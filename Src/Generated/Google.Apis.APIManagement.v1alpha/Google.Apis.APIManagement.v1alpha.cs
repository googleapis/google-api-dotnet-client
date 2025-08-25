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

namespace Google.Apis.APIManagement.v1alpha
{
    /// <summary>The APIManagement Service.</summary>
    public class APIManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public APIManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public APIManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://apim.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://apim.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "apim";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the API Management API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the API Management API.</summary>
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

    /// <summary>A base abstract class for APIManagement requests.</summary>
    public abstract class APIManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new APIManagementBaseServiceRequest instance.</summary>
        protected APIManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes APIManagement parameter list.</summary>
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
                ObservationJobs = new ObservationJobsResource(service);
                ObservationSources = new ObservationSourcesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the ObservationJobs resource.</summary>
            public virtual ObservationJobsResource ObservationJobs { get; }

            /// <summary>The "observationJobs" collection of methods.</summary>
            public class ObservationJobsResource
            {
                private const string Resource = "observationJobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ObservationJobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ApiObservations = new ApiObservationsResource(service);
                }

                /// <summary>Gets the ApiObservations resource.</summary>
                public virtual ApiObservationsResource ApiObservations { get; }

                /// <summary>The "apiObservations" collection of methods.</summary>
                public class ApiObservationsResource
                {
                    private const string Resource = "apiObservations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ApiObservationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        ApiOperations = new ApiOperationsResource(service);
                    }

                    /// <summary>Gets the ApiOperations resource.</summary>
                    public virtual ApiOperationsResource ApiOperations { get; }

