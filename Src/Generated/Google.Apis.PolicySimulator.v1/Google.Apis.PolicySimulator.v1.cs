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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://policysimulator.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://policysimulator.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "policysimulator";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

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
                AccessPolicySimulations = new AccessPolicySimulationsResource(service);
                OrgPolicyViolationsPreviews = new OrgPolicyViolationsPreviewsResource(service);
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the AccessPolicySimulations resource.</summary>
            public virtual AccessPolicySimulationsResource AccessPolicySimulations { get; }

            /// <summary>The "accessPolicySimulations" collection of methods.</summary>
            public class AccessPolicySimulationsResource
            {
                private const string Resource = "accessPolicySimulations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AccessPolicySimulationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/accessPolicySimulations/[^/]+/operations/.*$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the OrgPolicyViolationsPreviews resource.</summary>
            public virtual OrgPolicyViolationsPreviewsResource OrgPolicyViolationsPreviews { get; }

            /// <summary>The "orgPolicyViolationsPreviews" collection of methods.</summary>
            public class OrgPolicyViolationsPreviewsResource
            {
                private const string Resource = "orgPolicyViolationsPreviews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OrgPolicyViolationsPreviewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/orgPolicyViolationsPreviews/[^/]+/operations/.*$",
                            });
                        }
                    }
                }
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
                        return new GetRequest(this.service, name);
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
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                        return new ListRequest(this.service, parent);
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
                    return new CreateRequest(this.service, body, parent);
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
                    return new GetRequest(this.service, name);
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
            return new GetRequest(this.service, name);
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
        /// it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(this.service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`.
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
                AccessPolicySimulations = new AccessPolicySimulationsResource(service);
                OrgPolicyViolationsPreviews = new OrgPolicyViolationsPreviewsResource(service);
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the AccessPolicySimulations resource.</summary>
            public virtual AccessPolicySimulationsResource AccessPolicySimulations { get; }

            /// <summary>The "accessPolicySimulations" collection of methods.</summary>
            public class AccessPolicySimulationsResource
            {
                private const string Resource = "accessPolicySimulations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AccessPolicySimulationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/accessPolicySimulations/[^/]+/operations/.*$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the OrgPolicyViolationsPreviews resource.</summary>
            public virtual OrgPolicyViolationsPreviewsResource OrgPolicyViolationsPreviews { get; }

            /// <summary>The "orgPolicyViolationsPreviews" collection of methods.</summary>
            public class OrgPolicyViolationsPreviewsResource
            {
                private const string Resource = "orgPolicyViolationsPreviews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OrgPolicyViolationsPreviewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    OrgPolicyViolations = new OrgPolicyViolationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/orgPolicyViolationsPreviews/[^/]+/operations/.*$",
                            });
                        }
                    }
                }

                /// <summary>Gets the OrgPolicyViolations resource.</summary>
                public virtual OrgPolicyViolationsResource OrgPolicyViolations { get; }

                /// <summary>The "orgPolicyViolations" collection of methods.</summary>
                public class OrgPolicyViolationsResource
                {
                    private const string Resource = "orgPolicyViolations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OrgPolicyViolationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// ListOrgPolicyViolations lists the OrgPolicyViolations that are present in an
                    /// OrgPolicyViolationsPreview.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from. Format:
                    /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// ListOrgPolicyViolations lists the OrgPolicyViolations that are present in an
                    /// OrgPolicyViolationsPreview.
                    /// </summary>
                    public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1ListOrgPolicyViolationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from. Format:
                        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. The service may return fewer than this
                        /// value. If unspecified, at most 1000 items will be returned. The maximum value is 1000;
                        /// values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters must match the call that provided the
                        /// page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/orgPolicyViolations";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/orgPolicyViolationsPreviews/[^/]+$",
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

                /// <summary>
                /// CreateOrgPolicyViolationsPreview creates an OrgPolicyViolationsPreview for the proposed changes in
                /// the provided OrgPolicyViolationsPreview.OrgPolicyOverlay. The changes to OrgPolicy are specified by
                /// this `OrgPolicyOverlay`. The resources to scan are inferred from these specified changes.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The organization under which this OrgPolicyViolationsPreview will be created. Example:
                /// `organizations/my-example-org/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// CreateOrgPolicyViolationsPreview creates an OrgPolicyViolationsPreview for the proposed changes in
                /// the provided OrgPolicyViolationsPreview.OrgPolicyOverlay. The changes to OrgPolicy are specified by
                /// this `OrgPolicyOverlay`. The resources to scan are inferred from these specified changes.
                /// </summary>
                public class CreateRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The organization under which this OrgPolicyViolationsPreview will be created. Example:
                    /// `organizations/my-example-org/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An optional user-specified ID for the OrgPolicyViolationsPreview. If not provided, a
                    /// random ID will be generated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orgPolicyViolationsPreviewId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrgPolicyViolationsPreviewId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/orgPolicyViolationsPreviews";

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
                        RequestParameters.Add("orgPolicyViolationsPreviewId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orgPolicyViolationsPreviewId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// GetOrgPolicyViolationsPreview gets the specified OrgPolicyViolationsPreview. Each
                /// OrgPolicyViolationsPreview is available for at least 7 days.
                /// </summary>
                /// <param name="name">Required. The name of the OrgPolicyViolationsPreview to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// GetOrgPolicyViolationsPreview gets the specified OrgPolicyViolationsPreview. Each
                /// OrgPolicyViolationsPreview is available for at least 7 days.
                /// </summary>
                public class GetRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the OrgPolicyViolationsPreview to get.</summary>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/orgPolicyViolationsPreviews/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// ListOrgPolicyViolationsPreviews lists each OrgPolicyViolationsPreview in an organization. Each
                /// OrgPolicyViolationsPreview is available for at least 7 days.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent the violations are scoped to. Format:
                /// `organizations/{organization}/locations/{location}` Example:
                /// `organizations/my-example-org/locations/global`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// ListOrgPolicyViolationsPreviews lists each OrgPolicyViolationsPreview in an organization. Each
                /// OrgPolicyViolationsPreview is available for at least 7 days.
                /// </summary>
                public class ListRequest : PolicySimulatorBaseServiceRequest<Google.Apis.PolicySimulator.v1.Data.GoogleCloudPolicysimulatorV1ListOrgPolicyViolationsPreviewsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent the violations are scoped to. Format:
                    /// `organizations/{organization}/locations/{location}` Example:
                    /// `organizations/my-example-org/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. The service may return fewer than this value.
                    /// If unspecified, at most 5 items will be returned. The maximum value is 10; values above 10 will
                    /// be coerced to 10.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call. Provide this to retrieve the subsequent
                    /// page. When paginating, all other parameters must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/orgPolicyViolationsPreviews";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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
                        return new GetRequest(this.service, name);
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
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                        return new ListRequest(this.service, parent);
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
                    return new CreateRequest(this.service, body, parent);
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
                    return new GetRequest(this.service, name);
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
                AccessPolicySimulations = new AccessPolicySimulationsResource(service);
                OrgPolicyViolationsPreviews = new OrgPolicyViolationsPreviewsResource(service);
                Replays = new ReplaysResource(service);
            }

            /// <summary>Gets the AccessPolicySimulations resource.</summary>
            public virtual AccessPolicySimulationsResource AccessPolicySimulations { get; }

            /// <summary>The "accessPolicySimulations" collection of methods.</summary>
            public class AccessPolicySimulationsResource
            {
                private const string Resource = "accessPolicySimulations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AccessPolicySimulationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accessPolicySimulations/[^/]+/operations/.*$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the OrgPolicyViolationsPreviews resource.</summary>
            public virtual OrgPolicyViolationsPreviewsResource OrgPolicyViolationsPreviews { get; }

            /// <summary>The "orgPolicyViolationsPreviews" collection of methods.</summary>
            public class OrgPolicyViolationsPreviewsResource
            {
                private const string Resource = "orgPolicyViolationsPreviews";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OrgPolicyViolationsPreviewsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
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
                        return new GetRequest(this.service, name);
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/orgPolicyViolationsPreviews/[^/]+/operations/.*$",
                            });
                        }
                    }
                }
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
                        return new GetRequest(this.service, name);
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
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
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
                        return new ListRequest(this.service, parent);
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
                    return new CreateRequest(this.service, body, parent);
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
                    return new GetRequest(this.service, name);
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
    /// Similar to PolicySpec but with an extra 'launch' field for launch reference. The PolicySpec here is specific for
    /// dry-run.
    /// </summary>
    public class GoogleCloudOrgpolicyV2AlternatePolicySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference to the launch that will be used while audit logging and to control the launch. Should be set only
        /// in the alternate policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launch")]
        public virtual string Launch { get; set; }

        /// <summary>Specify constraint for configurations of Google Cloud resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A custom constraint defined by customers which can *only* be applied to the given resource types and
    /// organization. By creating a custom constraint, customers can apply policies of this custom constraint. *Creating
    /// a custom constraint itself does NOT apply any policy enforcement*.
    /// </summary>
    public class GoogleCloudOrgpolicyV2CustomConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow or deny type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// A Common Expression Language (CEL) condition which is used in the evaluation of the constraint. For example:
        /// `resource.instanceName.matches("[production|test]_.*_(\d)+")` or, `resource.management.auto_upgrade == true`
        /// The max length of the condition is 1000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Detailed information about this custom policy constraint. The max length of the description is 2000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>One line display name for the UI. The max length of the display_name is 200 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>All the operations being applied for this constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodTypes")]
        public virtual System.Collections.Generic.IList<string> MethodTypes { get; set; }

        /// <summary>
        /// Immutable. Name of the constraint. This is unique within the organization. Format of the name should be *
        /// `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
        /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms` The max length is 70 characters and the
        /// minimum length is 1. Note that the prefix `organizations/{organization_id}/customConstraints/` is not
        /// counted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource instance type on which this policy applies. Format will be of the form : `/`
        /// Example: * `compute.googleapis.com/Instance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The last time this custom constraint was updated. This represents the last time that the
        /// `CreateCustomConstraint` or `UpdateCustomConstraint` methods were called.
        /// </summary>
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
    /// Defines an organization policy which is used to specify constraints for configurations of Google Cloud
    /// resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV2Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternate")]
        public virtual GoogleCloudOrgpolicyV2AlternatePolicySpec Alternate { get; set; }

        /// <summary>
        /// Dry-run policy. Audit-only policy, can be used to monitor how the policy would have impacted the existing
        /// and future resources if it's enforced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRunSpec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec DryRunSpec { get; set; }

        /// <summary>
        /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This
        /// 'etag' is computed by the server based on the value of other fields, and may be sent on update and delete
        /// requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Immutable. The resource name of the policy. Must be one of the following forms, where `constraint_name` is
        /// the name of the constraint which this policy configures: *
        /// `projects/{project_number}/policies/{constraint_name}` * `folders/{folder_id}/policies/{constraint_name}` *
        /// `organizations/{organization_id}/policies/{constraint_name}` For example,
        /// `projects/123/policies/compute.disableSerialPortAccess`. Note:
        /// `projects/{project_id}/policies/{constraint_name}` is also an acceptable name for API requests, but
        /// responses will return the name using the equivalent project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Basic information about the organization policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual GoogleCloudOrgpolicyV2PolicySpec Spec { get; set; }
    }

    /// <summary>
    /// Defines a Google Cloud policy specification which is used to specify constraints for configurations of Google
    /// Cloud resources.
    /// </summary>
    public class GoogleCloudOrgpolicyV2PolicySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An opaque tag indicating the current version of the policySpec, used for concurrency control. This field is
        /// ignored if used in a `CreatePolicy` request. When the policy is returned from either a `GetPolicy` or a
        /// `ListPolicies` request, this `etag` indicates the version of the current policySpec to use when executing a
        /// read-modify-write loop. When the policy is returned from a `GetEffectivePolicy` request, the `etag` will be
        /// unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Determines the inheritance behavior for this policy. If `inherit_from_parent` is true, policy rules set
        /// higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it
        /// is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can
        /// be set only for policies which configure list constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromParent")]
        public virtual System.Nullable<bool> InheritFromParent { get; set; }

        /// <summary>
        /// Ignores policies set above this resource and restores the `constraint_default` enforcement behavior of the
        /// specific constraint at this resource. This field can be set in policies for either list or boolean
        /// constraints. If set, `rules` must be empty and `inherit_from_parent` must be set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reset")]
        public virtual System.Nullable<bool> Reset { get; set; }

        /// <summary>
        /// In policies for boolean constraints, the following requirements apply: - There must be one and only one
        /// policy rule where condition is unset. - Boolean policy rules with conditions must set `enforced` to the
        /// opposite of the policy rule without a condition. - During policy evaluation, policy rules with conditions
        /// that are true for a target resource take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleCloudOrgpolicyV2PolicySpecPolicyRule> Rules { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The time stamp this was previously updated. This represents the last time a call to
        /// `CreatePolicy` or `UpdatePolicy` was made for that policy.
        /// </summary>
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

    /// <summary>A rule used to express this policy.</summary>
    public class GoogleCloudOrgpolicyV2PolicySpecPolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Setting this to true means that all values are allowed. This field can be set only in policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAll")]
        public virtual System.Nullable<bool> AllowAll { get; set; }

        /// <summary>
        /// A condition which determines whether this rule is used in the evaluation of the policy. When set, the
        /// `expression` field in the `Expr' must include from 1 to 10 subexpressions, joined by the "||" or
        /// "&amp;amp;&amp;amp;" operators. Each subexpression must be of the form
        /// "resource.matchTag('/tag_key_short_name, 'tag_value_short_name')". or "resource.matchTagId('tagKeys/key_id',
        /// 'tagValues/value_id')". where key_name and value_name are the resource names for Label Keys and Values.
        /// These names are available from the Tag Manager Service. An example expression is:
        /// "resource.matchTag('123456789/environment, 'prod')". or "resource.matchTagId('tagKeys/123',
        /// 'tagValues/456')".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Setting this to true means that all values are denied. This field can be set only in policies for list
        /// constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAll")]
        public virtual System.Nullable<bool> DenyAll { get; set; }

        /// <summary>
        /// If `true`, then the policy is enforced. If `false`, then any configuration is acceptable. This field can be
        /// set in policies for boolean constraints, custom constraints and managed constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual System.Nullable<bool> Enforce { get; set; }

        /// <summary>
        /// Optional. Required for managed constraints if parameters are defined. Passes parameter values when policy
        /// enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition.
        /// For example:
        /// ```
        /// { "allowedLocations" : ["us-east1", "us-west1"], "allowAll" : true }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// List of values to be used for this policy rule. This field can be set only in policies for list constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual GoogleCloudOrgpolicyV2PolicySpecPolicyRuleStringValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that holds specific allowed and denied values. This message can define specific values and subtrees of
    /// the Resource Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that are allowed or denied.
    /// This is achieved by using the `under:` and optional `is:` prefixes. The `under:` prefix is used to denote
    /// resource subtree values. The `is:` prefix is used to denote specific values, and is required only if the value
    /// contains a ":". Values prefixed with "is:" are treated the same as values with no prefix. Ancestry subtrees must
    /// be in one of the following formats: - `projects/` (for example, `projects/tokyo-rain-123`) - `folders/` (for
    /// example, `folders/1234`) - `organizations/` (for example, `organizations/1234`) The `supports_under` field of
    /// the associated `Constraint` defines whether ancestry prefixes can be used.
    /// </summary>
    public class GoogleCloudOrgpolicyV2PolicySpecPolicyRuleStringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of values allowed at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>List of values denied at this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>
    /// ListOrgPolicyViolationsPreviewsResponse is the response message for
    /// OrgPolicyViolationsPreviewService.ListOrgPolicyViolationsPreviews.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1ListOrgPolicyViolationsPreviewsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that you can use to retrieve the next page of results. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of OrgPolicyViolationsPreview</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyViolationsPreviews")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview> OrgPolicyViolationsPreviews { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ListOrgPolicyViolationsResponse is the response message for
    /// OrgPolicyViolationsPreviewService.ListOrgPolicyViolations
    /// </summary>
    public class GoogleCloudPolicysimulatorV1ListOrgPolicyViolationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that you can use to retrieve the next page of results. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of OrgPolicyViolations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyViolations")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1OrgPolicyViolation> OrgPolicyViolations { get; set; }

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

    /// <summary>The proposed changes to OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The OrgPolicy CustomConstraint changes to preview violations for. Any existing CustomConstraints
        /// with the same name will be overridden in the simulation. That is, violations will be determined as if all
        /// custom constraints in the overlay were instantiated. Only a single custom_constraint is supported in the
        /// overlay at a time. For evaluating multiple constraints, multiple `GenerateOrgPolicyViolationsPreview`
        /// requests are made, where each request evaluates a single constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1OrgPolicyOverlayCustomConstraintOverlay> CustomConstraints { get; set; }

        /// <summary>
        /// Optional. The OrgPolicy changes to preview violations for. Any existing OrgPolicies with the same name will
        /// be overridden in the simulation. That is, violations will be determined as if all policies in the overlay
        /// were created or updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1OrgPolicyOverlayPolicyOverlay> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change to an OrgPolicy custom constraint.</summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyOverlayCustomConstraintOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The new or updated custom constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraint")]
        public virtual GoogleCloudOrgpolicyV2CustomConstraint CustomConstraint { get; set; }

        /// <summary>Optional. Resource the constraint is attached to. Example: "organization/987654"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraintParent")]
        public virtual string CustomConstraintParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change to an OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyOverlayPolicyOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The new or updated OrgPolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleCloudOrgpolicyV2Policy Policy { get; set; }

        /// <summary>Optional. The parent of the policy we are attaching to. Example: "projects/123456"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyParent")]
        public virtual string PolicyParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OrgPolicyViolation is a resource representing a single resource violating a single OrgPolicy constraint.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The custom constraint being violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraint")]
        public virtual GoogleCloudOrgpolicyV2CustomConstraint CustomConstraint { get; set; }

        /// <summary>Any error encountered during the evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// The name of the `OrgPolicyViolation`. Example:
        /// organizations/my-example-org/locations/global/orgPolicyViolationsPreviews/506a5f7f/orgPolicyViolations/38ce`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The resource violating the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudPolicysimulatorV1ResourceContext Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OrgPolicyViolationsPreview is a resource providing a preview of the violations that will exist if an OrgPolicy
    /// change is made. The list of violations are modeled as child resources and retrieved via a
    /// ListOrgPolicyViolations API call. There are potentially more OrgPolicyViolations than could fit in an embedded
    /// field. Thus, the use of a child resource instead of a field.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreview : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this `OrgPolicyViolationsPreview` was created.</summary>
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
        /// Output only. The names of the constraints against which all `OrgPolicyViolations` were evaluated. If
        /// `OrgPolicyOverlay` only contains `PolicyOverlay` then it contains the name of the configured custom
        /// constraint, applicable to the specified policies. Otherwise it contains the name of the constraint specified
        /// in `CustomConstraintOverlay`. Format:
        /// `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
        /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual System.Collections.Generic.IList<string> CustomConstraints { get; set; }

        /// <summary>
        /// Output only. The resource name of the `OrgPolicyViolationsPreview`. It has the following format:
        /// `organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}`
        /// Example: `organizations/my-example-org/locations/global/orgPolicyViolationsPreviews/506a5f7f`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The proposed changes we are previewing violations for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlay")]
        public virtual GoogleCloudPolicysimulatorV1OrgPolicyOverlay Overlay { get; set; }

        /// <summary>
        /// Output only. A summary of the state of all resources scanned for compliance with the changed OrgPolicy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCounts")]
        public virtual GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreviewResourceCounts ResourceCounts { get; set; }

        /// <summary>Output only. The state of the `OrgPolicyViolationsPreview`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The number of OrgPolicyViolations in this `OrgPolicyViolationsPreview`. This count may differ
        /// from `resource_summary.noncompliant_count` because each OrgPolicyViolation is specific to a resource **and**
        /// constraint. If there are multiple constraints being evaluated (i.e. multiple policies in the overlay), a
        /// single resource may violate multiple constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationsCount")]
        public virtual System.Nullable<int> ViolationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A summary of the state of all resources scanned for compliance with the changed OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1OrgPolicyViolationsPreviewResourceCounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of scanned resources with zero violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliant")]
        public virtual System.Nullable<int> Compliant { get; set; }

        /// <summary>Output only. Number of resources that returned an error when scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Nullable<int> Errors { get; set; }

        /// <summary>Output only. Number of scanned resources with at least one violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noncompliant")]
        public virtual System.Nullable<int> Noncompliant { get; set; }

        /// <summary>
        /// Output only. Number of resources checked for compliance. Must equal: unenforced + noncompliant + compliant +
        /// error
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanned")]
        public virtual System.Nullable<int> Scanned { get; set; }

        /// <summary>
        /// Output only. Number of resources where the constraint was not enforced, i.e. the Policy set `enforced:
        /// false` for that resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unenforced")]
        public virtual System.Nullable<int> Unenforced { get; set; }

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
        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

    /// <summary>
    /// ResourceContext provides the context we know about a resource. It is similar in concept to
    /// google.cloud.asset.v1.Resource, but focuses on the information specifically used by Simulator.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1ResourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ancestry path of the resource in Google Cloud [resource
        /// hierarchy](https://cloud.google.com/resource-manager/docs/cloud-platform-resource-hierarchy), represented as
        /// a list of relative resource names. An ancestry path starts with the closest ancestor in the hierarchy and
        /// ends at root. If the resource is a project, folder, or organization, the ancestry path starts from the
        /// resource itself. Example: `["projects/123456789", "folders/5432", "organizations/1234"]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestors")]
        public virtual System.Collections.Generic.IList<string> Ancestors { get; set; }

        /// <summary>
        /// The asset type of the resource as defined by CAIS. Example: `compute.googleapis.com/Firewall` See [Supported
        /// asset types](https://cloud.google.com/asset-inventory/docs/supported-asset-types) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// The full name of the resource. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1` See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names#full_resource_name) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CreateOrgPolicyViolationsPreviewOperationMetadata is metadata about an OrgPolicyViolationsPreview generations
    /// operation.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1betaCreateOrgPolicyViolationsPreviewOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>Time when the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Total number of resources that need scanning. Should equal resource_scanned + resources_pending
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesFound")]
        public virtual System.Nullable<int> ResourcesFound { get; set; }

        /// <summary>Number of resources still to scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesPending")]
        public virtual System.Nullable<int> ResourcesPending { get; set; }

        /// <summary>Number of resources already scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesScanned")]
        public virtual System.Nullable<int> ResourcesScanned { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request started processing, i.e., when the state was set to RUNNING.</summary>
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

        /// <summary>Output only. The current state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GenerateOrgPolicyViolationsPreviewOperationMetadata is metadata about an OrgPolicyViolationsPreview generations
    /// operation.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1betaGenerateOrgPolicyViolationsPreviewOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _requestTimeRaw;

        private object _requestTime;

        /// <summary>Time when the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTime")]
        public virtual string RequestTimeRaw
        {
            get => _requestTimeRaw;
            set
            {
                _requestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _requestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RequestTimeDateTimeOffset instead.")]
        public virtual object RequestTime
        {
            get => _requestTime;
            set
            {
                _requestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _requestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RequestTimeRaw);
            set => RequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Total number of resources that need scanning. Should equal resource_scanned + resources_pending
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesFound")]
        public virtual System.Nullable<int> ResourcesFound { get; set; }

        /// <summary>Number of resources still to scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesPending")]
        public virtual System.Nullable<int> ResourcesPending { get; set; }

        /// <summary>Number of resources already scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesScanned")]
        public virtual System.Nullable<int> ResourcesScanned { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request started processing, i.e. when the state was set to RUNNING.</summary>
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

        /// <summary>The current state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The proposed changes to OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1betaOrgPolicyOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The OrgPolicy CustomConstraint changes to preview violations for. Any existing CustomConstraints
        /// with the same name will be overridden in the simulation. That is, violations will be determined as if all
        /// custom constraints in the overlay were instantiated. Only a single custom_constraint is supported in the
        /// overlay at a time. For evaluating multiple constraints, multiple `GenerateOrgPolicyViolationsPreview`
        /// requests are made, where each request evaluates a single constraint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1betaOrgPolicyOverlayCustomConstraintOverlay> CustomConstraints { get; set; }

        /// <summary>
        /// Optional. The OrgPolicy changes to preview violations for. Any existing OrgPolicies with the same name will
        /// be overridden in the simulation. That is, violations will be determined as if all policies in the overlay
        /// were created or updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleCloudPolicysimulatorV1betaOrgPolicyOverlayPolicyOverlay> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change to an OrgPolicy custom constraint.</summary>
    public class GoogleCloudPolicysimulatorV1betaOrgPolicyOverlayCustomConstraintOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The new or updated custom constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraint")]
        public virtual GoogleCloudOrgpolicyV2CustomConstraint CustomConstraint { get; set; }

        /// <summary>Optional. Resource the constraint is attached to. Example: "organization/987654"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraintParent")]
        public virtual string CustomConstraintParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A change to an OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1betaOrgPolicyOverlayPolicyOverlay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The new or updated OrgPolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleCloudOrgpolicyV2Policy Policy { get; set; }

        /// <summary>Optional. The parent of the policy we are attaching to. Example: "projects/123456"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyParent")]
        public virtual string PolicyParent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OrgPolicyViolationsPreview is a resource providing a preview of the violations that will exist if an OrgPolicy
    /// change is made. The list of violations are modeled as child resources and retrieved via a
    /// ListOrgPolicyViolations API call. There are potentially more OrgPolicyViolations than could fit in an embedded
    /// field. Thus, the use of a child resource instead of a field.
    /// </summary>
    public class GoogleCloudPolicysimulatorV1betaOrgPolicyViolationsPreview : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this `OrgPolicyViolationsPreview` was created.</summary>
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
        /// Output only. The names of the constraints against which all `OrgPolicyViolations` were evaluated. If
        /// `OrgPolicyOverlay` only contains `PolicyOverlay` then it contains the name of the configured custom
        /// constraint, applicable to the specified policies. Otherwise it contains the name of the constraint specified
        /// in `CustomConstraintOverlay`. Format:
        /// `organizations/{organization_id}/customConstraints/{custom_constraint_id}` Example:
        /// `organizations/123/customConstraints/custom.createOnlyE2TypeVms`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraints")]
        public virtual System.Collections.Generic.IList<string> CustomConstraints { get; set; }

        /// <summary>
        /// Output only. The resource name of the `OrgPolicyViolationsPreview`. It has the following format:
        /// `organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}`
        /// Example: `organizations/my-example-org/locations/global/orgPolicyViolationsPreviews/506a5f7f`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The proposed changes we are previewing violations for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlay")]
        public virtual GoogleCloudPolicysimulatorV1betaOrgPolicyOverlay Overlay { get; set; }

        /// <summary>
        /// Output only. A summary of the state of all resources scanned for compliance with the changed OrgPolicy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCounts")]
        public virtual GoogleCloudPolicysimulatorV1betaOrgPolicyViolationsPreviewResourceCounts ResourceCounts { get; set; }

        /// <summary>Output only. The state of the `OrgPolicyViolationsPreview`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The number of OrgPolicyViolations in this `OrgPolicyViolationsPreview`. This count may differ
        /// from `resource_summary.noncompliant_count` because each OrgPolicyViolation is specific to a resource **and**
        /// constraint. If there are multiple constraints being evaluated (i.e. multiple policies in the overlay), a
        /// single resource may violate multiple constraints.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationsCount")]
        public virtual System.Nullable<int> ViolationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A summary of the state of all resources scanned for compliance with the changed OrgPolicy.</summary>
    public class GoogleCloudPolicysimulatorV1betaOrgPolicyViolationsPreviewResourceCounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of scanned resources with zero violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliant")]
        public virtual System.Nullable<int> Compliant { get; set; }

        /// <summary>Output only. Number of resources that returned an error when scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Nullable<int> Errors { get; set; }

        /// <summary>Output only. Number of scanned resources with at least one violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noncompliant")]
        public virtual System.Nullable<int> Noncompliant { get; set; }

        /// <summary>
        /// Output only. Number of resources checked for compliance. Must equal: unenforced + noncompliant + compliant +
        /// error
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanned")]
        public virtual System.Nullable<int> Scanned { get; set; }

        /// <summary>
        /// Output only. Number of resources where the constraint was not enforced, i.e. the Policy set `enforced:
        /// false` for that resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unenforced")]
        public virtual System.Nullable<int> Unenforced { get; set; }

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
