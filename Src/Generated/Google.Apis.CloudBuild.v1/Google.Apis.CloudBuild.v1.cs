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

namespace Google.Apis.CloudBuild.v1
{
    /// <summary>The CloudBuild Service.</summary>
    public class CloudBuildService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudBuildService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudBuildService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudbuild";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudbuild.googleapis.com/";
        #else
            "https://cloudbuild.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudbuild.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Build API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Build API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudBuild requests.</summary>
    public abstract class CloudBuildBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudBuildBaseServiceRequest instance.</summary>
        protected CloudBuildBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudBuild parameter list.</summary>
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
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudBuild.v1.Data.CancelOperationRequest Body { get; set; }

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
                });
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
            Builds = new BuildsResource(service);
            Locations = new LocationsResource(service);
            Triggers = new TriggersResource(service);
        }

        /// <summary>Gets the Builds resource.</summary>
        public virtual BuildsResource Builds { get; }

        /// <summary>The "builds" collection of methods.</summary>
        public class BuildsResource
        {
            private const string Resource = "builds";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BuildsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Cancels a build in progress.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="id">Required. ID of the build.</param>
            public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string projectId, string id)
            {
                return new CancelRequest(service, body, projectId, id);
            }

            /// <summary>Cancels a build in progress.</summary>
            public class CancelRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Build>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string projectId, string id) : base(service)
                {
                    ProjectId = projectId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the build.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.CancelBuildRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/builds/{id}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Starts a build with the specified configuration. This method returns a long-running `Operation`, which
            /// includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as `SUCCESS`
            /// or `FAILURE`).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.Build body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>
            /// Starts a build with the specified configuration. This method returns a long-running `Operation`, which
            /// includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as `SUCCESS`
            /// or `FAILURE`).
            /// </summary>
            public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.Build body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// The parent resource where this build will be created. Format:
                /// `projects/{project}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Parent { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.Build Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/builds";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns information about a previously requested build. The `Build` that is returned includes its status
            /// (such as `SUCCESS`, `FAILURE`, or `WORKING`), and timing information.
            /// </summary>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="id">Required. ID of the build.</param>
            public virtual GetRequest Get(string projectId, string id)
            {
                return new GetRequest(service, projectId, id);
            }

            /// <summary>
            /// Returns information about a previously requested build. The `Build` that is returned includes its status
            /// (such as `SUCCESS`, `FAILURE`, or `WORKING`), and timing information.
            /// </summary>
            public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Build>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string id) : base(service)
                {
                    ProjectId = projectId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the build.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>
                /// The name of the `Build` to retrieve. Format:
                /// `projects/{project}/locations/{location}/builds/{build}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/builds/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists previously requested builds. Previously requested builds may still be in-progress, or may have
            /// finished successfully or unsuccessfully.
            /// </summary>
            /// <param name="projectId">Required. ID of the project.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>
            /// Lists previously requested builds. Previously requested builds may still be in-progress, or may have
            /// finished successfully or unsuccessfully.
            /// </summary>
            public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBuildsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The raw filter text to constrain the results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Number of results to return in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The page token for the next page of Builds. If unspecified, the first page of results is returned.
                /// If the token is rejected for any reason, INVALID_ARGUMENT will be thrown. In this case, the token
                /// should be discarded, and pagination should be restarted from the first page of results. See
                /// https://google.aip.dev/158 for more.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/location`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Parent { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/builds";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
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
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Creates a new build based on the specified build. This method creates a new build using the original
            /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
            /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build that
            /// uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original build
            /// built from the tip of a branch, the retried build will build from the tip of that branch, which may not
            /// be the same revision as the original build. * If the original build specified a commit sha or revision
            /// ID, the retried build will use the identical source. For builds that specify `StorageSource`: * If the
            /// original build pulled source from Google Cloud Storage without specifying the generation of the object,
            /// the new build will use the current object, which may be different from the original build source. * If
            /// the original build pulled source from Cloud Storage and specified the generation of the object, the new
            /// build will attempt to use the same object, which may or may not be available depending on the bucket's
            /// lifecycle management settings.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="id">Required. Build ID of the original build.</param>
            public virtual RetryRequest Retry(Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string projectId, string id)
            {
                return new RetryRequest(service, body, projectId, id);
            }

            /// <summary>
            /// Creates a new build based on the specified build. This method creates a new build using the original
            /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
            /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build that
            /// uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original build
            /// built from the tip of a branch, the retried build will build from the tip of that branch, which may not
            /// be the same revision as the original build. * If the original build specified a commit sha or revision
            /// ID, the retried build will use the identical source. For builds that specify `StorageSource`: * If the
            /// original build pulled source from Google Cloud Storage without specifying the generation of the object,
            /// the new build will use the current object, which may be different from the original build source. * If
            /// the original build pulled source from Cloud Storage and specified the generation of the object, the new
            /// build will attempt to use the same object, which may or may not be available depending on the bucket's
            /// lifecycle management settings.
            /// </summary>
            public class RetryRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Retry request.</summary>
                public RetryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string projectId, string id) : base(service)
                {
                    ProjectId = projectId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. Build ID of the original build.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.RetryBuildRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "retry";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/builds/{id}:retry";

                /// <summary>Initializes Retry parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
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
                Builds = new BuildsResource(service);
                Operations = new OperationsResource(service);
                Triggers = new TriggersResource(service);
                WorkerPools = new WorkerPoolsResource(service);
            }

            /// <summary>Gets the Builds resource.</summary>
            public virtual BuildsResource Builds { get; }

            /// <summary>The "builds" collection of methods.</summary>
            public class BuildsResource
            {
                private const string Resource = "builds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BuildsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Cancels a build in progress.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Build` to cancel. Format: `projects/{project}/locations/{location}/builds/{build}`
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>Cancels a build in progress.</summary>
                public class CancelRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Build>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Build` to cancel. Format:
                    /// `projects/{project}/locations/{location}/builds/{build}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.CancelBuildRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/builds/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Starts a build with the specified configuration. This method returns a long-running `Operation`,
                /// which includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as
                /// `SUCCESS` or `FAILURE`).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent resource where this build will be created. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.Build body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Starts a build with the specified configuration. This method returns a long-running `Operation`,
                /// which includes the build ID. Pass the build ID to `GetBuild` to determine the build status (such as
                /// `SUCCESS` or `FAILURE`).
                /// </summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.Build body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent resource where this build will be created. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.Build Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/builds";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns information about a previously requested build. The `Build` that is returned includes its
                /// status (such as `SUCCESS`, `FAILURE`, or `WORKING`), and timing information.
                /// </summary>
                /// <param name="name">
                /// The name of the `Build` to retrieve. Format:
                /// `projects/{project}/locations/{location}/builds/{build}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Returns information about a previously requested build. The `Build` that is returned includes its
                /// status (such as `SUCCESS`, `FAILURE`, or `WORKING`), and timing information.
                /// </summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Build>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Build` to retrieve. Format:
                    /// `projects/{project}/locations/{location}/builds/{build}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. ID of the build.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Id { get; set; }

                    /// <summary>Required. ID of the project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/builds/[^/]+$",
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists previously requested builds. Previously requested builds may still be in-progress, or may have
                /// finished successfully or unsuccessfully.
                /// </summary>
                /// <param name="parent">
                /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/location`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists previously requested builds. Previously requested builds may still be in-progress, or may have
                /// finished successfully or unsuccessfully.
                /// </summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBuildsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/location`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The raw filter text to constrain the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Number of results to return in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The page token for the next page of Builds. If unspecified, the first page of results is
                    /// returned. If the token is rejected for any reason, INVALID_ARGUMENT will be thrown. In this
                    /// case, the token should be discarded, and pagination should be restarted from the first page of
                    /// results. See https://google.aip.dev/158 for more.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Required. ID of the project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/builds";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates a new build based on the specified build. This method creates a new build using the original
                /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
                /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build
                /// that uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original
                /// build built from the tip of a branch, the retried build will build from the tip of that branch,
                /// which may not be the same revision as the original build. * If the original build specified a commit
                /// sha or revision ID, the retried build will use the identical source. For builds that specify
                /// `StorageSource`: * If the original build pulled source from Google Cloud Storage without specifying
                /// the generation of the object, the new build will use the current object, which may be different from
                /// the original build source. * If the original build pulled source from Cloud Storage and specified
                /// the generation of the object, the new build will attempt to use the same object, which may or may
                /// not be available depending on the bucket's lifecycle management settings.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Build` to retry. Format: `projects/{project}/locations/{location}/builds/{build}`
                /// </param>
                public virtual RetryRequest Retry(Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string name)
                {
                    return new RetryRequest(service, body, name);
                }

                /// <summary>
                /// Creates a new build based on the specified build. This method creates a new build using the original
                /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
                /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build
                /// that uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original
                /// build built from the tip of a branch, the retried build will build from the tip of that branch,
                /// which may not be the same revision as the original build. * If the original build specified a commit
                /// sha or revision ID, the retried build will use the identical source. For builds that specify
                /// `StorageSource`: * If the original build pulled source from Google Cloud Storage without specifying
                /// the generation of the object, the new build will use the current object, which may be different from
                /// the original build source. * If the original build pulled source from Cloud Storage and specified
                /// the generation of the object, the new build will attempt to use the same object, which may or may
                /// not be available depending on the bucket's lifecycle management settings.
                /// </summary>
                public class RetryRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Retry request.</summary>
                    public RetryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Build` to retry. Format:
                    /// `projects/{project}/locations/{location}/builds/{build}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.RetryBuildRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retry";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:retry";

                    /// <summary>Initializes Retry parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/builds/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
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
            }

            /// <summary>Gets the Triggers resource.</summary>
            public virtual TriggersResource Triggers { get; }

            /// <summary>The "triggers" collection of methods.</summary>
            public class TriggersResource
            {
                private const string Resource = "triggers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TriggersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new `BuildTrigger`. This API is experimental.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent resource where this trigger will be created. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new `BuildTrigger`. This API is experimental.</summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent resource where this trigger will be created. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the project for which to configure automatic builds.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.BuildTrigger Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/triggers";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a `BuildTrigger` by its project ID and trigger ID. This API is experimental.
                /// </summary>
                /// <param name="name">
                /// The name of the `Trigger` to delete. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a `BuildTrigger` by its project ID and trigger ID. This API is experimental.
                /// </summary>
                public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Trigger` to delete. Format:
                    /// `projects/{project}/locations/{location}/triggers/{trigger}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. ID of the project that owns the trigger.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Required. ID of the `BuildTrigger` to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TriggerId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/triggers/[^/]+$",
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns information about a `BuildTrigger`. This API is experimental.</summary>
                /// <param name="name">
                /// The name of the `Trigger` to retrieve. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about a `BuildTrigger`. This API is experimental.</summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Trigger` to retrieve. Format:
                    /// `projects/{project}/locations/{location}/triggers/{trigger}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. ID of the project that owns the trigger.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TriggerId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/triggers/[^/]+$",
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists existing `BuildTrigger`s. This API is experimental.</summary>
                /// <param name="parent">
                /// The parent of the collection of `Triggers`. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists existing `BuildTrigger`s. This API is experimental.</summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBuildTriggersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent of the collection of `Triggers`. Format: `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Number of results to return in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Required. ID of the project for which to list BuildTriggers.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/triggers";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates a `BuildTrigger` by its project ID and trigger ID. This API is experimental.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resourceName">
                /// The `Trigger` name with format: `projects/{project}/locations/{location}/triggers/{trigger}`, where
                /// {trigger} is a unique identifier generated by the service.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string resourceName)
                {
                    return new PatchRequest(service, body, resourceName);
                }

                /// <summary>
                /// Updates a `BuildTrigger` by its project ID and trigger ID. This API is experimental.
                /// </summary>
                public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string resourceName) : base(service)
                    {
                        ResourceName = resourceName;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The `Trigger` name with format: `projects/{project}/locations/{location}/triggers/{trigger}`,
                    /// where {trigger} is a unique identifier generated by the service.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ResourceName { get; private set; }

                    /// <summary>Required. ID of the project that owns the trigger.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Required. ID of the `BuildTrigger` to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TriggerId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.BuildTrigger Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resourceName}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/triggers/[^/]+$",
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Runs a `BuildTrigger` at a particular source revision.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Trigger` to run. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual RunRequest Run(Google.Apis.CloudBuild.v1.Data.RunBuildTriggerRequest body, string name)
                {
                    return new RunRequest(service, body, name);
                }

                /// <summary>Runs a `BuildTrigger` at a particular source revision.</summary>
                public class RunRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RunBuildTriggerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `Trigger` to run. Format:
                    /// `projects/{project}/locations/{location}/triggers/{trigger}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.RunBuildTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:run";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/triggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// ReceiveTriggerWebhook [Experimental] is called when the API receives a webhook request targeted at a
                /// specific trigger.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `ReceiveTriggerWebhook` to retrieve. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual WebhookRequest Webhook(Google.Apis.CloudBuild.v1.Data.HttpBody body, string name)
                {
                    return new WebhookRequest(service, body, name);
                }

                /// <summary>
                /// ReceiveTriggerWebhook [Experimental] is called when the API receives a webhook request targeted at a
                /// specific trigger.
                /// </summary>
                public class WebhookRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ReceiveTriggerWebhookResponse>
                {
                    /// <summary>Constructs a new Webhook request.</summary>
                    public WebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.HttpBody body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the `ReceiveTriggerWebhook` to retrieve. Format:
                    /// `projects/{project}/locations/{location}/triggers/{trigger}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Project in which the specified trigger lives</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Secret token used for authorization if an OAuth token isn't provided.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("secret", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Secret { get; set; }

                    /// <summary>Name of the trigger to run the payload against</summary>
                    [Google.Apis.Util.RequestParameterAttribute("trigger", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Trigger { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.HttpBody Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "webhook";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:webhook";

                    /// <summary>Initializes Webhook parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/triggers/[^/]+$",
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("secret", new Google.Apis.Discovery.Parameter
                        {
                            Name = "secret",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("trigger", new Google.Apis.Discovery.Parameter
                        {
                            Name = "trigger",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the WorkerPools resource.</summary>
            public virtual WorkerPoolsResource WorkerPools { get; }

            /// <summary>The "workerPools" collection of methods.</summary>
            public class WorkerPoolsResource
            {
                private const string Resource = "workerPools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkerPoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a `WorkerPool`.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this worker pool will be created. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.WorkerPool body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a `WorkerPool`.</summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.WorkerPool body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this worker pool will be created. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// If set, validate the request and preview the response, but do not actually post it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>
                    /// Required. Immutable. The ID to use for the `WorkerPool`, which will become the final component
                    /// of the resource name. This value should be 1-63 characters, and valid characters are /a-z-/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("workerPoolId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WorkerPoolId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.WorkerPool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workerPools";

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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("workerPoolId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workerPoolId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a `WorkerPool`.</summary>
                /// <param name="name">
                /// Required. The name of the `WorkerPool` to delete. Format:
                /// `projects/{project}/locations/{workerPool}/workerPools/{workerPool}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a `WorkerPool`.</summary>
                public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `WorkerPool` to delete. Format:
                    /// `projects/{project}/locations/{workerPool}/workerPools/{workerPool}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the `WorkerPool` is not found, the request will succeed but no action will
                    /// be taken on the server.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. If this is provided, it must match the server's etag on the workerpool for the request
                    /// to be processed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// If set, validate the request and preview the response, but do not actually post it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

                /// <summary>Returns details of a `WorkerPool`.</summary>
                /// <param name="name">
                /// Required. The name of the `WorkerPool` to retrieve. Format:
                /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns details of a `WorkerPool`.</summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.WorkerPool>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `WorkerPool` to retrieve. Format:
                    /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists `WorkerPool`s.</summary>
                /// <param name="parent">
                /// Required. The parent of the collection of `WorkerPools`. Format:
                /// `projects/{project}/locations/location`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists `WorkerPool`s.</summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListWorkerPoolsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the collection of `WorkerPools`. Format:
                    /// `projects/{project}/locations/location`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of `WorkerPool`s to return. The service may return fewer than this value. If
                    /// omitted, the server will use a sensible default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListWorkerPools` call. Provide this to retrieve the
                    /// subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/workerPools";

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

                /// <summary>Updates a `WorkerPool`.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the `WorkerPool`, with format
                /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`. The value of `{worker_pool}` is
                /// provided by `worker_pool_id` in `CreateWorkerPool` request and the value of `{location}` is
                /// determined by the endpoint accessed.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.WorkerPool body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a `WorkerPool`.</summary>
                public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.WorkerPool body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the `WorkerPool`, with format
                    /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`. The value of
                    /// `{worker_pool}` is provided by `worker_pool_id` in `CreateWorkerPool` request and the value of
                    /// `{location}` is determined by the endpoint accessed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>A mask specifying which fields in `worker_pool` to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// If set, validate the request and preview the response, but do not actually post it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.WorkerPool Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
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
        }

        /// <summary>Gets the Triggers resource.</summary>
        public virtual TriggersResource Triggers { get; }

        /// <summary>The "triggers" collection of methods.</summary>
        public class TriggersResource
        {
            private const string Resource = "triggers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TriggersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new `BuildTrigger`. This API is experimental.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project for which to configure automatic builds.</param>
            public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>Creates a new `BuildTrigger`. This API is experimental.</summary>
            public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project for which to configure automatic builds.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// The parent resource where this trigger will be created. Format:
                /// `projects/{project}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Parent { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.BuildTrigger Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID. This API is experimental.</summary>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. ID of the `BuildTrigger` to delete.</param>
            public virtual DeleteRequest Delete(string projectId, string triggerId)
            {
                return new DeleteRequest(service, projectId, triggerId);
            }

            /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID. This API is experimental.</summary>
            public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string triggerId) : base(service)
                {
                    ProjectId = projectId;
                    TriggerId = triggerId;
                    InitParameters();
                }

                /// <summary>Required. ID of the project that owns the trigger.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the `BuildTrigger` to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TriggerId { get; private set; }

                /// <summary>
                /// The name of the `Trigger` to delete. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers/{triggerId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "triggerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns information about a `BuildTrigger`. This API is experimental.</summary>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.</param>
            public virtual GetRequest Get(string projectId, string triggerId)
            {
                return new GetRequest(service, projectId, triggerId);
            }

            /// <summary>Returns information about a `BuildTrigger`. This API is experimental.</summary>
            public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string triggerId) : base(service)
                {
                    ProjectId = projectId;
                    TriggerId = triggerId;
                    InitParameters();
                }

                /// <summary>Required. ID of the project that owns the trigger.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TriggerId { get; private set; }

                /// <summary>
                /// The name of the `Trigger` to retrieve. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers/{triggerId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "triggerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists existing `BuildTrigger`s. This API is experimental.</summary>
            /// <param name="projectId">Required. ID of the project for which to list BuildTriggers.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>Lists existing `BuildTrigger`s. This API is experimental.</summary>
            public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBuildTriggersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Required. ID of the project for which to list BuildTriggers.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Number of results to return in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to provide to skip to a particular spot in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The parent of the collection of `Triggers`. Format: `projects/{project}/locations/{location}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Parent { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
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
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID. This API is experimental.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. ID of the `BuildTrigger` to update.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId, string triggerId)
            {
                return new PatchRequest(service, body, projectId, triggerId);
            }

            /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID. This API is experimental.</summary>
            public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BuildTrigger>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId, string triggerId) : base(service)
                {
                    ProjectId = projectId;
                    TriggerId = triggerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project that owns the trigger.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the `BuildTrigger` to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TriggerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.BuildTrigger Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers/{triggerId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "triggerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Runs a `BuildTrigger` at a particular source revision.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="triggerId">Required. ID of the trigger.</param>
            public virtual RunRequest Run(Google.Apis.CloudBuild.v1.Data.RepoSource body, string projectId, string triggerId)
            {
                return new RunRequest(service, body, projectId, triggerId);
            }

            /// <summary>Runs a `BuildTrigger` at a particular source revision.</summary>
            public class RunRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RepoSource body, string projectId, string triggerId) : base(service)
                {
                    ProjectId = projectId;
                    TriggerId = triggerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the trigger.</summary>
                [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TriggerId { get; private set; }

                /// <summary>
                /// The name of the `Trigger` to run. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.RepoSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "run";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers/{triggerId}:run";

                /// <summary>Initializes Run parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "triggerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// ReceiveTriggerWebhook [Experimental] is called when the API receives a webhook request targeted at a
            /// specific trigger.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Project in which the specified trigger lives</param>
            /// <param name="trigger">Name of the trigger to run the payload against</param>
            public virtual WebhookRequest Webhook(Google.Apis.CloudBuild.v1.Data.HttpBody body, string projectId, string trigger)
            {
                return new WebhookRequest(service, body, projectId, trigger);
            }

            /// <summary>
            /// ReceiveTriggerWebhook [Experimental] is called when the API receives a webhook request targeted at a
            /// specific trigger.
            /// </summary>
            public class WebhookRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ReceiveTriggerWebhookResponse>
            {
                /// <summary>Constructs a new Webhook request.</summary>
                public WebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.HttpBody body, string projectId, string trigger) : base(service)
                {
                    ProjectId = projectId;
                    Trigger = trigger;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Project in which the specified trigger lives</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Name of the trigger to run the payload against</summary>
                [Google.Apis.Util.RequestParameterAttribute("trigger", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Trigger { get; private set; }

                /// <summary>
                /// The name of the `ReceiveTriggerWebhook` to retrieve. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Secret token used for authorization if an OAuth token isn't provided.</summary>
                [Google.Apis.Util.RequestParameterAttribute("secret", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Secret { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.HttpBody Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "webhook";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/triggers/{trigger}:webhook";

                /// <summary>Initializes Webhook parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("trigger", new Google.Apis.Discovery.Parameter
                    {
                        Name = "trigger",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secret", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secret",
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
namespace Google.Apis.CloudBuild.v1.Data
{
    /// <summary>
    /// Files in the workspace to upload to Cloud Storage upon successful completion of all build steps.
    /// </summary>
    public class ArtifactObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". (see [Bucket
        /// Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Files in the
        /// workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Path globs used to match files in the build's workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>Output only. Stores timing information for pushing all artifact objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual TimeSpan Timing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An artifact that was uploaded during a build. This is a single record in the artifact manifest JSON file.
    /// </summary>
    public class ArtifactResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The file hash of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<FileHashes> FileHash { get; set; }

        /// <summary>
        /// The path of an artifact in a Google Cloud Storage bucket, with the generation number. For example,
        /// `gs://mybucket/path/to/output.jar#generation`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Artifacts produced by a build that should be uploaded upon successful completion of all build steps.
    /// </summary>
    public class Artifacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images will be pushed
        /// using the builder service account's credentials. The digests of the pushed images will be stored in the
        /// Build resource's results field. If any of the images fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in
        /// the workspace matching specified paths globs will be uploaded to the specified Cloud Storage location using
        /// the builder service account's credentials. The location and generation of the uploaded objects will be
        /// stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual ArtifactObjects Objects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A build resource in the Cloud Build API. At a high level, a `Build` describes where to find source code, how to
    /// build it (for example, the builder image to run on the source), and where to store the built artifacts. Fields
    /// can include the following variables, which will be expanded when the build is created: - $PROJECT_ID: the
    /// project ID of the build. - $PROJECT_NUMBER: the project number of the build. - $BUILD_ID: the autogenerated ID
    /// of the build. - $REPO_NAME: the source repository name specified by RepoSource. - $BRANCH_NAME: the branch name
    /// specified by RepoSource. - $TAG_NAME: the tag name specified by RepoSource. - $REVISION_ID or $COMMIT_SHA: the
    /// commit SHA specified by RepoSource or resolved from the specified branch or tag. - $SHORT_SHA: first 7
    /// characters of $REVISION_ID or $COMMIT_SHA.
    /// </summary>
    public class Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual Artifacts Artifacts { get; set; }

        /// <summary>Secrets and secret environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableSecrets")]
        public virtual Secrets AvailableSecrets { get; set; }

        /// <summary>
        /// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildTriggerId")]
        public virtual string BuildTriggerId { get; set; }

        /// <summary>Output only. Time at which the request to create the build was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. Time at which execution of the build was finished. The difference between finish_time and
        /// start_time is the duration of the build's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>Output only. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using
        /// the builder service account's credentials. The digests of the pushed images will be stored in the `Build`
        /// resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>Output only. URL to logs for this build in Google Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUrl")]
        public virtual string LogUrl { get; set; }

        /// <summary>
        /// Google Cloud Storage bucket where logs should be written (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of
        /// the format `${logs_bucket}/log-${build_id}.txt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsBucket")]
        public virtual string LogsBucket { get; set; }

        /// <summary>
        /// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where
        /// {build} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Special options for this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual BuildOptions Options { get; set; }

        /// <summary>Output only. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will
        /// expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueTtl")]
        public virtual object QueueTtl { get; set; }

        /// <summary>Output only. Results of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual Results Results { get; set; }

        /// <summary>
        /// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for
        /// managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from
        /// Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual System.Collections.Generic.IList<Secret> Secrets { get; set; }

        /// <summary>
        /// IAM service account whose credentials will be used at build runtime. Must be of the format
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The location of the source files to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual SourceProvenance SourceProvenance { get; set; }

        /// <summary>Output only. Time at which execution of the build was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Status of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Customer-readable message about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Required. The operations to be performed on the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<BuildStep> Steps { get; set; }

        /// <summary>Substitutions data for `Build` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>Tags for annotation of a `Build`. These are not docker tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Amount of time that this build should be allowed to run, to second granularity. If this amount of time
        /// elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from
        /// `startTime`. Default time is ten minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all
        /// build steps * PUSH: time to push all specified images. * FETCHSOURCE: time to fetch source. If the build
        /// does not specify source or images, these keys will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual System.Collections.Generic.IDictionary<string, TimeSpan> Timing { get; set; }

        /// <summary>Output only. Non-fatal problems encountered during the execution of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for build operations.</summary>
    public class BuildOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The build that the operation is tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual Build Build { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional arguments to enable specific features of builds.</summary>
    public class BuildOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Requested disk size for the VM that runs the build. Note that this is *NOT* "disk free"; some of the space
        /// will be used by the operating system and build utilities. Also note that this is the minimum disk size that
        /// will be allocated for the build -- the build may run with a larger disk than requested. At present, the
        /// maximum disk size is 1000GB; builds that request more than the maximum are rejected with an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Option to specify whether or not to apply bash style string operations to the substitutions. NOTE: this is
        /// always enabled for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSubstitutions")]
        public virtual System.Nullable<bool> DynamicSubstitutions { get; set; }

        /// <summary>
        /// A list of global environment variable definitions that will exist for all build steps in this build. If a
        /// variable is defined in both globally and in a build step, the variable will use the build step value. The
        /// elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Option to define build log streaming behavior to Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logStreamingOption")]
        public virtual string LogStreamingOption { get; set; }

        /// <summary>Option to specify the logging mode, which determines if and where build logs are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual string Logging { get; set; }

        /// <summary>Compute Engine machine type on which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. Specification for execution on a `WorkerPool`. See [running builds in a private
        /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual PoolOption Pool { get; set; }

        /// <summary>Requested verifiability options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedVerifyOption")]
        public virtual string RequestedVerifyOption { get; set; }

        /// <summary>
        /// A list of global environment variables, which are encrypted using a Cloud Key Management Service crypto key.
        /// These values must be specified in the build's `Secret`. These variables will be available to all build steps
        /// in this build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>Requested hash for SourceProvenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenanceHash")]
        public virtual System.Collections.Generic.IList<string> SourceProvenanceHash { get; set; }

        /// <summary>
        /// Option to specify behavior when there is an error in the substitution checks. NOTE: this is always set to
        /// ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutionOption")]
        public virtual string SubstitutionOption { get; set; }

        /// <summary>
        /// Global list of volumes to mount for ALL build steps Each volume is created as an empty volume prior to
        /// starting the build process. Upon completion of the build, volumes and their contents are discarded. Global
        /// volume names and paths cannot conflict with the volumes defined a build step. Using a global volume in a
        /// build with only one step is not valid as it is indicative of a build request with an incorrect
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>This field deprecated; please use `pool.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step in the build pipeline.</summary>
    public class BuildStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Working directory to use when running this step's container. If this value is a relative path, it is
        /// relative to the build's working directory. If this value is absolute, it may be outside the build's working
        /// directory, in which case the contents of the path may not be persisted across build step executions, unless
        /// a `volume` for that path is specified. If the build specifies a `RepoSource` with `dir` and a step with a
        /// `dir`, which specifies an absolute path, the `RepoSource` `dir` is ignored for the step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default
        /// entrypoint is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// A list of environment variable definitions to be used when running a step. The elements are of the form
        /// "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// Unique identifier for this build step, used in `wait_for` to reference this build step as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the container image that will run this particular build step. If the image is
        /// available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to
        /// pull the image first, using the builder service account's credentials if necessary. The Docker daemon's
        /// cache will already have the latest versions of all of the officially supported build steps
        /// ([https://github.com/GoogleCloudPlatform/cloud-builders](https://github.com/GoogleCloudPlatform/cloud-builders)).
        /// The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian",
        /// but they will be refreshed at the time you attempt to use them. If you built an image in a previous build
        /// step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later
        /// build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pulling this build step's builder image only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullTiming")]
        public virtual TimeSpan PullTiming { get; set; }

        /// <summary>
        /// A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These
        /// values must be specified in the build's `Secret`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>
        /// Output only. Status of the build step. At this time, build step status is only updated on build completion;
        /// step status is not updated in real-time as the build progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to
        /// continue to run until either it completes or the build itself times out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Output only. Stores timing information for executing this build step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual TimeSpan Timing { get; set; }

        /// <summary>
        /// List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution
        /// of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named
        /// volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>
        /// The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build
        /// steps in `wait_for` have completed successfully. If `wait_for` is empty, this build step will start when all
        /// previous build steps in the `Build.Steps` list have completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an automated build in response to source repository changes.</summary>
    public class BuildTrigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Autodetect build configuration. The following precedence is used (case insensitive): 1. cloudbuild.yaml 2.
        /// cloudbuild.yml 3. cloudbuild.json 4. Dockerfile Currently only available for GitHub App Triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>Contents of the build template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual Build Build { get; set; }

        /// <summary>Output only. Time when the trigger was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Human-readable description of this trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>If true, the trigger will never automatically execute a build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Path, from the source root, to the build configuration file (i.e. cloudbuild.yaml).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>Optional. A Common Expression Language string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// GitHubEventsConfig describes the configuration of a trigger that creates a build whenever a GitHub event is
        /// received. Mutually exclusive with `trigger_template`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("github")]
        public virtual GitHubEventsConfig Github { get; set; }

        /// <summary>Output only. Unique identifier of the trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// ignored_files and included_files are file glob matches using https://golang.org/pkg/path/filepath/#Match
        /// extended with support for "**". If ignored_files and changed files are both empty, then they are not used to
        /// determine whether or not to trigger a build. If ignored_files is not empty, then we ignore any files that
        /// match any of the ignored_file globs. If the change has no files that are outside of the ignored_files globs,
        /// then we do not trigger a build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoredFiles")]
        public virtual System.Collections.Generic.IList<string> IgnoredFiles { get; set; }

        /// <summary>
        /// If any of the files altered in the commit pass the ignored_files filter and included_files is empty, then as
        /// far as this filter is concerned, we should trigger the build. If any of the files altered in the commit pass
        /// the ignored_files filter and included_files is not empty, then we make sure that at least one of those files
        /// matches a included_files glob. If not, then we do not trigger a build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedFiles")]
        public virtual System.Collections.Generic.IList<string> IncludedFiles { get; set; }

        /// <summary>
        /// User-assigned name of the trigger. Must be unique within the project. Trigger names must meet the following
        /// requirements: + They must contain only alphanumeric characters and dashes. + They can be 1-64 characters
        /// long. + They must begin and end with an alphanumeric character.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is
        /// published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubConfig")]
        public virtual PubsubConfig PubsubConfig { get; set; }

        /// <summary>
        /// The `Trigger` name with format: `projects/{project}/locations/{location}/triggers/{trigger}`, where
        /// {trigger} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Substitutions for Build resource. The keys must match the following regular expression: `^_[A-Z0-9_]+$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>Tags for annotation of a `BuildTrigger`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Template describing the types of source changes to trigger a build. Branch and tag names in trigger
        /// templates are interpreted as regular expressions. Any branch or tag change that matches that regular
        /// expression will trigger a build. Mutually exclusive with `github`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerTemplate")]
        public virtual RepoSource TriggerTemplate { get; set; }

        /// <summary>
        /// WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a
        /// trigger's webhook URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookConfig")]
        public virtual WebhookConfig WebhookConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image built by the pipeline.</summary>
    public class BuiltImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Docker Registry 2.0 digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// Name used to push the container image to Google Container Registry, as presented to `docker push`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual TimeSpan PushTiming { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to cancel an ongoing build.</summary>
    public class CancelBuildRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The name of the `Build` to cancel. Format: `projects/{project}/locations/{location}/builds/{build}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `CreateWorkerPool` operation.</summary>
    public class CreateWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The resource name of the `WorkerPool` to create. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `DeleteWorkerPool` operation.</summary>
    public class DeleteWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The resource name of the `WorkerPool` being deleted. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

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
    /// Container message for hashes of byte content of files, used in SourceProvenance messages to verify integrity of
    /// source input to the build.
    /// </summary>
    public class FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GitHubEventsConfig describes the configuration of a trigger that creates a build whenever a GitHub event is
    /// received. This message is experimental.
    /// </summary>
    public class GitHubEventsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The installationID that emits the GitHub event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationId")]
        public virtual System.Nullable<long> InstallationId { get; set; }

        /// <summary>
        /// Name of the repository. For example: The name for https://github.com/googlecloudplatform/cloud-builders is
        /// "cloud-builders".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Owner of the repository. For example: The owner for https://github.com/googlecloudplatform/cloud-builders is
        /// "googlecloudplatform".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual string Owner { get; set; }

        /// <summary>filter to match changes in pull requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullRequest")]
        public virtual PullRequestFilter PullRequest { get; set; }

        /// <summary>filter to match changes in refs like branches, tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("push")]
        public virtual PushFilter Push { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPDelivery is the delivery configuration for an HTTP notification.</summary>
    public class HTTPDelivery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI to which JSON-containing HTTP POST requests should be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables mapped to encrypted values with the Cloud KMS key to use to decrypt
    /// the value.
    /// </summary>
    public class InlineSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvMap { get; set; }

        /// <summary>
        /// Resource name of Cloud KMS crypto key to decrypt the encrypted value. In format:
        /// projects/*/locations/*/keyRings/*/cryptoKeys/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing existing `BuildTriggers`.</summary>
    public class ListBuildTriggersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to receive the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>`BuildTriggers` for the project, sorted by `create_time` descending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggers")]
        public virtual System.Collections.Generic.IList<BuildTrigger> Triggers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response including listed builds.</summary>
    public class ListBuildsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Builds will be sorted by `create_time`, descending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builds")]
        public virtual System.Collections.Generic.IList<Build> Builds { get; set; }

        /// <summary>
        /// Token to receive the next page of results. This will be absent if the end of the response list has been
        /// reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing existing `WorkerPools`.</summary>
    public class ListWorkerPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to page through large result sets. Provide this value in a subsequent
        /// ListWorkerPoolsRequest to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>`WorkerPools` for the specified project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPools")]
        public virtual System.Collections.Generic.IList<WorkerPool> WorkerPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the network configuration for the pool.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Option to configure network egress for the workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressOption")]
        public virtual string EgressOption { get; set; }

        /// <summary>
        /// Required. Immutable. The network definition that the workers are peered to. If this section is left empty,
        /// the workers will be peered to `WorkerPool.project_id` on the service producer network. Must be in the format
        /// `projects/{project}/global/networks/{network}`, where `{project}` is a project number, such as `12345`, and
        /// `{network}` is the name of a VPC network in the project. See [Understanding network configuration
        /// options](https://cloud.google.com/build/docs/private-pools/set-up-private-pool-environment)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeredNetwork")]
        public virtual string PeeredNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Notification is the container which holds the data that is relevant to this particular notification.
    /// </summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The filter string to use for notification filtering. Currently, this is assumed to be a CEL program. See
        /// https://opensource.google/projects/cel for more.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Configuration for HTTP delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpDelivery")]
        public virtual HTTPDelivery HttpDelivery { get; set; }

        /// <summary>Configuration for Slack delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slackDelivery")]
        public virtual SlackDelivery SlackDelivery { get; set; }

        /// <summary>Configuration for SMTP (email) delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smtpDelivery")]
        public virtual SMTPDelivery SmtpDelivery { get; set; }

        /// <summary>Escape hatch for users to supply custom delivery configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structDelivery")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructDelivery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NotifierConfig is the top-level configuration message.</summary>
    public class NotifierConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version of this configuration format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The type of notifier to use (e.g. SMTPNotifier).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata for referring to/handling/deploying this notifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual NotifierMetadata Metadata { get; set; }

        /// <summary>The actual configuration for this notifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual NotifierSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NotifierMetadata contains the data which can be used to reference or describe this notifier.</summary>
    public class NotifierMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The human-readable and user-given name for the notifier. For example: "repo-merge-email-notifier".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The string representing the name and version of notifier to deploy. Expected to be of the form of "/:". For
        /// example: "gcr.io/my-project/notifiers/smtp:1.2.34".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifier")]
        public virtual string Notifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NotifierSecret is the container that maps a secret name (reference) to its Google Cloud Secret Manager resource
    /// path.
    /// </summary>
    public class NotifierSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name is the local name of the secret, such as the verbatim string "my-smtp-password".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Value is interpreted to be a resource path for fetching the actual (versioned) secret data for this secret.
        /// For example, this would be a Google Cloud Secret Manager secret version resource path like:
        /// "projects/my-project/secrets/my-secret/versions/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NotifierSecretRef contains the reference to a secret stored in the corresponding NotifierSpec.
    /// </summary>
    public class NotifierSecretRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of `secret_ref` should be a `name` that is registered in a `Secret` in the `secrets` list of the
        /// `Spec`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretRef")]
        public virtual string SecretRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NotifierSpec is the configuration container for notifications.</summary>
    public class NotifierSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration of this particular notifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notification")]
        public virtual Notification Notification { get; set; }

        /// <summary>Configurations for secret resources used by this particular notifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual System.Collections.Generic.IList<NotifierSecret> Secrets { get; set; }

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

    /// <summary>
    /// Details about how a build should be executed on a `WorkerPool`. See [running builds in a private
    /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
    /// </summary>
    public class PoolOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `WorkerPool` resource to execute the build on. You must have `cloudbuild.workerpools.use` on the project
        /// hosting the WorkerPool. Format projects/{project}/locations/{location}/workerPools/{workerPoolId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a V1 `PrivatePool`.</summary>
    public class PrivatePoolV1Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network configuration for the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Machine configuration for the workers in the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual WorkerConfig WorkerConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PubsubConfig describes the configuration of a trigger that creates a build whenever a Pub/Sub message is
    /// published.
    /// </summary>
    public class PubsubConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Service account that will make the push request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Name of the subscription. Format is `projects/{project}/subscriptions/{subscription}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>
        /// The name of the topic from which this subscription is receiving messages. Format is
        /// `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PullRequestFilter contains filter properties for matching GitHub Pull Requests.</summary>
    public class PullRequestFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex of branches to match. The syntax of the regular expressions accepted is the syntax accepted by RE2 and
        /// described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>
        /// Configure builds to run whether a repository owner or collaborator need to comment `/gcbrun`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commentControl")]
        public virtual string CommentControl { get; set; }

        /// <summary>If true, branches that do NOT match the git_ref will trigger a build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Push contains filter properties for matching GitHub git pushes.</summary>
    public class PushFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regexes matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>When true, only trigger a build if the revision regex does NOT match the git_ref regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// Regexes matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ReceiveTriggerWebhookResponse [Experimental] is the response object for the ReceiveTriggerWebhook method.
    /// </summary>
    public class ReceiveTriggerWebhookResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    public class RepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchName")]
        public virtual string BranchName { get; set; }

        /// <summary>Explicit commit SHA to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitSha")]
        public virtual string CommitSha { get; set; }

        /// <summary>
        /// Directory, relative to the source root, in which to run the build. This must be a relative path. If a step's
        /// `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the build is
        /// assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>Substitutions to use in a triggered build. Should only be used with RunBuildTrigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>
        /// Regex matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by the build pipeline.</summary>
    public class Results : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the artifact manifest. Only populated when artifacts are uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactManifest")]
        public virtual string ArtifactManifest { get; set; }

        /// <summary>Time to push all non-container artifacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactTiming")]
        public virtual TimeSpan ArtifactTiming { get; set; }

        /// <summary>List of build step digests, in the order corresponding to build step indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepImages")]
        public virtual System.Collections.Generic.IList<string> BuildStepImages { get; set; }

        /// <summary>
        /// List of build step outputs, produced by builder images, in the order corresponding to build step indices.
        /// [Cloud Builders](https://cloud.google.com/cloud-build/docs/cloud-builders) can produce this output by
        /// writing to `$BUILDER_OUTPUT/output`. Only the first 4KB of data is stored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepOutputs")]
        public virtual System.Collections.Generic.IList<string> BuildStepOutputs { get; set; }

        /// <summary>Container images that were built as a part of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<BuiltImage> Images { get; set; }

        /// <summary>Number of artifacts uploaded. Only populated when artifacts are uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numArtifacts")]
        public virtual System.Nullable<long> NumArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a build to retry.</summary>
    public class RetryBuildRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Build ID of the original build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The name of the `Build` to retry. Format: `projects/{project}/locations/{location}/builds/{build}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a build trigger to run and the source to use.</summary>
    public class RunBuildTriggerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Source to build against this trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual RepoSource Source { get; set; }

        /// <summary>Required. ID of the trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SMTPDelivery is the delivery configuration for an SMTP (email) notification.</summary>
    public class SMTPDelivery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is the SMTP account/email that appears in the `From:` of the email. If empty, it is assumed to be
        /// sender.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromAddress")]
        public virtual string FromAddress { get; set; }

        /// <summary>The SMTP sender's password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual NotifierSecretRef Password { get; set; }

        /// <summary>The SMTP port of the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual string Port { get; set; }

        /// <summary>
        /// This is the list of addresses to which we send the email (i.e. in the `To:` of the email).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipientAddresses")]
        public virtual System.Collections.Generic.IList<string> RecipientAddresses { get; set; }

        /// <summary>This is the SMTP account/email that is used to send the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("senderAddress")]
        public virtual string SenderAddress { get; set; }

        /// <summary>The address of the SMTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual string Server { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables containing encrypted values with the Cloud KMS key to use to decrypt
    /// the value. Note: Use `kmsKeyName` with `available_secrets` instead of using `kmsKeyName` with `secret`. For
    /// instructions see: https://cloud.google.com/cloud-build/docs/securing-builds/use-encrypted-credentials.
    /// </summary>
    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretEnv { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager.</summary>
    public class SecretManagerSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Environment variable name to associate with the secret. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual string Env { get; set; }

        /// <summary>Resource name of the SecretVersion. In format: projects/*/secrets/*/versions/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secrets and secret environment variables.</summary>
    public class Secrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Secrets encrypted with KMS key and the associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual System.Collections.Generic.IList<InlineSecret> Inline { get; set; }

        /// <summary>Secrets in Secret Manager and associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretManager")]
        public virtual System.Collections.Generic.IList<SecretManagerSecret> SecretManager { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SlackDelivery is the delivery configuration for delivering Slack messages via webhooks. See Slack webhook
    /// documentation at: https://api.slack.com/messaging/webhooks.
    /// </summary>
    public class SlackDelivery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The secret reference for the Slack webhook URI for sending messages to a channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookUri")]
        public virtual NotifierSecretRef WebhookUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a supported storage service.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual StorageSource StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Google Cloud Storage. This feature is in Preview; see
        /// description [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSourceManifest")]
        public virtual StorageSourceManifest StorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of the source. Ways to find the original source, or verify that some source was used for this build.
    /// </summary>
    public class SourceProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Hash(es) of the build source, which can be used to verify that the original source integrity
        /// was maintained in the build. Note that `FileHashes` will only be populated if `BuildOptions` has requested a
        /// `SourceProvenanceHash`. The keys to this map are file paths used as build source and the values contain the
        /// hash values for those files. If the build source came in a single package such as a gzipped tarfile
        /// (`.tar.gz`), the `FileHash` will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, FileHashes> FileHashes { get; set; }

        /// <summary>A copy of the build's `source.repo_source`, if exists, with any revisions resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedRepoSource")]
        public virtual RepoSource ResolvedRepoSource { get; set; }

        /// <summary>A copy of the build's `source.storage_source`, if exists, with any generations resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSource")]
        public virtual StorageSource ResolvedStorageSource { get; set; }

        /// <summary>
        /// A copy of the build's `source.storage_source_manifest`, if exists, with any revisions resolved. This feature
        /// is in Preview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSourceManifest")]
        public virtual StorageSourceManifest ResolvedStorageSourceManifest { get; set; }

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

    /// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
    public class StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Google Cloud Storage object containing the source. This object must be a zipped (`.zip`) or gzipped archive
        /// file (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location of the source manifest in Google Cloud Storage. This feature is in Preview; see description
    /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
    /// </summary>
    public class StorageSourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Storage bucket containing the source manifest (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Google Cloud Storage generation for the object. If the generation is omitted, the latest generation will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Google Cloud Storage object containing the source manifest. This object must be a JSON file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start and end times for a build execution phase.</summary>
    public class TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Start of time span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `UpdateWorkerPool` operation.</summary>
    public class UpdateWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual object CompleteTime { get; set; }

        /// <summary>Time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The resource name of the `WorkerPool` being updated. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volume describes a Docker container volume which is mounted into build steps in order to persist files across
    /// build step execution.
    /// </summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker
        /// volumes. Each named volume must be used by at least two build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the
        /// same build step or with certain reserved volume paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A non-fatal problem encountered during the execution of the build.</summary>
    public class Warning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The priority for this warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>Explanation of the warning generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WebhookConfig describes the configuration of a trigger that creates a build whenever a webhook is sent to a
    /// trigger's webhook URL.
    /// </summary>
    public class WebhookConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Resource name for the secret required as a URL parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>
        /// Potential issues with the underlying Pub/Sub subscription configuration. Only populated on get requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the configuration to be used for creating workers in the pool.</summary>
    public class WorkerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Size of the disk attached to the worker, in GB. See [Worker pool config
        /// file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). Specify a value of
        /// up to 1000. If `0` is specified, Cloud Build will use a standard disk size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Machine type of a worker, such as `e2-medium`. See [Worker pool config
        /// file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank,
        /// Cloud Build will use a sensible default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a `WorkerPool`. Cloud Build owns and maintains a pool of workers for general use and have no
    /// access to a project's private network. By default, builds submitted to Cloud Build will use a worker from this
    /// pool. If your build needs access to resources on a private network, create and use a `WorkerPool` to run your
    /// builds. Private `WorkerPool`s give your builds access to any single VPC network that you administer, including
    /// any on-prem resources connected to that VPC network. For an overview of private pools, see [Private pools
    /// overview](https://cloud.google.com/build/docs/private-pools/private-pools-overview).
    /// </summary>
    public class WorkerPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User specified annotations. See https://google.aip.dev/128#annotations for more details such as format and
        /// size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Time at which the request to create the `WorkerPool` was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Time at which the request to delete the `WorkerPool` was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// A user-specified, human-readable name for the `WorkerPool`. If provided, this value must be 1-63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Checksum computed by the server. May be sent on update and delete requests to ensure that the
        /// client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The resource name of the `WorkerPool`, with format
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`. The value of `{worker_pool}` is
        /// provided by `worker_pool_id` in `CreateWorkerPool` request and the value of `{location}` is determined by
        /// the endpoint accessed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Private Pool using a v1 configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privatePoolV1Config")]
        public virtual PrivatePoolV1Config PrivatePoolV1Config { get; set; }

        /// <summary>Output only. `WorkerPool` state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A unique identifier for the `WorkerPool`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. Time at which the request to update the `WorkerPool` was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }
}