                    /// <summary>The "apiOperations" collection of methods.</summary>
                    public class ApiOperationsResource
                    {
                        private const string Resource = "apiOperations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ApiOperationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>GetApiOperation retrieves a single ApiOperation by name.</summary>
                        /// <param name="name">
                        /// Required. The name of the ApiOperation to retrieve. Format:
                        /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}/apiOperation/{api_operation}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>GetApiOperation retrieves a single ApiOperation by name.</summary>
                        public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ApiOperation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the ApiOperation to retrieve. Format:
                            /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}/apiOperation/{api_operation}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+/apiObservations/[^/]+/apiOperations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// ListApiOperations gets all ApiOperations for a given project and location and ObservationJob
                        /// and ApiObservation.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of ApiOperations. Format:
                        /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// ListApiOperations gets all ApiOperations for a given project and location and ObservationJob
                        /// and ApiObservation.
                        /// </summary>
                        public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListApiOperationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of ApiOperations. Format:
                            /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. The maximum number of ApiOperations to return. The service may return fewer
                            /// than this value. If unspecified, at most 10 ApiOperations will be returned. The maximum
                            /// value is 1000; values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListApiApiOperations` call. Provide
                            /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListApiApiOperations` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/apiOperations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+/apiObservations/[^/]+$",
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

                    /// <summary>BatchEditTagsApiObservations adds or removes Tags for ApiObservations.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource shared by all ApiObservations being edited. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                    /// </param>
                    public virtual BatchEditTagsRequest BatchEditTags(Google.Apis.APIManagement.v1alpha.Data.BatchEditTagsApiObservationsRequest body, string parent)
                    {
                        return new BatchEditTagsRequest(this.service, body, parent);
                    }

                    /// <summary>BatchEditTagsApiObservations adds or removes Tags for ApiObservations.</summary>
                    public class BatchEditTagsRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.BatchEditTagsApiObservationsResponse>
                    {
                        /// <summary>Constructs a new BatchEditTags request.</summary>
                        public BatchEditTagsRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.BatchEditTagsApiObservationsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource shared by all ApiObservations being edited. Format:
                        /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.APIManagement.v1alpha.Data.BatchEditTagsApiObservationsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchEditTags";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/apiObservations:batchEditTags";

                        /// <summary>Initializes BatchEditTags parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>GetApiObservation retrieves a single ApiObservation by name.</summary>
                    /// <param name="name">
                    /// Required. The name of the ApiObservation to retrieve. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>GetApiObservation retrieves a single ApiObservation by name.</summary>
                    public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ApiObservation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the ApiObservation to retrieve. Format:
                        /// projects/{project}/locations/{location}/observationJobs/{observation_job}/apiObservations/{api_observation}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+/apiObservations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// ListApiObservations gets all ApiObservations for a given project and location and
                    /// ObservationJob.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of ApiObservations. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// ListApiObservations gets all ApiObservations for a given project and location and
                    /// ObservationJob.
                    /// </summary>
                    public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListApiObservationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of ApiObservations. Format:
                        /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of ApiObservations to return. The service may return fewer than
                        /// this value. If unspecified, at most 10 ApiObservations will be returned. The maximum value
                        /// is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListApiObservations` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListApiObservations` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/apiObservations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
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
                /// CreateObservationJob creates a new ObservationJob but does not have any effecton its own. It is a
                /// configuration that can be used in an Observation Job to collect data about existing APIs.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this ObservationJob will be created. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.APIManagement.v1alpha.Data.ObservationJob body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// CreateObservationJob creates a new ObservationJob but does not have any effecton its own. It is a
                /// configuration that can be used in an Observation Job to collect data about existing APIs.
                /// </summary>
                public class CreateRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.ObservationJob body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this ObservationJob will be created. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the Observation Job. This value should be 4-63 characters, and valid
                    /// characters are /a-z-/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("observationJobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ObservationJobId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIManagement.v1alpha.Data.ObservationJob Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/observationJobs";

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
                        RequestParameters.Add("observationJobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "observationJobId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// DeleteObservationJob deletes an ObservationJob. This method will fail if the observation job is
                /// currently being used by any ObservationSource, even if not enabled.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the resource Format:
                /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// DeleteObservationJob deletes an ObservationJob. This method will fail if the observation job is
                /// currently being used by any ObservationSource, even if not enabled.
                /// </summary>
                public class DeleteRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource Format:
                    /// projects/{project}/locations/{location}/observationJobs/{observation_job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Disables the given ObservationJob.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the ObservationJob to disable. Format:
                /// projects/{project}/locations/{location}/observationJobs/{job}
                /// </param>
                public virtual DisableRequest Disable(Google.Apis.APIManagement.v1alpha.Data.DisableObservationJobRequest body, string name)
                {
                    return new DisableRequest(this.service, body, name);
                }

                /// <summary>Disables the given ObservationJob.</summary>
                public class DisableRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Disable request.</summary>
                    public DisableRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.DisableObservationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ObservationJob to disable. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIManagement.v1alpha.Data.DisableObservationJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:disable";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables the given ObservationJob.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the ObservationJob to enable. Format:
                /// projects/{project}/locations/{location}/observationJobs/{job}
                /// </param>
                public virtual EnableRequest Enable(Google.Apis.APIManagement.v1alpha.Data.EnableObservationJobRequest body, string name)
                {
                    return new EnableRequest(this.service, body, name);
                }

                /// <summary>Enables the given ObservationJob.</summary>
                public class EnableRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Enable request.</summary>
                    public EnableRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.EnableObservationJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ObservationJob to enable. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIManagement.v1alpha.Data.EnableObservationJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enable";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:enable";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>GetObservationJob retrieves a single ObservationJob by name.</summary>
                /// <param name="name">
                /// Required. The name of the ObservationJob to retrieve. Format:
                /// projects/{project}/locations/{location}/observationJobs/{job}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>GetObservationJob retrieves a single ObservationJob by name.</summary>
                public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ObservationJob>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ObservationJob to retrieve. Format:
                    /// projects/{project}/locations/{location}/observationJobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>ListObservationJobs gets all ObservationJobs for a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of ObservationJobs. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>ListObservationJobs gets all ObservationJobs for a given project and location.</summary>
                public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListObservationJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of ObservationJobs. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of ObservationJobs to return. The service may return fewer than
                    /// this value. If unspecified, at most 10 ObservationJobs will be returned. The maximum value is
                    /// 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListObservationJobs` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListObservationJobs` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/observationJobs";

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

            /// <summary>Gets the ObservationSources resource.</summary>
            public virtual ObservationSourcesResource ObservationSources { get; }

            /// <summary>The "observationSources" collection of methods.</summary>
            public class ObservationSourcesResource
            {
                private const string Resource = "observationSources";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ObservationSourcesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// CreateObservationSource creates a new ObservationSource but does not affect any deployed
                /// infrastructure. It is a configuration that can be used in an Observation Job to collect data about
                /// APIs running in user's dataplane.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.APIManagement.v1alpha.Data.ObservationSource body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// CreateObservationSource creates a new ObservationSource but does not affect any deployed
                /// infrastructure. It is a configuration that can be used in an Observation Job to collect data about
                /// APIs running in user's dataplane.
                /// </summary>
                public class CreateRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.ObservationSource body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the Observation Source. This value should be 4-63 characters, and
                    /// valid characters are /a-z-/.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("observationSourceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ObservationSourceId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIManagement.v1alpha.Data.ObservationSource Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/observationSources";

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
                        RequestParameters.Add("observationSourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "observationSourceId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// DeleteObservationSource deletes an observation source. This method will fail if the observation
                /// source is currently being used by any ObservationJob, even if not enabled.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the resource Format:
                /// projects/{project}/locations/{location}/observationSources/{source}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// DeleteObservationSource deletes an observation source. This method will fail if the observation
                /// source is currently being used by any ObservationJob, even if not enabled.
                /// </summary>
                public class DeleteRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource Format:
                    /// projects/{project}/locations/{location}/observationSources/{source}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationSources/[^/]+$",
                        });
                    }
                }

                /// <summary>GetObservationSource retrieves a single ObservationSource by name.</summary>
                /// <param name="name">
                /// Required. The name of the ObservationSource to retrieve. Format:
                /// projects/{project}/locations/{location}/observationSources/{source}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>GetObservationSource retrieves a single ObservationSource by name.</summary>
                public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ObservationSource>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ObservationSource to retrieve. Format:
                    /// projects/{project}/locations/{location}/observationSources/{source}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/observationSources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// ListObservationSources gets all ObservationSources for a given project and location.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of ObservationSources. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// ListObservationSources gets all ObservationSources for a given project and location.
                /// </summary>
                public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListObservationSourcesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of ObservationSources. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of ObservationSources to return. The service may return fewer than
                    /// this value. If unspecified, at most 10 ObservationSources will be returned. The maximum value is
                    /// 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListObservationSources` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListObservationSources` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/observationSources";

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
                public virtual CancelRequest Cancel(Google.Apis.APIManagement.v1alpha.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.APIManagement.v1alpha.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.APIManagement.v1alpha.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:cancel";

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
                public class DeleteRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Empty>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Operation>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1alpha/{+name}/operations";

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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Location>
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
                public override string RestPath => "v1alpha/{+name}";

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

            /// <summary>GetEntitlement returns the entitlement for the provided project.</summary>
            /// <param name="name">
            /// Required. The entitlement resource name Format: projects/{project}/locations/{location}/entitlement
            /// </param>
            public virtual GetEntitlementRequest GetEntitlement(string name)
            {
                return new GetEntitlementRequest(this.service, name);
            }

            /// <summary>GetEntitlement returns the entitlement for the provided project.</summary>
            public class GetEntitlementRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.Entitlement>
            {
                /// <summary>Constructs a new GetEntitlement request.</summary>
                public GetEntitlementRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The entitlement resource name Format: projects/{project}/locations/{location}/entitlement
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEntitlement";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}";

                /// <summary>Initializes GetEntitlement parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/entitlement$",
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
            public class ListRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
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
                public override string RestPath => "v1alpha/{+name}/locations";

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

            /// <summary>ListApiObservationTags lists all extant tags on any observation in the given project.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of tags. Format:
            /// projects/{project}/locations/{location}
            /// </param>
            public virtual ListApiObservationTagsRequest ListApiObservationTags(string parent)
            {
                return new ListApiObservationTagsRequest(this.service, parent);
            }

            /// <summary>ListApiObservationTags lists all extant tags on any observation in the given project.</summary>
            public class ListApiObservationTagsRequest : APIManagementBaseServiceRequest<Google.Apis.APIManagement.v1alpha.Data.ListApiObservationTagsResponse>
            {
                /// <summary>Constructs a new ListApiObservationTags request.</summary>
                public ListApiObservationTagsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of tags. Format:
                /// projects/{project}/locations/{location}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of tags to return. The service may return fewer than this value. If
                /// unspecified, at most 10 tags will be returned. The maximum value is 1000; values above 1000 will be
                /// coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListApiObservationTags` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListApiObservationTags` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listApiObservationTags";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}:listApiObservationTags";

                /// <summary>Initializes ListApiObservationTags parameter list.</summary>
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
    }
}
namespace Google.Apis.APIManagement.v1alpha.Data
{
    /// <summary>Message describing ApiObservation object</summary>
    public class ApiObservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of observed API Operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiOperationCount")]
        public virtual System.Nullable<long> ApiOperationCount { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Create time stamp</summary>
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

        /// <summary>The hostname of requests processed for this Observation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        private string _lastEventDetectedTimeRaw;

        private object _lastEventDetectedTime;

        /// <summary>Last event detected time stamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEventDetectedTime")]
        public virtual string LastEventDetectedTimeRaw
        {
            get => _lastEventDetectedTimeRaw;
            set
            {
                _lastEventDetectedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastEventDetectedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastEventDetectedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastEventDetectedTimeDateTimeOffset instead.")]
        public virtual object LastEventDetectedTime
        {
            get => _lastEventDetectedTime;
            set
            {
                _lastEventDetectedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastEventDetectedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastEventDetectedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastEventDetectedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastEventDetectedTimeRaw);
            set => LastEventDetectedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Identifier. Name of resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The IP address (IPv4 or IPv6) of the origin server that the request was sent to. This field can include port
        /// information. Examples: `"192.168.1.1"`, `"10.0.0.1:80"`, `"FE80::0202:B3FF:FE1E:8329"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverIps")]
        public virtual System.Collections.Generic.IList<string> ServerIps { get; set; }

        /// <summary>Location of the Observation Source, for example "us-central1" or "europe-west1."</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocations")]
        public virtual System.Collections.Generic.IList<string> SourceLocations { get; set; }

        /// <summary>Style of ApiObservation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        /// <summary>User-defined tags to organize and sort</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Update time stamp</summary>
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

    /// <summary>Message describing ApiOperation object</summary>
    public class ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences of this API Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        private string _firstSeenTimeRaw;

        private object _firstSeenTime;

        /// <summary>First seen time stamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSeenTime")]
        public virtual string FirstSeenTimeRaw
        {
            get => _firstSeenTimeRaw;
            set
            {
                _firstSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstSeenTimeDateTimeOffset instead.")]
        public virtual object FirstSeenTime
        {
            get => _firstSeenTime;
            set
            {
                _firstSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstSeenTimeRaw);
            set => FirstSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>An HTTP Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpOperation")]
        public virtual HttpOperation HttpOperation { get; set; }

        private string _lastSeenTimeRaw;

        private object _lastSeenTime;

        /// <summary>Last seen time stamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSeenTime")]
        public virtual string LastSeenTimeRaw
        {
            get => _lastSeenTimeRaw;
            set
            {
                _lastSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSeenTimeDateTimeOffset instead.")]
        public virtual object LastSeenTime
        {
            get => _lastSeenTime;
            set
            {
                _lastSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSeenTimeRaw);
            set => LastSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Identifier. Name of resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for requesting batch edit tags for ApiObservations</summary>
    public class BatchEditTagsApiObservationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request message specifying the resources to update. A maximum of 1000 apiObservations can be
        /// modified in a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<EditTagsApiObservationsRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to edit Tags for ApiObservations</summary>
    public class BatchEditTagsApiObservationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ApiObservations that were changed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiObservations")]
        public virtual System.Collections.Generic.IList<ApiObservation> ApiObservations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for disabling an ObservationJob</summary>
    public class DisableObservationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for requesting edit tags for ApiObservation</summary>
    public class EditTagsApiObservationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Identifier of ApiObservation need to be edit tags Format example:
        /// "apigee.googleapis.com|us-west1|443"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiObservationId")]
        public virtual string ApiObservationId { get; set; }

        /// <summary>Required. Tag actions to be applied</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagActions")]
        public virtual System.Collections.Generic.IList<TagAction> TagActions { get; set; }

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

    /// <summary>Message for enabling an ObservationJob</summary>
    public class EnableObservationJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entitlement stores data related to API Observation entitlement for a given project</summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether API Observation is entitled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiObservationEntitled")]
        public virtual System.Nullable<bool> ApiObservationEntitled { get; set; }

        /// <summary>
        /// Project number of associated billing project that has Apigee and Advanced API Security entitled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingProjectNumber")]
        public virtual System.Nullable<long> BillingProjectNumber { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time of the entitlement creation.</summary>
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
        /// Identifier. The entitlement resource name `projects/{project}/locations/{location}/entitlement`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time of the entitlement update.</summary>
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

    /// <summary>The GCLB observation source.</summary>
    public class GclbObservationSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The VPC networks where traffic will be observed. All load balancers within this network will be
        /// observed. Currently, this is limited to only one network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscNetworkConfigs")]
        public virtual System.Collections.Generic.IList<GclbObservationSourcePscNetworkConfig> PscNetworkConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network information for setting up a PSC connection.</summary>
    public class GclbObservationSourcePscNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The VPC network. Format: `projects/{project_id}/global/networks/{network}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Required. The subnetwork in the source region that will be used to connect to the Cloud Load Balancers via
        /// PSC NEGs. Must belong to `network`. Format: projects/{project_id}/regions/{region}/subnetworks/{subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An HTTP-based API Operation, sometimes called a "REST" Operation.</summary>
    public class HttpOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HTTP Method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>Path of the HTTP request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Path params of HttpOperation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathParams")]
        public virtual System.Collections.Generic.IList<HttpOperationPathParam> PathParams { get; set; }

        /// <summary>Query params of HttpOperation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParams")]
        public virtual System.Collections.Generic.IDictionary<string, HttpOperationQueryParam> QueryParams { get; set; }

        /// <summary>Request metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual HttpOperationHttpRequest Request { get; set; }

        /// <summary>Response metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual HttpOperationHttpResponse Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An aggregation of HTTP header occurrences.</summary>
    public class HttpOperationHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences of this Header across transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Data type of header</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Header name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An aggregation of HTTP requests.</summary>
    public class HttpOperationHttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered map from header name to header metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, HttpOperationHeader> Headers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An aggregation of HTTP responses.</summary>
    public class HttpOperationHttpResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered map from header name to header metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, HttpOperationHeader> Headers { get; set; }

        /// <summary>Map of status code to observed count</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCodes")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ResponseCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTP Path parameter.</summary>
    public class HttpOperationPathParam : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data type of path param</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Segment location in the path, 1-indexed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<int> Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An aggregation of HTTP query parameter occurrences.</summary>
    public class HttpOperationQueryParam : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of occurrences of this query parameter across transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Data type of path param</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Name of query param</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing tags</summary>
    public class ListApiObservationTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tags from the specified project</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiObservationTags")]
        public virtual System.Collections.Generic.IList<string> ApiObservationTags { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing ApiObservations</summary>
    public class ListApiObservationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ApiObservation from the specified project and location and ObservationJobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiObservations")]
        public virtual System.Collections.Generic.IList<ApiObservation> ApiObservations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing ApiOperations</summary>
    public class ListApiOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ApiOperations from the specified project and location and ObservationJob and ApiObservation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiOperations")]
        public virtual System.Collections.Generic.IList<ApiOperation> ApiOperations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Message for response to listing ObservationJobs</summary>
    public class ListObservationJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ObservationJob from the specified project and location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationJobs")]
        public virtual System.Collections.Generic.IList<ObservationJob> ObservationJobs { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing ObservationSources</summary>
    public class ListObservationSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ObservationSource from the specified project and location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationSources")]
        public virtual System.Collections.Generic.IList<ObservationSource> ObservationSources { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>A resource that represents a Google Cloud location.</summary>
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

    /// <summary>Message describing ObservationJob object</summary>
    public class ObservationJob : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create time stamp</summary>
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
        /// Identifier. name of resource Format:
        /// projects/{project}/locations/{location}/observationJobs/{observation_job}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. These should be of the same kind of source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>Output only. The observation job state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update time stamp</summary>
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

    /// <summary>Observation source configuration types</summary>
    public class ObservationSource : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create time stamp</summary>
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

        /// <summary>The GCLB observation source</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gclbObservationSource")]
        public virtual GclbObservationSource GclbObservationSource { get; set; }

        /// <summary>Identifier. name of resource For MVP, each region can only have 1 source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The observation source state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update time stamp</summary>
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

    /// <summary>Message for edit tag action</summary>
    public class TagAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Action to be applied</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Required. Tag to be added or removed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
