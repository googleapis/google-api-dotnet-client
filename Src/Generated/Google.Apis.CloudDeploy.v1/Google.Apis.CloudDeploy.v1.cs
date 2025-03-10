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

namespace Google.Apis.CloudDeploy.v1
{
    /// <summary>The CloudDeploy Service.</summary>
    public class CloudDeployService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudDeployService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudDeployService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://clouddeploy.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://clouddeploy.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "clouddeploy";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Deploy API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Deploy API.</summary>
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

    /// <summary>A base abstract class for CloudDeploy requests.</summary>
    public abstract class CloudDeployBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudDeployBaseServiceRequest instance.</summary>
        protected CloudDeployBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudDeploy parameter list.</summary>
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
                CustomTargetTypes = new CustomTargetTypesResource(service);
                DeliveryPipelines = new DeliveryPipelinesResource(service);
                DeployPolicies = new DeployPoliciesResource(service);
                Operations = new OperationsResource(service);
                Targets = new TargetsResource(service);
            }

            /// <summary>Gets the CustomTargetTypes resource.</summary>
            public virtual CustomTargetTypesResource CustomTargetTypes { get; }

            /// <summary>The "customTargetTypes" collection of methods.</summary>
            public class CustomTargetTypesResource
            {
                private const string Resource = "customTargetTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomTargetTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new CustomTargetType in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent collection in which the `CustomTargetType` must be created. The format is
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.CustomTargetType body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new CustomTargetType in a given project and location.</summary>
                public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.CustomTargetType body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent collection in which the `CustomTargetType` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the `CustomTargetType`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customTargetTypeId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CustomTargetTypeId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.CustomTargetType Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customTargetTypes";

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
                        RequestParameters.Add("customTargetTypeId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customTargetTypeId",
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

                /// <summary>Deletes a single CustomTargetType.</summary>
                /// <param name="name">
                /// Required. The name of the `CustomTargetType` to delete. Format must be
                /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single CustomTargetType.</summary>
                public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `CustomTargetType` to delete. Format must be
                    /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, then deleting an already deleted or non-existing `CustomTargetType`
                    /// will succeed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. This checksum is computed by the server based on the value of other fields, and may be
                    /// sent on update and delete requests to ensure the client has an up-to-date value before
                    /// proceeding.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated but no actual change is made.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customTargetTypes/[^/]+$",
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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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

                /// <summary>Gets details of a single CustomTargetType.</summary>
                /// <param name="name">
                /// Required. Name of the `CustomTargetType`. Format must be
                /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single CustomTargetType.</summary>
                public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.CustomTargetType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the `CustomTargetType`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customTargetTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customTargetTypes/[^/]+$",
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

                /// <summary>Lists CustomTargetTypes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent that owns this collection of custom target types. Format must be
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists CustomTargetTypes in a given project and location.</summary>
                public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListCustomTargetTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent that owns this collection of custom target types. Format must be
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter custom target types to be returned. See https://google.aip.dev/160 for more
                    /// details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of `CustomTargetType` objects to return. The service may return
                    /// fewer than this value. If unspecified, at most 50 `CustomTargetType` objects will be returned.
                    /// The maximum value is 1000; values above 1000 will be set to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListCustomTargetTypes` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other provided parameters match the call that
                    /// provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customTargetTypes";

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

                /// <summary>Updates a single CustomTargetType.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the `CustomTargetType`. Format is
                /// `projects/{project}/locations/{location}/customTargetTypes/{customTargetType}`. The
                /// `customTargetType` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDeploy.v1.Data.CustomTargetType body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a single CustomTargetType.</summary>
                public class PatchRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.CustomTargetType body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the `CustomTargetType`. Format is
                    /// `projects/{project}/locations/{location}/customTargetTypes/{customTargetType}`. The
                    /// `customTargetType` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, updating a `CustomTargetType` that does not exist will result in the
                    /// creation of a new `CustomTargetType`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// `CustomTargetType` resource. The fields specified in the update_mask are relative to the
                    /// resource, not the full request. A field will be overwritten if it's in the mask. If the user
                    /// doesn't provide a mask then all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.CustomTargetType Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customTargetTypes/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customTargetTypes/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DeliveryPipelines resource.</summary>
            public virtual DeliveryPipelinesResource DeliveryPipelines { get; }

            /// <summary>The "deliveryPipelines" collection of methods.</summary>
            public class DeliveryPipelinesResource
            {
                private const string Resource = "deliveryPipelines";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeliveryPipelinesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AutomationRuns = new AutomationRunsResource(service);
                    Automations = new AutomationsResource(service);
                    Releases = new ReleasesResource(service);
                }

                /// <summary>Gets the AutomationRuns resource.</summary>
                public virtual AutomationRunsResource AutomationRuns { get; }

                /// <summary>The "automationRuns" collection of methods.</summary>
                public class AutomationRunsResource
                {
                    private const string Resource = "automationRuns";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AutomationRunsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Cancels an AutomationRun. The `state` of the `AutomationRun` after cancelling is `CANCELLED`.
                    /// `CancelAutomationRun` can be called on AutomationRun in the state `IN_PROGRESS` and `PENDING`;
                    /// AutomationRun in a different state returns an `FAILED_PRECONDITION` error.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Name of the `AutomationRun`. Format is
                    /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
                    /// </param>
                    public virtual CancelRequest Cancel(Google.Apis.CloudDeploy.v1.Data.CancelAutomationRunRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Cancels an AutomationRun. The `state` of the `AutomationRun` after cancelling is `CANCELLED`.
                    /// `CancelAutomationRun` can be called on AutomationRun in the state `IN_PROGRESS` and `PENDING`;
                    /// AutomationRun in a different state returns an `FAILED_PRECONDITION` error.
                    /// </summary>
                    public class CancelRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.CancelAutomationRunResponse>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.CancelAutomationRunRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the `AutomationRun`. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDeploy.v1.Data.CancelAutomationRunRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/automationRuns/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single AutomationRun.</summary>
                    /// <param name="name">
                    /// Required. Name of the `AutomationRun`. Format must be
                    /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single AutomationRun.</summary>
                    public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.AutomationRun>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the `AutomationRun`. Format must be
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/automationRuns/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists AutomationRuns in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The parent `Delivery Pipeline`, which owns this collection of automationRuns. Format
                    /// must be `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists AutomationRuns in a given project and location.</summary>
                    public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListAutomationRunsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent `Delivery Pipeline`, which owns this collection of automationRuns.
                        /// Format must be
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter automationRuns to be returned. All fields can be used in the filter.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field to sort by.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of automationRuns to return. The service may return fewer than this
                        /// value. If unspecified, at most 50 automationRuns will be returned. The maximum value is
                        /// 1000; values above 1000 will be set to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListAutomationRuns` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other provided parameters match the call that
                        /// provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/automationRuns";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
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
                }

                /// <summary>Gets the Automations resource.</summary>
                public virtual AutomationsResource Automations { get; }

                /// <summary>The "automations" collection of methods.</summary>
                public class AutomationsResource
                {
                    private const string Resource = "automations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AutomationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new Automation in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent collection in which the `Automation` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.Automation body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new Automation in a given project and location.</summary>
                    public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Automation body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent collection in which the `Automation` must be created. The format is
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. ID of the `Automation`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("automationId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AutomationId { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server knows to ignore the request if it has already been completed.
                        /// The server guarantees that for at least 60 minutes after the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. If set to true, the request is validated and the user is provided with an expected
                        /// result, but no actual change is made.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDeploy.v1.Data.Automation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/automations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                            });
                            RequestParameters.Add("automationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "automationId",
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

                    /// <summary>Deletes a single Automation resource.</summary>
                    /// <param name="name">
                    /// Required. The name of the `Automation` to delete. The format is
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single Automation resource.</summary>
                    public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the `Automation` to delete. The format is
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, then deleting an already deleted or non-existing `Automation` will
                        /// succeed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Optional. The weak etag of the request. This checksum is computed by the server based on the
                        /// value of other fields, and may be sent on update and delete requests to ensure the client
                        /// has an up-to-date value before proceeding.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server knows to ignore the request if it has already been completed.
                        /// The server guarantees that for at least 60 minutes after the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. If set, validate the request and verify whether the resource exists, but do not
                        /// actually post it.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/automations/[^/]+$",
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
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
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

                    /// <summary>Gets details of a single Automation.</summary>
                    /// <param name="name">
                    /// Required. Name of the `Automation`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single Automation.</summary>
                    public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Automation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the `Automation`. Format must be
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/automations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Automations in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The parent `Delivery Pipeline`, which owns this collection of automations. Format must
                    /// be `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Automations in a given project and location.</summary>
                    public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListAutomationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent `Delivery Pipeline`, which owns this collection of automations. Format
                        /// must be `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter automations to be returned. All fields can be used in the filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field to sort by.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of automations to return. The service may return fewer than this value.
                        /// If unspecified, at most 50 automations will be returned. The maximum value is 1000; values
                        /// above 1000 will be set to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListAutomations` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other provided parameters match the call that provided
                        /// the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/automations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
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

                    /// <summary>Updates the parameters of a single Automation resource.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Name of the `Automation`. Format is
                    /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudDeploy.v1.Data.Automation body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single Automation resource.</summary>
                    public class PatchRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Automation body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Name of the `Automation`. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, updating a `Automation` that does not exist will result in the
                        /// creation of a new `Automation`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server knows to ignore the request if it has already been completed.
                        /// The server guarantees that for at least 60 minutes after the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                        /// `Automation` resource. The fields specified in the update_mask are relative to the resource,
                        /// not the full request. A field will be overwritten if it's in the mask. If the user doesn't
                        /// provide a mask then all fields are overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. If set to true, the request is validated and the user is provided with an expected
                        /// result, but no actual change is made.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDeploy.v1.Data.Automation Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/automations/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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

                /// <summary>Gets the Releases resource.</summary>
                public virtual ReleasesResource Releases { get; }

                /// <summary>The "releases" collection of methods.</summary>
                public class ReleasesResource
                {
                    private const string Resource = "releases";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReleasesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Rollouts = new RolloutsResource(service);
                    }

                    /// <summary>Gets the Rollouts resource.</summary>
                    public virtual RolloutsResource Rollouts { get; }

                    /// <summary>The "rollouts" collection of methods.</summary>
                    public class RolloutsResource
                    {
                        private const string Resource = "rollouts";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public RolloutsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            JobRuns = new JobRunsResource(service);
                        }

                        /// <summary>Gets the JobRuns resource.</summary>
                        public virtual JobRunsResource JobRuns { get; }

                        /// <summary>The "jobRuns" collection of methods.</summary>
                        public class JobRunsResource
                        {
                            private const string Resource = "jobRuns";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public JobRunsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Gets details of a single JobRun.</summary>
                            /// <param name="name">
                            /// Required. Name of the `JobRun`. Format must be
                            /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
                            /// </param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(this.service, name);
                            }

                            /// <summary>Gets details of a single JobRun.</summary>
                            public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.JobRun>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Name of the `JobRun`. Format must be
                                /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+/jobRuns/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>Lists JobRuns in a given project and location.</summary>
                            /// <param name="parent">
                            /// Required. The `Rollout` which owns this collection of `JobRun` objects.
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(this.service, parent);
                            }

                            /// <summary>Lists JobRuns in a given project and location.</summary>
                            public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListJobRunsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The `Rollout` which owns this collection of `JobRun` objects.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// Optional. Filter results to be returned. See https://google.aip.dev/160 for more
                                /// details.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string Filter { get; set; }

                                /// <summary>
                                /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more
                                /// details.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string OrderBy { get; set; }

                                /// <summary>
                                /// Optional. The maximum number of `JobRun` objects to return. The service may return
                                /// fewer than this value. If unspecified, at most 50 `JobRun` objects will be returned.
                                /// The maximum value is 1000; values above 1000 will be set to 1000.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>
                                /// Optional. A page token, received from a previous `ListJobRuns` call. Provide this to
                                /// retrieve the subsequent page. When paginating, all other provided parameters match
                                /// the call that provided the page token.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/jobRuns";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
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

                            /// <summary>Terminates a Job Run in a given project and location.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">
                            /// Required. Name of the `JobRun`. Format must be
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
                            /// </param>
                            public virtual TerminateRequest Terminate(Google.Apis.CloudDeploy.v1.Data.TerminateJobRunRequest body, string name)
                            {
                                return new TerminateRequest(this.service, body, name);
                            }

                            /// <summary>Terminates a Job Run in a given project and location.</summary>
                            public class TerminateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.TerminateJobRunResponse>
                            {
                                /// <summary>Constructs a new Terminate request.</summary>
                                public TerminateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.TerminateJobRunRequest body, string name) : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Name of the `JobRun`. Format must be
                                /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.CloudDeploy.v1.Data.TerminateJobRunRequest Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "terminate";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+name}:terminate";

                                /// <summary>Initializes Terminate parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "name",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+/jobRuns/[^/]+$",
                                    });
                                }
                            }
                        }

                        /// <summary>Advances a Rollout in a given project and location.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. Name of the Rollout. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                        /// </param>
                        public virtual AdvanceRequest Advance(Google.Apis.CloudDeploy.v1.Data.AdvanceRolloutRequest body, string name)
                        {
                            return new AdvanceRequest(this.service, body, name);
                        }

                        /// <summary>Advances a Rollout in a given project and location.</summary>
                        public class AdvanceRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.AdvanceRolloutResponse>
                        {
                            /// <summary>Constructs a new Advance request.</summary>
                            public AdvanceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.AdvanceRolloutRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the Rollout. Format is
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.AdvanceRolloutRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "advance";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:advance";

                            /// <summary>Initializes Advance parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Approves a Rollout.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. Name of the Rollout. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                        /// </param>
                        public virtual ApproveRequest Approve(Google.Apis.CloudDeploy.v1.Data.ApproveRolloutRequest body, string name)
                        {
                            return new ApproveRequest(this.service, body, name);
                        }

                        /// <summary>Approves a Rollout.</summary>
                        public class ApproveRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ApproveRolloutResponse>
                        {
                            /// <summary>Constructs a new Approve request.</summary>
                            public ApproveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.ApproveRolloutRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the Rollout. Format is
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.ApproveRolloutRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Cancels a Rollout in a given project and location.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. Name of the Rollout. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                        /// </param>
                        public virtual CancelRequest Cancel(Google.Apis.CloudDeploy.v1.Data.CancelRolloutRequest body, string name)
                        {
                            return new CancelRequest(this.service, body, name);
                        }

                        /// <summary>Cancels a Rollout in a given project and location.</summary>
                        public class CancelRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.CancelRolloutResponse>
                        {
                            /// <summary>Constructs a new Cancel request.</summary>
                            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.CancelRolloutRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the Rollout. Format is
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.CancelRolloutRequest Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Creates a new Rollout in a given project and location.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent collection in which the `Rollout` must be created. The format is
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.Rollout body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>Creates a new Rollout in a given project and location.</summary>
                        public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Rollout body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent collection in which the `Rollout` must be created. The format is
                            /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Deploy policies to override. Format is
                            /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("overrideDeployPolicy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> OverrideDeployPolicy { get; set; }

                            /// <summary>
                            /// Optional. A request ID to identify requests. Specify a unique request ID so that if you
                            /// must retry your request, the server knows to ignore the request if it has already been
                            /// completed. The server guarantees that for at least 60 minutes after the first request.
                            /// For example, consider a situation where you make an initial request and the request
                            /// times out. If you make the request again with the same request ID, the server can check
                            /// if original operation with the same request ID was received, and if so, will ignore the
                            /// second request. This prevents clients from accidentally creating duplicate commitments.
                            /// The request ID must be a valid UUID with the exception that zero UUID is not supported
                            /// (00000000-0000-0000-0000-000000000000).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RequestId { get; set; }

                            /// <summary>Required. ID of the `Rollout`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("rolloutId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string RolloutId { get; set; }

                            /// <summary>
                            /// Optional. The starting phase ID for the `Rollout`. If empty the `Rollout` will start at
                            /// the first phase.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("startingPhaseId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string StartingPhaseId { get; set; }

                            /// <summary>
                            /// Optional. If set to true, the request is validated and the user is provided with an
                            /// expected result, but no actual change is made.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.Rollout Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/rollouts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+$",
                                });
                                RequestParameters.Add("overrideDeployPolicy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "overrideDeployPolicy",
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
                                RequestParameters.Add("rolloutId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "rolloutId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("startingPhaseId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "startingPhaseId",
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

                        /// <summary>Gets details of a single Rollout.</summary>
                        /// <param name="name">
                        /// Required. Name of the `Rollout`. Format must be
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single Rollout.</summary>
                        public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Rollout>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the `Rollout`. Format must be
                            /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Ignores the specified Job in a Rollout.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="rollout">
                        /// Required. Name of the Rollout. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                        /// </param>
                        public virtual IgnoreJobRequest IgnoreJob(Google.Apis.CloudDeploy.v1.Data.IgnoreJobRequest body, string rollout)
                        {
                            return new IgnoreJobRequest(this.service, body, rollout);
                        }

                        /// <summary>Ignores the specified Job in a Rollout.</summary>
                        public class IgnoreJobRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.IgnoreJobResponse>
                        {
                            /// <summary>Constructs a new IgnoreJob request.</summary>
                            public IgnoreJobRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.IgnoreJobRequest body, string rollout) : base(service)
                            {
                                Rollout = rollout;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the Rollout. Format is
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("rollout", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Rollout { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.IgnoreJobRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "ignoreJob";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+rollout}:ignoreJob";

                            /// <summary>Initializes IgnoreJob parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("rollout", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "rollout",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists Rollouts in a given project and location.</summary>
                        /// <param name="parent">
                        /// Required. The `Release` which owns this collection of `Rollout` objects.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists Rollouts in a given project and location.</summary>
                        public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListRolloutsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The `Release` which owns this collection of `Rollout` objects.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Filter rollouts to be returned. See https://google.aip.dev/160 for more
                            /// details.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more details.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. The maximum number of `Rollout` objects to return. The service may return
                            /// fewer than this value. If unspecified, at most 50 `Rollout` objects will be returned.
                            /// The maximum value is 1000; values above 1000 will be set to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. A page token, received from a previous `ListRollouts` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other provided parameters match the
                            /// call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/rollouts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+$",
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

                        /// <summary>Retries the specified Job in a Rollout.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="rollout">
                        /// Required. Name of the Rollout. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                        /// </param>
                        public virtual RetryJobRequest RetryJob(Google.Apis.CloudDeploy.v1.Data.RetryJobRequest body, string rollout)
                        {
                            return new RetryJobRequest(this.service, body, rollout);
                        }

                        /// <summary>Retries the specified Job in a Rollout.</summary>
                        public class RetryJobRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.RetryJobResponse>
                        {
                            /// <summary>Constructs a new RetryJob request.</summary>
                            public RetryJobRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.RetryJobRequest body, string rollout) : base(service)
                            {
                                Rollout = rollout;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the Rollout. Format is
                            /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("rollout", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Rollout { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudDeploy.v1.Data.RetryJobRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "retryJob";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+rollout}:retryJob";

                            /// <summary>Initializes RetryJob parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("rollout", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "rollout",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+/rollouts/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Abandons a Release in the Delivery Pipeline.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Name of the Release. Format is
                    /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
                    /// </param>
                    public virtual AbandonRequest Abandon(Google.Apis.CloudDeploy.v1.Data.AbandonReleaseRequest body, string name)
                    {
                        return new AbandonRequest(this.service, body, name);
                    }

                    /// <summary>Abandons a Release in the Delivery Pipeline.</summary>
                    public class AbandonRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.AbandonReleaseResponse>
                    {
                        /// <summary>Constructs a new Abandon request.</summary>
                        public AbandonRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.AbandonReleaseRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the Release. Format is
                        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDeploy.v1.Data.AbandonReleaseRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "abandon";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:abandon";

                        /// <summary>Initializes Abandon parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Creates a new Release in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent collection in which the `Release` is created. The format is
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.Release body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new Release in a given project and location.</summary>
                    public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Release body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent collection in which the `Release` is created. The format is
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Deploy policies to override. Format is
                        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("overrideDeployPolicy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> OverrideDeployPolicy { get; set; }

                        /// <summary>Required. ID of the `Release`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("releaseId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReleaseId { get; set; }

                        /// <summary>
                        /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                        /// retry your request, the server knows to ignore the request if it has already been completed.
                        /// The server guarantees that for at least 60 minutes after the first request. For example,
                        /// consider a situation where you make an initial request and the request times out. If you
                        /// make the request again with the same request ID, the server can check if original operation
                        /// with the same request ID was received, and if so, will ignore the second request. This
                        /// prevents clients from accidentally creating duplicate commitments. The request ID must be a
                        /// valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>
                        /// Optional. If set to true, the request is validated and the user is provided with an expected
                        /// result, but no actual change is made.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudDeploy.v1.Data.Release Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/releases";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                            });
                            RequestParameters.Add("overrideDeployPolicy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "overrideDeployPolicy",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("releaseId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "releaseId",
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

                    /// <summary>Gets details of a single Release.</summary>
                    /// <param name="name">
                    /// Required. Name of the `Release`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single Release.</summary>
                    public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Release>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the `Release`. Format must be
                        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+/releases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Releases in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Releases in a given project and location.</summary>
                    public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListReleasesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter releases to be returned. See https://google.aip.dev/160 for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of `Release` objects to return. The service may return fewer
                        /// than this value. If unspecified, at most 50 `Release` objects will be returned. The maximum
                        /// value is 1000; values above 1000 will be set to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListReleases` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other provided parameters match the call
                        /// that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/releases";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
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
                }

                /// <summary>Creates a new DeliveryPipeline in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent collection in which the `DeliveryPipeline` must be created. The format is
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new DeliveryPipeline in a given project and location.</summary>
                public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent collection in which the `DeliveryPipeline` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the `DeliveryPipeline`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("deliveryPipelineId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeliveryPipelineId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deliveryPipelines";

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
                        RequestParameters.Add("deliveryPipelineId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deliveryPipelineId",
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

                /// <summary>Deletes a single DeliveryPipeline.</summary>
                /// <param name="name">
                /// Required. The name of the `DeliveryPipeline` to delete. The format is
                /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single DeliveryPipeline.</summary>
                public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `DeliveryPipeline` to delete. The format is
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, then deleting an already deleted or non-existing `DeliveryPipeline`
                    /// will succeed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. This checksum is computed by the server based on the value of other fields, and may be
                    /// sent on update and delete requests to ensure the client has an up-to-date value before
                    /// proceeding.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. If set to true, all child resources under this pipeline will also be deleted.
                    /// Otherwise, the request will only work if the pipeline has no child resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not actually post it.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
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
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
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

                /// <summary>Gets details of a single DeliveryPipeline.</summary>
                /// <param name="name">
                /// Required. Name of the `DeliveryPipeline`. Format must be
                /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single DeliveryPipeline.</summary>
                public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the `DeliveryPipeline`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
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

                /// <summary>Lists DeliveryPipelines in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of pipelines. Format must be
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists DeliveryPipelines in a given project and location.</summary>
                public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListDeliveryPipelinesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of pipelines. Format must be
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filter pipelines to be returned. See https://google.aip.dev/160 for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of pipelines to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 pipelines will be returned. The maximum value is 1000; values above 1000
                    /// will be set to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListDeliveryPipelines` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other provided parameters match the call that provided
                    /// the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deliveryPipelines";

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

                /// <summary>Updates the parameters of a single DeliveryPipeline.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the `DeliveryPipeline`. Format is
                /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}`. The
                /// `deliveryPipeline` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single DeliveryPipeline.</summary>
                public class PatchRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the `DeliveryPipeline`. Format is
                    /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}`. The
                    /// `deliveryPipeline` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, updating a `DeliveryPipeline` that does not exist will result in the
                    /// creation of a new `DeliveryPipeline`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// `DeliveryPipeline` resource. The fields specified in the update_mask are relative to the
                    /// resource, not the full request. A field will be overwritten if it's in the mask. If the user
                    /// doesn't provide a mask then all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.DeliveryPipeline Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>Creates a `Rollout` to roll back the specified target.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be created. The format is
                /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                /// </param>
                public virtual RollbackTargetRequest RollbackTarget(Google.Apis.CloudDeploy.v1.Data.RollbackTargetRequest body, string name)
                {
                    return new RollbackTargetRequest(this.service, body, name);
                }

                /// <summary>Creates a `Rollout` to roll back the specified target.</summary>
                public class RollbackTargetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.RollbackTargetResponse>
                {
                    /// <summary>Constructs a new RollbackTarget request.</summary>
                    public RollbackTargetRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.RollbackTargetRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.RollbackTargetRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollbackTarget";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:rollbackTarget";

                    /// <summary>Initializes RollbackTarget parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deliveryPipelines/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DeployPolicies resource.</summary>
            public virtual DeployPoliciesResource DeployPolicies { get; }

            /// <summary>The "deployPolicies" collection of methods.</summary>
            public class DeployPoliciesResource
            {
                private const string Resource = "deployPolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeployPoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new DeployPolicy in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent collection in which the `DeployPolicy` must be created. The format is
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.DeployPolicy body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new DeployPolicy in a given project and location.</summary>
                public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.DeployPolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent collection in which the `DeployPolicy` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the `DeployPolicy`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("deployPolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeployPolicyId { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.DeployPolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deployPolicies";

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
                        RequestParameters.Add("deployPolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "deployPolicyId",
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

                /// <summary>Deletes a single DeployPolicy.</summary>
                /// <param name="name">
                /// Required. The name of the `DeployPolicy` to delete. The format is
                /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single DeployPolicy.</summary>
                public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `DeployPolicy` to delete. The format is
                    /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, then deleting an already deleted or non-existing `DeployPolicy` will
                    /// succeed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. This checksum is computed by the server based on the value of other fields, and may be
                    /// sent on update and delete requests to ensure the client has an up-to-date value before
                    /// proceeding.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not actually post it.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployPolicies/[^/]+$",
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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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

                /// <summary>Gets details of a single DeployPolicy.</summary>
                /// <param name="name">
                /// Required. Name of the `DeployPolicy`. Format must be
                /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single DeployPolicy.</summary>
                public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.DeployPolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the `DeployPolicy`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployPolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployPolicies/[^/]+$",
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

                /// <summary>Lists DeployPolicies in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of deploy policies. Format must be
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists DeployPolicies in a given project and location.</summary>
                public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListDeployPoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of deploy policies. Format must be
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filter deploy policies to be returned. See https://google.aip.dev/160 for more details. All
                    /// fields can be used in the filter.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Field to sort by. See https://google.aip.dev/132#ordering for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of deploy policies to return. The service may return fewer than this value.
                    /// If unspecified, at most 50 deploy policies will be returned. The maximum value is 1000; values
                    /// above 1000 will be set to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListDeployPolicies` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other provided parameters match the call that provided the
                    /// page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/deployPolicies";

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

                /// <summary>Updates the parameters of a single DeployPolicy.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Name of the `DeployPolicy`. Format is
                /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`. The `deployPolicy`
                /// component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDeploy.v1.Data.DeployPolicy body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single DeployPolicy.</summary>
                public class PatchRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.DeployPolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Name of the `DeployPolicy`. Format is
                    /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`. The `deployPolicy`
                    /// component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, updating a `DeployPolicy` that does not exist will result in the
                    /// creation of a new `DeployPolicy`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// `DeployPolicy` resource. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it's in the mask. If the user doesn't
                    /// provide a mask then all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.DeployPolicy Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployPolicies/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deployPolicies/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CloudDeploy.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Empty>
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
                public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
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
                public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}/operations";

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

            /// <summary>Gets the Targets resource.</summary>
            public virtual TargetsResource Targets { get; }

            /// <summary>The "targets" collection of methods.</summary>
            public class TargetsResource
            {
                private const string Resource = "targets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TargetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Target in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent collection in which the `Target` must be created. The format is
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudDeploy.v1.Data.Target body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Target in a given project and location.</summary>
                public class CreateRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Target body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent collection in which the `Target` must be created. The format is
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. ID of the `Target`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("targetId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string TargetId { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.Target Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/targets";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("targetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "targetId",
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

                /// <summary>Deletes a single Target.</summary>
                /// <param name="name">
                /// Required. The name of the `Target` to delete. The format is
                /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Target.</summary>
                public class DeleteRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Target` to delete. The format is
                    /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, then deleting an already deleted or non-existing `Target` will
                    /// succeed.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. This checksum is computed by the server based on the value of other fields, and may be
                    /// sent on update and delete requests to ensure the client has an up-to-date value before
                    /// proceeding.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not actually post it.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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

                /// <summary>Gets details of a single Target.</summary>
                /// <param name="name">
                /// Required. Name of the `Target`. Format must be
                /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Target.</summary>
                public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Target>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the `Target`. Format must be
                    /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
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

                /// <summary>Lists Targets in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of targets. Format must be
                /// `projects/{project_id}/locations/{location_name}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Targets in a given project and location.</summary>
                public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListTargetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of targets. Format must be
                    /// `projects/{project_id}/locations/{location_name}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter targets to be returned. See https://google.aip.dev/160 for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Field to sort by. See https://google.aip.dev/132#ordering for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of `Target` objects to return. The service may return fewer than
                    /// this value. If unspecified, at most 50 `Target` objects will be returned. The maximum value is
                    /// 1000; values above 1000 will be set to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListTargets` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other provided parameters match the call that provided
                    /// the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/targets";

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

                /// <summary>Updates the parameters of a single Target.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Name of the `Target`. Format is
                /// `projects/{project}/locations/{location}/targets/{target}`. The `target` component must match
                /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDeploy.v1.Data.Target body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Target.</summary>
                public class PatchRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.Target body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Name of the `Target`. Format is
                    /// `projects/{project}/locations/{location}/targets/{target}`. The `target` component must match
                    /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, updating a `Target` that does not exist will result in the creation of
                    /// a new `Target`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. A request ID to identify requests. Specify a unique request ID so that if you must
                    /// retry your request, the server knows to ignore the request if it has already been completed. The
                    /// server guarantees that for at least 60 minutes after the first request. For example, consider a
                    /// situation where you make an initial request and the request times out. If you make the request
                    /// again with the same request ID, the server can check if original operation with the same request
                    /// ID was received, and if so, will ignore the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten by the update in the
                    /// `Target` resource. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it's in the mask. If the user doesn't provide a
                    /// mask then all fields are overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set to true, the request is validated and the user is provided with an expected
                    /// result, but no actual change is made.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDeploy.v1.Data.Target Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDeploy.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/targets/[^/]+$",
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
            public class GetRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration for a location.</summary>
            /// <param name="name">Required. Name of requested configuration.</param>
            public virtual GetConfigRequest GetConfig(string name)
            {
                return new GetConfigRequest(this.service, name);
            }

            /// <summary>Gets the configuration for a location.</summary>
            public class GetConfigRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.Config>
            {
                /// <summary>Constructs a new GetConfig request.</summary>
                public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of requested configuration.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/config$",
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
            public class ListRequest : CloudDeployBaseServiceRequest<Google.Apis.CloudDeploy.v1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1/{+name}/locations";

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
namespace Google.Apis.CloudDeploy.v1.Data
{
    /// <summary>The request object used by `AbandonRelease`.</summary>
    public class AbandonReleaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object for `AbandonRelease`.</summary>
    public class AbandonReleaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An advanceChildRollout Job.</summary>
    public class AdvanceChildRolloutJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AdvanceChildRolloutJobRun contains information specific to a advanceChildRollout `JobRun`.</summary>
    public class AdvanceChildRolloutJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the `ChildRollout`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Output only. the ID of the ChildRollout's Phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutPhaseId")]
        public virtual string RolloutPhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the information of an automated advance-rollout operation.</summary>
    public class AdvanceRolloutOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The phase the rollout will be advanced to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPhase")]
        public virtual string DestinationPhase { get; set; }

        /// <summary>Output only. The name of the rollout that initiates the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Output only. The phase of a deployment that initiated the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePhase")]
        public virtual string SourcePhase { get; set; }

        /// <summary>Output only. How long the operation will be paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `AdvanceRollout`.</summary>
    public class AdvanceRolloutRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>Required. The phase ID to advance the `Rollout` to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `AdvanceRollout`.</summary>
    public class AdvanceRolloutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `AdvanceRollout` automation rule will automatically advance a successful Rollout to the next phase.
    /// </summary>
    public class AdvanceRolloutRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information around the state of the Automation rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual AutomationRuleCondition Condition { get; set; }

        /// <summary>
        /// Required. ID of the rule. This id must be unique in the `Automation` resource to which this rule belongs.
        /// The format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Proceeds only after phase name matched any one in the list. This value must consist of lower-case
        /// letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length
        /// of 63 characters. In other words, it must match the following regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePhases")]
        public virtual System.Collections.Generic.IList<string> SourcePhases { get; set; }

        /// <summary>Optional. How long to wait after a rollout is finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specifying an Anthos Cluster.</summary>
    public class AnthosCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Membership of the GKE Hub-registered cluster to which to apply the Skaffold configuration. Format
        /// is `projects/{project}/locations/{location}/memberships/{membership_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `ApproveRollout`.</summary>
    public class ApproveRolloutRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. True = approve; false = reject</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approved")]
        public virtual System.Nullable<bool> Approved { get; set; }

        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ApproveRollout`.</summary>
    public class ApproveRolloutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about entities associated with a `Target`.</summary>
    public class AssociatedEntities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Information specifying Anthos clusters as associated entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anthosClusters")]
        public virtual System.Collections.Generic.IList<AnthosCluster> AnthosClusters { get; set; }

        /// <summary>Optional. Information specifying GKE clusters as associated entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusters")]
        public virtual System.Collections.Generic.IList<GkeCluster> GkeClusters { get; set; }

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
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

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
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// An `Automation` resource in the Cloud Deploy API. An `Automation` enables the automation of manually driven
    /// actions for a Delivery Pipeline, which includes Release promotion among Targets, Rollout repair and Rollout
    /// deployment strategy advancement. The intention of Automation is to reduce manual intervention in the continuous
    /// delivery process.
    /// </summary>
    public class Automation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// Annotations must meet the following constraints: * Annotations are key/value pairs. * Valid annotation keys
        /// have two segments: an optional prefix and name, separated by a slash (`/`). * The name segment is required
        /// and must be 63 characters or less, beginning and ending with an alphanumeric character (`[a-z0-9A-Z]`) with
        /// dashes (`-`), underscores (`_`), dots (`.`), and alphanumerics between. * The prefix is optional. If
        /// specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots(`.`), not longer
        /// than 253 characters in total, followed by a slash (`/`). See
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/#syntax-and-character-set for
        /// more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the automation was created.</summary>
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

        /// <summary>Optional. Description of the `Automation`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The weak etag of the `Automation` resource. This checksum is computed by the server based on the
        /// value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date
        /// value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must
        /// meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Name of the `Automation`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. List of Automation rules associated with the Automation resource. Must have at least one rule and
        /// limited to 250 rules per Delivery Pipeline. Note: the order of the rules here is not the same as the order
        /// of execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<AutomationRule> Rules { get; set; }

        /// <summary>Required. Selected resources to which the automation will be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual AutomationResourceSelector Selector { get; set; }

        /// <summary>
        /// Required. Email address of the user-managed IAM service account that creates Cloud Deploy release and
        /// rollout resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. When Suspended, automation is deactivated from execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>Output only. Unique identifier of the `Automation`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time at which the automation was updated.</summary>
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

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/automation" Platform Log event that describes the Automation
    /// related events.
    /// </summary>
    public class AutomationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automation")]
        public virtual string Automation { get; set; }

        /// <summary>
        /// Debug message for when there is an update on the AutomationRun. Provides further details about the resource
        /// creation or state change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AutomationResourceSelector contains the information to select the resources to which an Automation is going to
    /// be applied.
    /// </summary>
    public class AutomationResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Contains attributes about a target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<TargetAttribute> Targets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AutomationRolloutMetadata contains Automation-related actions that were performed on a rollout.
    /// </summary>
    public class AutomationRolloutMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The names of the AutomationRuns initiated by an advance rollout rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceAutomationRuns")]
        public virtual System.Collections.Generic.IList<string> AdvanceAutomationRuns { get; set; }

        /// <summary>Output only. The name of the AutomationRun initiated by a promote release rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promoteAutomationRun")]
        public virtual string PromoteAutomationRun { get; set; }

        /// <summary>Output only. The names of the AutomationRuns initiated by a repair rollout rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repairAutomationRuns")]
        public virtual System.Collections.Generic.IList<string> RepairAutomationRuns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`AutomationRule` defines the automation activities.</summary>
    public class AutomationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The `AdvanceRolloutRule` will automatically advance a successful Rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceRolloutRule")]
        public virtual AdvanceRolloutRule AdvanceRolloutRule { get; set; }

        /// <summary>
        /// Optional. `PromoteReleaseRule` will automatically promote a release from the current target to a specified
        /// target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promoteReleaseRule")]
        public virtual PromoteReleaseRule PromoteReleaseRule { get; set; }

        /// <summary>Optional. The `RepairRolloutRule` will automatically repair a failed rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repairRolloutRule")]
        public virtual RepairRolloutRule RepairRolloutRule { get; set; }

        /// <summary>
        /// Optional. The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to
        /// the specified target(s) on a configured schedule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedPromoteReleaseRule")]
        public virtual TimedPromoteReleaseRule TimedPromoteReleaseRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`AutomationRuleCondition` contains conditions relevant to an `Automation` rule.</summary>
    public class AutomationRuleCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Details around targets enumerated in the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetsPresentCondition")]
        public virtual TargetsPresentCondition TargetsPresentCondition { get; set; }

        /// <summary>
        /// Optional. TimedPromoteReleaseCondition contains rule conditions specific to a an Automation with a timed
        /// promote release rule defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedPromoteReleaseCondition")]
        public virtual TimedPromoteReleaseCondition TimedPromoteReleaseCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `AutomationRun` resource in the Cloud Deploy API. An `AutomationRun` represents an execution instance of an
    /// automation rule.
    /// </summary>
    public class AutomationRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Advances a rollout to the next phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceRolloutOperation")]
        public virtual AdvanceRolloutOperation AdvanceRolloutOperation { get; set; }

        /// <summary>Output only. The ID of the automation that initiated the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationId")]
        public virtual string AutomationId { get; set; }

        /// <summary>Output only. Snapshot of the Automation taken at AutomationRun creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationSnapshot")]
        public virtual Automation AutomationSnapshot { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `AutomationRun` was created.</summary>
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
        /// Output only. The weak etag of the `AutomationRun` resource. This checksum is computed by the server based on
        /// the value of other fields, and may be sent on update and delete requests to ensure the client has an
        /// up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Time the `AutomationRun` expires. An `AutomationRun` expires after 14 days from its creation
        /// date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Contains information about what policies prevented the `AutomationRun` from proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyViolation")]
        public virtual PolicyViolation PolicyViolation { get; set; }

        /// <summary>Output only. Promotes a release to a specified 'Target'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promoteReleaseOperation")]
        public virtual PromoteReleaseOperation PromoteReleaseOperation { get; set; }

        /// <summary>Output only. Repairs a failed 'Rollout'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repairRolloutOperation")]
        public virtual RepairRolloutOperation RepairRolloutOperation { get; set; }

        /// <summary>Output only. The ID of the automation rule that initiated the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>
        /// Output only. Email address of the user-managed IAM service account that performs the operations against
        /// Cloud Deploy resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Output only. Current state of the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Explains the current state of the `AutomationRun`. Present only when an explanation is needed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDescription")]
        public virtual string StateDescription { get; set; }

        /// <summary>
        /// Output only. The ID of the source target that initiates the `AutomationRun`. The value of this field is the
        /// last segment of a target name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>
        /// Output only. Promotes a release to a specified 'Target' as defined in a Timed Promote Release rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedPromoteReleaseOperation")]
        public virtual TimedPromoteReleaseOperation TimedPromoteReleaseOperation { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time at which the automationRun was updated.</summary>
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

        private string _waitUntilTimeRaw;

        private object _waitUntilTime;

        /// <summary>
        /// Output only. Earliest time the `AutomationRun` will attempt to resume. Wait-time is configured by `wait` in
        /// automation rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitUntilTime")]
        public virtual string WaitUntilTimeRaw
        {
            get => _waitUntilTimeRaw;
            set
            {
                _waitUntilTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _waitUntilTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="WaitUntilTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use WaitUntilTimeDateTimeOffset instead.")]
        public virtual object WaitUntilTime
        {
            get => _waitUntilTime;
            set
            {
                _waitUntilTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _waitUntilTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="WaitUntilTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? WaitUntilTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(WaitUntilTimeRaw);
            set => WaitUntilTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/automation_run" Platform Log event that describes the
    /// AutomationRun related events.
    /// </summary>
    public class AutomationRunEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the `Automation`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationId")]
        public virtual string AutomationId { get; set; }

        /// <summary>The name of the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationRun")]
        public virtual string AutomationRun { get; set; }

        /// <summary>ID of the `Target` to which the `AutomationRun` is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTargetId")]
        public virtual string DestinationTargetId { get; set; }

        /// <summary>
        /// Debug message for when there is an update on the AutomationRun. Provides further details about the resource
        /// creation or state change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>Identifier of the `Automation` rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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

    /// <summary>Description of an a image to use during Skaffold rendering.</summary>
    public class BuildArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Image name in Skaffold configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Optional. Image tag to use. This will generally be the full path to an image, such as
        /// "gcr.io/my-project/busybox:1.2.3" or "gcr.io/my-project/busybox@sha256:abc123".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Canary represents the canary deployment strategy.</summary>
    public class Canary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configures the progressive based deployment for a Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canaryDeployment")]
        public virtual CanaryDeployment CanaryDeployment { get; set; }

        /// <summary>
        /// Optional. Configures the progressive based deployment for a Target, but allows customizing at the phase
        /// level where a phase represents each of the percentage deployments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customCanaryDeployment")]
        public virtual CustomCanaryDeployment CustomCanaryDeployment { get; set; }

        /// <summary>
        /// Optional. Runtime specific configurations for the deployment strategy. The runtime configuration is used to
        /// determine how Cloud Deploy will split traffic to enable a progressive deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeConfig")]
        public virtual RuntimeConfig RuntimeConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CanaryDeployment represents the canary deployment configuration</summary>
    public class CanaryDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The percentage based deployments that will occur as a part of a `Rollout`. List is expected in
        /// ascending order and each integer n is 0 &amp;lt;= n &amp;lt; 100. If the GatewayServiceMesh is configured
        /// for Kubernetes, then the range for n is 0 &amp;lt;= n &amp;lt;= 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentages")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Percentages { get; set; }

        /// <summary>
        /// Optional. Configuration for the postdeploy job of the last phase. If this is not configured, there will be
        /// no postdeploy job for this phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeploy")]
        public virtual Postdeploy Postdeploy { get; set; }

        /// <summary>
        /// Optional. Configuration for the predeploy job of the first phase. If this is not configured, there will be
        /// no predeploy job for this phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeploy")]
        public virtual Predeploy Predeploy { get; set; }

        /// <summary>Optional. Whether to run verify tests after each percentage deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verify")]
        public virtual System.Nullable<bool> Verify { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `CancelAutomationRun`.</summary>
    public class CancelAutomationRunRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `CancelAutomationRun`.</summary>
    public class CancelAutomationRunResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `CancelRollout`.</summary>
    public class CancelRolloutRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `CancelRollout`.</summary>
    public class CancelRolloutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ChildRollouts job composition</summary>
    public class ChildRolloutJobs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of AdvanceChildRolloutJobs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceRolloutJobs")]
        public virtual System.Collections.Generic.IList<Job> AdvanceRolloutJobs { get; set; }

        /// <summary>Output only. List of CreateChildRolloutJobs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createRolloutJobs")]
        public virtual System.Collections.Generic.IList<Job> CreateRolloutJobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CloudRunConfig contains the Cloud Run runtime configuration.</summary>
    public class CloudRunConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether Cloud Deploy should update the traffic stanza in a Cloud Run Service on the user's behalf
        /// to facilitate traffic splitting. This is required to be true for CanaryDeployments, but optional for
        /// CustomCanaryDeployments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticTrafficControl")]
        public virtual System.Nullable<bool> AutomaticTrafficControl { get; set; }

        /// <summary>
        /// Optional. A list of tags that are added to the canary revision while the canary phase is in progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canaryRevisionTags")]
        public virtual System.Collections.Generic.IList<string> CanaryRevisionTags { get; set; }

        /// <summary>
        /// Optional. A list of tags that are added to the prior revision while the canary phase is in progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorRevisionTags")]
        public virtual System.Collections.Generic.IList<string> PriorRevisionTags { get; set; }

        /// <summary>
        /// Optional. A list of tags that are added to the final stable revision when the stable phase is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stableRevisionTags")]
        public virtual System.Collections.Generic.IList<string> StableRevisionTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specifying where to deploy a Cloud Run Service.</summary>
    public class CloudRunLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The location for the Cloud Run Service. Format must be `projects/{project}/locations/{location}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CloudRunMetadata contains information from a Cloud Run deployment.</summary>
    public class CloudRunMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the Cloud Run job that is associated with a `Rollout`. Format is
        /// `projects/{project}/locations/{location}/jobs/{job_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual string Job { get; set; }

        /// <summary>Output only. The Cloud Run Revision id associated with a `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// Output only. The name of the Cloud Run Service that is associated with a `Rollout`. Format is
        /// `projects/{project}/locations/{location}/services/{service}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>Output only. The Cloud Run Service urls that are associated with a `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceUrls")]
        public virtual System.Collections.Generic.IList<string> ServiceUrls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CloudRunRenderMetadata contains Cloud Run information associated with a `Release` render.</summary>
    public class CloudRunRenderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the Cloud Run Service in the rendered manifest. Format is
        /// `projects/{project}/locations/{location}/services/{service}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service-wide configuration.</summary>
    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Default Skaffold version that is assigned when a Release is created without specifying a Skaffold version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSkaffoldVersion")]
        public virtual string DefaultSkaffoldVersion { get; set; }

        /// <summary>Name of the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>All supported versions of Skaffold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedVersions")]
        public virtual System.Collections.Generic.IList<SkaffoldVersion> SupportedVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A createChildRollout Job.</summary>
    public class CreateChildRolloutJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CreateChildRolloutJobRun contains information specific to a createChildRollout `JobRun`.</summary>
    public class CreateChildRolloutJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the `ChildRollout`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Output only. The ID of the childRollout Phase initiated by this JobRun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutPhaseId")]
        public virtual string RolloutPhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomCanaryDeployment represents the custom canary deployment configuration.</summary>
    public class CustomCanaryDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Configuration for each phase in the canary deployment in the order executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseConfigs")]
        public virtual System.Collections.Generic.IList<PhaseConfig> PhaseConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomMetadata contains information from a user-defined operation.</summary>
    public class CustomMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Key-value pairs provided by the user-defined operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specifying a Custom Target.</summary>
    public class CustomTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the CustomTargetType. Format must be
        /// `projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetType")]
        public virtual string CustomTargetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomTargetDeployMetadata contains information from a Custom Target deploy operation.</summary>
    public class CustomTargetDeployMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Skip message provided in the results of a custom deploy operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipMessage")]
        public virtual string SkipMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CustomTargetSkaffoldActions represents the `CustomTargetType` configuration using Skaffold custom actions.
    /// </summary>
    public class CustomTargetSkaffoldActions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Skaffold custom action responsible for deploy operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployAction")]
        public virtual string DeployAction { get; set; }

        /// <summary>
        /// Optional. List of Skaffold modules Cloud Deploy will include in the Skaffold Config as required before
        /// performing diagnose.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeSkaffoldModules")]
        public virtual System.Collections.Generic.IList<SkaffoldModules> IncludeSkaffoldModules { get; set; }

        /// <summary>
        /// Optional. The Skaffold custom action responsible for render operations. If not provided then Cloud Deploy
        /// will perform the render operations via `skaffold render`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderAction")]
        public virtual string RenderAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `CustomTargetType` resource in the Cloud Deploy API. A `CustomTargetType` defines a type of custom target that
    /// can be referenced in a `Target` in order to facilitate deploying to other systems besides the supported
    /// runtimes.
    /// </summary>
    public class CustomTargetType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// See https://google.aip.dev/128#annotations for more details such as format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `CustomTargetType` was created.</summary>
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
        /// Optional. Configures render and deploy for the `CustomTargetType` using Skaffold custom actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customActions")]
        public virtual CustomTargetSkaffoldActions CustomActions { get; set; }

        /// <summary>Output only. Resource id of the `CustomTargetType`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetTypeId")]
        public virtual string CustomTargetTypeId { get; set; }

        /// <summary>Optional. Description of the `CustomTargetType`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must
        /// meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the `CustomTargetType`. Format is
        /// `projects/{project}/locations/{location}/customTargetTypes/{customTargetType}`. The `customTargetType`
        /// component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Unique identifier of the `CustomTargetType`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Most recent time at which the `CustomTargetType` was updated.</summary>
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

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/customtargettype_notification" Platform Log event that describes
    /// the failure to send a custom target type status change Pub/Sub notification.
    /// </summary>
    public class CustomTargetTypeNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `CustomTargetType`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetType")]
        public virtual string CustomTargetType { get; set; }

        /// <summary>Unique identifier of the `CustomTargetType`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetTypeUid")]
        public virtual string CustomTargetTypeUid { get; set; }

        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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
    public class Date : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Execution using the default Cloud Build pool.</summary>
    public class DefaultPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud Storage location where execution outputs should be stored. This can either be a bucket
        /// ("gs://my-bucket") or a path within a bucket ("gs://my-bucket/my-dir"). If unspecified, a default bucket
        /// located in the same region will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorage")]
        public virtual string ArtifactStorage { get; set; }

        /// <summary>
        /// Optional. Google service account to use for execution. If unspecified, the project execution service account
        /// (-compute@developer.gserviceaccount.com) will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `DeliveryPipeline` resource in the Cloud Deploy API. A `DeliveryPipeline` defines a pipeline through which a
    /// Skaffold configuration can progress.
    /// </summary>
    public class DeliveryPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Information around the state of the Delivery Pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual PipelineCondition Condition { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the pipeline was created.</summary>
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

        /// <summary>Optional. Description of the `DeliveryPipeline`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the
        /// following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the `DeliveryPipeline`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}`. The `deliveryPipeline`
        /// component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. SerialPipeline defines a sequential set of stages for a `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialPipeline")]
        public virtual SerialPipeline SerialPipeline { get; set; }

        /// <summary>
        /// Optional. When suspended, no new releases or rollouts can be created, but in-progress ones will complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>Output only. Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Most recent time at which the pipeline was updated.</summary>
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

    /// <summary>Contains criteria for selecting DeliveryPipelines.</summary>
    public class DeliveryPipelineAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ID of the `DeliveryPipeline`. The value of this field could be one of the following: * The last
        /// segment of a pipeline name * "*", all delivery pipelines in a location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>DeliveryPipeline labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/deliverypipeline_notification" Platform Log event that describes
    /// the failure to send delivery pipeline status change Pub/Sub notification.
    /// </summary>
    public class DeliveryPipelineNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `Delivery Pipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPipeline")]
        public virtual string DeliveryPipeline { get; set; }

        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The artifacts produced by a deploy operation.</summary>
    public class DeployArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. URI of a directory containing the artifacts. All paths are relative to this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactUri")]
        public virtual string ArtifactUri { get; set; }

        /// <summary>
        /// Output only. File paths of the manifests applied during the deploy operation relative to the URI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestPaths")]
        public virtual System.Collections.Generic.IList<string> ManifestPaths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A deploy Job.</summary>
    public class DeployJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DeployJobRun contains information specific to a deploy `JobRun`.</summary>
    public class DeployJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The artifact of a deploy job run, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifact")]
        public virtual DeployArtifact Artifact { get; set; }

        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to deploy. Format is
        /// `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>
        /// Output only. The reason the deploy failed. This will always be unspecified while the deploy is in progress
        /// or if it succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Output only. Additional information about the deploy failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>Output only. Metadata containing information about the deploy job run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual DeployJobRunMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DeployJobRunMetadata surfaces information associated with a `DeployJobRun` to the user.</summary>
    public class DeployJobRunMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the Cloud Run Service that is associated with a `DeployJobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRun")]
        public virtual CloudRunMetadata CloudRun { get; set; }

        /// <summary>Output only. Custom metadata provided by user-defined deploy operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomMetadata Custom { get; set; }

        /// <summary>Output only. Custom Target metadata associated with a `DeployJobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTarget")]
        public virtual CustomTargetDeployMetadata CustomTarget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DeployParameters contains deploy parameters information.</summary>
    public class DeployParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deploy parameters are applied to targets with match labels. If unspecified, deploy parameters are
        /// applied to all targets (including child targets of a multi-target).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchTargetLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> MatchTargetLabels { get; set; }

        /// <summary>Required. Values are deploy parameters in key-value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `DeployPolicy` resource in the Cloud Deploy API. A `DeployPolicy` inhibits manual or automation-driven actions
    /// within a Delivery Pipeline or Target.
    /// </summary>
    public class DeployPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// Annotations must meet the following constraints: * Annotations are key/value pairs. * Valid annotation keys
        /// have two segments: an optional prefix and name, separated by a slash (`/`). * The name segment is required
        /// and must be 63 characters or less, beginning and ending with an alphanumeric character (`[a-z0-9A-Z]`) with
        /// dashes (`-`), underscores (`_`), dots (`.`), and alphanumerics between. * The prefix is optional. If
        /// specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots(`.`), not longer
        /// than 253 characters in total, followed by a slash (`/`). See
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/#syntax-and-character-set for
        /// more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the deploy policy was created.</summary>
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

        /// <summary>Optional. Description of the `DeployPolicy`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The weak etag of the `Automation` resource. This checksum is computed by the server based on the value of
        /// other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value
        /// before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the
        /// following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Name of the `DeployPolicy`. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`. The `deployPolicy` component must
        /// match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Rules to apply. At least one rule must be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<PolicyRule> Rules { get; set; }

        /// <summary>
        /// Required. Selected resources to which the policy will be applied. At least one selector is required. If one
        /// selector matches the resource the policy applies. For example, if there are two selectors and the action
        /// being attempted matches one of them, the policy will apply to that action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectors")]
        public virtual System.Collections.Generic.IList<DeployPolicyResourceSelector> Selectors { get; set; }

        /// <summary>
        /// Optional. When suspended, the policy will not prevent actions from occurring, even if the action violates
        /// the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>Output only. Unique identifier of the `DeployPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Most recent time at which the deploy policy was updated.</summary>
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

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/deploypolicy_evaluation" Platform Log event that describes the
    /// deploy policy evaluation event.
    /// </summary>
    public class DeployPolicyEvaluationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the request is allowed. Allowed is set as true if: (1) the request complies with the policy; or (2)
        /// the request doesn't comply with the policy but the policy was overridden; or (3) the request doesn't comply
        /// with the policy but the policy was suspended
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual System.Nullable<bool> Allowed { get; set; }

        /// <summary>The name of the `Delivery Pipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPipeline")]
        public virtual string DeliveryPipeline { get; set; }

        /// <summary>The name of the `DeployPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPolicy")]
        public virtual string DeployPolicy { get; set; }

        /// <summary>Unique identifier of the `DeployPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPolicyUid")]
        public virtual string DeployPolicyUid { get; set; }

        /// <summary>What invoked the action (e.g. a user or automation).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invoker")]
        public virtual string Invoker { get; set; }

        /// <summary>Debug message for when a deploy policy event occurs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Things that could have overridden the policy verdict. Overrides together with verdict decide whether the
        /// request is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrides")]
        public virtual System.Collections.Generic.IList<string> Overrides { get; set; }

        /// <summary>Unique identifier of the `Delivery Pipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>Rule id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual string Rule { get; set; }

        /// <summary>Rule type (e.g. Restrict Rollouts).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleType")]
        public virtual string RuleType { get; set; }

        /// <summary>
        /// The name of the `Target`. This is an optional field, as a `Target` may not always be applicable to a policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>
        /// Unique identifier of the `Target`. This is an optional field, as a `Target` may not always be applicable to
        /// a policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUid")]
        public virtual string TargetUid { get; set; }

        /// <summary>The policy verdict of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/deploypolicy_notification". Platform Log event that describes the
    /// failure to send a pub/sub notification when there is a DeployPolicy status change.
    /// </summary>
    public class DeployPolicyNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `DeployPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPolicy")]
        public virtual string DeployPolicy { get; set; }

        /// <summary>Unique identifier of the deploy policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPolicyUid")]
        public virtual string DeployPolicyUid { get; set; }

        /// <summary>Debug message for when a deploy policy fails to send a pub/sub notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information on the resources to select for a deploy policy. Attributes provided must all match the
    /// resource in order for policy restrictions to apply. For example, if delivery pipelines attributes given are an
    /// id "prod" and labels "foo: bar", a delivery pipeline resource must match both that id and have that label in
    /// order to be subject to the policy.
    /// </summary>
    public class DeployPolicyResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Contains attributes about a delivery pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPipeline")]
        public virtual DeliveryPipelineAttribute DeliveryPipeline { get; set; }

        /// <summary>Optional. Contains attributes about a target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual TargetAttribute Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deployment job composition.</summary>
    public class DeploymentJobs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The deploy Job. This is the deploy job in the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployJob")]
        public virtual Job DeployJob { get; set; }

        /// <summary>Output only. The postdeploy Job, which is the last job on the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeployJob")]
        public virtual Job PostdeployJob { get; set; }

        /// <summary>Output only. The predeploy Job, which is the first job on the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeployJob")]
        public virtual Job PredeployJob { get; set; }

        /// <summary>Output only. The verify Job. Runs after a deploy if the deploy succeeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyJob")]
        public virtual Job VerifyJob { get; set; }

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

    /// <summary>Configuration of the environment to use when calling Skaffold.</summary>
    public class ExecutionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud Storage location in which to store execution outputs. This can either be a bucket
        /// ("gs://my-bucket") or a path within a bucket ("gs://my-bucket/my-dir"). If unspecified, a default bucket
        /// located in the same region will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorage")]
        public virtual string ArtifactStorage { get; set; }

        /// <summary>Optional. Use default Cloud Build pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPool")]
        public virtual DefaultPool DefaultPool { get; set; }

        /// <summary>
        /// Optional. Execution timeout for a Cloud Build Execution. This must be between 10m and 24h in seconds format.
        /// If unspecified, a default timeout of 1h is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTimeout")]
        public virtual object ExecutionTimeout { get; set; }

        /// <summary>Optional. Use private Cloud Build pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privatePool")]
        public virtual PrivatePool PrivatePool { get; set; }

        /// <summary>
        /// Optional. Google service account to use for execution. If unspecified, the project execution service account
        /// (-compute@developer.gserviceaccount.com) is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Required. Usages when this configuration should be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usages")]
        public virtual System.Collections.Generic.IList<string> Usages { get; set; }

        /// <summary>
        /// Optional. If true, additional logging will be enabled when running builds in this execution environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verbose")]
        public virtual System.Nullable<bool> Verbose { get; set; }

        /// <summary>
        /// Optional. The resource name of the `WorkerPool`, with the format
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`. If this optional field is unspecified,
        /// the default Cloud Build pool will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

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
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Information about the Kubernetes Gateway API service mesh configuration.</summary>
    public class GatewayServiceMesh : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the Kubernetes Deployment whose traffic is managed by the specified HTTPRoute and Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>Required. Name of the Gateway API HTTPRoute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRoute")]
        public virtual string HttpRoute { get; set; }

        /// <summary>
        /// Optional. The label to use when selecting Pods for the Deployment and Service resources. This label must
        /// already be present in both resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podSelectorLabel")]
        public virtual string PodSelectorLabel { get; set; }

        /// <summary>
        /// Optional. Route destinations allow configuring the Gateway API HTTPRoute to be deployed to additional
        /// clusters. This option is available for multi-cluster service mesh set ups that require the route to exist in
        /// the clusters that call the service. If unspecified, the HTTPRoute will only be deployed to the Target
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeDestinations")]
        public virtual RouteDestinations RouteDestinations { get; set; }

        /// <summary>
        /// Optional. The time to wait for route updates to propagate. The maximum configurable time is 3 hours, in
        /// seconds format. If unspecified, there is no wait time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeUpdateWaitTime")]
        public virtual object RouteUpdateWaitTime { get; set; }

        /// <summary>Required. Name of the Kubernetes Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Optional. The amount of time to migrate traffic back from the canary Service to the original Service during
        /// the stable phase deployment. If specified, must be between 15s and 3600s. If unspecified, there is no
        /// cutback time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stableCutbackDuration")]
        public virtual object StableCutbackDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specifying a GKE Cluster.</summary>
    public class GkeCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Information specifying a GKE Cluster. Format is
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>
        /// Optional. If set, the cluster will be accessed using the DNS endpoint. Note that both `dns_endpoint` and
        /// `internal_ip` cannot be set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsEndpoint")]
        public virtual System.Nullable<bool> DnsEndpoint { get; set; }

        /// <summary>
        /// Optional. If true, `cluster` is accessed using the private IP address of the control plane endpoint.
        /// Otherwise, the default IP address of the control plane endpoint is used. The default IP address is the
        /// private IP address for clusters with private control-plane endpoints and the public IP address otherwise.
        /// Only specify this option when `cluster` is a [private GKE
        /// cluster](https://cloud.google.com/kubernetes-engine/docs/concepts/private-cluster-concept). Note that
        /// `internal_ip` and `dns_endpoint` cannot both be set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual System.Nullable<bool> InternalIp { get; set; }

        /// <summary>
        /// Optional. If set, used to configure a
        /// [proxy](https://kubernetes.io/docs/concepts/configuration/organize-cluster-access-kubeconfig/#proxy) to the
        /// Kubernetes server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyUrl")]
        public virtual string ProxyUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `IgnoreJob`.</summary>
    public class IgnoreJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The job ID for the Job to ignore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>Required. The phase ID the Job to ignore belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `IgnoreJob`.</summary>
    public class IgnoreJobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job represents an operation for a `Rollout`.</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. An advanceChildRollout Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceChildRolloutJob")]
        public virtual AdvanceChildRolloutJob AdvanceChildRolloutJob { get; set; }

        /// <summary>Output only. A createChildRollout Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createChildRolloutJob")]
        public virtual CreateChildRolloutJob CreateChildRolloutJob { get; set; }

        /// <summary>Output only. A deploy Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployJob")]
        public virtual DeployJob DeployJob { get; set; }

        /// <summary>Output only. The ID of the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The name of the `JobRun` responsible for the most recent invocation of this Job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobRun")]
        public virtual string JobRun { get; set; }

        /// <summary>Output only. A postdeploy Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeployJob")]
        public virtual PostdeployJob PostdeployJob { get; set; }

        /// <summary>Output only. A predeploy Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeployJob")]
        public virtual PredeployJob PredeployJob { get; set; }

        /// <summary>Output only. Additional information on why the Job was skipped, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipMessage")]
        public virtual string SkipMessage { get; set; }

        /// <summary>Output only. The current state of the Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A verify Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyJob")]
        public virtual VerifyJob VerifyJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `JobRun` resource in the Cloud Deploy API. A `JobRun` contains information of a single `Rollout` job
    /// evaluation.
    /// </summary>
    public class JobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information specific to an advanceChildRollout `JobRun`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advanceChildRolloutJobRun")]
        public virtual AdvanceChildRolloutJobRun AdvanceChildRolloutJobRun { get; set; }

        /// <summary>Output only. Information specific to a createChildRollout `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createChildRolloutJobRun")]
        public virtual CreateChildRolloutJobRun CreateChildRolloutJobRun { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `JobRun` was created.</summary>
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

        /// <summary>Output only. Information specific to a deploy `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployJobRun")]
        public virtual DeployJobRun DeployJobRun { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Time at which the `JobRun` ended.</summary>
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
        /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. ID of the `Rollout` job this `JobRun` corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Output only. Name of the `JobRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{releases}/rollouts/{rollouts}/jobRuns/{uuid}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. ID of the `Rollout` phase this `JobRun` belongs in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>Output only. Information specific to a postdeploy `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeployJobRun")]
        public virtual PostdeployJobRun PostdeployJobRun { get; set; }

        /// <summary>Output only. Information specific to a predeploy `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeployJobRun")]
        public virtual PredeployJobRun PredeployJobRun { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Time at which the `JobRun` was started.</summary>
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

        /// <summary>Output only. The current state of the `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Unique identifier of the `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. Information specific to a verify `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyJobRun")]
        public virtual VerifyJobRun VerifyJobRun { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/jobrun_notification" Platform Log event that describes the failure
    /// to send JobRun resource update Pub/Sub notification.
    /// </summary>
    public class JobRunNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the `JobRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobRun")]
        public virtual string JobRun { get; set; }

        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>The name of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>Unique identifier of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseUid")]
        public virtual string ReleaseUid { get; set; }

        /// <summary>The name of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Unique identifier of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUid")]
        public virtual string RolloutUid { get; set; }

        /// <summary>ID of the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>KubernetesConfig contains the Kubernetes runtime configuration.</summary>
    public class KubernetesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Kubernetes Gateway API service mesh configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayServiceMesh")]
        public virtual GatewayServiceMesh GatewayServiceMesh { get; set; }

        /// <summary>Optional. Kubernetes Service networking configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceNetworking")]
        public virtual ServiceNetworking ServiceNetworking { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListAutomationRuns`.</summary>
    public class ListAutomationRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `AutomationRuns` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automationRuns")]
        public virtual System.Collections.Generic.IList<AutomationRun> AutomationRuns { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListAutomations`.</summary>
    public class ListAutomationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `Automation` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automations")]
        public virtual System.Collections.Generic.IList<Automation> Automations { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListCustomTargetTypes.`</summary>
    public class ListCustomTargetTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `CustomTargetType` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetTypes")]
        public virtual System.Collections.Generic.IList<CustomTargetType> CustomTargetTypes { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListDeliveryPipelines`.</summary>
    public class ListDeliveryPipelinesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `DeliveryPipeline` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPipelines")]
        public virtual System.Collections.Generic.IList<DeliveryPipeline> DeliveryPipelines { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListDeployPolicies`.</summary>
    public class ListDeployPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `DeployPolicy` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployPolicies")]
        public virtual System.Collections.Generic.IList<DeployPolicy> DeployPolicies { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListJobRunsResponse is the response object returned by `ListJobRuns`.</summary>
    public class ListJobRunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `JobRun` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobRuns")]
        public virtual System.Collections.Generic.IList<JobRun> JobRuns { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>The response object from `ListReleases`.</summary>
    public class ListReleasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Release` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<Release> Releases { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListRolloutsResponse is the response object returned by `ListRollouts`.</summary>
    public class ListRolloutsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Rollout` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollouts")]
        public virtual System.Collections.Generic.IList<Rollout> Rollouts { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `ListTargets`.</summary>
    public class ListTargetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Target` objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<Target> Targets { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Metadata includes information associated with a `Rollout`.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. AutomationRolloutMetadata contains the information about the interactions between Automation
        /// service and this rollout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automation")]
        public virtual AutomationRolloutMetadata Automation { get; set; }

        /// <summary>Output only. The name of the Cloud Run Service that is associated with a `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRun")]
        public virtual CloudRunMetadata CloudRun { get; set; }

        /// <summary>Output only. Custom metadata provided by user-defined `Rollout` operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomMetadata Custom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specifying a multiTarget.</summary>
    public class MultiTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The target_ids of this multiTarget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetIds")]
        public virtual System.Collections.Generic.IList<string> TargetIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// One-time window within which actions are restricted. For example, blocking actions over New Year's Eve from
    /// December 31st at 5pm to January 1st at 9am.
    /// </summary>
    public class OneTimeWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. End date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Required. End time (exclusive). You may use 24:00 for the end of the day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>Required. Start date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>Required. Start time (inclusive). Use 00:00 for the beginning of the day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

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
        /// successfully been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to `Code.CANCELLED`.
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

    /// <summary>Phase represents a collection of jobs that are logically grouped together for a `Rollout`.</summary>
    public class Phase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. ChildRollout job composition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childRolloutJobs")]
        public virtual ChildRolloutJobs ChildRolloutJobs { get; set; }

        /// <summary>Output only. Deployment job composition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentJobs")]
        public virtual DeploymentJobs DeploymentJobs { get; set; }

        /// <summary>Output only. The ID of the Phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Additional information on why the Phase was skipped, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipMessage")]
        public virtual string SkipMessage { get; set; }

        /// <summary>Output only. Current state of the Phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the paths to the artifacts, relative to the URI, for a phase.</summary>
    public class PhaseArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. File path of the directory of rendered job manifests relative to the URI. This is only set if
        /// it is applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobManifestsPath")]
        public virtual string JobManifestsPath { get; set; }

        /// <summary>Output only. File path of the rendered manifest relative to the URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestPath")]
        public virtual string ManifestPath { get; set; }

        /// <summary>Output only. File path of the resolved Skaffold configuration relative to the URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldConfigPath")]
        public virtual string SkaffoldConfigPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PhaseConfig represents the configuration for a phase in the custom canary deployment.</summary>
    public class PhaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Percentage deployment for the phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>
        /// Required. The ID to assign to the `Rollout` phase. This value must consist of lower-case letters, numbers,
        /// and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters.
        /// In other words, it must match the following regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>
        /// Optional. Configuration for the postdeploy job of this phase. If this is not configured, there will be no
        /// postdeploy job for this phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeploy")]
        public virtual Postdeploy Postdeploy { get; set; }

        /// <summary>
        /// Optional. Configuration for the predeploy job of this phase. If this is not configured, there will be no
        /// predeploy job for this phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeploy")]
        public virtual Predeploy Predeploy { get; set; }

        /// <summary>
        /// Optional. Skaffold profiles to use when rendering the manifest for this phase. These are in addition to the
        /// profiles list specified in the `DeliveryPipeline` stage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profiles")]
        public virtual System.Collections.Generic.IList<string> Profiles { get; set; }

        /// <summary>Optional. Whether to run verify tests after the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verify")]
        public virtual System.Nullable<bool> Verify { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PipelineCondition contains all conditions relevant to a Delivery Pipeline.</summary>
    public class PipelineCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details around the Pipeline's overall status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineReadyCondition")]
        public virtual PipelineReadyCondition PipelineReadyCondition { get; set; }

        /// <summary>Details around targets enumerated in the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetsPresentCondition")]
        public virtual TargetsPresentCondition TargetsPresentCondition { get; set; }

        /// <summary>Details on the whether the targets enumerated in the pipeline are of the same type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetsTypeCondition")]
        public virtual TargetsTypeCondition TargetsTypeCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PipelineReadyCondition contains information around the status of the Pipeline.</summary>
    public class PipelineReadyCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the Pipeline is in a valid state. Otherwise at least one condition in `PipelineCondition` is in an
        /// invalid state. Iterate over those conditions and see which condition(s) has status = false to find out what
        /// is wrong with the Pipeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Last time the condition was updated.</summary>
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
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

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

    /// <summary>Deploy Policy rule.</summary>
    public class PolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Rollout restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutRestriction")]
        public virtual RolloutRestriction RolloutRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Returned from an action if one or more policies were violated, and therefore the action was prevented. Contains
    /// information about what policies were violated and why.
    /// </summary>
    public class PolicyViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy violation details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationDetails")]
        public virtual System.Collections.Generic.IList<PolicyViolationDetails> PolicyViolationDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy violation details.</summary>
    public class PolicyViolationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User readable message about why the request violated a policy. This is not intended for machine parsing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>
        /// Name of the policy that was violated. Policy resource will be in the format of
        /// `projects/{project}/locations/{location}/policies/{policy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>Id of the rule that triggered the policy violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Postdeploy contains the postdeploy job configuration information.</summary>
    public class Postdeploy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A sequence of Skaffold custom actions to invoke during execution of the postdeploy job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A postdeploy Job.</summary>
    public class PostdeployJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The custom actions that the postdeploy Job executes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PostdeployJobRun contains information specific to a postdeploy `JobRun`.</summary>
    public class PostdeployJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to execute the custom actions
        /// associated with the postdeploy Job. Format is `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>
        /// Output only. The reason the postdeploy failed. This will always be unspecified while the postdeploy is in
        /// progress or if it succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Output only. Additional information about the postdeploy failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Predeploy contains the predeploy job configuration information.</summary>
    public class Predeploy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A sequence of Skaffold custom actions to invoke during execution of the predeploy job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A predeploy Job.</summary>
    public class PredeployJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The custom actions that the predeploy Job executes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PredeployJobRun contains information specific to a predeploy `JobRun`.</summary>
    public class PredeployJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to execute the custom actions
        /// associated with the predeploy Job. Format is `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>
        /// Output only. The reason the predeploy failed. This will always be unspecified while the predeploy is in
        /// progress or if it succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Output only. Additional information about the predeploy failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execution using a private Cloud Build pool.</summary>
    public class PrivatePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud Storage location where execution outputs should be stored. This can either be a bucket
        /// ("gs://my-bucket") or a path within a bucket ("gs://my-bucket/my-dir"). If unspecified, a default bucket
        /// located in the same region will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorage")]
        public virtual string ArtifactStorage { get; set; }

        /// <summary>
        /// Optional. Google service account to use for execution. If unspecified, the project execution service account
        /// (-compute@developer.gserviceaccount.com) will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Required. Resource name of the Cloud Build worker pool to use. The format is
        /// `projects/{project}/locations/{location}/workerPools/{pool}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the information of an automated promote-release operation.</summary>
    public class PromoteReleaseOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The starting phase of the rollout created by this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>Output only. The name of the rollout that initiates the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>
        /// Output only. The ID of the target that represents the promotion stage to which the release will be promoted.
        /// The value of this field is the last segment of a target name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Output only. How long the operation will be paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `PromoteRelease` rule will automatically promote a release from the current target to a specified target.
    /// </summary>
    public class PromoteReleaseRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information around the state of the Automation rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual AutomationRuleCondition Condition { get; set; }

        /// <summary>
        /// Optional. The starting phase of the rollout created by this operation. Default to the first phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPhase")]
        public virtual string DestinationPhase { get; set; }

        /// <summary>
        /// Optional. The ID of the stage in the pipeline to which this `Release` is deploying. If unspecified, default
        /// it to the next stage in the promotion flow. The value of this field could be one of the following: * The
        /// last segment of a target name * "@next", the next target in the promotion sequence
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTargetId")]
        public virtual string DestinationTargetId { get; set; }

        /// <summary>
        /// Required. ID of the rule. This id must be unique in the `Automation` resource to which this rule belongs.
        /// The format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. How long the release need to be paused until being promoted to the next target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Release` resource in the Cloud Deploy API. A `Release` defines a specific Skaffold configuration instance
    /// that can be deployed.
    /// </summary>
    public class Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates whether this is an abandoned release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abandoned")]
        public virtual System.Nullable<bool> Abandoned { get; set; }

        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// See https://google.aip.dev/128#annotations for more details such as format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Optional. List of artifacts to pass through to Skaffold command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildArtifacts")]
        public virtual System.Collections.Generic.IList<BuildArtifact> BuildArtifacts { get; set; }

        /// <summary>Output only. Information around the state of the Release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual ReleaseCondition Condition { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `Release` was created.</summary>
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
        /// Output only. Snapshot of the custom target types referenced by the targets taken at release creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTargetTypeSnapshots")]
        public virtual System.Collections.Generic.IList<CustomTargetType> CustomTargetTypeSnapshots { get; set; }

        /// <summary>Output only. Snapshot of the parent pipeline taken at release creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryPipelineSnapshot")]
        public virtual DeliveryPipeline DeliveryPipelineSnapshot { get; set; }

        /// <summary>Optional. The deploy parameters to use for all targets in this release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployParameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> DeployParameters { get; set; }

        /// <summary>Optional. Description of the `Release`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the
        /// following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Name of the `Release`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`. The
        /// `release` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _renderEndTimeRaw;

        private object _renderEndTime;

        /// <summary>Output only. Time at which the render completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderEndTime")]
        public virtual string RenderEndTimeRaw
        {
            get => _renderEndTimeRaw;
            set
            {
                _renderEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _renderEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RenderEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RenderEndTimeDateTimeOffset instead.")]
        public virtual object RenderEndTime
        {
            get => _renderEndTime;
            set
            {
                _renderEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _renderEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RenderEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RenderEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RenderEndTimeRaw);
            set => RenderEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _renderStartTimeRaw;

        private object _renderStartTime;

        /// <summary>Output only. Time at which the render began.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderStartTime")]
        public virtual string RenderStartTimeRaw
        {
            get => _renderStartTimeRaw;
            set
            {
                _renderStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _renderStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RenderStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RenderStartTimeDateTimeOffset instead.")]
        public virtual object RenderStartTime
        {
            get => _renderStartTime;
            set
            {
                _renderStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _renderStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RenderStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RenderStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RenderStartTimeRaw);
            set => RenderStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Current state of the render operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderState")]
        public virtual string RenderState { get; set; }

        /// <summary>Optional. Filepath of the Skaffold config inside of the config URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldConfigPath")]
        public virtual string SkaffoldConfigPath { get; set; }

        /// <summary>Optional. Cloud Storage URI of tar.gz archive containing Skaffold configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldConfigUri")]
        public virtual string SkaffoldConfigUri { get; set; }

        /// <summary>
        /// Optional. The Skaffold version to use when operating on this release, such as "1.20.0". Not all versions are
        /// valid; Cloud Deploy supports a specific set of versions. If unset, the most recent supported Skaffold
        /// version will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldVersion")]
        public virtual string SkaffoldVersion { get; set; }

        /// <summary>
        /// Output only. Map from target ID to the target artifacts created during the render operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetArtifacts")]
        public virtual System.Collections.Generic.IDictionary<string, TargetArtifact> TargetArtifacts { get; set; }

        /// <summary>Output only. Map from target ID to details of the render operation for that target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRenders")]
        public virtual System.Collections.Generic.IDictionary<string, TargetRender> TargetRenders { get; set; }

        /// <summary>Output only. Snapshot of the targets taken at release creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSnapshots")]
        public virtual System.Collections.Generic.IList<Target> TargetSnapshots { get; set; }

        /// <summary>Output only. Unique identifier of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }
    }

    /// <summary>ReleaseCondition contains all conditions relevant to a Release.</summary>
    public class ReleaseCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details around the Releases's overall status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseReadyCondition")]
        public virtual ReleaseReadyCondition ReleaseReadyCondition { get; set; }

        /// <summary>Details around the support state of the release's Skaffold version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldSupportedCondition")]
        public virtual SkaffoldSupportedCondition SkaffoldSupportedCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/release_notification" Platform Log event that describes the
    /// failure to send release status change Pub/Sub notification.
    /// </summary>
    public class ReleaseNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>The name of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>Unique identifier of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseUid")]
        public virtual string ReleaseUid { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ReleaseReadyCondition contains information around the status of the Release. If a release is not ready, you
    /// cannot create a rollout with the release.
    /// </summary>
    public class ReleaseReadyCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the Release is in a valid state. Otherwise at least one condition in `ReleaseCondition` is in an
        /// invalid state. Iterate over those conditions and see which condition(s) has status = false to find out what
        /// is wrong with the Release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/release_render" Platform Log event that describes the render
    /// status change.
    /// </summary>
    public class ReleaseRenderEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Debug message for when a render transition occurs. Provides further details as rendering progresses through
        /// render states.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>
        /// The name of the release. release_uid is not in this log message because we write some of these log messages
        /// at release creation time, before we've generated the uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>The state of the release render.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseRenderState")]
        public virtual string ReleaseRenderState { get; set; }

        /// <summary>Type of this notification, e.g. for a release render state change event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RenderMetadata includes information associated with a `Release` render.</summary>
    public class RenderMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Metadata associated with rendering for Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRun")]
        public virtual CloudRunRenderMetadata CloudRun { get; set; }

        /// <summary>Output only. Custom metadata provided by user-defined render operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomMetadata Custom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RepairPhase tracks the repair attempts that have been made for each `RepairPhaseConfig` specified in the
    /// `Automation` resource.
    /// </summary>
    public class RepairPhase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Records of the retry attempts for retry repair mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retry")]
        public virtual RetryPhase Retry { get; set; }

        /// <summary>Output only. Rollback attempt for rollback repair mode .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollback")]
        public virtual RollbackAttempt Rollback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of the repair phase.</summary>
    public class RepairPhaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Retries a failed job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retry")]
        public virtual Retry Retry { get; set; }

        /// <summary>Optional. Rolls back a `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollback")]
        public virtual Rollback Rollback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the information for an automated `repair rollout` operation.</summary>
    public class RepairRolloutOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The index of the current repair action in the repair sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentRepairPhaseIndex")]
        public virtual System.Nullable<long> CurrentRepairPhaseIndex { get; set; }

        /// <summary>Output only. The job ID for the Job to repair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>Output only. The phase ID of the phase that includes the job being repaired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>
        /// Output only. Records of the repair attempts. Each repair phase may have multiple retry attempts or single
        /// rollback attempt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repairPhases")]
        public virtual System.Collections.Generic.IList<RepairPhase> RepairPhases { get; set; }

        /// <summary>Output only. The name of the rollout that initiates the `AutomationRun`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The `RepairRolloutRule` automation rule will automatically repair a failed `Rollout`.</summary>
    public class RepairRolloutRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information around the state of the 'Automation' rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual AutomationRuleCondition Condition { get; set; }

        /// <summary>
        /// Required. ID of the rule. This id must be unique in the `Automation` resource to which this rule belongs.
        /// The format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Jobs to repair. Proceeds only after job name matched any one in the list, or for all jobs if
        /// unspecified or empty. The phase that includes the job must match the phase ID specified in `source_phase`.
        /// This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a
        /// letter or a number, and have a max length of 63 characters. In other words, it must match the following
        /// regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<string> Jobs { get; set; }

        /// <summary>
        /// Optional. Phases within which jobs are subject to automatic repair actions on failure. Proceeds only after
        /// phase name matched any one in the list, or for all phases if unspecified. This value must consist of
        /// lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a
        /// max length of 63 characters. In other words, it must match the following regex:
        /// `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phases")]
        public virtual System.Collections.Generic.IList<string> Phases { get; set; }

        /// <summary>Required. Defines the types of automatic repair phases for failed jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repairPhases")]
        public virtual System.Collections.Generic.IList<RepairPhaseConfig> RepairPhases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retries the failed job.</summary>
    public class Retry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Total number of retries. Retry is skipped if set to 0; The minimum value is 1, and the maximum
        /// value is 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attempts")]
        public virtual System.Nullable<long> Attempts { get; set; }

        /// <summary>
        /// Optional. The pattern of how wait time will be increased. Default is linear. Backoff mode will be ignored if
        /// `wait` is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backoffMode")]
        public virtual string BackoffMode { get; set; }

        /// <summary>
        /// Optional. How long to wait for the first retry. Default is 0, and the maximum value is 14d.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RetryAttempt represents an action of retrying the failed Cloud Deploy job.</summary>
    public class RetryAttempt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The index of this retry attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attempt")]
        public virtual System.Nullable<long> Attempt { get; set; }

        /// <summary>Output only. Valid state of this retry action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Description of the state of the Retry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDesc")]
        public virtual string StateDesc { get; set; }

        /// <summary>Output only. How long the operation will be paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wait")]
        public virtual object Wait { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RetryJobRequest is the request object used by `RetryJob`.</summary>
    public class RetryJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The job ID for the Job to retry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>Required. The phase ID the Job to retry belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseId")]
        public virtual string PhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from 'RetryJob'.</summary>
    public class RetryJobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RetryPhase contains the retry attempts and the metadata for initiating a new attempt.</summary>
    public class RetryPhase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Detail of a retry action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attempts")]
        public virtual System.Collections.Generic.IList<RetryAttempt> Attempts { get; set; }

        /// <summary>Output only. The pattern of how the wait time of the retry attempt is calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backoffMode")]
        public virtual string BackoffMode { get; set; }

        /// <summary>Output only. The number of attempts that have been made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalAttempts")]
        public virtual System.Nullable<long> TotalAttempts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rolls back a `Rollout`.</summary>
    public class Rollback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The starting phase ID for the `Rollout`. If unspecified, the `Rollout` will start in the stable
        /// phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPhase")]
        public virtual string DestinationPhase { get; set; }

        /// <summary>
        /// Optional. If pending rollout exists on the target, the rollback operation will be aborted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableRollbackIfRolloutPending")]
        public virtual System.Nullable<bool> DisableRollbackIfRolloutPending { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RollbackAttempt represents an action of rolling back a Cloud Deploy 'Target'.</summary>
    public class RollbackAttempt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The phase to which the rollout will be rolled back to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPhase")]
        public virtual string DestinationPhase { get; set; }

        /// <summary>Output only. If active rollout exists on the target, abort this rollback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableRollbackIfRolloutPending")]
        public virtual System.Nullable<bool> DisableRollbackIfRolloutPending { get; set; }

        /// <summary>Output only. ID of the rollback `Rollout` to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutId")]
        public virtual string RolloutId { get; set; }

        /// <summary>Output only. Valid state of this rollback action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Description of the state of the Rollback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateDesc")]
        public virtual string StateDesc { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs for the Rollback rollout.</summary>
    public class RollbackTargetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The rollback `Rollout` to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual Rollout Rollout { get; set; }

        /// <summary>
        /// Optional. The starting phase ID for the `Rollout`. If unspecified, the `Rollout` will start in the stable
        /// phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startingPhaseId")]
        public virtual string StartingPhaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object for `RollbackTarget`.</summary>
    public class RollbackTargetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deploy_policy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>
        /// Optional. ID of the `Release` to roll back to. If this isn't specified, the previous successful `Rollout` to
        /// the specified target will be used to determine the `Release`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseId")]
        public virtual string ReleaseId { get; set; }

        /// <summary>Optional. Configs for the rollback `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollbackConfig")]
        public virtual RollbackTargetConfig RollbackConfig { get; set; }

        /// <summary>Required. ID of the rollback `Rollout` to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutId")]
        public virtual string RolloutId { get; set; }

        /// <summary>Optional. If provided, this must be the latest `Rollout` that is on the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutToRollBack")]
        public virtual string RolloutToRollBack { get; set; }

        /// <summary>Required. ID of the `Target` that is being rolled back.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>
        /// Optional. If set to true, the request is validated and the user is provided with a `RollbackTargetResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `RollbackTarget`.</summary>
    public class RollbackTargetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The config of the rollback `Rollout` created or will be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollbackConfig")]
        public virtual RollbackTargetConfig RollbackConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Rollout` resource in the Cloud Deploy API. A `Rollout` contains information around a specific deployment to a
    /// `Target`.
    /// </summary>
    public class Rollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The AutomationRun actively repairing the rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeRepairAutomationRun")]
        public virtual string ActiveRepairAutomationRun { get; set; }

        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// See https://google.aip.dev/128#annotations for more details such as format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Approval state of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalState")]
        public virtual string ApprovalState { get; set; }

        private string _approveTimeRaw;

        private object _approveTime;

        /// <summary>Output only. Time at which the `Rollout` was approved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approveTime")]
        public virtual string ApproveTimeRaw
        {
            get => _approveTimeRaw;
            set
            {
                _approveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _approveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApproveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApproveTimeDateTimeOffset instead.")]
        public virtual object ApproveTime
        {
            get => _approveTime;
            set
            {
                _approveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _approveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApproveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApproveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApproveTimeRaw);
            set => ApproveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Name of the `ControllerRollout`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controllerRollout")]
        public virtual string ControllerRollout { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `Rollout` was created.</summary>
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

        private string _deployEndTimeRaw;

        private object _deployEndTime;

        /// <summary>Output only. Time at which the `Rollout` finished deploying.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployEndTime")]
        public virtual string DeployEndTimeRaw
        {
            get => _deployEndTimeRaw;
            set
            {
                _deployEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deployEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeployEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeployEndTimeDateTimeOffset instead.")]
        public virtual object DeployEndTime
        {
            get => _deployEndTime;
            set
            {
                _deployEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deployEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeployEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeployEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeployEndTimeRaw);
            set => DeployEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The reason this rollout failed. This will always be unspecified while the rollout is in
        /// progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployFailureCause")]
        public virtual string DeployFailureCause { get; set; }

        private string _deployStartTimeRaw;

        private object _deployStartTime;

        /// <summary>Output only. Time at which the `Rollout` started deploying.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployStartTime")]
        public virtual string DeployStartTimeRaw
        {
            get => _deployStartTimeRaw;
            set
            {
                _deployStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deployStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeployStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeployStartTimeDateTimeOffset instead.")]
        public virtual object DeployStartTime
        {
            get => _deployStartTime;
            set
            {
                _deployStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deployStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DeployStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeployStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeployStartTimeRaw);
            set => DeployStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to deploy the Rollout. Format
        /// is `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployingBuild")]
        public virtual string DeployingBuild { get; set; }

        /// <summary>Optional. Description of the `Rollout` for user purposes. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _enqueueTimeRaw;

        private object _enqueueTime;

        /// <summary>Output only. Time at which the `Rollout` was enqueued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enqueueTime")]
        public virtual string EnqueueTimeRaw
        {
            get => _enqueueTimeRaw;
            set
            {
                _enqueueTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _enqueueTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EnqueueTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EnqueueTimeDateTimeOffset instead.")]
        public virtual object EnqueueTime
        {
            get => _enqueueTime;
            set
            {
                _enqueueTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _enqueueTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EnqueueTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EnqueueTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EnqueueTimeRaw);
            set => EnqueueTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Additional information about the rollout failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>
        /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the
        /// following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Metadata contains information about the rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>
        /// Identifier. Name of the `Rollout`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// The `rollout` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The phases that represent the workflows of this `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phases")]
        public virtual System.Collections.Generic.IList<Phase> Phases { get; set; }

        /// <summary>
        /// Output only. Name of the `Rollout` that is rolled back by this `Rollout`. Empty if this `Rollout` wasn't
        /// created as a rollback.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollbackOfRollout")]
        public virtual string RollbackOfRollout { get; set; }

        /// <summary>Output only. Names of `Rollouts` that rolled back this `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolledBackByRollouts")]
        public virtual System.Collections.Generic.IList<string> RolledBackByRollouts { get; set; }

        /// <summary>Output only. Current state of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. The ID of Target to which this `Rollout` is deploying.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Output only. Unique identifier of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/rollout_notification" Platform Log event that describes the
    /// failure to send rollout status change Pub/Sub notification.
    /// </summary>
    public class RolloutNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the `DeliveryPipeline`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>The name of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>Unique identifier of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseUid")]
        public virtual string ReleaseUid { get; set; }

        /// <summary>The name of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>Unique identifier of the `Rollout`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUid")]
        public virtual string RolloutUid { get; set; }

        /// <summary>ID of the `Target` that the rollout is deployed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rollout restrictions.</summary>
    public class RolloutRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Rollout actions to be restricted as part of the policy. If left empty, all actions will be
        /// restricted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>
        /// Required. Restriction rule ID. Required and must be unique within a DeployPolicy. The format is
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. What invoked the action. If left empty, all invoker types will be restricted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invokers")]
        public virtual System.Collections.Generic.IList<string> Invokers { get; set; }

        /// <summary>Required. Time window within which actions are restricted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeWindows")]
        public virtual TimeWindows TimeWindows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/rollout_update" Platform Log event that describes the rollout
    /// update event.
    /// </summary>
    public class RolloutUpdateEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug message for when a rollout update event occurs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Unique identifier of the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineUid")]
        public virtual string PipelineUid { get; set; }

        /// <summary>The name of the `Release`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>Unique identifier of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseUid")]
        public virtual string ReleaseUid { get; set; }

        /// <summary>
        /// The name of the rollout. rollout_uid is not in this log message because we write some of these log messages
        /// at rollout creation time, before we've generated the uid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual string Rollout { get; set; }

        /// <summary>The type of the rollout update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateType")]
        public virtual string RolloutUpdateType { get; set; }

        /// <summary>ID of the target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Type of this notification, e.g. for a rollout update event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about route destinations for the Gateway API service mesh.</summary>
    public class RouteDestinations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The clusters where the Gateway API HTTPRoute resource will be deployed to. Valid entries include
        /// the associated entities IDs configured in the Target resource and "@self" to include the Target cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIds")]
        public virtual System.Collections.Generic.IList<string> DestinationIds { get; set; }

        /// <summary>
        /// Optional. Whether to propagate the Kubernetes Service to the route destination clusters. The Service will
        /// always be deployed to the Target cluster even if the HTTPRoute is not. This option may be used to facilitate
        /// successful DNS lookup in the route destination clusters. Can only be set to true if destinations are
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propagateService")]
        public virtual System.Nullable<bool> PropagateService { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RuntimeConfig contains the runtime specific configurations for a deployment strategy.</summary>
    public class RuntimeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Cloud Run runtime configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRun")]
        public virtual CloudRunConfig CloudRun { get; set; }

        /// <summary>Optional. Kubernetes runtime configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual KubernetesConfig Kubernetes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SerialPipeline defines a sequential set of stages for a `DeliveryPipeline`.</summary>
    public class SerialPipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Each stage specifies configuration for a `Target`. The ordering of this list defines the promotion
        /// flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<Stage> Stages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the Kubernetes Service networking configuration.</summary>
    public class ServiceNetworking : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the Kubernetes Deployment whose traffic is managed by the specified Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>
        /// Optional. Whether to disable Pod overprovisioning. If Pod overprovisioning is disabled then Cloud Deploy
        /// will limit the number of total Pods used for the deployment strategy to the number of Pods the Deployment
        /// has on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePodOverprovisioning")]
        public virtual System.Nullable<bool> DisablePodOverprovisioning { get; set; }

        /// <summary>
        /// Optional. The label to use when selecting Pods for the Deployment resource. This label must already be
        /// present in the Deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podSelectorLabel")]
        public virtual string PodSelectorLabel { get; set; }

        /// <summary>Required. Name of the Kubernetes Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Build V2 Repository containing Skaffold Configs.</summary>
    public class SkaffoldGCBRepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative path from the repository root to the Skaffold Config file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Optional. Branch or tag to use when cloning the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        /// <summary>
        /// Required. Name of the Cloud Build V2 Repository. Format is
        /// projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Storage bucket containing Skaffold Config modules.</summary>
    public class SkaffoldGCSSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative path from the source to the Skaffold file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Required. Cloud Storage source paths to copy recursively. For example, providing
        /// "gs://my-bucket/dir/configs/*" will result in Skaffold copying all files within the "dir/configs" directory
        /// in the bucket "my-bucket".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Git repository containing Skaffold Config modules.</summary>
    public class SkaffoldGitSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative path from the repository root to the Skaffold file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Optional. Git branch or tag to use when cloning the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        /// <summary>Required. Git repository the package should be cloned from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repo")]
        public virtual string Repo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Skaffold Config modules and their remote source.</summary>
    public class SkaffoldModules : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Skaffold Config modules to use from the specified source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<string> Configs { get; set; }

        /// <summary>Optional. Remote git repository containing the Skaffold Config modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual SkaffoldGitSource Git { get; set; }

        /// <summary>Optional. Cloud Build V2 repository containing the Skaffold Config modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudBuildRepo")]
        public virtual SkaffoldGCBRepoSource GoogleCloudBuildRepo { get; set; }

        /// <summary>Optional. Cloud Storage bucket containing the Skaffold Config modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStorage")]
        public virtual SkaffoldGCSSource GoogleCloudStorage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SkaffoldSupportedCondition contains information about when support for the release's version of Skaffold ends.
    /// </summary>
    public class SkaffoldSupportedCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _maintenanceModeTimeRaw;

        private object _maintenanceModeTime;

        /// <summary>The time at which this release's version of Skaffold will enter maintenance mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceModeTime")]
        public virtual string MaintenanceModeTimeRaw
        {
            get => _maintenanceModeTimeRaw;
            set
            {
                _maintenanceModeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _maintenanceModeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MaintenanceModeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MaintenanceModeTimeDateTimeOffset instead.")]
        public virtual object MaintenanceModeTime
        {
            get => _maintenanceModeTime;
            set
            {
                _maintenanceModeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _maintenanceModeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MaintenanceModeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MaintenanceModeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MaintenanceModeTimeRaw);
            set => MaintenanceModeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The Skaffold support state for this release's version of Skaffold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldSupportState")]
        public virtual string SkaffoldSupportState { get; set; }

        /// <summary>True if the version of Skaffold used by this release is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        private string _supportExpirationTimeRaw;

        private object _supportExpirationTime;

        /// <summary>The time at which this release's version of Skaffold will no longer be supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportExpirationTime")]
        public virtual string SupportExpirationTimeRaw
        {
            get => _supportExpirationTimeRaw;
            set
            {
                _supportExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _supportExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SupportExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SupportExpirationTimeDateTimeOffset instead.")]
        public virtual object SupportExpirationTime
        {
            get => _supportExpirationTime;
            set
            {
                _supportExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _supportExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SupportExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SupportExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SupportExpirationTimeRaw);
            set => SupportExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a supported Skaffold version.</summary>
    public class SkaffoldVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _maintenanceModeTimeRaw;

        private object _maintenanceModeTime;

        /// <summary>The time at which this version of Skaffold will enter maintenance mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceModeTime")]
        public virtual string MaintenanceModeTimeRaw
        {
            get => _maintenanceModeTimeRaw;
            set
            {
                _maintenanceModeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _maintenanceModeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MaintenanceModeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MaintenanceModeTimeDateTimeOffset instead.")]
        public virtual object MaintenanceModeTime
        {
            get => _maintenanceModeTime;
            set
            {
                _maintenanceModeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _maintenanceModeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MaintenanceModeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MaintenanceModeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MaintenanceModeTimeRaw);
            set => MaintenanceModeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Date when this version is expected to no longer be supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEndDate")]
        public virtual Date SupportEndDate { get; set; }

        private string _supportExpirationTimeRaw;

        private object _supportExpirationTime;

        /// <summary>The time at which this version of Skaffold will no longer be supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportExpirationTime")]
        public virtual string SupportExpirationTimeRaw
        {
            get => _supportExpirationTimeRaw;
            set
            {
                _supportExpirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _supportExpirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SupportExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SupportExpirationTimeDateTimeOffset instead.")]
        public virtual object SupportExpirationTime
        {
            get => _supportExpirationTime;
            set
            {
                _supportExpirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _supportExpirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SupportExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SupportExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SupportExpirationTimeRaw);
            set => SupportExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Release version number. For example, "1.20.3".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stage specifies a location to which to deploy.</summary>
    public class Stage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The deploy parameters to use for the target in this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployParameters")]
        public virtual System.Collections.Generic.IList<DeployParameters> DeployParameters { get; set; }

        /// <summary>Optional. Skaffold profiles to use when rendering the manifest for this stage's `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profiles")]
        public virtual System.Collections.Generic.IList<string> Profiles { get; set; }

        /// <summary>Optional. The strategy to use for a `Rollout` to this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strategy")]
        public virtual Strategy Strategy { get; set; }

        /// <summary>
        /// Optional. The target_id to which this stage points. This field refers exclusively to the last segment of a
        /// target name. For example, this field would just be `my-target` (rather than
        /// `projects/project/locations/location/targets/my-target`). The location of the `Target` is inferred to be the
        /// same as the location of the `DeliveryPipeline` that contains this `Stage`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Standard represents the standard deployment strategy.</summary>
    public class Standard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configuration for the postdeploy job. If this is not configured, postdeploy job will not be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postdeploy")]
        public virtual Postdeploy Postdeploy { get; set; }

        /// <summary>
        /// Optional. Configuration for the predeploy job. If this is not configured, predeploy job will not be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predeploy")]
        public virtual Predeploy Predeploy { get; set; }

        /// <summary>Optional. Whether to verify a deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verify")]
        public virtual System.Nullable<bool> Verify { get; set; }

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

    /// <summary>Strategy contains deployment strategy information.</summary>
    public class Strategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Canary deployment strategy provides progressive percentage based deployments to a Target.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canary")]
        public virtual Canary Canary { get; set; }

        /// <summary>
        /// Optional. Standard deployment strategy executes a single deploy and allows verifying the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual Standard Standard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `Target` resource in the Cloud Deploy API. A `Target` defines a location to which a Skaffold configuration can
    /// be deployed.
    /// </summary>
    public class Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy.
        /// See https://google.aip.dev/128#annotations for more details such as format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Optional. Information specifying an Anthos Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anthosCluster")]
        public virtual AnthosCluster AnthosCluster { get; set; }

        /// <summary>
        /// Optional. Map of entity IDs to their associated entities. Associated entities allows specifying places other
        /// than the deployment target for specific features. For example, the Gateway API canary can be configured to
        /// deploy the HTTPRoute to a different cluster(s) than the deployment cluster using associated entities. An
        /// entity ID must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a
        /// letter or a number, and have a max length of 63 characters. In other words, it must match the following
        /// regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedEntities")]
        public virtual System.Collections.Generic.IDictionary<string, AssociatedEntities> AssociatedEntities { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the `Target` was created.</summary>
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

        /// <summary>Optional. Information specifying a Custom Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTarget")]
        public virtual CustomTarget CustomTarget { get; set; }

        /// <summary>Optional. The deploy parameters to use for this target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployParameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> DeployParameters { get; set; }

        /// <summary>Optional. Description of the `Target`. Max length is 255 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Configurations for all execution that relates to this `Target`. Each `ExecutionEnvironmentUsage`
        /// value may only be used in a single configuration; using the same value multiple times is an error. When one
        /// or more configurations are specified, they must include the `RENDER` and `DEPLOY`
        /// `ExecutionEnvironmentUsage` values. When no configurations are specified, execution will use the default
        /// specified in `DefaultPool`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionConfigs")]
        public virtual System.Collections.Generic.IList<ExecutionConfig> ExecutionConfigs { get; set; }

        /// <summary>Optional. Information specifying a GKE Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gke")]
        public virtual GkeCluster Gke { get; set; }

        /// <summary>
        /// Optional. Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must
        /// meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters,
        /// underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed.
        /// * Keys must start with a lowercase letter or international character. * Each resource is limited to a
        /// maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Information specifying a multiTarget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiTarget")]
        public virtual MultiTarget MultiTarget { get; set; }

        /// <summary>
        /// Identifier. Name of the `Target`. Format is `projects/{project}/locations/{location}/targets/{target}`. The
        /// `target` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Whether or not the `Target` requires approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireApproval")]
        public virtual System.Nullable<bool> RequireApproval { get; set; }

        /// <summary>Optional. Information specifying a Cloud Run deployment target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("run")]
        public virtual CloudRunLocation Run { get; set; }

        /// <summary>Output only. Resource id of the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>Output only. Unique identifier of the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Most recent time at which the `Target` was updated.</summary>
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

    /// <summary>The artifacts produced by a target render operation.</summary>
    public class TargetArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. URI of a directory containing the artifacts. This contains deployment configuration used by
        /// Skaffold during a rollout, and all paths are relative to this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactUri")]
        public virtual string ArtifactUri { get; set; }

        /// <summary>Output only. File path of the rendered manifest relative to the URI for the stable phase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestPath")]
        public virtual string ManifestPath { get; set; }

        /// <summary>Output only. Map from the phase ID to the phase artifacts for the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phaseArtifacts")]
        public virtual System.Collections.Generic.IDictionary<string, PhaseArtifact> PhaseArtifacts { get; set; }

        /// <summary>
        /// Output only. File path of the resolved Skaffold configuration for the stable phase, relative to the URI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skaffoldConfigPath")]
        public virtual string SkaffoldConfigPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains criteria for selecting Targets. This could be used to select targets for a Deploy Policy or for an
    /// Automation.
    /// </summary>
    public class TargetAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ID of the `Target`. The value of this field could be one of the following: * The last segment of a
        /// target name * "*", all targets in a location
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Target labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Payload proto for "clouddeploy.googleapis.com/target_notification" Platform Log event that describes the failure
    /// to send target status change Pub/Sub notification.
    /// </summary>
    public class TargetNotificationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Debug message for when a notification fails to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The name of the `Target`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Type of this notification, e.g. for a Pub/Sub failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of rendering for a single target.</summary>
    public class TargetRender : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Reason this render failed. This will always be unspecified while the render in progress.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Output only. Additional information about the render failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>Output only. Metadata related to the `Release` render for this Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual RenderMetadata Metadata { get; set; }

        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to render the manifest for
        /// this target. Format is `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderingBuild")]
        public virtual string RenderingBuild { get; set; }

        /// <summary>Output only. Current state of the render operation for this Target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renderingState")]
        public virtual string RenderingState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The targets involved in a single timed promotion.</summary>
    public class Targets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The destination target ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTargetId")]
        public virtual string DestinationTargetId { get; set; }

        /// <summary>Optional. The source target ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTargetId")]
        public virtual string SourceTargetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `TargetsPresentCondition` contains information on any Targets referenced in the Delivery Pipeline that do not
    /// actually exist.
    /// </summary>
    public class TargetsPresentCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of Target names that do not exist. For example,
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingTargets")]
        public virtual System.Collections.Generic.IList<string> MissingTargets { get; set; }

        /// <summary>True if there aren't any missing Targets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Last time the condition was updated.</summary>
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
    /// TargetsTypeCondition contains information on whether the Targets defined in the Delivery Pipeline are of the
    /// same type.
    /// </summary>
    public class TargetsTypeCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human readable error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorDetails")]
        public virtual string ErrorDetails { get; set; }

        /// <summary>
        /// True if the targets are all a comparable type. For example this is true if all targets are GKE clusters.
        /// This is false if some targets are Cloud Run targets and others are GKE clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request object used by `TerminateJobRun`.</summary>
    public class TerminateJobRunRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deploy policies to override. Format is
        /// `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideDeployPolicy")]
        public virtual System.Collections.Generic.IList<string> OverrideDeployPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response object from `TerminateJobRun`.</summary>
    public class TerminateJobRunResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Time windows within which actions are restricted. See the
    /// [documentation](https://cloud.google.com/deploy/docs/deploy-policy#dates_times) for more information on how to
    /// configure dates/times.
    /// </summary>
    public class TimeWindows : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. One-time windows within which actions are restricted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeWindows")]
        public virtual System.Collections.Generic.IList<OneTimeWindow> OneTimeWindows { get; set; }

        /// <summary>
        /// Required. The time zone in IANA format [IANA Time Zone Database](https://www.iana.org/time-zones) (e.g.
        /// America/New_York).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Optional. Recurring weekly windows within which actions are restricted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyWindows")]
        public virtual System.Collections.Generic.IList<WeeklyWindow> WeeklyWindows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `TimedPromoteReleaseCondition` contains conditions specific to an Automation with a Timed Promote Release rule
    /// defined.
    /// </summary>
    public class TimedPromoteReleaseCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _nextPromotionTimeRaw;

        private object _nextPromotionTime;

        /// <summary>Output only. When the next scheduled promotion(s) will occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPromotionTime")]
        public virtual string NextPromotionTimeRaw
        {
            get => _nextPromotionTimeRaw;
            set
            {
                _nextPromotionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextPromotionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextPromotionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextPromotionTimeDateTimeOffset instead.")]
        public virtual object NextPromotionTime
        {
            get => _nextPromotionTime;
            set
            {
                _nextPromotionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextPromotionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextPromotionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextPromotionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextPromotionTimeRaw);
            set => NextPromotionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. A list of targets involved in the upcoming timed promotion(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetsList")]
        public virtual System.Collections.Generic.IList<Targets> TargetsList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the information of an automated timed promote-release operation.</summary>
    public class TimedPromoteReleaseOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The starting phase of the rollout created by this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>Output only. The name of the release to be promoted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("release")]
        public virtual string Release { get; set; }

        /// <summary>
        /// Output only. The ID of the target that represents the promotion stage to which the release will be promoted.
        /// The value of this field is the last segment of a target name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual string TargetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `TimedPromoteReleaseRule` will automatically promote a release from the current target(s) to the specified
    /// target(s) on a configured schedule.
    /// </summary>
    public class TimedPromoteReleaseRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information around the state of the Automation rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual AutomationRuleCondition Condition { get; set; }

        /// <summary>
        /// Optional. The starting phase of the rollout created by this rule. Default to the first phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPhase")]
        public virtual string DestinationPhase { get; set; }

        /// <summary>
        /// Optional. The ID of the stage in the pipeline to which this `Release` is deploying. If unspecified, default
        /// it to the next stage in the promotion flow. The value of this field could be one of the following: * The
        /// last segment of a target name * "@next", the next target in the promotion sequence
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationTargetId")]
        public virtual string DestinationTargetId { get; set; }

        /// <summary>
        /// Required. ID of the rule. This ID must be unique in the `Automation` resource to which this rule belongs.
        /// The format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. Schedule in crontab format. e.g. "0 9 * * 1" for every Monday at 9am.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>
        /// Required. The time zone in IANA format [IANA Time Zone Database](https://www.iana.org/time-zones) (e.g.
        /// America/New_York).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A verify Job.</summary>
    public class VerifyJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VerifyJobRun contains information specific to a verify `JobRun`.</summary>
    public class VerifyJobRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. URI of a directory containing the verify artifacts. This contains the Skaffold event log.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactUri")]
        public virtual string ArtifactUri { get; set; }

        /// <summary>
        /// Output only. The resource name of the Cloud Build `Build` object that is used to verify. Format is
        /// `projects/{project}/locations/{location}/builds/{build}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual string Build { get; set; }

        /// <summary>Output only. File path of the Skaffold event log relative to the artifact URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventLogPath")]
        public virtual string EventLogPath { get; set; }

        /// <summary>
        /// Output only. The reason the verify failed. This will always be unspecified while the verify is in progress
        /// or if it succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureCause")]
        public virtual string FailureCause { get; set; }

        /// <summary>Output only. Additional information about the verify failure, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Weekly windows. For example, blocking actions every Saturday and Sunday. Another example would be blocking
    /// actions every weekday from 5pm to midnight.
    /// </summary>
    public class WeeklyWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Days of week. If left empty, all days of the week will be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfWeek")]
        public virtual System.Collections.Generic.IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// Optional. End time (exclusive). Use 24:00 to indicate midnight. If you specify end_time you must also
        /// specify start_time. If left empty, this will block for the entire day for the days specified in
        /// days_of_week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual TimeOfDay EndTime { get; set; }

        /// <summary>
        /// Optional. Start time (inclusive). Use 00:00 for the beginning of the day. If you specify start_time you must
        /// also specify end_time. If left empty, this will block for the entire day for the days specified in
        /// days_of_week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
