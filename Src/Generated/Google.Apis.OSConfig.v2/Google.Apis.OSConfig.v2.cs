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

namespace Google.Apis.OSConfig.v2
{
    /// <summary>The OSConfig Service.</summary>
    public class OSConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OSConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OSConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://osconfig.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://osconfig.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "osconfig";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the OS Config API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the OS Config API.</summary>
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

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for OSConfig requests.</summary>
    public abstract class OSConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OSConfigBaseServiceRequest instance.</summary>
        protected OSConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OSConfig parameter list.</summary>
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
                Global = new GlobalResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Global resource.</summary>
            public virtual GlobalResource Global { get; }

            /// <summary>The "global" collection of methods.</summary>
            public class GlobalResource
            {
                private const string Resource = "global";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlobalResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    PolicyOrchestrators = new PolicyOrchestratorsResource(service);
                }

                /// <summary>Gets the PolicyOrchestrators resource.</summary>
                public virtual PolicyOrchestratorsResource PolicyOrchestrators { get; }

                /// <summary>The "policyOrchestrators" collection of methods.</summary>
                public class PolicyOrchestratorsResource
                {
                    private const string Resource = "policyOrchestrators";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PolicyOrchestratorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given folder resource. `name` field of the given
                    /// orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name in the form of: *
                    /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global` *
                    /// `projects/{project_id_or_number}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given folder resource. `name` field of the given
                    /// orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name in the form of: *
                        /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global`
                        /// * `projects/{project_id_or_number}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The logical identifier of the policy orchestrator, with the following
                        /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
                        /// a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be
                        /// unique within the parent.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("policyOrchestratorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PolicyOrchestratorId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^folders/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("policyOrchestratorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "policyOrchestratorId",
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

                    /// <summary>Deletes an existing policy orchestrator resource, parented by a folder.</summary>
                    /// <param name="name">Required. Name of the resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes an existing policy orchestrator resource, parented by a folder.</summary>
                    public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource to be deleted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the policy orchestrator. If an etag is provided and does not
                        /// match the current etag of the policy orchestrator, deletion will be blocked and an ABORTED
                        /// error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^folders/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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

                    /// <summary>Retrieves an existing policy orchestrator, parented by a folder.</summary>
                    /// <param name="name">Required. The resource name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves an existing policy orchestrator, parented by a folder.</summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name.</summary>
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
                                Pattern = @"^folders/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the policy orchestrators under the given parent folder resource.</summary>
                    /// <param name="parent">Required. The parent resource name.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the policy orchestrators under the given parent folder resource.</summary>
                    public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2ListPolicyOrchestratorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^folders/[^/]+/locations/global$",
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

                    /// <summary>Updates an existing policy orchestrator, parented by a folder.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Identifier. In form of *
                    /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing policy orchestrator, parented by a folder.</summary>
                    public class PatchRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Identifier. In form of *
                        /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The list of fields to merge into the existing policy orchestrator. A special ["*"]
                        /// field mask can be used to simply replace the entire resource. Otherwise, for all paths
                        /// referenced in the mask, following merge rules are used: * output only fields are ignored, *
                        /// primitive fields are replaced, * repeated fields are replaced, * map fields are merged key
                        /// by key, * message fields are cleared if not set in the request, otherwise they are merged
                        /// recursively (in particular - message fields set to an empty message has no side effects) If
                        /// field mask (or its paths) is not specified, it is automatically inferred from the request
                        /// using following rules: * primitive fields are listed, if set to a non-default value (as
                        /// there is no way to distinguish between default and unset value), * map and repeated fields
                        /// are listed, * `google.protobuf.Any` fields are listed, * other message fields are traversed
                        /// recursively. Note: implicit mask does not allow clearing fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

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
                                Pattern = @"^folders/[^/]+/locations/global/policyOrchestrators/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.ListOperationsResponse>
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
                            Pattern = @"^folders/[^/]+/locations/[^/]+$",
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
                Global = new GlobalResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Global resource.</summary>
            public virtual GlobalResource Global { get; }

            /// <summary>The "global" collection of methods.</summary>
            public class GlobalResource
            {
                private const string Resource = "global";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlobalResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    PolicyOrchestrators = new PolicyOrchestratorsResource(service);
                }

                /// <summary>Gets the PolicyOrchestrators resource.</summary>
                public virtual PolicyOrchestratorsResource PolicyOrchestrators { get; }

