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

namespace Google.Apis.PolicySimulator.v1
{
    /// <summary>The PolicySimulator Service.</summary>
    public class PolicySimulatorService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PolicySimulatorService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PolicySimulatorService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Operations = new OperationsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "policysimulator";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://policysimulator.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://policysimulator.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Policy Simulator API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Policy Simulator API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for PolicySimulator requests.</summary>
    public abstract class PolicySimulatorBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PolicySimulatorBaseServiceRequest instance.</summary>
        protected PolicySimulatorBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PolicySimulator parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
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
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the Replays resource.</summary>
            public virtual ReplaysResource Replays { get; }

            /// <summary>The "replays" collection of methods.</summary>
            public class ReplaysResource
            {
                private const string Resource = "replays";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReplaysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    Results = new ResultsResource(service);
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/replays/[^/]+/operations/.*$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/replays/[^/]+/operations$",
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

                /// <summary>Gets the Results resource.</summary>
                public virtual ResultsResource Results { get; }

                /// <summary>The "results" collection of methods.</summary>
                public class ResultsResource
                {
                    private const string Resource = "results";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ResultsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    /// <param name="parent">
                    /// Required. The Replay whose results are listed, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}` Example:
                    /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1ListReplayResultsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Replay whose results are listed, in the following format:
                        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
                        /// Example: `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of ReplayResult objects to return. Defaults to 5000. The maximum value is
                        /// 5000; values above 5000 are rounded down to 5000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous Simulator.ListReplayResults call. Provide this token
                        /// to retrieve the next page of results. When paginating, all other parameters provided to
                        /// [Simulator.ListReplayResults[] must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/results";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/replays/[^/]+$",
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

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this Replay will be created. This resource must be a project,
                /// folder, or organization with a location. Example: `projects/my-example-project/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                public class CreateRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this Replay will be created. This resource must be a
                    /// project, folder, or organization with a location. Example:
                    /// `projects/my-example-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/replays";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                /// <param name="name">
                /// Required. The name of the Replay to retrieve, in the following format:
                /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`. Example:
                /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Replay to retrieve, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                    /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`.
                    /// Example:
                    /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/replays/[^/]+$",
                        });
                    }
                }
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
        public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
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

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningListOperationsResponse>
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
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^operations$",
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
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
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the Replays resource.</summary>
            public virtual ReplaysResource Replays { get; }

            /// <summary>The "replays" collection of methods.</summary>
            public class ReplaysResource
            {
                private const string Resource = "replays";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReplaysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    Results = new ResultsResource(service);
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/replays/[^/]+/operations/.*$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/replays/[^/]+/operations$",
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

                /// <summary>Gets the Results resource.</summary>
                public virtual ResultsResource Results { get; }

                /// <summary>The "results" collection of methods.</summary>
                public class ResultsResource
                {
                    private const string Resource = "results";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ResultsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    /// <param name="parent">
                    /// Required. The Replay whose results are listed, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}` Example:
                    /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1ListReplayResultsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Replay whose results are listed, in the following format:
                        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
                        /// Example: `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of ReplayResult objects to return. Defaults to 5000. The maximum value is
                        /// 5000; values above 5000 are rounded down to 5000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous Simulator.ListReplayResults call. Provide this token
                        /// to retrieve the next page of results. When paginating, all other parameters provided to
                        /// [Simulator.ListReplayResults[] must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/results";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/replays/[^/]+$",
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

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this Replay will be created. This resource must be a project,
                /// folder, or organization with a location. Example: `projects/my-example-project/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                public class CreateRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this Replay will be created. This resource must be a
                    /// project, folder, or organization with a location. Example:
                    /// `projects/my-example-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/replays";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                /// <param name="name">
                /// Required. The name of the Replay to retrieve, in the following format:
                /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`. Example:
                /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Replay to retrieve, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                    /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`.
                    /// Example:
                    /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/replays/[^/]+$",
                        });
                    }
                }
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
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the Replays resource.</summary>
            public virtual ReplaysResource Replays { get; }

            /// <summary>The "replays" collection of methods.</summary>
            public class ReplaysResource
            {
                private const string Resource = "replays";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReplaysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    Results = new ResultsResource(service);
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
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/replays/[^/]+/operations/.*$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningListOperationsResponse>
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
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/replays/[^/]+/operations$",
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

                /// <summary>Gets the Results resource.</summary>
                public virtual ResultsResource Results { get; }

                /// <summary>The "results" collection of methods.</summary>
                public class ResultsResource
                {
                    private const string Resource = "results";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ResultsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    /// <param name="parent">
                    /// Required. The Replay whose results are listed, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}` Example:
                    /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the results of running a Replay.</summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1ListReplayResultsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Replay whose results are listed, in the following format:
                        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
                        /// Example: `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of ReplayResult objects to return. Defaults to 5000. The maximum value is
                        /// 5000; values above 5000 are rounded down to 5000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous Simulator.ListReplayResults call. Provide this token
                        /// to retrieve the next page of results. When paginating, all other parameters provided to
                        /// [Simulator.ListReplayResults[] must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/results";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/replays/[^/]+$",
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

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this Replay will be created. This resource must be a project,
                /// folder, or organization with a location. Example: `projects/my-example-project/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates and starts a Replay using the given ReplayConfig.</summary>
                public class CreateRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this Replay will be created. This resource must be a
                    /// project, folder, or organization with a location. Example:
                    /// `projects/my-example-project/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/replays";

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
                    }
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                /// <param name="name">
                /// Required. The name of the Replay to retrieve, in the following format:
                /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`. Example:
                /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the specified Replay. Each `Replay` is available for at least 7 days.</summary>
                public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1Replay>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Replay to retrieve, in the following format:
                    /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where
                    /// `{resource-id}` is the ID of the project, folder, or organization that owns the `Replay`.
                    /// Example:
                    /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/replays/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.PolicySimulator.v1.Data
{
    /// <summary>
    /// A summary and comparison of the principal's access under the current (baseline) policies and the proposed
    /// (simulated) policies for a single access tuple.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1AccessStateDiff : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the principal's access, specified in the AccessState field, changed between the current (baseline)
        /// policies and proposed (simulated) policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessChange")]
        public virtual string AccessChange { get; set; }

        /// <summary>
        /// The results of evaluating the access tuple under the current (baseline) policies. If the AccessState
        /// couldn't be fully evaluated, this field explains why.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseline")]
        public virtual GoogleCloudPolicysimulatorV1ExplainedAccess Baseline { get; set; }

        /// <summary>
        /// The results of evaluating the access tuple under the proposed (simulated) policies. If the AccessState
        /// couldn't be fully evaluated, this field explains why.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simulated")]
        public virtual GoogleCloudPolicysimulatorV1ExplainedAccess Simulated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the principal, resource, and permission to check.</summary>
    public class GoogleCloudPolicysimulatorV1AccessTuple : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The full resource name that identifies the resource. For example,
        /// `//compute.googleapis.com/projects/my-project/zones/us-central1-a/instances/my-instance`. For examples of
        /// full resource names for Google Cloud services, see
        /// https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Required. The IAM permission to check for the specified principal and resource. For a complete list of IAM
        /// permissions, see https://cloud.google.com/iam/help/permissions/reference. For a complete list of predefined
        /// IAM roles and the permissions in each role, see https://cloud.google.com/iam/help/roles/reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>
        /// Required. The principal whose access you want to check, in the form of the email address that represents
        /// that principal. For example, `alice@example.com` or `my-service-account@my-project.iam.gserviceaccount.com`.
        /// The principal must be a Google Account or a service account. Other types of principals are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how a binding in a policy affects a principal's ability to use a permission.</summary>
    public class GoogleCloudPolicysimulatorV1BindingExplanation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Indicates whether _this binding_ provides the specified permission to the specified principal for
        /// the specified resource. This field does _not_ indicate whether the principal actually has the permission for
        /// the resource. There might be another binding that overrides this binding. To determine whether the principal
        /// actually has the permission, use the `access` field in the TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; }

        /// <summary>
        /// A condition expression that prevents this binding from granting access unless the expression evaluates to
        /// `true`. To learn about IAM Conditions, see https://cloud.google.com/iam/docs/conditions-overview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Indicates whether each principal in the binding includes the principal specified in the request, either
        /// directly or indirectly. Each key identifies a principal in the binding, and each value indicates whether the
        /// principal in the binding includes the principal in the request. For example, suppose that a binding includes
        /// the following principals: * `user:alice@example.com` * `group:product-eng@example.com` The principal in the
        /// replayed access tuple is `user:bob@example.com`. This user is a principal of the group
        /// `group:product-eng@example.com`. For the first principal in the binding, the key is
        /// `user:alice@example.com`, and the `membership` field in the value is set to `MEMBERSHIP_NOT_INCLUDED`. For
        /// the second principal in the binding, the key is `group:product-eng@example.com`, and the `membership` field
        /// in the value is set to `MEMBERSHIP_INCLUDED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudPolicysimulatorV1BindingExplanationAnnotatedMembership> Memberships { get; set; }

        /// <summary>The relevance of this binding to the overall determination for the entire policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>
        /// The role that this binding grants. For example, `roles/compute.serviceAgent`. For a complete list of
        /// predefined IAM roles, as well as the permissions in each role, see
        /// https://cloud.google.com/iam/help/roles/reference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Indicates whether the role granted by this binding contains the specified permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePermission")]
        public virtual string RolePermission { get; set; }

        /// <summary>
        /// The relevance of the permission's existence, or nonexistence, in the role to the overall determination for
        /// the entire policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePermissionRelevance")]
        public virtual string RolePermissionRelevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about whether the binding includes the principal.</summary>
    public class GoogleCloudPolicysimulatorV1BindingExplanationAnnotatedMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the binding includes the principal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>The relevance of the principal's status to the overall determination for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a set of policies, listed in ExplainedPolicy, resulted in a certain AccessState when replaying
    /// an access tuple.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1ExplainedAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the principal in the access tuple has permission to access the resource in the access tuple under
        /// the given policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessState")]
        public virtual string AccessState { get; set; }

        /// <summary>
        /// If the AccessState is `UNKNOWN`, this field contains a list of errors explaining why the result is
        /// `UNKNOWN`. If the `AccessState` is `GRANTED` or `NOT_GRANTED`, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> Errors { get; set; }

        /// <summary>
        /// If the AccessState is `UNKNOWN`, this field contains the policies that led to that result. If the
        /// `AccessState` is `GRANTED` or `NOT_GRANTED`, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1ExplainedPolicy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about how a specific IAM Policy contributed to the access check.</summary>
    public class GoogleCloudPolicysimulatorV1ExplainedPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether _this policy_ provides the specified permission to the specified principal for the
        /// specified resource. This field does _not_ indicate whether the principal actually has the permission for the
        /// resource. There might be another policy that overrides this policy. To determine whether the principal
        /// actually has the permission, use the `access` field in the TroubleshootIamPolicyResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; }

        /// <summary>
        /// Details about how each binding in the policy affects the principal's ability, or inability, to use the
        /// permission for the resource. If the user who created the Replay does not have access to the policy, this
        /// field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindingExplanations")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1BindingExplanation> BindingExplanations { get; set; }

        /// <summary>
        /// The full resource name that identifies the resource. For example,
        /// `//compute.googleapis.com/projects/my-project/zones/us-central1-a/instances/my-instance`. If the user who
        /// created the Replay does not have access to the policy, this field is omitted. For examples of full resource
        /// names for Google Cloud services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// The IAM policy attached to the resource. If the user who created the Replay does not have access to the
        /// policy, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// The relevance of this policy to the overall determination in the TroubleshootIamPolicyResponse. If the user
        /// who created the Replay does not have access to the policy, this field is omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevance")]
        public virtual string Relevance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Simulator.ListReplayResults.</summary>
    public class GoogleCloudPolicysimulatorV1ListReplayResultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that you can use to retrieve the next page of ReplayResult objects. If this field is omitted, there
        /// are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The results of running a Replay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replayResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1ReplayResult> ReplayResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource describing a `Replay`, or simulation.</summary>
    public class GoogleCloudPolicysimulatorV1Replay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration used for the `Replay`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudPolicysimulatorV1ReplayConfig Config { get; set; }

        /// <summary>
        /// Output only. The resource name of the `Replay`, which has the following format:
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where `{resource-id}`
        /// is the ID of the project, folder, or organization that owns the Replay. Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Summary statistics about the replayed log entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsSummary")]
        public virtual GoogleCloudPolicysimulatorV1ReplayResultsSummary ResultsSummary { get; set; }

        /// <summary>Output only. The current state of the `Replay`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration used for a Replay.</summary>
    public class GoogleCloudPolicysimulatorV1ReplayConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The logs to use as input for the Replay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSource")]
        public virtual string LogSource { get; set; }

        /// <summary>
        /// A mapping of the resources that you want to simulate policies for and the policies that you want to
        /// simulate. Keys are the full resource names for the resources. For example,
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`. For examples of full resource names for Google
        /// Cloud services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names. Values are Policy
        /// objects representing the policies that you want to simulate. Replays automatically take into account any IAM
        /// policies inherited through the resource hierarchy, and any policies set on descendant resources. You do not
        /// need to include these policies in the policy overlay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyOverlay")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleIamV1Policy> PolicyOverlay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The difference between the results of evaluating an access tuple under the current (baseline) policies and under
    /// the proposed (simulated) policies. This difference explains how a principal's access could change if the
    /// proposed policies were applied.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1ReplayDiff : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A summary and comparison of the principal's access under the current (baseline) policies and the proposed
        /// (simulated) policies for a single access tuple. The evaluation of the principal's access is reported in the
        /// AccessState field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessDiff")]
        public virtual GoogleCloudPolicysimulatorV1AccessStateDiff AccessDiff { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a Replay operation.</summary>
    public class GoogleCloudPolicysimulatorV1ReplayOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replaying a single access tuple against a simulated state.</summary>
    public class GoogleCloudPolicysimulatorV1ReplayResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The access tuple that was replayed. This field includes information about the principal, resource, and
        /// permission that were involved in the access attempt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTuple")]
        public virtual GoogleCloudPolicysimulatorV1AccessTuple AccessTuple { get; set; }

        /// <summary>
        /// The difference between the principal's access under the current (baseline) policies and the principal's
        /// access under the proposed (simulated) policies. This field is only included for access tuples that were
        /// successfully replayed and had different results under the current policies and the proposed policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diff")]
        public virtual GoogleCloudPolicysimulatorV1ReplayDiff Diff { get; set; }

        /// <summary>
        /// The error that caused the access tuple replay to fail. This field is only included for access tuples that
        /// were not replayed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>The latest date this access tuple was seen in the logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSeenDate")]
        public virtual GoogleTypeDate LastSeenDate { get; set; }

        /// <summary>
        /// The resource name of the `ReplayResult`, in the following format:
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}/results/{replay-result-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization that owns the Replay. Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36/results/1234`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The Replay that the access tuple was included in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary statistics about the replayed log entries.</summary>
    public class GoogleCloudPolicysimulatorV1ReplayResultsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of replayed log entries with a difference between baseline and simulated policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("differenceCount")]
        public virtual System.Nullable<int> DifferenceCount { get; set; }

        /// <summary>The number of log entries that could not be replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<int> ErrorCount { get; set; }

        /// <summary>The total number of log entries replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logCount")]
        public virtual System.Nullable<int> LogCount { get; set; }

        /// <summary>The date of the newest log entry replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newestDate")]
        public virtual GoogleTypeDate NewestDate { get; set; }

        /// <summary>The date of the oldest log entry replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestDate")]
        public virtual GoogleTypeDate OldestDate { get; set; }

        /// <summary>
        /// The number of replayed log entries with no difference between baseline and simulated policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unchangedCount")]
        public virtual System.Nullable<int> UnchangedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource describing a `Replay`, or simulation.</summary>
    public class GoogleCloudPolicysimulatorV1beta1Replay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration used for the `Replay`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudPolicysimulatorV1beta1ReplayConfig Config { get; set; }

        /// <summary>
        /// Output only. The resource name of the `Replay`, which has the following format:
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`, where `{resource-id}`
        /// is the ID of the project, folder, or organization that owns the Replay. Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Summary statistics about the replayed log entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsSummary")]
        public virtual GoogleCloudPolicysimulatorV1beta1ReplayResultsSummary ResultsSummary { get; set; }

        /// <summary>Output only. The current state of the `Replay`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration used for a Replay.</summary>
    public class GoogleCloudPolicysimulatorV1beta1ReplayConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The logs to use as input for the Replay.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSource")]
        public virtual string LogSource { get; set; }

        /// <summary>
        /// A mapping of the resources that you want to simulate policies for and the policies that you want to
        /// simulate. Keys are the full resource names for the resources. For example,
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`. For examples of full resource names for Google
        /// Cloud services, see https://cloud.google.com/iam/help/troubleshooter/full-resource-names. Values are Policy
        /// objects representing the policies that you want to simulate. Replays automatically take into account any IAM
        /// policies inherited through the resource hierarchy, and any policies set on descendant resources. You do not
        /// need to include these policies in the policy overlay.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyOverlay")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleIamV1Policy> PolicyOverlay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a Replay operation.</summary>
    public class GoogleCloudPolicysimulatorV1beta1ReplayOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary statistics about the replayed log entries.</summary>
    public class GoogleCloudPolicysimulatorV1beta1ReplayResultsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of replayed log entries with a difference between baseline and simulated policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("differenceCount")]
        public virtual System.Nullable<int> DifferenceCount { get; set; }

        /// <summary>The number of log entries that could not be replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCount")]
        public virtual System.Nullable<int> ErrorCount { get; set; }

        /// <summary>The total number of log entries replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logCount")]
        public virtual System.Nullable<int> LogCount { get; set; }

        /// <summary>The date of the newest log entry replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newestDate")]
        public virtual GoogleTypeDate NewestDate { get; set; }

        /// <summary>The date of the oldest log entry replayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestDate")]
        public virtual GoogleTypeDate OldestDate { get; set; }

        /// <summary>
        /// The number of replayed log entries with no difference between baseline and simulated policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unchangedCount")]
        public virtual System.Nullable<int> UnchangedCount { get; set; }

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
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

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
