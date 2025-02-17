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
            GithubDotComWebhook = new GithubDotComWebhookResource(this);
            Locations = new LocationsResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            V1 = new V1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudbuild.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudbuild.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudbuild";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Build API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Build API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the GithubDotComWebhook resource.</summary>
        public virtual GithubDotComWebhookResource GithubDotComWebhook { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
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

    /// <summary>The "githubDotComWebhook" collection of methods.</summary>
    public class GithubDotComWebhookResource
    {
        private const string Resource = "githubDotComWebhook";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GithubDotComWebhookResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>ReceiveGitHubDotComWebhook is called when the API receives a github.com webhook.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ReceiveRequest Receive(Google.Apis.CloudBuild.v1.Data.HttpBody body)
        {
            return new ReceiveRequest(this.service, body);
        }

        /// <summary>ReceiveGitHubDotComWebhook is called when the API receives a github.com webhook.</summary>
        public class ReceiveRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
        {
            /// <summary>Constructs a new Receive request.</summary>
            public ReceiveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.HttpBody body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// For GitHub Enterprise webhooks, this key is used to associate the webhook request with the
            /// GitHubEnterpriseConfig to use for validation.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("webhookKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WebhookKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudBuild.v1.Data.HttpBody Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "receive";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/githubDotComWebhook:receive";

            /// <summary>Initializes Receive parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("webhookKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "webhookKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        }

        /// <summary>ReceiveRegionalWebhook is called when the API receives a regional GitHub webhook.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="location">Required. The location where the webhook should be sent.</param>
        public virtual RegionalWebhookRequest RegionalWebhook(Google.Apis.CloudBuild.v1.Data.HttpBody body, string location)
        {
            return new RegionalWebhookRequest(this.service, body, location);
        }

        /// <summary>ReceiveRegionalWebhook is called when the API receives a regional GitHub webhook.</summary>
        public class RegionalWebhookRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
        {
            /// <summary>Constructs a new RegionalWebhook request.</summary>
            public RegionalWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.HttpBody body, string location) : base(service)
            {
                Location = location;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The location where the webhook should be sent.</summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Location { get; private set; }

            /// <summary>
            /// For GitHub Enterprise webhooks, this key is used to associate the webhook request with the
            /// GitHubEnterpriseConfig to use for validation.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("webhookKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WebhookKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudBuild.v1.Data.HttpBody Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "regionalWebhook";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+location}/regionalWebhook";

            /// <summary>Initializes RegionalWebhook parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
                RequestParameters.Add("webhookKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "webhookKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(this.service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
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
            return new GetRequest(this.service, name);
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
            GithubEnterpriseConfigs = new GithubEnterpriseConfigsResource(service);
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

            /// <summary>
            /// Approves or rejects a pending build. If approved, the returned LRO will be analogous to the LRO returned
            /// from a CreateBuild call. If rejected, the returned LRO will be immediately done.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the target build. For example: "projects/{$project_id}/builds/{$build_id}"
            /// </param>
            public virtual ApproveRequest Approve(Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest body, string name)
            {
                return new ApproveRequest(this.service, body, name);
            }

            /// <summary>
            /// Approves or rejects a pending build. If approved, the returned LRO will be analogous to the LRO returned
            /// from a CreateBuild call. If rejected, the returned LRO will be immediately done.
            /// </summary>
            public class ApproveRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Approve request.</summary>
                public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the target build. For example: "projects/{$project_id}/builds/{$build_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "approve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:approve";

                /// <summary>Initializes Approve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/builds/[^/]+$",
                    });
                }
            }

            /// <summary>Cancels a build in progress.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="id">Required. ID of the build.</param>
            public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string projectId, string id)
            {
                return new CancelRequest(this.service, body, projectId, id);
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
                return new CreateRequest(this.service, body, projectId);
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
                return new GetRequest(this.service, projectId, id);
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
                return new ListRequest(this.service, projectId);
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
                /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/{location}`
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
            /// original build pulled source from Cloud Storage without specifying the generation of the object, the new
            /// build will use the current object, which may be different from the original build source. * If the
            /// original build pulled source from Cloud Storage and specified the generation of the object, the new
            /// build will attempt to use the same object, which may or may not be available depending on the bucket's
            /// lifecycle management settings.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="id">Required. Build ID of the original build.</param>
            public virtual RetryRequest Retry(Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string projectId, string id)
            {
                return new RetryRequest(this.service, body, projectId, id);
            }

            /// <summary>
            /// Creates a new build based on the specified build. This method creates a new build using the original
            /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
            /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build that
            /// uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original build
            /// built from the tip of a branch, the retried build will build from the tip of that branch, which may not
            /// be the same revision as the original build. * If the original build specified a commit sha or revision
            /// ID, the retried build will use the identical source. For builds that specify `StorageSource`: * If the
            /// original build pulled source from Cloud Storage without specifying the generation of the object, the new
            /// build will use the current object, which may be different from the original build source. * If the
            /// original build pulled source from Cloud Storage and specified the generation of the object, the new
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

        /// <summary>Gets the GithubEnterpriseConfigs resource.</summary>
        public virtual GithubEnterpriseConfigsResource GithubEnterpriseConfigs { get; }

        /// <summary>The "githubEnterpriseConfigs" collection of methods.</summary>
        public class GithubEnterpriseConfigsResource
        {
            private const string Resource = "githubEnterpriseConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GithubEnterpriseConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create an association between a GCP project and a GitHub Enterprise server.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create an association between a GCP project and a GitHub Enterprise server.</summary>
            public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The ID to use for the GithubEnterpriseConfig, which will become the final component of the
                /// GithubEnterpriseConfig's resource name. ghe_config_id must meet the following requirements: + They
                /// must contain only alphanumeric characters and dashes. + They can be 1-64 characters long. + They
                /// must begin and end with an alphanumeric character
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("gheConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GheConfigId { get; set; }

                /// <summary>ID of the project.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ProjectId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/githubEnterpriseConfigs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("gheConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "gheConfigId",
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

            /// <summary>Delete an association between a GCP project and a GitHub Enterprise server.</summary>
            /// <param name="name">
            /// This field should contain the name of the enterprise config resource. For example:
            /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete an association between a GCP project and a GitHub Enterprise server.</summary>
            public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// This field should contain the name of the enterprise config resource. For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Unique identifier of the `GitHubEnterpriseConfig`</summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>ID of the project</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ProjectId { get; set; }

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
                        Pattern = @"^projects/[^/]+/githubEnterpriseConfigs/[^/]+$",
                    });
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
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

            /// <summary>Retrieve a GitHubEnterpriseConfig.</summary>
            /// <param name="name">
            /// This field should contain the name of the enterprise config resource. For example:
            /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieve a GitHubEnterpriseConfig.</summary>
            public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// This field should contain the name of the enterprise config resource. For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Unique identifier of the `GitHubEnterpriseConfig`</summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>ID of the project</summary>
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
                        Pattern = @"^projects/[^/]+/githubEnterpriseConfigs/[^/]+$",
                    });
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
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

            /// <summary>List all GitHubEnterpriseConfigs for a given project.</summary>
            /// <param name="parent">
            /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List all GitHubEnterpriseConfigs for a given project.</summary>
            public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListGithubEnterpriseConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>ID of the project</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ProjectId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/githubEnterpriseConfigs";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Update an association between a GCP project and a GitHub Enterprise server.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The full resource name for the GitHubEnterpriseConfig For example:
            /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Update an association between a GCP project and a GitHub Enterprise server.</summary>
            public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The full resource name for the GitHubEnterpriseConfig For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Update mask for the resource. If this is set, the server will only update the fields specified in
                /// the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/githubEnterpriseConfigs/[^/]+$",
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
                BitbucketServerConfigs = new BitbucketServerConfigsResource(service);
                Builds = new BuildsResource(service);
                GitLabConfigs = new GitLabConfigsResource(service);
                GithubEnterpriseConfigs = new GithubEnterpriseConfigsResource(service);
                Operations = new OperationsResource(service);
                Triggers = new TriggersResource(service);
                WorkerPools = new WorkerPoolsResource(service);
            }

            /// <summary>Gets the BitbucketServerConfigs resource.</summary>
            public virtual BitbucketServerConfigsResource BitbucketServerConfigs { get; }

            /// <summary>The "bitbucketServerConfigs" collection of methods.</summary>
            public class BitbucketServerConfigsResource
            {
                private const string Resource = "bitbucketServerConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BitbucketServerConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ConnectedRepositories = new ConnectedRepositoriesResource(service);
                    Repos = new ReposResource(service);
                }

                /// <summary>Gets the ConnectedRepositories resource.</summary>
                public virtual ConnectedRepositoriesResource ConnectedRepositories { get; }

                /// <summary>The "connectedRepositories" collection of methods.</summary>
                public class ConnectedRepositoriesResource
                {
                    private const string Resource = "connectedRepositories";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectedRepositoriesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Batch connecting Bitbucket Server repositories to Cloud Build.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the `BitbucketServerConfig` that added connected repository. Format:
                    /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
                    /// </param>
                    public virtual BatchCreateRequest BatchCreate(Google.Apis.CloudBuild.v1.Data.BatchCreateBitbucketServerConnectedRepositoriesRequest body, string parent)
                    {
                        return new BatchCreateRequest(this.service, body, parent);
                    }

                    /// <summary>Batch connecting Bitbucket Server repositories to Cloud Build.</summary>
                    public class BatchCreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new BatchCreate request.</summary>
                        public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BatchCreateBitbucketServerConnectedRepositoriesRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the `BitbucketServerConfig` that added connected repository. Format:
                        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudBuild.v1.Data.BatchCreateBitbucketServerConnectedRepositoriesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchCreate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectedRepositories:batchCreate";

                        /// <summary>Initializes BatchCreate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Repos resource.</summary>
                public virtual ReposResource Repos { get; }

                /// <summary>The "repos" collection of methods.</summary>
                public class ReposResource
                {
                    private const string Resource = "repos";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReposResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// List all repositories for a given `BitbucketServerConfig`. This API is experimental.
                    /// </summary>
                    /// <param name="parent">Required. Name of the parent resource.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// List all repositories for a given `BitbucketServerConfig`. This API is experimental.
                    /// </summary>
                    public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBitbucketServerRepositoriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of configs to return. The service may return fewer than this value. The
                        /// maximum value is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListBitbucketServerRepositoriesRequest` call.
                        /// Provide this to retrieve the subsequent page. When paginating, all other parameters provided
                        /// to `ListBitbucketServerConfigsRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/repos";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
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

                /// <summary>Creates a new `BitbucketServerConfig`. This API is experimental.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Name of the parent resource.</param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `BitbucketServerConfig`. This API is experimental.</summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the BitbucketServerConfig, which will become the final component of
                    /// the BitbucketServerConfig's resource name. bitbucket_server_config_id must meet the following
                    /// requirements: + They must contain only alphanumeric characters and dashes. + They can be 1-64
                    /// characters long. + They must begin and end with an alphanumeric character.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bitbucketServerConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BitbucketServerConfigId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bitbucketServerConfigs";

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
                        RequestParameters.Add("bitbucketServerConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bitbucketServerConfigId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a `BitbucketServerConfig`. This API is experimental.</summary>
                /// <param name="name">Required. The config resource name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a `BitbucketServerConfig`. This API is experimental.</summary>
                public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The config resource name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve a `BitbucketServerConfig`. This API is experimental.</summary>
                /// <param name="name">Required. The config resource name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a `BitbucketServerConfig`. This API is experimental.</summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The config resource name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>List all `BitbucketServerConfigs` for a given project. This API is experimental.</summary>
                /// <param name="parent">Required. Name of the parent resource.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all `BitbucketServerConfigs` for a given project. This API is experimental.</summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListBitbucketServerConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of configs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 configs will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListBitbucketServerConfigsRequest` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListBitbucketServerConfigsRequest` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bitbucketServerConfigs";

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

                /// <summary>Updates an existing `BitbucketServerConfig`. This API is experimental.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The resource name for the config.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing `BitbucketServerConfig`. This API is experimental.</summary>
                public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The resource name for the config.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Update mask for the resource. If this is set, the server will only update the fields specified
                    /// in the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.BitbucketServerConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
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
                /// Remove a Bitbucket Server repository from a given BitbucketServerConfig's connected repositories.
                /// This API is experimental.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="config">
                /// Required. The name of the `BitbucketServerConfig` to remove a connected repository. Format:
                /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
                /// </param>
                public virtual RemoveBitbucketServerConnectedRepositoryRequest RemoveBitbucketServerConnectedRepository(Google.Apis.CloudBuild.v1.Data.RemoveBitbucketServerConnectedRepositoryRequest body, string config)
                {
                    return new RemoveBitbucketServerConnectedRepositoryRequest(this.service, body, config);
                }

                /// <summary>
                /// Remove a Bitbucket Server repository from a given BitbucketServerConfig's connected repositories.
                /// This API is experimental.
                /// </summary>
                public class RemoveBitbucketServerConnectedRepositoryRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
                {
                    /// <summary>Constructs a new RemoveBitbucketServerConnectedRepository request.</summary>
                    public RemoveBitbucketServerConnectedRepositoryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RemoveBitbucketServerConnectedRepositoryRequest body, string config) : base(service)
                    {
                        Config = config;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `BitbucketServerConfig` to remove a connected repository. Format:
                    /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("config", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Config { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.RemoveBitbucketServerConnectedRepositoryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeBitbucketServerConnectedRepository";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+config}:removeBitbucketServerConnectedRepository";

                    /// <summary>Initializes RemoveBitbucketServerConnectedRepository parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("config", new Google.Apis.Discovery.Parameter
                        {
                            Name = "config",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bitbucketServerConfigs/[^/]+$",
                        });
                    }
                }
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

                /// <summary>
                /// Approves or rejects a pending build. If approved, the returned LRO will be analogous to the LRO
                /// returned from a CreateBuild call. If rejected, the returned LRO will be immediately done.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the target build. For example: "projects/{$project_id}/builds/{$build_id}"
                /// </param>
                public virtual ApproveRequest Approve(Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest body, string name)
                {
                    return new ApproveRequest(this.service, body, name);
                }

                /// <summary>
                /// Approves or rejects a pending build. If approved, the returned LRO will be analogous to the LRO
                /// returned from a CreateBuild call. If rejected, the returned LRO will be immediately done.
                /// </summary>
                public class ApproveRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Approve request.</summary>
                    public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the target build. For example: "projects/{$project_id}/builds/{$build_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.ApproveBuildRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "approve";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:approve";

                    /// <summary>Initializes Approve parameter list.</summary>
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

                /// <summary>Cancels a build in progress.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Build` to cancel. Format: `projects/{project}/locations/{location}/builds/{build}`
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelBuildRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
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
                    return new CreateRequest(this.service, body, parent);
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
                    return new GetRequest(this.service, name);
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
                /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
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
                    /// The parent of the collection of `Builds`. Format: `projects/{project}/locations/{location}`
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
                /// `StorageSource`: * If the original build pulled source from Cloud Storage without specifying the
                /// generation of the object, the new build will use the current object, which may be different from the
                /// original build source. * If the original build pulled source from Cloud Storage and specified the
                /// generation of the object, the new build will attempt to use the same object, which may or may not be
                /// available depending on the bucket's lifecycle management settings.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Build` to retry. Format: `projects/{project}/locations/{location}/builds/{build}`
                /// </param>
                public virtual RetryRequest Retry(Google.Apis.CloudBuild.v1.Data.RetryBuildRequest body, string name)
                {
                    return new RetryRequest(this.service, body, name);
                }

                /// <summary>
                /// Creates a new build based on the specified build. This method creates a new build using the original
                /// build request, which may or may not result in an identical build. For triggered builds: * Triggered
                /// builds resolve to a precise revision; therefore a retry of a triggered build will result in a build
                /// that uses the same revision. For non-triggered builds that specify `RepoSource`: * If the original
                /// build built from the tip of a branch, the retried build will build from the tip of that branch,
                /// which may not be the same revision as the original build. * If the original build specified a commit
                /// sha or revision ID, the retried build will use the identical source. For builds that specify
                /// `StorageSource`: * If the original build pulled source from Cloud Storage without specifying the
                /// generation of the object, the new build will use the current object, which may be different from the
                /// original build source. * If the original build pulled source from Cloud Storage and specified the
                /// generation of the object, the new build will attempt to use the same object, which may or may not be
                /// available depending on the bucket's lifecycle management settings.
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

            /// <summary>Gets the GitLabConfigs resource.</summary>
            public virtual GitLabConfigsResource GitLabConfigs { get; }

            /// <summary>The "gitLabConfigs" collection of methods.</summary>
            public class GitLabConfigsResource
            {
                private const string Resource = "gitLabConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GitLabConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ConnectedRepositories = new ConnectedRepositoriesResource(service);
                    Repos = new ReposResource(service);
                }

                /// <summary>Gets the ConnectedRepositories resource.</summary>
                public virtual ConnectedRepositoriesResource ConnectedRepositories { get; }

                /// <summary>The "connectedRepositories" collection of methods.</summary>
                public class ConnectedRepositoriesResource
                {
                    private const string Resource = "connectedRepositories";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectedRepositoriesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Batch connecting GitLab repositories to Cloud Build. This API is experimental.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the `GitLabConfig` that adds connected repositories. Format:
                    /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
                    /// </param>
                    public virtual BatchCreateRequest BatchCreate(Google.Apis.CloudBuild.v1.Data.BatchCreateGitLabConnectedRepositoriesRequest body, string parent)
                    {
                        return new BatchCreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Batch connecting GitLab repositories to Cloud Build. This API is experimental.
                    /// </summary>
                    public class BatchCreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new BatchCreate request.</summary>
                        public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.BatchCreateGitLabConnectedRepositoriesRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the `GitLabConfig` that adds connected repositories. Format:
                        /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudBuild.v1.Data.BatchCreateGitLabConnectedRepositoriesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchCreate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectedRepositories:batchCreate";

                        /// <summary>Initializes BatchCreate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Repos resource.</summary>
                public virtual ReposResource Repos { get; }

                /// <summary>The "repos" collection of methods.</summary>
                public class ReposResource
                {
                    private const string Resource = "repos";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReposResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List all repositories for a given `GitLabConfig`. This API is experimental</summary>
                    /// <param name="parent">Required. Name of the parent resource.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List all repositories for a given `GitLabConfig`. This API is experimental</summary>
                    public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListGitLabRepositoriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of repositories to return. The service may return fewer than this value.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous ListGitLabRepositoriesRequest` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListGitLabRepositoriesRequest` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/repos";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
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

                /// <summary>Creates a new `GitLabConfig`. This API is experimental</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Name of the parent resource.</param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.GitLabConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `GitLabConfig`. This API is experimental</summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitLabConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the GitLabConfig, which will become the final component of the
                    /// GitLabConfig’s resource name. gitlab_config_id must meet the following requirements: + They must
                    /// contain only alphanumeric characters and dashes. + They can be 1-64 characters long. + They must
                    /// begin and end with an alphanumeric character
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("gitlabConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GitlabConfigId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.GitLabConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/gitLabConfigs";

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
                        RequestParameters.Add("gitlabConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gitlabConfigId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a `GitLabConfig`. This API is experimental</summary>
                /// <param name="name">Required. The config resource name.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete a `GitLabConfig`. This API is experimental</summary>
                public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The config resource name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a `GitLabConfig`. This API is experimental</summary>
                /// <param name="name">Required. The config resource name.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieves a `GitLabConfig`. This API is experimental</summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.GitLabConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The config resource name.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>List all `GitLabConfigs` for a given project. This API is experimental</summary>
                /// <param name="parent">Required. Name of the parent resource</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all `GitLabConfigs` for a given project. This API is experimental</summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListGitLabConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the parent resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of configs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 configs will be returned. The maximum value is 1000;, values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous ‘ListGitlabConfigsRequest’ call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to
                    /// ‘ListGitlabConfigsRequest’ must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/gitLabConfigs";

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

                /// <summary>Updates an existing `GitLabConfig`. This API is experimental</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The resource name for the config.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.GitLabConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing `GitLabConfig`. This API is experimental</summary>
                public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitLabConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The resource name for the config.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Update mask for the resource. If this is set, the server will only update the fields specified
                    /// in the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.GitLabConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
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
                /// Remove a GitLab repository from a given GitLabConfig's connected repositories. This API is
                /// experimental.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="config">
                /// Required. The name of the `GitLabConfig` to remove a connected repository. Format:
                /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
                /// </param>
                public virtual RemoveGitLabConnectedRepositoryRequest RemoveGitLabConnectedRepository(Google.Apis.CloudBuild.v1.Data.RemoveGitLabConnectedRepositoryRequest body, string config)
                {
                    return new RemoveGitLabConnectedRepositoryRequest(this.service, body, config);
                }

                /// <summary>
                /// Remove a GitLab repository from a given GitLabConfig's connected repositories. This API is
                /// experimental.
                /// </summary>
                public class RemoveGitLabConnectedRepositoryRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
                {
                    /// <summary>Constructs a new RemoveGitLabConnectedRepository request.</summary>
                    public RemoveGitLabConnectedRepositoryRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.RemoveGitLabConnectedRepositoryRequest body, string config) : base(service)
                    {
                        Config = config;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `GitLabConfig` to remove a connected repository. Format:
                    /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("config", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Config { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.RemoveGitLabConnectedRepositoryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeGitLabConnectedRepository";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+config}:removeGitLabConnectedRepository";

                    /// <summary>Initializes RemoveGitLabConnectedRepository parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("config", new Google.Apis.Discovery.Parameter
                        {
                            Name = "config",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gitLabConfigs/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the GithubEnterpriseConfigs resource.</summary>
            public virtual GithubEnterpriseConfigsResource GithubEnterpriseConfigs { get; }

            /// <summary>The "githubEnterpriseConfigs" collection of methods.</summary>
            public class GithubEnterpriseConfigsResource
            {
                private const string Resource = "githubEnterpriseConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GithubEnterpriseConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create an association between a GCP project and a GitHub Enterprise server.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create an association between a GCP project and a GitHub Enterprise server.</summary>
                public class CreateRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the GithubEnterpriseConfig, which will become the final component of
                    /// the GithubEnterpriseConfig's resource name. ghe_config_id must meet the following requirements:
                    /// + They must contain only alphanumeric characters and dashes. + They can be 1-64 characters long.
                    /// + They must begin and end with an alphanumeric character
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("gheConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GheConfigId { get; set; }

                    /// <summary>ID of the project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/githubEnterpriseConfigs";

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
                        RequestParameters.Add("gheConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gheConfigId",
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

                /// <summary>Delete an association between a GCP project and a GitHub Enterprise server.</summary>
                /// <param name="name">
                /// This field should contain the name of the enterprise config resource. For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete an association between a GCP project and a GitHub Enterprise server.</summary>
                public class DeleteRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// This field should contain the name of the enterprise config resource. For example:
                    /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Unique identifier of the `GitHubEnterpriseConfig`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConfigId { get; set; }

                    /// <summary>ID of the project</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/githubEnterpriseConfigs/[^/]+$",
                        });
                        RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "configId",
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

                /// <summary>Retrieve a GitHubEnterpriseConfig.</summary>
                /// <param name="name">
                /// This field should contain the name of the enterprise config resource. For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve a GitHubEnterpriseConfig.</summary>
                public class GetRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// This field should contain the name of the enterprise config resource. For example:
                    /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Unique identifier of the `GitHubEnterpriseConfig`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConfigId { get; set; }

                    /// <summary>ID of the project</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/githubEnterpriseConfigs/[^/]+$",
                        });
                        RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "configId",
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

                /// <summary>List all GitHubEnterpriseConfigs for a given project.</summary>
                /// <param name="parent">
                /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all GitHubEnterpriseConfigs for a given project.</summary>
                public class ListRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.ListGithubEnterpriseConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the parent project. For example: projects/{$project_number} or projects/{$project_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>ID of the project</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/githubEnterpriseConfigs";

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

                /// <summary>Update an association between a GCP project and a GitHub Enterprise server.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The full resource name for the GitHubEnterpriseConfig For example:
                /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update an association between a GCP project and a GitHub Enterprise server.</summary>
                public class PatchRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The full resource name for the GitHubEnterpriseConfig For example:
                    /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Update mask for the resource. If this is set, the server will only update the fields specified
                    /// in the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudBuild.v1.Data.GitHubEnterpriseConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/githubEnterpriseConfigs/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudBuild.v1.Data.CancelOperationRequest body, string name)
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
                    return new GetRequest(this.service, name);
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

                /// <summary>Creates a new `BuildTrigger`.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent resource where this trigger will be created. Format:
                /// `projects/{project}/locations/{location}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new `BuildTrigger`.</summary>
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

                /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID.</summary>
                /// <param name="name">
                /// The name of the `Trigger` to delete. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID.</summary>
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

                /// <summary>Returns information about a `BuildTrigger`.</summary>
                /// <param name="name">
                /// The name of the `Trigger` to retrieve. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns information about a `BuildTrigger`.</summary>
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

                /// <summary>Lists existing `BuildTrigger`s.</summary>
                /// <param name="parent">
                /// The parent of the collection of `Triggers`. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists existing `BuildTrigger`s.</summary>
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

                /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resourceName">
                /// The `Trigger` name with format: `projects/{project}/locations/{location}/triggers/{trigger}`, where
                /// {trigger} is a unique identifier generated by the service.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string resourceName)
                {
                    return new PatchRequest(this.service, body, resourceName);
                }

                /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID.</summary>
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

                    /// <summary>
                    /// Update mask for the resource. If this is set, the server will only update the fields specified
                    /// in the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

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
                /// Runs a `BuildTrigger` at a particular source revision. To run a regional or global trigger, use the
                /// POST request that includes the location endpoint in the path (ex.
                /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The POST request that does not
                /// include the location endpoint in the path can only be used when running global triggers.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the `Trigger` to run. Format:
                /// `projects/{project}/locations/{location}/triggers/{trigger}`
                /// </param>
                public virtual RunRequest Run(Google.Apis.CloudBuild.v1.Data.RunBuildTriggerRequest body, string name)
                {
                    return new RunRequest(this.service, body, name);
                }

                /// <summary>
                /// Runs a `BuildTrigger` at a particular source revision. To run a regional or global trigger, use the
                /// POST request that includes the location endpoint in the path (ex.
                /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The POST request that does not
                /// include the location endpoint in the path can only be used when running global triggers.
                /// </summary>
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
                    return new WebhookRequest(this.service, body, name);
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
                    return new CreateRequest(this.service, body, parent);
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
                /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
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
                    /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
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
                    /// Optional. If provided, it must match the server's etag on the workerpool for the request to be
                    /// processed.
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
                    return new GetRequest(this.service, name);
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
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
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
                    /// `projects/{project}/locations/{location}`.
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
                    return new PatchRequest(this.service, body, name);
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

                    /// <summary>Optional. A mask specifying which fields in `worker_pool` to update.</summary>
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

            /// <summary>Returns the `DefaultServiceAccount` used by the project.</summary>
            /// <param name="name">
            /// Required. The name of the `DefaultServiceAccount` to retrieve. Format:
            /// `projects/{project}/locations/{location}/defaultServiceAccount`
            /// </param>
            public virtual GetDefaultServiceAccountRequest GetDefaultServiceAccount(string name)
            {
                return new GetDefaultServiceAccountRequest(this.service, name);
            }

            /// <summary>Returns the `DefaultServiceAccount` used by the project.</summary>
            public class GetDefaultServiceAccountRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.DefaultServiceAccount>
            {
                /// <summary>Constructs a new GetDefaultServiceAccount request.</summary>
                public GetDefaultServiceAccountRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the `DefaultServiceAccount` to retrieve. Format:
                /// `projects/{project}/locations/{location}/defaultServiceAccount`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getDefaultServiceAccount";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetDefaultServiceAccount parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/defaultServiceAccount$",
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

            /// <summary>Creates a new `BuildTrigger`.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project for which to configure automatic builds.</param>
            public virtual CreateRequest Create(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId)
            {
                return new CreateRequest(this.service, body, projectId);
            }

            /// <summary>Creates a new `BuildTrigger`.</summary>
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

            /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID.</summary>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. ID of the `BuildTrigger` to delete.</param>
            public virtual DeleteRequest Delete(string projectId, string triggerId)
            {
                return new DeleteRequest(this.service, projectId, triggerId);
            }

            /// <summary>Deletes a `BuildTrigger` by its project ID and trigger ID.</summary>
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

            /// <summary>Returns information about a `BuildTrigger`.</summary>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.</param>
            public virtual GetRequest Get(string projectId, string triggerId)
            {
                return new GetRequest(this.service, projectId, triggerId);
            }

            /// <summary>Returns information about a `BuildTrigger`.</summary>
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

            /// <summary>Lists existing `BuildTrigger`s.</summary>
            /// <param name="projectId">Required. ID of the project for which to list BuildTriggers.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(this.service, projectId);
            }

            /// <summary>Lists existing `BuildTrigger`s.</summary>
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

            /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project that owns the trigger.</param>
            /// <param name="triggerId">Required. ID of the `BuildTrigger` to update.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudBuild.v1.Data.BuildTrigger body, string projectId, string triggerId)
            {
                return new PatchRequest(this.service, body, projectId, triggerId);
            }

            /// <summary>Updates a `BuildTrigger` by its project ID and trigger ID.</summary>
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

                /// <summary>
                /// Update mask for the resource. If this is set, the server will only update the fields specified in
                /// the field mask. Otherwise, a full update of the mutable resource fields will be performed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

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
            /// Runs a `BuildTrigger` at a particular source revision. To run a regional or global trigger, use the POST
            /// request that includes the location endpoint in the path (ex.
            /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The POST request that does not
            /// include the location endpoint in the path can only be used when running global triggers.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. ID of the project.</param>
            /// <param name="triggerId">Required. ID of the trigger.</param>
            public virtual RunRequest Run(Google.Apis.CloudBuild.v1.Data.RepoSource body, string projectId, string triggerId)
            {
                return new RunRequest(this.service, body, projectId, triggerId);
            }

            /// <summary>
            /// Runs a `BuildTrigger` at a particular source revision. To run a regional or global trigger, use the POST
            /// request that includes the location endpoint in the path (ex.
            /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The POST request that does not
            /// include the location endpoint in the path can only be used when running global triggers.
            /// </summary>
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
                return new WebhookRequest(this.service, body, projectId, trigger);
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

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>ReceiveWebhook is called when the API receives a GitHub webhook.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual WebhookRequest Webhook(Google.Apis.CloudBuild.v1.Data.HttpBody body)
        {
            return new WebhookRequest(this.service, body);
        }

        /// <summary>ReceiveWebhook is called when the API receives a GitHub webhook.</summary>
        public class WebhookRequest : CloudBuildBaseServiceRequest<Google.Apis.CloudBuild.v1.Data.Empty>
        {
            /// <summary>Constructs a new Webhook request.</summary>
            public WebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudBuild.v1.Data.HttpBody body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// For GitHub Enterprise webhooks, this key is used to associate the webhook request with the
            /// GitHubEnterpriseConfig to use for validation.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("webhookKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WebhookKey { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudBuild.v1.Data.HttpBody Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "webhook";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/webhook";

            /// <summary>Initializes Webhook parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("webhookKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "webhookKey",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudBuild.v1.Data
{
    /// <summary>ApprovalConfig describes configuration for manual approval of a build.</summary>
    public class ApprovalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not approval is needed. If this is set on a build, it will become pending when created, and will
        /// need to be explicitly approved to start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalRequired")]
        public virtual System.Nullable<bool> ApprovalRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ApprovalResult describes the decision and associated metadata of a manual approval of a build.
    /// </summary>
    public class ApprovalResult : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _approvalTimeRaw;

        private object _approvalTime;

        /// <summary>Output only. The time when the approval decision was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalTime")]
        public virtual string ApprovalTimeRaw
        {
            get => _approvalTimeRaw;
            set
            {
                _approvalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _approvalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApprovalTimeDateTimeOffset instead.")]
        public virtual object ApprovalTime
        {
            get => _approvalTime;
            set
            {
                _approvalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _approvalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApprovalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApprovalTimeRaw);
            set => ApprovalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Email of the user that called the ApproveBuild API to approve or reject a build at the time
        /// that the API was called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approverAccount")]
        public virtual string ApproverAccount { get; set; }

        /// <summary>Optional. An optional comment for this manual approval result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Required. The decision of this manual approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decision")]
        public virtual string Decision { get; set; }

        /// <summary>
        /// Optional. An optional URL tied to this manual approval result. This field is essentially the same as
        /// comment, except that it will be rendered by the UI differently. An example use case is a link to an external
        /// job that approved this Build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to approve or reject a pending build.</summary>
    public class ApproveBuildRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Approval decision and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalResult")]
        public virtual ApprovalResult ApprovalResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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
        /// The path of an artifact in a Cloud Storage bucket, with the generation number. For example,
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
        /// Optional. A list of Go modules to be uploaded to Artifact Registry upon successful completion of all build
        /// steps. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<GoModule> GoModules { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images will be pushed
        /// using the builder service account's credentials. The digests of the pushed images will be stored in the
        /// Build resource's results field. If any of the images fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// A list of Maven artifacts to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Artifacts in the workspace matching specified paths globs will be uploaded to the specified Artifact
        /// Registry repository using the builder service account's credentials. If any artifacts fail to be pushed, the
        /// build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<MavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// A list of npm packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Npm packages in the specified paths will be uploaded to the specified Artifact Registry repository using the
        /// builder service account's credentials. If any packages fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<NpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in
        /// the workspace matching specified paths globs will be uploaded to the specified Cloud Storage location using
        /// the builder service account's credentials. The location and generation of the uploaded objects will be
        /// stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual ArtifactObjects Objects { get; set; }

        /// <summary>
        /// A list of Python packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// The build service account credentials will be used to perform the upload. If any objects fail to be pushed,
        /// the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<PythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by BatchCreateBitbucketServerConnectedRepositories RPC method.</summary>
    public class BatchCreateBitbucketServerConnectedRepositoriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Requests to connect Bitbucket Server repositories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreateBitbucketServerConnectedRepositoryRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response of BatchCreateBitbucketServerConnectedRepositories RPC method including all successfully connected
    /// Bitbucket Server repositories.
    /// </summary>
    public class BatchCreateBitbucketServerConnectedRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The connected Bitbucket Server repositories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConnectedRepositories")]
        public virtual System.Collections.Generic.IList<BitbucketServerConnectedRepository> BitbucketServerConnectedRepositories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `BatchCreateBitbucketServerConnectedRepositories` operation.</summary>
    public class BatchCreateBitbucketServerConnectedRepositoriesResponseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of the `BitbucketServerConfig` that added connected repositories. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by BatchCreateGitLabConnectedRepositories RPC method.</summary>
    public class BatchCreateGitLabConnectedRepositoriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Requests to connect GitLab repositories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreateGitLabConnectedRepositoryRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of BatchCreateGitLabConnectedRepositories RPC method.</summary>
    public class BatchCreateGitLabConnectedRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The GitLab connected repository requests' responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConnectedRepositories")]
        public virtual System.Collections.Generic.IList<GitLabConnectedRepository> GitlabConnectedRepositories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `BatchCreateGitLabConnectedRepositories` operation.</summary>
    public class BatchCreateGitLabConnectedRepositoriesResponseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of the `GitLabConfig` that added connected repositories. Format:
        /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BitbucketServerConfig represents the configuration for a Bitbucket Server.</summary>
    public class BitbucketServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. API Key that will be attached to webhook. Once this field has been set, it cannot be
        /// changed. If you need to change it, please create another BitbucketServerConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKey")]
        public virtual string ApiKey { get; set; }

        /// <summary>Output only. Connected Bitbucket Server repositories for this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepositories")]
        public virtual System.Collections.Generic.IList<BitbucketServerRepositoryId> ConnectedRepositories { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time when the config was created.</summary>
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
        /// Required. Immutable. The URI of the Bitbucket Server host. Once this field has been set, it cannot be
        /// changed. If you need to change it, please create another BitbucketServerConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>The resource name for the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The network to be used when reaching out to the Bitbucket Server instance. The VPC network must be
        /// enabled for private service connection. This should be set if the Bitbucket Server instance is hosted
        /// on-premises and not reachable by public internet. If this field is left empty, no network peering will occur
        /// and calls to the Bitbucket Server instance will be made over the public internet. Must be in the format
        /// `projects/{project}/global/networks/{network}`, where {project} is a project number or id and {network} is
        /// the name of a VPC network in the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeredNetwork")]
        public virtual string PeeredNetwork { get; set; }

        /// <summary>
        /// Immutable. IP range within the peered network. This is specified in CIDR notation with a slash and the
        /// subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g.
        /// `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a 29 bit prefix size. `/16` would
        /// specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified,
        /// a value of `/24` will be used. The field only has an effect if peered_network is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeredNetworkIpRange")]
        public virtual string PeeredNetworkIpRange { get; set; }

        /// <summary>Required. Secret Manager secrets needed by the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual BitbucketServerSecrets Secrets { get; set; }

        /// <summary>
        /// Optional. SSL certificate to use for requests to Bitbucket Server. The format should be PEM format but the
        /// extension can be one of .pem, .cer, or .crt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCa")]
        public virtual string SslCa { get; set; }

        /// <summary>Username of the account Cloud Build will use on Bitbucket Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookKey")]
        public virtual string WebhookKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>/ BitbucketServerConnectedRepository represents a connected Bitbucket Server / repository.</summary>
    public class BitbucketServerConnectedRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the `BitbucketServerConfig` that added connected repository. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The Bitbucket Server repositories to connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repo")]
        public virtual BitbucketServerRepositoryId Repo { get; set; }

        /// <summary>Output only. The status of the repo connection request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BitbucketServerRepository represents a repository hosted on a Bitbucket Server.</summary>
    public class BitbucketServerRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to the browse repo page on the Bitbucket Server instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browseUri")]
        public virtual string BrowseUri { get; set; }

        /// <summary>Description of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Identifier for a repository hosted on a Bitbucket Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual BitbucketServerRepositoryId RepoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BitbucketServerRepositoryId identifies a specific repository hosted on a Bitbucket Server.</summary>
    public class BitbucketServerRepositoryId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Identifier for the project storing the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectKey")]
        public virtual string ProjectKey { get; set; }

        /// <summary>Required. Identifier for the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSlug")]
        public virtual string RepoSlug { get; set; }

        /// <summary>
        /// Output only. The ID of the webhook that was created for receiving events from this repo. We only create and
        /// manage a single webhook for each repo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookId")]
        public virtual System.Nullable<int> WebhookId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BitbucketServerSecrets represents the secrets in Secret Manager for a Bitbucket Server.</summary>
    public class BitbucketServerSecrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name for the admin access token's secret version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminAccessTokenVersionName")]
        public virtual string AdminAccessTokenVersionName { get; set; }

        /// <summary>Required. The resource name for the read access token's secret version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAccessTokenVersionName")]
        public virtual string ReadAccessTokenVersionName { get; set; }

        /// <summary>
        /// Required. Immutable. The resource name for the webhook secret's secret version. Once this field has been
        /// set, it cannot be changed. If you need to change it, please create another BitbucketServerConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretVersionName")]
        public virtual string WebhookSecretVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a Bitbucket
    /// Server event is received.
    /// </summary>
    public class BitbucketServerTriggerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The BitbucketServerConfig specified in the bitbucket_server_config_resource field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual BitbucketServerConfig BitbucketServerConfig { get; set; }

        /// <summary>Required. The Bitbucket server config resource that this trigger config maps to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfigResource")]
        public virtual string BitbucketServerConfigResource { get; set; }

        /// <summary>
        /// Required. Key of the project that the repo is in. For example: The key for
        /// https://mybitbucket.server/projects/TEST/repos/test-repo is "TEST".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectKey")]
        public virtual string ProjectKey { get; set; }

        /// <summary>Filter to match changes in pull requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullRequest")]
        public virtual PullRequestFilter PullRequest { get; set; }

        /// <summary>Filter to match changes in refs like branches, tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("push")]
        public virtual PushFilter Push { get; set; }

        /// <summary>
        /// Required. Slug of the repository. A repository slug is a URL-friendly version of a repository name,
        /// automatically generated by Bitbucket for use in the URL. For example, if the repository name is 'test repo',
        /// in the URL it would become 'test-repo' as in https://mybitbucket.server/projects/TEST/repos/test-repo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSlug")]
        public virtual string RepoSlug { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A build resource in the Cloud Build API. At a high level, a `Build` describes where to find source code, how to
    /// build it (for example, the builder image to run on the source), and where to store the built artifacts. Fields
    /// can include the following variables, which will be expanded when the build is created: - $PROJECT_ID: the
    /// project ID of the build. - $PROJECT_NUMBER: the project number of the build. - $LOCATION: the location/region of
    /// the build. - $BUILD_ID: the autogenerated ID of the build. - $REPO_NAME: the source repository name specified by
    /// RepoSource. - $BRANCH_NAME: the branch name specified by RepoSource. - $TAG_NAME: the tag name specified by
    /// RepoSource. - $REVISION_ID or $COMMIT_SHA: the commit SHA specified by RepoSource or resolved from the specified
    /// branch or tag. - $SHORT_SHA: first 7 characters of $REVISION_ID or $COMMIT_SHA.
    /// </summary>
    public class Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Describes this build's approval configuration, status, and result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approval")]
        public virtual BuildApproval Approval { get; set; }

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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the request to create the build was received.</summary>
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
        /// Optional. Dependencies that the Cloud Build worker will fetch before executing user steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<Dependency> Dependencies { get; set; }

        /// <summary>Output only. Contains information about the build when status=FAILURE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureInfo")]
        public virtual FailureInfo FailureInfo { get; set; }

        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>
        /// Output only. Time at which execution of the build was finished. The difference between finish_time and
        /// start_time is the duration of the build's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Configuration for git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitConfig")]
        public virtual GitConfig GitConfig { get; set; }

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
        /// Cloud Storage bucket where logs should be written (see [Bucket Name
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

        /// <summary>Optional. The location of the source files to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual SourceProvenance SourceProvenance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Time at which execution of the build was started.</summary>
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
        /// `startTime`. Default time is 60 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all
        /// build steps. * PUSH: time to push all artifacts including docker images and non docker artifacts. *
        /// FETCHSOURCE: time to fetch source. * SETUPBUILD: time to set up build. If the build does not specify source
        /// or images, these keys will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual System.Collections.Generic.IDictionary<string, TimeSpan> Timing { get; set; }

        /// <summary>Output only. Non-fatal problems encountered during the execution of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BuildApproval describes a build's approval configuration, state, and result.</summary>
    public class BuildApproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configuration for manual approval of this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ApprovalConfig Config { get; set; }

        /// <summary>Output only. Result of manual approval for this Build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual ApprovalResult Result { get; set; }

        /// <summary>Output only. The state of this build's approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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
        /// <summary>Option to include built-in and custom substitutions as env variables for all build steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

        /// <summary>Optional. Option to specify how default logs buckets are setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLogsBucketBehavior")]
        public virtual string DefaultLogsBucketBehavior { get; set; }

        /// <summary>
        /// Requested disk size for the VM that runs the build. Note that this is *NOT* "disk free"; some of the space
        /// will be used by the operating system and build utilities. Also note that this is the minimum disk size that
        /// will be allocated for the build -- the build may run with a larger disk than requested. At present, the
        /// maximum disk size is 4000GB; builds that request more than the maximum are rejected with an error.
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
        /// Optional. Option to specify whether structured logging is enabled. If true, JSON-formatted logs are parsed
        /// as structured logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStructuredLogging")]
        public virtual System.Nullable<bool> EnableStructuredLogging { get; set; }

        /// <summary>
        /// A list of global environment variable definitions that will exist for all build steps in this build. If a
        /// variable is defined in both globally and in a build step, the variable will use the build step value. The
        /// elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Option to define build log streaming behavior to Cloud Storage.</summary>
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

        /// <summary>Optional. Option to specify the Pub/Sub topic to receive build status updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

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
        /// Allow this build step to fail without failing the entire build if and only if the exit code is one of the
        /// specified codes. If allow_failure is also specified, this field will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowExitCodes { get; set; }

        /// <summary>
        /// Allow this build step to fail without failing the entire build. If false, the entire build will fail if this
        /// step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error
        /// information will be reported in the failure_detail field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFailure")]
        public virtual System.Nullable<bool> AllowFailure { get; set; }

        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Option to include built-in and custom substitutions as env variables for this build step. This option will
        /// override the global option in BuildOption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

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

        /// <summary>Output only. Return code from running the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

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
        /// A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint
        /// or args.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

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
        /// <summary>Configuration for manual approval to start a build invocation of this BuildTrigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalConfig")]
        public virtual ApprovalConfig ApprovalConfig { get; set; }

        /// <summary>
        /// Autodetect build configuration. The following precedence is used (case insensitive): 1. cloudbuild.yaml 2.
        /// cloudbuild.yml 3. cloudbuild.json 4. Dockerfile Currently only available for GitHub App Triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autodetect")]
        public virtual System.Nullable<bool> Autodetect { get; set; }

        /// <summary>
        /// BitbucketServerTriggerConfig describes the configuration of a trigger that creates a build whenever a
        /// Bitbucket Server event is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerTriggerConfig")]
        public virtual BitbucketServerTriggerConfig BitbucketServerTriggerConfig { get; set; }

        /// <summary>Contents of the build template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual Build Build { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the trigger was created.</summary>
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

        /// <summary>Human-readable description of this trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>If true, the trigger will never automatically execute a build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// EventType allows the user to explicitly set the type of event to which this BuildTrigger should respond.
        /// This field will be validated against the rest of the configuration if it is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>Path, from the source root, to the build configuration file (i.e. cloudbuild.yaml).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>A Common Expression Language string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The file source describing the local or remote Build template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitFileSource")]
        public virtual GitFileSource GitFileSource { get; set; }

        /// <summary>
        /// GitHubEventsConfig describes the configuration of a trigger that creates a build whenever a GitHub event is
        /// received. Mutually exclusive with `trigger_template`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("github")]
        public virtual GitHubEventsConfig Github { get; set; }

        /// <summary>
        /// GitLabEnterpriseEventsConfig describes the configuration of a trigger that creates a build whenever a GitLab
        /// Enterprise event is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabEnterpriseEventsConfig")]
        public virtual GitLabEventsConfig GitlabEnterpriseEventsConfig { get; set; }

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
        /// If set to INCLUDE_BUILD_LOGS_WITH_STATUS, log url will be shown on GitHub page when build status is final.
        /// Setting this field to INCLUDE_BUILD_LOGS_WITH_STATUS for non GitHub triggers results in INVALID_ARGUMENT
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeBuildLogs")]
        public virtual string IncludeBuildLogs { get; set; }

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
        /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryEventConfig")]
        public virtual RepositoryEventConfig RepositoryEventConfig { get; set; }

        /// <summary>
        /// The `Trigger` name with format: `projects/{project}/locations/{location}/triggers/{trigger}`, where
        /// {trigger} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// The service account used for all user-controlled operations including UpdateBuildTrigger, RunBuildTrigger,
        /// CreateBuild, and CancelBuild. If no service account is set and the legacy Cloud Build service account
        /// ([PROJECT_NUM]@cloudbuild.gserviceaccount.com) is the default for the project then it will be used instead.
        /// Format: `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_ID_OR_EMAIL}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The repo and ref of the repository from which to build. This field is used only for those triggers that do
        /// not respond to SCM events. Triggers that respond to such events build source at whatever commit caused the
        /// event. This field is currently only used by Webhook, Pub/Sub, Manual, and Cron triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceToBuild")]
        public virtual GitRepoSource SourceToBuild { get; set; }

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

    /// <summary>Location of the source in a 2nd-gen Google Cloud Build repository resource.</summary>
    public class ConnectedRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. Name of the Google Cloud Build repository, formatted as
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `CreateBitbucketServerConfig` operation.</summary>
    public class CreateBitbucketServerConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the BitbucketServerConfig to be created. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual string BitbucketServerConfig { get; set; }

        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to connect a repository from a connected Bitbucket Server host.</summary>
    public class CreateBitbucketServerConnectedRepositoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Bitbucket Server repository to connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConnectedRepository")]
        public virtual BitbucketServerConnectedRepository BitbucketServerConnectedRepository { get; set; }

        /// <summary>
        /// Required. The name of the `BitbucketServerConfig` that added connected repository. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `CreateGithubEnterpriseConfig` operation.</summary>
    public class CreateGitHubEnterpriseConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitHubEnterprise to be created. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `CreateGitLabConfig` operation.</summary>
    public class CreateGitLabConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitLabConfig to be created. Format:
        /// `projects/{project}/locations/{location}/gitlabConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfig")]
        public virtual string GitlabConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to connect a repository from a connected GitLab host.</summary>
    public class CreateGitLabConnectedRepositoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The GitLab repository to connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConnectedRepository")]
        public virtual GitLabConnectedRepository GitlabConnectedRepository { get; set; }

        /// <summary>
        /// Required. The name of the `GitLabConfig` that adds connected repository. Format:
        /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `CreateWorkerPool` operation.</summary>
    public class CreateWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the `WorkerPool` to create. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The default service account used for `Builds`.</summary>
    public class DefaultServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier. Format: `projects/{project}/locations/{location}/defaultServiceAccount</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The email address of the service account identity that will be used for a build by default.
        /// This is returned in the format `projects/{project}/serviceAccounts/{service_account}` where
        /// `{service_account}` could be the legacy Cloud Build SA, in the format
        /// [PROJECT_NUMBER]@cloudbuild.gserviceaccount.com or the Compute SA, in the format
        /// [PROJECT_NUMBER]-compute@developer.gserviceaccount.com. If no service account will be used by default, this
        /// will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `DeleteBitbucketServerConfig` operation.</summary>
    public class DeleteBitbucketServerConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the BitbucketServerConfig to be deleted. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual string BitbucketServerConfig { get; set; }

        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `DeleteGitHubEnterpriseConfig` operation.</summary>
    public class DeleteGitHubEnterpriseConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitHubEnterprise to be deleted. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `DeleteGitLabConfig` operation.</summary>
    public class DeleteGitLabConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitLabConfig to be created. Format:
        /// `projects/{project}/locations/{location}/gitlabConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfig")]
        public virtual string GitlabConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `DeleteWorkerPool` operation.</summary>
    public class DeleteWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the `WorkerPool` being deleted. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dependency that the Cloud Build worker will fetch before executing user steps.</summary>
    public class Dependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to true disable all dependency fetching (ignoring the default source as well).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("empty")]
        public virtual System.Nullable<bool> Empty { get; set; }

        /// <summary>Represents a git repository as a build dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GitSourceDependency GitSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This config defines the location of a source through Developer Connect.</summary>
    public class DeveloperConnectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. The Developer Connect Git repository link, formatted as
        /// `projects/*/locations/*/connections/*/gitRepositoryLink/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitRepositoryLink")]
        public virtual string GitRepositoryLink { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

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

    /// <summary>A fatal problem encountered during the execution of the build.</summary>
    public class FailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explains the failure issue in more detail using hard-coded text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The name of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>GitConfig is a configuration for git operations.</summary>
    public class GitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for HTTP related git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("http")]
        public virtual HttpConfig Http { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitFileSource describes a file within a (possibly remote) code repository.</summary>
    public class GitFileSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of the bitbucket server config. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual string BitbucketServerConfig { get; set; }

        /// <summary>
        /// The full resource name of the github enterprise config. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// `projects/{project}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

        /// <summary>The path of the file, with the repo root as the root of the path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>See RepoType above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoType")]
        public virtual string RepoType { get; set; }

        /// <summary>
        /// The fully qualified resource name of the Repos API repository. Either URI or repository can be specified. If
        /// unspecified, the repo from which the trigger invocation originated is assumed to be the repo from which to
        /// read the specified path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// The branch, tag, arbitrary ref, or SHA version of the repo to use when resolving the filename (optional).
        /// This field respects the same syntax/resolution as described here: https://git-scm.com/docs/gitrevisions If
        /// unspecified, the revision from which the trigger invocation originated is assumed to be the revision from
        /// which to read the specified path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// The URI of the repo. Either uri or repository can be specified. If unspecified, the repo from which the
        /// trigger invocation originated is assumed to be the repo from which to read the specified path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitHubEnterpriseConfig represents a configuration for a GitHub Enterprise server.</summary>
    public class GitHubEnterpriseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The GitHub app id of the Cloud Build app on the GitHub Enterprise server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual System.Nullable<long> AppId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the installation was associated with the project.</summary>
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

        /// <summary>Optional. Name to display for this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The URL of the github enterprise host the configuration is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUrl")]
        public virtual string HostUrl { get; set; }

        /// <summary>
        /// The full resource name for the GitHubEnterpriseConfig For example:
        /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The network to be used when reaching out to the GitHub Enterprise server. The VPC network must be
        /// enabled for private service connection. This should be set if the GitHub Enterprise server is hosted
        /// on-premises and not reachable by public internet. If this field is left empty, no network peering will occur
        /// and calls to the GitHub Enterprise server will be made over the public internet. Must be in the format
        /// `projects/{project}/global/networks/{network}`, where {project} is a project number or id and {network} is
        /// the name of a VPC network in the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeredNetwork")]
        public virtual string PeeredNetwork { get; set; }

        /// <summary>Optional. Names of secrets in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual GitHubEnterpriseSecrets Secrets { get; set; }

        /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCa")]
        public virtual string SslCa { get; set; }

        /// <summary>The key that should be attached to webhook calls to the ReceiveWebhook endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookKey")]
        public virtual string WebhookKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GitHubEnterpriseSecrets represents the names of all necessary secrets in Secret Manager for a GitHub Enterprise
    /// server. Format is: projects//secrets/.
    /// </summary>
    public class GitHubEnterpriseSecrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name for the OAuth client ID secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthClientIdName")]
        public virtual string OauthClientIdName { get; set; }

        /// <summary>The resource name for the OAuth client ID secret version in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthClientIdVersionName")]
        public virtual string OauthClientIdVersionName { get; set; }

        /// <summary>The resource name for the OAuth secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthSecretName")]
        public virtual string OauthSecretName { get; set; }

        /// <summary>The resource name for the OAuth secret secret version in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthSecretVersionName")]
        public virtual string OauthSecretVersionName { get; set; }

        /// <summary>The resource name for the private key secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyName")]
        public virtual string PrivateKeyName { get; set; }

        /// <summary>The resource name for the private key secret version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyVersionName")]
        public virtual string PrivateKeyVersionName { get; set; }

        /// <summary>The resource name for the webhook secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretName")]
        public virtual string WebhookSecretName { get; set; }

        /// <summary>The resource name for the webhook secret secret version in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretVersionName")]
        public virtual string WebhookSecretVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GitHubEventsConfig describes the configuration of a trigger that creates a build whenever a GitHub event is
    /// received.
    /// </summary>
    public class GitHubEventsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the github enterprise config that should be applied to this installation. For example:
        /// "projects/{$project_id}/locations/{$location_id}/githubEnterpriseConfigs/{$config_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseConfigResourceName")]
        public virtual string EnterpriseConfigResourceName { get; set; }

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

    /// <summary>GitLabConfig represents the configuration for a GitLab integration.</summary>
    public class GitLabConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connected GitLab.com or GitLabEnterprise repositories for this config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepositories")]
        public virtual System.Collections.Generic.IList<GitLabRepositoryId> ConnectedRepositories { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the config was created.</summary>
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

        /// <summary>Optional. GitLabEnterprise config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseConfig")]
        public virtual GitLabEnterpriseConfig EnterpriseConfig { get; set; }

        /// <summary>The resource name for the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Secret Manager secrets needed by the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual GitLabSecrets Secrets { get; set; }

        /// <summary>Username of the GitLab.com or GitLab Enterprise account Cloud Build will use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>
        /// Output only. UUID included in webhook requests. The UUID is used to look up the corresponding config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookKey")]
        public virtual string WebhookKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitLabConnectedRepository represents a GitLab connected repository request response.</summary>
    public class GitLabConnectedRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the `GitLabConfig` that added connected repository. Format:
        /// `projects/{project}/locations/{location}/gitLabConfigs/{config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The GitLab repositories to connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repo")]
        public virtual GitLabRepositoryId Repo { get; set; }

        /// <summary>Output only. The status of the repo connection request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitLabEnterpriseConfig represents the configuration for a GitLabEnterprise integration.</summary>
    public class GitLabEnterpriseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. The URI of the GitlabEnterprise host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>
        /// The Service Directory configuration to be used when reaching out to the GitLab Enterprise instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>The SSL certificate to use in requests to GitLab Enterprise instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCa")]
        public virtual string SslCa { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GitLabEventsConfig describes the configuration of a trigger that creates a build whenever a GitLab event is
    /// received.
    /// </summary>
    public class GitLabEventsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The GitLabConfig specified in the gitlab_config_resource field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfig")]
        public virtual GitLabConfig GitlabConfig { get; set; }

        /// <summary>The GitLab config resource that this trigger config maps to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfigResource")]
        public virtual string GitlabConfigResource { get; set; }

        /// <summary>Namespace of the GitLab project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNamespace")]
        public virtual string ProjectNamespace { get; set; }

        /// <summary>Filter to match changes in pull requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullRequest")]
        public virtual PullRequestFilter PullRequest { get; set; }

        /// <summary>Filter to match changes in refs like branches, tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("push")]
        public virtual PushFilter Push { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto Representing a GitLabRepository</summary>
    public class GitLabRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to the browse repo page on the GitLab instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browseUri")]
        public virtual string BrowseUri { get; set; }

        /// <summary>Description of the repository</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name of the repository</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the repository</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Identifier for a repository</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryId")]
        public virtual GitLabRepositoryId RepositoryId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitLabRepositoryId identifies a specific repository hosted on GitLab.com or GitLabEnterprise</summary>
    public class GitLabRepositoryId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Identifier for the repository. example: "namespace/project-slug", namespace is usually the
        /// username or group ID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The ID of the webhook that was created for receiving events from this repo. We only create and
        /// manage a single webhook for each repo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookId")]
        public virtual System.Nullable<int> WebhookId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitLabSecrets represents the secrets in Secret Manager for a GitLab integration.</summary>
    public class GitLabSecrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name for the api access token’s secret version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAccessTokenVersion")]
        public virtual string ApiAccessTokenVersion { get; set; }

        /// <summary>
        /// Required. Immutable. API Key that will be attached to webhook requests from GitLab to Cloud Build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyVersion")]
        public virtual string ApiKeyVersion { get; set; }

        /// <summary>Required. The resource name for the read access token’s secret version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAccessTokenVersion")]
        public virtual string ReadAccessTokenVersion { get; set; }

        /// <summary>
        /// Required. Immutable. The resource name for the webhook secret’s secret version. Once this field has been
        /// set, it cannot be changed. If you need to change it, please create another GitLabConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretVersion")]
        public virtual string WebhookSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitRepoSource describes a repo and ref of a code repository.</summary>
    public class GitRepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of the bitbucket server config. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual string BitbucketServerConfig { get; set; }

        /// <summary>
        /// The full resource name of the github enterprise config. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// `projects/{project}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

        /// <summary>The branch or tag to use. Must start with "refs/" (required).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        /// <summary>See RepoType below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoType")]
        public virtual string RepoType { get; set; }

        /// <summary>
        /// The connected repository resource name, in the format `projects/*/locations/*/connections/*/repositories/*`.
        /// Either `uri` or `repository` can be specified and is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// The URI of the repo (e.g. https://github.com/user/repo.git). Either `uri` or `repository` can be specified
        /// and is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in any accessible Git repository.</summary>
    public class GitSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Optional. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref. Cloud Build uses `git fetch` to fetch the revision from the Git repository; therefore make sure that
        /// the string you provide for `revision` is parsable by the command. For information on string values accepted
        /// by `git fetch`, see https://git-scm.com/docs/gitrevisions#_specifying_revisions. For information on `git
        /// fetch`, see https://git-scm.com/docs/git-fetch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// Required. Location of the Git repo to build. This will be used as a `git remote`, see
        /// https://git-scm.com/docs/git-remote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a git repository as a build dependency.</summary>
    public class GitSourceDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How much history should be fetched for the build (default 1, -1 for all history).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<long> Depth { get; set; }

        /// <summary>Required. Where should the files be placed on the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destPath")]
        public virtual string DestPath { get; set; }

        /// <summary>Optional. True if submodules should be fetched too (default false).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurseSubmodules")]
        public virtual System.Nullable<bool> RecurseSubmodules { get; set; }

        /// <summary>Required. The kind of repo (url or dev connect).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual GitSourceRepository Repository { get; set; }

        /// <summary>Required. The revision that we will fetch the repo at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A repository for a git source.</summary>
    public class GitSourceRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Developer Connect Git repository link or the url that matches a repository link in the current project,
        /// formatted as `projects/*/locations/*/connections/*/gitRepositoryLink/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnect")]
        public virtual string DeveloperConnect { get; set; }

        /// <summary>Location of the Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Go module to upload to Artifact Registry upon successful completion of all build steps. A module refers to all
    /// dependencies in a go.mod file.
    /// </summary>
    public class GoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Go module's "module path". e.g. example.com/foo/v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modulePath")]
        public virtual string ModulePath { get; set; }

        /// <summary>
        /// Optional. The Go module's semantic version in the form vX.Y.Z. e.g. v0.1.1 Pre-release identifiers can also
        /// be added by appending a dash and dot separated ASCII alphanumeric characters and hyphens. e.g.
        /// v0.2.3-alpha.x.12m.5
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleVersion")]
        public virtual string ModuleVersion { get; set; }

        /// <summary>
        /// Optional. Location of the Artifact Registry repository. i.e. us-east1 Defaults to the build’s location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryLocation")]
        public virtual string RepositoryLocation { get; set; }

        /// <summary>
        /// Optional. Artifact Registry repository name. Specified Go modules will be zipped and uploaded to Artifact
        /// Registry with this location as a prefix. e.g. my-go-repo
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryName")]
        public virtual string RepositoryName { get; set; }

        /// <summary>Optional. Project ID of the Artifact Registry repository. Defaults to the build project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryProjectId")]
        public virtual string RepositoryProjectId { get; set; }

        /// <summary>
        /// Optional. Source path of the go.mod file in the build's workspace. If not specified, this will default to
        /// the current directory. e.g. ~/code/go/mypackage
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

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

    /// <summary>HttpConfig is a configuration for HTTP related git operations.</summary>
    public class HttpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// SecretVersion resource of the HTTP proxy URL. The Service Account used in the build (either the default
        /// Service Account or user-specified Service Account) should have `secretmanager.versions.access` permissions
        /// on this secret. The proxy URL should be in format `protocol://@]proxyhost[:port]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxySecretVersionName")]
        public virtual string ProxySecretVersionName { get; set; }

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

    /// <summary>RPC response object returned by ListBitbucketServerConfigs RPC method.</summary>
    public class ListBitbucketServerConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of BitbucketServerConfigs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfigs")]
        public virtual System.Collections.Generic.IList<BitbucketServerConfig> BitbucketServerConfigs { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC response object returned by the ListBitbucketServerRepositories RPC method.</summary>
    public class ListBitbucketServerRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Bitbucket Server repositories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerRepositories")]
        public virtual System.Collections.Generic.IList<BitbucketServerRepository> BitbucketServerRepositories { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>RPC response object returned by ListGitLabConfigs RPC method.</summary>
    public class ListGitLabConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of GitLabConfigs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfigs")]
        public virtual System.Collections.Generic.IList<GitLabConfig> GitlabConfigs { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC response object returned by the ListGitLabRepositories RPC method.</summary>
    public class ListGitLabRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GitLab repositories</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabRepositories")]
        public virtual System.Collections.Generic.IList<GitLabRepository> GitlabRepositories { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC response object returned by ListGithubEnterpriseConfigs RPC method.</summary>
    public class ListGithubEnterpriseConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of GitHubEnterpriseConfigs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GitHubEnterpriseConfig> Configs { get; set; }

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

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// </summary>
    public class MavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maven `artifactId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Maven `groupId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// Path to an artifact in the build's workspace to be uploaded to Artifact Registry. This can be either an
        /// absolute path, e.g. /workspace/my-app/target/my-app-1.0.SNAPSHOT.jar or a relative path from /workspace,
        /// e.g. my-app/target/my-app-1.0.SNAPSHOT.jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-maven.pkg.dev/$PROJECT/$REPOSITORY" Artifact in
        /// the workspace specified by path will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>Maven `version` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

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

        /// <summary>
        /// Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and
        /// the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g.
        /// `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16`
        /// would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If
        /// unspecified, a value of `/24` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeredNetworkIpRange")]
        public virtual string PeeredNetworkIpRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps.</summary>
    public class NpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packagePath")]
        public virtual string PackagePath { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-npm.pkg.dev/$PROJECT/$REPOSITORY" Npm package in
        /// the workspace specified by path will be zipped and uploaded to Artifact Registry with this location as a
        /// prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

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

        /// <summary>Immutable. Private Service Connect(PSC) Network configuration for the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateServiceConnect")]
        public virtual PrivateServiceConnect PrivateServiceConnect { get; set; }

        /// <summary>Machine configuration for the workers in the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerConfig")]
        public virtual WorkerConfig WorkerConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the Private Service Connect network configuration for the pool.</summary>
    public class PrivateServiceConnect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The network attachment that the worker network interface is peered to. Must be in the
        /// format `projects/{project}/regions/{region}/networkAttachments/{networkAttachment}`. The region of network
        /// attachment must be the same as the worker pool. See [Network
        /// Attachments](https://cloud.google.com/vpc/docs/about-network-attachments)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkAttachment")]
        public virtual string NetworkAttachment { get; set; }

        /// <summary>
        /// Required. Immutable. Disable public IP on the primary network interface. If true, workers are created
        /// without any public address, which prevents network egress to public IPs unless a network proxy is
        /// configured. If false, workers are created with a public address which allows for public internet egress. The
        /// public address only applies to traffic through the primary network interface. If `route_all_traffic` is set
        /// to true, all traffic will go through the non-primary network interface, this boolean has no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicIpAddressDisabled")]
        public virtual System.Nullable<bool> PublicIpAddressDisabled { get; set; }

        /// <summary>
        /// Immutable. Route all traffic through PSC interface. Enable this if you want full control of traffic in the
        /// private pool. Configure Cloud NAT for the subnet of network attachment if you need to access public
        /// Internet. If false, Only route private IPs, e.g. 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 through PSC
        /// interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeAllTraffic")]
        public virtual System.Nullable<bool> RouteAllTraffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `ProcessAppManifestCallback` operation.</summary>
    public class ProcessAppManifestCallbackOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitHubEnterprise to be created. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

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
        /// Optional. The name of the topic from which this subscription is receiving messages. Format is
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
        /// If CommentControl is enabled, depending on the setting, builds may not fire until a repository writer
        /// comments `/gcbrun` on a pull request or `/gcbrun` is in the pull request description. Only PR comments that
        /// contain `/gcbrun` will trigger builds. If CommentControl is set to disabled, comments with `/gcbrun` from a
        /// user with repository write permission or above will still trigger builds to run.
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
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can
    /// encapsulate multiple objects to be uploaded to a single repository.
    /// </summary>
    public class PythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path globs used to match files in the build's workspace. For Python/ Twine, this is usually `dist/*`, and
        /// sometimes additionally an `.asc` file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-python.pkg.dev/$PROJECT/$REPOSITORY" Files in the
        /// workspace matching any path pattern will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

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

    /// <summary>RPC request object accepted by RemoveBitbucketServerConnectedRepository RPC method.</summary>
    public class RemoveBitbucketServerConnectedRepositoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The connected repository to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepository")]
        public virtual BitbucketServerRepositoryId ConnectedRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by RemoveGitLabConnectedRepository RPC method.</summary>
    public class RemoveGitLabConnectedRepositoryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The connected repository to remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepository")]
        public virtual GitLabRepositoryId ConnectedRepository { get; set; }

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
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Optional. Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// Optional. ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the
        /// build is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>
        /// Optional. Substitutions to use in a triggered build. Should only be used with RunBuildTrigger
        /// </summary>
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

    /// <summary>
    /// The configuration of a trigger that creates a build whenever an event from Repo API is received.
    /// </summary>
    public class RepositoryEventConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter to match changes in pull requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullRequest")]
        public virtual PullRequestFilter PullRequest { get; set; }

        /// <summary>Filter to match changes in refs like branches, tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("push")]
        public virtual PushFilter Push { get; set; }

        /// <summary>The resource name of the Repo API resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>Output only. The type of the SCM vendor the repository points to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryType")]
        public virtual string RepositoryType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by the build pipeline.</summary>
    public class Results : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path to the artifact manifest for non-container artifacts uploaded to Cloud Storage. Only populated when
        /// artifacts are uploaded to Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactManifest")]
        public virtual string ArtifactManifest { get; set; }

        /// <summary>Time to push all non-container artifacts to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactTiming")]
        public virtual TimeSpan ArtifactTiming { get; set; }

        /// <summary>List of build step digests, in the order corresponding to build step indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepImages")]
        public virtual System.Collections.Generic.IList<string> BuildStepImages { get; set; }

        /// <summary>
        /// List of build step outputs, produced by builder images, in the order corresponding to build step indices.
        /// [Cloud Builders](https://cloud.google.com/cloud-build/docs/cloud-builders) can produce this output by
        /// writing to `$BUILDER_OUTPUT/output`. Only the first 50KB of data is stored. Note that the `$BUILDER_OUTPUT`
        /// variable is read-only and can't be substituted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepOutputs")]
        public virtual System.Collections.Generic.IList<string> BuildStepOutputs { get; set; }

        /// <summary>Optional. Go module artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<UploadedGoModule> GoModules { get; set; }

        /// <summary>Container images that were built as a part of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<BuiltImage> Images { get; set; }

        /// <summary>Maven artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<UploadedMavenArtifact> MavenArtifacts { get; set; }

        /// <summary>Npm packages uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<UploadedNpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// Number of non-container artifacts uploaded to Cloud Storage. Only populated when artifacts are uploaded to
        /// Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numArtifacts")]
        public virtual System.Nullable<long> NumArtifacts { get; set; }

        /// <summary>Python artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<UploadedPythonPackage> PythonPackages { get; set; }

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

        /// <summary>
        /// Source to build against this trigger. Branch and tag names cannot consist of regular expressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual RepoSource Source { get; set; }

        /// <summary>Required. ID of the trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

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

    /// <summary>ServiceDirectoryConfig represents Service Directory configuration for a SCM host connection.</summary>
    public class ServiceDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Service Directory service name. Format:
        /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a supported storage service.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If provided, get the source from this 2nd-gen Google Cloud Build repository resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepository")]
        public virtual ConnectedRepository ConnectedRepository { get; set; }

        /// <summary>If provided, get the source from this Developer Connect config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnectConfig")]
        public virtual DeveloperConnectConfig DeveloperConnectConfig { get; set; }

        /// <summary>If provided, get the source from this Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GitSource GitSource { get; set; }

        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual StorageSource StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Cloud Storage. This feature is in Preview; see description
        /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
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

        /// <summary>
        /// Output only. A copy of the build's `source.connected_repository`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedConnectedRepository")]
        public virtual ConnectedRepository ResolvedConnectedRepository { get; set; }

        /// <summary>
        /// Output only. A copy of the build's `source.git_source`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedGitSource")]
        public virtual GitSource ResolvedGitSource { get; set; }

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

    /// <summary>Location of the source in an archive file in Cloud Storage.</summary>
    public class StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Cloud Storage generation for the object. If the generation is omitted, the latest generation will
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source. This object must be a zipped (`.zip`) or gzipped
        /// archive file (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>Optional. Option to specify the tool to fetch the source file for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFetcher")]
        public virtual string SourceFetcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location of the source manifest in Cloud Storage. This feature is in Preview; see description
    /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
    /// </summary>
    public class StorageSourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cloud Storage bucket containing the source manifest (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source manifest. This object must be a JSON file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start and end times for a build execution phase.</summary>
    public class TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End of time span.</summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Start of time span.</summary>
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

    /// <summary>Metadata for `UpdateBitbucketServerConfig` operation.</summary>
    public class UpdateBitbucketServerConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the BitbucketServerConfig to be updated. Format:
        /// `projects/{project}/locations/{location}/bitbucketServerConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketServerConfig")]
        public virtual string BitbucketServerConfig { get; set; }

        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `UpdateGitHubEnterpriseConfig` operation.</summary>
    public class UpdateGitHubEnterpriseConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitHubEnterprise to be updated. Format:
        /// `projects/{project}/locations/{location}/githubEnterpriseConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual string GithubEnterpriseConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for `UpdateGitLabConfig` operation.</summary>
    public class UpdateGitLabConfigOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the GitLabConfig to be created. Format:
        /// `projects/{project}/locations/{location}/gitlabConfigs/{id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfig")]
        public virtual string GitlabConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the `UpdateWorkerPool` operation.</summary>
    public class UpdateWorkerPoolOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _completeTimeRaw;

        private object _completeTime;

        /// <summary>Time the operation was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeTime")]
        public virtual string CompleteTimeRaw
        {
            get => _completeTimeRaw;
            set
            {
                _completeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompleteTimeDateTimeOffset instead.")]
        public virtual object CompleteTime
        {
            get => _completeTime;
            set
            {
                _completeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompleteTimeRaw);
            set => CompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time the operation was created.</summary>
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
        /// The resource name of the `WorkerPool` being updated. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Go module artifact uploaded to Artifact Registry using the GoModule directive.</summary>
    public class UploadedGoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Go Module Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Maven artifact uploaded using the MavenArtifact directive.</summary>
    public class UploadedMavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Maven Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An npm package uploaded to Artifact Registry using the NpmPackage directive.</summary>
    public class UploadedNpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact uploaded using the PythonPackage directive.</summary>
    public class UploadedPythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Python Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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
        /// up to 2000. If `0` is specified, Cloud Build will use a standard disk size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Machine type of a worker, such as `e2-medium`. See [Worker pool config
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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the request to create the `WorkerPool` was received.</summary>
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

        /// <summary>Output only. Time at which the request to delete the `WorkerPool` was received.</summary>
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

        /// <summary>Legacy Private Pool configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privatePoolV1Config")]
        public virtual PrivatePoolV1Config PrivatePoolV1Config { get; set; }

        /// <summary>Output only. `WorkerPool` state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A unique identifier for the `WorkerPool`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time at which the request to update the `WorkerPool` was received.</summary>
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
}