                /// <summary>The "policyOrchestrators" collection of methods.</summary>
                public class PolicyOrchestratorsResource
                {
                    private const string Resource = "policyOrchestrators";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PolicyOrchestratorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given organizations resource. `name` field of the
                    /// given orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name in the form of: *
                    /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global` *
                    /// `projects/{project_id_or_number}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given organizations resource. `name` field of the
                    /// given orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name in the form of: *
                        /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global`
                        /// * `projects/{project_id_or_number}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The logical identifier of the policy orchestrator, with the following
                        /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
                        /// a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be
                        /// unique within the parent.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("policyOrchestratorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PolicyOrchestratorId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^organizations/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("policyOrchestratorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "policyOrchestratorId",
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
                    /// Deletes an existing policy orchestrator resource, parented by an organization.
                    /// </summary>
                    /// <param name="name">Required. Name of the resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes an existing policy orchestrator resource, parented by an organization.
                    /// </summary>
                    public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource to be deleted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the policy orchestrator. If an etag is provided and does not
                        /// match the current etag of the policy orchestrator, deletion will be blocked and an ABORTED
                        /// error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^organizations/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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

                    /// <summary>Retrieves an existing policy orchestrator, parented by an organization.</summary>
                    /// <param name="name">Required. The resource name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves an existing policy orchestrator, parented by an organization.</summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name.</summary>
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
                                Pattern = @"^organizations/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the policy orchestrators under the given parent organization resource.</summary>
                    /// <param name="parent">Required. The parent resource name.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the policy orchestrators under the given parent organization resource.</summary>
                    public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2ListPolicyOrchestratorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^organizations/[^/]+/locations/global$",
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

                    /// <summary>Updates an existing policy orchestrator, parented by an organization.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Identifier. In form of *
                    /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing policy orchestrator, parented by an organization.</summary>
                    public class PatchRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Identifier. In form of *
                        /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The list of fields to merge into the existing policy orchestrator. A special ["*"]
                        /// field mask can be used to simply replace the entire resource. Otherwise, for all paths
                        /// referenced in the mask, following merge rules are used: * output only fields are ignored, *
                        /// primitive fields are replaced, * repeated fields are replaced, * map fields are merged key
                        /// by key, * message fields are cleared if not set in the request, otherwise they are merged
                        /// recursively (in particular - message fields set to an empty message has no side effects) If
                        /// field mask (or its paths) is not specified, it is automatically inferred from the request
                        /// using following rules: * primitive fields are listed, if set to a non-default value (as
                        /// there is no way to distinguish between default and unset value), * map and repeated fields
                        /// are listed, * `google.protobuf.Any` fields are listed, * other message fields are traversed
                        /// recursively. Note: implicit mask does not allow clearing fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

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
                                Pattern = @"^organizations/[^/]+/locations/global/policyOrchestrators/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/operations/[^/]+$",
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
                public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
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
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.ListOperationsResponse>
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
                Global = new GlobalResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Global resource.</summary>
            public virtual GlobalResource Global { get; }

            /// <summary>The "global" collection of methods.</summary>
            public class GlobalResource
            {
                private const string Resource = "global";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlobalResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    PolicyOrchestrators = new PolicyOrchestratorsResource(service);
                }

                /// <summary>Gets the PolicyOrchestrators resource.</summary>
                public virtual PolicyOrchestratorsResource PolicyOrchestrators { get; }

                /// <summary>The "policyOrchestrators" collection of methods.</summary>
                public class PolicyOrchestratorsResource
                {
                    private const string Resource = "policyOrchestrators";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PolicyOrchestratorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given project resource. `name` field of the given
                    /// orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name in the form of: *
                    /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global` *
                    /// `projects/{project_id_or_number}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new policy orchestrator under the given project resource. `name` field of the given
                    /// orchestrator are ignored and instead replaced by a product of `parent` and
                    /// `policy_orchestrator_id`. Orchestrator state field might be only set to `ACTIVE`, `STOPPED` or
                    /// omitted (in which case, the created resource will be in `ACTIVE` state anyway).
                    /// </summary>
                    public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name in the form of: *
                        /// `organizations/{organization_id}/locations/global` * `folders/{folder_id}/locations/global`
                        /// * `projects/{project_id_or_number}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The logical identifier of the policy orchestrator, with the following
                        /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
                        /// a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be
                        /// unique within the parent.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("policyOrchestratorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PolicyOrchestratorId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("policyOrchestratorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "policyOrchestratorId",
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

                    /// <summary>Deletes an existing policy orchestrator resource, parented by a project.</summary>
                    /// <param name="name">Required. Name of the resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes an existing policy orchestrator resource, parented by a project.</summary>
                    public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource to be deleted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the policy orchestrator. If an etag is provided and does not
                        /// match the current etag of the policy orchestrator, deletion will be blocked and an ABORTED
                        /// error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
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

                    /// <summary>Retrieves an existing policy orchestrator, parented by a project.</summary>
                    /// <param name="name">Required. The resource name.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Retrieves an existing policy orchestrator, parented by a project.</summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/global/policyOrchestrators/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the policy orchestrators under the given parent project resource.</summary>
                    /// <param name="parent">Required. The parent resource name.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the policy orchestrators under the given parent project resource.</summary>
                    public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2ListPolicyOrchestratorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/policyOrchestrators";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
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

