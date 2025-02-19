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

namespace Google.Apis.Assuredworkloads.v1beta1
{
    /// <summary>The Assuredworkloads Service.</summary>
    public class AssuredworkloadsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AssuredworkloadsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AssuredworkloadsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://assuredworkloads.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://assuredworkloads.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "assuredworkloads";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Assured Workloads API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Assured Workloads API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for Assuredworkloads requests.</summary>
    public abstract class AssuredworkloadsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AssuredworkloadsBaseServiceRequest instance.</summary>
        protected AssuredworkloadsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Assuredworkloads parameter list.</summary>
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
                Operations = new OperationsResource(service);
                Workloads = new WorkloadsResource(service);
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
                public class GetRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleLongrunningOperation>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleLongrunningListOperationsResponse>
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
                    public override string RestPath => "v1beta1/{+name}/operations";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the Workloads resource.</summary>
            public virtual WorkloadsResource Workloads { get; }

            /// <summary>The "workloads" collection of methods.</summary>
            public class WorkloadsResource
            {
                private const string Resource = "workloads";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkloadsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Updates = new UpdatesResource(service);
                    Violations = new ViolationsResource(service);
                }

                /// <summary>Gets the Updates resource.</summary>
                public virtual UpdatesResource Updates { get; }

                /// <summary>The "updates" collection of methods.</summary>
                public class UpdatesResource
                {
                    private const string Resource = "updates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UpdatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>This endpoint creates a new operation to apply the given update.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the update. Format:
                    /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}/updates/{update_id}
                    /// </param>
                    public virtual ApplyRequest Apply(Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateRequest body, string name)
                    {
                        return new ApplyRequest(this.service, body, name);
                    }

