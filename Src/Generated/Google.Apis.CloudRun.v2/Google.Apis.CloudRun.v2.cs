// Copyright 2022 Google LLC
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

namespace Google.Apis.CloudRun.v2
{
    /// <summary>The CloudRun Service.</summary>
    public class CloudRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://run.googleapis.com/";
        #else
            "https://run.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://run.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
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

    /// <summary>A base abstract class for CloudRun requests.</summary>
    public abstract class CloudRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRunBaseServiceRequest instance.</summary>
        protected CloudRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRun parameter list.</summary>
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
                Jobs = new JobsResource(service);
                Operations = new OperationsResource(service);
                Services = new ServicesResource(service);
            }

            /// <summary>Gets the Jobs resource.</summary>
            public virtual JobsResource Jobs { get; }

            /// <summary>The "jobs" collection of methods.</summary>
            public class JobsResource
            {
                private const string Resource = "jobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public JobsResource(Google.Apis.Services.IClientService service)
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
                        Tasks = new TasksResource(service);
                    }

                    /// <summary>Gets the Tasks resource.</summary>
                    public virtual TasksResource Tasks { get; }

                    /// <summary>The "tasks" collection of methods.</summary>
                    public class TasksResource
                    {
                        private const string Resource = "tasks";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TasksResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets information about a Task.</summary>
                        /// <param name="name">
                        /// Required. The full name of the Task. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets information about a Task.</summary>
                        public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Task>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The full name of the Task. Format:
                            /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+/tasks/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List Tasks from an Execution of a Job.</summary>
                        /// <param name="parent">
                        /// Required. The Execution from which the Tasks should be listed. To list all Tasks across
                        /// Executions of a Job, use "-" instead of Execution name. To list all Tasks across Jobs, use
                        /// "-" instead of Job name. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List Tasks from an Execution of a Job.</summary>
                        public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListTasksResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The Execution from which the Tasks should be listed. To list all Tasks across
                            /// Executions of a Job, use "-" instead of Execution name. To list all Tasks across Jobs,
                            /// use "-" instead of Job name. Format:
                            /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Maximum number of Tasks to return in this call.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token received from a previous call to ListTasks. All other parameters must
                            /// match.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// If true, returns deleted (but unexpired) resources along with active ones.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ShowDeleted { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/tasks";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
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
                    }

                    /// <summary>Delete an Execution.</summary>
                    /// <param name="name">
                    /// Required. The name of the Execution to delete. Format:
                    /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete an Execution.</summary>
                    public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Execution to delete. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A system-generated fingerprint for this version of the resource. This may be used to detect
                        /// modification conflict during updates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Indicates that the request should be validated without actually deleting any resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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

                    /// <summary>Gets information about a Execution.</summary>
                    /// <param name="name">
                    /// Required. The full name of the Execution. Format:
                    /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets information about a Execution.</summary>
                    public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Execution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full name of the Execution. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List Executions from a Job.</summary>
                    /// <param name="parent">
                    /// Required. The Execution from which the Executions should be listed. To list all Executions
                    /// across Jobs, use "-" instead of Job name. Format:
                    /// projects/{project}/locations/{location}/jobs/{job}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List Executions from a Job.</summary>
                    public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Execution from which the Executions should be listed. To list all Executions
                        /// across Jobs, use "-" instead of Job name. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of Executions to return in this call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token received from a previous call to ListExecutions. All other parameters must
                        /// match.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If true, returns deleted (but unexpired) resources along with active ones.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/executions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                }

                /// <summary>Create a Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location and project in which this Job should be created. Format:
                /// projects/{projectnumber}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create a Job.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project in which this Job should be created. Format:
                    /// projects/{projectnumber}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The unique identifier for the Job. The name of the job becomes {parent}/jobs/{job_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string JobId { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or creating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobs";

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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
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

                /// <summary>Deletes a Job.</summary>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{projectnumber}/locations/{location}/jobs/{job}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a Job.</summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format:
                    /// projects/{projectnumber}/locations/{location}/jobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A system-generated fingerprint for this version of the resource. May be used to detect
                    /// modification conflict during updates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// If set to true, the Job and its Executions will be deleted no matter whether any Executions are
                    /// still running or not. If set to false or unset, the Job and its Executions can only be deleted
                    /// if there are no running Executions. Any running Execution will fail the deletion.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated without actually deleting any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
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

                /// <summary>Gets information about a Job.</summary>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{projectnumber}/locations/{location}/jobs/{job}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets information about a Job.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format:
                    /// projects/{projectnumber}/locations/{location}/jobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given Job. This result does not
                /// include any inherited policies.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given Job. This result does not
                /// include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
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
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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

                /// <summary>List Jobs.</summary>
                /// <param name="parent">
                /// Required. The location and project to list resources on. Format:
                /// projects/{projectnumber}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List Jobs.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project to list resources on. Format:
                    /// projects/{projectnumber}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Jobs to return in this call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token received from a previous call to ListJobs. All other parameters must match.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>If true, returns deleted (but unexpired) resources along with active ones.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobs";

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

                /// <summary>Updates a Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a Job.</summary>
                public class PatchRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and if the Job does not exist, it will create a new one. Caller must have both
                    /// create and update permissions for this call if this is set to true.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or updating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>Triggers creation of a new Execution of this Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{projectnumber}/locations/{location}/jobs/{job}
                /// </param>
                public virtual RunRequest Run(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest body, string name)
                {
                    return new RunRequest(service, body, name);
                }

                /// <summary>Triggers creation of a new Execution of this Job.</summary>
                public class RunRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format:
                    /// projects/{projectnumber}/locations/{location}/jobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:run";

                    /// <summary>Initializes Run parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Job. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Job. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleProtobufEmpty>
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
                    public override string RestPath => "v2/{+name}";

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
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v2/{+name}";

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
                /// <param name="name">Required. To query for all of the operations for a project.</param>
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
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. To query for all of the operations for a project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A filter for matching the completed or in-progress operations. The supported formats
                    /// of *filter* are: To query for only completed operations: done:true To query for only ongoing
                    /// operations: done:false Must be empty to query for all of the latest operations for the given
                    /// parent project.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of records that should be returned. Requested page size cannot exceed 100. If
                    /// not set or set to less than or equal to 0, the default page size is 100. .
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token identifying which result to start with, which is returned by a previous list call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/operations";

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

            /// <summary>Gets the Services resource.</summary>
            public virtual ServicesResource Services { get; }

            /// <summary>The "services" collection of methods.</summary>
            public class ServicesResource
            {
                private const string Resource = "services";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Revisions = new RevisionsResource(service);
                }

                /// <summary>Gets the Revisions resource.</summary>
                public virtual RevisionsResource Revisions { get; }

                /// <summary>The "revisions" collection of methods.</summary>
                public class RevisionsResource
                {
                    private const string Resource = "revisions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RevisionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Delete a Revision.</summary>
                    /// <param name="name">
                    /// Required. The name of the Revision to delete. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete a Revision.</summary>
                    public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Revision to delete. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A system-generated fingerprint for this version of the resource. This may be used to detect
                        /// modification conflict during updates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Indicates that the request should be validated without actually deleting any resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/revisions/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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

                    /// <summary>Gets information about a Revision.</summary>
                    /// <param name="name">
                    /// Required. The full name of the Revision. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets information about a Revision.</summary>
                    public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Revision>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full name of the Revision. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/revisions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List Revisions from a given Service, or from a given location.</summary>
                    /// <param name="parent">
                    /// Required. The Service from which the Revisions should be listed. To list all Revisions across
                    /// Services, use "-" instead of Service name. Format:
                    /// projects/{project}/locations/{location}/services/{service}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List Revisions from a given Service, or from a given location.</summary>
                    public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListRevisionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Service from which the Revisions should be listed. To list all Revisions
                        /// across Services, use "-" instead of Service name. Format:
                        /// projects/{project}/locations/{location}/services/{service}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of revisions to return in this call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token received from a previous call to ListRevisions. All other parameters must
                        /// match.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If true, returns deleted (but unexpired) resources along with active ones.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/revisions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                }

                /// <summary>Creates a new Service in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location and project in which this service should be created. Format:
                /// projects/{projectnumber}/locations/{location} Only lowercase, digits, and hyphens; must begin with
                /// letter, and may not end with hyphen; must contain fewer than 50 characters.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new Service in a given project and location.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project in which this service should be created. Format:
                    /// projects/{projectnumber}/locations/{location} Only lowercase, digits, and hyphens; must begin
                    /// with letter, and may not end with hyphen; must contain fewer than 50 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The unique identifier for the Service. The name of the service becomes
                    /// {parent}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceId { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or creating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/services";

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
                        RequestParameters.Add("serviceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceId",
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

                /// <summary>
                /// Deletes a Service. This will cause the Service to stop serving traffic and will delete all
                /// revisions.
                /// </summary>
                /// <param name="name">
                /// Required. The full name of the Service. Format:
                /// projects/{projectnumber}/locations/{location}/services/{service}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a Service. This will cause the Service to stop serving traffic and will delete all
                /// revisions.
                /// </summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Service. Format:
                    /// projects/{projectnumber}/locations/{location}/services/{service}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A system-generated fingerprint for this version of the resource. May be used to detect
                    /// modification conflict during updates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated without actually deleting any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
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

                /// <summary>Gets information about a Service.</summary>
                /// <param name="name">
                /// Required. The full name of the Service. Format:
                /// projects/{projectnumber}/locations/{location}/services/{service}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets information about a Service.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Service. Format:
                    /// projects/{projectnumber}/locations/{location}/services/{service}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given Cloud Run Service. This result
                /// does not include any inherited policies.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Get the IAM Access Control policy currently in effect for the given Cloud Run Service. This result
                /// does not include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
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
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>List Services.</summary>
                /// <param name="parent">
                /// Required. The location and project to list resources on. Location must be a valid GCP region, and
                /// may not be the "-" wildcard. Format: projects/{projectnumber}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List Services.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project to list resources on. Location must be a valid GCP region,
                    /// and may not be the "-" wildcard. Format: projects/{projectnumber}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Services to return in this call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token received from a previous call to ListServices. All other parameters must match.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>If true, returns deleted (but unexpired) resources along with active ones.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/services";

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

                /// <summary>Updates a Service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and
                /// instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
                /// projects/{project}/locations/{location}/services/{service_id}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a Service.</summary>
                public class PatchRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and
                    /// instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
                    /// projects/{project}/locations/{location}/services/{service_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and if the Service does not exist, it will create a new one. Caller must have
                    /// both create and update permissions for this call if this is set to true.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or updating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.CloudRun.v2.Data
{
    /// <summary>Settings for Binary Authorization feature.</summary>
    public class GoogleCloudRunV2BinaryAuthorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, indicates to use Breakglass using this justification. If use_default is False, then it must be
        /// empty. For more information on breakglass, see
        /// https://cloud.google.com/binary-authorization/docs/using-breakglass
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakglassJustification")]
        public virtual string BreakglassJustification { get; set; }

        /// <summary>
        /// If True, indicates to use the default project's binary authorization policy. If False, binary authorization
        /// will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useDefault")]
        public virtual System.Nullable<bool> UseDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a specific Cloud SQL instance.</summary>
    public class GoogleCloudRunV2CloudSqlInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances.
        /// Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL
        /// and Cloud Run. Format: {project}:{location}:{instance}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<string> Instances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a status condition for a resource.</summary>
    public class GoogleCloudRunV2Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reason for the execution condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionReason")]
        public virtual string ExecutionReason { get; set; }

        /// <summary>Last time the condition transitioned from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual object LastTransitionTime { get; set; }

        /// <summary>Human readable message indicating details about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>A common (service-level) reason for this condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>A reason for the revision condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionReason")]
        public virtual string RevisionReason { get; set; }

        /// <summary>How to interpret failures of this condition, one of Error, Warning, Info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>State of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// type is used to communicate the status of the reconciliation process. See also:
        /// https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common
        /// to all resources include: * "Ready": True when the Resource is ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single application container. This specifies both the container to run, the command to run in the container
    /// and the arguments to supply to it. Note that additional arguments may be supplied by the system to the container
    /// at runtime.
    /// </summary>
    public class GoogleCloudRunV2Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references
        /// $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference
        /// in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.
        /// More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not
        /// provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable
        /// cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be
        /// escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether
        /// the variable exists or not. More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>List of environment variables to set in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2EnvVar> Env { get; set; }

        /// <summary>
        /// Required. URL of the Container image in Google Container Registry or Google Artifact Registry. More info:
        /// https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Not Supported By Cloud Run. Periodic probe of container liveness. Container will be restarted if the probe
        /// fails. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessProbe")]
        public virtual GoogleCloudRunV2Probe LivenessProbe { get; set; }

        /// <summary>Name of the container specified as a DNS_LABEL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of ports to expose from the container. Only a single port can be specified. The specified ports must be
        /// listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will
        /// be chosen and passed to the container through the PORT environment variable for the container to listen on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2ContainerPort> Ports { get; set; }

        /// <summary>
        /// Compute Resource requirements by this container. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual GoogleCloudRunV2ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Startup probe of application within the container. All other probes are disabled if a startup probe is
        /// provided, until it succeeds. Container will not be added to service endpoints if the probe fails. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupProbe")]
        public virtual GoogleCloudRunV2Probe StartupProbe { get; set; }

        /// <summary>Volume to mount into the container's filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeMounts")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might
        /// be configured in the container image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    public class GoogleCloudRunV2ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Port number the container listens on. This must be a valid TCP port number, 0 &amp;lt; container_port
        /// &amp;lt; 65536.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPort { get; set; }

        /// <summary>
        /// If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    public class GoogleCloudRunV2EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the environment variable. Must be a C_IDENTIFIER, and mnay not exceed 32768 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the
        /// container and any route environment variables. If a variable cannot be resolved, the reference in the input
        /// string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped
        /// references will never be expanded, regardless of whether the variable exists or not. Defaults to "", and the
        /// maximum length is 32768 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>Source for the environment variable's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueSource")]
        public virtual GoogleCloudRunV2EnvVarSource ValueSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    public class GoogleCloudRunV2EnvVarSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretKeyRef")]
        public virtual GoogleCloudRunV2SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Execution represents the configuration of a single execution. A execution an immutable resource that references
    /// a container image which is run to completion.
    /// </summary>
    public class GoogleCloudRunV2Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>KRM-style annotations for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. Represents time when the execution was completed. It is not guaranteed to be set in
        /// happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual object CompletionTime { get; set; }

        /// <summary>
        /// Output only. The Condition of this Execution, containing its readiness status, and detailed error
        /// information in case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>
        /// Output only. Represents time when the execution was acknowledged by the execution controller. It is not
        /// guaranteed to be set in happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>Output only. The number of tasks which reached phase Failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedCount")]
        public virtual System.Nullable<int> FailedCount { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Output only. The name of the parent Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual string Job { get; set; }

        /// <summary>
        /// KRM-style labels for the resource. User-provided labels are shared with Google's billing system, so they can
        /// be used to filter, or break down billing charges by team, component, environment, state, etc. For more
        /// information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will
        /// not be preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Set the launch stage to a preview stage on write to allow use of preview features in that stage. On read,
        /// describes whether the resource uses preview features. Launch Stages are defined at [Google Cloud Platform
        /// Launch Stages](https://cloud.google.com/terms/launch-stages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Output only. The unique name of this Execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Execution. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Specifies the maximum desired number of tasks the execution should run at any given time. Must
        /// be &amp;lt;= task_count. The actual number of tasks running in steady state will be less than this number
        /// when ((.spec.task_count - .status.successful) &amp;lt; .spec.parallelism), i.e. when the work left to do is
        /// less than max parallelism. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Job.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The number of actively running tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runningCount")]
        public virtual System.Nullable<int> RunningCount { get; set; }

        /// <summary>
        /// Output only. Represents time when the execution started to run. It is not guaranteed to be set in
        /// happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. The number of tasks which reached phase Succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededCount")]
        public virtual System.Nullable<int> SucceededCount { get; set; }

        /// <summary>
        /// Output only. Specifies the desired number of tasks the execution should run. Setting to 1 means that
        /// parallelism is limited to 1 and the success of that task signals the success of the execution. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>Output only. Describes the task(s) that will be created when executing an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2TaskTemplate Template { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>
    /// Reference to an Execution. Use /Executions.GetExecution with the given name to get full execution including the
    /// latest status.
    /// </summary>
    public class GoogleCloudRunV2ExecutionReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual object CompletionTime { get; set; }

        /// <summary>Creation timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Name of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecutionTemplate describes the data an execution should have when created from a template.</summary>
    public class GoogleCloudRunV2ExecutionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>KRM-style annotations for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>KRM-style labels for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Specifies the maximum desired number of tasks the execution should run at given time. Must be &amp;lt;=
        /// task_count. When the job is run, if this field is 0 or unset, the maximum possible value will be used for
        /// that execution. The actual number of tasks running in steady state will be less than this number when there
        /// are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max
        /// parallelism.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>
        /// Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is
        /// limited to 1 and the success of that task signals the success of the execution. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>Required. Describes the task(s) that will be created when executing an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2TaskTemplate Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GRPCAction describes an action involving a GRPC port.</summary>
    public class GoogleCloudRunV2GRPCAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Port number of the gRPC service. Number must be in the range 1 to 65535.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Service is the name of the service to place in the gRPC HealthCheckRequest (see
        /// https://github.com/grpc/grpc/blob/master/doc/health-checking.md). If this is not specified, the default
        /// behavior is defined by gRPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary>
    public class GoogleCloudRunV2HTTPGetAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2HTTPHeader> HttpHeaders { get; set; }

        /// <summary>Path to access on the HTTP server. Defaults to '/'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
    public class GoogleCloudRunV2HTTPHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The header field name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The header field value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Job represents the configuration of a single job. A job an immutable resource that references a container image
    /// which is run to completion.
    /// </summary>
    public class GoogleCloudRunV2Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// KRM-style annotations for the resource. Unstructured key value map that may be set by external tools to
        /// store and arbitrary metadata. They are not queryable and should be preserved when modifying objects. Cloud
        /// Run will populate some annotations using 'run.googleapis.com' or 'serving.knative.dev' namespaces. This
        /// field follows Kubernetes annotations' namespacing, limits, and rules. More info:
        /// https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Settings for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual GoogleCloudRunV2BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Arbitrary identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Arbitrary version identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>
        /// Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics
        /// information in case the Job does not reach its desired state. See comments in `reconciling` for additional
        /// information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Output only. The deletion time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Number of executions created for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionCount")]
        public virtual System.Nullable<int> ExecutionCount { get; set; }

        /// <summary>Output only. For a deleted resource, the time after which it will be permamently deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// KRM-style labels for the resource. User-provided labels are shared with Google's billing system, so they can
        /// be used to filter, or break down billing charges by team, component, environment, state, etc. For more
        /// information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will
        /// not be preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Email address of the last authenticated modifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifier")]
        public virtual string LastModifier { get; set; }

        /// <summary>Output only. Name of the last created execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedExecution")]
        public virtual GoogleCloudRunV2ExecutionReference LatestCreatedExecution { get; set; }

        /// <summary>
        /// The launch stage as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no
        /// value is specified, GA is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Job. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Returns true if the Job is currently being acted upon by the system to bring it into the
        /// desired state. When a new Job is created, or an existing one is updated, Cloud Run will asynchronously
        /// perform all necessary steps to bring the Job to the desired state. This process is called reconciliation.
        /// While reconciliation is in process, `observed_generation` and `latest_succeeded_execution`, will have
        /// transient values that might mismatch the intended state: Once reconciliation is over (and this field is
        /// false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there
        /// was an error, and reconciliation failed. This state can be found in `terminal_condition.state`. If
        /// reconciliation succeeded, the following fields will match: `observed_generation` and `generation`,
        /// `latest_succeeded_execution` and `latest_created_execution`. If reconciliation failed, `observed_generation`
        /// and `latest_succeeded_execution` will have the state of the last succeeded execution or empty for newly
        /// created Job. Additional information on the failure can be found in `terminal_condition` and `conditions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Required. The template used to create executions for this Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2ExecutionTemplate Template { get; set; }

        /// <summary>
        /// Output only. The Condition of this Job, containing its readiness status, and detailed error information in
        /// case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalCondition")]
        public virtual GoogleCloudRunV2Condition TerminalCondition { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Response message containing a list of Executions.</summary>
    public class GoogleCloudRunV2ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting list of Executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Execution> Executions { get; set; }

        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListExecutions request to
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Jobs.</summary>
    public class GoogleCloudRunV2ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting list of Jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Job> Jobs { get; set; }

        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListJobs request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Revisions.</summary>
    public class GoogleCloudRunV2ListRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListRevisions request to
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Revision> Revisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Services.</summary>
    public class GoogleCloudRunV2ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListServices request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Service> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Tasks.</summary>
    public class GoogleCloudRunV2ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListTasks request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Task> Tasks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to
    /// receive traffic.
    /// </summary>
    public class GoogleCloudRunV2Probe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3.
        /// Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<int> FailureThreshold { get; set; }

        /// <summary>
        /// GRPC specifies an action involving a GRPC port. Exactly one of HTTPGet, TCPSocket, or GRPC must be
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpc")]
        public virtual GoogleCloudRunV2GRPCAction Grpc { get; set; }

        /// <summary>
        /// HTTPGet specifies the http request to perform. Exactly one of HTTPGet, TCPSocket, or gRPC must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpGet")]
        public virtual GoogleCloudRunV2HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds.
        /// Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. More
        /// info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelaySeconds")]
        public virtual System.Nullable<int> InitialDelaySeconds { get; set; }

        /// <summary>
        /// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for
        /// liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than
        /// timeout_seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodSeconds")]
        public virtual System.Nullable<int> PeriodSeconds { get; set; }

        /// <summary>
        /// TCPSocket specifies an action involving a TCP port. Exactly one of HTTPGet, TCPSocket, or gRPC must be
        /// specified. TCP hooks not yet supported
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpSocket")]
        public virtual GoogleCloudRunV2TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value
        /// is 3600. Must be smaller than period_seconds. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class GoogleCloudRunV2ResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines whether CPU should be throttled or not outside of requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuIdle")]
        public virtual System.Nullable<bool> CpuIdle { get; set; }

        /// <summary>
        /// Only memory and CPU are supported. Note: The only supported values for CPU are '1', '2', and '4'. Setting 4
        /// CPU requires at least 2Gi of memory. The values of the map is string form of the 'quantity' k8s type:
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Revision is an immutable snapshot of code and configuration. A Revision references a container image.
    /// Revisions are only created by updates to its parent Service.
    /// </summary>
    public class GoogleCloudRunV2Revision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>KRM-style annotations for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. The Condition of this Revision, containing its readiness status, and detailed error information
        /// in case it did not reach a serving state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The execution environment being used to host this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// KRM-style labels for the resource. User-provided labels are shared with Google's billing system, so they can
        /// be used to filter, or break down billing charges by team, component, environment, state, etc. For more
        /// information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will
        /// not be preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Set the launch stage to a preview stage on write to allow use of preview features in that stage. On read,
        /// describes whether the resource uses preview features. Launch Stages are defined at [Google Cloud Platform
        /// Launch Stages](https://cloud.google.com/terms/launch-stages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Output only. The Google Console URI to obtain logs for the Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>Output only. The unique name of this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Revision currently serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Service.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Scaling settings for this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2RevisionScaling Scaling { get; set; }

        /// <summary>Output only. The name of the parent service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the revision of the service. The service account
        /// represents the identity of the running revision, and determines what permissions the revision has.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Max allowed time for an instance to respond to a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Revision. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// VPC Access configuration for this Revision. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }
    }

    /// <summary>Settings for revision-level scaling settings.</summary>
    public class GoogleCloudRunV2RevisionScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of serving instances that this resource should have.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceCount")]
        public virtual System.Nullable<int> MaxInstanceCount { get; set; }

        /// <summary>Minimum number of serving instances that this resource should have.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstanceCount")]
        public virtual System.Nullable<int> MinInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevisionTemplate describes the data a revision should have when created from a template.</summary>
    public class GoogleCloudRunV2RevisionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>KRM-style annotations for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>The sandbox environment to host this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>KRM-style labels for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>
        /// The unique name for the revision. If this field is omitted, it will be automatically generated based on the
        /// Service name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Scaling settings for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2RevisionScaling Scaling { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the revision of the service. The service account
        /// represents the identity of the running revision, and determines what permissions the revision has. If not
        /// provided, the revision will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Max allowed time for an instance to respond to a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// VPC Access configuration to use for this Revision. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to create a new Execution of a Job.</summary>
    public class GoogleCloudRunV2RunJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict
        /// during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Indicates that the request should be validated without actually deleting any resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    /// <summary>SecretEnvVarSource represents a source for the value of an EnvVar.</summary>
    public class GoogleCloudRunV2SecretKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the secret in Cloud Secret Manager. Format: {secret_name} if the secret is in the same
        /// project. projects/{project}/secrets/{secret_name} if the secret is in a different project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The secret's value will be presented as the content of a file whose name is defined in the item path. If no
    /// items are defined, the name of the file is the secret.
    /// </summary>
    public class GoogleCloudRunV2SecretVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer representation of mode bits to use on created files by default. Must be a value between 0000 and
        /// 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting. Notes *
        /// Internally, a umask of 0222 will be applied to any non-zero value. * This is an integer representation of
        /// the mode bits. So, the octal integer value should look exactly as the chmod numeric notation with a leading
        /// zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal) or 511 (base-10). For chmod 640 (u=rw,g=r),
        /// set to 0640 (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10).
        /// * This might be in conflict with other options that affect the file mode, like fsGroup, and the result can
        /// be other mode bits set. This might be in conflict with other options that affect the file mode, like
        /// fsGroup, and as a result, other mode bits could be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path.
        /// If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be
        /// the name of the file exposed in the volume. When items are defined, they must specify a path and a version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2VersionToPath> Items { get; set; }

        /// <summary>
        /// Required. The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same
        /// project. projects/{project}/secrets/{secret} if the secret is in a different project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Service acts as a top-level container that manages a set of configurations and revision templates which
    /// implement a network service. Service exists to provide a singular abstraction which can be access controlled,
    /// reasoned about, and which encapsulates software lifecycle decisions such as rollout policy and team resource
    /// ownership.
    /// </summary>
    public class GoogleCloudRunV2Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not
        /// queryable and should be preserved when modifying objects. Cloud Run will populate some annotations using
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. This field follows Kubernetes annotations'
        /// namespacing, limits, and rules. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Settings for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual GoogleCloudRunV2BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Arbitrary identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Arbitrary version identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>
        /// Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics
        /// information in case the Service does not reach its Serving state. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Output only. The deletion time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>User-provided description of the Service. This field currently has a 512-character limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. For a deleted resource, the time after which it will be permamently deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state. Please
        /// note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a
        /// `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Provides the ingress settings for this Service. On output, returns the currently observed ingress settings,
        /// or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingress")]
        public virtual string Ingress { get; set; }

        /// <summary>
        /// Map of string keys and values that can be used to organize and categorize objects. User-provided labels are
        /// shared with Google's billing system, so they can be used to filter, or break down billing charges by team,
        /// component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will
        /// not be preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Email address of the last authenticated modifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifier")]
        public virtual string LastModifier { get; set; }

        /// <summary>
        /// Output only. Name of the last created revision. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevision")]
        public virtual string LatestCreatedRevision { get; set; }

        /// <summary>
        /// Output only. Name of the latest revision that is serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevision")]
        public virtual string LatestReadyRevision { get; set; }

        /// <summary>
        /// The launch stage as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no
        /// value is specified, GA is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and instead
        /// composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
        /// projects/{project}/locations/{location}/services/{service_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Service currently serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64
        /// value. As with most Google APIs, its JSON representation will be a `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Returns true if the Service is currently being acted upon by the system to bring it into the
        /// desired state. When a new Service is created, or an existing one is updated, Cloud Run will asynchronously
        /// perform all necessary steps to bring the Service to the desired serving state. This process is called
        /// reconciliation. While reconciliation is in process, `observed_generation`, `latest_ready_revison`,
        /// `traffic_statuses`, and `uri` will have transient values that might mismatch the intended state: Once
        /// reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded
        /// and the serving state matches the Service, or there was an error, and reconciliation failed. This state can
        /// be found in `terminal_condition.state`. If reconciliation succeeded, the following fields will match:
        /// `traffic` and `traffic_statuses`, `observed_generation` and `generation`, `latest_ready_revision` and
        /// `latest_created_revision`. If reconciliation failed, `traffic_statuses`, `observed_generation`, and
        /// `latest_ready_revision` will have the state of the last serving revision, or empty for newly created
        /// Services. Additional information on the failure can be found in `terminal_condition` and `conditions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Required. The template used to create revisions for this Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2RevisionTemplate Template { get; set; }

        /// <summary>
        /// Output only. The Condition of this Service, containing its readiness status, and detailed error information
        /// in case it did not reach a serving state. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalCondition")]
        public virtual GoogleCloudRunV2Condition TerminalCondition { get; set; }

        /// <summary>
        /// Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If traffic is
        /// empty or not provided, defaults to 100% traffic to the latest `Ready` Revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// Output only. Detailed status information for corresponding traffic targets. See comments in `reconciling`
        /// for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2TrafficTargetStatus> TrafficStatuses { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. The main URI in which this Service is serving traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }
    }

    /// <summary>TCPSocketAction describes an action based on opening a socket</summary>
    public class GoogleCloudRunV2TCPSocketAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Host name to connect to, defaults to the pod IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be
        /// an IANA_SVC_NAME. This field is currently limited to integer types only because of proto's inability to
        /// properly support the IntOrString golang type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task represents a single run of a container to completion.</summary>
    public class GoogleCloudRunV2Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>KRM-style annotations for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. Represents time when the Task was completed. It is not guaranteed to be set in happens-before
        /// order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual object CompletionTime { get; set; }

        /// <summary>
        /// Output only. The Condition of this Task, containing its readiness status, and detailed error information in
        /// case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// Output only. Represents time when the task was created by the job controller. It is not guaranteed to be set
        /// in happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Output only. A reference to a customer managed encryption key (CMEK) to use to encrypt this container image.
        /// For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. The name of the parent Execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execution")]
        public virtual string Execution { get; set; }

        /// <summary>The execution environment being used to host this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Output only. Index of the Task, unique per execution, and beginning at 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Output only. The name of the parent Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual string Job { get; set; }

        /// <summary>
        /// KRM-style labels for the resource. User-provided labels are shared with Google's billing system, so they can
        /// be used to filter, or break down billing charges by team, component, environment, state, etc. For more
        /// information, visit https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels Cloud Run will populate some labels with
        /// 'run.googleapis.com' or 'serving.knative.dev' namespaces. Those labels are read-only, and user changes will
        /// not be preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Result of the last attempt of this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttemptResult")]
        public virtual GoogleCloudRunV2TaskAttemptResult LastAttemptResult { get; set; }

        /// <summary>
        /// Set the launch stage to a preview stage on write to allow use of preview features in that stage. On read,
        /// describes whether the resource uses preview features. Launch Stages are defined at [Google Cloud Platform
        /// Launch Stages](https://cloud.google.com/terms/launch-stages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>Output only. The unique name of this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Task. See comments in `Job.reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Job.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Output only. The number of times this Task was retried. Tasks are retried when they fail up to the
        /// maxRetries limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retried")]
        public virtual System.Nullable<int> Retried { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the Task of a Job. The service account represents
        /// the identity of the running task, and determines what permissions the task has. If not provided, the task
        /// will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Output only. Represents time when the task started to run. It is not guaranteed to be set in happens-before
        /// order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Max allowed time duration the Task may be active before the system will actively try to mark it failed and
        /// kill associated containers. This applies per attempt of a task, meaning each retry can run for the full
        /// timeout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Task. The value is a UUID4 string and guaranteed to
        /// remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// Output only. VPC Access configuration to use for this Task. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }
    }

    /// <summary>Result of a task attempt.</summary>
    public class GoogleCloudRunV2TaskAttemptResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The exit code of this attempt. This may be unset if the container was unable to exit cleanly
        /// with a code due to some other failure. See status field for possible failure details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Output only. The status of this attempt. If the status code is OK, then the attempt succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TaskTemplate describes the data a task should have when created from a template.</summary>
    public class GoogleCloudRunV2TaskTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>The execution environment being used to host this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the Task of a Job. The service account represents
        /// the identity of the running task, and determines what permissions the task has. If not provided, the task
        /// will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Max allowed time duration the Task may be active before the system will actively try to mark it failed and
        /// kill associated containers. This applies per attempt of a task, meaning each retry can run for the full
        /// timeout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// VPC Access configuration to use for this Task. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds a single traffic routing entry for the Service. Allocations can be done to a specific Revision name, or
    /// pointing to the latest Ready Revision.
    /// </summary>
    public class GoogleCloudRunV2TrafficTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The allocation type for this traffic target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the observed state of a single `TrafficTarget` entry.</summary>
    public class GoogleCloudRunV2TrafficTargetStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies percent of the traffic to this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which this traffic is sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Indicates the string used in the URI to exclusively reference this target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The allocation type for this traffic target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Displays the target URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VersionToPath maps a specific version of a secret to a relative file to mount to, relative to VolumeMount's
    /// mount_path.
    /// </summary>
    public class GoogleCloudRunV2VersionToPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set,
        /// the Volume's default mode will be used. Notes * Internally, a umask of 0222 will be applied to any non-zero
        /// value. * This is an integer representation of the mode bits. So, the octal integer value should look exactly
        /// as the chmod numeric notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal)
        /// or 511 (base-10). For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755
        /// (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that
        /// affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual System.Nullable<int> Mode { get; set; }

        /// <summary>Required. The relative path of the secret in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume represents a named volume in a container.</summary>
    public class GoogleCloudRunV2Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For Cloud SQL volumes, contains the specific instances that should be mounted. Visit
        /// https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and
        /// Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual GoogleCloudRunV2CloudSqlInstance CloudSqlInstance { get; set; }

        /// <summary>Required. Volume's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Secret represents a secret that should populate this volume. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual GoogleCloudRunV2SecretVolumeSource Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    public class GoogleCloudRunV2VolumeMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud
        /// SQL volumes, it can be left empty, or must otherwise be `/cloudsql`. All instances defined in the Volume
        /// will be available as `/cloudsql/[instance]`. For more information on Cloud SQL volumes, visit
        /// https://cloud.google.com/sql/docs/mysql/connect-run
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>Required. This must match the Name of a Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VPC Access settings. For more information on creating a VPC Connector, visit
    /// https://cloud.google.com/vpc/docs/configure-serverless-vpc-access For information on how to configure Cloud Run
    /// with an existing VPC Connector, visit https://cloud.google.com/run/docs/configuring/connecting-vpc
    /// </summary>
    public class GoogleCloudRunV2VpcAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// VPC Access connector name. Format: projects/{project}/locations/{location}/connectors/{connector}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connector")]
        public virtual string Connector { get; set; }

        /// <summary>Traffic VPC egress settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egress")]
        public virtual string Egress { get; set; }

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
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

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
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
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
}