                    /// <summary>Updates an existing policy orchestrator, parented by a project.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Immutable. Identifier. In form of *
                    /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                    /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing policy orchestrator, parented by a project.</summary>
                    public class PatchRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Immutable. Identifier. In form of *
                        /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
                        /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The list of fields to merge into the existing policy orchestrator. A special ["*"]
                        /// field mask can be used to simply replace the entire resource. Otherwise, for all paths
                        /// referenced in the mask, following merge rules are used: * output only fields are ignored, *
                        /// primitive fields are replaced, * repeated fields are replaced, * map fields are merged key
                        /// by key, * message fields are cleared if not set in the request, otherwise they are merged
                        /// recursively (in particular - message fields set to an empty message has no side effects) If
                        /// field mask (or its paths) is not specified, it is automatically inferred from the request
                        /// using following rules: * primitive fields are listed, if set to a non-default value (as
                        /// there is no way to distinguish between default and unset value), * map and repeated fields
                        /// are listed, * `google.protobuf.Any` fields are listed, * other message fields are traversed
                        /// recursively. Note: implicit mask does not allow clearing fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v2.Data.GoogleCloudOsconfigV2PolicyOrchestrator Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/policyOrchestrators/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v2.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

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
                public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Empty>
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
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.Operation>
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
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v2.Data.ListOperationsResponse>
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
        }
    }
}
namespace Google.Apis.OSConfig.v2.Data
{
    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>
    /// Message encapsulating a value that can be either absolute ("fixed") or relative ("percent") to a value.
    /// </summary>
    public class FixedOrPercent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fixed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual System.Nullable<int> Fixed__ { get; set; }

        /// <summary>
        /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment operation metadata provided by OS policy assignment API methods that return long running
    /// operations.
    /// </summary>
    public class GoogleCloudOsconfigV1OSPolicyAssignmentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS policy assignment API method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethod")]
        public virtual string ApiMethod { get; set; }

        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        private string _rolloutStartTimeRaw;

        private object _rolloutStartTime;