                    /// <summary>This endpoint creates a new operation to apply the given update.</summary>
                    public class ApplyRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Apply request.</summary>
                        public ApplyRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the update. Format:
                        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}/updates/{update_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "apply";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:apply";

                        /// <summary>Initializes Apply parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+/updates/[^/]+$",
                            });
                        }
                    }

                    /// <summary>This endpoint lists all updates for the given workload.</summary>
                    /// <param name="parent">
                    /// Required. organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>This endpoint lists all updates for the given workload.</summary>
                    public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ListWorkloadUpdatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Page size. The default value is 20 and the max allowed value is 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token returned from previous request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/updates";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
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

                /// <summary>Gets the Violations resource.</summary>
                public virtual ViolationsResource Violations { get; }

                /// <summary>The "violations" collection of methods.</summary>
                public class ViolationsResource
                {
                    private const string Resource = "violations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ViolationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Acknowledges an existing violation. By acknowledging a violation, users acknowledge the
                    /// existence of a compliance violation in their workload and decide to ignore it due to a valid
                    /// business justification. Acknowledgement is a permanent operation and it cannot be reverted.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the Violation to acknowledge. Format:
                    /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
                    /// </param>
                    public virtual AcknowledgeRequest Acknowledge(Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationRequest body, string name)
                    {
                        return new AcknowledgeRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Acknowledges an existing violation. By acknowledging a violation, users acknowledge the
                    /// existence of a compliance violation in their workload and decide to ignore it due to a valid
                    /// business justification. Acknowledgement is a permanent operation and it cannot be reverted.
                    /// </summary>
                    public class AcknowledgeRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationResponse>
                    {
                        /// <summary>Constructs a new Acknowledge request.</summary>
                        public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Violation to acknowledge. Format:
                        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "acknowledge";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:acknowledge";

                        /// <summary>Initializes Acknowledge parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+/violations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Retrieves Assured Workload Violation based on ID.</summary>
                    /// <param name="name">
                    /// Required. The resource name of the Violation to fetch (ie. Violation.name). Format:
                    /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves Assured Workload Violation based on ID.</summary>
                    public class GetRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Violation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Violation to fetch (ie. Violation.name). Format:
                        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
                        /// </summary>
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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+/violations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the Violations in the AssuredWorkload Environment. Callers may also choose to read across
                    /// multiple Workloads as per [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
                    /// character) as a wildcard character instead of workload-id in the parent. Format
                    /// `organizations/{org_id}/locations/{location}/workloads/-`
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The Workload name. Format
                    /// `organizations/{org_id}/locations/{location}/workloads/{workload}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists the Violations in the AssuredWorkload Environment. Callers may also choose to read across
                    /// multiple Workloads as per [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
                    /// character) as a wildcard character instead of workload-id in the parent. Format
                    /// `organizations/{org_id}/locations/{location}/workloads/-`
                    /// </summary>
                    public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ListViolationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Workload name. Format
                        /// `organizations/{org_id}/locations/{location}/workloads/{workload}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. A custom filter for filtering by the Violations properties.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        private object _intervalEndTime;

                        /// <summary>
                        /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for
                        /// inclusion in the HTTP request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string IntervalEndTimeRaw { get; private set; }

                        /// <summary>
                        /// <seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.
                        /// </summary>
                        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                        public virtual object IntervalEndTime
                        {
                            get => _intervalEndTime;
                            set
                            {
                                IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                _intervalEndTime = value;
                            }
                        }

                        public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                        {
                            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                            set
                            {
                                IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                _intervalEndTime = value;
                            }
                        }

                        private object _intervalStartTime;

                        /// <summary>
                        /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for
                        /// inclusion in the HTTP request.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string IntervalStartTimeRaw { get; private set; }

                        /// <summary>
                        /// <seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.
                        /// </summary>
                        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                        public virtual object IntervalStartTime
                        {
                            get => _intervalStartTime;
                            set
                            {
                                IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                                _intervalStartTime = value;
                            }
                        }

                        public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                        {
                            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                            set
                            {
                                IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                                _intervalStartTime = value;
                            }
                        }

                        /// <summary>Optional. Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. Page token returned from previous request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/violations";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "interval.endTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "interval.startTime",
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

                /// <summary>
                /// Analyzes a hypothetical move of a source resource to a target workload to surface compliance risks.
                /// The analysis is best effort and is not guaranteed to be exhaustive.
                /// </summary>
                /// <param name="target">
                /// Required. The resource ID of the folder-based destination workload. This workload is where the
                /// source resource will hypothetically be moved to. Specify the workload's relative resource name,
                /// formatted as: "organizations/{ORGANIZATION_ID}/locations/{LOCATION_ID}/workloads/{WORKLOAD_ID}" For
                /// example: "organizations/123/locations/us-east1/workloads/assured-workload-2"
                /// </param>
                public virtual AnalyzeWorkloadMoveRequest AnalyzeWorkloadMove(string target)
                {
                    return new AnalyzeWorkloadMoveRequest(this.service, target);
                }

                /// <summary>
                /// Analyzes a hypothetical move of a source resource to a target workload to surface compliance risks.
                /// The analysis is best effort and is not guaranteed to be exhaustive.
                /// </summary>
                public class AnalyzeWorkloadMoveRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1AnalyzeWorkloadMoveResponse>
                {
                    /// <summary>Constructs a new AnalyzeWorkloadMove request.</summary>
                    public AnalyzeWorkloadMoveRequest(Google.Apis.Services.IClientService service, string target) : base(service)
                    {
                        Target = target;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource ID of the folder-based destination workload. This workload is where the
                    /// source resource will hypothetically be moved to. Specify the workload's relative resource name,
                    /// formatted as: "organizations/{ORGANIZATION_ID}/locations/{LOCATION_ID}/workloads/{WORKLOAD_ID}"
                    /// For example: "organizations/123/locations/us-east1/workloads/assured-workload-2"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Target { get; private set; }

                    /// <summary>
                    /// Optional. List of asset types to be analyzed, including and under the source resource. If empty,
                    /// all assets are analyzed. The complete list of asset types is available
                    /// [here](https://cloud.google.com/asset-inventory/docs/supported-asset-types).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("assetTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> AssetTypes { get; set; }

                    /// <summary>
                    /// Optional. Page size. If a value is not specified, the default value of 10 is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The page token from the previous response. It needs to be passed in the second and
                    /// following requests.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// The source type is a project. Specify the project's relative resource name, formatted as either
                    /// a project number or a project ID: "projects/{PROJECT_NUMBER}" or "projects/{PROJECT_ID}" For
                    /// example: "projects/951040570662" when specifying a project number, or "projects/my-project-123"
                    /// when specifying a project ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Project { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "analyzeWorkloadMove";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+target}:analyzeWorkloadMove";

                    /// <summary>Initializes AnalyzeWorkloadMove parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("target", new Google.Apis.Discovery.Parameter
                        {
                            Name = "target",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                        RequestParameters.Add("assetTypes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "assetTypes",
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
                        RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Creates Assured Workload.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the new Workload's parent. Must be of the form
                /// `organizations/{org_id}/locations/{location_id}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates Assured Workload.</summary>
                public class CreateRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the new Workload's parent. Must be of the form
                    /// `organizations/{org_id}/locations/{location_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A identifier associated with the workload and underlying projects which allows for the
                    /// break down of billing costs for a workload. The value provided for the identifier will add a
                    /// label to the workload and contained projects with the identifier as the value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("externalId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExternalId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/workloads";

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
                        RequestParameters.Add("externalId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "externalId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the workload. Make sure that workload's direct children are already in a deleted state,
                /// otherwise the request will fail with a FAILED_PRECONDITION error. In addition to
                /// assuredworkloads.workload.delete permission, the user should also have orgpolicy.policy.set
                /// permission on the deleted folder to remove Assured Workloads OrgPolicies.
                /// </summary>
                /// <param name="name">
                /// Required. The `name` field is used to identify the workload. Format:
                /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes the workload. Make sure that workload's direct children are already in a deleted state,
                /// otherwise the request will fail with a FAILED_PRECONDITION error. In addition to
                /// assuredworkloads.workload.delete permission, the user should also have orgpolicy.policy.set
                /// permission on the deleted folder to remove Assured Workloads OrgPolicies.
                /// </summary>
                public class DeleteRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` field is used to identify the workload. Format:
                    /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The etag of the workload. If this is provided, it must match the server's etag.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// This endpoint enables Assured Workloads service to offer compliance updates for the folder based
                /// assured workload. It sets up an Assured Workloads Service Agent, having permissions to read
                /// compliance controls (for example: Org Policies) applied on the workload. The caller must have
                /// `resourcemanager.folders.getIamPolicy` and `resourcemanager.folders.setIamPolicy` permissions on the
                /// assured workload folder.
                /// </summary>
                /// <param name="name">
                /// Required. The `name` field is used to identify the workload. Format:
                /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                /// </param>
                public virtual EnableComplianceUpdatesRequest EnableComplianceUpdates(string name)
                {
                    return new EnableComplianceUpdatesRequest(this.service, name);
                }

                /// <summary>
                /// This endpoint enables Assured Workloads service to offer compliance updates for the folder based
                /// assured workload. It sets up an Assured Workloads Service Agent, having permissions to read
                /// compliance controls (for example: Org Policies) applied on the workload. The caller must have
                /// `resourcemanager.folders.getIamPolicy` and `resourcemanager.folders.setIamPolicy` permissions on the
                /// assured workload folder.
                /// </summary>
                public class EnableComplianceUpdatesRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1EnableComplianceUpdatesResponse>
                {
                    /// <summary>Constructs a new EnableComplianceUpdates request.</summary>
                    public EnableComplianceUpdatesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` field is used to identify the workload. Format:
                    /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enableComplianceUpdates";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:enableComplianceUpdates";

                    /// <summary>Initializes EnableComplianceUpdates parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                    }
                }

                /// <summary>Enable resource violation monitoring for a workload.</summary>
                /// <param name="name">
                /// Required. The `name` field is used to identify the workload. Format:
                /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                /// </param>
                public virtual EnableResourceMonitoringRequest EnableResourceMonitoring(string name)
                {
                    return new EnableResourceMonitoringRequest(this.service, name);
                }

                /// <summary>Enable resource violation monitoring for a workload.</summary>
                public class EnableResourceMonitoringRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1EnableResourceMonitoringResponse>
                {
                    /// <summary>Constructs a new EnableResourceMonitoring request.</summary>
                    public EnableResourceMonitoringRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `name` field is used to identify the workload. Format:
                    /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enableResourceMonitoring";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:enableResourceMonitoring";

                    /// <summary>Initializes EnableResourceMonitoring parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets Assured Workload associated with a CRM Node</summary>
                /// <param name="name">
                /// Required. The resource name of the Workload to fetch. This is the workloads's relative path in the
                /// API, formatted as "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
                /// For example, "organizations/123/locations/us-east1/workloads/assured-workload-1".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets Assured Workload associated with a CRM Node</summary>
                public class GetRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Workload to fetch. This is the workloads's relative path in
                    /// the API, formatted as
                    /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}". For example,
                    /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
                    /// </summary>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Assured Workloads under a CRM Node.</summary>
                /// <param name="parent">
                /// Required. Parent Resource to list workloads from. Must be of the form
                /// `organizations/{org_id}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Assured Workloads under a CRM Node.</summary>
                public class ListRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1ListWorkloadsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent Resource to list workloads from. Must be of the form
                    /// `organizations/{org_id}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A custom filter for filtering by properties of a workload. At this time, only filtering by
                    /// labels is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token returned from previous request. Page token contains context from previous request.
                    /// Page token needs to be passed in the second and following requests.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/workloads";

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

                /// <summary>
                /// Updates an existing workload. Currently allows updating of workload display_name and labels. For
                /// force updates don't set etag field in the Workload. Only one update operation per workload can be in
                /// progress.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Optional. The resource name of the workload. Format:
                /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an existing workload. Currently allows updating of workload display_name and labels. For
                /// force updates don't set etag field in the Workload. Only one update operation per workload can be in
                /// progress.
                /// </summary>
                public class PatchRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. The resource name of the workload. Format:
                    /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1Workload Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
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
                /// Restrict the list of resources allowed in the Workload environment. The current list of allowed
                /// products can be found at https://cloud.google.com/assured-workloads/docs/supported-products In
                /// addition to assuredworkloads.workload.update permission, the user should also have
                /// orgpolicy.policy.set permission on the folder resource to use this functionality.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the Workload. This is the workloads's relative path in the API,
                /// formatted as "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}". For
                /// example, "organizations/123/locations/us-east1/workloads/assured-workload-1".
                /// </param>
                public virtual RestrictAllowedResourcesRequest RestrictAllowedResources(Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesRequest body, string name)
                {
                    return new RestrictAllowedResourcesRequest(this.service, body, name);
                }

                /// <summary>
                /// Restrict the list of resources allowed in the Workload environment. The current list of allowed
                /// products can be found at https://cloud.google.com/assured-workloads/docs/supported-products In
                /// addition to assuredworkloads.workload.update permission, the user should also have
                /// orgpolicy.policy.set permission on the folder resource to use this functionality.
                /// </summary>
                public class RestrictAllowedResourcesRequest : AssuredworkloadsBaseServiceRequest<Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesResponse>
                {
                    /// <summary>Constructs a new RestrictAllowedResources request.</summary>
                    public RestrictAllowedResourcesRequest(Google.Apis.Services.IClientService service, Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the Workload. This is the workloads's relative path in the API,
                    /// formatted as "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
                    /// For example, "organizations/123/locations/us-east1/workloads/assured-workload-1".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Assuredworkloads.v1beta1.Data.GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restrictAllowedResources";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:restrictAllowedResources";

                    /// <summary>Initializes RestrictAllowedResources parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/workloads/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Assuredworkloads.v1beta1.Data
{
    /// <summary>Request for acknowledging the violation</summary>
    public class GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Acknowledge type of specified violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgeType")]
        public virtual string AcknowledgeType { get; set; }

        /// <summary>Required. Business justification explaining the need for violation acknowledgement</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>
        /// Optional. This field is deprecated and will be removed in future version of the API. Name of the OrgPolicy
        /// which was modified with non-compliant change and resulted in this violation. Format:
        /// projects/{project_number}/policies/{constraint_name} folders/{folder_id}/policies/{constraint_name}
        /// organizations/{organization_id}/policies/{constraint_name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonCompliantOrgPolicy")]
        public virtual string NonCompliantOrgPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for violation acknowledgement</summary>
    public class GoogleCloudAssuredworkloadsV1beta1AcknowledgeViolationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the analysis results for the hypothetical resource move.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1AnalyzeWorkloadMoveResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of analysis results for each asset in scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetMoveAnalyses")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1AssetMoveAnalysis> AssetMoveAnalyses { get; set; }

        /// <summary>The next page token. Is empty if the last page is reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata to give request details of ApplyWorkloadUpdate.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Optional. Output only. The time the operation was created.</summary>
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

        /// <summary>Required. The resource name of the update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateName")]
        public virtual string UpdateName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to apply update to a workload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action to be performed on the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ApplyWorkloadUpdate endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ApplyWorkloadUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The update that was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedUpdate")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadUpdate AppliedUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents move analysis results for an asset.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1AssetMoveAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of eligible analyses performed for the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1MoveAnalysisGroup> AnalysisGroups { get; set; }

        /// <summary>
        /// The full resource name of the asset being analyzed. Example:
        /// //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// Type of the asset being analyzed. Possible values will be among the ones listed
        /// [here](https://cloud.google.com/asset-inventory/docs/supported-asset-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation metadata to give request details of CreateWorkload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1CreateWorkloadOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Compliance controls that should be applied to the resources managed by the workload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Optional. Time when the operation was created.</summary>
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

        /// <summary>Optional. The display name of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The parent of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Optional. Resource properties in the input that are used for creating/customizing workload resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings> ResourceSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for EnableComplianceUpdates endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1EnableComplianceUpdatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for EnableResourceMonitoring endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1EnableResourceMonitoringResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListViolations endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ListViolationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next page token. Returns empty if reached the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Violations under a Workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violations")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1Violation> Violations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of listing the compliance updates per workload with pagination.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ListWorkloadUpdatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next page token. Return empty if reached the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of workload updates for a given workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadUpdates")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadUpdate> WorkloadUpdates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListWorkloads endpoint.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ListWorkloadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The next page token. Return empty if reached the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Workloads under a given parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloads")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1Workload> Workloads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a logical group of checks performed for an asset. If successful, the group contains the analysis
    /// result, otherwise it contains an error with the failure reason.
    /// </summary>
    public class GoogleCloudAssuredworkloadsV1beta1MoveAnalysisGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Result of a successful analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisResult")]
        public virtual GoogleCloudAssuredworkloadsV1beta1MoveAnalysisResult AnalysisResult { get; set; }

        /// <summary>Name of the analysis group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Error details for a failed analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the successful move analysis results for a group.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1MoveAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of blockers. If not resolved, these will result in compliance violations in the target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockers")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1MoveImpact> Blockers { get; set; }

        /// <summary>List of warnings. These are risks that may or may not result in compliance violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1MoveImpact> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the impact of moving the asset to the target.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1MoveImpact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explanation of the impact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This assured workload service object is used to represent the org policy attached to a resource. It servces the
    /// same purpose as the orgpolicy.v2.Policy object but with functionality that is limited to what is supported by
    /// Assured Workloads(e.g. only one rule under one OrgPolicy object, no conditions, etc).
    /// </summary>
    public class GoogleCloudAssuredworkloadsV1beta1OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The constraint name of the OrgPolicy. e.g. "constraints/gcp.resourceLocations".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>
        /// If `inherit` is true, policy rules of the lowest ancestor in the resource hierarchy chain are inherited. If
        /// it is false, policy rules are not inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inherit")]
        public virtual System.Nullable<bool> Inherit { get; set; }

        /// <summary>
        /// Ignores policies set above this resource and restores to the `constraint_default` value. `reset` can only be
        /// true when `rules` is empty and `inherit` is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reset")]
        public virtual System.Nullable<bool> Reset { get; set; }

        /// <summary>Resource that the OrgPolicy attaches to. Format: folders/123" projects/123".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The rule of the OrgPolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual GoogleCloudAssuredworkloadsV1beta1OrgPolicyPolicyRule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule used to express this policy.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1OrgPolicyPolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ListPolicy only when all values are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAll")]
        public virtual System.Nullable<bool> AllowAll { get; set; }

        /// <summary>ListPolicy only when all values are denied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAll")]
        public virtual System.Nullable<bool> DenyAll { get; set; }

        /// <summary>BooleanPolicy only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual System.Nullable<bool> Enforce { get; set; }

        /// <summary>ListPolicy only when custom values are specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual GoogleCloudAssuredworkloadsV1beta1OrgPolicyPolicyRuleStringValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The values allowed for a ListPolicy.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1OrgPolicyPolicyRuleStringValues : Google.Apis.Requests.IDirectResponseSchema
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
    /// Represents an update for an org policy control applied on an Assured Workload resource. The inherited org policy
    /// is not considered.
    /// </summary>
    public class GoogleCloudAssuredworkloadsV1beta1OrgPolicyUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The org policy currently applied on the assured workload resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedPolicy")]
        public virtual GoogleCloudAssuredworkloadsV1beta1OrgPolicy AppliedPolicy { get; set; }

        /// <summary>The suggested org policy that replaces the applied policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedPolicy")]
        public virtual GoogleCloudAssuredworkloadsV1beta1OrgPolicy SuggestedPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for restricting list of available resources in Workload environment.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of restriction for using gcp products in the Workload environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictionType")]
        public virtual string RestrictionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for restricting the list of allowed resources.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1RestrictAllowedResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the update.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1UpdateDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Update to one org policy, e.g. gcp.resourceLocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyUpdate")]
        public virtual GoogleCloudAssuredworkloadsV1beta1OrgPolicyUpdate OrgPolicyUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Workload monitoring Violation.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1Violation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean that indicates if the violation is acknowledged</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledged")]
        public virtual System.Nullable<bool> Acknowledged { get; set; }

        private string _acknowledgementTimeRaw;

        private object _acknowledgementTime;

        /// <summary>
        /// Optional. Timestamp when this violation was acknowledged first. Check exception_contexts to find the last
        /// time the violation was acknowledged when there are more than one violations. This field will be absent when
        /// acknowledged field is marked as false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementTime")]
        public virtual string AcknowledgementTimeRaw
        {
            get => _acknowledgementTimeRaw;
            set
            {
                _acknowledgementTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _acknowledgementTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AcknowledgementTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AcknowledgementTimeDateTimeOffset instead.")]
        public virtual object AcknowledgementTime
        {
            get => _acknowledgementTime;
            set
            {
                _acknowledgementTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _acknowledgementTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AcknowledgementTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AcknowledgementTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AcknowledgementTimeRaw);
            set => AcknowledgementTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Output only. Violation Id of the org-policy violation due to which the resource violation is
        /// caused. Empty for org-policy violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedOrgPolicyViolationId")]
        public virtual string AssociatedOrgPolicyViolationId { get; set; }

        /// <summary>
        /// Output only. Immutable. Audit Log Link for violated resource Format:
        /// https://console.cloud.google.com/logs/query;query={logName}{protoPayload.resourceName}{timeRange}{folder}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogLink")]
        public virtual string AuditLogLink { get; set; }

        private string _beginTimeRaw;

        private object _beginTime;

        /// <summary>Output only. Time of the event which triggered the Violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beginTime")]
        public virtual string BeginTimeRaw
        {
            get => _beginTimeRaw;
            set
            {
                _beginTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _beginTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BeginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BeginTimeDateTimeOffset instead.")]
        public virtual object BeginTime
        {
            get => _beginTime;
            set
            {
                _beginTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _beginTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="BeginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BeginTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BeginTimeRaw);
            set => BeginTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Category under which this violation is mapped. e.g. Location, Service Usage, Access,
        /// Encryption, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. Description for the Violation. e.g. OrgPolicy gcp.resourceLocations has non compliant value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Immutable. Audit Log link to find business justification provided for violation exception.
        /// Format:
        /// https://console.cloud.google.com/logs/query;query={logName}{protoPayload.resourceName}{protoPayload.methodName}{timeRange}{organization}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionAuditLogLink")]
        public virtual string ExceptionAuditLogLink { get; set; }

        /// <summary>Output only. List of all the exception detail added for the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1ViolationExceptionContext> ExceptionContexts { get; set; }

        /// <summary>
        /// Output only. Immutable. Name of the Violation. Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload_id}/violations/{violations_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Immutable. Name of the OrgPolicy which was modified with non-compliant change and resulted this
        /// violation. Format: projects/{project_number}/policies/{constraint_name}
        /// folders/{folder_id}/policies/{constraint_name} organizations/{organization_id}/policies/{constraint_name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonCompliantOrgPolicy")]
        public virtual string NonCompliantOrgPolicy { get; set; }

        /// <summary>
        /// Output only. Immutable. The org-policy-constraint that was incorrectly changed, which resulted in this
        /// violation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyConstraint")]
        public virtual string OrgPolicyConstraint { get; set; }

        /// <summary>
        /// Optional. Output only. Parent project number where resource is present. Empty for org-policy violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentProjectNumber")]
        public virtual string ParentProjectNumber { get; set; }

        /// <summary>Output only. Compliance violation remediation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual GoogleCloudAssuredworkloadsV1beta1ViolationRemediation Remediation { get; set; }

        private string _resolveTimeRaw;

        private object _resolveTime;

        /// <summary>
        /// Output only. Time of the event which fixed the Violation. If the violation is ACTIVE this will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolveTime")]
        public virtual string ResolveTimeRaw
        {
            get => _resolveTimeRaw;
            set
            {
                _resolveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _resolveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ResolveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ResolveTimeDateTimeOffset instead.")]
        public virtual object ResolveTime
        {
            get => _resolveTime;
            set
            {
                _resolveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _resolveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ResolveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ResolveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ResolveTimeRaw);
            set => ResolveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Output only. Name of the resource like //storage.googleapis.com/myprojectxyz-testbucket. Empty for
        /// org-policy violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Optional. Output only. Type of the resource like compute.googleapis.com/Disk, etc. Empty for org-policy
        /// violations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Output only. State of the violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time when the Violation record was updated.</summary>
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

        /// <summary>Output only. Type of the violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationType")]
        public virtual string ViolationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Violation exception detail.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ViolationExceptionContext : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _acknowledgementTimeRaw;

        private object _acknowledgementTime;

        /// <summary>Timestamp when the violation was acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementTime")]
        public virtual string AcknowledgementTimeRaw
        {
            get => _acknowledgementTimeRaw;
            set
            {
                _acknowledgementTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _acknowledgementTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AcknowledgementTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AcknowledgementTimeDateTimeOffset instead.")]
        public virtual object AcknowledgementTime
        {
            get => _acknowledgementTime;
            set
            {
                _acknowledgementTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _acknowledgementTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AcknowledgementTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AcknowledgementTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AcknowledgementTimeRaw);
            set => AcknowledgementTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Business justification provided towards the acknowledgement of the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Name of the user (or service account) who acknowledged the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents remediation guidance to resolve compliance violation for AssuredWorkload</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ViolationRemediation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Values that can resolve the violation For example: for list org policy violations, this will either be the
        /// list of allowed or denied values
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliantValues")]
        public virtual System.Collections.Generic.IList<string> CompliantValues { get; set; }

        /// <summary>Required. Remediation instructions to resolve violations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructions Instructions { get; set; }

        /// <summary>Output only. Reemediation type based on the type of org policy values violated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediationType")]
        public virtual string RemediationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instructions to remediate violation</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Remediation instructions to resolve violation via cloud console</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consoleInstructions")]
        public virtual GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructionsConsole ConsoleInstructions { get; set; }

        /// <summary>Remediation instructions to resolve violation via gcloud cli</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcloudInstructions")]
        public virtual GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructionsGcloud GcloudInstructions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remediation instructions to resolve violation via cloud console</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructionsConsole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional urls for more information about steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalLinks { get; set; }

        /// <summary>Link to console page where violations can be resolved</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consoleUris")]
        public virtual System.Collections.Generic.IList<string> ConsoleUris { get; set; }

        /// <summary>Steps to resolve violation via cloud console</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<string> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remediation instructions to resolve violation via gcloud cli</summary>
    public class GoogleCloudAssuredworkloadsV1beta1ViolationRemediationInstructionsGcloud : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional urls for more information about steps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalLinks")]
        public virtual System.Collections.Generic.IList<string> AdditionalLinks { get; set; }

        /// <summary>Gcloud command to resolve violation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcloudCommands")]
        public virtual System.Collections.Generic.IList<string> GcloudCommands { get; set; }

        /// <summary>Steps to resolve violation via gcloud cli</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<string> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Workload object for managing highly regulated workloads of cloud customers.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The number of updates available for the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableUpdates")]
        public virtual System.Nullable<int> AvailableUpdates { get; set; }

        /// <summary>
        /// Optional. The billing account used for the resources which are direct children of workload. This billing
        /// account is initially associated with the resources created as part of Workload creation. After the initial
        /// creation of these resources, the customer can change the assigned billing account. The resource name has the
        /// form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAccount")]
        public virtual string BillingAccount { get; set; }

        /// <summary>Input only. Immutable. Settings specific to resources needed for CJIS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cjisSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadCJISSettings CjisSettings { get; set; }

        /// <summary>Required. Immutable. Compliance Regime associated with this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRegime")]
        public virtual string ComplianceRegime { get; set; }

        /// <summary>Output only. Count of active Violations in the Workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStatus")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadComplianceStatus ComplianceStatus { get; set; }

        /// <summary>
        /// Output only. Indicates whether the compliance updates feature is enabled for a workload. The compliance
        /// updates feature can be enabled via the EnableComplianceUpdates endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceUpdatesEnabled")]
        public virtual System.Nullable<bool> ComplianceUpdatesEnabled { get; set; }

        /// <summary>
        /// Output only. Urls for services which are compliant for this Assured Workload, but which are currently
        /// disallowed by the ResourceUsageRestriction org policy. Invoke RestrictAllowedResources endpoint to allow
        /// your project developers to use these services in their environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliantButDisallowedServices")]
        public virtual System.Collections.Generic.IList<string> CompliantButDisallowedServices { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Immutable. The Workload creation timestamp.</summary>
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
        /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30
        /// characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example:
        /// My Workload
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Represents the Ekm Provisioning State of the given workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmProvisioningResponse")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadEkmProvisioningResponse EkmProvisioningResponse { get; set; }

        /// <summary>
        /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by
        /// Europe/Canada customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSovereignControls")]
        public virtual System.Nullable<bool> EnableSovereignControls { get; set; }

        /// <summary>
        /// Optional. ETag of the workload, it is calculated on the basis of the Workload contents. It will be used in
        /// Update &amp;amp; Delete operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Input only. Immutable. Settings specific to resources needed for FedRAMP High.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fedrampHighSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampHighSettings FedrampHighSettings { get; set; }

        /// <summary>Input only. Immutable. Settings specific to resources needed for FedRAMP Moderate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fedrampModerateSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampModerateSettings FedrampModerateSettings { get; set; }

        /// <summary>Input only. Immutable. Settings specific to resources needed for IL4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("il4Settings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadIL4Settings Il4Settings { get; set; }

        /// <summary>Output only. Represents the KAJ enrollment state of the given workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kajEnrollmentState")]
        public virtual string KajEnrollmentState { get; set; }

        /// <summary>
        /// Input only. Settings used to create a CMEK crypto key. When set, a project with a KMS CMEK key is
        /// provisioned. This field is deprecated as of Feb 28, 2022. In order to create a Keyring, callers should
        /// specify, ENCRYPTION_KEYS_PROJECT or KEYRING in ResourceSettings.resource_type field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>Optional. Labels applied to the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The resource name of the workload. Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload} Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Partner regime associated with this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partner")]
        public virtual string Partner { get; set; }

        /// <summary>Optional. Permissions granted to the AW Partner SA account for the customer workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerPermissions")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadPartnerPermissions PartnerPermissions { get; set; }

        /// <summary>
        /// Optional. Billing account necessary for purchasing services from Sovereign Partners. This field is required
        /// for creating SIA/PSN/CNTXT partner workloads. The caller should have 'billing.resourceAssociations.create'
        /// IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerServicesBillingAccount")]
        public virtual string PartnerServicesBillingAccount { get; set; }

        /// <summary>
        /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a
        /// folder resource which is a child of the Workload parent. If not specified all resources are created under
        /// the parent organization. Format: folders/{folder_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResourcesParent")]
        public virtual string ProvisionedResourcesParent { get; set; }

        /// <summary>
        /// Output only. Indicates whether resource monitoring is enabled for workload or not. It is true when Resource
        /// feed is subscribed to AWM topic and AWM Service Agent Role is binded to AW Service Account for resource
        /// Assured workload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceMonitoringEnabled")]
        public virtual System.Nullable<bool> ResourceMonitoringEnabled { get; set; }

        /// <summary>
        /// Input only. Resource properties that are used to customize workload resources. These properties (such as
        /// custom project id) will be used to create workload resources if possible. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSettings")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings> ResourceSettings { get; set; }

        /// <summary>
        /// Output only. The resources associated with this workload. These resources will be created when creating the
        /// workload. If any of the projects already exist, the workload creation will fail. Always read only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssuredworkloadsV1beta1WorkloadResourceInfo> Resources { get; set; }

        /// <summary>
        /// Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is
        /// queried during GetWorkload call. In failure cases, user friendly error message is shown in SAA details page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saaEnrollmentResponse")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadSaaEnrollmentResponse SaaEnrollmentResponse { get; set; }

        /// <summary>
        /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value
        /// will be by default True, and if not present will be considered as true. This should only be updated via
        /// updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will
        /// always be true while creating the workload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationNotificationsEnabled")]
        public virtual System.Nullable<bool> ViolationNotificationsEnabled { get; set; }

        /// <summary>Optional. Options to be set for the given created workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadOptions")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadWorkloadOptions WorkloadOptions { get; set; }
    }

    /// <summary>Settings specific to resources needed for CJIS.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadCJISSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the Compliance Status of this workload</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadComplianceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of current resource violations which are not acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgedResourceViolationCount")]
        public virtual System.Nullable<int> AcknowledgedResourceViolationCount { get; set; }

        /// <summary>Number of current orgPolicy violations which are acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgedViolationCount")]
        public virtual System.Nullable<int> AcknowledgedViolationCount { get; set; }

        /// <summary>Number of current resource violations which are acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeResourceViolationCount")]
        public virtual System.Nullable<int> ActiveResourceViolationCount { get; set; }

        /// <summary>Number of current orgPolicy violations which are not acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeViolationCount")]
        public virtual System.Nullable<int> ActiveViolationCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>External key management systems(EKM) Provisioning response</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadEkmProvisioningResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates Ekm provisioning error if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmProvisioningErrorDomain")]
        public virtual string EkmProvisioningErrorDomain { get; set; }

        /// <summary>Detailed error message if Ekm provisioning fails</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmProvisioningErrorMapping")]
        public virtual string EkmProvisioningErrorMapping { get; set; }

        /// <summary>Output only. Indicates Ekm enrollment Provisioning of a given workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmProvisioningState")]
        public virtual string EkmProvisioningState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for FedRAMP High.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampHighSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for FedRAMP Moderate.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadFedrampModerateSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to resources needed for IL4.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadIL4Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Input only. Immutable. Settings used to create a CMEK crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsSettings")]
        public virtual GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings KmsSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to the Key Management Service.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadKMSSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _nextRotationTimeRaw;

        private object _nextRotationTime;

        /// <summary>
        /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a
        /// new version of the crypto key and mark it as the primary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRotationTime")]
        public virtual string NextRotationTimeRaw
        {
            get => _nextRotationTimeRaw;
            set
            {
                _nextRotationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextRotationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextRotationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextRotationTimeDateTimeOffset instead.")]
        public virtual object NextRotationTime
        {
            get => _nextRotationTime;
            set
            {
                _nextRotationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextRotationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextRotationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextRotationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextRotationTimeRaw);
            set => NextRotationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. Input only. Immutable. [next_rotation_time] will be advanced by this period when the Key
        /// Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotationPeriod")]
        public virtual object RotationPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Permissions granted to the AW Partner SA account for the customer workload</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadPartnerPermissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allow partner to view support case details for an AXT log</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTransparencyLogsSupportCaseViewer")]
        public virtual System.Nullable<bool> AccessTransparencyLogsSupportCaseViewer { get; set; }

        /// <summary>Optional. Allow partner to view violation alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assuredWorkloadsMonitoring")]
        public virtual System.Nullable<bool> AssuredWorkloadsMonitoring { get; set; }

        /// <summary>Optional. Allow the partner to view inspectability logs and monitoring violations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLogsViewer")]
        public virtual System.Nullable<bool> DataLogsViewer { get; set; }

        /// <summary>Optional. Allow partner to view access approval logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccessApprover")]
        public virtual System.Nullable<bool> ServiceAccessApprover { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the resources that are children of this Workload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource identifier. For a project this represents project_number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual System.Nullable<long> ResourceId { get; set; }

        /// <summary>Indicates the type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent the custom settings for the resources to be created.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadResourceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-assigned resource display name. If not empty it will be used to create a resource with the specified
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource identifier. For a project this represents project_id. If the project is already taken, the workload
        /// creation will fail. For KeyRing, this represents the keyring_id. For a folder, don't set this value as
        /// folder_id is assigned by Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>
        /// Indicates the type of resource. This field should be specified to correspond the id to the right project
        /// type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Signed Access Approvals (SAA) enrollment response.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadSaaEnrollmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates SAA enrollment setup error if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupErrors")]
        public virtual System.Collections.Generic.IList<string> SetupErrors { get; set; }

        /// <summary>Output only. Indicates SAA enrollment status of a given workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupStatus")]
        public virtual string SetupStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A workload update is a change to the workload's compliance configuration.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time the update was created.</summary>
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

        /// <summary>The details of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual GoogleCloudAssuredworkloadsV1beta1UpdateDetails Details { get; set; }

        /// <summary>
        /// Output only. Immutable. Identifier. Resource name of the WorkloadUpdate. Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/updates/{update}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time the update was last updated.</summary>
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

    /// <summary>Options to be set for the given created workload.</summary>
    public class GoogleCloudAssuredworkloadsV1beta1WorkloadWorkloadOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies type of KAJ Enrollment if provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kajEnrollmentType")]
        public virtual string KajEnrollmentType { get; set; }

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
}
