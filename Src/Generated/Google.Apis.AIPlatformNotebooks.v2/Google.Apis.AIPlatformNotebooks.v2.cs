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

namespace Google.Apis.AIPlatformNotebooks.v2
{
    /// <summary>The AIPlatformNotebooks Service.</summary>
    public class AIPlatformNotebooksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AIPlatformNotebooksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AIPlatformNotebooksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://notebooks.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://notebooks.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "notebooks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Notebooks API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Notebooks API.</summary>
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

    /// <summary>A base abstract class for AIPlatformNotebooks requests.</summary>
    public abstract class AIPlatformNotebooksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AIPlatformNotebooksBaseServiceRequest instance.</summary>
        protected AIPlatformNotebooksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AIPlatformNotebooks parameter list.</summary>
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
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Instances resource.</summary>
            public virtual InstancesResource Instances { get; }

            /// <summary>The "instances" collection of methods.</summary>
            public class InstancesResource
            {
                private const string Resource = "instances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Checks whether a notebook instance is upgradable.</summary>
                /// <param name="notebookInstance">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual CheckUpgradabilityRequest CheckUpgradability(string notebookInstance)
                {
                    return new CheckUpgradabilityRequest(this.service, notebookInstance);
                }

                /// <summary>Checks whether a notebook instance is upgradable.</summary>
                public class CheckUpgradabilityRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.CheckInstanceUpgradabilityResponse>
                {
                    /// <summary>Constructs a new CheckUpgradability request.</summary>
                    public CheckUpgradabilityRequest(Google.Apis.Services.IClientService service, string notebookInstance) : base(service)
                    {
                        NotebookInstance = notebookInstance;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("notebookInstance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string NotebookInstance { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkUpgradability";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+notebookInstance}:checkUpgradability";

                    /// <summary>Initializes CheckUpgradability parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("notebookInstance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "notebookInstance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a new Instance in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual CreateRequest Create(Google.Apis.AIPlatformNotebooks.v2.Data.Instance body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Instance in a given project and location.</summary>
                public class CreateRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.Instance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. User-defined unique ID of this instance.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.Instance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/instances";

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
                        RequestParameters.Add("instanceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instanceId",
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

                /// <summary>Deletes a single Instance.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Instance.</summary>
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                /// <summary>Creates a Diagnostic File and runs Diagnostic Tool given an Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual DiagnoseRequest Diagnose(Google.Apis.AIPlatformNotebooks.v2.Data.DiagnoseInstanceRequest body, string name)
                {
                    return new DiagnoseRequest(this.service, body, name);
                }

                /// <summary>Creates a Diagnostic File and runs Diagnostic Tool given an Instance.</summary>
                public class DiagnoseRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Diagnose request.</summary>
                    public DiagnoseRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.DiagnoseInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.DiagnoseInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "diagnose";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:diagnose";

                    /// <summary>Initializes Diagnose parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Instance.</summary>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Instance.</summary>
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets general backend configurations that might also affect the frontend. Location is required by
                /// CCFE. Although we could bypass it to send location- less request directly to the backend job, we
                /// would need CPE (go/cloud-cpe). Having the location might also be useful depending on the query.
                /// </summary>
                /// <param name="name">Required. Format: `projects/{project_id}/locations/{location}`</param>
                public virtual GetConfigRequest GetConfig(string name)
                {
                    return new GetConfigRequest(this.service, name);
                }

                /// <summary>
                /// Gets general backend configurations that might also affect the frontend. Location is required by
                /// CCFE. Although we could bypass it to send location- less request directly to the backend job, we
                /// would need CPE (go/cloud-cpe). Having the location might also be useful depending on the query.
                /// </summary>
                public class GetConfigRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Config>
                {
                    /// <summary>Constructs a new GetConfig request.</summary>
                    public GetConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/instances:getConfig";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                public class GetIamPolicyRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                /// <summary>Lists instances in a given project and location.</summary>
                /// <param name="parent">Required. Format: `parent=projects/{project_id}/locations/{location}`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists instances in a given project and location.</summary>
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Format: `parent=projects/{project_id}/locations/{location}`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Sort results. Supported values are "name", "name desc" or "" (unsorted).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Optional. Maximum return size of the list call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A previous returned page token that can be used to continue listing from the last
                    /// result.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/instances";

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

                /// <summary>UpdateInstance updates an Instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The name of this notebook instance. Format:
                /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.AIPlatformNotebooks.v2.Data.Instance body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>UpdateInstance updates an Instance.</summary>
                public class PatchRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.Instance body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The name of this notebook instance. Format:
                    /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Idempotent request UUID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Required. Mask used to update an instance</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.Instance Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                    }
                }

                /// <summary>
                /// Allows notebook instances to report their latest instance information to the Notebooks API server.
                /// The server will merge the reported information to the instance metadata store. Do not use this
                /// method directly.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual ReportInfoSystemRequest ReportInfoSystem(Google.Apis.AIPlatformNotebooks.v2.Data.ReportInstanceInfoSystemRequest body, string name)
                {
                    return new ReportInfoSystemRequest(this.service, body, name);
                }

                /// <summary>
                /// Allows notebook instances to report their latest instance information to the Notebooks API server.
                /// The server will merge the reported information to the instance metadata store. Do not use this
                /// method directly.
                /// </summary>
                public class ReportInfoSystemRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new ReportInfoSystem request.</summary>
                    public ReportInfoSystemRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.ReportInstanceInfoSystemRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.ReportInstanceInfoSystemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reportInfoSystem";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:reportInfoSystem";

                    /// <summary>Initializes ReportInfoSystem parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Resets a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual ResetRequest Reset(Google.Apis.AIPlatformNotebooks.v2.Data.ResetInstanceRequest body, string name)
                {
                    return new ResetRequest(this.service, body, name);
                }

                /// <summary>Resets a notebook instance.</summary>
                public class ResetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Reset request.</summary>
                    public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.ResetInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.ResetInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reset";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:reset";

                    /// <summary>Initializes Reset parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Resize a notebook instance disk to a higher capacity.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="notebookInstance">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual ResizeDiskRequest ResizeDisk(Google.Apis.AIPlatformNotebooks.v2.Data.ResizeDiskRequest body, string notebookInstance)
                {
                    return new ResizeDiskRequest(this.service, body, notebookInstance);
                }

                /// <summary>Resize a notebook instance disk to a higher capacity.</summary>
                public class ResizeDiskRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new ResizeDisk request.</summary>
                    public ResizeDiskRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.ResizeDiskRequest body, string notebookInstance) : base(service)
                    {
                        NotebookInstance = notebookInstance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("notebookInstance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string NotebookInstance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.ResizeDiskRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resizeDisk";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+notebookInstance}:resizeDisk";

                    /// <summary>Initializes ResizeDisk parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("notebookInstance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "notebookInstance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>RestoreInstance restores an Instance from a BackupSource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.AIPlatformNotebooks.v2.Data.RestoreInstanceRequest body, string name)
                {
                    return new RestoreRequest(this.service, body, name);
                }

                /// <summary>RestoreInstance restores an Instance from a BackupSource.</summary>
                public class RestoreRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.RestoreInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.RestoreInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Rollbacks a notebook instance to the previous version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual RollbackRequest Rollback(Google.Apis.AIPlatformNotebooks.v2.Data.RollbackInstanceRequest body, string name)
                {
                    return new RollbackRequest(this.service, body, name);
                }

                /// <summary>Rollbacks a notebook instance to the previous version.</summary>
                public class RollbackRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Rollback request.</summary>
                    public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.RollbackInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.RollbackInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollback";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:rollback";

                    /// <summary>Initializes Rollback parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AIPlatformNotebooks.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.AIPlatformNotebooks.v2.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual StartRequest Start(Google.Apis.AIPlatformNotebooks.v2.Data.StartInstanceRequest body, string name)
                {
                    return new StartRequest(this.service, body, name);
                }

                /// <summary>Starts a notebook instance.</summary>
                public class StartRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.StartInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.StartInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops a notebook instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual StopRequest Stop(Google.Apis.AIPlatformNotebooks.v2.Data.StopInstanceRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>Stops a notebook instance.</summary>
                public class StopRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.StopInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.StopInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AIPlatformNotebooks.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.AIPlatformNotebooks.v2.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Upgrades a notebook instance to the latest version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpgradeRequest Upgrade(Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceRequest body, string name)
                {
                    return new UpgradeRequest(this.service, body, name);
                }

                /// <summary>Upgrades a notebook instance to the latest version.</summary>
                public class UpgradeRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Upgrade request.</summary>
                    public UpgradeRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upgrade";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:upgrade";

                    /// <summary>Initializes Upgrade parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Allows notebook instances to upgrade themselves. Do not use this method directly.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                /// </param>
                public virtual UpgradeSystemRequest UpgradeSystem(Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceSystemRequest body, string name)
                {
                    return new UpgradeSystemRequest(this.service, body, name);
                }

                /// <summary>Allows notebook instances to upgrade themselves. Do not use this method directly.</summary>
                public class UpgradeSystemRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
                {
                    /// <summary>Constructs a new UpgradeSystem request.</summary>
                    public UpgradeSystemRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceSystemRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `projects/{project_id}/locations/{location}/instances/{instance_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.UpgradeInstanceSystemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "upgradeSystem";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:upgradeSystem";

                    /// <summary>Initializes UpgradeSystem parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.AIPlatformNotebooks.v2.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.AIPlatformNotebooks.v2.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AIPlatformNotebooks.v2.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Empty>
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
                public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Operation>
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
                public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.ListOperationsResponse>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.Location>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
            public class ListRequest : AIPlatformNotebooksBaseServiceRequest<Google.Apis.AIPlatformNotebooks.v2.Data.ListLocationsResponse>
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
                public override string RestPath => "v2/{+name}/locations";

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
namespace Google.Apis.AIPlatformNotebooks.v2.Data
{
    /// <summary>
    /// An accelerator configuration for a VM instance Definition of a hardware accelerator. Note that there is no check
    /// on `type` and `core_count` combinations. TPUs are not supported. See [GPUs on Compute
    /// Engine](https://cloud.google.com/compute/docs/gpus/#gpus-list) to find a valid combination.
    /// </summary>
    public class AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Count of cores of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreCount")]
        public virtual System.Nullable<long> CoreCount { get; set; }

        /// <summary>Optional. Type of this accelerator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An access configuration attached to an instance's network interface.</summary>
    public class AccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An external IP address associated with this instance. Specify an unused static external IP address available
        /// to the project or leave this field undefined to use an IP from a shared ephemeral IP address pool. If you
        /// specify a static external IP address, it must live in the same region as the zone of the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

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

    /// <summary>The definition of a boot disk.</summary>
    public class BootDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Input only. Disk encryption method used on the boot and data disks, defaults to GMEK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryption")]
        public virtual string DiskEncryption { get; set; }

        /// <summary>
        /// Optional. The size of the boot disk in GB attached to this instance, up to a maximum of 64000 GB (64 TB). If
        /// not specified, this defaults to the recommended value of 150GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>Optional. Indicates the type of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Input only. The KMS key used to encrypt the disks, only applicable if disk_encryption is CMEK.
        /// Format: `projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}` Learn more
        /// about using your own encryption keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for checking if a notebook instance is upgradeable.</summary>
    public class CheckInstanceUpgradabilityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new image self link this instance will be upgraded to if calling the upgrade endpoint. This field will
        /// only be populated if field upgradeable is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeImage")]
        public virtual string UpgradeImage { get; set; }

        /// <summary>Additional information about upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeInfo")]
        public virtual string UpgradeInfo { get; set; }

        /// <summary>
        /// The version this instance will be upgraded to if calling the upgrade endpoint. This field will only be
        /// populated if field upgradeable is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeVersion")]
        public virtual string UpgradeVersion { get; set; }

        /// <summary>If an instance is upgradeable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeable")]
        public virtual System.Nullable<bool> Upgradeable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for getting WbI configurations in a location</summary>
    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of available images to create a WbI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableImages")]
        public virtual System.Collections.Generic.IList<ImageRelease> AvailableImages { get; set; }

        /// <summary>Output only. The default values for configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValues")]
        public virtual DefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Output only. Flag to disable the creation of legacy Workbench notebooks (User-managed notebooks and
        /// Google-managed notebooks).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableWorkbenchLegacyCreation")]
        public virtual System.Nullable<bool> DisableWorkbenchLegacyCreation { get; set; }

        /// <summary>Output only. The supported values for configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedValues")]
        public virtual SupportedValues SupportedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a container image for starting a notebook instance with the environment installed in a container.
    /// </summary>
    public class ContainerImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The path to the container image repository. For example: `gcr.io/{project_id}/{image_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// Optional. The tag of the container image. If not specified, this defaults to the latest tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instance-attached disk resource.</summary>
    public class DataDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Input only. Disk encryption method used on the boot and data disks, defaults to GMEK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskEncryption")]
        public virtual string DiskEncryption { get; set; }

        /// <summary>
        /// Optional. The size of the disk in GB attached to this VM instance, up to a maximum of 64000 GB (64 TB). If
        /// not specified, this defaults to 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>Optional. Input only. Indicates the type of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Input only. The KMS key used to encrypt the disks, only applicable if disk_encryption is CMEK.
        /// Format: `projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}` Learn more
        /// about using your own encryption keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DefaultValues represents the default configuration values.</summary>
    public class DefaultValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The default machine type used by the backend if not provided by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for creating a notebook instance diagnostic file.</summary>
    public class DiagnoseInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Defines flags that are used to run the diagnostic tool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticConfig")]
        public virtual DiagnosticConfig DiagnosticConfig { get; set; }

        /// <summary>Optional. Maximum amount of time in minutes before the operation times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutMinutes")]
        public virtual System.Nullable<int> TimeoutMinutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines flags that are used to run the diagnostic tool</summary>
    public class DiagnosticConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Enables flag to copy all `/home/jupyter` folder contents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCopyHomeFilesFlag")]
        public virtual System.Nullable<bool> EnableCopyHomeFilesFlag { get; set; }

        /// <summary>Optional. Enables flag to capture packets from the instance for 30 seconds</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePacketCaptureFlag")]
        public virtual System.Nullable<bool> EnablePacketCaptureFlag { get; set; }

        /// <summary>Optional. Enables flag to repair service for instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRepairFlag")]
        public virtual System.Nullable<bool> EnableRepairFlag { get; set; }

        /// <summary>
        /// Required. User Cloud Storage bucket location (REQUIRED). Must be formatted with path prefix
        /// (`gs://$GCS_BUCKET`). Permissions: User Managed Notebooks: - storage.buckets.writer: Must be given to the
        /// project's service account attached to VM. Google Managed Notebooks: - storage.buckets.writer: Must be given
        /// to the project's service account or user credentials attached to VM depending on authentication mode. Cloud
        /// Storage bucket Log file will be written to `gs://$GCS_BUCKET/$RELATIVE_PATH/$VM_DATE_$TIME.tar.gz`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

        /// <summary>
        /// Optional. Defines the relative storage path in the Cloud Storage bucket where the diagnostic logs will be
        /// written: Default path will be the root directory of the Cloud Storage bucket
        /// (`gs://$GCS_BUCKET/$DATE_$TIME.tar.gz`) Example of full path where Log file will be written:
        /// `gs://$GCS_BUCKET/$RELATIVE_PATH/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

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

    /// <summary>The definition of an Event for a managed / semi-managed notebook instance.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Event details. This field is used to pass event information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        private string _reportTimeRaw;

        private object _reportTime;

        /// <summary>Optional. Event report time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual string ReportTimeRaw
        {
            get => _reportTimeRaw;
            set
            {
                _reportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _reportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReportTimeDateTimeOffset instead.")]
        public virtual object ReportTime
        {
            get => _reportTime;
            set
            {
                _reportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _reportTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReportTimeRaw);
            set => ReportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>A GPU driver configuration</summary>
    public class GPUDriverConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specify a custom Cloud Storage path where the GPU driver is stored. If not specified, we'll
        /// automatically choose from official GPU drivers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGpuDriverPath")]
        public virtual string CustomGpuDriverPath { get; set; }

        /// <summary>
        /// Optional. Whether the end user authorizes Google Cloud to install GPU driver on this VM instance. If this
        /// field is empty or set to false, the GPU driver won't be installed. Only applicable to instances with GPUs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableGpuDriver")]
        public virtual System.Nullable<bool> EnableGpuDriver { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of how to configure a VM instance outside of Resources and Identity.</summary>
    public class GceSetup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The hardware accelerators used on this instance. If you use accelerators, make sure that your
        /// configuration has [enough vCPUs and memory to support the `machine_type` you have
        /// selected](https://cloud.google.com/compute/docs/gpus/#gpus-list). Currently supports only one accelerator
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorConfigs")]
        public virtual System.Collections.Generic.IList<AcceleratorConfig> AcceleratorConfigs { get; set; }

        /// <summary>Optional. The boot disk for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual BootDisk BootDisk { get; set; }

        /// <summary>Optional. Use a container image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual ContainerImage ContainerImage { get; set; }

        /// <summary>Optional. Data disks attached to the VM instance. Currently supports only one data disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisks")]
        public virtual System.Collections.Generic.IList<DataDisk> DataDisks { get; set; }

        /// <summary>Optional. If true, no external IP will be assigned to this VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePublicIp")]
        public virtual System.Nullable<bool> DisablePublicIp { get; set; }

        /// <summary>
        /// Optional. Flag to enable ip forwarding or not, default false/off.
        /// https://cloud.google.com/vpc/docs/using-routes#canipforward
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIpForwarding")]
        public virtual System.Nullable<bool> EnableIpForwarding { get; set; }

        /// <summary>Optional. Configuration for GPU drivers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuDriverConfig")]
        public virtual GPUDriverConfig GpuDriverConfig { get; set; }

        /// <summary>
        /// Optional. The machine type of the VM instance. https://cloud.google.com/compute/docs/machine-resource
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Optional. Custom metadata to apply to this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Optional. The minimum CPU platform to use for this instance. The list of valid values can be found in
        /// https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>Optional. The network interfaces for the VM. Supports only one interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>
        /// Optional. The service account that serves as an identity for the VM instance. Currently supports only one
        /// service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccounts")]
        public virtual System.Collections.Generic.IList<ServiceAccount> ServiceAccounts { get; set; }

        /// <summary>
        /// Optional. Shielded VM configuration. [Images using supported Shielded VM
        /// features](https://cloud.google.com/compute/docs/instances/modifying-shielded-vm).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// Optional. The Compute Engine network tags to add to runtime (see [Add network
        /// tags](https://cloud.google.com/vpc/docs/add-remove-network-tags)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>Optional. Use a Compute Engine VM image to start the notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual VmImage VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigImage represents an image release available to create a WbI</summary>
    public class ImageRelease : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the image of the form workbench-instances-vYYYYmmdd--</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageName")]
        public virtual string ImageName { get; set; }

        /// <summary>Output only. The release of the image of the form m123</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseName")]
        public virtual string ReleaseName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of a notebook instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Instance creation time.</summary>
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

        /// <summary>Output only. Email address of entity that sent original CreateInstance request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Optional. If true, the notebook instance will not register with the proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableProxyAccess")]
        public virtual System.Nullable<bool> DisableProxyAccess { get; set; }

        /// <summary>
        /// Optional. Flag that specifies that a notebook can be accessed with third party identity provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableThirdPartyIdentity")]
        public virtual System.Nullable<bool> EnableThirdPartyIdentity { get; set; }

        /// <summary>Optional. Compute Engine setup for the notebook. Uses notebook-defined fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceSetup")]
        public virtual GceSetup GceSetup { get; set; }

        /// <summary>
        /// Output only. Additional information about instance health. Example: healthInfo": {
        /// "docker_proxy_agent_status": "1", "docker_status": "1", "jupyterlab_api_status": "-1", "jupyterlab_status":
        /// "-1", "updated": "2020-10-18 09:40:03.573409" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthInfo")]
        public virtual System.Collections.Generic.IDictionary<string, string> HealthInfo { get; set; }

        /// <summary>Output only. Instance health_state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthState")]
        public virtual string HealthState { get; set; }

        /// <summary>Output only. Unique ID of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Input only. The owner of this instance after creation. Format: `alias@example.com` Currently
        /// supports one owner only. If not specified, all of the service account users of your VM instance's service
        /// account can use the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceOwners")]
        public virtual System.Collections.Generic.IList<string> InstanceOwners { get; set; }

        /// <summary>
        /// Optional. Labels to apply to this instance. These can be later modified by the UpdateInstance method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The name of this notebook instance. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The proxy endpoint that is used to access the Jupyter notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyUri")]
        public virtual string ProxyUri { get; set; }

        /// <summary>Output only. Reserved for future use for Zone Isolation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use for Zone Separation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. The state of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The workforce pools proxy endpoint that is used to access the Jupyter notebook.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyProxyUrl")]
        public virtual string ThirdPartyProxyUrl { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Instance update time.</summary>
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

        /// <summary>Output only. The upgrade history of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeHistory")]
        public virtual System.Collections.Generic.IList<UpgradeHistoryEntry> UpgradeHistory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing notebook instances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of returned instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// Page token that can be used to continue listing from the last result in the next list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Locations that could not be reached. For example, ['us-west1-a', 'us-central1-b']. A ListInstancesResponse
        /// will only contain either instances or unreachables,
        /// </summary>
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

    /// <summary>The definition of a network interface resource attached to a VM.</summary>
    public class NetworkInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of configurations for this interface. Currently, only one access config, ONE_TO_ONE_NAT,
        /// is supported. If no accessConfigs specified, the instance will have an external internet access through an
        /// ephemeral external IP address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessConfigs")]
        public virtual System.Collections.Generic.IList<AccessConfig> AccessConfigs { get; set; }

        /// <summary>
        /// Optional. The name of the VPC that this VM instance is in. Format:
        /// `projects/{project_id}/global/networks/{network_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. The type of vNIC to be used on this interface. This may be gVNIC or VirtioNet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nicType")]
        public virtual string NicType { get; set; }

        /// <summary>
        /// Optional. The name of the subnet that this VM instance is in. Format:
        /// `projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

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
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time the operation was created.</summary>
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

        /// <summary>The time the operation finished running.</summary>
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

        /// <summary>API endpoint name of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Identifies whether the user has requested cancellation of the operation. Operations that have successfully
        /// been cancelled have google.longrunning.Operation.error value with a google.rpc.Status.code of `1`,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

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

    /// <summary>Request for notebook instances to report information to Notebooks API.</summary>
    public class ReportInstanceInfoSystemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Event to be reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual Event Event__ { get; set; }

        /// <summary>
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for resetting a notebook instance</summary>
    public class ResetInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for resizing the notebook instance disks</summary>
    public class ResizeDiskRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The boot disk to be resized. Only disk_size_gb will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual BootDisk BootDisk { get; set; }

        /// <summary>Required. The data disk to be resized. Only disk_size_gb will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual DataDisk DataDisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for restoring the notebook instance from a BackupSource.</summary>
    public class RestoreInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Snapshot to be used for restore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual Snapshot Snapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for rollbacking a notebook instance</summary>
    public class RollbackInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Output only. Revision Id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// Required. The snapshot for rollback. Example: "projects/test-project/global/snapshots/krwlzipynril".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSnapshot")]
        public virtual string TargetSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A service account that acts as an identity.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Email address of the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Output only. The list of scopes to be made available for this service account. Set by the CLH to
        /// https://www.googleapis.com/auth/cloud-platform
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of Shielded Instance options. See [Images using supported Shielded VM
    /// features](https://cloud.google.com/compute/docs/instances/modifying-shielded-vm). Not all combinations are
    /// valid.
    /// </summary>
    public class ShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Defines whether the VM instance has integrity monitoring enabled. Enables monitoring and
        /// attestation of the boot integrity of the VM instance. The attestation is performed against the integrity
        /// policy baseline. This baseline is initially derived from the implicitly trusted boot image when the VM
        /// instance is created. Enabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Optional. Defines whether the VM instance has Secure Boot enabled. Secure Boot helps ensure that the system
        /// only runs authentic software by verifying the digital signature of all boot components, and halting the boot
        /// process if signature verification fails. Disabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>Optional. Defines whether the VM instance has the vTPM enabled. Enabled by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Snapshot represents the snapshot of the data disk used to restore the Workbench Instance from. Refers to:
    /// compute/v1/projects/{project_id}/global/snapshots/{snapshot_id}
    /// </summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The project ID of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. The ID of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotId")]
        public virtual string SnapshotId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for starting a notebook instance</summary>
    public class StartInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request for stopping a notebook instance</summary>
    public class StopInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SupportedValues represents the values supported by the configuration.</summary>
    public class SupportedValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The accelerator types supported by WbI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorTypes")]
        public virtual System.Collections.Generic.IList<string> AcceleratorTypes { get; set; }

        /// <summary>Output only. The machine types supported by WbI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineTypes")]
        public virtual System.Collections.Generic.IList<string> MachineTypes { get; set; }

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

    /// <summary>The entry of VM image upgrade history.</summary>
    public class UpgradeHistoryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Action. Rolloback or Upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Optional. The container image before this instance upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual string ContainerImage { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Immutable. The time that this instance upgrade history entry is created.</summary>
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

        /// <summary>Optional. The framework of this notebook instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("framework")]
        public virtual string Framework { get; set; }

        /// <summary>Optional. The snapshot of the boot disk of this notebook instance before upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual string Snapshot { get; set; }

        /// <summary>Output only. The state of this instance upgrade history entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Target VM Version, like m63.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVersion")]
        public virtual string TargetVersion { get; set; }

        /// <summary>Optional. The version of the notebook instance before this upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>Optional. The VM image before this instance upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmImage")]
        public virtual string VmImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for upgrading a notebook instance</summary>
    public class UpgradeInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for upgrading a notebook instance from within the VM</summary>
    public class UpgradeInstanceSystemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The VM hardware token for authenticating the VM.
        /// https://cloud.google.com/compute/docs/instances/verifying-instance-identity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a custom Compute Engine virtual machine image for starting a notebook instance with the
    /// environment installed directly on the VM.
    /// </summary>
    public class VmImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Use this VM image family to find the image; the newest image in this family will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>Optional. Use VM image name to find the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The name of the Google Cloud project that this VM image belongs to. Format: `{project_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
