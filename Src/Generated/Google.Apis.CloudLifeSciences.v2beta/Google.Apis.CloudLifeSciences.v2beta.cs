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

namespace Google.Apis.CloudLifeSciences.v2beta
{
    /// <summary>The CloudLifeSciences Service.</summary>
    public class CloudLifeSciencesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudLifeSciencesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudLifeSciencesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "lifesciences";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://lifesciences.googleapis.com/";
        #else
            "https://lifesciences.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://lifesciences.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Life Sciences API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Life Sciences API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudLifeSciences requests.</summary>
    public abstract class CloudLifeSciencesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudLifeSciencesBaseServiceRequest instance.</summary>
        protected CloudLifeSciencesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudLifeSciences parameter list.</summary>
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
                Operations = new OperationsResource(service);
                Pipelines = new PipelinesResource(service);
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
                /// cancel the operation, but success is not guaranteed. Clients may use Operations.GetOperation or
                /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed
                /// despite cancellation. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.cancel`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CloudLifeSciences.v2beta.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. Clients may use Operations.GetOperation or
                /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed
                /// despite cancellation. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.cancel`
                /// </summary>
                public class CancelRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudLifeSciences.v2beta.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudLifeSciences.v2beta.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+name}:cancel";

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
                /// result at intervals as recommended by the API service. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.get`
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.get`
                /// </summary>
                public class GetRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.Operation>
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
                    public override string RestPath => "v2beta/{+name}";

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
                /// Lists operations that match the specified filter in the request. Authorization requires the
                /// following [Google IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.list`
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. Authorization requires the
                /// following [Google IAM](https://cloud.google.com/iam) permission: * `lifesciences.operations.list`
                /// </summary>
                public class ListRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.ListOperationsResponse>
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

                    /// <summary>
                    /// A string for filtering Operations. The following filter fields are supported: * createTime: The
                    /// time this job was created * events: The set of event (names) that have occurred while running
                    /// the pipeline. The : operator can be used to determine if a particular event has occurred. *
                    /// error: If the pipeline is running, this value is NULL. Once the pipeline finishes, the value is
                    /// the standard Google error code. * labels.key or labels."key with space" where key is a label
                    /// key. * done: If the pipeline is running, this value is false. Once the pipeline finishes, the
                    /// value is true.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of results to return. The maximum value is 256.</summary>
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
                    public override string RestPath => "v2beta/{+name}/operations";

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

            /// <summary>Gets the Pipelines resource.</summary>
            public virtual PipelinesResource Pipelines { get; }

            /// <summary>The "pipelines" collection of methods.</summary>
            public class PipelinesResource
            {
                private const string Resource = "pipelines";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PipelinesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Runs a pipeline. The returned Operation's metadata field will contain a
                /// google.cloud.lifesciences.v2beta.Metadata object describing the status of the pipeline execution.
                /// The response field will contain a google.cloud.lifesciences.v2beta.RunPipelineResponse object if the
                /// pipeline completes successfully. **Note:** Before you can use this method, the *Life Sciences
                /// Service Agent* must have access to your project. This is done automatically when the Cloud Life
                /// Sciences API is first enabled, but if you delete this permission you must disable and re-enable the
                /// API to grant the Life Sciences Service Agent the required permissions. Authorization requires the
                /// following [Google IAM](https://cloud.google.com/iam/) permission: * `lifesciences.workflows.run`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">The project and location that this request should be executed against.</param>
                public virtual RunRequest Run(Google.Apis.CloudLifeSciences.v2beta.Data.RunPipelineRequest body, string parent)
                {
                    return new RunRequest(service, body, parent);
                }

                /// <summary>
                /// Runs a pipeline. The returned Operation's metadata field will contain a
                /// google.cloud.lifesciences.v2beta.Metadata object describing the status of the pipeline execution.
                /// The response field will contain a google.cloud.lifesciences.v2beta.RunPipelineResponse object if the
                /// pipeline completes successfully. **Note:** Before you can use this method, the *Life Sciences
                /// Service Agent* must have access to your project. This is done automatically when the Cloud Life
                /// Sciences API is first enabled, but if you delete this permission you must disable and re-enable the
                /// API to grant the Life Sciences Service Agent the required permissions. Authorization requires the
                /// following [Google IAM](https://cloud.google.com/iam/) permission: * `lifesciences.workflows.run`
                /// </summary>
                public class RunRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.Operation>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudLifeSciences.v2beta.Data.RunPipelineRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The project and location that this request should be executed against.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudLifeSciences.v2beta.Data.RunPipelineRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2beta/{+parent}/pipelines:run";

                    /// <summary>Initializes Run parameter list.</summary>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.Location>
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
                public override string RestPath => "v2beta/{+name}";

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
            public class ListRequest : CloudLifeSciencesBaseServiceRequest<Google.Apis.CloudLifeSciences.v2beta.Data.ListLocationsResponse>
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
                public override string RestPath => "v2beta/{+name}/locations";

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
namespace Google.Apis.CloudLifeSciences.v2beta.Data
{
    /// <summary>Carries information about an accelerator that can be attached to a VM.</summary>
    public class Accelerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many accelerators of this type to attach.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// The accelerator type string (for example, "nvidia-tesla-k80"). Only NVIDIA GPU accelerators are currently
        /// supported. If an NVIDIA GPU is attached, the required runtime libraries will be made available to all
        /// containers under `/usr/local/nvidia`. The driver version to install must be specified using the NVIDIA
        /// driver version parameter on the virtual machine specification. Note that attaching a GPU increases the
        /// worker VM startup time by a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a single action that runs a Docker container.</summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, after an action fails, no further actions are run. This flag indicates that this action must be
        /// run even if the pipeline has already failed. This is useful for actions that copy output files off of the VM
        /// or for debugging. Note that no actions will be run if image prefetching fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysRun")]
        public virtual System.Nullable<bool> AlwaysRun { get; set; }

        /// <summary>Prevents the container from accessing the external network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockExternalNetwork")]
        public virtual System.Nullable<bool> BlockExternalNetwork { get; set; }

        /// <summary>
        /// If specified, overrides the `CMD` specified in the container. If the container also has an `ENTRYPOINT` the
        /// values are used as entrypoint arguments. Otherwise, they are used as a command and arguments to run inside
        /// the container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>
        /// An optional name for the container. The container hostname will be set to this name, making it useful for
        /// inter-container communication. The name must contain only upper and lowercase alphanumeric characters and
        /// hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerName")]
        public virtual string ContainerName { get; set; }

        /// <summary>
        /// If the specified image is hosted on a private registry other than Google Container Registry, the credentials
        /// required to pull the image must be specified here as an encrypted secret. The secret must decrypt to a
        /// JSON-encoded dictionary containing both `username` and `password` keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentials")]
        public virtual Secret Credentials { get; set; }

        /// <summary>
        /// All container images are typically downloaded before any actions are executed. This helps prevent typos in
        /// URIs or issues like lack of disk space from wasting large amounts of compute resources. If set, this flag
        /// prevents the worker from downloading the image until just before the action is executed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableImagePrefetch")]
        public virtual System.Nullable<bool> DisableImagePrefetch { get; set; }

        /// <summary>
        /// A small portion of the container's standard error stream is typically captured and returned inside the
        /// `ContainerStoppedEvent`. Setting this flag disables this functionality.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStandardErrorCapture")]
        public virtual System.Nullable<bool> DisableStandardErrorCapture { get; set; }

        /// <summary>
        /// Enable access to the FUSE device for this action. Filesystems can then be mounted into disks shared with
        /// other actions. The other actions do not need the `enable_fuse` flag to access the mounted filesystem. This
        /// has the effect of causing the container to be executed with `CAP_SYS_ADMIN` and exposes `/dev/fuse` to the
        /// container, so use it only for containers you trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFuse")]
        public virtual System.Nullable<bool> EnableFuse { get; set; }

        /// <summary>
        /// The encrypted environment to pass into the container. This environment is merged with values specified in
        /// the google.cloud.lifesciences.v2beta.Pipeline message, overwriting any duplicate values. The secret must
        /// decrypt to a JSON-encoded dictionary where key-value pairs serve as environment variable names and their
        /// values. The decoded environment variables can overwrite the values specified by the `environment` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedEnvironment")]
        public virtual Secret EncryptedEnvironment { get; set; }

        /// <summary>If specified, overrides the `ENTRYPOINT` specified in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// The environment to pass into the container. This environment is merged with values specified in the
        /// google.cloud.lifesciences.v2beta.Pipeline message, overwriting any duplicate values. In addition to the
        /// values passed here, a few other values are automatically injected into the environment. These cannot be
        /// hidden or overwritten. `GOOGLE_PIPELINE_FAILED` will be set to "1" if the pipeline failed because an action
        /// has exited with a non-zero status (and did not have the `IGNORE_EXIT_STATUS` flag set). This can be used to
        /// determine if additional debug or logging actions should execute. `GOOGLE_LAST_EXIT_STATUS` will be set to
        /// the exit status of the last non-background action that executed. This can be used by workflow engine authors
        /// to determine whether an individual action has succeeded or failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environment { get; set; }

        /// <summary>
        /// Normally, a non-zero exit status causes the pipeline to fail. This flag allows execution of other actions to
        /// continue instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreExitStatus")]
        public virtual System.Nullable<bool> IgnoreExitStatus { get; set; }

        /// <summary>
        /// Required. The URI to pull the container image from. Note that all images referenced by actions in the
        /// pipeline are pulled before the first action runs. If multiple actions reference the same image, it is only
        /// pulled once, ensuring that the same image is used for all actions in a single pipeline. The image URI can be
        /// either a complete host and image specification (e.g., quay.io/biocontainers/samtools), a library and image
        /// name (e.g., google/cloud-sdk) or a bare image name ('bash') to pull from the default library. No schema is
        /// required in any of these cases. If the specified image is not public, the service account specified for the
        /// Virtual Machine must have access to pull the images from GCR, or appropriate credentials must be specified
        /// in the google.cloud.lifesciences.v2beta.Action.credentials field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Labels to associate with the action. This field is provided to assist workflow engine authors in identifying
        /// actions (for example, to indicate what sort of action they perform, such as localization or debugging). They
        /// are returned in the operation metadata, but are otherwise ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// A list of mounts to make available to the action. In addition to the values specified here, every action has
        /// a special virtual disk mounted under `/google` that contains log files and other operational components. -
        /// /google/logs All logs written during the pipeline execution. - /google/logs/output The combined standard
        /// output and standard error of all actions run as part of the pipeline execution. -
        /// /google/logs/action/*/stdout The complete contents of each individual action's standard output. -
        /// /google/logs/action/*/stderr The complete contents of each individual action's standard error output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mounts")]
        public virtual System.Collections.Generic.IList<Mount> Mounts { get; set; }

        /// <summary>
        /// An optional identifier for a PID namespace to run the action inside. Multiple actions should use the same
        /// string to share a namespace. If unspecified, a separate isolated namespace is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pidNamespace")]
        public virtual string PidNamespace { get; set; }

        /// <summary>
        /// A map of containers to host port mappings for this container. If the container already specifies exposed
        /// ports, use the `PUBLISH_EXPOSED_PORTS` flag instead. The host port number must be less than 65536. If it is
        /// zero, an unused random port is assigned. To determine the resulting port number, consult the
        /// `ContainerStartedEvent` in the operation metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> PortMappings { get; set; }

        /// <summary>
        /// Exposes all ports specified by `EXPOSE` statements in the container. To discover the host side port numbers,
        /// consult the `ACTION_STARTED` event in the operation metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishExposedPorts")]
        public virtual System.Nullable<bool> PublishExposedPorts { get; set; }

        /// <summary>
        /// This flag allows an action to continue running in the background while executing subsequent actions. This is
        /// useful to provide services to other actions (or to provide debugging support tools like SSH servers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runInBackground")]
        public virtual System.Nullable<bool> RunInBackground { get; set; }

        /// <summary>
        /// The maximum amount of time to give the action to complete. If the action fails to complete before the
        /// timeout, it will be terminated and the exit status will be non-zero. The pipeline will continue or terminate
        /// based on the rules defined by the `ALWAYS_RUN` and `IGNORE_EXIT_STATUS` flags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

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
    /// An event generated when a container is forcibly terminated by the worker. Currently, this only occurs when the
    /// container outlives the timeout specified by the user.
    /// </summary>
    public class ContainerKilledEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container starts.</summary>
    public class ContainerStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>
        /// The public IP address that can be used to connect to the container. This field is only populated when at
        /// least one port mapping is present. If the instance was created with a private address, this field will be
        /// empty even if port mappings exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The container-to-host port mappings installed for this container. This set will contain any ports exposed
        /// using the `PUBLISH_EXPOSED_PORTS` flag as well as any specified in the `Action` definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> PortMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container exits.</summary>
    public class ContainerStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>
        /// The tail end of any content written to standard error by the container. If the content emits large amounts
        /// of debugging noise or contains sensitive information, you can prevent the content from being printed by
        /// setting the `DISABLE_STANDARD_ERROR_CAPTURE` flag. Note that only a small amount of the end of the stream is
        /// captured here. The entire stream is stored in the `/google/logs` directory mounted into each action, and can
        /// be copied off the machine as described elsewhere.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderr")]
        public virtual string Stderr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated whenever a resource limitation or transient error delays execution of a pipeline that was
    /// otherwise ready to run.
    /// </summary>
    public class DelayedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A textual description of the cause of the delay. The string can change without notice because it is often
        /// generated by another service (such as Compute Engine).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>
        /// If the delay was caused by a resource shortage, this field lists the Compute Engine metrics that are
        /// preventing this operation from running (for example, `CPUS` or `INSTANCES`). If the particular metric is not
        /// known, a single `UNKNOWN` metric will be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Carries information about a disk that can be attached to a VM. See
    /// https://cloud.google.com/compute/docs/disks/performance for more information about disk type, size, and
    /// performance considerations. Specify either `Volume` or `Disk`, but not both.
    /// </summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-supplied name for the disk. Used when mounting the disk into actions. The name must contain only
        /// upper and lowercase alphanumeric characters and hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The size, in GB, of the disk to attach. If the size is not specified, a default is chosen to ensure
        /// reasonable I/O performance. If the disk type is specified as `local-ssd`, multiple local drives are
        /// automatically combined to provide the requested size. Note, however, that each physical SSD is 375GB in
        /// size, and no more than 8 drives can be attached to a single instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>An optional image to put on the disk before attaching it to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>The Compute Engine disk type. If unspecified, `pd-standard` is used.</summary>
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

    /// <summary>Carries information about events that occur during pipeline execution.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>See google.cloud.lifesciences.v2beta.ContainerKilledEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerKilled")]
        public virtual ContainerKilledEvent ContainerKilled { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.ContainerStartedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerStarted")]
        public virtual ContainerStartedEvent ContainerStarted { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.ContainerStoppedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerStopped")]
        public virtual ContainerStoppedEvent ContainerStopped { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.DelayedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delayed")]
        public virtual DelayedEvent Delayed { get; set; }

        /// <summary>
        /// A human-readable description of the event. Note that these strings can change at any time without notice.
        /// Any application logic must use the information in the `details` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.FailedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failed")]
        public virtual FailedEvent Failed { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.PullStartedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullStarted")]
        public virtual PullStartedEvent PullStarted { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.PullStoppedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullStopped")]
        public virtual PullStoppedEvent PullStopped { get; set; }

        /// <summary>The time at which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.UnexpectedExitStatusEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedExitStatus")]
        public virtual UnexpectedExitStatusEvent UnexpectedExitStatus { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.WorkerAssignedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerAssigned")]
        public virtual WorkerAssignedEvent WorkerAssigned { get; set; }

        /// <summary>See google.cloud.lifesciences.v2beta.WorkerReleasedEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerReleased")]
        public virtual WorkerReleasedEvent WorkerReleased { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an existing disk to be attached to the VM.</summary>
    public class ExistingDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `disk` contains slashes, the Cloud Life Sciences API assumes that it is a complete URL for the disk. If
        /// `disk` does not contain slashes, the Cloud Life Sciences API assumes that the disk is a zonal disk and a URL
        /// will be generated of the form `zones//disks/`, where `` is the zone in which the instance is allocated. The
        /// disk must be ext4 formatted. If all `Mount` references to this disk have the `read_only` flag set to true,
        /// the disk will be attached in `read-only` mode and can be shared with other instances. Otherwise, the disk
        /// will be available for writing but cannot be shared.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual string Disk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the execution of a pipeline has failed. Note that other events can continue to occur
    /// after this event.
    /// </summary>
    public class FailedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>The Google standard error code that best describes this failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

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

    /// <summary>
    /// Carries information about the pipeline execution that is returned in the long running operation's metadata
    /// field.
    /// </summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation was created by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time at which execution was completed and resources were cleaned up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The list of events that have happened so far during the execution of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>The user-defined labels associated with this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The pipeline this operation represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipeline")]
        public virtual Pipeline Pipeline { get; set; }

        /// <summary>
        /// The name of the Cloud Pub/Sub topic where notifications of operation status changes are sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubSubTopic")]
        public virtual string PubSubTopic { get; set; }

        /// <summary>The first time at which resources were allocated to execute the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a particular disk mount inside a container.</summary>
    public class Mount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the disk to mount, as specified in the resources section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual string Disk { get; set; }

        /// <summary>The path to mount the disk inside the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>If true, the disk is mounted read-only inside the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an `NFSMount` to be attached to the VM.</summary>
    public class NFSMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A target NFS mount. The target must be specified as `address:/mount".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM networking options.</summary>
    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The network name to attach the VM's network interface to. The value will be prefixed with `global/networks/`
        /// unless it contains a `/`, in which case it is assumed to be a fully specified network resource URL. If
        /// unspecified, the global default network is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string NetworkValue { get; set; }

        /// <summary>
        /// If the specified network is configured for custom subnet creation, the name of the subnetwork to attach the
        /// instance to must be specified here. The value is prefixed with `regions/*/subnetworks/` unless it contains a
        /// `/`, in which case it is assumed to be a fully specified subnetwork resource URL. If the `*` character
        /// appears in the value, it is replaced with the region that the virtual machine has been allocated in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// If set to true, do not attach a public IP address to the VM. Note that without a public IP address,
        /// additional configuration is required to allow the VM to access Google services. See
        /// https://cloud.google.com/vpc/docs/configure-private-google-access for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usePrivateAddress")]
        public virtual System.Nullable<bool> UsePrivateAddress { get; set; }

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

        /// <summary>An Metadata object. This will always be returned with the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name for the operation. This may be passed to the other operation methods to retrieve
        /// information about the operation's status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An Empty object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a persistent disk to be attached to the VM. See
    /// https://cloud.google.com/compute/docs/disks/performance for more information about disk type, size, and
    /// performance considerations.
    /// </summary>
    public class PersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The size, in GB, of the disk to attach. If the size is not specified, a default is chosen to ensure
        /// reasonable I/O performance. If the disk type is specified as `local-ssd`, multiple local drives are
        /// automatically combined to provide the requested size. Note, however, that each physical SSD is 375GB in
        /// size, and no more than 8 drives can be attached to a single instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>An image to put on the disk before attaching it to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>The Compute Engine disk type. If unspecified, `pd-standard` is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a series of actions to execute, expressed as Docker containers.</summary>
    public class Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of actions to execute, in the order they are specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>
        /// The encrypted environment to pass into every action. Each action can also specify its own encrypted
        /// environment. The secret must decrypt to a JSON-encoded dictionary where key-value pairs serve as environment
        /// variable names and their values. The decoded environment variables can overwrite the values specified by the
        /// `environment` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedEnvironment")]
        public virtual Secret EncryptedEnvironment { get; set; }

        /// <summary>
        /// The environment to pass into every action. Each action can also specify additional environment variables but
        /// cannot delete an entry from this map (though they can overwrite it with a different value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environment { get; set; }

        /// <summary>The resources required for execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>
        /// The maximum amount of time to give the pipeline to complete. This includes the time spent waiting for a
        /// worker to be allocated. If the pipeline fails to complete before the timeout, it will be cancelled and the
        /// error code will be set to DEADLINE_EXCEEDED. If unspecified, it will default to 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker starts pulling an image.</summary>
    public class PullStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker stops pulling an image.</summary>
    public class PullStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The system resources for the pipeline run. At least one zone or region must be specified or the pipeline run
    /// will fail.
    /// </summary>
    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of regions allowed for VM allocation. If set, the `zones` field must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The virtual machine specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualMachine")]
        public virtual VirtualMachine VirtualMachine { get; set; }

        /// <summary>The list of zones allowed for VM allocation. If set, the `regions` field must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The arguments to the `RunPipeline` method. The requesting user must have the `iam.serviceAccounts.actAs`
    /// permission for the Cloud Life Sciences service account or the request will fail.
    /// </summary>
    public class RunPipelineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-defined labels to associate with the returned operation. These labels are not propagated to any Google
        /// Cloud Platform resources used by the operation, and can be modified at any time. To associate labels with
        /// resources created while executing the operation, see the appropriate resource message (for example,
        /// `VirtualMachine`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The description of the pipeline to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipeline")]
        public virtual Pipeline Pipeline { get; set; }

        /// <summary>
        /// The name of an existing Pub/Sub topic. The server will publish messages to this topic whenever the status of
        /// the operation changes. The Life Sciences Service Agent account must have publisher permissions to the
        /// specified topic or notifications will not be sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubSubTopic")]
        public virtual string PubSubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to the RunPipeline method, returned in the operation's result field on success.</summary>
    public class RunPipelineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds encrypted information that is only decrypted and stored in RAM by the worker VM when running the pipeline.
    /// </summary>
    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of the cipherText response from the `encrypt` method. This field is intentionally unaudited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cipherText")]
        public virtual string CipherText { get; set; }

        /// <summary>
        /// The name of the Cloud KMS key that will be used to decrypt the secret value. The VM service account must
        /// have the required permissions and authentication scopes to invoke the `decrypt` method on the specified key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a Google Cloud service account.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email address of the service account. If not specified, the default Compute Engine service account for the
        /// project will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// List of scopes to be enabled for this service account on the VM, in addition to the cloud-platform API scope
        /// that will be added by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

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
    /// An event generated when the execution of a container results in a non-zero exit status that was not otherwise
    /// ignored. Execution will continue, but only actions that are flagged as `ALWAYS_RUN` will be executed. Other
    /// actions will be skipped.
    /// </summary>
    public class UnexpectedExitStatusEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a Compute Engine VM resource.</summary>
    public class VirtualMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of accelerators to attach to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<Accelerator> Accelerators { get; set; }

        /// <summary>
        /// The size of the boot disk, in GB. The boot disk must be large enough to accommodate all of the Docker images
        /// from each action in the pipeline at the same time. If not specified, a small but reasonable default value is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>
        /// The host operating system image to use. Currently, only Container-Optimized OS images can be used. The
        /// default value is `projects/cos-cloud/global/images/family/cos-stable`, which selects the latest stable
        /// release of Container-Optimized OS. This option is provided to allow testing against the beta release of the
        /// operating system to ensure that the new version does not interact negatively with production pipelines. To
        /// test a pipeline against the beta release of Container-Optimized OS, use the value
        /// `projects/cos-cloud/global/images/family/cos-beta`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootImage")]
        public virtual string BootImage { get; set; }

        /// <summary>
        /// The CPU platform to request. An instance based on a newer platform can be allocated, but never one with
        /// fewer capabilities. The value of this parameter must be a valid Compute Engine CPU platform name (such as
        /// "Intel Skylake"). This parameter is only useful for carefully optimized work loads where the CPU platform
        /// has a significant impact. For more information about the effect of this parameter, see
        /// https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuPlatform")]
        public virtual string CpuPlatform { get; set; }

        /// <summary>
        /// The list of disks to create and attach to the VM. Specify either the `volumes[]` field or the `disks[]`
        /// field, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<Disk> Disks { get; set; }

        /// <summary>
        /// The Compute Engine Disk Images to use as a Docker cache. The disks will be mounted into the Docker folder in
        /// a way that the images present in the cache will not need to be pulled. The digests of the cached images must
        /// match those of the tags used or the latest version will still be pulled. The root directory of the ext4
        /// image must contain `image` and `overlay2` directories copied from the Docker directory of a VM where the
        /// desired Docker images have already been pulled. Any images pulled that are not cached will be stored on the
        /// first cache disk instead of the boot disk. Only a single image is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerCacheImages")]
        public virtual System.Collections.Generic.IList<string> DockerCacheImages { get; set; }

        /// <summary>Whether Stackdriver monitoring should be enabled on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStackdriverMonitoring")]
        public virtual System.Nullable<bool> EnableStackdriverMonitoring { get; set; }

        /// <summary>
        /// Optional set of labels to apply to the VM and any attached disk resources. These labels must adhere to the
        /// [name and value restrictions](https://cloud.google.com/compute/docs/labeling-resources) on VM labels imposed
        /// by Compute Engine. Labels keys with the prefix 'google-' are reserved for use by Google. Labels applied at
        /// creation time to the VM. Applied on a best-effort basis to attached disk resources shortly after VM
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The machine type of the virtual machine to create. Must be the short name of a standard machine
        /// type (such as "n1-standard-1") or a custom machine type (such as "custom-1-4096", where "1" indicates the
        /// number of vCPUs and "4096" indicates the memory in MB). See [Creating an instance with a custom machine
        /// type](https://cloud.google.com/compute/docs/instances/creating-instance-with-custom-machine-type#create) for
        /// more specifications on creating a custom machine type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The VM network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual Network Network { get; set; }

        /// <summary>
        /// The NVIDIA driver version to use when attaching an NVIDIA GPU accelerator. The version specified here must
        /// be compatible with the GPU libraries contained in the container being executed, and must be one of the
        /// drivers hosted in the `nvidia-drivers-us-public` bucket on Google Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nvidiaDriverVersion")]
        public virtual string NvidiaDriverVersion { get; set; }

        /// <summary>If true, allocate a preemptible VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; }

        /// <summary>
        /// If specified, the VM will only be allocated inside the matching reservation. It will fail if the VM
        /// parameters don't match the reservation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation")]
        public virtual string Reservation { get; set; }

        /// <summary>
        /// The service account to install on the VM. This account does not need any permissions other than those
        /// required by the pipeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        /// <summary>
        /// The list of disks and other storage to create or attach to the VM. Specify either the `volumes[]` field or
        /// the `disks[]` field, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Carries information about storage that can be attached to a VM. Specify either `Volume` or `Disk`, but not both.
    /// </summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for a existing disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingDisk")]
        public virtual ExistingDisk ExistingDisk { get; set; }

        /// <summary>Configuration for an NFS mount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsMount")]
        public virtual NFSMount NfsMount { get; set; }

        /// <summary>Configuration for a persistent disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentDisk")]
        public virtual PersistentDisk PersistentDisk { get; set; }

        /// <summary>
        /// A user-supplied name for the volume. Used when mounting the volume into `Actions`. The name must contain
        /// only upper and lowercase alphanumeric characters and hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volume")]
        public virtual string VolumeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated after a worker VM has been assigned to run the pipeline.</summary>
    public class WorkerAssignedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The machine type that was assigned for the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The zone the worker is running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the worker VM that was assigned to the pipeline has been released (deleted).
    /// </summary>
    public class WorkerReleasedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The zone the worker was running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
