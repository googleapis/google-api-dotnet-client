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

namespace Google.Apis.AIPlatformNotebooks.v1
{
    /// <summary>The AIPlatformNotebooks Service.</summary>
    public class AIPlatformNotebooksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AIPlatformNotebooksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AIPlatformNotebooksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "notebooks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://notebooks.googleapis.com/";
        #else
            "https://notebooks.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://notebooks.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Notebooks API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Notebooks API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for AIPlatformNotebooks requests.</summary>
    public abstract class AIPlatformNotebooksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AIPlatformNotebooksBaseServiceRequest instance.</summary>
        protected AIPlatformNotebooksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AIPlatformNotebooks parameter list.</summary>
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
                Environments = new EnvironmentsResource(service);
                Executions = new ExecutionsResource(service);
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);
                Runtimes = new RuntimesResource(service);
                Schedules = new SchedulesResource(service);
            }

            /// <summary>Gets the Environments resource.</summary>
            public virtual EnvironmentsResource Environments { get; }

            /// <summary>The "environments" collection of methods.</summary>
            public class EnvironmentsResource
            {
                private const string Resource = "environments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EnvironmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v1.Data.Environment body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Environment.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.Environment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. User-defined unique ID of this environment. The `environment_id` must be 1 to 63
                    /// characters long and contain only lowercase letters, numeric characters, and dashes. The first
                    /// character must be a lowercase letter and the last character cannot be a dash.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EnvironmentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.Environment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/environments";

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
                        RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Environment.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/environments/{environment_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Environment.</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/environments/{environment_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Environment.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/environments/{environment_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Environment.</summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Environment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/environments/{environment_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists environments in a project.</summary>
                /// <param name="parent">Required. Format: `projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists environments in a project.</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListEnvironmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A previous returned page token that can be used to continue listing from the last result.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/environments";

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
            }

            /// <summary>Gets the Executions resource.</summary>
            public virtual ExecutionsResource Executions { get; }

            /// <summary>The "executions" collection of methods.</summary>
            public class ExecutionsResource
            {
                private const string Resource = "executions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ExecutionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Scheduled Notebook in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v1.Data.Execution body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Scheduled Notebook in a given project and location.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.Execution body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-defined unique ID of this execution.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExecutionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.Execution Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/executions";

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
                        RequestParameters.Add("executionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "executionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes execution</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/executions/{execution_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes execution</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/executions/{execution_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/executions/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of executions</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{execution_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of executions</summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Execution>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{execution_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/executions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists executions in a given project and location</summary>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists executions in a given project and location</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListExecutionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filter applied to resulting executions. Currently only supports filtering executions by a
                    /// specified schedule_id. Format: "schedule_id="
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Sort by field.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A previous returned page token that can be used to continue listing from the last result.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/executions";

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

                /// <summary>Creates a new Instance in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v1.Data.Instance body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Instance in a given project and location.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.Instance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-defined unique ID of this instance.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.Instance Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instanceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Instance.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Instance.</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Instance.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single Instance.</summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                /// <summary>Check if a notebook instance is healthy.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual GetInstanceHealthRequest GetInstanceHealth(string name)
                {
                    return new GetInstanceHealthRequest(service, name);
                }

                /// <summary>Check if a notebook instance is healthy.</summary>
                public class GetInstanceHealthRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.GetInstanceHealthResponse>
                {
                    /// <summary>Constructs a new GetInstanceHealth request.</summary>
                    public GetInstanceHealthRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getInstanceHealth";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:getInstanceHealth";

                    /// <summary>Initializes GetInstanceHealth parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Check if a notebook instance is upgradable.</summary>
                /// <param name="notebookInstance">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual IsUpgradeableRequest IsUpgradeable(string notebookInstance)
                {
                    return new IsUpgradeableRequest(service, notebookInstance);
                }

                /// <summary>Check if a notebook instance is upgradable.</summary>
                public class IsUpgradeableRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.IsInstanceUpgradeableResponse>
                {
                    /// <summary>Constructs a new IsUpgradeable request.</summary>
                    public IsUpgradeableRequest(Google.Apis.Services.IClientService service, string notebookInstance) : base(service)
                    {
                        NotebookInstance = notebookInstance;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("notebookInstance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string NotebookInstance { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "isUpgradeable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+notebookInstance}:isUpgradeable";

                    /// <summary>Initializes IsUpgradeable parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("notebookInstance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "notebookInstance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists instances in a given project and location.</summary>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists instances in a given project and location.</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A previous returned page token that can be used to continue listing from the last result.
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
                /// Registers an existing legacy notebook instance to the Notebooks API server. Legacy instances are
                /// instances created with the legacy Compute Engine calls. They are not manageable by the Notebooks API
                /// out of the box. This call makes these instances manageable by the Notebooks API.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual RegisterRequest Register(Google.Apis.AIPlatformNotebooks.v1.Data.RegisterInstanceRequest body, string parent)
                {
                    return new RegisterRequest(service, body, parent);
                }

                /// <summary>
                /// Registers an existing legacy notebook instance to the Notebooks API server. Legacy instances are
                /// instances created with the legacy Compute Engine calls. They are not manageable by the Notebooks API
                /// out of the box. This call makes these instances manageable by the Notebooks API.
                /// </summary>
                public class RegisterRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Register request.</summary>
                    public RegisterRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.RegisterInstanceRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.RegisterInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "register";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances:register";

                    /// <summary>Initializes Register parameter list.</summary>
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

                /// <summary>
                /// Allows notebook instances to report their latest instance information to the Notebooks API server.
                /// The server will merge the reported information to the instance metadata store. Do not use this
                /// method directly.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual ReportRequest Report(Google.Apis.AIPlatformNotebooks.v1.Data.ReportInstanceInfoRequest body, string name)
                {
                    return new ReportRequest(service, body, name);
                }

                /// <summary>
                /// Allows notebook instances to report their latest instance information to the Notebooks API server.
                /// The server will merge the reported information to the instance metadata store. Do not use this
                /// method directly.
                /// </summary>
                public class ReportRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Report request.</summary>
                    public ReportRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.ReportInstanceInfoRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.ReportInstanceInfoRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "report";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:report";

                    /// <summary>Initializes Report parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Resets a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual ResetRequest Reset(Google.Apis.AIPlatformNotebooks.v1.Data.ResetInstanceRequest body, string name)
                {
                    return new ResetRequest(service, body, name);
                }

                /// <summary>Resets a notebook instance.</summary>
                public class ResetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Reset request.</summary>
                    public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.ResetInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.ResetInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reset";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:reset";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Rollbacks a notebook instance to the previous version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual RollbackRequest Rollback(Google.Apis.AIPlatformNotebooks.v1.Data.RollbackInstanceRequest body, string name)
                {
                    return new RollbackRequest(service, body, name);
                }

                /// <summary>Rollbacks a notebook instance to the previous version.</summary>
                public class RollbackRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.RollbackInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.RollbackInstanceRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the guest accelerators of a single Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual SetAcceleratorRequest SetAccelerator(Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceAcceleratorRequest body, string name)
                {
                    return new SetAcceleratorRequest(service, body, name);
                }

                /// <summary>Updates the guest accelerators of a single Instance.</summary>
                public class SetAcceleratorRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetAccelerator request.</summary>
                    public SetAcceleratorRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceAcceleratorRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceAcceleratorRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setAccelerator";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setAccelerator";

                    /// <summary>Initializes SetAccelerator parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AIPlatformNotebooks.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Replaces all the labels of an Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual SetLabelsRequest SetLabels(Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceLabelsRequest body, string name)
                {
                    return new SetLabelsRequest(service, body, name);
                }

                /// <summary>Replaces all the labels of an Instance.</summary>
                public class SetLabelsRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetLabels request.</summary>
                    public SetLabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceLabelsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceLabelsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setLabels";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setLabels";

                    /// <summary>Initializes SetLabels parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the machine type of a single Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual SetMachineTypeRequest SetMachineType(Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceMachineTypeRequest body, string name)
                {
                    return new SetMachineTypeRequest(service, body, name);
                }

                /// <summary>Updates the machine type of a single Instance.</summary>
                public class SetMachineTypeRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMachineType request.</summary>
                    public SetMachineTypeRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceMachineTypeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.SetInstanceMachineTypeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMachineType";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMachineType";

                    /// <summary>Initializes SetMachineType parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual StartRequest Start(Google.Apis.AIPlatformNotebooks.v1.Data.StartInstanceRequest body, string name)
                {
                    return new StartRequest(service, body, name);
                }

                /// <summary>Starts a notebook instance.</summary>
                public class StartRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.StartInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.StartInstanceRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual StopRequest Stop(Google.Apis.AIPlatformNotebooks.v1.Data.StopInstanceRequest body, string name)
                {
                    return new StopRequest(service, body, name);
                }

                /// <summary>Stops a notebook instance.</summary>
                public class StopRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.StopInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.StopInstanceRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AIPlatformNotebooks.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.AIPlatformNotebooks.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Update Notebook Instance configurations.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpdateConfigRequest UpdateConfig(Google.Apis.AIPlatformNotebooks.v1.Data.UpdateInstanceConfigRequest body, string name)
                {
                    return new UpdateConfigRequest(service, body, name);
                }

                /// <summary>Update Notebook Instance configurations.</summary>
                public class UpdateConfigRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateConfig request.</summary>
                    public UpdateConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.UpdateInstanceConfigRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.UpdateInstanceConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:updateConfig";

                    /// <summary>Initializes UpdateConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the Shielded instance configuration of a single Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpdateShieldedInstanceConfigRequest UpdateShieldedInstanceConfig(Google.Apis.AIPlatformNotebooks.v1.Data.UpdateShieldedInstanceConfigRequest body, string name)
                {
                    return new UpdateShieldedInstanceConfigRequest(service, body, name);
                }

                /// <summary>Updates the Shielded instance configuration of a single Instance.</summary>
                public class UpdateShieldedInstanceConfigRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateShieldedInstanceConfig request.</summary>
                    public UpdateShieldedInstanceConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.UpdateShieldedInstanceConfigRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.UpdateShieldedInstanceConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateShieldedInstanceConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:updateShieldedInstanceConfig";

                    /// <summary>Initializes UpdateShieldedInstanceConfig parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Upgrades a notebook instance to the latest version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpgradeRequest Upgrade(Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceRequest body, string name)
                {
                    return new UpgradeRequest(service, body, name);
                }

                /// <summary>Upgrades a notebook instance to the latest version.</summary>
                public class UpgradeRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Upgrade request.</summary>
                    public UpgradeRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upgrade";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:upgrade";

                    /// <summary>Initializes Upgrade parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Allows notebook instances to call this endpoint to upgrade themselves. Do not use this method
                /// directly.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpgradeInternalRequest UpgradeInternal(Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceInternalRequest body, string name)
                {
                    return new UpgradeInternalRequest(service, body, name);
                }

                /// <summary>
                /// Allows notebook instances to call this endpoint to upgrade themselves. Do not use this method
                /// directly.
                /// </summary>
                public class UpgradeInternalRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpgradeInternal request.</summary>
                    public UpgradeInternalRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceInternalRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.UpgradeInstanceInternalRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upgradeInternal";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:upgradeInternal";

                    /// <summary>Initializes UpgradeInternal parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.AIPlatformNotebooks.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Empty>
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
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
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
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Runtimes resource.</summary>
            public virtual RuntimesResource Runtimes { get; }

            /// <summary>The "runtimes" collection of methods.</summary>
            public class RuntimesResource
            {
                private const string Resource = "runtimes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RuntimesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Runtime in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v1.Data.Runtime body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Runtime in a given project and location.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.Runtime body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-defined unique ID of this Runtime.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("runtimeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RuntimeId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.Runtime Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/runtimes";

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
                        RequestParameters.Add("runtimeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "runtimeId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Runtime.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single Runtime.</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets details of a single Runtime. The location must be a regional endpoint rather than zonal.
                /// </summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets details of a single Runtime. The location must be a regional endpoint rather than zonal.
                /// </summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Runtime>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Runtimes in a given project and location.</summary>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Runtimes in a given project and location.</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListRuntimesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A previous returned page token that can be used to continue listing from the last result.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/runtimes";

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

                /// <summary>Report and process a runtime event.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual ReportEventRequest ReportEvent(Google.Apis.AIPlatformNotebooks.v1.Data.ReportRuntimeEventRequest body, string name)
                {
                    return new ReportEventRequest(service, body, name);
                }

                /// <summary>Report and process a runtime event.</summary>
                public class ReportEventRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ReportEvent request.</summary>
                    public ReportEventRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.ReportRuntimeEventRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.ReportRuntimeEventRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reportEvent";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:reportEvent";

                    /// <summary>Initializes ReportEvent parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>Resets a Managed Notebook Runtime.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual ResetRequest Reset(Google.Apis.AIPlatformNotebooks.v1.Data.ResetRuntimeRequest body, string name)
                {
                    return new ResetRequest(service, body, name);
                }

                /// <summary>Resets a Managed Notebook Runtime.</summary>
                public class ResetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Reset request.</summary>
                    public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.ResetRuntimeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.ResetRuntimeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reset";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:reset";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Starts a Managed Notebook Runtime. Perform "Start" on GPU instances; "Resume" on CPU instances See:
                /// https://cloud.google.com/compute/docs/instances/stop-start-instance
                /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual StartRequest Start(Google.Apis.AIPlatformNotebooks.v1.Data.StartRuntimeRequest body, string name)
                {
                    return new StartRequest(service, body, name);
                }

                /// <summary>
                /// Starts a Managed Notebook Runtime. Perform "Start" on GPU instances; "Resume" on CPU instances See:
                /// https://cloud.google.com/compute/docs/instances/stop-start-instance
                /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
                /// </summary>
                public class StartRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.StartRuntimeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.StartRuntimeRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Stops a Managed Notebook Runtime. Perform "Stop" on GPU instances; "Suspend" on CPU instances See:
                /// https://cloud.google.com/compute/docs/instances/stop-start-instance
                /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual StopRequest Stop(Google.Apis.AIPlatformNotebooks.v1.Data.StopRuntimeRequest body, string name)
                {
                    return new StopRequest(service, body, name);
                }

                /// <summary>
                /// Stops a Managed Notebook Runtime. Perform "Stop" on GPU instances; "Suspend" on CPU instances See:
                /// https://cloud.google.com/compute/docs/instances/stop-start-instance
                /// https://cloud.google.com/compute/docs/instances/suspend-resume-instance
                /// </summary>
                public class StopRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.StopRuntimeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.StopRuntimeRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }

                /// <summary>Switch a Managed Notebook Runtime.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                /// </param>
                public virtual AIPlatformNotebooksSwitchRequest AIPlatformNotebooksSwitch(Google.Apis.AIPlatformNotebooks.v1.Data.SwitchRuntimeRequest body, string name)
                {
                    return new AIPlatformNotebooksSwitchRequest(service, body, name);
                }

                /// <summary>Switch a Managed Notebook Runtime.</summary>
                public class AIPlatformNotebooksSwitchRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new AIPlatformNotebooksSwitch request.</summary>
                    public AIPlatformNotebooksSwitchRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.SwitchRuntimeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.SwitchRuntimeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "switch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:switch";

                    /// <summary>Initializes AIPlatformNotebooksSwitch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/runtimes/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Schedules resource.</summary>
            public virtual SchedulesResource Schedules { get; }

            /// <summary>The "schedules" collection of methods.</summary>
            public class SchedulesResource
            {
                private const string Resource = "schedules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SchedulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Scheduled Notebook in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v1.Data.Schedule body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Scheduled Notebook in a given project and location.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.Schedule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-defined unique ID of this schedule.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("scheduleId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ScheduleId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.Schedule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/schedules";

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
                        RequestParameters.Add("scheduleId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "scheduleId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes schedule and all underlying jobs</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes schedule and all underlying jobs</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/schedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of schedule</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of schedule</summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Schedule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/schedules/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists schedules in a given project and location.</summary>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists schedules in a given project and location.</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListSchedulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter applied to resulting schedules.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to order results by.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A previous returned page token that can be used to continue listing from the last result.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/schedules";

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

                /// <summary>Triggers execution of an existing schedule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `parent=projects/{project_id}/locations/{location}/schedules/{schedule_id}`
                /// </param>
                public virtual TriggerRequest Trigger(Google.Apis.AIPlatformNotebooks.v1.Data.TriggerScheduleRequest body, string name)
                {
                    return new TriggerRequest(service, body, name);
                }

                /// <summary>Triggers execution of an existing schedule.</summary>
                public class TriggerRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Trigger request.</summary>
                    public TriggerRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v1.Data.TriggerScheduleRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `parent=projects/{project_id}/locations/{location}/schedules/{schedule_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v1.Data.TriggerScheduleRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "trigger";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:trigger";

                    /// <summary>Initializes Trigger parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/schedules/[^/]+$",
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
            public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.Location>
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
            public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.AIPlatformNotebooks.v1.Data
{
    /// <summary>
    /// Definition of a hardware accelerator. Note that not all combinations of `type` and `core_count` are valid. Check
    /// [GPUs on Compute Engine](/compute/docs/gpus/#gpus-list) to find a valid combination. TPUs are not supported.
    /// </summary>
    public class AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of cores of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<long> CoreCount { get; set; }

        /// <summary>Type of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>
    /// Definition of a container image for starting a notebook instance with the environment installed in a container.
    /// </summary>
    public class ContainerImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The path to the container image repository. For example: `gcr.io/{project_id}/{image_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The tag of the container image. If not specified, this defaults to the latest tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instance-attached disk resource.</summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the disk will be auto-deleted when the instance is deleted (but not when the disk is
        /// detached from the instance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDelete")]
        public virtual System.Nullable<bool> AutoDelete { get; set; }

        /// <summary>
        /// Indicates that this is a boot disk. The virtual machine will use the first partition of the disk for its
        /// root filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boot")]
        public virtual System.Nullable<bool> Boot { get; set; }

        /// <summary>
        /// Indicates a unique device name of your choice that is reflected into the /dev/disk/by-id/google-* tree of a
        /// Linux operating system running within the instance. This name can be used to reference the device for
        /// mounting, resizing, and so on, from within the instance. If not specified, the server chooses a default
        /// device name to apply to this disk, in the form persistent-disk-x, where x is a number assigned by Google
        /// Compute Engine.This field is only applicable for persistent disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>Indicates the size of the disk in base-2 GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Indicates a list of features to enable on the guest operating system. Applicable only for bootable images.
        /// Read Enabling guest operating system features to see a list of available options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestOsFeatures")]
        public virtual System.Collections.Generic.IList<GuestOsFeature> GuestOsFeatures { get; set; }

        /// <summary>
        /// A zero-based index to this disk, where 0 is reserved for the boot disk. If you have many disks attached to
        /// an instance, each disk would have a unique index number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<long> Index { get; set; }

        /// <summary>
        /// Indicates the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is
        /// SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent
        /// disk in any other format than SCSI. Local SSDs can use either NVME or SCSI. For performance characteristics
        /// of SCSI over NVMe, see Local SSD performance. Valid values: NVME SCSI
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interface")]
        public virtual string Interface__ { get; set; }

        /// <summary>Type of the resource. Always compute#attachedDisk for attached disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// A list of publicly visible licenses. Reserved for Google's use. A License represents billing and aggregate
        /// usage data for public and marketplace images.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        /// <summary>
        /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to
        /// attach the disk in READ_WRITE mode. Valid values: READ_ONLY READ_WRITE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Indicates a valid partial or full URL to an existing Persistent Disk resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Indicates the type of the disk, either SCRATCH or PERSISTENT. Valid values: PERSISTENT SCRATCH
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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
    /// Represents a custom encryption key configuration that can be applied to a resource. This will encrypt all disks
    /// in Virtual Machine.
    /// </summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud KMS resource identifier of the customer-managed encryption key used to protect a resource, such as
        /// a disks. It has the following format:
        /// `projects/{PROJECT_ID}/locations/{REGION}/keyRings/{KEY_RING_NAME}/cryptoKeys/{KEY_NAME}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition of a software environment that is used to start a notebook instance.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use a container image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual ContainerImage ContainerImage { get; set; }

        /// <summary>Output only. The time at which this environment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A brief description of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name of this environment for the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Name of this environment. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a
        /// URL or Cloud Storage path. Example: `"gs://path-to-file/file-name"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postStartupScript")]
        public virtual string PostStartupScript { get; set; }

        /// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual VmImage VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of an Event for a managed / semi-managed notebook instance.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Event report time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a single executed notebook.</summary>
    public class Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time the Execution was instantiated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A brief description of this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Name used for UI purposes. Name can only contain alphanumeric characters and underscores '_'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>execute metadata including name, hardware spec, region, labels, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTemplate")]
        public virtual ExecutionTemplate ExecutionTemplate { get; set; }

        /// <summary>Output only. The URI of the external job used to execute the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobUri")]
        public virtual string JobUri { get; set; }

        /// <summary>
        /// Output only. The resource name of the execute. Format:
        /// `projects/{project_id}/locations/{location}/execution/{execution_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output notebook file generated by this execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputNotebookFile")]
        public virtual string OutputNotebookFile { get; set; }

        /// <summary>Output only. State of the underlying AI Platform job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Time the Execution was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The description a notebook execution workload.</summary>
    public class ExecutionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration (count and accelerator type) for hardware running notebook execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual SchedulerAcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>
        /// Container Image URI to a DLVM Example: 'gcr.io/deeplearning-platform-release/base-cu100' More examples can
        /// be found at: https://cloud.google.com/ai-platform/deep-learning-containers/docs/choosing-container
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImageUri")]
        public virtual string ContainerImageUri { get; set; }

        /// <summary>
        /// Path to the notebook file to execute. Must be in a Google Cloud Storage bucket. Format:
        /// gs://{project_id}/{folder}/{notebook_file_name} Ex:
        /// gs://notebook_user/scheduled_notebooks/sentiment_notebook.ipynb
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputNotebookFile")]
        public virtual string InputNotebookFile { get; set; }

        /// <summary>
        /// Labels for execution. If execution is scheduled, a field included will be 'nbs-scheduled'. Otherwise, it is
        /// an immediate execution, and an included field will be 'nbs-immediate'. Use fields to efficiently index
        /// between various types of executions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Specifies the type of virtual machine to use for your training job's master worker. You must specify this
        /// field when `scaleTier` is set to `CUSTOM`. You can use certain Compute Engine machine types directly in this
        /// field. The following types are supported: - `n1-standard-4` - `n1-standard-8` - `n1-standard-16` -
        /// `n1-standard-32` - `n1-standard-64` - `n1-standard-96` - `n1-highmem-2` - `n1-highmem-4` - `n1-highmem-8` -
        /// `n1-highmem-16` - `n1-highmem-32` - `n1-highmem-64` - `n1-highmem-96` - `n1-highcpu-16` - `n1-highcpu-32` -
        /// `n1-highcpu-64` - `n1-highcpu-96` Alternatively, you can use the following legacy machine types: -
        /// `standard` - `large_model` - `complex_model_s` - `complex_model_m` - `complex_model_l` - `standard_gpu` -
        /// `complex_model_m_gpu` - `complex_model_l_gpu` - `standard_p100` - `complex_model_m_p100` - `standard_v100` -
        /// `large_model_v100` - `complex_model_m_v100` - `complex_model_l_v100` Finally, if you want to use a TPU for
        /// training, specify `cloud_tpu` in this field. Learn more about the [special configuration options for
        /// training with TPU.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterType")]
        public virtual string MasterType { get; set; }

        /// <summary>
        /// Path to the notebook folder to write to. Must be in a Google Cloud Storage bucket path. Format:
        /// gs://{project_id}/{folder} Ex: gs://notebook_user/scheduled_notebooks
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputNotebookFolder")]
        public virtual string OutputNotebookFolder { get; set; }

        /// <summary>Parameters used within the 'input_notebook_file' notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual string Parameters { get; set; }

        /// <summary>
        /// Parameters to be overridden in the notebook during execution. Ref
        /// https://papermill.readthedocs.io/en/latest/usage-parameterize.html on how to specifying parameters in the
        /// input notebook and pass them here in an YAML file. Ex:
        /// gs://notebook_user/scheduled_notebooks/sentiment_notebook_params.yaml
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramsYamlFile")]
        public virtual string ParamsYamlFile { get; set; }

        /// <summary>
        /// Required. Scale tier of the hardware used for notebook execution. DEPRECATED Will be discontinued. As right
        /// now only CUSTOM is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleTier")]
        public virtual string ScaleTier { get; set; }

        /// <summary>
        /// The email address of a service account to use when running the execution. You must have the
        /// `iam.serviceAccounts.actAs` permission for the specified service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

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

    /// <summary>Response for checking if a notebook instance is healthy.</summary>
    public class GetInstanceHealthResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Additional information about instance health. Example: healthInfo": {
        /// "docker_proxy_agent_status": "1", "docker_status": "1", "jupyterlab_api_status": "-1", "jupyterlab_status":
        /// "-1", "updated": "2020-10-18 09:40:03.573409" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthInfo")]
        public virtual System.Collections.Generic.IDictionary<string, string> HealthInfo { get; set; }

        /// <summary>Output only. Runtime health_state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthState")]
        public virtual string HealthState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guest OS features for boot disk.</summary>
    public class GuestOsFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of a supported feature. Read Enabling guest operating system features to see a list of available
        /// options. Valid values: FEATURE_TYPE_UNSPECIFIED MULTI_IP_SUBNET SECURE_BOOT UEFI_COMPATIBLE
        /// VIRTIO_SCSI_MULTIQUEUE WINDOWS
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a notebook instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The hardware accelerator used on this instance. If you use accelerators, make sure that your configuration
        /// has [enough vCPUs and memory to support the `machine_type` you have
        /// selected](/compute/docs/gpus/#gpus-list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual AcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>
        /// Input only. The size of the boot disk in GB attached to this instance, up to a maximum of 64000 GB (64 TB).
        /// The minimum recommended value is 100 GB. If not specified, this defaults to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<long> BootDiskSizeGb { get; set; }

        /// <summary>
        /// Input only. The type of the boot disk attached to this instance, defaults to standard persistent disk
        /// (`PD_STANDARD`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskType")]
        public virtual string BootDiskType { get; set; }

        /// <summary>Use a container image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual ContainerImage ContainerImage { get; set; }

        /// <summary>Output only. Instance creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically
        /// choose from official GPU drivers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGpuDriverPath")]
        public virtual string CustomGpuDriverPath { get; set; }

        /// <summary>
        /// Input only. The size of the data disk in GB attached to this instance, up to a maximum of 64000 GB (64 TB).
        /// You can choose the size of the data disk based on how big your notebooks and data are. If not specified,
        /// this defaults to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskSizeGb")]
        public virtual System.Nullable<long> DataDiskSizeGb { get; set; }

        /// <summary>
        /// Input only. The type of the data disk attached to this instance, defaults to standard persistent disk
        /// (`PD_STANDARD`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskType")]
        public virtual string DataDiskType { get; set; }

        /// <summary>Input only. Disk encryption method used on the boot and data disks, defaults to GMEK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryption")]
        public virtual string DiskEncryption { get; set; }

        /// <summary>Output only. Attached disks to notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<Disk> Disks { get; set; }

        /// <summary>
        /// Whether the end user authorizes Google Cloud to install GPU driver on this instance. If this field is empty
        /// or set to false, the GPU driver won't be installed. Only applicable to instances with GPUs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installGpuDriver")]
        public virtual System.Nullable<bool> InstallGpuDriver { get; set; }

        /// <summary>
        /// Input only. The owner of this instance after creation. Format: `alias@example.com` Currently supports one
        /// owner only. If not specified, all of the service account users of your VM instance's service account can use
        /// the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceOwners")]
        public virtual System.Collections.Generic.IList<string> InstanceOwners { get; set; }

        /// <summary>
        /// Input only. The KMS key used to encrypt the disks, only applicable if disk_encryption is CMEK. Format:
        /// `projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}` Learn more about
        /// [using your own encryption keys](/kms/docs/quickstart).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Labels to apply to this instance. These can be later modified by the setLabels method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The [Compute Engine machine type](/compute/docs/machine-types) of this instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Custom metadata to apply to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Output only. The name of this notebook instance. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the VPC that this instance is in. Format: `projects/{project_id}/global/networks/{network_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicType")]
        public virtual string NicType { get; set; }

        /// <summary>If true, the notebook instance will not register with the proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noProxyAccess")]
        public virtual System.Nullable<bool> NoProxyAccess { get; set; }

        /// <summary>If true, no public IP will be assigned to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noPublicIp")]
        public virtual System.Nullable<bool> NoPublicIp { get; set; }

        /// <summary>Input only. If true, the data disk will not be auto deleted when deleting the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRemoveDataDisk")]
        public virtual System.Nullable<bool> NoRemoveDataDisk { get; set; }

        /// <summary>
        /// Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a
        /// URL or Cloud Storage path (gs://path-to-file/file-name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postStartupScript")]
        public virtual string PostStartupScript { get; set; }

        /// <summary>Output only. The proxy endpoint that is used to access the Jupyter notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyUri")]
        public virtual string ProxyUri { get; set; }

        /// <summary>
        /// Optional. The optional reservation affinity. Setting this field will apply the specified [Zonal Compute
        /// Reservation](https://cloud.google.com/compute/docs/instances/reserving-zonal-resources) to this notebook
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationAffinity")]
        public virtual ReservationAffinity ReservationAffinity { get; set; }

        /// <summary>
        /// The service account on this instance, giving access to other Google Cloud services. You can use any service
        /// account within the same project, but you must have the service account user permission to use the instance.
        /// If not specified, the [Compute Engine default service
        /// account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. The URIs of service account scopes to be included in Compute Engine instances. If not specified,
        /// the following [scopes](https://cloud.google.com/compute/docs/access/service-accounts#accesscopesiam) are
        /// defined: - https://www.googleapis.com/auth/cloud-platform - https://www.googleapis.com/auth/userinfo.email
        /// If not using default scopes, you need at least: https://www.googleapis.com/auth/compute
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountScopes")]
        public virtual System.Collections.Generic.IList<string> ServiceAccountScopes { get; set; }

        /// <summary>
        /// Optional. Shielded VM configuration. [Images using supported Shielded VM features]
        /// (https://cloud.google.com/compute/docs/instances/modifying-shielded-vm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>Output only. The state of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The name of the subnet that this instance is in. Format:
        /// `projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>
        /// Optional. The Compute Engine tags to add to runtime (see [Tagging
        /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>Output only. Instance update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The upgrade history of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeHistory")]
        public virtual System.Collections.Generic.IList<UpgradeHistoryEntry> UpgradeHistory { get; set; }

        /// <summary>Use a Compute Engine VM image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual VmImage VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Notebook instance configurations that can be updated.</summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Verifies core internal services are running. More info: go/notebooks-health</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHealthMonitoring")]
        public virtual System.Nullable<bool> EnableHealthMonitoring { get; set; }

        /// <summary>
        /// Cron expression in UTC timezone, used to schedule instance auto upgrade. Please follow the [cron
        /// format](https://en.wikipedia.org/wiki/Cron).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebookUpgradeSchedule")]
        public virtual string NotebookUpgradeSchedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for checking if a notebook instance is upgradeable.</summary>
    public class IsInstanceUpgradeableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new image self link this instance will be upgraded to if calling the upgrade endpoint. This field will
        /// only be populated if field upgradeable is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeImage")]
        public virtual string UpgradeImage { get; set; }

        /// <summary>Additional information about upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeInfo")]
        public virtual string UpgradeInfo { get; set; }

        /// <summary>
        /// The version this instance will be upgraded to if calling the upgrade endpoint. This field will only be
        /// populated if field upgradeable is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeVersion")]
        public virtual string UpgradeVersion { get; set; }

        /// <summary>If an instance is upgradeable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeable")]
        public virtual System.Nullable<bool> Upgradeable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing environments.</summary>
    public class ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of returned environments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<Environment> Environments { get; set; }

        /// <summary>
        /// A page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing scheduled notebook executions</summary>
    public class ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of returned instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<Execution> Executions { get; set; }

        /// <summary>
        /// Page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Executions IDs that could not be reached. For example,
        /// ['projects/{project_id}/location/{location}/executions/imagenet_test1',
        /// 'projects/{project_id}/location/{location}/executions/classifier_train1'].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing notebook instances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of returned instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// Page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Locations that could not be reached. For example, ['us-west1-a', 'us-central1-b']. A ListInstancesResponse
        /// will only contain either instances or unreachables,
        /// </summary>
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

    /// <summary>Response for listing Managed Notebook Runtimes.</summary>
    public class ListRuntimesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of returned Runtimes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimes")]
        public virtual System.Collections.Generic.IList<Runtime> Runtimes { get; set; }

        /// <summary>
        /// Locations that could not be reached. For example, ['us-west1', 'us-central1']. A ListRuntimesResponse will
        /// only contain either runtimes or unreachables,
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing scheduled notebook job.</summary>
    public class ListSchedulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of returned instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedules")]
        public virtual System.Collections.Generic.IList<Schedule> Schedules { get; set; }

        /// <summary>
        /// Schedules that could not be reached. For example,
        /// ['projects/{project_id}/location/{location}/schedules/monthly_digest',
        /// 'projects/{project_id}/location/{location}/schedules/weekly_sentiment'].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Local attached disk resource.</summary>
    public class LocalDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies whether the disk will be auto-deleted when the instance is deleted (but not when the
        /// disk is detached from the instance).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDelete")]
        public virtual System.Nullable<bool> AutoDelete { get; set; }

        /// <summary>
        /// Output only. Indicates that this is a boot disk. The virtual machine will use the first partition of the
        /// disk for its root filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boot")]
        public virtual System.Nullable<bool> Boot { get; set; }

        /// <summary>
        /// Output only. Specifies a unique device name of your choice that is reflected into the
        /// /dev/disk/by-id/google-* tree of a Linux operating system running within the instance. This name can be used
        /// to reference the device for mounting, resizing, and so on, from within the instance. If not specified, the
        /// server chooses a default device name to apply to this disk, in the form persistent-disk-x, where x is a
        /// number assigned by Google Compute Engine. This field is only applicable for persistent disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>
        /// Output only. Indicates a list of features to enable on the guest operating system. Applicable only for
        /// bootable images. Read Enabling guest operating system features to see a list of available options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestOsFeatures")]
        public virtual System.Collections.Generic.IList<RuntimeGuestOsFeature> GuestOsFeatures { get; set; }

        /// <summary>
        /// Output only. [Output Only] A zero-based index to this disk, where 0 is reserved for the boot disk. If you
        /// have many disks attached to an instance, each disk would have a unique index number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Input only. [Input Only] Specifies the parameters for a new disk that will be created alongside the new
        /// instance. Use initialization parameters to create boot disks or local SSDs attached to the new instance.
        /// This property is mutually exclusive with the source property; you can only define one or the other, but not
        /// both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializeParams")]
        public virtual LocalDiskInitializeParams InitializeParams { get; set; }

        /// <summary>
        /// Specifies the disk interface to use for attaching this disk, which is either SCSI or NVME. The default is
        /// SCSI. Persistent disks must always use SCSI and the request will fail if you attempt to attach a persistent
        /// disk in any other format than SCSI. Local SSDs can use either NVME or SCSI. For performance characteristics
        /// of SCSI over NVMe, see Local SSD performance. Valid values: NVME SCSI
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interface")]
        public virtual string Interface__ { get; set; }

        /// <summary>Output only. Type of the resource. Always compute#attachedDisk for attached disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. [Output Only] Any valid publicly visible licenses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        /// <summary>
        /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to
        /// attach the disk in READ_WRITE mode. Valid values: READ_ONLY READ_WRITE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>Specifies a valid partial or full URL to an existing Persistent Disk resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Specifies the type of the disk, either SCRATCH or PERSISTENT. If not specified, the default is PERSISTENT.
        /// Valid values: PERSISTENT SCRATCH
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [Input Only] Specifies the parameters for a new disk that will be created alongside the new instance. Use
    /// initialization parameters to create boot disks or local SSDs attached to the new runtime. This property is
    /// mutually exclusive with the source property; you can only define one or the other, but not both.
    /// </summary>
    public class LocalDiskInitializeParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Provide this property when creating the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Specifies the disk name. If not specified, the default is to use the name of the instance. If the
        /// disk with the instance name exists already in the given zone/region, a new name will be automatically
        /// generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskName")]
        public virtual string DiskName { get; set; }

        /// <summary>
        /// Optional. Specifies the size of the disk in base-2 GB. If not specified, the disk will be the same size as
        /// the image (usually 10GB). If specified, the size must be equal to or larger than 10GB. Default 100 GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Input only. The type of the boot disk attached to this instance, defaults to standard persistent disk
        /// (`PD_STANDARD`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Labels to apply to this disk. These can be later modified by the disks.setLabels method. This
        /// field is only applicable for persistent disks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

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
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>API endpoint name of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Identifies whether the user has requested cancellation of the operation. Operations that have successfully
        /// been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
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

    /// <summary>Request for registering a notebook instance.</summary>
    public class RegisterInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. User defined unique ID of this instance. The `instance_id` must be 1 to 63 characters long and
        /// contain only lowercase letters, numeric characters, and dashes. The first character must be a lowercase
        /// letter and the last character cannot be a dash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for notebook instances to report information to Notebooks API.</summary>
    public class ReportInstanceInfoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The metadata reported to Notebooks API. This will be merged to the instance metadata store
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for reporting a Managed Notebook Event.</summary>
    public class ReportRuntimeEventRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Event to be reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual Event Event__ { get; set; }

        /// <summary>
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    public class ReservationAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Type of reservation to consume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumeReservationType")]
        public virtual string ConsumeReservationType { get; set; }

        /// <summary>Optional. Corresponds to the label key of reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Corresponds to the label values of reservation resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for reseting a notebook instance</summary>
    public class ResetInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for reseting a Managed Notebook Runtime.</summary>
    public class ResetRuntimeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for rollbacking a notebook instance</summary>
    public class RollbackInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The snapshot for rollback. Example: "projects/test-project/global/snapshots/krwlzipynril".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSnapshot")]
        public virtual string TargetSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a Runtime for a managed notebook instance.</summary>
    public class Runtime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The config settings for accessing runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessConfig")]
        public virtual RuntimeAccessConfig AccessConfig { get; set; }

        /// <summary>Output only. Runtime creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Runtime health_state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthState")]
        public virtual string HealthState { get; set; }

        /// <summary>Output only. Contains Runtime daemon metrics such as Service status and JupyterLab stats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual RuntimeMetrics Metrics { get; set; }

        /// <summary>
        /// Output only. The resource name of the runtime. Format:
        /// `projects/{project}/locations/{location}/runtimes/{runtime}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The config settings for software inside the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareConfig")]
        public virtual RuntimeSoftwareConfig SoftwareConfig { get; set; }

        /// <summary>Output only. Runtime state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Runtime update time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Use a Compute Engine VM image to start the managed notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualMachine")]
        public virtual VirtualMachine VirtualMachine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of the types of hardware accelerators that can be used. Definition of the types of hardware
    /// accelerators that can be used. See [Compute Engine
    /// AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: *
    /// `nvidia-tesla-k80` * `nvidia-tesla-p100` * `nvidia-tesla-v100` * `nvidia-tesla-p4` * `nvidia-tesla-t4` *
    /// `nvidia-tesla-a100`
    /// </summary>
    public class RuntimeAcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of cores of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<long> CoreCount { get; set; }

        /// <summary>Accelerator model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the login configuration for Runtime</summary>
    public class RuntimeAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of access mode this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessType")]
        public virtual string AccessType { get; set; }

        /// <summary>Output only. The proxy endpoint that is used to access the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyUri")]
        public virtual string ProxyUri { get; set; }

        /// <summary>
        /// The owner of this runtime after creation. Format: `alias@example.com` Currently supports one owner only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeOwner")]
        public virtual string RuntimeOwner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling
    /// guest operating system features to see a list of available options. Guest OS features for boot disk.
    /// </summary>
    public class RuntimeGuestOsFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of a supported feature. Read Enabling guest operating system features to see a list of available
        /// options. Valid values: FEATURE_TYPE_UNSPECIFIED MULTI_IP_SUBNET SECURE_BOOT UEFI_COMPATIBLE
        /// VIRTIO_SCSI_MULTIQUEUE WINDOWS
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains runtime daemon metrics, such as OS and kernels and sessions stats.</summary>
    public class RuntimeMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The system metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of Shielded Instance options. Check [Images using supported Shielded VM features] Not all combinations are
    /// valid.
    /// </summary>
    public class RuntimeShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
        /// boot integrity of the instance. The attestation is performed against the integrity policy baseline. This
        /// baseline is initially derived from the implicitly trusted boot image when the instance is created. Enabled
        /// by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
        /// authentic software by verifying the digital signature of all boot components, and halting the boot process
        /// if signature verification fails. Disabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the selection and config of software inside the runtime. / The properties to set on runtime.
    /// Properties keys are specified in `key:value` format, for example: * idle_shutdown: idle_shutdown=true *
    /// idle_shutdown_timeout: idle_shutdown_timeout=180 * report-system-health: report-system-health=true
    /// </summary>
    public class RuntimeSoftwareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll automatically
        /// choose from official GPU drivers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGpuDriverPath")]
        public virtual string CustomGpuDriverPath { get; set; }

        /// <summary>Verifies core internal services are running. Default: True</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHealthMonitoring")]
        public virtual System.Nullable<bool> EnableHealthMonitoring { get; set; }

        /// <summary>Runtime will automatically shutdown after idle_shutdown_time. Default: True</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleShutdown")]
        public virtual System.Nullable<bool> IdleShutdown { get; set; }

        /// <summary>Time in minutes to wait before shuting down runtime. Default: 180 minutes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleShutdownTimeout")]
        public virtual System.Nullable<int> IdleShutdownTimeout { get; set; }

        /// <summary>Install Nvidia Driver automatically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installGpuDriver")]
        public virtual System.Nullable<bool> InstallGpuDriver { get; set; }

        /// <summary>
        /// Cron expression in UTC timezone, used to schedule instance auto upgrade. Please follow the [cron
        /// format](https://en.wikipedia.org/wiki/Cron).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebookUpgradeSchedule")]
        public virtual string NotebookUpgradeSchedule { get; set; }

        /// <summary>
        /// Path to a Bash script that automatically runs after a notebook instance fully boots up. The path must be a
        /// URL or Cloud Storage path (gs://path-to-file/file-name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postStartupScript")]
        public virtual string PostStartupScript { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time the schedule was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Cron-tab formatted schedule by which the job will execute Format: minute, hour, day of month, month, day of
        /// week e.g. 0 0 * * WED = every Wednesday More examples: https://crontab.guru/examples.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSchedule")]
        public virtual string CronSchedule { get; set; }

        /// <summary>A brief description of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Display name used for UI purposes. Name can only contain alphanumeric characters, hyphens '-',
        /// and underscores '_'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Notebook Execution Template corresponding to this schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTemplate")]
        public virtual ExecutionTemplate ExecutionTemplate { get; set; }

        /// <summary>
        /// Output only. The name of this schedule. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The most recent execution names triggered from this schedule and their corresponding states.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentExecutions")]
        public virtual System.Collections.Generic.IList<Execution> RecentExecutions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Timezone on which the cron_schedule. The value of this field must be a time zone name from the tz database.
        /// TZ Database: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones Note that some time zones include
        /// a provision for daylight savings time. The rules for daylight saving time are determined by the chosen tz.
        /// For UTC use the string "utc". If a time zone is not specified, the default will be in UTC (also known as
        /// GMT).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Output only. Time the schedule was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a hardware accelerator. Note that not all combinations of `type` and `core_count` are valid. Check
    /// GPUs on Compute Engine to find a valid combination. TPUs are not supported.
    /// </summary>
    public class SchedulerAcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of cores of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<long> CoreCount { get; set; }

        /// <summary>Type of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>Request for setting instance accelerator.</summary>
    public class SetInstanceAcceleratorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Count of cores of this accelerator. Note that not all combinations of `type` and `core_count` are
        /// valid. Check [GPUs on Compute Engine](https://cloud.google.com/compute/docs/gpus/#gpus-list) to find a valid
        /// combination. TPUs are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<long> CoreCount { get; set; }

        /// <summary>Required. Type of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for setting instance labels.</summary>
    public class SetInstanceLabelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels to apply to this instance. These can be later modified by the setLabels method</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for setting instance machine type.</summary>
    public class SetInstanceMachineTypeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [Compute Engine machine type](https://cloud.google.com/compute/docs/machine-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of Shielded Instance options. Check [Images using supported Shielded VM features] Not all combinations are
    /// valid.
    /// </summary>
    public class ShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
        /// boot integrity of the instance. The attestation is performed against the integrity policy baseline. This
        /// baseline is initially derived from the implicitly trusted boot image when the instance is created. Enabled
        /// by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
        /// authentic software by verifying the digital signature of all boot components, and halting the boot process
        /// if signature verification fails. Disabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>Defines whether the instance has the vTPM enabled. Enabled by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for starting a notebook instance</summary>
    public class StartInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for starting a Managed Notebook Runtime.</summary>
    public class StartRuntimeRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request for stopping a notebook instance</summary>
    public class StopInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for stopping a Managed Notebook Runtime.</summary>
    public class StopRuntimeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for switching a Managed Notebook Runtime.</summary>
    public class SwitchRuntimeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>accelerator config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual RuntimeAcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

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

    /// <summary>Request for created scheduled notebooks</summary>
    public class TriggerScheduleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for updating instance configurations.</summary>
    public class UpdateInstanceConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The instance configurations to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual InstanceConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request for updating the Shielded Instance config for a notebook instance. You can only use this method on a
    /// stopped instance
    /// </summary>
    public class UpdateShieldedInstanceConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ShieldedInstance configuration to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entry of VM image upgrade history.</summary>
    public class UpgradeHistoryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action. Rolloback or Upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The container image before this instance upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual string ContainerImage { get; set; }

        /// <summary>The time that this instance upgrade history entry is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The framework of this notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framework")]
        public virtual string Framework { get; set; }

        /// <summary>The snapshot of the boot disk of this notebook instance before upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual string Snapshot { get; set; }

        /// <summary>The state of this instance upgrade history entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Target VM Image. Format: ainotebooks-vm/project/image-name/name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetImage")]
        public virtual string TargetImage { get; set; }

        /// <summary>Target VM Version, like m63.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVersion")]
        public virtual string TargetVersion { get; set; }

        /// <summary>The version of the notebook instance before this upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The VM image before this instance upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual string VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for upgrading a notebook instance from within the VM</summary>
    public class UpgradeInstanceInternalRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for upgrading a notebook instance</summary>
    public class UpgradeInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime using Virtual Machine for computing.</summary>
    public class VirtualMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique identifier of the Managed Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>Output only. The user-friendly name of the Managed Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; }

        /// <summary>Virtual Machine configuration settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualMachineConfig")]
        public virtual VirtualMachineConfig VirtualMachineConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The config settings for virtual machine.</summary>
    public class VirtualMachineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Compute Engine accelerator configuration for this runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfig")]
        public virtual RuntimeAcceleratorConfig AcceleratorConfig { get; set; }

        /// <summary>Optional. Use a list of container images to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImages")]
        public virtual System.Collections.Generic.IList<ContainerImage> ContainerImages { get; set; }

        /// <summary>Required. Data disk option configuration settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual LocalDisk DataDisk { get; set; }

        /// <summary>Optional. Encryption settings for virtual machine data disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Output only. The Compute Engine guest attributes. (see [Project and instance guest
        /// attributes](https://cloud.google.com/compute/docs/storing-retrieving-metadata#guest_attributes)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guestAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> GuestAttributes { get; set; }

        /// <summary>
        /// Optional. If true, runtime will only have internal IP addresses. By default, runtimes are not restricted to
        /// internal IP addresses, and will have ephemeral external IP addresses assigned to each vm. This
        /// `internal_ip_only` restriction can only be enabled for subnetwork enabled networks, and all dependencies
        /// must be configured to be accessible without external IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIpOnly")]
        public virtual System.Nullable<bool> InternalIpOnly { get; set; }

        /// <summary>
        /// Optional. The labels to associate with this runtime. Label **keys** must contain 1 to 63 characters, and
        /// must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if
        /// present, must contain 1 to 63 characters, and must conform to [RFC
        /// 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The Compute Engine machine type used for runtimes. Short name is valid. Examples: *
        /// `n1-standard-2` * `e2-standard-8`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The Compute Engine metadata entries to add to virtual machine. (see [Project and instance
        /// metadata](https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Optional. The Compute Engine network to be used for machine communications. Cannot be specified with
        /// subnetwork. If neither `network` nor `subnet` is specified, the "default" network of the project is used, if
        /// it exists. A full URL or partial URI. Examples: *
        /// `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/global/default` *
        /// `projects/[project_id]/regions/global/default` Runtimes are managed resources inside Google Infrastructure.
        /// Runtimes support the following network configurations: * Google Managed Network (Network &amp;amp; subnet
        /// are empty) * Consumer Project VPC (network &amp;amp; subnet are required). Requires configuring Private
        /// Service Access. * Shared VPC (network &amp;amp; subnet are required). Requires configuring Private Service
        /// Access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicType")]
        public virtual string NicType { get; set; }

        /// <summary>Optional. Shielded VM Instance configuration settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual RuntimeShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// Optional. The Compute Engine subnetwork to be used for machine communications. Cannot be specified with
        /// network. A full URL or partial URI are valid. Examples: *
        /// `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/us-east1/subnetworks/sub0` *
        /// `projects/[project_id]/regions/us-east1/subnetworks/sub0`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>
        /// Optional. The Compute Engine tags to add to runtime (see [Tagging
        /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Output only. The zone where the virtual machine is located. If using regional request, the notebooks service
        /// will pick a location in the corresponding runtime region. On a get request, zone will always be present.
        /// Example: * `us-central1-b`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a custom Compute Engine virtual machine image for starting a notebook instance with the
    /// environment installed directly on the VM.
    /// </summary>
    public class VmImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use this VM image family to find the image; the newest image in this family will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageFamily")]
        public virtual string ImageFamily { get; set; }

        /// <summary>Use VM image name to find the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageName")]
        public virtual string ImageName { get; set; }

        /// <summary>
        /// Required. The name of the Google Cloud project that this VM image belongs to. Format:
        /// `projects/{project_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
