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

namespace Google.Apis.Dataform.v1beta1
{
    /// <summary>The Dataform Service.</summary>
    public class DataformService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataformService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataformService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataform";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://dataform.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dataform.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Dataform API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Dataform API.</summary>
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

    /// <summary>A base abstract class for Dataform requests.</summary>
    public abstract class DataformBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataformBaseServiceRequest instance.</summary>
        protected DataformBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Dataform parameter list.</summary>
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
                Repositories = new RepositoriesResource(service);
            }

            /// <summary>Gets the Repositories resource.</summary>
            public virtual RepositoriesResource Repositories { get; }

            /// <summary>The "repositories" collection of methods.</summary>
            public class RepositoriesResource
            {
                private const string Resource = "repositories";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RepositoriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CompilationResults = new CompilationResultsResource(service);
                    ReleaseConfigs = new ReleaseConfigsResource(service);
                    WorkflowConfigs = new WorkflowConfigsResource(service);
                    WorkflowInvocations = new WorkflowInvocationsResource(service);
                    Workspaces = new WorkspacesResource(service);
                }

                /// <summary>Gets the CompilationResults resource.</summary>
                public virtual CompilationResultsResource CompilationResults { get; }

                /// <summary>The "compilationResults" collection of methods.</summary>
                public class CompilationResultsResource
                {
                    private const string Resource = "compilationResults";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CompilationResultsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new CompilationResult in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The repository in which to create the compilation result. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.CompilationResult body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new CompilationResult in a given project and location.</summary>
                    public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.CompilationResult>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.CompilationResult body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to create the compilation result. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.CompilationResult Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/compilationResults";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches a single CompilationResult.</summary>
                    /// <param name="name">Required. The compilation result's name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Fetches a single CompilationResult.</summary>
                    public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.CompilationResult>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The compilation result's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/compilationResults/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists CompilationResults in a given Repository.</summary>
                    /// <param name="parent">
                    /// Required. The repository in which to list compilation results. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists CompilationResults in a given Repository.</summary>
                    public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListCompilationResultsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to list compilation results. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of compilation results to return. The server may return fewer items
                        /// than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `ListCompilationResults` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListCompilationResults` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/compilationResults";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Returns CompilationResultActions in a given CompilationResult.</summary>
                    /// <param name="name">Required. The compilation result's name.</param>
                    public virtual QueryRequest Query(string name)
                    {
                        return new QueryRequest(service, name);
                    }

                    /// <summary>Returns CompilationResultActions in a given CompilationResult.</summary>
                    public class QueryRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.QueryCompilationResultActionsResponse>
                    {
                        /// <summary>Constructs a new Query request.</summary>
                        public QueryRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The compilation result's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Optional filter for the returned list. Filtering is only currently supported on
                        /// the `file_path` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of compilation results to return. The server may return fewer items
                        /// than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `QueryCompilationResultActions` call. Provide
                        /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `QueryCompilationResultActions` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "query";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:query";

                        /// <summary>Initializes Query parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/compilationResults/[^/]+$",
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

                /// <summary>Gets the ReleaseConfigs resource.</summary>
                public virtual ReleaseConfigsResource ReleaseConfigs { get; }

                /// <summary>The "releaseConfigs" collection of methods.</summary>
                public class ReleaseConfigsResource
                {
                    private const string Resource = "releaseConfigs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReleaseConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new ReleaseConfig in a given Repository.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The repository in which to create the release config. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.ReleaseConfig body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new ReleaseConfig in a given Repository.</summary>
                    public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ReleaseConfig>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.ReleaseConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to create the release config. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the release config, which will become the final component of the
                        /// release config's resource name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("releaseConfigId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReleaseConfigId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.ReleaseConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/releaseConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                            RequestParameters.Add("releaseConfigId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "releaseConfigId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single ReleaseConfig.</summary>
                    /// <param name="name">Required. The release config's name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single ReleaseConfig.</summary>
                    public class DeleteRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The release config's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/releaseConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches a single ReleaseConfig.</summary>
                    /// <param name="name">Required. The release config's name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Fetches a single ReleaseConfig.</summary>
                    public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ReleaseConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The release config's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/releaseConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists ReleaseConfigs in a given Repository.</summary>
                    /// <param name="parent">
                    /// Required. The repository in which to list release configs. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists ReleaseConfigs in a given Repository.</summary>
                    public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListReleaseConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to list release configs. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of release configs to return. The server may return fewer items
                        /// than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `ListReleaseConfigs` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListReleaseConfigs` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/releaseConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Updates a single ReleaseConfig.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. The release config's name.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dataform.v1beta1.Data.ReleaseConfig body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a single ReleaseConfig.</summary>
                    public class PatchRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ReleaseConfig>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.ReleaseConfig body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. The release config's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Specifies the fields to be updated in the release config. If left unset, all
                        /// fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.ReleaseConfig Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/releaseConfigs/[^/]+$",
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

                /// <summary>Gets the WorkflowConfigs resource.</summary>
                public virtual WorkflowConfigsResource WorkflowConfigs { get; }

                /// <summary>The "workflowConfigs" collection of methods.</summary>
                public class WorkflowConfigsResource
                {
                    private const string Resource = "workflowConfigs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WorkflowConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new WorkflowConfig in a given Repository.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The repository in which to create the workflow config. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.WorkflowConfig body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new WorkflowConfig in a given Repository.</summary>
                    public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WorkflowConfig>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.WorkflowConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to create the workflow config. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the workflow config, which will become the final component of
                        /// the workflow config's resource name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workflowConfigId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkflowConfigId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.WorkflowConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workflowConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                            RequestParameters.Add("workflowConfigId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workflowConfigId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single WorkflowConfig.</summary>
                    /// <param name="name">Required. The workflow config's name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single WorkflowConfig.</summary>
                    public class DeleteRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow config's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches a single WorkflowConfig.</summary>
                    /// <param name="name">Required. The workflow config's name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Fetches a single WorkflowConfig.</summary>
                    public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WorkflowConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow config's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists WorkflowConfigs in a given Repository.</summary>
                    /// <param name="parent">
                    /// Required. The repository in which to list workflow configs. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists WorkflowConfigs in a given Repository.</summary>
                    public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListWorkflowConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to list workflow configs. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of workflow configs to return. The server may return fewer items
                        /// than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `ListWorkflowConfigs` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListWorkflowConfigs` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workflowConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Updates a single WorkflowConfig.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. The workflow config's name.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dataform.v1beta1.Data.WorkflowConfig body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a single WorkflowConfig.</summary>
                    public class PatchRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WorkflowConfig>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.WorkflowConfig body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. The workflow config's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Specifies the fields to be updated in the workflow config. If left unset, all
                        /// fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.WorkflowConfig Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowConfigs/[^/]+$",
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

                /// <summary>Gets the WorkflowInvocations resource.</summary>
                public virtual WorkflowInvocationsResource WorkflowInvocations { get; }

                /// <summary>The "workflowInvocations" collection of methods.</summary>
                public class WorkflowInvocationsResource
                {
                    private const string Resource = "workflowInvocations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WorkflowInvocationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Requests cancellation of a running WorkflowInvocation.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The workflow invocation resource's name.</param>
                    public virtual CancelRequest Cancel(Google.Apis.Dataform.v1beta1.Data.CancelWorkflowInvocationRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>Requests cancellation of a running WorkflowInvocation.</summary>
                    public class CancelRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.CancelWorkflowInvocationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow invocation resource's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.CancelWorkflowInvocationRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowInvocations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Creates a new WorkflowInvocation in a given Repository.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The repository in which to create the workflow invocation. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.WorkflowInvocation body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new WorkflowInvocation in a given Repository.</summary>
                    public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WorkflowInvocation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.WorkflowInvocation body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to create the workflow invocation. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.WorkflowInvocation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workflowInvocations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a single WorkflowInvocation.</summary>
                    /// <param name="name">Required. The workflow invocation resource's name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single WorkflowInvocation.</summary>
                    public class DeleteRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow invocation resource's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowInvocations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches a single WorkflowInvocation.</summary>
                    /// <param name="name">Required. The workflow invocation resource's name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Fetches a single WorkflowInvocation.</summary>
                    public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WorkflowInvocation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow invocation resource's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowInvocations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists WorkflowInvocations in a given Repository.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource of the WorkflowInvocation type. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists WorkflowInvocations in a given Repository.</summary>
                    public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListWorkflowInvocationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the WorkflowInvocation type. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter for the returned list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. This field only supports ordering by `name`. If unspecified, the server will
                        /// choose the ordering. If specified, the default order is ascending for the `name` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of workflow invocations to return. The server may return fewer
                        /// items than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `ListWorkflowInvocations` call. Provide this
                        /// to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListWorkflowInvocations` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workflowInvocations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Returns WorkflowInvocationActions in a given WorkflowInvocation.</summary>
                    /// <param name="name">Required. The workflow invocation's name.</param>
                    public virtual QueryRequest Query(string name)
                    {
                        return new QueryRequest(service, name);
                    }

                    /// <summary>Returns WorkflowInvocationActions in a given WorkflowInvocation.</summary>
                    public class QueryRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.QueryWorkflowInvocationActionsResponse>
                    {
                        /// <summary>Constructs a new Query request.</summary>
                        public QueryRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workflow invocation's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of workflow invocations to return. The server may return fewer
                        /// items than requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `QueryWorkflowInvocationActions` call. Provide
                        /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `QueryWorkflowInvocationActions` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "query";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:query";

                        /// <summary>Initializes Query parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workflowInvocations/[^/]+$",
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

                /// <summary>Gets the Workspaces resource.</summary>
                public virtual WorkspacesResource Workspaces { get; }

                /// <summary>The "workspaces" collection of methods.</summary>
                public class WorkspacesResource
                {
                    private const string Resource = "workspaces";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WorkspacesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Applies a Git commit for uncommitted files in a Workspace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual CommitRequest Commit(Google.Apis.Dataform.v1beta1.Data.CommitWorkspaceChangesRequest body, string name)
                    {
                        return new CommitRequest(service, body, name);
                    }

                    /// <summary>Applies a Git commit for uncommitted files in a Workspace.</summary>
                    public class CommitRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Commit request.</summary>
                        public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.CommitWorkspaceChangesRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.CommitWorkspaceChangesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "commit";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:commit";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Creates a new Workspace in a given Repository.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The repository in which to create the workspace. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.Workspace body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new Workspace in a given Repository.</summary>
                    public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Workspace>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.Workspace body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to create the workspace. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the workspace, which will become the final component of the
                        /// workspace's resource name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspaceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkspaceId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.Workspace Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workspaces";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                            RequestParameters.Add("workspaceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspaceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single Workspace.</summary>
                    /// <param name="name">Required. The workspace resource's name.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single Workspace.</summary>
                    public class DeleteRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace resource's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches Git diff for an uncommitted file in a Workspace.</summary>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual FetchFileDiffRequest FetchFileDiff(string workspace)
                    {
                        return new FetchFileDiffRequest(service, workspace);
                    }

                    /// <summary>Fetches Git diff for an uncommitted file in a Workspace.</summary>
                    public class FetchFileDiffRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.FetchFileDiffResponse>
                    {
                        /// <summary>Constructs a new FetchFileDiff request.</summary>
                        public FetchFileDiffRequest(Google.Apis.Services.IClientService service, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>
                        /// Required. The file's full path including filename, relative to the workspace root.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Path { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchFileDiff";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:fetchFileDiff";

                        /// <summary>Initializes FetchFileDiff parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                            RequestParameters.Add("path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Fetches Git statuses for the files in a Workspace.</summary>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual FetchFileGitStatusesRequest FetchFileGitStatuses(string name)
                    {
                        return new FetchFileGitStatusesRequest(service, name);
                    }

                    /// <summary>Fetches Git statuses for the files in a Workspace.</summary>
                    public class FetchFileGitStatusesRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.FetchFileGitStatusesResponse>
                    {
                        /// <summary>Constructs a new FetchFileGitStatuses request.</summary>
                        public FetchFileGitStatusesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchFileGitStatuses";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:fetchFileGitStatuses";

                        /// <summary>Initializes FetchFileGitStatuses parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches Git ahead/behind against a remote branch.</summary>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual FetchGitAheadBehindRequest FetchGitAheadBehind(string name)
                    {
                        return new FetchGitAheadBehindRequest(service, name);
                    }

                    /// <summary>Fetches Git ahead/behind against a remote branch.</summary>
                    public class FetchGitAheadBehindRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.FetchGitAheadBehindResponse>
                    {
                        /// <summary>Constructs a new FetchGitAheadBehind request.</summary>
                        public FetchGitAheadBehindRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The name of the branch in the Git remote against which this workspace should be
                        /// compared. If left unset, the repository's default branch name will be used.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("remoteBranch", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RemoteBranch { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchGitAheadBehind";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:fetchGitAheadBehind";

                        /// <summary>Initializes FetchGitAheadBehind parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                            RequestParameters.Add("remoteBranch", new Google.Apis.Discovery.Parameter
                            {
                                Name = "remoteBranch",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Fetches a single Workspace.</summary>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Fetches a single Workspace.</summary>
                    public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Workspace>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Installs dependency NPM packages (inside a Workspace).</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual InstallNpmPackagesRequest InstallNpmPackages(Google.Apis.Dataform.v1beta1.Data.InstallNpmPackagesRequest body, string workspace)
                    {
                        return new InstallNpmPackagesRequest(service, body, workspace);
                    }

                    /// <summary>Installs dependency NPM packages (inside a Workspace).</summary>
                    public class InstallNpmPackagesRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.InstallNpmPackagesResponse>
                    {
                        /// <summary>Constructs a new InstallNpmPackages request.</summary>
                        public InstallNpmPackagesRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.InstallNpmPackagesRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.InstallNpmPackagesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "installNpmPackages";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:installNpmPackages";

                        /// <summary>Initializes InstallNpmPackages parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Workspaces in a given Repository.</summary>
                    /// <param name="parent">
                    /// Required. The repository in which to list workspaces. Must be in the format
                    /// `projects/*/locations/*/repositories/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists Workspaces in a given Repository.</summary>
                    public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListWorkspacesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The repository in which to list workspaces. Must be in the format
                        /// `projects/*/locations/*/repositories/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filter for the returned list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. This field only supports ordering by `name`. If unspecified, the server will
                        /// choose the ordering. If specified, the default order is ascending for the `name` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Maximum number of workspaces to return. The server may return fewer items than
                        /// requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `ListWorkspaces` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListWorkspaces` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/workspaces";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Creates a directory inside a Workspace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual MakeDirectoryRequest MakeDirectory(Google.Apis.Dataform.v1beta1.Data.MakeDirectoryRequest body, string workspace)
                    {
                        return new MakeDirectoryRequest(service, body, workspace);
                    }

                    /// <summary>Creates a directory inside a Workspace.</summary>
                    public class MakeDirectoryRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.MakeDirectoryResponse>
                    {
                        /// <summary>Constructs a new MakeDirectory request.</summary>
                        public MakeDirectoryRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.MakeDirectoryRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.MakeDirectoryRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "makeDirectory";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:makeDirectory";

                        /// <summary>Initializes MakeDirectory parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Moves a directory (inside a Workspace), and all of its contents, to a new location.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual MoveDirectoryRequest MoveDirectory(Google.Apis.Dataform.v1beta1.Data.MoveDirectoryRequest body, string workspace)
                    {
                        return new MoveDirectoryRequest(service, body, workspace);
                    }

                    /// <summary>
                    /// Moves a directory (inside a Workspace), and all of its contents, to a new location.
                    /// </summary>
                    public class MoveDirectoryRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.MoveDirectoryResponse>
                    {
                        /// <summary>Constructs a new MoveDirectory request.</summary>
                        public MoveDirectoryRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.MoveDirectoryRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.MoveDirectoryRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "moveDirectory";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:moveDirectory";

                        /// <summary>Initializes MoveDirectory parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Moves a file (inside a Workspace) to a new location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual MoveFileRequest MoveFile(Google.Apis.Dataform.v1beta1.Data.MoveFileRequest body, string workspace)
                    {
                        return new MoveFileRequest(service, body, workspace);
                    }

                    /// <summary>Moves a file (inside a Workspace) to a new location.</summary>
                    public class MoveFileRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.MoveFileResponse>
                    {
                        /// <summary>Constructs a new MoveFile request.</summary>
                        public MoveFileRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.MoveFileRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.MoveFileRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "moveFile";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:moveFile";

                        /// <summary>Initializes MoveFile parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Pulls Git commits from the Repository's remote into a Workspace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual PullRequest Pull(Google.Apis.Dataform.v1beta1.Data.PullGitCommitsRequest body, string name)
                    {
                        return new PullRequest(service, body, name);
                    }

                    /// <summary>Pulls Git commits from the Repository's remote into a Workspace.</summary>
                    public class PullRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Pull request.</summary>
                        public PullRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.PullGitCommitsRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.PullGitCommitsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "pull";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:pull";

                        /// <summary>Initializes Pull parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Pushes Git commits from a Workspace to the Repository's remote.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual PushRequest Push(Google.Apis.Dataform.v1beta1.Data.PushGitCommitsRequest body, string name)
                    {
                        return new PushRequest(service, body, name);
                    }

                    /// <summary>Pushes Git commits from a Workspace to the Repository's remote.</summary>
                    public class PushRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Push request.</summary>
                        public PushRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.PushGitCommitsRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.PushGitCommitsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "push";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:push";

                        /// <summary>Initializes Push parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the contents of a given Workspace directory.</summary>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual QueryDirectoryContentsRequest QueryDirectoryContents(string workspace)
                    {
                        return new QueryDirectoryContentsRequest(service, workspace);
                    }

                    /// <summary>Returns the contents of a given Workspace directory.</summary>
                    public class QueryDirectoryContentsRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.QueryDirectoryContentsResponse>
                    {
                        /// <summary>Constructs a new QueryDirectoryContents request.</summary>
                        public QueryDirectoryContentsRequest(Google.Apis.Services.IClientService service, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>
                        /// Optional. Maximum number of paths to return. The server may return fewer items than
                        /// requested. If unspecified, the server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Page token received from a previous `QueryDirectoryContents` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `QueryDirectoryContents` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. The directory's full path including directory name, relative to the workspace
                        /// root. If left unset, the workspace root is used.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Path { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "queryDirectoryContents";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:queryDirectoryContents";

                        /// <summary>Initializes QueryDirectoryContents parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
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
                            RequestParameters.Add("path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns the contents of a file (inside a Workspace).</summary>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual ReadFileRequest ReadFile(string workspace)
                    {
                        return new ReadFileRequest(service, workspace);
                    }

                    /// <summary>Returns the contents of a file (inside a Workspace).</summary>
                    public class ReadFileRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ReadFileResponse>
                    {
                        /// <summary>Constructs a new ReadFile request.</summary>
                        public ReadFileRequest(Google.Apis.Services.IClientService service, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>
                        /// Required. The file's full path including filename, relative to the workspace root.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Path { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "readFile";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:readFile";

                        /// <summary>Initializes ReadFile parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                            RequestParameters.Add("path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a directory (inside a Workspace) and all of its contents.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual RemoveDirectoryRequest RemoveDirectory(Google.Apis.Dataform.v1beta1.Data.RemoveDirectoryRequest body, string workspace)
                    {
                        return new RemoveDirectoryRequest(service, body, workspace);
                    }

                    /// <summary>Deletes a directory (inside a Workspace) and all of its contents.</summary>
                    public class RemoveDirectoryRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new RemoveDirectory request.</summary>
                        public RemoveDirectoryRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.RemoveDirectoryRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.RemoveDirectoryRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "removeDirectory";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:removeDirectory";

                        /// <summary>Initializes RemoveDirectory parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a file (inside a Workspace).</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual RemoveFileRequest RemoveFile(Google.Apis.Dataform.v1beta1.Data.RemoveFileRequest body, string workspace)
                    {
                        return new RemoveFileRequest(service, body, workspace);
                    }

                    /// <summary>Deletes a file (inside a Workspace).</summary>
                    public class RemoveFileRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new RemoveFile request.</summary>
                        public RemoveFileRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.RemoveFileRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.RemoveFileRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "removeFile";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:removeFile";

                        /// <summary>Initializes RemoveFile parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Performs a Git reset for uncommitted files in a Workspace.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The workspace's name.</param>
                    public virtual ResetRequest Reset(Google.Apis.Dataform.v1beta1.Data.ResetWorkspaceChangesRequest body, string name)
                    {
                        return new ResetRequest(service, body, name);
                    }

                    /// <summary>Performs a Git reset for uncommitted files in a Workspace.</summary>
                    public class ResetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Reset request.</summary>
                        public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.ResetWorkspaceChangesRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.ResetWorkspaceChangesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "reset";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:reset";

                        /// <summary>Initializes Reset parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Writes to a file (inside a Workspace).</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="workspace">Required. The workspace's name.</param>
                    public virtual WriteFileRequest WriteFile(Google.Apis.Dataform.v1beta1.Data.WriteFileRequest body, string workspace)
                    {
                        return new WriteFileRequest(service, body, workspace);
                    }

                    /// <summary>Writes to a file (inside a Workspace).</summary>
                    public class WriteFileRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.WriteFileResponse>
                    {
                        /// <summary>Constructs a new WriteFile request.</summary>
                        public WriteFileRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.WriteFileRequest body, string workspace) : base(service)
                        {
                            Workspace = workspace;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The workspace's name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workspace", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Workspace { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataform.v1beta1.Data.WriteFileRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "writeFile";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+workspace}:writeFile";

                        /// <summary>Initializes WriteFile parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("workspace", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workspace",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/workspaces/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new Repository in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location in which to create the repository. Must be in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataform.v1beta1.Data.Repository body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Repository in a given project and location.</summary>
                public class CreateRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Repository>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.Repository body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location in which to create the repository. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the repository, which will become the final component of the
                    /// repository's resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("repositoryId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RepositoryId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataform.v1beta1.Data.Repository Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/repositories";

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
                        RequestParameters.Add("repositoryId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "repositoryId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Repository.</summary>
                /// <param name="name">Required. The repository's name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Repository.</summary>
                public class DeleteRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The repository's name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, any child resources of this repository will also be deleted. (Otherwise, the
                    /// request will only succeed if the repository has no child resources.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Fetches a Repository's remote branches.</summary>
                /// <param name="name">Required. The repository's name.</param>
                public virtual FetchRemoteBranchesRequest FetchRemoteBranches(string name)
                {
                    return new FetchRemoteBranchesRequest(service, name);
                }

                /// <summary>Fetches a Repository's remote branches.</summary>
                public class FetchRemoteBranchesRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.FetchRemoteBranchesResponse>
                {
                    /// <summary>Constructs a new FetchRemoteBranches request.</summary>
                    public FetchRemoteBranchesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The repository's name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchRemoteBranches";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:fetchRemoteBranches";

                    /// <summary>Initializes FetchRemoteBranches parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                        });
                    }
                }

                /// <summary>Fetches a single Repository.</summary>
                /// <param name="name">Required. The repository's name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Fetches a single Repository.</summary>
                public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Repository>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The repository's name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Repositories in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The location in which to list repositories. Must be in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Repositories in a given project and location.</summary>
                public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListRepositoriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location in which to list repositories. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filter for the returned list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. This field only supports ordering by `name`. If unspecified, the server will choose
                    /// the ordering. If specified, the default order is ascending for the `name` field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Maximum number of repositories to return. The server may return fewer items than
                    /// requested. If unspecified, the server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Page token received from a previous `ListRepositories` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListRepositories` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/repositories";

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

                /// <summary>Updates a single Repository.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The repository's name.</param>
                public virtual PatchRequest Patch(Google.Apis.Dataform.v1beta1.Data.Repository body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a single Repository.</summary>
                public class PatchRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Repository>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataform.v1beta1.Data.Repository body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The repository's name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Specifies the fields to be updated in the repository. If left unset, all fields will
                    /// be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataform.v1beta1.Data.Repository Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.Location>
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
            public class ListRequest : DataformBaseServiceRequest<Google.Apis.Dataform.v1beta1.Data.ListLocationsResponse>
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

                /// <summary>If true, the returned list will include locations which are not yet revealed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUnrevealedLocations", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUnrevealedLocations { get; set; }

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
                    RequestParameters.Add("includeUnrevealedLocations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUnrevealedLocations",
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
namespace Google.Apis.Dataform.v1beta1.Data
{
    /// <summary>Represents an assertion upon a SQL query which is required return zero rows.</summary>
    public class Assertion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of actions that this action depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencyTargets")]
        public virtual System.Collections.Generic.IList<Target> DependencyTargets { get; set; }

        /// <summary>Whether this action is disabled (i.e. should not be run).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// The parent action of this assertion. Only set if this assertion was automatically generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentAction")]
        public virtual Target ParentAction { get; set; }

        /// <summary>Descriptor for the assertion's automatically-generated view and its columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationDescriptor")]
        public virtual RelationDescriptor RelationDescriptor { get; set; }

        /// <summary>The SELECT query which must return zero rows in order for this assertion to succeed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectQuery")]
        public virtual string SelectQuery { get; set; }

        /// <summary>Arbitrary, user-defined tags on this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a workflow action that will run against BigQuery.</summary>
    public class BigQueryAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The generated BigQuery SQL script that will be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlScript")]
        public virtual string SqlScript { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`CancelWorkflowInvocation` request message.</summary>
    public class CancelWorkflowInvocationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures various aspects of Dataform code compilation.</summary>
    public class CodeCompilationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The default schema (BigQuery dataset ID) for assertions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertionSchema")]
        public virtual string AssertionSchema { get; set; }

        /// <summary>
        /// Optional. The suffix that should be appended to all database (Google Cloud project ID) names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseSuffix")]
        public virtual string DatabaseSuffix { get; set; }

        /// <summary>Optional. The default database (Google Cloud project ID).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultDatabase")]
        public virtual string DefaultDatabase { get; set; }

        /// <summary>
        /// Optional. The default BigQuery location to use. Defaults to "US". See the BigQuery docs for a full list of
        /// locations: https://cloud.google.com/bigquery/docs/locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLocation")]
        public virtual string DefaultLocation { get; set; }

        /// <summary>Optional. The default schema (BigQuery dataset ID).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSchema")]
        public virtual string DefaultSchema { get; set; }

        /// <summary>Optional. The suffix that should be appended to all schema (BigQuery dataset ID) names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaSuffix")]
        public virtual string SchemaSuffix { get; set; }

        /// <summary>Optional. The prefix that should be prepended to all table names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tablePrefix")]
        public virtual string TablePrefix { get; set; }

        /// <summary>
        /// Optional. User-defined variables that are made available to project code during compilation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vars")]
        public virtual System.Collections.Generic.IDictionary<string, string> Vars { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a column.</summary>
    public class ColumnDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of BigQuery policy tags that will be applied to the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryPolicyTags")]
        public virtual System.Collections.Generic.IList<string> BigqueryPolicyTags { get; set; }

        /// <summary>A textual description of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The identifier for the column. Each entry in `path` represents one level of nesting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the author of a Git commit.</summary>
    public class CommitAuthor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The commit author's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Required. The commit author's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`CommitWorkspaceChanges` request message.</summary>
    public class CommitWorkspaceChangesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The commit's author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual CommitAuthor Author { get; set; }

        /// <summary>Optional. The commit's message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitMessage")]
        public virtual string CommitMessage { get; set; }

        /// <summary>
        /// Optional. Full file paths to commit including filename, rooted at workspace root. If left empty, all files
        /// will be committed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error encountered when attempting to compile a Dataform project.</summary>
    public class CompilationError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The identifier of the action where this error occurred, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionTarget")]
        public virtual Target ActionTarget { get; set; }

        /// <summary>Output only. The error's top level message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Output only. The path of the file where this error occurred, if available, relative to the project root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Output only. The error's full stack trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stack")]
        public virtual string Stack { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of compiling a Dataform project.</summary>
    public class CompilationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. If set, fields of `code_compilation_config` override the default compilation settings that are
        /// specified in dataform.json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeCompilationConfig")]
        public virtual CodeCompilationConfig CodeCompilationConfig { get; set; }

        /// <summary>Output only. Errors encountered during project compilation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilationErrors")]
        public virtual System.Collections.Generic.IList<CompilationError> CompilationErrors { get; set; }

        /// <summary>Output only. The version of `@dataform/core` that was used for compilation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataformCoreVersion")]
        public virtual string DataformCoreVersion { get; set; }

        /// <summary>
        /// Immutable. Git commit/tag/branch name at which the repository should be compiled. Must exist in the remote
        /// repository. Examples: - a commit SHA: `12ade345` - a tag: `tag1` - a branch name: `branch1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitCommitish")]
        public virtual string GitCommitish { get; set; }

        /// <summary>Output only. The compilation result's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The name of the release config to compile. The release config's 'current_compilation_result'
        /// field will be updated to this compilation result. Must be in the format
        /// `projects/*/locations/*/repositories/*/releaseConfigs/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseConfig")]
        public virtual string ReleaseConfig { get; set; }

        /// <summary>
        /// Output only. The fully resolved Git commit SHA of the code that was compiled. Not set for compilation
        /// results whose source is a workspace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedGitCommitSha")]
        public virtual string ResolvedGitCommitSha { get; set; }

        /// <summary>
        /// Immutable. The name of the workspace to compile. Must be in the format
        /// `projects/*/locations/*/repositories/*/workspaces/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspace")]
        public virtual string Workspace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single Dataform action in a compilation result.</summary>
    public class CompilationResultAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assertion executed by this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertion")]
        public virtual Assertion Assertion { get; set; }

        /// <summary>
        /// The action's identifier if the project had been compiled without any overrides configured. Unique within the
        /// compilation result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalTarget")]
        public virtual Target CanonicalTarget { get; set; }

        /// <summary>The declaration declared by this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("declaration")]
        public virtual Declaration Declaration { get; set; }

        /// <summary>
        /// The full path including filename in which this action is located, relative to the workspace root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The database operations executed by this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual Operations Operations { get; set; }

        /// <summary>The database relation created/updated by this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual Relation Relation { get; set; }

        /// <summary>This action's identifier. Unique within the compilation result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Target Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a relation which is not managed by Dataform but which may be referenced by Dataform actions.
    /// </summary>
    public class Declaration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Descriptor for the relation and its columns. Used as documentation only, i.e. values here will result in no
        /// changes to the relation's metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationDescriptor")]
        public virtual RelationDescriptor RelationDescriptor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single entry in a workspace directory.</summary>
    public class DirectoryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A child directory in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directory")]
        public virtual string Directory { get; set; }

        /// <summary>A file in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

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

    /// <summary>`FetchFileDiff` response message.</summary>
    public class FetchFileDiffResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The raw formatted Git diff for the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedDiff")]
        public virtual string FormattedDiff { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`FetchFileGitStatuses` response message.</summary>
    public class FetchFileGitStatusesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of all files which have uncommitted Git changes. There will only be a single entry for any given
        /// file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncommittedFileChanges")]
        public virtual System.Collections.Generic.IList<UncommittedFileChange> UncommittedFileChanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`FetchGitAheadBehind` response message.</summary>
    public class FetchGitAheadBehindResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of commits in the remote branch that are not in the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitsAhead")]
        public virtual System.Nullable<int> CommitsAhead { get; set; }

        /// <summary>The number of commits in the workspace that are not in the remote branch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitsBehind")]
        public virtual System.Nullable<int> CommitsBehind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`FetchRemoteBranches` response message.</summary>
    public class FetchRemoteBranchesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The remote repository's branch names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branches")]
        public virtual System.Collections.Generic.IList<string> Branches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Controls Git remote configuration for a repository.</summary>
    public class GitRemoteSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the Secret Manager secret version to use as an authentication token for Git
        /// operations. Must be in the format `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationTokenSecretVersion")]
        public virtual string AuthenticationTokenSecretVersion { get; set; }

        /// <summary>Required. The Git remote's default branch name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultBranch")]
        public virtual string DefaultBranch { get; set; }

        /// <summary>Output only. Indicates the status of the Git access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenStatus")]
        public virtual string TokenStatus { get; set; }

        /// <summary>Required. The Git remote's URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains settings for relations of type `INCREMENTAL_TABLE`.</summary>
    public class IncrementalTableConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SQL statements to be executed after inserting new rows into the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalPostOperations")]
        public virtual System.Collections.Generic.IList<string> IncrementalPostOperations { get; set; }

        /// <summary>SQL statements to be executed before inserting new rows into the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalPreOperations")]
        public virtual System.Collections.Generic.IList<string> IncrementalPreOperations { get; set; }

        /// <summary>
        /// The SELECT query which returns rows which should be inserted into the relation if it already exists and is
        /// not being refreshed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalSelectQuery")]
        public virtual string IncrementalSelectQuery { get; set; }

        /// <summary>Whether this table should be protected from being refreshed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshDisabled")]
        public virtual System.Nullable<bool> RefreshDisabled { get; set; }

        /// <summary>
        /// A set of columns or SQL expressions used to define row uniqueness. If any duplicates are discovered (as
        /// defined by `unique_key_parts`), only the newly selected rows (as defined by `incremental_select_query`) will
        /// be included in the relation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueKeyParts")]
        public virtual System.Collections.Generic.IList<string> UniqueKeyParts { get; set; }

        /// <summary>
        /// A SQL expression conditional used to limit the set of existing rows considered for a merge operation (see
        /// `unique_key_parts` for more information).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePartitionFilter")]
        public virtual string UpdatePartitionFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`InstallNpmPackages` request message.</summary>
    public class InstallNpmPackagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`InstallNpmPackages` response message.</summary>
    public class InstallNpmPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Includes various configuration options for a workflow invocation. If both `included_targets` and `included_tags`
    /// are unset, all actions will be included.
    /// </summary>
    public class InvocationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. When set to true, any incremental tables will be fully refreshed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyRefreshIncrementalTablesEnabled")]
        public virtual System.Nullable<bool> FullyRefreshIncrementalTablesEnabled { get; set; }

        /// <summary>Optional. The set of tags to include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedTags")]
        public virtual System.Collections.Generic.IList<string> IncludedTags { get; set; }

        /// <summary>Optional. The set of action identifiers to include.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedTargets")]
        public virtual System.Collections.Generic.IList<Target> IncludedTargets { get; set; }

        /// <summary>Optional. When set to true, transitive dependencies of included actions will be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitiveDependenciesIncluded")]
        public virtual System.Nullable<bool> TransitiveDependenciesIncluded { get; set; }

        /// <summary>Optional. When set to true, transitive dependents of included actions will be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitiveDependentsIncluded")]
        public virtual System.Nullable<bool> TransitiveDependentsIncluded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListCompilationResults` response message.</summary>
    public class ListCompilationResultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of compilation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilationResults")]
        public virtual System.Collections.Generic.IList<CompilationResult> CompilationResults { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations which could not be reached.</summary>
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

    /// <summary>`ListReleaseConfigs` response message.</summary>
    public class ListReleaseConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of release configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseConfigs")]
        public virtual System.Collections.Generic.IList<ReleaseConfig> ReleaseConfigs { get; set; }

        /// <summary>Locations which could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListRepositories` response message.</summary>
    public class ListRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of repositories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositories")]
        public virtual System.Collections.Generic.IList<Repository> Repositories { get; set; }

        /// <summary>Locations which could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListWorkflowConfigs` response message.</summary>
    public class ListWorkflowConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations which could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of workflow configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowConfigs")]
        public virtual System.Collections.Generic.IList<WorkflowConfig> WorkflowConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListWorkflowInvocations` response message.</summary>
    public class ListWorkflowInvocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations which could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of workflow invocations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowInvocations")]
        public virtual System.Collections.Generic.IList<WorkflowInvocation> WorkflowInvocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListWorkspaces` response message.</summary>
    public class ListWorkspacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations which could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of workspaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaces")]
        public virtual System.Collections.Generic.IList<Workspace> Workspaces { get; set; }

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

    /// <summary>`MakeDirectory` request message.</summary>
    public class MakeDirectoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The directory's full path including directory name, relative to the workspace root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`MakeDirectory` response message.</summary>
    public class MakeDirectoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`MoveDirectory` request message.</summary>
    public class MoveDirectoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The new path for the directory including directory name, rooted at workspace root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPath")]
        public virtual string NewPath { get; set; }

        /// <summary>
        /// Required. The directory's full path including directory name, relative to the workspace root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`MoveDirectory` response message.</summary>
    public class MoveDirectoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`MoveFile` request message.</summary>
    public class MoveFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The file's new path including filename, relative to the workspace root.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPath")]
        public virtual string NewPath { get; set; }

        /// <summary>Required. The file's full path including filename, relative to the workspace root.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`MoveFile` response message.</summary>
    public class MoveFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
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

    /// <summary>Represents a list of arbitrary database operations.</summary>
    public class Operations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of actions that this action depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencyTargets")]
        public virtual System.Collections.Generic.IList<Target> DependencyTargets { get; set; }

        /// <summary>Whether this action is disabled (i.e. should not be run).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Whether these operations produce an output relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasOutput")]
        public virtual System.Nullable<bool> HasOutput { get; set; }

        /// <summary>A list of arbitrary SQL statements that will be executed without alteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<string> Queries { get; set; }

        /// <summary>Descriptor for any output relation and its columns. Only set if `has_output` is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationDescriptor")]
        public virtual RelationDescriptor RelationDescriptor { get; set; }

        /// <summary>Arbitrary, user-defined tags on this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`PullGitCommits` request message.</summary>
    public class PullGitCommitsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The author of any merge commit which may be created as a result of merging fetched Git commits
        /// into this workspace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual CommitAuthor Author { get; set; }

        /// <summary>
        /// Optional. The name of the branch in the Git remote from which to pull commits. If left unset, the
        /// repository's default branch name will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteBranch")]
        public virtual string RemoteBranch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`PushGitCommits` request message.</summary>
    public class PushGitCommitsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the branch in the Git remote to which commits should be pushed. If left unset, the
        /// repository's default branch name will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteBranch")]
        public virtual string RemoteBranch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`QueryCompilationResultActions` response message.</summary>
    public class QueryCompilationResultActionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of compilation result actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilationResultActions")]
        public virtual System.Collections.Generic.IList<CompilationResultAction> CompilationResultActions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`QueryDirectoryContents` response message.</summary>
    public class QueryDirectoryContentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of entries in the directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoryEntries")]
        public virtual System.Collections.Generic.IList<DirectoryEntry> DirectoryEntries { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`QueryWorkflowInvocationActions` response message.</summary>
    public class QueryWorkflowInvocationActionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of workflow invocation actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowInvocationActions")]
        public virtual System.Collections.Generic.IList<WorkflowInvocationAction> WorkflowInvocationActions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ReadFile` response message.</summary>
    public class ReadFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The file's contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileContents")]
        public virtual string FileContents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a database relation.</summary>
    public class Relation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional options that will be provided as key/value pairs into the options clause of a create table/view
        /// statement. See https://cloud.google.com/bigquery/docs/reference/standard-sql/data-definition-language for
        /// more information on which options are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalOptions { get; set; }

        /// <summary>A list of columns or SQL expressions used to cluster the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterExpressions")]
        public virtual System.Collections.Generic.IList<string> ClusterExpressions { get; set; }

        /// <summary>A list of actions that this action depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencyTargets")]
        public virtual System.Collections.Generic.IList<Target> DependencyTargets { get; set; }

        /// <summary>Whether this action is disabled (i.e. should not be run).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Configures `INCREMENTAL_TABLE` settings for this relation. Only set if `relation_type` is
        /// `INCREMENTAL_TABLE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incrementalTableConfig")]
        public virtual IncrementalTableConfig IncrementalTableConfig { get; set; }

        /// <summary>Sets the partition expiration in days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionExpirationDays")]
        public virtual System.Nullable<int> PartitionExpirationDays { get; set; }

        /// <summary>The SQL expression used to partition the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionExpression")]
        public virtual string PartitionExpression { get; set; }

        /// <summary>SQL statements to be executed after creating the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postOperations")]
        public virtual System.Collections.Generic.IList<string> PostOperations { get; set; }

        /// <summary>SQL statements to be executed before creating the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preOperations")]
        public virtual System.Collections.Generic.IList<string> PreOperations { get; set; }

        /// <summary>Descriptor for the relation and its columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationDescriptor")]
        public virtual RelationDescriptor RelationDescriptor { get; set; }

        /// <summary>The type of this relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationType")]
        public virtual string RelationType { get; set; }

        /// <summary>
        /// Specifies whether queries on this table must include a predicate filter that filters on the partitioning
        /// column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePartitionFilter")]
        public virtual System.Nullable<bool> RequirePartitionFilter { get; set; }

        /// <summary>The SELECT query which returns rows which this relation should contain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectQuery")]
        public virtual string SelectQuery { get; set; }

        /// <summary>Arbitrary, user-defined tags on this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a relation and its columns.</summary>
    public class RelationDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of BigQuery labels that should be applied to the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> BigqueryLabels { get; set; }

        /// <summary>A list of descriptions of columns within the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<ColumnDescriptor> Columns { get; set; }

        /// <summary>A text description of the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Dataform release configuration.</summary>
    public class ReleaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set, fields of `code_compilation_config` override the default compilation settings that are
        /// specified in dataform.json.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeCompilationConfig")]
        public virtual CodeCompilationConfig CodeCompilationConfig { get; set; }

        /// <summary>
        /// Optional. Optional schedule (in cron format) for automatic creation of compilation results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>
        /// Required. Git commit/tag/branch name at which the repository should be compiled. Must exist in the remote
        /// repository. Examples: - a commit SHA: `12ade345` - a tag: `tag1` - a branch name: `branch1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitCommitish")]
        public virtual string GitCommitish { get; set; }

        /// <summary>Output only. The release config's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Records of the 10 most recent scheduled release attempts. Updated whenever automatic creation
        /// of a compilation result is triggered by cron_schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentScheduledReleaseRecords")]
        public virtual System.Collections.Generic.IList<ScheduledReleaseRecord> RecentScheduledReleaseRecords { get; set; }

        /// <summary>
        /// Optional. The name of the currently released compilation result for this release config. This value is
        /// updated when a compilation result is created from this release config, or when this resource is updated by
        /// API call (perhaps to roll back to an earlier release). The compilation result must have been created using
        /// this release config. Must be in the format `projects/*/locations/*/repositories/*/compilationResults/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseCompilationResult")]
        public virtual string ReleaseCompilationResult { get; set; }

        /// <summary>
        /// Optional. Specifies the time zone to be used when interpreting cron_schedule. Must be a time zone name from
        /// the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). If left unspecified,
        /// the default is UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`RemoveDirectory` request message.</summary>
    public class RemoveDirectoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The directory's full path including directory name, relative to the workspace root.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`RemoveFile` request message.</summary>
    public class RemoveFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The file's full path including filename, relative to the workspace root.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Dataform Git repository.</summary>
    public class Repository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, configures this repository to be linked to a Git remote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitRemoteSettings")]
        public virtual GitRemoteSettings GitRemoteSettings { get; set; }

        /// <summary>Output only. The repository's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The name of the Secret Manager secret version to be used to interpolate variables into the .npmrc
        /// file for package installation operations. Must be in the format `projects/*/secrets/*/versions/*`. The file
        /// itself must be in a JSON format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmrcEnvironmentVariablesSecretVersion")]
        public virtual string NpmrcEnvironmentVariablesSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ResetWorkspaceChanges` request message.</summary>
    public class ResetWorkspaceChangesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, untracked files will be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clean")]
        public virtual System.Nullable<bool> Clean { get; set; }

        /// <summary>
        /// Optional. Full file paths to reset back to their committed state including filename, rooted at workspace
        /// root. If left empty, all files will be reset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A record of an attempt to create a workflow invocation for this workflow config.</summary>
    public class ScheduledExecutionRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The error status encountered upon this attempt to create the workflow invocation, if the attempt was
        /// unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorStatus")]
        public virtual Status ErrorStatus { get; set; }

        /// <summary>The timestamp of this execution attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTime")]
        public virtual object ExecutionTime { get; set; }

        /// <summary>
        /// The name of the created workflow invocation, if one was successfully created. Must be in the format
        /// `projects/*/locations/*/repositories/*/workflowInvocations/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowInvocation")]
        public virtual string WorkflowInvocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A record of an attempt to create a compilation result for this release config.</summary>
    public class ScheduledReleaseRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the created compilation result, if one was successfully created. Must be in the format
        /// `projects/*/locations/*/repositories/*/compilationResults/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilationResult")]
        public virtual string CompilationResult { get; set; }

        /// <summary>
        /// The error status encountered upon this attempt to create the compilation result, if the attempt was
        /// unsuccessful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorStatus")]
        public virtual Status ErrorStatus { get; set; }

        /// <summary>The timestamp of this release attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseTime")]
        public virtual object ReleaseTime { get; set; }

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
    /// Represents an action identifier. If the action writes output, the output will be written to the referenced
    /// database object.
    /// </summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action's database (Google Cloud project ID) .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>The action's name, within `database` and `schema`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The action's schema (BigQuery dataset ID), within `database`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the Git state of a file with uncommitted changes.</summary>
    public class UncommittedFileChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The file's full path including filename, relative to the workspace root.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Indicates the status of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Dataform workflow configuration.</summary>
    public class WorkflowConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional schedule (in cron format) for automatic execution of this workflow config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>Optional. If left unset, a default InvocationConfig will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationConfig")]
        public virtual InvocationConfig InvocationConfig { get; set; }

        /// <summary>Output only. The workflow config's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Records of the 10 most recent scheduled execution attempts. Updated whenever automatic creation
        /// of a compilation result is triggered by cron_schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentScheduledExecutionRecords")]
        public virtual System.Collections.Generic.IList<ScheduledExecutionRecord> RecentScheduledExecutionRecords { get; set; }

        /// <summary>
        /// Required. The name of the release config whose release_compilation_result should be executed. Must be in the
        /// format `projects/*/locations/*/repositories/*/releaseConfigs/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseConfig")]
        public virtual string ReleaseConfig { get; set; }

        /// <summary>
        /// Optional. Specifies the time zone to be used when interpreting cron_schedule. Must be a time zone name from
        /// the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). If left unspecified,
        /// the default is UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single invocation of a compilation result.</summary>
    public class WorkflowInvocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The name of the compilation result to compile. Must be in the format
        /// `projects/*/locations/*/repositories/*/compilationResults/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilationResult")]
        public virtual string CompilationResult { get; set; }

        /// <summary>Immutable. If left unset, a default InvocationConfig will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationConfig")]
        public virtual InvocationConfig InvocationConfig { get; set; }

        /// <summary>Output only. This workflow invocation's timing details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationTiming")]
        public virtual Interval InvocationTiming { get; set; }

        /// <summary>Output only. The workflow invocation's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. This workflow invocation's current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single action in a workflow invocation.</summary>
    public class WorkflowInvocationAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The workflow action's bigquery action details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryAction")]
        public virtual BigQueryAction BigqueryAction { get; set; }

        /// <summary>
        /// Output only. The action's identifier if the project had been compiled without any overrides configured.
        /// Unique within the compilation result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalTarget")]
        public virtual Target CanonicalTarget { get; set; }

        /// <summary>Output only. If and only if action's state is FAILED a failure reason is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Output only. This action's timing details. `start_time` will be set if the action is in [RUNNING, SUCCEEDED,
        /// CANCELLED, FAILED] state. `end_time` will be set if the action is in [SUCCEEDED, CANCELLED, FAILED] state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationTiming")]
        public virtual Interval InvocationTiming { get; set; }

        /// <summary>Output only. This action's current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. This action's identifier. Unique within the workflow invocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Target Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Dataform Git workspace.</summary>
    public class Workspace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The workspace's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`WriteFile` request message.</summary>
    public class WriteFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The file's contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Required. The file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`WriteFile` response message.</summary>
    public class WriteFileResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