        /// <summary>Rollout start time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStartTime")]
        public virtual string RolloutStartTimeRaw
        {
            get => _rolloutStartTimeRaw;
            set
            {
                _rolloutStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rolloutStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RolloutStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RolloutStartTimeDateTimeOffset instead.")]
        public virtual object RolloutStartTime
        {
            get => _rolloutStartTime;
            set
            {
                _rolloutStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rolloutStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RolloutStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RolloutStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RolloutStartTimeRaw);
            set => RolloutStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>State of the rollout</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        private string _rolloutUpdateTimeRaw;

        private object _rolloutUpdateTime;

        /// <summary>Rollout update time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateTime")]
        public virtual string RolloutUpdateTimeRaw
        {
            get => _rolloutUpdateTimeRaw;
            set
            {
                _rolloutUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rolloutUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RolloutUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RolloutUpdateTimeDateTimeOffset instead.")]
        public virtual object RolloutUpdateTime
        {
            get => _rolloutUpdateTime;
            set
            {
                _rolloutUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rolloutUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RolloutUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RolloutUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RolloutUpdateTimeRaw);
            set => RolloutUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the list policy orchestrator resources.</summary>
    public class GoogleCloudOsconfigV2ListPolicyOrchestratorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The policy orchestrators for the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyOrchestrators")]
        public virtual System.Collections.Generic.IList<GoogleCloudOsconfigV2PolicyOrchestrator> PolicyOrchestrators { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudOsconfigV2OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Represents a resource that is being orchestrated by the policy orchestrator.</summary>
    public class GoogleCloudOsconfigV2OrchestratedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ID of the resource to be used while generating set of affected resources. For UPSERT action the
        /// value is auto-generated during PolicyOrchestrator creation when not set. When the value is set it should
        /// following next restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
        /// a letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within
        /// the project. For DELETE action, ID must be specified explicitly during PolicyOrchestrator creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. OSPolicyAssignment resource to be created, updated or deleted. Name field is ignored and replace
        /// with a generated value. With this field set, orchestrator will perform actions on
        /// `project/{project}/locations/{zone}/osPolicyAssignments/{resource_id}` resources, where `project` and `zone`
        /// pairs come from the expanded scope, and `resource_id` comes from the `resource_id` field of orchestrator
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignmentV1Payload")]
        public virtual OSPolicyAssignment OsPolicyAssignmentV1Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a set of selectors which drive which resources are in scope of policy orchestration.</summary>
    public class GoogleCloudOsconfigV2OrchestrationScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Selectors of the orchestration scope. There is a logical AND between each selector defined. When
        /// there is no explicit `ResourceHierarchySelector` selector specified, the scope is by default bounded to the
        /// parent of the policy orchestrator resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectors")]
        public virtual System.Collections.Generic.IList<GoogleCloudOsconfigV2OrchestrationScopeSelector> Selectors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selector containing locations in scope.</summary>
    public class GoogleCloudOsconfigV2OrchestrationScopeLocationSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Names of the locations in scope. Format: `us-central1-a`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedLocations")]
        public virtual System.Collections.Generic.IList<string> IncludedLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selector containing Cloud Resource Manager resource hierarchy nodes.</summary>
    public class GoogleCloudOsconfigV2OrchestrationScopeResourceHierarchySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Names of the folders in scope. Format: `folders/{folder_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedFolders")]
        public virtual System.Collections.Generic.IList<string> IncludedFolders { get; set; }

        /// <summary>Optional. Names of the projects in scope. Format: `projects/{project_number}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedProjects")]
        public virtual System.Collections.Generic.IList<string> IncludedProjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Selector for the resources in scope of orchestration.</summary>
    public class GoogleCloudOsconfigV2OrchestrationScopeSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selector for selecting locations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationSelector")]
        public virtual GoogleCloudOsconfigV2OrchestrationScopeLocationSelector LocationSelector { get; set; }

        /// <summary>Selector for selecting resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceHierarchySelector")]
        public virtual GoogleCloudOsconfigV2OrchestrationScopeResourceHierarchySelector ResourceHierarchySelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PolicyOrchestrator helps managing project+zone level policy resources (e.g. OS Policy Assignments), by providing
    /// tools to create, update and delete them across projects and locations, at scale. Policy orchestrator functions
    /// as an endless loop. Each iteration orchestrator computes a set of resources that should be affected, then
    /// progressively applies changes to them. If for some reason this set of resources changes over time (e.g. new
    /// projects are added), the future loop iterations will address that. Orchestrator can either upsert or delete
    /// policy resources. For more details, see the description of the `action`, and `orchestrated_resource` fields.
    /// Note that policy orchestrator do not "manage" the resources it creates. Every iteration is independent and only
    /// minimal history of past actions is retained (apart from Cloud Logging). If orchestrator gets deleted, it does
    /// not affect the resources it created in the past. Those will remain where they were. Same applies if projects are
    /// removed from the orchestrator's scope.
    /// </summary>
    public class GoogleCloudOsconfigV2PolicyOrchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Action to be done by the orchestrator in `projects/{project_id}/zones/{zone_id}` locations defined
        /// by the `orchestration_scope`. Allowed values: - `UPSERT` - Orchestrator will create or update target
        /// resources. - `DELETE` - Orchestrator will delete target resources, if they exist
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the policy orchestrator resource was created.</summary>
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

        /// <summary>Optional. Freeform text describing the purpose of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Immutable. Identifier. In form of *
        /// `organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
        /// `folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}` *
        /// `projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Resource to be orchestrated by the policy orchestrator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestratedResource")]
        public virtual GoogleCloudOsconfigV2OrchestratedResource OrchestratedResource { get; set; }

        /// <summary>
        /// Optional. Defines scope for the orchestration, in context of the enclosing PolicyOrchestrator resource.
        /// Scope is expanded into a list of pairs, in which the rollout action will take place. Expansion starts with a
        /// Folder resource parenting the PolicyOrchestrator resource: - All the descendant projects are listed. - List
        /// of project is cross joined with a list of all available zones. - Resulting list of pairs is filtered
        /// according to the selectors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestrationScope")]
        public virtual GoogleCloudOsconfigV2OrchestrationScope OrchestrationScope { get; set; }

        /// <summary>Output only. State of the orchestration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestrationState")]
        public virtual GoogleCloudOsconfigV2PolicyOrchestratorOrchestrationState OrchestrationState { get; set; }

        /// <summary>
        /// Output only. Set to true, if the there are ongoing changes being applied by the orchestrator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Optional. State of the orchestrator. Can be updated to change orchestrator behaviour. Allowed values: -
        /// `ACTIVE` - orchestrator is actively looking for actions to be taken. - `STOPPED` - orchestrator won't make
        /// any changes. Note: There might be more states added in the future. We use string here instead of an enum, to
        /// avoid the need of propagating new states to all the client code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the policy orchestrator resource was last modified.</summary>
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

    /// <summary>Describes the state of a single iteration of the orchestrator.</summary>
    public class GoogleCloudOsconfigV2PolicyOrchestratorIterationState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Error thrown in the wave iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Output only. Number of orchestration actions which failed so far. For more details, query the Cloud Logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedActions")]
        public virtual System.Nullable<long> FailedActions { get; set; }

        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>Output only. Finish time of the wave iteration.</summary>
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

        /// <summary>Output only. Unique identifier of the iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterationId")]
        public virtual string IterationId { get; set; }

        /// <summary>Output only. Overall number of actions done by the orchestrator so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performedActions")]
        public virtual System.Nullable<long> PerformedActions { get; set; }

        /// <summary>Output only. An estimated percentage of the progress. Number between 0 and 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<float> Progress { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Start time of the wave iteration.</summary>
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

        /// <summary>Output only. State of the iteration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the state of the orchestration process.</summary>
    public class GoogleCloudOsconfigV2PolicyOrchestratorOrchestrationState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Current Wave iteration state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentIterationState")]
        public virtual GoogleCloudOsconfigV2PolicyOrchestratorIterationState CurrentIterationState { get; set; }

        /// <summary>Output only. Previous Wave iteration state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousIterationState")]
        public virtual GoogleCloudOsconfigV2PolicyOrchestratorIterationState PreviousIterationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class GoogleCloudOsconfigV2betaOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// This is proto2's version of MessageSet. DEPRECATED: DO NOT USE FOR NEW FIELDS. If you are using editions or
    /// proto2, please make your own extendable messages for your use case. If you are using proto3, please use `Any`
    /// instead. MessageSet was the implementation of extensions for proto1. When proto2 was introduced, extensions were
    /// implemented as a first-class feature. This schema for MessageSet was meant to be a "bridge" solution to migrate
    /// MessageSet-bearing messages from proto1 to proto2. This schema has been open-sourced only to facilitate the
    /// migration of Google products with MessageSet-bearing messages to open-source environments.
    /// </summary>
    public class MessageSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An OS policy defines the desired state configuration for a VM.</summary>
    public class OSPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This flag determines the OS policy compliance status when none of the resource groups within the policy are
        /// applicable for a VM. Set this value to `true` if the policy needs to be reported as compliant even if the
        /// policy has nothing to validate or enforce.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowNoResourceGroupMatch")]
        public virtual System.Nullable<bool> AllowNoResourceGroupMatch { get; set; }

        /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The id of the OS policy with the following restrictions: * Must contain only lowercase letters,
        /// numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a
        /// number or a letter. * Must be unique within the assignment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. Policy mode</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Required. List of resource groups for the policy. For a particular VM, resource groups are evaluated in the
        /// order specified and the first resource group that is applicable is selected and the rest are ignored. If
        /// none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this
        /// policy. This behavior can be toggled by the flag `allow_no_resource_group_match`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroups")]
        public virtual System.Collections.Generic.IList<OSPolicyResourceGroup> ResourceGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted
    /// group of Compute Engine VM instances. An OS policy is used to define the desired state configuration for a
    /// Compute Engine VM instance through a set of configuration resources that provide capabilities such as installing
    /// or removing software packages, or executing a script. For more information about the OS policy resource
    /// definitions and examples, see [OS policy and OS policy
    /// assignment](https://cloud.google.com/compute/docs/os-configuration-management/working-with-os-policies).
    /// </summary>
    public class OSPolicyAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be
        /// assigned OS policies from this revision. For a given OS policy assignment, there is only one revision with a
        /// value of `true` for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseline")]
        public virtual System.Nullable<bool> Baseline { get; set; }

        /// <summary>Output only. Indicates that this revision deletes the OS policy assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// OS policy assignment description. Length of the description is limited to 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The etag for this OS policy assignment. If this is provided on update, it must match the server's etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Required. Filter to select VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual OSPolicyAssignmentInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Resource name. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}` This field is
        /// ignored when you create an OS policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. List of OS policies to be applied to the VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicies")]
        public virtual System.Collections.Generic.IList<OSPolicy> OsPolicies { get; set; }

        /// <summary>
        /// Output only. Indicates that reconciliation is in progress for the revision. This value is `true` when the
        /// `rollout_state` is one of: * IN_PROGRESS * CANCELLING
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        private string _revisionCreateTimeRaw;

        private object _revisionCreateTime;

        /// <summary>Output only. The timestamp that the revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual string RevisionCreateTimeRaw
        {
            get => _revisionCreateTimeRaw;
            set
            {
                _revisionCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _revisionCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RevisionCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RevisionCreateTimeDateTimeOffset instead.")]
        public virtual object RevisionCreateTime
        {
            get => _revisionCreateTime;
            set
            {
                _revisionCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _revisionCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RevisionCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RevisionCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RevisionCreateTimeRaw);
            set => RevisionCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS
        /// policy assignment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// Required. Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1)
        /// OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of
        /// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual OSPolicyAssignmentRollout Rollout { get; set; }

        /// <summary>Output only. OS policy assignment rollout state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        /// <summary>Output only. Server generated unique id for the OS policy assignment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }
    }

    /// <summary>
    /// Filters to select target VMs for an assignment. If more than one filter criteria is specified below, a VM will
    /// be selected if and only if it satisfies all of them.
    /// </summary>
    public class OSPolicyAssignmentInstanceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual System.Nullable<bool> All { get; set; }

        /// <summary>
        /// List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any
        /// of the label sets are applicable for the VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusionLabels")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignmentLabelSet> ExclusionLabels { get; set; }

        /// <summary>
        /// List of label sets used for VM inclusion. If the list has more than one `LabelSet`, the VM is included if
        /// any of the label sets are applicable for the VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusionLabels")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignmentLabelSet> InclusionLabels { get; set; }

        /// <summary>
        /// List of inventories to select VMs. A VM is selected if its inventory data matches at least one of the
        /// following inventories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventories")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignmentInstanceFilterInventory> Inventories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM inventory details.</summary>
    public class OSPolicyAssignmentInstanceFilterInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The OS short name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortName")]
        public virtual string OsShortName { get; set; }

        /// <summary>
        /// The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example,
        /// to match all versions with a major version of `7`, specify the following value for this field `7.*` An empty
        /// string matches all OS versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message representing label set. * A label is a key value pair set for a VM. * A LabelSet is a set of labels. *
    /// Labels within a LabelSet are ANDed. In other words, a LabelSet is applicable for a VM only if it matches all the
    /// labels in the LabelSet. * Example: A LabelSet with 2 labels: `env=prod` and `type=webserver` will only be
    /// applicable for those VMs with both labels present.
    /// </summary>
    public class OSPolicyAssignmentLabelSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified
        /// in this map to be selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment operation metadata provided by OS policy assignment API methods that return long running
    /// operations.
    /// </summary>
    public class OSPolicyAssignmentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS policy assignment API method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethod")]
        public virtual string ApiMethod { get; set; }

        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        private string _rolloutStartTimeRaw;

        private object _rolloutStartTime;

        /// <summary>Rollout start time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStartTime")]
        public virtual string RolloutStartTimeRaw
        {
            get => _rolloutStartTimeRaw;
            set
            {
                _rolloutStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rolloutStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RolloutStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RolloutStartTimeDateTimeOffset instead.")]
        public virtual object RolloutStartTime
        {
            get => _rolloutStartTime;
            set
            {
                _rolloutStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rolloutStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RolloutStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RolloutStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RolloutStartTimeRaw);
            set => RolloutStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>State of the rollout</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        private string _rolloutUpdateTimeRaw;

        private object _rolloutUpdateTime;

        /// <summary>Rollout update time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateTime")]
        public virtual string RolloutUpdateTimeRaw
        {
            get => _rolloutUpdateTimeRaw;
            set
            {
                _rolloutUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _rolloutUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RolloutUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RolloutUpdateTimeDateTimeOffset instead.")]
        public virtual object RolloutUpdateTime
        {
            get => _rolloutUpdateTime;
            set
            {
                _rolloutUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _rolloutUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RolloutUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RolloutUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RolloutUpdateTimeRaw);
            set => RolloutUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message to configure the rollout at the zonal level for the OS policy assignment.</summary>
    public class OSPolicyAssignmentRollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The maximum number (or percentage) of VMs per zone to disrupt at any given moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disruptionBudget")]
        public virtual FixedOrPercent DisruptionBudget { get; set; }

        /// <summary>
        /// Required. This determines the minimum duration of time to wait after the configuration changes are applied
        /// through the current rollout. A VM continues to count towards the `disruption_budget` at least until this
        /// duration of time has passed after configuration changes are applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minWaitDuration")]
        public virtual object MinWaitDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filtering criteria to select VMs based on inventory details.</summary>
    public class OSPolicyInventoryFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The OS short name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortName")]
        public virtual string OsShortName { get; set; }

        /// <summary>
        /// The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example,
        /// to match all versions with a major version of `7`, specify the following value for this field `7.*` An empty
        /// string matches all OS versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An OS policy resource is used to define the desired state configuration and provides a specific functionality
    /// like installing/removing packages, executing a script etc. The system ensures that resources are always in their
    /// desired state by taking necessary actions if they have drifted from their desired state.
    /// </summary>
    public class OSPolicyResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Exec resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exec")]
        public virtual OSPolicyResourceExecResource Exec { get; set; }

        /// <summary>File resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFileResource File { get; set; }

        /// <summary>
        /// Required. The id of the resource with the following restrictions: * Must contain only lowercase letters,
        /// numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a
        /// number or a letter. * Must be unique within the OS policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Package resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkg")]
        public virtual OSPolicyResourcePackageResource Pkg { get; set; }

        /// <summary>Package repository resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual OSPolicyResourceRepositoryResource Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource that allows executing scripts on the VM. The `ExecResource` has 2 stages: `validate` and `enforce`
    /// and both stages accept a script as an argument to execute. When the `ExecResource` is applied by the agent, it
    /// first executes the script in the `validate` stage. The `validate` stage can signal that the `ExecResource` is
    /// already in the desired state by returning an exit code of `100`. If the `ExecResource` is not in the desired
    /// state, it should return an exit code of `101`. Any other exit code returned by this stage is considered an
    /// error. If the `ExecResource` is not in the desired state based on the exit code from the `validate` stage, the
    /// agent proceeds to execute the script from the `enforce` stage. If the `ExecResource` is already in the desired
    /// state, the `enforce` stage will not be run. Similar to `validate` stage, the `enforce` stage should return an
    /// exit code of `100` to indicate that the resource in now in its desired state. Any other exit code is considered
    /// an error. NOTE: An exit code of `100` was chosen over `0` (and `101` vs `1`) to have an explicit indicator of
    /// `in desired state`, `not in desired state` and errors. Because, for example, Powershell will always return an
    /// exit code of `0` unless an `exit` statement is provided in the script. So, for reasons of consistency and being
    /// explicit, exit codes `100` and `101` were chosen.
    /// </summary>
    public class OSPolicyResourceExecResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any
        /// other exit code indicates a failure running enforce.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual OSPolicyResourceExecResourceExec Enforce { get; set; }

        /// <summary>
        /// Required. What to run to validate this resource is in the desired state. An exit code of 100 indicates "in
        /// desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a
        /// failure running validate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validate")]
        public virtual OSPolicyResourceExecResourceExec Validate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A file or script to execute.</summary>
    public class OSPolicyResourceExecResourceExec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional arguments to pass to the source during execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>A remote or local file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFile File { get; set; }

        /// <summary>Required. The script interpreter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; }

        /// <summary>
        /// Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be
        /// recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will
        /// result in this ExecResource being non-compliant. Output file size is limited to 500K bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFilePath")]
        public virtual string OutputFilePath { get; set; }

        /// <summary>An inline script. The size of the script is limited to 32KiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A remote or local file.</summary>
    public class OSPolicyResourceFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum
        /// must be specified. Cloud Storage: An object generation number must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowInsecure")]
        public virtual System.Nullable<bool> AllowInsecure { get; set; }

        /// <summary>A Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcs")]
        public virtual OSPolicyResourceFileGcs Gcs { get; set; }

        /// <summary>A local path within the VM to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPath")]
        public virtual string LocalPath { get; set; }

        /// <summary>A generic remote file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remote")]
        public virtual OSPolicyResourceFileRemote Remote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a file available as a Cloud Storage Object.</summary>
    public class OSPolicyResourceFileGcs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Bucket of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>Generation number of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Required. Name of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a file available via some URI.</summary>
    public class OSPolicyResourceFileRemote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SHA256 checksum of the remote file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Checksum")]
        public virtual string Sha256Checksum { get; set; }

        /// <summary>
        /// Required. URI from which to fetch the object. It should contain both the protocol and path following the
        /// format `{protocol}://{location}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages the state of a file.</summary>
    public class OSPolicyResourceFileResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A a file with this content. The size of the content is limited to 32KiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>A remote or local source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFile File { get; set; }

        /// <summary>Required. The absolute path of the file within the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Consists of three octal digits which represent, in order, the permissions of the owner, group, and other
        /// users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a
        /// three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write
        /// bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples
        /// of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write:
        /// 6 read only: 4
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>Required. Desired state of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource groups provide a mechanism to group OS policy resources. Resource groups enable OS policy authors to
    /// create a single OS policy to be applied to VMs running different operating Systems. When the OS policy is
    /// applied to a target VM, the appropriate resource group within the OS policy is selected based on the `OSFilter`
    /// specified within the resource group.
    /// </summary>
    public class OSPolicyResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of inventory filters for the resource group. The resources in this resource group are applied to the
        /// target VM if it satisfies at least one of the following inventory filters. For example, to apply this
        /// resource group to VMs running either `RHEL` or `CentOS` operating systems, specify 2 items for the list with
        /// following values: inventory_filters[0].os_short_name='rhel' and inventory_filters[1].os_short_name='centos'
        /// If the list is empty, this resource group will be applied to the target VM unconditionally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryFilters")]
        public virtual System.Collections.Generic.IList<OSPolicyInventoryFilter> InventoryFilters { get; set; }

        /// <summary>
        /// Required. List of resources configured for this resource group. The resources are executed in the exact
        /// order specified here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<OSPolicyResource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages a system package.</summary>
    public class OSPolicyResourcePackageResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A package managed by Apt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual OSPolicyResourcePackageResourceAPT Apt { get; set; }

        /// <summary>A deb package file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deb")]
        public virtual OSPolicyResourcePackageResourceDeb Deb { get; set; }

        /// <summary>Required. The desired state the agent should maintain for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredState")]
        public virtual string DesiredState { get; set; }

        /// <summary>A package managed by GooGet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googet")]
        public virtual OSPolicyResourcePackageResourceGooGet Googet { get; set; }

        /// <summary>An MSI package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msi")]
        public virtual OSPolicyResourcePackageResourceMSI Msi { get; set; }

        /// <summary>An rpm package file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rpm")]
        public virtual OSPolicyResourcePackageResourceRPM Rpm { get; set; }

        /// <summary>A package managed by YUM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual OSPolicyResourcePackageResourceYUM Yum { get; set; }

        /// <summary>A package managed by Zypper.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual OSPolicyResourcePackageResourceZypper Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by APT. - install: `apt-get update &amp;amp;&amp;amp; apt-get -y install [name]` - remove:
    /// `apt-get -y remove [name]`
    /// </summary>
    public class OSPolicyResourcePackageResourceAPT : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A deb package file. dpkg packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceDeb : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether dependencies should also be installed. - install when false: `dpkg -i package` - install when true:
        /// `apt-get update &amp;amp;&amp;amp; apt-get -y install package.deb`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullDeps")]
        public virtual System.Nullable<bool> PullDeps { get; set; }

        /// <summary>Required. A deb package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by GooGet. - install: `googet -noconfirm install package` - remove: `googet -noconfirm remove
    /// package`
    /// </summary>
    public class OSPolicyResourcePackageResourceGooGet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An MSI package. MSI packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceMSI : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional properties to use during installation. This should be in the format of Property=Setting. Appended
        /// to the defaults of `ACTION=INSTALL REBOOT=ReallySuppress`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<string> Properties { get; set; }

        /// <summary>Required. The MSI package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An RPM package file. RPM packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceRPM : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether dependencies should also be installed. - install when false: `rpm --upgrade --replacepkgs
        /// package.rpm` - install when true: `yum -y install package.rpm` or `zypper -y install package.rpm`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullDeps")]
        public virtual System.Nullable<bool> PullDeps { get; set; }

        /// <summary>Required. An rpm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by YUM. - install: `yum -y install package` - remove: `yum -y remove package`
    /// </summary>
    public class OSPolicyResourcePackageResourceYUM : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by Zypper. - install: `zypper -y install package` - remove: `zypper -y rm package`
    /// </summary>
    public class OSPolicyResourcePackageResourceZypper : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages a package repository.</summary>
    public class OSPolicyResourceRepositoryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Apt Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual OSPolicyResourceRepositoryResourceAptRepository Apt { get; set; }

        /// <summary>A Goo Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goo")]
        public virtual OSPolicyResourceRepositoryResourceGooRepository Goo { get; set; }

        /// <summary>A Yum Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual OSPolicyResourceRepositoryResourceYumRepository Yum { get; set; }

        /// <summary>A Zypper Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual OSPolicyResourceRepositoryResourceZypperRepository Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single apt package repository. These will be added to a repo file that will be managed at
    /// `/etc/apt/sources.list.d/google_osconfig.list`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceAptRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Type of archive files in this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveType")]
        public virtual string ArchiveType { get; set; }

        /// <summary>Required. List of components for this repository. Must contain at least one item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>Required. Distribution of this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual string Distribution { get; set; }

        /// <summary>
        /// URI of the key file for this repository. The agent maintains a keyring at
        /// `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKey")]
        public virtual string GpgKey { get; set; }

        /// <summary>Required. URI for this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Goo package repository. These are added to a repo file that is managed at
    /// `C:/ProgramData/GooGet/repos/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceGooRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The url of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single yum package repository. These are added to a repo file that is managed at
    /// `/etc/yum.repos.d/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceYumRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the yum config file and also
        /// the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking
        /// for resource conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single zypper package repository. These are added to a repo file that is managed at
    /// `/etc/zypp/repos.d/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceZypperRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the zypper config file and
        /// also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when
        /// checking for GuestPolicy conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

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

    /// <summary>Wire-format for a Status object</summary>
    public class StatusProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional int32 canonical_code = 6;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalCode")]
        public virtual System.Nullable<int> CanonicalCode { get; set; }

        /// <summary>
        /// Numeric code drawn from the space specified below. Often, this is the canonical error space, and code is
        /// drawn from google3/util/task/codes.proto copybara:strip_begin(b/383363683) copybara:strip_end_and_replace
        /// optional int32 code = 1;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Detail message copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional string message = 3;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// message_set associates an arbitrary proto message with the status. copybara:strip_begin(b/383363683)
        /// copybara:strip_end_and_replace optional proto2.bridge.MessageSet message_set = 5;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageSet")]
        public virtual MessageSet MessageSet { get; set; }

        /// <summary>
        /// copybara:strip_begin(b/383363683) Space to which this status belongs copybara:strip_end_and_replace optional
        /// string space = 2; // Space to which this status belongs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
