// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.ToolResults.v1beta3
{
    /// <summary>The ToolResults Service.</summary>
    public class ToolResultsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ToolResultsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ToolResultsService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "toolresults";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://toolresults.googleapis.com/";
        #else
            "https://toolresults.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://toolresults.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Tool Results API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Tool Results API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    ///<summary>A base abstract class for ToolResults requests.</summary>
    public abstract class ToolResultsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ToolResultsBaseServiceRequest instance.</summary>
        protected ToolResultsBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ToolResults parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
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
            Histories = new HistoriesResource(service);

        }

        /// <summary>Gets the Histories resource.</summary>
        public virtual HistoriesResource Histories { get; }

        /// <summary>The "histories" collection of methods.</summary>
        public class HistoriesResource
        {
            private const string Resource = "histories";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HistoriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Executions = new ExecutionsResource(service);

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
                    Clusters = new ClustersResource(service);
                    Environments = new EnvironmentsResource(service);
                    Steps = new StepsResource(service);

                }

                /// <summary>Gets the Clusters resource.</summary>
                public virtual ClustersResource Clusters { get; }

                /// <summary>The "clusters" collection of methods.</summary>
                public class ClustersResource
                {
                    private const string Resource = "clusters";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ClustersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Retrieves a single screenshot cluster by its ID</summary>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">An Execution id. Required.</param>
                    /// <param
                    /// name="clusterId">A Cluster id Required.</param>
                    public virtual GetRequest Get(string projectId, string historyId, string executionId, string clusterId)
                    {
                        return new GetRequest(service, projectId, historyId, executionId, clusterId);
                    }

                    /// <summary>Retrieves a single screenshot cluster by its ID</summary>
                    public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ScreenshotCluster>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string clusterId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            ClusterId = clusterId;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>An Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A Cluster id Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/clusters/{clusterId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "clusterId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "clusterId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Lists Screenshot Clusters Returns the list of screenshot clusters corresponding to an
                    /// execution. Screenshot clusters are created after the execution is finished. Clusters are created
                    /// from a set of screenshots. Between any two screenshots, a matching score is calculated based off
                    /// their metadata that determines how similar they are. Screenshots are placed in the cluster that
                    /// has screens which have the highest matching scores.</summary>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">An Execution id. Required.</param>
                    public virtual ListRequest List(string projectId, string historyId, string executionId)
                    {
                        return new ListRequest(service, projectId, historyId, executionId);
                    }

                    /// <summary>Lists Screenshot Clusters Returns the list of screenshot clusters corresponding to an
                    /// execution. Screenshot clusters are created after the execution is finished. Clusters are created
                    /// from a set of screenshots. Between any two screenshots, a matching score is calculated based off
                    /// their metadata that determines how similar they are. Screenshots are placed in the cluster that
                    /// has screens which have the highest matching scores.</summary>
                    public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListScreenshotClustersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>An Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/clusters";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
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


                    /// <summary>Gets an Environment. May return any of the following canonical error codes: -
                    /// PERMISSION_DENIED - if the user is not authorized to read project - INVALID_ARGUMENT - if the
                    /// request is malformed - NOT_FOUND - if the Environment does not exist</summary>
                    /// <param name="projectId">Required. A Project id.</param>
                    /// <param name="historyId">Required. A History
                    /// id.</param>
                    /// <param name="executionId">Required. An Execution id.</param>
                    /// <param
                    /// name="environmentId">Required. An Environment id.</param>
                    public virtual GetRequest Get(string projectId, string historyId, string executionId, string environmentId)
                    {
                        return new GetRequest(service, projectId, historyId, executionId, environmentId);
                    }

                    /// <summary>Gets an Environment. May return any of the following canonical error codes: -
                    /// PERMISSION_DENIED - if the user is not authorized to read project - INVALID_ARGUMENT - if the
                    /// request is malformed - NOT_FOUND - if the Environment does not exist</summary>
                    public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Environment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string environmentId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            EnvironmentId = environmentId;
                            InitParameters();
                        }


                        /// <summary>Required. A Project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>Required. A History id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>Required. An Execution id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>Required. An Environment id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string EnvironmentId { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/environments/{environmentId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "environmentId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "environmentId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Lists Environments for a given Execution. The Environments are sorted by display name.
                    /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
                    /// authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the
                    /// containing Execution does not exist</summary>
                    /// <param name="projectId">Required. A Project id.</param>
                    /// <param name="historyId">Required. A History
                    /// id.</param>
                    /// <param name="executionId">Required. An Execution id.</param>
                    public virtual ListRequest List(string projectId, string historyId, string executionId)
                    {
                        return new ListRequest(service, projectId, historyId, executionId);
                    }

                    /// <summary>Lists Environments for a given Execution. The Environments are sorted by display name.
                    /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
                    /// authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the
                    /// containing Execution does not exist</summary>
                    public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListEnvironmentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            InitParameters();
                        }


                        /// <summary>Required. A Project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>Required. A History id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>Required. An Execution id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>The maximum number of Environments to fetch. Default value: 25. The server will use
                        /// this default if the field is not set or has a value of 0.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A continuation token to resume the query at the next item.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/environments";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
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
                /// <summary>Gets the Steps resource.</summary>
                public virtual StepsResource Steps { get; }

                /// <summary>The "steps" collection of methods.</summary>
                public class StepsResource
                {
                    private const string Resource = "steps";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public StepsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        PerfMetricsSummary = new PerfMetricsSummaryResource(service);
                        PerfSampleSeries = new PerfSampleSeriesResource(service);
                        TestCases = new TestCasesResource(service);
                        Thumbnails = new ThumbnailsResource(service);

                    }

                    /// <summary>Gets the PerfMetricsSummary resource.</summary>
                    public virtual PerfMetricsSummaryResource PerfMetricsSummary { get; }

                    /// <summary>The "perfMetricsSummary" collection of methods.</summary>
                    public class PerfMetricsSummaryResource
                    {
                        private const string Resource = "perfMetricsSummary";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public PerfMetricsSummaryResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Creates a PerfMetricsSummary resource. Returns the existing one if it has already
                        /// been created. May return any of the following error code(s): - NOT_FOUND - The containing
                        /// Step does not exist</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="projectId">The cloud project</param>
                        /// <param name="historyId">A tool results history
                        /// ID.</param>
                        /// <param name="executionId">A tool results execution ID.</param>
                        /// <param name="stepId">A
                        /// tool results step ID.</param>
                        public virtual CreateRequest Create(Google.Apis.ToolResults.v1beta3.Data.PerfMetricsSummary body, string projectId, string historyId, string executionId, string stepId)
                        {
                            return new CreateRequest(service, body, projectId, historyId, executionId, stepId);
                        }

                        /// <summary>Creates a PerfMetricsSummary resource. Returns the existing one if it has already
                        /// been created. May return any of the following error code(s): - NOT_FOUND - The containing
                        /// Step does not exist</summary>
                        public class CreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.PerfMetricsSummary>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.PerfMetricsSummary body, string projectId, string historyId, string executionId, string stepId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>The cloud project</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A tool results history ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A tool results execution ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A tool results step ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ToolResults.v1beta3.Data.PerfMetricsSummary Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfMetricsSummary";

                            /// <summary>Initializes Create parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }
                    }
                    /// <summary>Gets the PerfSampleSeries resource.</summary>
                    public virtual PerfSampleSeriesResource PerfSampleSeries { get; }

                    /// <summary>The "perfSampleSeries" collection of methods.</summary>
                    public class PerfSampleSeriesResource
                    {
                        private const string Resource = "perfSampleSeries";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public PerfSampleSeriesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Samples = new SamplesResource(service);

                        }

                        /// <summary>Gets the Samples resource.</summary>
                        public virtual SamplesResource Samples { get; }

                        /// <summary>The "samples" collection of methods.</summary>
                        public class SamplesResource
                        {
                            private const string Resource = "samples";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public SamplesResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;

                            }


                            /// <summary>Creates a batch of PerfSamples - a client can submit multiple batches of Perf
                            /// Samples through repeated calls to this method in order to split up a large request
                            /// payload - duplicates and existing timestamp entries will be ignored. - the batch
                            /// operation may partially succeed - the set of elements successfully inserted is returned
                            /// in the response (omits items which already existed in the database). May return any of
                            /// the following canonical error codes: - NOT_FOUND - The containing PerfSampleSeries does
                            /// not exist</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="projectId">The cloud project</param>
                            /// <param name="historyId">A tool results history
                            /// ID.</param>
                            /// <param name="executionId">A tool results execution ID.</param>
                            /// <param name="stepId">A
                            /// tool results step ID.</param>
                            /// <param name="sampleSeriesId">A sample series id</param>
                            public virtual BatchCreateRequest BatchCreate(Google.Apis.ToolResults.v1beta3.Data.BatchCreatePerfSamplesRequest body, string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                            {
                                return new BatchCreateRequest(service, body, projectId, historyId, executionId, stepId, sampleSeriesId);
                            }

                            /// <summary>Creates a batch of PerfSamples - a client can submit multiple batches of Perf
                            /// Samples through repeated calls to this method in order to split up a large request
                            /// payload - duplicates and existing timestamp entries will be ignored. - the batch
                            /// operation may partially succeed - the set of elements successfully inserted is returned
                            /// in the response (omits items which already existed in the database). May return any of
                            /// the following canonical error codes: - NOT_FOUND - The containing PerfSampleSeries does
                            /// not exist</summary>
                            public class BatchCreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.BatchCreatePerfSamplesResponse>
                            {
                                /// <summary>Constructs a new BatchCreate request.</summary>
                                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.BatchCreatePerfSamplesRequest body, string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                                    : base(service)
                                {
                                    ProjectId = projectId;
                                    HistoryId = historyId;
                                    ExecutionId = executionId;
                                    StepId = stepId;
                                    SampleSeriesId = sampleSeriesId;
                                    Body = body;
                                    InitParameters();
                                }


                                /// <summary>The cloud project</summary>
                                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string ProjectId { get; private set; }

                                /// <summary>A tool results history ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string HistoryId { get; private set; }

                                /// <summary>A tool results execution ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string ExecutionId { get; private set; }

                                /// <summary>A tool results step ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string StepId { get; private set; }

                                /// <summary>A sample series id</summary>
                                [Google.Apis.Util.RequestParameterAttribute("sampleSeriesId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string SampleSeriesId { get; private set; }


                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.ToolResults.v1beta3.Data.BatchCreatePerfSamplesRequest Body { get; set; }

                                ///<summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "batchCreate";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfSampleSeries/{sampleSeriesId}/samples:batchCreate";

                                /// <summary>Initializes BatchCreate parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();

                                    RequestParameters.Add(
                                        "projectId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "projectId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "historyId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "historyId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "executionId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "executionId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "stepId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "stepId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "sampleSeriesId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "sampleSeriesId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                }

                            }

                            /// <summary>Lists the Performance Samples of a given Sample Series - The list results are
                            /// sorted by timestamps ascending - The default page size is 500 samples; and maximum size
                            /// allowed 5000 - The response token indicates the last returned PerfSample timestamp -
                            /// When the results size exceeds the page size, submit a subsequent request including the
                            /// page token to return the rest of the samples up to the page limit May return any of the
                            /// following canonical error codes: - OUT_OF_RANGE - The specified request page_token is
                            /// out of valid range - NOT_FOUND - The containing PerfSampleSeries does not
                            /// exist</summary>
                            /// <param name="projectId">The cloud project</param>
                            /// <param name="historyId">A tool results history
                            /// ID.</param>
                            /// <param name="executionId">A tool results execution ID.</param>
                            /// <param name="stepId">A
                            /// tool results step ID.</param>
                            /// <param name="sampleSeriesId">A sample series id</param>
                            public virtual ListRequest List(string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                            {
                                return new ListRequest(service, projectId, historyId, executionId, stepId, sampleSeriesId);
                            }

                            /// <summary>Lists the Performance Samples of a given Sample Series - The list results are
                            /// sorted by timestamps ascending - The default page size is 500 samples; and maximum size
                            /// allowed 5000 - The response token indicates the last returned PerfSample timestamp -
                            /// When the results size exceeds the page size, submit a subsequent request including the
                            /// page token to return the rest of the samples up to the page limit May return any of the
                            /// following canonical error codes: - OUT_OF_RANGE - The specified request page_token is
                            /// out of valid range - NOT_FOUND - The containing PerfSampleSeries does not
                            /// exist</summary>
                            public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListPerfSamplesResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                                    : base(service)
                                {
                                    ProjectId = projectId;
                                    HistoryId = historyId;
                                    ExecutionId = executionId;
                                    StepId = stepId;
                                    SampleSeriesId = sampleSeriesId;
                                    InitParameters();
                                }


                                /// <summary>The cloud project</summary>
                                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string ProjectId { get; private set; }

                                /// <summary>A tool results history ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string HistoryId { get; private set; }

                                /// <summary>A tool results execution ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string ExecutionId { get; private set; }

                                /// <summary>A tool results step ID.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string StepId { get; private set; }

                                /// <summary>A sample series id</summary>
                                [Google.Apis.Util.RequestParameterAttribute("sampleSeriesId", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string SampleSeriesId { get; private set; }

                                /// <summary>The default page size is 500 samples, and the maximum size is 5000. If the
                                /// page_size is greater than 5000, the effective page size will be 5000</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>Optional, the next_page_token returned in the previous response</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }


                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfSampleSeries/{sampleSeriesId}/samples";

                                /// <summary>Initializes List parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();

                                    RequestParameters.Add(
                                        "projectId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "projectId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "historyId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "historyId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "executionId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "executionId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "stepId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "stepId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "sampleSeriesId", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "sampleSeriesId",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "pageSize", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "pageSize",
                                            IsRequired = false,
                                            ParameterType = "query",
                                            DefaultValue = null,
                                            Pattern = null,
                                        });
                                    RequestParameters.Add(
                                        "pageToken", new Google.Apis.Discovery.Parameter
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

                        /// <summary>Creates a PerfSampleSeries. May return any of the following error code(s): -
                        /// ALREADY_EXISTS - PerfMetricSummary already exists for the given Step - NOT_FOUND - The
                        /// containing Step does not exist</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="projectId">The cloud project</param>
                        /// <param name="historyId">A tool results history
                        /// ID.</param>
                        /// <param name="executionId">A tool results execution ID.</param>
                        /// <param name="stepId">A
                        /// tool results step ID.</param>
                        public virtual CreateRequest Create(Google.Apis.ToolResults.v1beta3.Data.PerfSampleSeries body, string projectId, string historyId, string executionId, string stepId)
                        {
                            return new CreateRequest(service, body, projectId, historyId, executionId, stepId);
                        }

                        /// <summary>Creates a PerfSampleSeries. May return any of the following error code(s): -
                        /// ALREADY_EXISTS - PerfMetricSummary already exists for the given Step - NOT_FOUND - The
                        /// containing Step does not exist</summary>
                        public class CreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.PerfSampleSeries>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.PerfSampleSeries body, string projectId, string historyId, string executionId, string stepId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>The cloud project</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A tool results history ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A tool results execution ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A tool results step ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ToolResults.v1beta3.Data.PerfSampleSeries Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfSampleSeries";

                            /// <summary>Initializes Create parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Gets a PerfSampleSeries. May return any of the following error code(s): - NOT_FOUND
                        /// - The specified PerfSampleSeries does not exist</summary>
                        /// <param name="projectId">The cloud project</param>
                        /// <param name="historyId">A tool results history
                        /// ID.</param>
                        /// <param name="executionId">A tool results execution ID.</param>
                        /// <param name="stepId">A
                        /// tool results step ID.</param>
                        /// <param name="sampleSeriesId">A sample series id</param>
                        public virtual GetRequest Get(string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                        {
                            return new GetRequest(service, projectId, historyId, executionId, stepId, sampleSeriesId);
                        }

                        /// <summary>Gets a PerfSampleSeries. May return any of the following error code(s): - NOT_FOUND
                        /// - The specified PerfSampleSeries does not exist</summary>
                        public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.PerfSampleSeries>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId, string sampleSeriesId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                SampleSeriesId = sampleSeriesId;
                                InitParameters();
                            }


                            /// <summary>The cloud project</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A tool results history ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A tool results execution ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A tool results step ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }

                            /// <summary>A sample series id</summary>
                            [Google.Apis.Util.RequestParameterAttribute("sampleSeriesId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string SampleSeriesId { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfSampleSeries/{sampleSeriesId}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "sampleSeriesId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "sampleSeriesId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Lists PerfSampleSeries for a given Step. The request provides an optional filter
                        /// which specifies one or more PerfMetricsType to include in the result; if none returns all.
                        /// The resulting PerfSampleSeries are sorted by ids. May return any of the following canonical
                        /// error codes: - NOT_FOUND - The containing Step does not exist</summary>
                        /// <param name="projectId">The cloud project</param>
                        /// <param name="historyId">A tool results history
                        /// ID.</param>
                        /// <param name="executionId">A tool results execution ID.</param>
                        /// <param name="stepId">A
                        /// tool results step ID.</param>
                        public virtual ListRequest List(string projectId, string historyId, string executionId, string stepId)
                        {
                            return new ListRequest(service, projectId, historyId, executionId, stepId);
                        }

                        /// <summary>Lists PerfSampleSeries for a given Step. The request provides an optional filter
                        /// which specifies one or more PerfMetricsType to include in the result; if none returns all.
                        /// The resulting PerfSampleSeries are sorted by ids. May return any of the following canonical
                        /// error codes: - NOT_FOUND - The containing Step does not exist</summary>
                        public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListPerfSampleSeriesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                InitParameters();
                            }


                            /// <summary>The cloud project</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A tool results history ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A tool results execution ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A tool results step ID.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }

                            /// <summary>Specify one or more PerfMetricType values such as CPU to filter the
                            /// result</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<FilterEnum> Filter { get; set; }

                            /// <summary>Specify one or more PerfMetricType values such as CPU to filter the
                            /// result</summary>
                            public enum FilterEnum
                            {
                                [Google.Apis.Util.StringValueAttribute("perfMetricTypeUnspecified")]
                                PerfMetricTypeUnspecified,
                                [Google.Apis.Util.StringValueAttribute("memory")]
                                Memory,
                                [Google.Apis.Util.StringValueAttribute("cpu")]
                                Cpu,
                                [Google.Apis.Util.StringValueAttribute("network")]
                                Network,
                                [Google.Apis.Util.StringValueAttribute("graphics")]
                                Graphics,
                            }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfSampleSeries";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "filter", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "filter",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }
                    }
                    /// <summary>Gets the TestCases resource.</summary>
                    public virtual TestCasesResource TestCases { get; }

                    /// <summary>The "testCases" collection of methods.</summary>
                    public class TestCasesResource
                    {
                        private const string Resource = "testCases";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TestCasesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Gets details of a Test Case for a Step. Experimental test cases API. Still in
                        /// active development. May return any of the following canonical error codes: -
                        /// PERMISSION_DENIED - if the user is not authorized to write to project - INVALID_ARGUMENT -
                        /// if the request is malformed - NOT_FOUND - if the containing Test Case does not
                        /// exist</summary>
                        /// <param name="projectId">A Project id. Required.</param>
                        /// <param name="historyId">A History id.
                        /// Required.</param>
                        /// <param name="executionId">A Execution id Required.</param>
                        /// <param name="stepId">A
                        /// Step id. Note: This step must include a TestExecutionStep. Required.</param>
                        /// <param name="testCaseId">A Test
                        /// Case id. Required.</param>
                        public virtual GetRequest Get(string projectId, string historyId, string executionId, string stepId, string testCaseId)
                        {
                            return new GetRequest(service, projectId, historyId, executionId, stepId, testCaseId);
                        }

                        /// <summary>Gets details of a Test Case for a Step. Experimental test cases API. Still in
                        /// active development. May return any of the following canonical error codes: -
                        /// PERMISSION_DENIED - if the user is not authorized to write to project - INVALID_ARGUMENT -
                        /// if the request is malformed - NOT_FOUND - if the containing Test Case does not
                        /// exist</summary>
                        public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.TestCase>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId, string testCaseId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                TestCaseId = testCaseId;
                                InitParameters();
                            }


                            /// <summary>A Project id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A History id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A Execution id Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A Step id. Note: This step must include a TestExecutionStep.
                            /// Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }

                            /// <summary>A Test Case id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("testCaseId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string TestCaseId { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/testCases/{testCaseId}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "testCaseId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "testCaseId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Lists Test Cases attached to a Step. Experimental test cases API. Still in active
                        /// development. May return any of the following canonical error codes: - PERMISSION_DENIED - if
                        /// the user is not authorized to write to project - INVALID_ARGUMENT - if the request is
                        /// malformed - NOT_FOUND - if the containing Step does not exist</summary>
                        /// <param name="projectId">A Project id. Required.</param>
                        /// <param name="historyId">A History id.
                        /// Required.</param>
                        /// <param name="executionId">A Execution id Required.</param>
                        /// <param name="stepId">A
                        /// Step id. Note: This step must include a TestExecutionStep. Required.</param>
                        public virtual ListRequest List(string projectId, string historyId, string executionId, string stepId)
                        {
                            return new ListRequest(service, projectId, historyId, executionId, stepId);
                        }

                        /// <summary>Lists Test Cases attached to a Step. Experimental test cases API. Still in active
                        /// development. May return any of the following canonical error codes: - PERMISSION_DENIED - if
                        /// the user is not authorized to write to project - INVALID_ARGUMENT - if the request is
                        /// malformed - NOT_FOUND - if the containing Step does not exist</summary>
                        public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListTestCasesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                InitParameters();
                            }


                            /// <summary>A Project id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A History id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>A Execution id Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A Step id. Note: This step must include a TestExecutionStep.
                            /// Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }

                            /// <summary>The maximum number of TestCases to fetch. Default value: 100. The server will
                            /// use this default if the field is not set or has a value of 0. Optional.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>A continuation token to resume the query at the next item. Optional.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/testCases";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "pageSize", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "pageSize",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "pageToken", new Google.Apis.Discovery.Parameter
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
                    /// <summary>Gets the Thumbnails resource.</summary>
                    public virtual ThumbnailsResource Thumbnails { get; }

                    /// <summary>The "thumbnails" collection of methods.</summary>
                    public class ThumbnailsResource
                    {
                        private const string Resource = "thumbnails";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ThumbnailsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Lists thumbnails of images attached to a step. May return any of the following
                        /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to read from the
                        /// project, or from any of the images - INVALID_ARGUMENT - if the request is malformed -
                        /// NOT_FOUND - if the step does not exist, or if any of the images do not exist</summary>
                        /// <param name="projectId">A Project id. Required.</param>
                        /// <param name="historyId">A History id.
                        /// Required.</param>
                        /// <param name="executionId">An Execution id. Required.</param>
                        /// <param
                        /// name="stepId">A Step id. Required.</param>
                        public virtual ListRequest List(string projectId, string historyId, string executionId, string stepId)
                        {
                            return new ListRequest(service, projectId, historyId, executionId, stepId);
                        }

                        /// <summary>Lists thumbnails of images attached to a step. May return any of the following
                        /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to read from the
                        /// project, or from any of the images - INVALID_ARGUMENT - if the request is malformed -
                        /// NOT_FOUND - if the step does not exist, or if any of the images do not exist</summary>
                        public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListStepThumbnailsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId)
                                : base(service)
                            {
                                ProjectId = projectId;
                                HistoryId = historyId;
                                ExecutionId = executionId;
                                StepId = stepId;
                                InitParameters();
                            }


                            /// <summary>A Project id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectId { get; private set; }

                            /// <summary>A History id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string HistoryId { get; private set; }

                            /// <summary>An Execution id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ExecutionId { get; private set; }

                            /// <summary>A Step id. Required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string StepId { get; private set; }

                            /// <summary>The maximum number of thumbnails to fetch. Default value: 50. The server will
                            /// use this default if the field is not set or has a value of 0. Optional.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>A continuation token to resume the query at the next item. Optional.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/thumbnails";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "projectId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "projectId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "historyId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "historyId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "executionId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "executionId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "stepId", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "stepId",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "pageSize", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "pageSize",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                RequestParameters.Add(
                                    "pageToken", new Google.Apis.Discovery.Parameter
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

                    /// <summary>Lists accessibility clusters for a given Step May return any of the following canonical
                    /// error codes: - PERMISSION_DENIED - if the user is not authorized to read project -
                    /// INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if an argument in the
                    /// request happens to be invalid; e.g. if the locale format is incorrect - NOT_FOUND - if the
                    /// containing Step does not exist</summary>
                    /// <param name="name">A full resource name of the step. For example, projects/my-
                    /// project/histories/bh.1234567890abcdef/executions/ 1234567890123456789/steps/bs.1234567890abcdef
                    /// Required.</param>
                    public virtual AccessibilityClustersRequest AccessibilityClusters(string name)
                    {
                        return new AccessibilityClustersRequest(service, name);
                    }

                    /// <summary>Lists accessibility clusters for a given Step May return any of the following canonical
                    /// error codes: - PERMISSION_DENIED - if the user is not authorized to read project -
                    /// INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if an argument in the
                    /// request happens to be invalid; e.g. if the locale format is incorrect - NOT_FOUND - if the
                    /// containing Step does not exist</summary>
                    public class AccessibilityClustersRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListStepAccessibilityClustersResponse>
                    {
                        /// <summary>Constructs a new AccessibilityClusters request.</summary>
                        public AccessibilityClustersRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>A full resource name of the step. For example, projects/my-
                        /// project/histories/bh.1234567890abcdef/executions/
                        /// 1234567890123456789/steps/bs.1234567890abcdef Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The accepted format is the canonical Unicode format with hyphen as a delimiter.
                        /// Language must be lowercase, Language Script - Capitalized, Region - UPPERCASE. See
                        /// http://www.unicode.org/reports/tr35/#Unicode_locale_identifier for details.
                        /// Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Locale { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "accessibilityClusters";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/{+name}:accessibilityClusters";

                        /// <summary>Initializes AccessibilityClusters parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/histories/[^/]+/executions/[^/]+/steps/[^/]+$",
                                });
                            RequestParameters.Add(
                                "locale", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "locale",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Creates a Step. The returned Step will have the id set. May return any of the following
                    /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to project -
                    /// INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the step is too large
                    /// (more than 10Mib) - NOT_FOUND - if the containing Execution does not exist</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">Required. A Project id.</param>
                    /// <param name="historyId">Required. A History
                    /// id.</param>
                    /// <param name="executionId">Required. An Execution id.</param>
                    public virtual CreateRequest Create(Google.Apis.ToolResults.v1beta3.Data.Step body, string projectId, string historyId, string executionId)
                    {
                        return new CreateRequest(service, body, projectId, historyId, executionId);
                    }

                    /// <summary>Creates a Step. The returned Step will have the id set. May return any of the following
                    /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to project -
                    /// INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the step is too large
                    /// (more than 10Mib) - NOT_FOUND - if the containing Execution does not exist</summary>
                    public class CreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Step>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.Step body, string projectId, string historyId, string executionId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. A Project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>Required. A History id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>Required. An Execution id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A unique request ID for server to detect duplicated requests. For example, a UUID.
                        /// Optional, but strongly recommended.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ToolResults.v1beta3.Data.Step Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "requestId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "requestId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Gets a Step. May return any of the following canonical error codes: - PERMISSION_DENIED
                    /// - if the user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed
                    /// - NOT_FOUND - if the Step does not exist</summary>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">A Execution id. Required.</param>
                    /// <param name="stepId">A
                    /// Step id. Required.</param>
                    public virtual GetRequest Get(string projectId, string historyId, string executionId, string stepId)
                    {
                        return new GetRequest(service, projectId, historyId, executionId, stepId);
                    }

                    /// <summary>Gets a Step. May return any of the following canonical error codes: - PERMISSION_DENIED
                    /// - if the user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed
                    /// - NOT_FOUND - if the Step does not exist</summary>
                    public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Step>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            StepId = stepId;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>A Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A Step id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string StepId { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "stepId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "stepId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Retrieves a PerfMetricsSummary. May return any of the following error code(s): -
                    /// NOT_FOUND - The specified PerfMetricsSummary does not exist</summary>
                    /// <param name="projectId">The cloud project</param>
                    /// <param name="historyId">A tool results history
                    /// ID.</param>
                    /// <param name="executionId">A tool results execution ID.</param>
                    /// <param name="stepId">A
                    /// tool results step ID.</param>
                    public virtual GetPerfMetricsSummaryRequest GetPerfMetricsSummary(string projectId, string historyId, string executionId, string stepId)
                    {
                        return new GetPerfMetricsSummaryRequest(service, projectId, historyId, executionId, stepId);
                    }

                    /// <summary>Retrieves a PerfMetricsSummary. May return any of the following error code(s): -
                    /// NOT_FOUND - The specified PerfMetricsSummary does not exist</summary>
                    public class GetPerfMetricsSummaryRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.PerfMetricsSummary>
                    {
                        /// <summary>Constructs a new GetPerfMetricsSummary request.</summary>
                        public GetPerfMetricsSummaryRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId, string stepId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            StepId = stepId;
                            InitParameters();
                        }


                        /// <summary>The cloud project</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A tool results history ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>A tool results execution ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A tool results step ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string StepId { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "getPerfMetricsSummary";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}/perfMetricsSummary";

                        /// <summary>Initializes GetPerfMetricsSummary parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "stepId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "stepId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Lists Steps for a given Execution. The steps are sorted by creation_time in descending
                    /// order. The step_id key will be used to order the steps with the same creation_time. May return
                    /// any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized
                    /// to read project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if an
                    /// argument in the request happens to be invalid; e.g. if an attempt is made to list the children
                    /// of a nonexistent Step - NOT_FOUND - if the containing Execution does not exist</summary>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">A Execution id. Required.</param>
                    public virtual ListRequest List(string projectId, string historyId, string executionId)
                    {
                        return new ListRequest(service, projectId, historyId, executionId);
                    }

                    /// <summary>Lists Steps for a given Execution. The steps are sorted by creation_time in descending
                    /// order. The step_id key will be used to order the steps with the same creation_time. May return
                    /// any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized
                    /// to read project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if an
                    /// argument in the request happens to be invalid; e.g. if an attempt is made to list the children
                    /// of a nonexistent Step - NOT_FOUND - if the containing Execution does not exist</summary>
                    public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListStepsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>A Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>The maximum number of Steps to fetch. Default value: 25. The server will use this
                        /// default if the field is not set or has a value of 0. Optional.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A continuation token to resume the query at the next item. Optional.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates an existing Step with the supplied partial entity. May return any of the
                    /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write
                    /// project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the
                    /// requested state transition is illegal (e.g try to upload a duplicate xml file), if the updated
                    /// step is too large (more than 10Mib) - NOT_FOUND - if the containing Execution does not
                    /// exist</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">A Execution id. Required.</param>
                    /// <param name="stepId">A
                    /// Step id. Required.</param>
                    public virtual PatchRequest Patch(Google.Apis.ToolResults.v1beta3.Data.Step body, string projectId, string historyId, string executionId, string stepId)
                    {
                        return new PatchRequest(service, body, projectId, historyId, executionId, stepId);
                    }

                    /// <summary>Updates an existing Step with the supplied partial entity. May return any of the
                    /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write
                    /// project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the
                    /// requested state transition is illegal (e.g try to upload a duplicate xml file), if the updated
                    /// step is too large (more than 10Mib) - NOT_FOUND - if the containing Execution does not
                    /// exist</summary>
                    public class PatchRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Step>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.Step body, string projectId, string historyId, string executionId, string stepId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            StepId = stepId;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>A Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A Step id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string StepId { get; private set; }

                        /// <summary>A unique request ID for server to detect duplicated requests. For example, a UUID.
                        /// Optional, but strongly recommended.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ToolResults.v1beta3.Data.Step Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "stepId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "stepId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "requestId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "requestId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Publish xml files to an existing Step. May return any of the following canonical error
                    /// codes: - PERMISSION_DENIED - if the user is not authorized to write project - INVALID_ARGUMENT -
                    /// if the request is malformed - FAILED_PRECONDITION - if the requested state transition is
                    /// illegal, e.g try to upload a duplicate xml file or a file too large. - NOT_FOUND - if the
                    /// containing Execution does not exist</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">A Project id. Required.</param>
                    /// <param name="historyId">A History id.
                    /// Required.</param>
                    /// <param name="executionId">A Execution id. Required.</param>
                    /// <param name="stepId">A
                    /// Step id. Note: This step must include a TestExecutionStep. Required.</param>
                    public virtual PublishXunitXmlFilesRequest PublishXunitXmlFiles(Google.Apis.ToolResults.v1beta3.Data.PublishXunitXmlFilesRequest body, string projectId, string historyId, string executionId, string stepId)
                    {
                        return new PublishXunitXmlFilesRequest(service, body, projectId, historyId, executionId, stepId);
                    }

                    /// <summary>Publish xml files to an existing Step. May return any of the following canonical error
                    /// codes: - PERMISSION_DENIED - if the user is not authorized to write project - INVALID_ARGUMENT -
                    /// if the request is malformed - FAILED_PRECONDITION - if the requested state transition is
                    /// illegal, e.g try to upload a duplicate xml file or a file too large. - NOT_FOUND - if the
                    /// containing Execution does not exist</summary>
                    public class PublishXunitXmlFilesRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Step>
                    {
                        /// <summary>Constructs a new PublishXunitXmlFiles request.</summary>
                        public PublishXunitXmlFilesRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.PublishXunitXmlFilesRequest body, string projectId, string historyId, string executionId, string stepId)
                            : base(service)
                        {
                            ProjectId = projectId;
                            HistoryId = historyId;
                            ExecutionId = executionId;
                            StepId = stepId;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>A Project id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>A History id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string HistoryId { get; private set; }

                        /// <summary>A Execution id. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ExecutionId { get; private set; }

                        /// <summary>A Step id. Note: This step must include a TestExecutionStep. Required.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("stepId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string StepId { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ToolResults.v1beta3.Data.PublishXunitXmlFilesRequest Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "publishXunitXmlFiles";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}/steps/{stepId}:publishXunitXmlFiles";

                        /// <summary>Initializes PublishXunitXmlFiles parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "projectId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "historyId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "historyId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "executionId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "stepId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "stepId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }

                /// <summary>Creates an Execution. The returned Execution will have the id set. May return any of the
                /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to
                /// project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the containing History
                /// does not exist</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">A Project id. Required.</param>
                /// <param name="historyId">A History id.
                /// Required.</param>
                public virtual CreateRequest Create(Google.Apis.ToolResults.v1beta3.Data.Execution body, string projectId, string historyId)
                {
                    return new CreateRequest(service, body, projectId, historyId);
                }

                /// <summary>Creates an Execution. The returned Execution will have the id set. May return any of the
                /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to
                /// project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the containing History
                /// does not exist</summary>
                public class CreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Execution>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.Execution body, string projectId, string historyId)
                        : base(service)
                    {
                        ProjectId = projectId;
                        HistoryId = historyId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>A Project id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>A History id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HistoryId { get; private set; }

                    /// <summary>A unique request ID for server to detect duplicated requests. For example, a UUID.
                    /// Optional, but strongly recommended.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ToolResults.v1beta3.Data.Execution Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "historyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "historyId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Gets an Execution. May return any of the following canonical error codes: -
                /// PERMISSION_DENIED - if the user is not authorized to write to project - INVALID_ARGUMENT - if the
                /// request is malformed - NOT_FOUND - if the Execution does not exist</summary>
                /// <param name="projectId">A Project id. Required.</param>
                /// <param name="historyId">A History id.
                /// Required.</param>
                /// <param name="executionId">An Execution id. Required.</param>
                public virtual GetRequest Get(string projectId, string historyId, string executionId)
                {
                    return new GetRequest(service, projectId, historyId, executionId);
                }

                /// <summary>Gets an Execution. May return any of the following canonical error codes: -
                /// PERMISSION_DENIED - if the user is not authorized to write to project - INVALID_ARGUMENT - if the
                /// request is malformed - NOT_FOUND - if the Execution does not exist</summary>
                public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Execution>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId, string executionId)
                        : base(service)
                    {
                        ProjectId = projectId;
                        HistoryId = historyId;
                        ExecutionId = executionId;
                        InitParameters();
                    }


                    /// <summary>A Project id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>A History id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HistoryId { get; private set; }

                    /// <summary>An Execution id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ExecutionId { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "historyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "historyId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "executionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "executionId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Lists Executions for a given History. The executions are sorted by creation_time in
                /// descending order. The execution_id key will be used to order the executions with the same
                /// creation_time. May return any of the following canonical error codes: - PERMISSION_DENIED - if the
                /// user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND
                /// - if the containing History does not exist</summary>
                /// <param name="projectId">A Project id. Required.</param>
                /// <param name="historyId">A History id.
                /// Required.</param>
                public virtual ListRequest List(string projectId, string historyId)
                {
                    return new ListRequest(service, projectId, historyId);
                }

                /// <summary>Lists Executions for a given History. The executions are sorted by creation_time in
                /// descending order. The execution_id key will be used to order the executions with the same
                /// creation_time. May return any of the following canonical error codes: - PERMISSION_DENIED - if the
                /// user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND
                /// - if the containing History does not exist</summary>
                public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListExecutionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string historyId)
                        : base(service)
                    {
                        ProjectId = projectId;
                        HistoryId = historyId;
                        InitParameters();
                    }


                    /// <summary>A Project id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>A History id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HistoryId { get; private set; }

                    /// <summary>The maximum number of Executions to fetch. Default value: 25. The server will use this
                    /// default if the field is not set or has a value of 0. Optional.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A continuation token to resume the query at the next item. Optional.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "historyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "historyId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Updates an existing Execution with the supplied partial entity. May return any of the
                /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to
                /// project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the requested
                /// state transition is illegal - NOT_FOUND - if the containing History does not exist</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">A Project id. Required.</param>
                /// <param name="historyId">Required.</param>
                ///
                /// <param name="executionId">Required.</param>
                public virtual PatchRequest Patch(Google.Apis.ToolResults.v1beta3.Data.Execution body, string projectId, string historyId, string executionId)
                {
                    return new PatchRequest(service, body, projectId, historyId, executionId);
                }

                /// <summary>Updates an existing Execution with the supplied partial entity. May return any of the
                /// following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to
                /// project - INVALID_ARGUMENT - if the request is malformed - FAILED_PRECONDITION - if the requested
                /// state transition is illegal - NOT_FOUND - if the containing History does not exist</summary>
                public class PatchRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.Execution>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.Execution body, string projectId, string historyId, string executionId)
                        : base(service)
                    {
                        ProjectId = projectId;
                        HistoryId = historyId;
                        ExecutionId = executionId;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>A Project id. Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string HistoryId { get; private set; }

                    /// <summary>Required.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("executionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ExecutionId { get; private set; }

                    /// <summary>A unique request ID for server to detect duplicated requests. For example, a UUID.
                    /// Optional, but strongly recommended.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ToolResults.v1beta3.Data.Execution Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}/executions/{executionId}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "historyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "historyId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "executionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "executionId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }
            }

            /// <summary>Creates a History. The returned History will have the id set. May return any of the following
            /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to project -
            /// INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the containing project does not
            /// exist</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">A Project id. Required.</param>
            public virtual CreateRequest Create(Google.Apis.ToolResults.v1beta3.Data.History body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>Creates a History. The returned History will have the id set. May return any of the following
            /// canonical error codes: - PERMISSION_DENIED - if the user is not authorized to write to project -
            /// INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the containing project does not
            /// exist</summary>
            public class CreateRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.History>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ToolResults.v1beta3.Data.History body, string projectId)
                    : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>A Project id. Required.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>A unique request ID for server to detect duplicated requests. For example, a UUID.
                /// Optional, but strongly recommended.</summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ToolResults.v1beta3.Data.History Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Gets a History. May return any of the following canonical error codes: - PERMISSION_DENIED - if
            /// the user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND
            /// - if the History does not exist</summary>
            /// <param name="projectId">A Project id. Required.</param>
            /// <param name="historyId">A History id.
            /// Required.</param>
            public virtual GetRequest Get(string projectId, string historyId)
            {
                return new GetRequest(service, projectId, historyId);
            }

            /// <summary>Gets a History. May return any of the following canonical error codes: - PERMISSION_DENIED - if
            /// the user is not authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND
            /// - if the History does not exist</summary>
            public class GetRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.History>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string historyId)
                    : base(service)
                {
                    ProjectId = projectId;
                    HistoryId = historyId;
                    InitParameters();
                }


                /// <summary>A Project id. Required.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>A History id. Required.</summary>
                [Google.Apis.Util.RequestParameterAttribute("historyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string HistoryId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories/{historyId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "historyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "historyId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists Histories for a given Project. The histories are sorted by modification time in
            /// descending order. The history_id key will be used to order the history with the same modification time.
            /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
            /// authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the History
            /// does not exist</summary>
            /// <param name="projectId">A Project id. Required.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>Lists Histories for a given Project. The histories are sorted by modification time in
            /// descending order. The history_id key will be used to order the history with the same modification time.
            /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
            /// authorized to read project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the History
            /// does not exist</summary>
            public class ListRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ListHistoriesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId)
                    : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }


                /// <summary>A Project id. Required.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>If set, only return histories with the given name. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filterByName", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FilterByName { get; set; }

                /// <summary>The maximum number of Histories to fetch. Default value: 20. The server will use this
                /// default if the field is not set or has a value of 0. Any value greater than 100 will be treated as
                /// 100. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A continuation token to resume the query at the next item. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "toolresults/v1beta3/projects/{projectId}/histories";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "filterByName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filterByName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
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

        /// <summary>Gets the Tool Results settings for a project. May return any of the following canonical error
        /// codes: - PERMISSION_DENIED - if the user is not authorized to read from project</summary>
        /// <param name="projectId">A Project id. Required.</param>
        public virtual GetSettingsRequest GetSettings(string projectId)
        {
            return new GetSettingsRequest(service, projectId);
        }

        /// <summary>Gets the Tool Results settings for a project. May return any of the following canonical error
        /// codes: - PERMISSION_DENIED - if the user is not authorized to read from project</summary>
        public class GetSettingsRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ProjectSettings>
        {
            /// <summary>Constructs a new GetSettings request.</summary>
            public GetSettingsRequest(Google.Apis.Services.IClientService service, string projectId)
                : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }


            /// <summary>A Project id. Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "getSettings";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "toolresults/v1beta3/projects/{projectId}/settings";

            /// <summary>Initializes GetSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates resources for settings which have not yet been set. Currently, this creates a single
        /// resource: a Google Cloud Storage bucket, to be used as the default bucket for this project. The bucket is
        /// created in an FTL-own storage project. Except for in rare cases, calling this method in parallel from
        /// multiple clients will only create a single bucket. In order to avoid unnecessary storage charges, the bucket
        /// is configured to automatically delete objects older than 90 days. The bucket is created with the following
        /// permissions: - Owner access for owners of central storage project (FTL-owned) - Writer access for
        /// owners/editors of customer project - Reader access for viewers of customer project The default ACL on
        /// objects created in the bucket is: - Owner access for owners of central storage project - Reader access for
        /// owners/editors/viewers of customer project See Google Cloud Storage documentation for more details. If there
        /// is already a default bucket set and the project can access the bucket, this call does nothing. However, if
        /// the project doesn't have the permission to access the bucket or the bucket is deleted, a new bucket will be
        /// created. May return any canonical error codes, including the following: - PERMISSION_DENIED - if the user is
        /// not authorized to write to project - Any error code raised by Google Cloud Storage</summary>
        /// <param name="projectId">A Project id. Required.</param>
        public virtual InitializeSettingsRequest InitializeSettings(string projectId)
        {
            return new InitializeSettingsRequest(service, projectId);
        }

        /// <summary>Creates resources for settings which have not yet been set. Currently, this creates a single
        /// resource: a Google Cloud Storage bucket, to be used as the default bucket for this project. The bucket is
        /// created in an FTL-own storage project. Except for in rare cases, calling this method in parallel from
        /// multiple clients will only create a single bucket. In order to avoid unnecessary storage charges, the bucket
        /// is configured to automatically delete objects older than 90 days. The bucket is created with the following
        /// permissions: - Owner access for owners of central storage project (FTL-owned) - Writer access for
        /// owners/editors of customer project - Reader access for viewers of customer project The default ACL on
        /// objects created in the bucket is: - Owner access for owners of central storage project - Reader access for
        /// owners/editors/viewers of customer project See Google Cloud Storage documentation for more details. If there
        /// is already a default bucket set and the project can access the bucket, this call does nothing. However, if
        /// the project doesn't have the permission to access the bucket or the bucket is deleted, a new bucket will be
        /// created. May return any canonical error codes, including the following: - PERMISSION_DENIED - if the user is
        /// not authorized to write to project - Any error code raised by Google Cloud Storage</summary>
        public class InitializeSettingsRequest : ToolResultsBaseServiceRequest<Google.Apis.ToolResults.v1beta3.Data.ProjectSettings>
        {
            /// <summary>Constructs a new InitializeSettings request.</summary>
            public InitializeSettingsRequest(Google.Apis.Services.IClientService service, string projectId)
                : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }


            /// <summary>A Project id. Required.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "initializeSettings";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "toolresults/v1beta3/projects/{projectId}:initializeSettings";

            /// <summary>Initializes InitializeSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.ToolResults.v1beta3.Data
{    

    /// <summary>Additional details for an ANR crash.</summary>
    public class ANR : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the ANR crash. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Android app information.</summary>
    public class AndroidAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the app. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The package name of the app. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; } 

        /// <summary>The internal version code of the app. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual string VersionCode { get; set; } 

        /// <summary>The version name of the app. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A test of an Android application that can control an Android component independently of its normal
    /// lifecycle. See for more information on types of Android tests.</summary>
    public class AndroidInstrumentationTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The java package for the test to be executed. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testPackageId")]
        public virtual string TestPackageId { get; set; } 

        /// <summary>The InstrumentationTestRunner class. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testRunnerClass")]
        public virtual string TestRunnerClass { get; set; } 

        /// <summary>Each target must be fully qualified with the package name or class name, in one of these formats: -
        /// "package package_name" - "class package_name.class_name" - "class package_name.class_name#method_name" If
        /// empty, all targets in the module will be run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargets")]
        public virtual System.Collections.Generic.IList<string> TestTargets { get; set; } 

        /// <summary>The flag indicates whether Android Test Orchestrator will be used to run test or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useOrchestrator")]
        public virtual System.Nullable<bool> UseOrchestrator { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A test of an android application that explores the application on a virtual or physical Android device,
    /// finding culprits and crashes as it goes.</summary>
    public class AndroidRoboTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The initial activity that should be used to start the app. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInitialActivity")]
        public virtual string AppInitialActivity { get; set; } 

        /// <summary>The java package for the bootstrap. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootstrapPackageId")]
        public virtual string BootstrapPackageId { get; set; } 

        /// <summary>The runner class for the bootstrap. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootstrapRunnerClass")]
        public virtual string BootstrapRunnerClass { get; set; } 

        /// <summary>The max depth of the traversal stack Robo can explore. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDepth")]
        public virtual System.Nullable<int> MaxDepth { get; set; } 

        /// <summary>The max number of steps/actions Robo can execute. Default is no limit (0). Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSteps")]
        public virtual System.Nullable<int> MaxSteps { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Android mobile test specification.</summary>
    public class AndroidTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppInfo")]
        public virtual AndroidAppInfo AndroidAppInfo { get; set; } 

        /// <summary>An Android instrumentation test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInstrumentationTest")]
        public virtual AndroidInstrumentationTest AndroidInstrumentationTest { get; set; } 

        /// <summary>An Android robo test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidRoboTest")]
        public virtual AndroidRoboTest AndroidRoboTest { get; set; } 

        /// <summary>An Android test loop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidTestLoop")]
        public virtual AndroidTestLoop AndroidTestLoop { get; set; } 

        /// <summary>Max time a test is allowed to run before it is automatically cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTimeout")]
        public virtual Duration TestTimeout { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Test Loops are tests that can be launched by the app itself, determining when to run by listening for
    /// an intent.</summary>
    public class AndroidTestLoop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary> `Any` contains an arbitrary serialized protocol buffer message along with a URL that describes the
    /// type of the serialized message. Protobuf library provides support to pack/unpack Any values in the form of
    /// utility functions or additional generated methods of the Any type. Example 1: Pack and unpack a message in C++.
    /// Foo foo = ...; Any any; any.PackFrom(foo); ... if (any.UnpackTo()) { ... } Example 2: Pack and unpack a message
    /// in Java. Foo foo = ...; Any any = Any.pack(foo); ... if (any.is(Foo.class)) { foo = any.unpack(Foo.class); }
    /// Example 3: Pack and unpack a message in Python. foo = Foo(...) any = Any() any.Pack(foo) ... if
    /// any.Is(Foo.DESCRIPTOR): any.Unpack(foo) ... Example 4: Pack and unpack a message in Go foo := {...} any, err :=
    /// ptypes.MarshalAny(foo) ... foo := {} if err := ptypes.UnmarshalAny(any, foo); err != nil { ... } The pack
    /// methods provided by protobuf library will by default use 'type.googleapis.com/full.type.name' as the type URL
    /// and the unpack methods only use the fully qualified type name after the last '/' in the type URL, for example
    /// "foo.bar.com/x/y.z" will yield type name "y.z". # JSON The JSON representation of an `Any` value uses the
    /// regular representation of the deserialized, embedded message, with an additional field `@type` which contains
    /// the type URL. Example: package google.profile; message Person { string first_name = 1; string last_name = 2; } {
    /// "@type": "type.googleapis.com/google.profile.Person", "firstName": , "lastName": } If the embedded message type
    /// is well-known and has a custom JSON representation, that representation will be embedded adding a field `value`
    /// which holds the custom JSON in addition to the `@type` field. Example (for message google.protobuf.Duration): {
    /// "@type": "type.googleapis.com/google.protobuf.Duration", "value": "1.212s" }</summary>
    public class Any : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A URL/resource name that uniquely identifies the type of the serialized protocol buffer message.
        /// This string must contain at least one "/" character. The last segment of the URL's path must represent the
        /// fully qualified name of the type (as in `path/google.protobuf.Duration`). The name should be in a canonical
        /// form (e.g., leading "." is not accepted). In practice, teams usually precompile into the binary all types
        /// that they expect it to use in the context of Any. However, for URLs which use the scheme `http`, `https`, or
        /// no scheme, one can optionally set up a type server that maps type URLs to message definitions as follows: *
        /// If no scheme is provided, `https` is assumed. * An HTTP GET on the URL must yield a google.protobuf.Type
        /// value in binary format, or produce an error. * Applications are allowed to cache lookup results based on the
        /// URL, or have them precompiled into a binary to avoid any lookup. Therefore, binary compatibility needs to be
        /// preserved on changes to types. (Use versioned type names to manage breaking changes.) Note: this
        /// functionality is not currently available in the official protobuf release, and it is not used for type URLs
        /// beginning with type.googleapis.com. Schemes other than `http`, `https` (or the empty scheme) might be used
        /// with implementation specific semantics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeUrl")]
        public virtual string TypeUrl { get; set; } 

        /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class AppStartTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The time from app start to reaching the developer-reported "fully drawn" time. This is
        /// only stored if the app includes a call to Activity.reportFullyDrawn(). See
        /// https://developer.android.com/topic/performance/launch-time.html#time-full</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyDrawnTime")]
        public virtual Duration FullyDrawnTime { get; set; } 

        /// <summary>The time from app start to the first displayed activity being drawn, as reported in Logcat. See
        /// https://developer.android.com/topic/performance/launch-time.html#time-initial</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDisplayTime")]
        public virtual Duration InitialDisplayTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A suggestion to use deep links for a Robo run.</summary>
    public class AvailableDeepLinks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Encapsulates the metadata for basic sample series represented by a line chart</summary>
    public class BasicPerfSampleSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("perfMetricType")]
        public virtual string PerfMetricType { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("perfUnit")]
        public virtual string PerfUnit { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("sampleSeriesLabel")]
        public virtual string SampleSeriesLabel { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request must provide up to a maximum of 5000 samples to be created; a larger sample size will cause
    /// an INVALID_ARGUMENT error</summary>
    public class BatchCreatePerfSamplesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of PerfSamples to create should not include existing timestamps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perfSamples")]
        public virtual System.Collections.Generic.IList<PerfSample> PerfSamples { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class BatchCreatePerfSamplesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("perfSamples")]
        public virtual System.Collections.Generic.IList<PerfSample> PerfSamples { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo encountered a screen that was mostly blank; this may indicate a problem with the
    /// app.</summary>
    public class BlankScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The screen id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CPUInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>description of the device processor ie '1.8 GHz hexa core 64-bit ARMv8-A'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuProcessor")]
        public virtual string CpuProcessor { get; set; } 

        /// <summary>the CPU clock speed in GHz</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuSpeedInGhz")]
        public virtual System.Nullable<float> CpuSpeedInGhz { get; set; } 

        /// <summary>the number of CPU cores</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfCores")]
        public virtual System.Nullable<int> NumberOfCores { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Crash dialog was detected during the test execution</summary>
    public class CrashDialogError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the package that caused the dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashPackage")]
        public virtual string CrashPackage { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary> A Duration represents a signed, fixed-length span of time represented as a count of seconds and
    /// fractions of seconds at nanosecond resolution. It is independent of any calendar and concepts like "day" or
    /// "month". It is related to Timestamp in that the difference between two Timestamp values is a Duration and it can
    /// be added or subtracted from a Timestamp. Range is approximately +-10,000 years.</summary>
    public class Duration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signed fractions of a second at nanosecond resolution of the span of time. Durations less than one
        /// second are represented with a 0 `seconds` field and a positive or negative `nanos` field. For durations of
        /// one second or more, a non-zero value for the `nanos` field must be of the same sign as the `seconds` field.
        /// Must be from -999,999,999 to +999,999,999 inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; } 

        /// <summary>Signed seconds of the span of time. Must be from -315,576,000,000 to +315,576,000,000 inclusive.
        /// Note: these bounds are computed from: 60 sec/min * 60 min/hr * 24 hr/day * 365.25 days/year * 10000
        /// years</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details about encountered login screens.</summary>
    public class EncounteredLoginScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of encountered distinct login screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctScreens")]
        public virtual System.Nullable<int> DistinctScreens { get; set; } 

        /// <summary>Subset of login screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenIds")]
        public virtual System.Collections.Generic.IList<string> ScreenIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details about encountered screens with elements that are not Android UI widgets.</summary>
    public class EncounteredNonAndroidUiWidgetScreen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of encountered distinct screens with non Android UI widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctScreens")]
        public virtual System.Nullable<int> DistinctScreens { get; set; } 

        /// <summary>Subset of screens which contain non Android UI widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenIds")]
        public virtual System.Collections.Generic.IList<string> ScreenIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Environment represents the set of test runs (Steps) from the parent Execution that are configured
    /// with the same set of dimensions (Model, Version, Locale, and Orientation). Multiple such runs occur particularly
    /// because of features like sharding (splitting up a test suite to run in parallel across devices) and reruns
    /// (running a test multiple times to check for different outcomes).</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the Environment status was set to complete. This value will be set
        /// automatically when state transitions to COMPLETE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual Timestamp CompletionTime { get; set; } 

        /// <summary>Output only. The time when the Environment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual Timestamp CreationTime { get; set; } 

        /// <summary>Dimension values describing the environment. Dimension values always consist of "Model", "Version",
        /// "Locale", and "Orientation". - In response: always set - In create request: always set - In update request:
        /// never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValue")]
        public virtual System.Collections.Generic.IList<EnvironmentDimensionValueEntry> DimensionValue { get; set; } 

        /// <summary>A short human-readable name to display in the UI. Maximum of 100 characters. For example: Nexus 5,
        /// API 27.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. An Environment id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentId")]
        public virtual string EnvironmentId { get; set; } 

        /// <summary>Merged result of the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentResult")]
        public virtual MergedResult EnvironmentResult { get; set; } 

        /// <summary>Output only. An Execution id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; } 

        /// <summary>Output only. A History id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; } 

        /// <summary>Output only. A Project id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>The location where output files are stored in the user bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsStorage")]
        public virtual ResultsStorage ResultsStorage { get; set; } 

        /// <summary>Output only. Summaries of shards. Only one shard will present unless sharding feature is enabled in
        /// TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardSummaries")]
        public virtual System.Collections.Generic.IList<ShardSummary> ShardSummaries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class EnvironmentDimensionValueEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Execution represents a collection of Steps. For instance, it could represent: - a mobile test
    /// executed across a range of device configurations - a jenkins job with a build step followed by a test step The
    /// maximum size of an execution message is 1 MiB. An Execution can be updated until its state is set to COMPLETE at
    /// which point it becomes immutable.</summary>
    public class Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the Execution status transitioned to COMPLETE. This value will be set automatically
        /// when state transitions to COMPLETE. - In response: set if the execution state is COMPLETE. - In
        /// create/update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual Timestamp CompletionTime { get; set; } 

        /// <summary>The time when the Execution was created. This value will be set automatically when CreateExecution
        /// is called. - In response: always set - In create/update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual Timestamp CreationTime { get; set; } 

        /// <summary>The dimensions along which different steps in this execution may vary. This must remain fixed over
        /// the life of the execution. Returns INVALID_ARGUMENT if this field is set in an update request. Returns
        /// INVALID_ARGUMENT if the same name occurs in more than one dimension_definition. Returns INVALID_ARGUMENT if
        /// the size of the list is over 100. - In response: present if set by create - In create request: optional - In
        /// update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionDefinitions")]
        public virtual System.Collections.Generic.IList<MatrixDimensionDefinition> DimensionDefinitions { get; set; } 

        /// <summary>A unique identifier within a History for this Execution. Returns INVALID_ARGUMENT if this field is
        /// set or overwritten by the caller. - In response always set - In create/update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; } 

        /// <summary>Classify the result, for example into SUCCESS or FAILURE - In response: present if set by
        /// create/update request - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual Outcome Outcome { get; set; } 

        /// <summary>Lightweight information about execution request. - In response: present if set by create - In
        /// create: optional - In update: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specification")]
        public virtual Specification Specification { get; set; } 

        /// <summary>The initial state is IN_PROGRESS. The only legal state transitions is from IN_PROGRESS to COMPLETE.
        /// A PRECONDITION_FAILED will be returned if an invalid transition is requested. The state can only be set to
        /// COMPLETE once. A FAILED_PRECONDITION will be returned if the state is set to COMPLETE multiple times. If the
        /// state is set to COMPLETE, all the in-progress steps within the execution will be set as COMPLETE. If the
        /// outcome of the step is not set, the outcome will be set to INCONCLUSIVE. - In response always set - In
        /// create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>TestExecution Matrix ID that the TestExecutionService uses. - In response: present if set by create
        /// - In create: optional - In update: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExecutionMatrixId")]
        public virtual string TestExecutionMatrixId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Failed to install the APK.</summary>
    public class FailedToInstall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for an outcome with a FAILURE outcome summary.</summary>
    public class FailureDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the failure was severe because the system (app) under test crashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashed")]
        public virtual System.Nullable<bool> Crashed { get; set; } 

        /// <summary>If the device ran out of memory during a test, causing the test to crash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceOutOfMemory")]
        public virtual System.Nullable<bool> DeviceOutOfMemory { get; set; } 

        /// <summary>If the Roboscript failed to complete successfully, e.g., because a Roboscript action or assertion
        /// failed or a Roboscript action could not be matched during the entire crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedRoboscript")]
        public virtual System.Nullable<bool> FailedRoboscript { get; set; } 

        /// <summary>If an app is not installed and thus no test can be run with the app. This might be caused by trying
        /// to run a test on an unsupported platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notInstalled")]
        public virtual System.Nullable<bool> NotInstalled { get; set; } 

        /// <summary>If a native process (including any other than the app) crashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherNativeCrash")]
        public virtual System.Nullable<bool> OtherNativeCrash { get; set; } 

        /// <summary>If the test overran some time limit, and that is why it failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedOut")]
        public virtual System.Nullable<bool> TimedOut { get; set; } 

        /// <summary>If the robo was unable to crawl the app; perhaps because the app did not start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unableToCrawl")]
        public virtual System.Nullable<bool> UnableToCrawl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a fatal exception.</summary>
    public class FatalException : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the fatal exception. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A reference to a file.</summary>
    public class FileReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of a file stored in Google Cloud Storage. For example:
        /// http://storage.googleapis.com/mybucket/path/to/test.xml or in gsutil format: gs://mybucket/path/to/test.xml
        /// with version-specific info, gs://mybucket/path/to/test.xml#1360383693690000 An INVALID_ARGUMENT error will
        /// be returned if the URI format is not supported. - In response: always set - In create/update request: always
        /// set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUri")]
        public virtual string FileUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Graphics statistics for the App. The information is collected from 'adb shell dumpsys graphicsstats'.
    /// For more info see: https://developer.android.com/training/testing/performance.html Statistics will only be
    /// present for API 23+.</summary>
    public class GraphicsStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram of frame render times. There should be 154 buckets ranging from [5ms, 6ms) to [4950ms,
        /// infinity)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<GraphicsStatsBucket> Buckets { get; set; } 

        /// <summary>Total "high input latency" events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highInputLatencyCount")]
        public virtual System.Nullable<long> HighInputLatencyCount { get; set; } 

        /// <summary>Total frames with slow render time. Should be <= total_frames.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jankyFrames")]
        public virtual System.Nullable<long> JankyFrames { get; set; } 

        /// <summary>Total "missed vsync" events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missedVsyncCount")]
        public virtual System.Nullable<long> MissedVsyncCount { get; set; } 

        /// <summary>50th percentile frame render time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p50Millis")]
        public virtual System.Nullable<long> P50Millis { get; set; } 

        /// <summary>90th percentile frame render time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p90Millis")]
        public virtual System.Nullable<long> P90Millis { get; set; } 

        /// <summary>95th percentile frame render time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p95Millis")]
        public virtual System.Nullable<long> P95Millis { get; set; } 

        /// <summary>99th percentile frame render time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p99Millis")]
        public virtual System.Nullable<long> P99Millis { get; set; } 

        /// <summary>Total "slow bitmap upload" events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slowBitmapUploadCount")]
        public virtual System.Nullable<long> SlowBitmapUploadCount { get; set; } 

        /// <summary>Total "slow draw" events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slowDrawCount")]
        public virtual System.Nullable<long> SlowDrawCount { get; set; } 

        /// <summary>Total "slow UI thread" events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slowUiThreadCount")]
        public virtual System.Nullable<long> SlowUiThreadCount { get; set; } 

        /// <summary>Total frames rendered by package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalFrames")]
        public virtual System.Nullable<long> TotalFrames { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GraphicsStatsBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of frames in the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameCount")]
        public virtual System.Nullable<long> FrameCount { get; set; } 

        /// <summary>Lower bound of render time in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderMillis")]
        public virtual System.Nullable<long> RenderMillis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A History represents a sorted list of Executions ordered by the start_timestamp_millis field
    /// (descending). It can be used to group all the Executions of a continuous build. Note that the ordering only
    /// operates on one-dimension. If a repository has multiple branches, it means that multiple histories will need to
    /// be used in order to order Executions per branch.</summary>
    public class History : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short human-readable (plain text) name to display in the UI. Maximum of 100 characters. - In
        /// response: present if set during create. - In create request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>A unique identifier within a project for this History. Returns INVALID_ARGUMENT if this field is
        /// set or overwritten by the caller. - In response always set - In create request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; } 

        /// <summary>A name to uniquely identify a history within a project. Maximum of 200 characters. - In response
        /// always set - In create request: always set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The platform of the test history. - In response: always set. Returns the platform of the last
        /// execution if unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testPlatform")]
        public virtual string TestPlatform { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An image, with a link to the main image and a thumbnail.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An error explaining why the thumbnail could not be rendered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>A reference to the full-size, original image. This is the same as the tool_outputs entry for the
        /// image under its Step. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual ToolOutputReference SourceImage { get; set; } 

        /// <summary>The step to which the image is attached. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; } 

        /// <summary>The thumbnail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual Thumbnail Thumbnail { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of in-app purchases encountered during the crawl.</summary>
    public class InAppPurchasesFound : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of in-app purchases flows explored: how many times the robo tries to buy a
        /// SKU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppPurchasesFlowsExplored")]
        public virtual System.Nullable<int> InAppPurchasesFlowsExplored { get; set; } 

        /// <summary>The total number of in-app purchases flows started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppPurchasesFlowsStarted")]
        public virtual System.Nullable<int> InAppPurchasesFlowsStarted { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for an outcome with an INCONCLUSIVE outcome summary.</summary>
    public class InconclusiveDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the end user aborted the test execution before a pass or fail could be determined. For example,
        /// the user pressed ctrl-c which sent a kill signal to the test runner while the test was running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abortedByUser")]
        public virtual System.Nullable<bool> AbortedByUser { get; set; } 

        /// <summary>If results are being provided to the user in certain cases of infrastructure failures</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasErrorLogs")]
        public virtual System.Nullable<bool> HasErrorLogs { get; set; } 

        /// <summary>If the test runner could not determine success or failure because the test depends on a component
        /// other than the system under test which failed. For example, a mobile test requires provisioning a device
        /// where the test executes, and that provisioning can fail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infrastructureFailure")]
        public virtual System.Nullable<bool> InfrastructureFailure { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Step Id and outcome of each individual step that was run as a group with other steps with the same
    /// configuration.</summary>
    public class IndividualOutcome : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique int given to each step. Ranges from 0(inclusive) to total number of steps(exclusive). The
        /// primary step is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multistepNumber")]
        public virtual System.Nullable<int> MultistepNumber { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("outcomeSummary")]
        public virtual string OutcomeSummary { get; set; } 

        /// <summary>How long it took for this step to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runDuration")]
        public virtual Duration RunDuration { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo did not crawl potentially important parts of the app.</summary>
    public class InsufficientCoverage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for an iOS app crash.</summary>
    public class IosAppCrashed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace, if one is available. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>iOS app information</summary>
    public class IosAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the app. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Robo test for an iOS application.</summary>
    public class IosRoboTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A iOS mobile test specification</summary>
    public class IosTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppInfo")]
        public virtual IosAppInfo IosAppInfo { get; set; } 

        /// <summary>An iOS Robo test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosRoboTest")]
        public virtual IosRoboTest IosRoboTest { get; set; } 

        /// <summary>An iOS test loop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosTestLoop")]
        public virtual IosTestLoop IosTestLoop { get; set; } 

        /// <summary>An iOS XCTest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosXcTest")]
        public virtual IosXcTest IosXcTest { get; set; } 

        /// <summary>Max time a test is allowed to run before it is automatically cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTimeout")]
        public virtual Duration TestTimeout { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A game loop test of an iOS application.</summary>
    public class IosTestLoop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A test of an iOS application that uses the XCTest framework.</summary>
    public class IosXcTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; } 

        /// <summary>Xcode version that the test was run with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcodeVersion")]
        public virtual string XcodeVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Failed to find the launcher activity of an app.</summary>
    public class LauncherActivityNotFound : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for EnvironmentService.ListEnvironments.</summary>
    public class ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environments. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<Environment> Environments { get; set; } 

        /// <summary>A Execution id Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; } 

        /// <summary>A History id. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; } 

        /// <summary>A continuation token to resume the query at the next item. Will only be set if there are more
        /// Environments to fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A Project id. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Executions. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<Execution> Executions { get; set; } 

        /// <summary>A continuation token to resume the query at the next item. Will only be set if there are more
        /// Executions to fetch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for HistoryService.List</summary>
    public class ListHistoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histories")]
        public virtual System.Collections.Generic.IList<History> Histories { get; set; } 

        /// <summary>A continuation token to resume the query at the next item. Will only be set if there are more
        /// histories to fetch. Tokens are valid for up to one hour from the time of the first list request. For
        /// instance, if you make a list request at 1PM and use the token from this first request 10 minutes later, the
        /// token from this second response will only be valid for 50 minutes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListPerfSampleSeriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting PerfSampleSeries sorted by id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perfSampleSeries")]
        public virtual System.Collections.Generic.IList<PerfSampleSeries> PerfSampleSeries { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListPerfSamplesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional, returned if result size exceeds the page size specified in the request (or the default
        /// page size, 500, if unspecified). It indicates the last sample timestamp to be used as page_token in
        /// subsequent request</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("perfSamples")]
        public virtual System.Collections.Generic.IList<PerfSample> PerfSamples { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListScreenshotClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of clusters associated with an execution Always set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<ScreenshotCluster> Clusters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for AccessibilityService.ListStepAccessibilityClusters.</summary>
    public class ListStepAccessibilityClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A sequence of accessibility suggestions, grouped into clusters. Within the sequence, clusters that
        /// belong to the same SuggestionCategory should be adjacent. Within each category, clusters should be ordered
        /// by their SuggestionPriority (ERRORs first). The categories should be ordered by their highest priority
        /// cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<SuggestionClusterProto> Clusters { get; set; } 

        /// <summary>A full resource name of the step. For example, projects/my-
        /// project/histories/bh.1234567890abcdef/executions/ 1234567890123456789/steps/bs.1234567890abcdef Always
        /// presents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response containing the thumbnails in a step.</summary>
    public class ListStepThumbnailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A continuation token to resume the query at the next item. If set, indicates that there are more
        /// thumbnails to read, by calling list again with this value in the page_token field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of image data. Images are returned in a deterministic order; they are ordered by these
        /// factors, in order of importance: * First, by their associated test case. Images without a test case are
        /// considered greater than images with one. * Second, by their creation time. Images without a creation time
        /// are greater than images with one. * Third, by the order in which they were added to the step (by calls to
        /// CreateStep or UpdateStep).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnails")]
        public virtual System.Collections.Generic.IList<Image> Thumbnails { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for StepService.List.</summary>
    public class ListStepsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A continuation token to resume the query at the next item. If set, indicates that there are more
        /// steps to read, by calling list again with this value in the page_token field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<Step> Steps { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for StepService.ListTestCases.</summary>
    public class ListTestCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>List of test cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCases")]
        public virtual System.Collections.Generic.IList<TestCase> TestCases { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>One dimension of the matrix of different runs of a step.</summary>
    public class MatrixDimensionDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MemoryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum memory that can be allocated to the process in KiB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryCapInKibibyte")]
        public virtual System.Nullable<long> MemoryCapInKibibyte { get; set; } 

        /// <summary>Total memory available on the device in KiB</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryTotalInKibibyte")]
        public virtual System.Nullable<long> MemoryTotalInKibibyte { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Merged test result for environment. If the environment has only one step (no reruns or shards), then
    /// the merged result is the same as the step result. If the environment has multiple shards and/or reruns, then the
    /// results of shards and reruns that belong to the same environment are merged into one environment
    /// result.</summary>
    public class MergedResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Outcome of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual Outcome Outcome { get; set; } 

        /// <summary>State of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The combined and rolled-up result of each test suite that was run as part of this environment.
        /// Combining: When the test cases from a suite are run in different steps (sharding), the results are added
        /// back together in one overview. (e.g., if shard1 has 2 failures and shard2 has 1 failure than the overview
        /// failure_count = 3). Rollup: When test cases from the same suite are run multiple times (flaky), the results
        /// are combined (e.g., if testcase1.run1 fails, testcase1.run2 passes, and both testcase2.run1 and
        /// testcase2.run2 fail then the overview flaky_count = 1 and failure_count = 1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSuiteOverviews")]
        public virtual System.Collections.Generic.IList<TestSuiteOverview> TestSuiteOverviews { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details when multiple steps are run with the same configuration as a group.</summary>
    public class MultiStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique int given to each step. Ranges from 0(inclusive) to total number of steps(exclusive). The
        /// primary step is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multistepNumber")]
        public virtual System.Nullable<int> MultistepNumber { get; set; } 

        /// <summary>Present if it is a primary (original) step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryStep")]
        public virtual PrimaryStep PrimaryStep { get; set; } 

        /// <summary>Step Id of the primary (original) step, which might be this step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryStepId")]
        public virtual string PrimaryStepId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a native crash.</summary>
    public class NativeCrash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace of the native crash. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A non-sdk API and examples of it being called along with other metadata See
    /// https://developer.android.com/distribute/best-practices/develop/restrictions-non-sdk-interfaces</summary>
    public class NonSdkApi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The signature of the Non-SDK API</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSignature")]
        public virtual string ApiSignature { get; set; } 

        /// <summary>Example stack traces of this API being called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleStackTraces")]
        public virtual System.Collections.Generic.IList<string> ExampleStackTraces { get; set; } 

        /// <summary>Optional debugging insights for non-SDK API violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insights")]
        public virtual System.Collections.Generic.IList<NonSdkApiInsight> Insights { get; set; } 

        /// <summary>The total number of times this API was observed to have been called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invocationCount")]
        public virtual System.Nullable<int> InvocationCount { get; set; } 

        /// <summary>Which list this API appears on</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("list")]
        public virtual string List { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Non-SDK API insights (to address debugging solutions).</summary>
    public class NonSdkApiInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional sample stack traces, for which this insight applies (there should be at least
        /// one).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleTraceMessages")]
        public virtual System.Collections.Generic.IList<string> ExampleTraceMessages { get; set; } 

        /// <summary>A unique ID, to be used for determining the effectiveness of this particular insight in the context
        /// of a matcher. (required)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matcherId")]
        public virtual string MatcherId { get; set; } 

        /// <summary>An insight indicating that the hidden API usage originates from a Google-provided
        /// library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingGoogleUpdateInsight")]
        public virtual PendingGoogleUpdateInsight PendingGoogleUpdateInsight { get; set; } 

        /// <summary>An insight indicating that the hidden API usage originates from the use of a library that needs to
        /// be upgraded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeInsight")]
        public virtual UpgradeInsight UpgradeInsight { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details for a non-sdk API usage violation.</summary>
    public class NonSdkApiUsageViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signatures of a subset of those hidden API's.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiSignatures")]
        public virtual System.Collections.Generic.IList<string> ApiSignatures { get; set; } 

        /// <summary>Total number of unique hidden API's accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueApis")]
        public virtual System.Nullable<int> UniqueApis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains a summary and examples of non-sdk API usage violations.</summary>
    public class NonSdkApiUsageViolationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Examples of the detected API usages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleApis")]
        public virtual System.Collections.Generic.IList<NonSdkApi> ExampleApis { get; set; } 

        /// <summary>Minimum API level required for the application to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSdkVersion")]
        public virtual System.Nullable<int> MinSdkVersion { get; set; } 

        /// <summary>Specifies the API Level on which the application is designed to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSdkVersion")]
        public virtual System.Nullable<int> TargetSdkVersion { get; set; } 

        /// <summary>Total number of unique Non-SDK API's accessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueApis")]
        public virtual System.Nullable<int> UniqueApis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Interprets a result so that humans and machines can act on it.</summary>
    public class Outcome : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>More information about a FAILURE outcome. Returns INVALID_ARGUMENT if this field is set but the
        /// summary is not FAILURE. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureDetail")]
        public virtual FailureDetail FailureDetail { get; set; } 

        /// <summary>More information about an INCONCLUSIVE outcome. Returns INVALID_ARGUMENT if this field is set but
        /// the summary is not INCONCLUSIVE. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inconclusiveDetail")]
        public virtual InconclusiveDetail InconclusiveDetail { get; set; } 

        /// <summary>More information about a SKIPPED outcome. Returns INVALID_ARGUMENT if this field is set but the
        /// summary is not SKIPPED. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedDetail")]
        public virtual SkippedDetail SkippedDetail { get; set; } 

        /// <summary>More information about a SUCCESS outcome. Returns INVALID_ARGUMENT if this field is set but the
        /// summary is not SUCCESS. Optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successDetail")]
        public virtual SuccessDetail SuccessDetail { get; set; } 

        /// <summary>The simplest way to interpret a result. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that Robo encountered a screen that has overlapping clickable elements; this may indicate a
    /// potential UI issue.</summary>
    public class OverlappingUIElements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource names of the overlapping screen elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual System.Collections.Generic.IList<string> ResourceName { get; set; } 

        /// <summary>The screen id of the elements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This insight indicates that the hidden API usage originates from a Google-provided library. Users need
    /// not take any action.</summary>
    public class PendingGoogleUpdateInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Google-provided library with the non-SDK API dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameOfGoogleLibrary")]
        public virtual string NameOfGoogleLibrary { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Encapsulates performance environment info</summary>
    public class PerfEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CPU related environment info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuInfo")]
        public virtual CPUInfo CpuInfo { get; set; } 

        /// <summary>Memory related environment info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryInfo")]
        public virtual MemoryInfo MemoryInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A summary of perf metrics collected and performance environment info</summary>
    public class PerfMetricsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appStartTime")]
        public virtual AppStartTime AppStartTime { get; set; } 

        /// <summary>A tool results execution ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; } 

        /// <summary>Graphics statistics for the entire run. Statistics are reset at the beginning of the run and
        /// collected at the end of the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("graphicsStats")]
        public virtual GraphicsStats GraphicsStats { get; set; } 

        /// <summary>A tool results history ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; } 

        /// <summary>Describes the environment in which the performance metrics were collected</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perfEnvironment")]
        public virtual PerfEnvironment PerfEnvironment { get; set; } 

        /// <summary>Set of resource collected</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perfMetrics")]
        public virtual System.Collections.Generic.IList<string> PerfMetrics { get; set; } 

        /// <summary>The cloud project @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>A tool results step ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource representing a single performance measure or data point</summary>
    public class PerfSample : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp of collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual Timestamp SampleTime { get; set; } 

        /// <summary>Value observed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource representing a collection of performance samples (or data points)</summary>
    public class PerfSampleSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic series represented by a line chart</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicPerfSampleSeries")]
        public virtual BasicPerfSampleSeries BasicPerfSampleSeries { get; set; } 

        /// <summary>A tool results execution ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; } 

        /// <summary>A tool results history ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; } 

        /// <summary>The cloud project @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>A sample series id @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleSeriesId")]
        public virtual string SampleSeriesId { get; set; } 

        /// <summary>A tool results step ID. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A notification that Robo signed in with Google.</summary>
    public class PerformedGoogleLogin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A notification that Robo performed some monkey actions.</summary>
    public class PerformedMonkeyActions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total number of monkey actions performed during the crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalActions")]
        public virtual System.Nullable<int> TotalActions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Stores rollup test status of multiple steps that were run as a group and outcome of each individual
    /// step.</summary>
    public class PrimaryStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Step Id and outcome of each individual step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualOutcome")]
        public virtual System.Collections.Generic.IList<IndividualOutcome> IndividualOutcome { get; set; } 

        /// <summary>Rollup test status of multiple steps that were run with the same configuration as a
        /// group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollUp")]
        public virtual string RollUp { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Per-project settings for the Tool Results service.</summary>
    public class ProjectSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Google Cloud Storage bucket to which results are written. By default, this is
        /// unset. In update request: optional In response: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultBucket")]
        public virtual string DefaultBucket { get; set; } 

        /// <summary>The name of the project's settings. Always of the form: projects/{project-id}/settings In update
        /// request: never set In response: always set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for StepService.PublishXunitXmlFiles.</summary>
    public class PublishXunitXmlFilesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the Xunit XML files to publish. The maximum size of the file this reference is pointing to
        /// is 50MB. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xunitXmlFiles")]
        public virtual System.Collections.Generic.IList<FileReference> XunitXmlFiles { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A rectangular region.</summary>
    public class RegionProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPx")]
        public virtual System.Nullable<int> HeightPx { get; set; } 

        /// <summary>The left side of the rectangle, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leftPx")]
        public virtual System.Nullable<int> LeftPx { get; set; } 

        /// <summary>The top of the rectangle, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topPx")]
        public virtual System.Nullable<int> TopPx { get; set; } 

        /// <summary>The width, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPx")]
        public virtual System.Nullable<int> WidthPx { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The storage for test results.</summary>
    public class ResultsStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The root directory for test results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsStoragePath")]
        public virtual FileReference ResultsStoragePath { get; set; } 

        /// <summary>The path to the Xunit XML file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xunitXmlFile")]
        public virtual FileReference XunitXmlFile { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Execution stats for a user-provided Robo script.</summary>
    public class RoboScriptExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of Robo script actions executed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulActions")]
        public virtual System.Nullable<int> SuccessfulActions { get; set; } 

        /// <summary>The total number of actions in the Robo script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalActions")]
        public virtual System.Nullable<int> TotalActions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>IMPORTANT: It is unsafe to accept this message from an untrusted source, since it's trivial for an
    /// attacker to forge serialized messages that don't fulfill the type's safety contract -- for example, it could
    /// contain attacker controlled script. A system which receives a SafeHtmlProto implicitly trusts the producer of
    /// the SafeHtmlProto. So, it's generally safe to return this message in RPC responses, but generally unsafe to
    /// accept it in RPC requests.</summary>
    public class SafeHtmlProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IMPORTANT: Never set or read this field, even from tests, it is private. See documentation at the
        /// top of .proto file for programming language packages with which to create or read this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateDoNotAccessOrElseSafeHtmlWrappedValue")]
        public virtual string PrivateDoNotAccessOrElseSafeHtmlWrappedValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Screen : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>File reference of the png file. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileReference")]
        public virtual string FileReference { get; set; } 

        /// <summary>Locale of the device that the screenshot was taken on. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; } 

        /// <summary>Model of the device that the screenshot was taken on. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; } 

        /// <summary>OS version of the device that the screenshot was taken on. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ScreenshotCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A string that describes the activity of every screen in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activity")]
        public virtual string Activity { get; set; } 

        /// <summary>A unique identifier for the cluster. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; } 

        /// <summary>A singular screen that represents the cluster as a whole. This screen will act as the "cover" of
        /// the entire cluster. When users look at the clusters, only the key screen from each cluster will be shown.
        /// Which screen is the key screen is determined by the ClusteringAlgorithm</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyScreen")]
        public virtual Screen KeyScreen { get; set; } 

        /// <summary>Full list of screens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screens")]
        public virtual System.Collections.Generic.IList<Screen> Screens { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Result summary for a shard in an environment.</summary>
    public class ShardSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summaries of the steps belonging to the shard. With flaky_test_attempts enabled from
        /// TestExecutionService, more than one run (Step) can present. And the runs will be sorted by
        /// multistep_number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runs")]
        public virtual System.Collections.Generic.IList<StepSummary> Runs { get; set; } 

        /// <summary>Merged result of the shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardResult")]
        public virtual MergedResult ShardResult { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for an outcome with a SKIPPED outcome summary.</summary>
    public class SkippedDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the App doesn't support the specific API level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incompatibleAppVersion")]
        public virtual System.Nullable<bool> IncompatibleAppVersion { get; set; } 

        /// <summary>If the App doesn't run on the specific architecture, for example, x86.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incompatibleArchitecture")]
        public virtual System.Nullable<bool> IncompatibleArchitecture { get; set; } 

        /// <summary>If the requested OS version doesn't run on the specific device model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incompatibleDevice")]
        public virtual System.Nullable<bool> IncompatibleDevice { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The details about how to run the execution.</summary>
    public class Specification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Android mobile test execution specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidTest")]
        public virtual AndroidTest AndroidTest { get; set; } 

        /// <summary>An iOS mobile test execution specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosTest")]
        public virtual IosTest IosTest { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A stacktrace.</summary>
    public class StackTrace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stack trace message. Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exception")]
        public virtual string Exception { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>User provided intent failed to resolve to an activity.</summary>
    public class StartActivityNotFound : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Step represents a single operation performed as part of Execution. A step can be used to represent
    /// the execution of a tool ( for example a test runner execution or an execution of a compiler). Steps can overlap
    /// (for instance two steps might have the same start time if some operations are done in parallel). Here is an
    /// example, let's consider that we have a continuous build is executing a test runner for each iteration. The
    /// workflow would look like: - user creates a Execution with id 1 - user creates an TestExecutionStep with id 100
    /// for Execution 1 - user update TestExecutionStep with id 100 to add a raw xml log + the service parses the xml
    /// logs and returns a TestExecutionStep with updated TestResult(s). - user update the status of TestExecutionStep
    /// with id 100 to COMPLETE A Step can be updated until its state is set to COMPLETE at which points it becomes
    /// immutable. Next tag: 27</summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the step status was set to complete. This value will be set automatically when state
        /// transitions to COMPLETE. - In response: set if the execution state is COMPLETE. - In create/update request:
        /// never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual Timestamp CompletionTime { get; set; } 

        /// <summary>The time when the step was created. - In response: always set - In create/update request: never
        /// set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual Timestamp CreationTime { get; set; } 

        /// <summary>A description of this tool For example: mvn clean package -D skipTests=true - In response: present
        /// if set by create/update request - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>How much the device resource is used to perform the test. This is the device usage used for billing
        /// purpose, which is different from the run_duration, for example, infrastructure failure won't be charged for
        /// device usage. PRECONDITION_FAILED will be returned if one attempts to set a device_usage on a step which
        /// already has this field set. - In response: present if previously set. - In create request: optional - In
        /// update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUsageDuration")]
        public virtual Duration DeviceUsageDuration { get; set; } 

        /// <summary>If the execution containing this step has any dimension_definition set, then this field allows the
        /// child to specify the values of the dimensions. The keys must exactly match the dimension_definition of the
        /// execution. For example, if the execution has `dimension_definition = ['attempt', 'device']` then a step must
        /// define values for those dimensions, eg. `dimension_value = ['attempt': '1', 'device': 'Nexus 6']` If a step
        /// does not participate in one dimension of the matrix, the value for that dimension should be empty string.
        /// For example, if one of the tests is executed by a runner which does not support retries, the step could have
        /// `dimension_value = ['attempt': '', 'device': 'Nexus 6']` If the step does not participate in any dimensions
        /// of the matrix, it may leave dimension_value unset. A PRECONDITION_FAILED will be returned if any of the keys
        /// do not exist in the dimension_definition of the execution. A PRECONDITION_FAILED will be returned if another
        /// step in this execution already has the same name and dimension_value, but differs on other data fields, for
        /// example, step field is different. A PRECONDITION_FAILED will be returned if dimension_value is set, and
        /// there is a dimension_definition in the execution which is not specified as one of the keys. - In response:
        /// present if set by create - In create request: optional - In update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValue")]
        public virtual System.Collections.Generic.IList<StepDimensionValueEntry> DimensionValue { get; set; } 

        /// <summary>Whether any of the outputs of this step are images whose thumbnails can be fetched with
        /// ListThumbnails. - In response: always set - In create/update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasImages")]
        public virtual System.Nullable<bool> HasImages { get; set; } 

        /// <summary>Arbitrary user-supplied key/value pairs that are associated with the step. Users are responsible
        /// for managing the key namespace such that keys don't accidentally collide. An INVALID_ARGUMENT will be
        /// returned if the number of labels exceeds 100 or if the length of any of the keys or values exceeds 100
        /// characters. - In response: always set - In create request: optional - In update request: optional; any new
        /// key/value pair will be added to the map, and any new value for an existing key will update that key's
        /// value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<StepLabelsEntry> Labels { get; set; } 

        /// <summary>Details when multiple steps are run with the same configuration as a group. These details can be
        /// used identify which group this step is part of. It also identifies the groups 'primary step' which indexes
        /// all the group members. - In response: present if previously set. - In create request: optional, set iff this
        /// step was performed more than once. - In update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiStep")]
        public virtual MultiStep MultiStep { get; set; } 

        /// <summary>A short human-readable name to display in the UI. Maximum of 100 characters. For example: Clean
        /// build A PRECONDITION_FAILED will be returned upon creating a new step if it shares its name and
        /// dimension_value with an existing step. If two steps represent a similar action, but have different dimension
        /// values, they should share the same name. For instance, if the same set of tests is run on two different
        /// platforms, the two steps should have the same name. - In response: always set - In create request: always
        /// set - In update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Classification of the result, for example into SUCCESS or FAILURE - In response: present if set by
        /// create/update request - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual Outcome Outcome { get; set; } 

        /// <summary>How long it took for this step to run. If unset, this is set to the difference between
        /// creation_time and completion_time when the step is set to the COMPLETE state. In some cases, it is
        /// appropriate to set this value separately: For instance, if a step is created, but the operation it
        /// represents is queued for a few minutes before it executes, it would be appropriate not to include the time
        /// spent queued in its run_duration. PRECONDITION_FAILED will be returned if one attempts to set a run_duration
        /// on a step which already has this field set. - In response: present if previously set; always present on
        /// COMPLETE step - In create request: optional - In update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runDuration")]
        public virtual Duration RunDuration { get; set; } 

        /// <summary>The initial state is IN_PROGRESS. The only legal state transitions are * IN_PROGRESS -> COMPLETE A
        /// PRECONDITION_FAILED will be returned if an invalid transition is requested. It is valid to create Step with
        /// a state set to COMPLETE. The state can only be set to COMPLETE once. A PRECONDITION_FAILED will be returned
        /// if the state is set to COMPLETE multiple times. - In response: always set - In create/update request:
        /// optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>A unique identifier within a Execution for this Step. Returns INVALID_ARGUMENT if this field is set
        /// or overwritten by the caller. - In response: always set - In create/update request: never set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; } 

        /// <summary>An execution of a test runner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExecutionStep")]
        public virtual TestExecutionStep TestExecutionStep { get; set; } 

        /// <summary>An execution of a tool (used for steps we don't explicitly support).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolExecutionStep")]
        public virtual ToolExecutionStep ToolExecutionStep { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class StepDimensionValueEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class StepLabelsEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Lightweight summary of a step within this execution.</summary>
    public class StepSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Details for an outcome with a SUCCESS outcome summary. LINT.IfChange</summary>
    public class SuccessDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If a native process other than the app crashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherNativeCrash")]
        public virtual System.Nullable<bool> OtherNativeCrash { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A set of similar suggestions that we suspect are closely related. This proto and most of the nested
    /// protos are branched from foxandcrown.prelaunchreport.service.SuggestionClusterProto, replacing PLR's
    /// dependencies with FTL's.</summary>
    public class SuggestionClusterProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Category in which these types of suggestions should appear. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; } 

        /// <summary>A sequence of suggestions. All of the suggestions within a cluster must have the same
        /// SuggestionPriority and belong to the same SuggestionCategory. Suggestions with the same screenshot URL
        /// should be adjacent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual System.Collections.Generic.IList<SuggestionProto> Suggestions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SuggestionProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference to a help center article concerning this type of suggestion. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpUrl")]
        public virtual string HelpUrl { get; set; } 

        /// <summary>Message, in the user's language, explaining the suggestion, which may contain markup. Always
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longMessage")]
        public virtual SafeHtmlProto LongMessage { get; set; } 

        /// <summary>Relative importance of a suggestion. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; } 

        /// <summary>A somewhat human readable identifier of the source view, if it does not have a resource_name. This
        /// is a path within the accessibility hierarchy, an element with resource name; similar to an XPath.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pseudoResourceId")]
        public virtual string PseudoResourceId { get; set; } 

        /// <summary>Region within the screenshot that is relevant to this suggestion. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual RegionProto Region { get; set; } 

        /// <summary>Reference to a view element, identified by its resource name, if it has one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>ID of the screen for the suggestion. It is used for getting the corresponding screenshot path. For
        /// example, screen_id "1" corresponds to "1.png" file in GCS. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>Relative importance of a suggestion as compared with other suggestions that have the same priority
        /// and category. This is a meaningless value that can be used to order suggestions that are in the same
        /// category and have the same priority. The larger values have higher priority (i.e., are more important).
        /// Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryPriority")]
        public virtual System.Nullable<double> SecondaryPriority { get; set; } 

        /// <summary>Concise message, in the user's language, representing the suggestion, which may contain markup.
        /// Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortMessage")]
        public virtual SafeHtmlProto ShortMessage { get; set; } 

        /// <summary>General title for the suggestion, in the user's language, without markup. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TestCase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The elapsed run time of the test case. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elapsedTime")]
        public virtual Duration ElapsedTime { get; set; } 

        /// <summary>The end time of the test case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual Timestamp EndTime { get; set; } 

        /// <summary>Why the test case was skipped. Present only for skipped test case</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedMessage")]
        public virtual string SkippedMessage { get; set; } 

        /// <summary>The stack trace details if the test case failed or encountered an error. The maximum size of the
        /// stack traces is 100KiB, beyond which the stack track will be truncated. Zero if the test case
        /// passed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTraces")]
        public virtual System.Collections.Generic.IList<StackTrace> StackTraces { get; set; } 

        /// <summary>The start time of the test case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual Timestamp StartTime { get; set; } 

        /// <summary>The status of the test case. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>A unique identifier within a Step for this Test Case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCaseId")]
        public virtual string TestCaseId { get; set; } 

        /// <summary>Test case reference, e.g. name, class name and test suite name. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCaseReference")]
        public virtual TestCaseReference TestCaseReference { get; set; } 

        /// <summary>References to opaque files of any format output by the tool execution. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolOutputs")]
        public virtual System.Collections.Generic.IList<ToolOutputReference> ToolOutputs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A reference to a test case. Test case references are canonically ordered lexicographically by these
    /// three factors: * First, by test_suite_name. * Second, by class_name. * Third, by name.</summary>
    public class TestCaseReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("className")]
        public virtual string ClassName { get; set; } 

        /// <summary>The name of the test case. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The name of the test suite to which this test case belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSuiteName")]
        public virtual string TestSuiteName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A step that represents running tests. It accepts ant-junit xml files which will be parsed into
    /// structured test results by the service. Xml file paths are updated in order to append more files, however they
    /// can't be deleted. Users can also add test results manually by using the test_result field.</summary>
    public class TestExecutionStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issues observed during the test execution. For example, if the mobile app under test crashed during
        /// the test, the error message and the stack trace content can be recorded here to assist debugging. - In
        /// response: present if set by create or update - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testIssues")]
        public virtual System.Collections.Generic.IList<TestIssue> TestIssues { get; set; } 

        /// <summary>List of test suite overview contents. This could be parsed from xUnit XML log by server, or
        /// uploaded directly by user. This references should only be called when test suites are fully parsed or
        /// uploaded. The maximum allowed number of test suite overviews per step is 1000. - In response: always set -
        /// In create request: optional - In update request: never (use publishXunitXmlFiles custom method
        /// instead)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSuiteOverviews")]
        public virtual System.Collections.Generic.IList<TestSuiteOverview> TestSuiteOverviews { get; set; } 

        /// <summary>The timing break down of the test execution. - In response: present if set by create or update - In
        /// create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTiming")]
        public virtual TestTiming TestTiming { get; set; } 

        /// <summary>Represents the execution of the test runner. The exit code of this tool will be used to determine
        /// if the test passed. - In response: always set - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolExecution")]
        public virtual ToolExecution ToolExecution { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An issue detected occurring during a test execution.</summary>
    public class TestIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Category of issue. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; } 

        /// <summary>A brief human-readable message describing the issue. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; } 

        /// <summary>Severity of issue. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; } 

        /// <summary>Deprecated in favor of stack trace fields inside specific warnings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; } 

        /// <summary>Type of issue. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Warning message with additional details of the issue. Should always be a message from
        /// com.google.devtools.toolresults.v1.warnings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual Any Warning { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A summary of a test suite result either parsed from XML or uploaded directly by a user. Note: the API
    /// related comments are for StepService only. This message is also being used in ExecutionService in a read only
    /// mode for the corresponding step.</summary>
    public class TestSuiteOverview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Elapsed time of test suite.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elapsedTime")]
        public virtual Duration ElapsedTime { get; set; } 

        /// <summary>Number of test cases in error, typically set by the service by parsing the xml_source. - In
        /// create/response: always set - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<int> ErrorCount { get; set; } 

        /// <summary>Number of failed test cases, typically set by the service by parsing the xml_source. May also be
        /// set by the user. - In create/response: always set - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCount")]
        public virtual System.Nullable<int> FailureCount { get; set; } 

        /// <summary>Number of flaky test cases, set by the service by rolling up flaky test attempts. Present only for
        /// rollup test suite overview at environment level. A step cannot have flaky test cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flakyCount")]
        public virtual System.Nullable<int> FlakyCount { get; set; } 

        /// <summary>The name of the test suite. - In create/response: always set - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Number of test cases not run, typically set by the service by parsing the xml_source. - In
        /// create/response: always set - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skippedCount")]
        public virtual System.Nullable<int> SkippedCount { get; set; } 

        /// <summary>Number of test cases, typically set by the service by parsing the xml_source. - In create/response:
        /// always set - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<int> TotalCount { get; set; } 

        /// <summary>If this test suite was parsed from XML, this is the URI where the original XML file is stored.
        /// Note: Multiple test suites can share the same xml_source Returns INVALID_ARGUMENT if the uri format is not
        /// supported. - In create/response: optional - In update request: never</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xmlSource")]
        public virtual FileReference XmlSource { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Testing timing break down to know phases.</summary>
    public class TestTiming : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How long it took to run the test process. - In response: present if previously set. - In
        /// create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testProcessDuration")]
        public virtual Duration TestProcessDuration { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A single thumbnail, with its size and format.</summary>
    public class Thumbnail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail's content type, i.e. "image/png". Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; } 

        /// <summary>The thumbnail file itself. That is, the bytes here are precisely the bytes that make up the
        /// thumbnail file; they can be served as an image as-is (with the appropriate content type.) Always
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; } 

        /// <summary>The height of the thumbnail, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPx")]
        public virtual System.Nullable<int> HeightPx { get; set; } 

        /// <summary>The width of the thumbnail, in pixels. Always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPx")]
        public virtual System.Nullable<int> WidthPx { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Timestamp represents a point in time independent of any time zone or local calendar, encoded as a
    /// count of seconds and fractions of seconds at nanosecond resolution. The count is relative to an epoch at UTC
    /// midnight on January 1, 1970, in the proleptic Gregorian calendar which extends the Gregorian calendar backwards
    /// to year one. All minutes are 60 seconds long. Leap seconds are "smeared" so that no leap second table is needed
    /// for interpretation, using a [24-hour linear smear](https://developers.google.com/time/smear). The range is from
    /// 0001-01-01T00:00:00Z to 9999-12-31T23:59:59.999999999Z. By restricting to that range, we ensure that we can
    /// convert to and from [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) date strings.</summary>
    public class Timestamp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Non-negative fractions of a second at nanosecond resolution. Negative second values with fractions
        /// must still have non-negative nanos values that count forward in time. Must be from 0 to 999,999,999
        /// inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; } 

        /// <summary>Represents seconds of UTC time since Unix epoch 1970-01-01T00:00:00Z. Must be from
        /// 0001-01-01T00:00:00Z to 9999-12-31T23:59:59Z inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An execution of an arbitrary tool. It could be a test runner or a tool copying artifacts or deploying
    /// code.</summary>
    public class ToolExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full tokenized command line including the program name (equivalent to argv in a C program). -
        /// In response: present if set by create request - In create request: optional - In update request: never
        /// set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandLineArguments")]
        public virtual System.Collections.Generic.IList<string> CommandLineArguments { get; set; } 

        /// <summary>Tool execution exit code. This field will be set once the tool has exited. - In response: present
        /// if set by create/update request - In create request: optional - In update request: optional, a
        /// FAILED_PRECONDITION error will be returned if an exit_code is already set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual ToolExitCode ExitCode { get; set; } 

        /// <summary>References to any plain text logs output the tool execution. This field can be set before the tool
        /// has exited in order to be able to have access to a live view of the logs while the tool is running. The
        /// maximum allowed number of tool logs per step is 1000. - In response: present if set by create/update request
        /// - In create request: optional - In update request: optional, any value provided will be appended to the
        /// existing list</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolLogs")]
        public virtual System.Collections.Generic.IList<FileReference> ToolLogs { get; set; } 

        /// <summary>References to opaque files of any format output by the tool execution. The maximum allowed number
        /// of tool outputs per step is 1000. - In response: present if set by create/update request - In create
        /// request: optional - In update request: optional, any value provided will be appended to the existing
        /// list</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolOutputs")]
        public virtual System.Collections.Generic.IList<ToolOutputReference> ToolOutputs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Generic tool step to be used for binaries we do not explicitly support. For example: running cp to copy
    /// artifacts from one location to another.</summary>
    public class ToolExecutionStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Tool execution. - In response: present if set by create/update request - In create/update
        /// request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolExecution")]
        public virtual ToolExecution ToolExecution { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Exit code from a tool execution.</summary>
    public class ToolExitCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tool execution exit code. A value of 0 means that the execution was successful. - In response:
        /// always set - In create/update request: always set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A reference to a ToolExecution output file.</summary>
    public class ToolOutputReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of the file. - In response: present if set by create/update request - In
        /// create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual Timestamp CreationTime { get; set; } 

        /// <summary>A FileReference to an output file. - In response: always set - In create/update request: always
        /// set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual FileReference Output { get; set; } 

        /// <summary>The test case to which this output file belongs. - In response: present if set by create/update
        /// request - In create/update request: optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCase")]
        public virtual TestCaseReference TestCase { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A warning that the screen hierarchy is deeper than the recommended threshold.</summary>
    public class UIElementTooDeep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The depth of the screen element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<int> Depth { get; set; } 

        /// <summary>The screen id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenId")]
        public virtual string ScreenId { get; set; } 

        /// <summary>The screen state id of the element</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenStateId")]
        public virtual string ScreenStateId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Default unspecified warning.</summary>
    public class UnspecifiedWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of an unused robodirective.</summary>
    public class UnusedRoboDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This insight is a recommendation to upgrade a given library to the specified version, in order to avoid
    /// dependencies on non-SDK APIs.</summary>
    public class UpgradeInsight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the package to be upgraded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; } 

        /// <summary>The suggested version to upgrade to. Optional: In case we are not sure which version solves this
        /// problem</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeToVersion")]
        public virtual string UpgradeToVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of a used Robo directive.</summary>
    public class UsedRoboDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional details of a used Robo directive with an ignore action. Note: This is a different scenario
    /// than unused directive.</summary>
    public class UsedRoboIgnoreDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource that was ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
