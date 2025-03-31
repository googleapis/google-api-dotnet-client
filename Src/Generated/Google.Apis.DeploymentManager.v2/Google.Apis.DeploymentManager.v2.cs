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

namespace Google.Apis.DeploymentManager.v2
{
    /// <summary>The DeploymentManager Service.</summary>
    public class DeploymentManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeploymentManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeploymentManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Deployments = new DeploymentsResource(this);
            Manifests = new ManifestsResource(this);
            Operations = new OperationsResource(this);
            Resources = new ResourcesResource(this);
            Types = new TypesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://deploymentmanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://deploymentmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "deploymentmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Deployment Manager V2 API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>
            /// View and manage your Google Cloud Platform management resources and deployment status information
            /// </summary>
            public static string NdevCloudman = "https://www.googleapis.com/auth/ndev.cloudman";

            /// <summary>
            /// View your Google Cloud Platform management resources and deployment status information
            /// </summary>
            public static string NdevCloudmanReadonly = "https://www.googleapis.com/auth/ndev.cloudman.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Deployment Manager V2 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>
            /// View and manage your Google Cloud Platform management resources and deployment status information
            /// </summary>
            public const string NdevCloudman = "https://www.googleapis.com/auth/ndev.cloudman";

            /// <summary>
            /// View your Google Cloud Platform management resources and deployment status information
            /// </summary>
            public const string NdevCloudmanReadonly = "https://www.googleapis.com/auth/ndev.cloudman.readonly";
        }

        /// <summary>Gets the Deployments resource.</summary>
        public virtual DeploymentsResource Deployments { get; }

        /// <summary>Gets the Manifests resource.</summary>
        public virtual ManifestsResource Manifests { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Resources resource.</summary>
        public virtual ResourcesResource Resources { get; }

        /// <summary>Gets the Types resource.</summary>
        public virtual TypesResource Types { get; }
    }

    /// <summary>A base abstract class for DeploymentManager requests.</summary>
    public abstract class DeploymentManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeploymentManagerBaseServiceRequest instance.</summary>
        protected DeploymentManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DeploymentManager parameter list.</summary>
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

    /// <summary>The "deployments" collection of methods.</summary>
    public class DeploymentsResource
    {
        private const string Resource = "deployments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DeploymentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Cancels and removes the preview currently associated with the deployment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual CancelPreviewRequest CancelPreview(Google.Apis.DeploymentManager.v2.Data.DeploymentsCancelPreviewRequest body, string project, string deployment)
        {
            return new CancelPreviewRequest(this.service, body, project, deployment);
        }

        /// <summary>Cancels and removes the preview currently associated with the deployment.</summary>
        public class CancelPreviewRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new CancelPreview request.</summary>
            public CancelPreviewRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.DeploymentsCancelPreviewRequest body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.DeploymentsCancelPreviewRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancelPreview";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/cancelPreview";

            /// <summary>Initializes CancelPreview parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }
        }

        /// <summary>Deletes a deployment and all of the resources in the deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual DeleteRequest Delete(string project, string deployment)
        {
            return new DeleteRequest(this.service, project, deployment);
        }

        /// <summary>Deletes a deployment and all of the resources in the deployment.</summary>
        public class DeleteRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON = 1,
            }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets information about a specific deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual GetRequest Get(string project, string deployment)
        {
            return new GetRequest(this.service, project, deployment);
        }

        /// <summary>Gets information about a specific deployment.</summary>
        public class GetRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Deployment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource for this request.</param>
        public virtual GetIamPolicyRequest GetIamPolicy(string project, string resource)
        {
            return new GetIamPolicyRequest(this.service, project, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. May be empty if no such policy or resource exists.
        /// </summary>
        public class GetIamPolicyRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                InitParameters();
            }

            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Requested IAM Policy version.</summary>
            [Google.Apis.Util.RequestParameterAttribute("optionsRequestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{resource}/getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("optionsRequestedPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "optionsRequestedPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        public virtual InsertRequest Insert(Google.Apis.DeploymentManager.v2.Data.Deployment body, string project)
        {
            return new InsertRequest(this.service, body, project);
        }

        /// <summary>Creates a deployment and all of the resources described by the deployment manifest.</summary>
        public class InsertRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.Deployment body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE = 1,
            }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>
            /// If set to true, creates a deployment and creates "shell" resources but does not actually instantiate
            /// these resources. This allows you to preview what your deployment looks like. After previewing a
            /// deployment, you can deploy your resources by making a request with the `update()` method or you can use
            /// the `cancelPreview()` method to cancel the preview altogether. Note that the deployment will still exist
            /// after you cancel the preview and you must separately delete this deployment if you want to remove it.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all deployments for a given project.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>Lists all deployments for a given project.</summary>
        public class ListRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.DeploymentsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. Most Compute resources support two
            /// types of filter expressions: expressions that support regular expressions and expressions that follow
            /// API improvement proposal AIP-160. These two types of filter expressions cannot be mixed in one request.
            /// If you want to use AIP-160, your expression must specify the field name, an operator, and the value that
            /// you want to use for filtering. The value must be a string, a number, or a boolean. The operator must be
            /// either `=`, `!=`, `&amp;gt;`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;=` or `:`. For example, if you are
            /// filtering Compute Engine instances, you can exclude instances named `example-instance` by specifying
            /// `name != example-instance`. The `:*` comparison can be used to test whether a key has been defined. For
            /// example, to find all objects with `owner` label use:
            /// ```
            /// labels.owner:*
            /// ```
            /// You can also filter nested
            /// fields. For example, you could specify `scheduling.automaticRestart = false` to include instances only
            /// if they are not scheduled for automatic restarts. You can use filtering on nested fields to filter based
            /// on resource labels. To filter on multiple expressions, provide each separate expression within
            /// parentheses. For example:
            /// ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake")
            /// ```
            /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR` expressions
            /// explicitly. For example:
            /// ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND
            /// (scheduling.automaticRestart = true)
            /// ```
            /// If you want to use a regular expression, use the `eq` (equal)
            /// or `ne` (not equal) operator against a single un-parenthesized expression with or without quotes or
            /// against multiple parenthesized expressions. Examples: `fieldname eq unquoted literal` `fieldname eq
            /// 'single quoted literal'` `fieldname eq "double quoted literal"` `(fieldname1 eq literal) (fieldname2 ne
            /// "literal")` The literal value is interpreted as a regular expression using Google RE2 library syntax.
            /// The literal value must match the entire field. For example, to filter for instances that do not end with
            /// name "instance", you would use `name ne .*instance`. You cannot combine constraints on multiple fields
            /// using regular expressions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results per page that should be returned. If the number of available results is
            /// larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get the next page
            /// of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive. (Default: `500`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on
            /// the resource name. You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first. Currently, only sorting by `name` or `creationTimestamp desc` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous list
            /// request to get the next page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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

        /// <summary>Patches a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual PatchRequest Patch(Google.Apis.DeploymentManager.v2.Data.Deployment body, string project, string deployment)
        {
            return new PatchRequest(this.service, body, project, deployment);
        }

        /// <summary>Patches a deployment and all of the resources described by the deployment manifest.</summary>
        public class PatchRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.Deployment body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE = 1,
            }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON = 1,
            }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>
            /// If set to true, updates the deployment and creates and updates the "shell" resources but does not
            /// actually alter or instantiate these resources. This allows you to preview what your deployment will look
            /// like. You can use this intent to preview how an update would affect your deployment. You must provide a
            /// `target.config` with a configuration if this is set to true. After previewing a deployment, you can
            /// deploy your resources by making a request with the `update()` or you can `cancelPreview()` to remove the
            /// preview altogether. Note that the deployment will still exist after you cancel the preview and you must
            /// separately delete this deployment if you want to remove it.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource for this request.</param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.DeploymentManager.v2.Data.GlobalSetPolicyRequest body, string project, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, project, resource);
        }

        /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy.</summary>
        public class SetIamPolicyRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.GlobalSetPolicyRequest body, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.GlobalSetPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{resource}/setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
            }
        }

        /// <summary>
        /// Stops an ongoing operation. This does not roll back any work that has already been completed, but prevents
        /// any new work from being started.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual StopRequest Stop(Google.Apis.DeploymentManager.v2.Data.DeploymentsStopRequest body, string project, string deployment)
        {
            return new StopRequest(this.service, body, project, deployment);
        }

        /// <summary>
        /// Stops an ongoing operation. This does not roll back any work that has already been completed, but prevents
        /// any new work from being started.
        /// </summary>
        public class StopRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.DeploymentsStopRequest body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.DeploymentsStopRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
            }
        }

        /// <summary>Returns permissions that a caller has on the specified resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">Project ID for this request.</param>
        /// <param name="resource">Name or id of the resource for this request.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.DeploymentManager.v2.Data.TestPermissionsRequest body, string project, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, project, resource);
        }

        /// <summary>Returns permissions that a caller has on the specified resource.</summary>
        public class TestIamPermissionsRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.TestPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.TestPermissionsRequest body, string project, string resource) : base(service)
            {
                Project = project;
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>Project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Name or id of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.TestPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{resource}/testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z0-9](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9_]{0,61}[a-z0-9])?|[1-9][0-9]{0,19}",
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a deployment and all of the resources described by the deployment manifest.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual UpdateRequest Update(Google.Apis.DeploymentManager.v2.Data.Deployment body, string project, string deployment)
        {
            return new UpdateRequest(this.service, body, project, deployment);
        }

        /// <summary>Updates a deployment and all of the resources described by the deployment manifest.</summary>
        public class UpdateRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeploymentManager.v2.Data.Deployment body, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Body = body;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("createPolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CreatePolicyEnum> CreatePolicy { get; set; }

            /// <summary>Sets the policy to use for creating new resources.</summary>
            public enum CreatePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("CREATE_OR_ACQUIRE")]
                CREATEORACQUIRE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ACQUIRE")]
                ACQUIRE = 1,
            }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deletePolicy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DeletePolicyEnum> DeletePolicy { get; set; }

            /// <summary>Sets the policy to use for deleting resources.</summary>
            public enum DeletePolicyEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DELETE")]
                DELETE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ABANDON")]
                ABANDON = 1,
            }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>
            /// If set to true, updates the deployment and creates and updates the "shell" resources but does not
            /// actually alter or instantiate these resources. This allows you to preview what your deployment will look
            /// like. You can use this intent to preview how an update would affect your deployment. You must provide a
            /// `target.config` with a configuration if this is set to true. After previewing a deployment, you can
            /// deploy your resources by making a request with the `update()` or you can `cancelPreview()` to remove the
            /// preview altogether. Note that the deployment will still exist after you cancel the preview and you must
            /// separately delete this deployment if you want to remove it.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("preview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Preview { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DeploymentManager.v2.Data.Deployment Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("createPolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "createPolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "CREATE_OR_ACQUIRE",
                    Pattern = null,
                });
                RequestParameters.Add("deletePolicy", new Google.Apis.Discovery.Parameter
                {
                    Name = "deletePolicy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "DELETE",
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("preview", new Google.Apis.Discovery.Parameter
                {
                    Name = "preview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "manifests" collection of methods.</summary>
    public class ManifestsResource
    {
        private const string Resource = "manifests";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManifestsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets information about a specific manifest.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="manifest">The name of the manifest for this request.</param>
        public virtual GetRequest Get(string project, string deployment, string manifest)
        {
            return new GetRequest(this.service, project, deployment, manifest);
        }

        /// <summary>Gets information about a specific manifest.</summary>
        public class GetRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Manifest>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment, string manifest) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Manifest = manifest;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>The name of the manifest for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("manifest", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Manifest { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/manifests/{manifest}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("manifest", new Google.Apis.Discovery.Parameter
                {
                    Name = "manifest",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all manifests for a given deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual ListRequest List(string project, string deployment)
        {
            return new ListRequest(this.service, project, deployment);
        }

        /// <summary>Lists all manifests for a given deployment.</summary>
        public class ListRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.ManifestsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. Most Compute resources support two
            /// types of filter expressions: expressions that support regular expressions and expressions that follow
            /// API improvement proposal AIP-160. These two types of filter expressions cannot be mixed in one request.
            /// If you want to use AIP-160, your expression must specify the field name, an operator, and the value that
            /// you want to use for filtering. The value must be a string, a number, or a boolean. The operator must be
            /// either `=`, `!=`, `&amp;gt;`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;=` or `:`. For example, if you are
            /// filtering Compute Engine instances, you can exclude instances named `example-instance` by specifying
            /// `name != example-instance`. The `:*` comparison can be used to test whether a key has been defined. For
            /// example, to find all objects with `owner` label use:
            /// ```
            /// labels.owner:*
            /// ```
            /// You can also filter nested
            /// fields. For example, you could specify `scheduling.automaticRestart = false` to include instances only
            /// if they are not scheduled for automatic restarts. You can use filtering on nested fields to filter based
            /// on resource labels. To filter on multiple expressions, provide each separate expression within
            /// parentheses. For example:
            /// ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake")
            /// ```
            /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR` expressions
            /// explicitly. For example:
            /// ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND
            /// (scheduling.automaticRestart = true)
            /// ```
            /// If you want to use a regular expression, use the `eq` (equal)
            /// or `ne` (not equal) operator against a single un-parenthesized expression with or without quotes or
            /// against multiple parenthesized expressions. Examples: `fieldname eq unquoted literal` `fieldname eq
            /// 'single quoted literal'` `fieldname eq "double quoted literal"` `(fieldname1 eq literal) (fieldname2 ne
            /// "literal")` The literal value is interpreted as a regular expression using Google RE2 library syntax.
            /// The literal value must match the entire field. For example, to filter for instances that do not end with
            /// name "instance", you would use `name ne .*instance`. You cannot combine constraints on multiple fields
            /// using regular expressions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results per page that should be returned. If the number of available results is
            /// larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get the next page
            /// of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive. (Default: `500`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on
            /// the resource name. You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first. Currently, only sorting by `name` or `creationTimestamp desc` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous list
            /// request to get the next page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/manifests";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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

        /// <summary>Gets information about a specific operation.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="operation">The name of the operation for this request.</param>
        public virtual GetRequest Get(string project, string operation)
        {
            return new GetRequest(this.service, project, operation);
        }

        /// <summary>Gets information about a specific operation.</summary>
        public class GetRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string operation) : base(service)
            {
                Project = project;
                Operation = operation;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the operation for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operation", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Operation { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/operations/{operation}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("operation", new Google.Apis.Discovery.Parameter
                {
                    Name = "operation",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all operations for a project.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>Lists all operations for a project.</summary>
        public class ListRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.OperationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. Most Compute resources support two
            /// types of filter expressions: expressions that support regular expressions and expressions that follow
            /// API improvement proposal AIP-160. These two types of filter expressions cannot be mixed in one request.
            /// If you want to use AIP-160, your expression must specify the field name, an operator, and the value that
            /// you want to use for filtering. The value must be a string, a number, or a boolean. The operator must be
            /// either `=`, `!=`, `&amp;gt;`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;=` or `:`. For example, if you are
            /// filtering Compute Engine instances, you can exclude instances named `example-instance` by specifying
            /// `name != example-instance`. The `:*` comparison can be used to test whether a key has been defined. For
            /// example, to find all objects with `owner` label use:
            /// ```
            /// labels.owner:*
            /// ```
            /// You can also filter nested
            /// fields. For example, you could specify `scheduling.automaticRestart = false` to include instances only
            /// if they are not scheduled for automatic restarts. You can use filtering on nested fields to filter based
            /// on resource labels. To filter on multiple expressions, provide each separate expression within
            /// parentheses. For example:
            /// ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake")
            /// ```
            /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR` expressions
            /// explicitly. For example:
            /// ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND
            /// (scheduling.automaticRestart = true)
            /// ```
            /// If you want to use a regular expression, use the `eq` (equal)
            /// or `ne` (not equal) operator against a single un-parenthesized expression with or without quotes or
            /// against multiple parenthesized expressions. Examples: `fieldname eq unquoted literal` `fieldname eq
            /// 'single quoted literal'` `fieldname eq "double quoted literal"` `(fieldname1 eq literal) (fieldname2 ne
            /// "literal")` The literal value is interpreted as a regular expression using Google RE2 library syntax.
            /// The literal value must match the entire field. For example, to filter for instances that do not end with
            /// name "instance", you would use `name ne .*instance`. You cannot combine constraints on multiple fields
            /// using regular expressions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results per page that should be returned. If the number of available results is
            /// larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get the next page
            /// of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive. (Default: `500`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on
            /// the resource name. You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first. Currently, only sorting by `name` or `creationTimestamp desc` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous list
            /// request to get the next page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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

    /// <summary>The "resources" collection of methods.</summary>
    public class ResourcesResource
    {
        private const string Resource = "resources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets information about a single resource.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        /// <param name="resource">The name of the resource for this request.</param>
        public virtual GetRequest Get(string project, string deployment, string resource)
        {
            return new GetRequest(this.service, project, deployment, resource);
        }

        /// <summary>Gets information about a single resource.</summary>
        public class GetRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.Resource>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string project, string deployment, string resource) : base(service)
            {
                Project = project;
                Deployment = deployment;
                Resource = resource;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>The name of the resource for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("header.bypassBillingFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> HeaderBypassBillingFilter { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/resources/{resource}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("header.bypassBillingFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "header.bypassBillingFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all resources in a given deployment.</summary>
        /// <param name="project">The project ID for this request.</param>
        /// <param name="deployment">The name of the deployment for this request.</param>
        public virtual ListRequest List(string project, string deployment)
        {
            return new ListRequest(this.service, project, deployment);
        }

        /// <summary>Lists all resources in a given deployment.</summary>
        public class ListRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.ResourcesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project, string deployment) : base(service)
            {
                Project = project;
                Deployment = deployment;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>The name of the deployment for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("deployment", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Deployment { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. Most Compute resources support two
            /// types of filter expressions: expressions that support regular expressions and expressions that follow
            /// API improvement proposal AIP-160. These two types of filter expressions cannot be mixed in one request.
            /// If you want to use AIP-160, your expression must specify the field name, an operator, and the value that
            /// you want to use for filtering. The value must be a string, a number, or a boolean. The operator must be
            /// either `=`, `!=`, `&amp;gt;`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;=` or `:`. For example, if you are
            /// filtering Compute Engine instances, you can exclude instances named `example-instance` by specifying
            /// `name != example-instance`. The `:*` comparison can be used to test whether a key has been defined. For
            /// example, to find all objects with `owner` label use:
            /// ```
            /// labels.owner:*
            /// ```
            /// You can also filter nested
            /// fields. For example, you could specify `scheduling.automaticRestart = false` to include instances only
            /// if they are not scheduled for automatic restarts. You can use filtering on nested fields to filter based
            /// on resource labels. To filter on multiple expressions, provide each separate expression within
            /// parentheses. For example:
            /// ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake")
            /// ```
            /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR` expressions
            /// explicitly. For example:
            /// ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND
            /// (scheduling.automaticRestart = true)
            /// ```
            /// If you want to use a regular expression, use the `eq` (equal)
            /// or `ne` (not equal) operator against a single un-parenthesized expression with or without quotes or
            /// against multiple parenthesized expressions. Examples: `fieldname eq unquoted literal` `fieldname eq
            /// 'single quoted literal'` `fieldname eq "double quoted literal"` `(fieldname1 eq literal) (fieldname2 ne
            /// "literal")` The literal value is interpreted as a regular expression using Google RE2 library syntax.
            /// The literal value must match the entire field. For example, to filter for instances that do not end with
            /// name "instance", you would use `name ne .*instance`. You cannot combine constraints on multiple fields
            /// using regular expressions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results per page that should be returned. If the number of available results is
            /// larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get the next page
            /// of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive. (Default: `500`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on
            /// the resource name. You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first. Currently, only sorting by `name` or `creationTimestamp desc` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous list
            /// request to get the next page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/deployments/{deployment}/resources";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("deployment", new Google.Apis.Discovery.Parameter
                {
                    Name = "deployment",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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

    /// <summary>The "types" collection of methods.</summary>
    public class TypesResource
    {
        private const string Resource = "types";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists all resource types for Deployment Manager.</summary>
        /// <param name="project">The project ID for this request.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>Lists all resource types for Deployment Manager.</summary>
        public class ListRequest : DeploymentManagerBaseServiceRequest<Google.Apis.DeploymentManager.v2.Data.TypesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>The project ID for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// A filter expression that filters resources listed in the response. Most Compute resources support two
            /// types of filter expressions: expressions that support regular expressions and expressions that follow
            /// API improvement proposal AIP-160. These two types of filter expressions cannot be mixed in one request.
            /// If you want to use AIP-160, your expression must specify the field name, an operator, and the value that
            /// you want to use for filtering. The value must be a string, a number, or a boolean. The operator must be
            /// either `=`, `!=`, `&amp;gt;`, `&amp;lt;`, `&amp;lt;=`, `&amp;gt;=` or `:`. For example, if you are
            /// filtering Compute Engine instances, you can exclude instances named `example-instance` by specifying
            /// `name != example-instance`. The `:*` comparison can be used to test whether a key has been defined. For
            /// example, to find all objects with `owner` label use:
            /// ```
            /// labels.owner:*
            /// ```
            /// You can also filter nested
            /// fields. For example, you could specify `scheduling.automaticRestart = false` to include instances only
            /// if they are not scheduled for automatic restarts. You can use filtering on nested fields to filter based
            /// on resource labels. To filter on multiple expressions, provide each separate expression within
            /// parentheses. For example:
            /// ```
            /// (scheduling.automaticRestart = true) (cpuPlatform = "Intel Skylake")
            /// ```
            /// By default, each expression is an `AND` expression. However, you can include `AND` and `OR` expressions
            /// explicitly. For example:
            /// ```
            /// (cpuPlatform = "Intel Skylake") OR (cpuPlatform = "Intel Broadwell") AND
            /// (scheduling.automaticRestart = true)
            /// ```
            /// If you want to use a regular expression, use the `eq` (equal)
            /// or `ne` (not equal) operator against a single un-parenthesized expression with or without quotes or
            /// against multiple parenthesized expressions. Examples: `fieldname eq unquoted literal` `fieldname eq
            /// 'single quoted literal'` `fieldname eq "double quoted literal"` `(fieldname1 eq literal) (fieldname2 ne
            /// "literal")` The literal value is interpreted as a regular expression using Google RE2 library syntax.
            /// The literal value must match the entire field. For example, to filter for instances that do not end with
            /// name "instance", you would use `name ne .*instance`. You cannot combine constraints on multiple fields
            /// using regular expressions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of results per page that should be returned. If the number of available results is
            /// larger than `maxResults`, Compute Engine returns a `nextPageToken` that can be used to get the next page
            /// of results in subsequent list requests. Acceptable values are `0` to `500`, inclusive. (Default: `500`)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on
            /// the resource name. You can also sort results in descending order based on the creation timestamp using
            /// `orderBy="creationTimestamp desc"`. This sorts results based on the `creationTimestamp` field in reverse
            /// chronological order (newest result first). Use this to sort resources like operations so that the newest
            /// operation is returned first. Currently, only sorting by `name` or `creationTimestamp desc` is supported.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Specifies a page token to use. Set `pageToken` to the `nextPageToken` returned by a previous list
            /// request to get the next page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "deploymentmanager/v2/projects/{project}/global/types";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(?:(?:[-a-z0-9]{1,63}\.)*(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?):)?(?:[0-9]{1,19}|(?:[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?))",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "500",
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
namespace Google.Apis.DeploymentManager.v2.Data
{
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

    public class BulkInsertOperationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output Only] Count of VMs successfully created so far.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdVmCount")]
        public virtual System.Nullable<int> CreatedVmCount { get; set; }

        /// <summary>[Output Only] Count of VMs that got deleted during rollback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedVmCount")]
        public virtual System.Nullable<int> DeletedVmCount { get; set; }

        /// <summary>[Output Only] Count of VMs that started creating but encountered an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedToCreateVmCount")]
        public virtual System.Nullable<int> FailedToCreateVmCount { get; set; }

        /// <summary>
        /// [Output Only] Creation status of BulkInsert operation - information if the flow is rolling forward or
        /// rolling back.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>[Output Only] Count of VMs originally planned to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVmCount")]
        public virtual System.Nullable<int> TargetVmCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ConfigFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes additional debugging info.</summary>
    public class DebugInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional debugging information provided by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The stack trace entries indicating where the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackEntries")]
        public virtual System.Collections.Generic.IList<string> StackEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional user-provided description of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Provides a fingerprint to use in requests to modify a deployment, such as `update()`, `stop()`, and
        /// `cancelPreview()` requests. A fingerprint is a randomly generated value that must be provided with
        /// `update()`, `stop()`, and `cancelPreview()` requests to perform optimistic locking. This ensures optimistic
        /// concurrency so that only one request happens at a time. The fingerprint is initially generated by Deployment
        /// Manager and changes after every request to modify data. To get the latest fingerprint value, perform a
        /// `get()` request to a deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; }

        /// <summary>
        /// Map of One Platform labels; provided by the client when the resource is created or updated. Specifically:
        /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<DeploymentLabelEntry> Labels { get; set; }

        /// <summary>
        /// Output only. URL of the manifest representing the last manifest that was successfully deployed. If no
        /// manifest has been successfully deployed, this field will be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>
        /// Name of the resource; provided by the client when the resource is created. The name must be 1-63 characters
        /// long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?` which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be
        /// a dash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The Operation that most recently ran, or is currently running, on this deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>Output only. Server defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// [Input Only] The parameters that define your deployment, including the deployment configuration and relevant
        /// templates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual TargetConfiguration Target { get; set; }

        /// <summary>
        /// Output only. If Deployment Manager is currently updating or previewing an update to this deployment, the
        /// updated configuration appears here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual DeploymentUpdate Update { get; set; }

        /// <summary>Output only. Update timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label object for Deployments</summary>
    public class DeploymentLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key of the label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value of the label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeploymentUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An optional user-provided description of the deployment after the current update has been
        /// applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Map of One Platform labels; provided by the client when the resource is created or updated. Specifically:
        /// Label keys must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?` Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<DeploymentUpdateLabelEntry> Labels { get; set; }

        /// <summary>
        /// Output only. URL of the manifest representing the update configuration of this deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label object for DeploymentUpdate</summary>
    public class DeploymentUpdateLabelEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key of the label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value of the label</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeploymentsCancelPreviewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies a fingerprint for `cancelPreview()` requests. A fingerprint is a randomly generated value that
        /// must be provided in `cancelPreview()` requests to perform optimistic locking. This ensures optimistic
        /// concurrency so that the deployment does not have conflicting requests (e.g. if someone attempts to make a
        /// new update request while another user attempts to cancel a preview, this would prevent one of the requests).
        /// The fingerprint is initially generated by Deployment Manager and changes after every request to modify a
        /// deployment. To get the latest fingerprint value, perform a `get()` request on the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response containing a partial list of deployments and a page token used to build the next request if the
    /// request has been truncated.
    /// </summary>
    public class DeploymentsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The deployments contained in this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<Deployment> Deployments { get; set; }

        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DeploymentsStopRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies a fingerprint for `stop()` requests. A fingerprint is a randomly generated value that must be
        /// provided in `stop()` requests to perform optimistic locking. This ensures optimistic concurrency so that the
        /// deployment does not have conflicting requests (e.g. if someone attempts to make a new update request while
        /// another user attempts to stop an ongoing update request, this would prevent a collision). The fingerprint is
        /// initially generated by Deployment Manager and changes after every request to modify a deployment. To get the
        /// latest fingerprint value, perform a `get()` request on the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the cause of the error with structured details. Example of an error when contacting the
    /// "pubsub.googleapis.com" API when it is not enabled: { "reason": "API_DISABLED" "domain": "googleapis.com"
    /// "metadata": { "resource": "projects/123", "service": "pubsub.googleapis.com" } } This response indicates that
    /// the pubsub.googleapis.com API is not enabled. Example of an error that is returned when attempting to create a
    /// Spanner instance in a region that is out of stock: { "reason": "STOCKOUT" "domain": "spanner.googleapis.com",
    /// "metadata": { "availableRegions": "us-central1,us-east2" } }
    /// </summary>
    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The logical grouping to which the "reason" belongs. The error domain is typically the registered service
        /// name of the tool or product that generates the error. Example: "pubsub.googleapis.com". If the error is
        /// generated by some common infrastructure, the error domain must be a globally unique value that identifies
        /// the infrastructure. For Google API infrastructure, the error domain is "googleapis.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Additional structured details about this error. Keys must match a regular expression of `a-z+` but should
        /// ideally be lowerCamelCase. Also, they must be limited to 64 characters in length. When identifying the
        /// current value of an exceeded limit, the units should be contained in the key, not the value. For example,
        /// rather than `{"instanceLimit": "100/request"}`, should be returned as, `{"instanceLimitPerRequest": "100"}`,
        /// if the client exceeds the number of instances that can be created in a single (batch) request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadatas")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadatas { get; set; }

        /// <summary>
        /// The reason of the error. This is a constant value that identifies the proximate cause of the error. Error
        /// reasons are unique within a particular domain of errors. This should be at most 63 characters and match a
        /// regular expression of `A-Z+[A-Z0-9]`, which represents UPPER_SNAKE_CASE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

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

    public class GlobalSetPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Flatten Policy to create a backward compatible wire-format. Deprecated. Use 'policy' to specify bindings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// Flatten Policy to create a backward compatible wire-format. Deprecated. Use 'policy' to specify the etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is in general a valid policy but certain services (like Projects) might reject
        /// them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }
    }

    /// <summary>
    /// Provides links to documentation or for performing an out of band action. For example, if a quota check failed
    /// with an error indicating the calling project hasn't enabled the accessed service, this can contain a URL
    /// pointing directly to the right place in the developer console to flip the bit.
    /// </summary>
    public class Help : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL(s) pointing to additional information on handling the current error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<HelpLink> Links { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a URL link.</summary>
    public class HelpLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes what the link offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The URL of the link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ImportFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The contents of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The name of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InstancesBulkInsertOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output Only] The machine type of the VMs that were created used internally only by KCP flex bulk insert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Status information per location (location name is key). Example key: zones/us-central1-a</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perLocationStatus")]
        public virtual System.Collections.Generic.IDictionary<string, BulkInsertOperationStatus> PerLocationStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides a localized error message that is safe to return to the user which can be attached to an RPC error.
    /// </summary>
    public class LocalizedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The locale used following the specification defined at https://www.rfc-editor.org/rfc/bcp/bcp47.txt.
        /// Examples are: "en-US", "fr-CH", "es-MX"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>The localized error message in the above locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Manifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The YAML configuration for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ConfigFile Config { get; set; }

        /// <summary>
        /// Output only. The fully-expanded configuration file, including any templates and references.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandedConfig")]
        public virtual string ExpandedConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>Output only. The imported files for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imports")]
        public virtual System.Collections.Generic.IList<ImportFile> Imports { get; set; }

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; }

        /// <summary>Output only. The YAML layout for this manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        /// <summary>Output only. The computed size of the fully expanded manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestSizeBytes")]
        public virtual System.Nullable<long> ManifestSizeBytes { get; set; }

        /// <summary>Output only. The size limit for expanded manifests in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestSizeLimitBytes")]
        public virtual System.Nullable<long> ManifestSizeLimitBytes { get; set; }

        /// <summary>Output only. The name of the manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Self link for the manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response containing a partial list of manifests and a page token used to build the next request if the request
    /// has been truncated.
    /// </summary>
    public class ManifestsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Manifests contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifests")]
        public virtual System.Collections.Generic.IList<Manifest> Manifests { get; set; }

        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an Operation resource. Google Compute Engine has three Operation resources: *
    /// [Global](/compute/docs/reference/rest/{$api_version}/globalOperations) *
    /// [Regional](/compute/docs/reference/rest/{$api_version}/regionOperations) *
    /// [Zonal](/compute/docs/reference/rest/{$api_version}/zoneOperations) You can use an operation resource to manage
    /// asynchronous API requests. For more information, read Handling API responses. Operations can be global, regional
    /// or zonal. - For global operations, use the `globalOperations` resource. - For regional operations, use the
    /// `regionOperations` resource. - For zonal operations, use the `zoneOperations` resource. For more information,
    /// read Global, Regional, and Zonal Resources. Note that completed Operation resources have a limited retention
    /// period.
    /// </summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output Only] The value of `requestId` if you provided it in the request. Not present otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientOperationId")]
        public virtual string ClientOperationId { get; set; }

        /// <summary>[Deprecated] This field is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual string CreationTimestamp { get; set; }

        /// <summary>
        /// [Output Only] A textual description of the operation, which is set when the operation is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// [Output Only] The time that this operation was completed. This value is in RFC3339 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; }

        /// <summary>
        /// [Output Only] If errors are generated during processing of the operation, this field will be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual ErrorData Error { get; set; }

        /// <summary>
        /// [Output Only] If the operation fails, this field contains the HTTP error message that was returned, such as
        /// `NOT FOUND`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpErrorMessage")]
        public virtual string HttpErrorMessage { get; set; }

        /// <summary>
        /// [Output Only] If the operation fails, this field contains the HTTP error status code that was returned. For
        /// example, a `404` means the resource was not found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpErrorStatusCode")]
        public virtual System.Nullable<int> HttpErrorStatusCode { get; set; }

        /// <summary>
        /// [Output Only] The unique identifier for the operation. This identifier is defined by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>
        /// [Output Only] The time that this operation was requested. This value is in RFC3339 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("instancesBulkInsertOperationMetadata")]
        public virtual InstancesBulkInsertOperationMetadata InstancesBulkInsertOperationMetadata { get; set; }

        /// <summary>[Output Only] Type of the resource. Always `compute#operation` for Operation resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>[Output Only] Name of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// [Output Only] An ID that represents a group of operations, such as when a group of operations results from a
        /// `bulkInsert` API request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationGroupId")]
        public virtual string OperationGroupId { get; set; }

        /// <summary>[Output Only] The type of operation, such as `insert`, `update`, or `delete`, and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// [Output Only] An optional progress indicator that ranges from 0 to 100. There is no requirement that this be
        /// linear or support any granularity of operations. This should not be used to guess when the operation will be
        /// complete. This number should monotonically increase as the operation progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<int> Progress { get; set; }

        /// <summary>
        /// [Output Only] The URL of the region where the operation resides. Only applicable when performing regional
        /// operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>[Output Only] Server-defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>[Output Only] Server-defined URL for this resource with the resource id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLinkWithId")]
        public virtual string SelfLinkWithId { get; set; }

        /// <summary>
        /// [Output Only] If the operation is for projects.setCommonInstanceMetadata, this field will contain
        /// information on all underlying zonal actions and their state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setCommonInstanceMetadataOperationMetadata")]
        public virtual SetCommonInstanceMetadataOperationMetadata SetCommonInstanceMetadataOperationMetadata { get; set; }

        /// <summary>
        /// [Output Only] The time that this operation was started by the server. This value is in RFC3339 text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>
        /// [Output Only] The status of the operation, which can be one of the following: `PENDING`, `RUNNING`, or
        /// `DONE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>[Output Only] An optional textual description of the current status of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>
        /// [Output Only] The unique target ID, which identifies a specific incarnation of the target resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetId")]
        public virtual System.Nullable<ulong> TargetId { get; set; }

        /// <summary>
        /// [Output Only] The URL of the resource that the operation modifies. For operations related to creating a
        /// snapshot, this points to the disk that the snapshot was created from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLink")]
        public virtual string TargetLink { get; set; }

        /// <summary>
        /// [Output Only] User who requested the operation, for example: `user@example.com` or `alice_smith_identifier
        /// (global/workforcePools/example-com-us-employees)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>
        /// [Output Only] If warning messages are generated during processing of the operation, this field will be
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; }

        /// <summary>
        /// [Output Only] The URL of the zone where the operation resides. Only applicable when performing per-zone
        /// operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// [Output Only] If errors are generated during processing of the operation, this field will be populated.
        /// </summary>
        public class ErrorData
        {
            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errors")]
            public virtual System.Collections.Generic.IList<ErrorsData> Errors { get; set; }

            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            public class ErrorsData
            {
                /// <summary>
                /// [Output Only] Optional error details WARNING: DO NOT MAKE VISIBLE This is for internal use-only
                /// (like componentization) (thus the visibility "none") and in case of public exposure it is strongly
                /// recommended to follow pattern of: https://aip.dev/193 and expose as details field.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
                public virtual System.Collections.Generic.IList<string> Arguments { get; set; }

                /// <summary>[Output Only] The error type identifier for this error.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("code")]
                public virtual string Code { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
                public virtual DebugInfo DebugInfo { get; set; }

                /// <summary>
                /// [Output Only] An optional list of messages that contain the error details. There is a set of defined
                /// message types to use for providing details.The syntax depends on the error code. For example,
                /// QuotaExceededInfo will have details when the error code is QUOTA_EXCEEDED.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("errorDetails")]
                public virtual System.Collections.Generic.IList<ErrorDetailsData> ErrorDetails { get; set; }

                /// <summary>
                /// [Output Only] Indicates the field in the request that caused the error. This property is optional.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("location")]
                public virtual string Location { get; set; }

                /// <summary>[Output Only] An optional, human-readable error message.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("message")]
                public virtual string Message { get; set; }

                /// <summary>
                /// [Output Only] An optional list of messages that contain the error details. There is a set of defined
                /// message types to use for providing details.The syntax depends on the error code. For example,
                /// QuotaExceededInfo will have details when the error code is QUOTA_EXCEEDED.
                /// </summary>
                public class ErrorDetailsData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
                    public virtual ErrorInfo ErrorInfo { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("help")]
                    public virtual Help Help { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("localizedMessage")]
                    public virtual LocalizedMessage LocalizedMessage { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("quotaInfo")]
                    public virtual QuotaExceededInfo QuotaInfo { get; set; }
                }
            }
        }

        /// <summary>
        /// [Output Only] If warning messages are generated during processing of the operation, this field will be
        /// populated.
        /// </summary>
        public class WarningsData
        {
            /// <summary>
            /// [Output Only] A warning code, if applicable. For example, Compute Engine returns NO_RESULTS_ON_PAGE if
            /// there are no results in the response.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; }

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            public class DataData
            {
                /// <summary>
                /// [Output Only] A key that provides more detail on the warning being returned. For example, for
                /// warnings where there are no results in a list request for a particular zone, this key might be scope
                /// and the key value might be the zone name. Other examples might be a key indicating a deprecated
                /// resource and a suggested replacement, or a warning about invalid network settings (for example, if
                /// an instance attempts to perform IP forwarding but is not enabled for IP forwarding).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; }

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; }
            }
        }
    }

    /// <summary>
    /// A response containing a partial list of operations and a page token used to build the next request if the
    /// request has been truncated.
    /// </summary>
    public class OperationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. Operations contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

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

    /// <summary>Additional details for quota exceeded error for resource quota.</summary>
    public class QuotaExceededInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The map holding related quota dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Future quota limit being rolled out. The limit's unit depends on the quota type or metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("futureLimit")]
        public virtual System.Nullable<double> FutureLimit { get; set; }

        /// <summary>Current effective quota limit. The limit's unit depends on the quota type or metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<double> Limit { get; set; }

        /// <summary>The name of the quota limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitName")]
        public virtual string LimitName { get; set; }

        /// <summary>The Compute Engine quota metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>Rollout status of the future quota limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStatus")]
        public virtual string RolloutStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Access Control Policy set on this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControl")]
        public virtual ResourceAccessControl AccessControl { get; set; }

        /// <summary>
        /// Output only. The evaluated properties of the resource with references expanded. Returned as serialized YAML.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalProperties")]
        public virtual string FinalProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; }

        /// <summary>Output only. URL of the manifest representing the current configuration of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>Output only. The name of the resource as it appears in the YAML config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The current properties of the resource before any references have been filled in. Returned as
        /// serialized YAML.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual string Properties { get; set; }

        /// <summary>
        /// Output only. The type of the resource, for example `compute.v1.instance`, or
        /// `cloudfunctions.v1beta1.function`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Output only. If Deployment Manager is currently updating or previewing an update to this resource, the
        /// updated configuration appears here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual ResourceUpdate Update { get; set; }

        /// <summary>Output only. Update timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTime { get; set; }

        /// <summary>Output only. The URL of the actual resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>
        /// Output only. If warning messages are generated during processing of this resource, this field will be
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. If warning messages are generated during processing of this resource, this field will be
        /// populated.
        /// </summary>
        public class WarningsData
        {
            /// <summary>
            /// [Output Only] A warning code, if applicable. For example, Compute Engine returns NO_RESULTS_ON_PAGE if
            /// there are no results in the response.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; }

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            public class DataData
            {
                /// <summary>
                /// [Output Only] A key that provides more detail on the warning being returned. For example, for
                /// warnings where there are no results in a list request for a particular zone, this key might be scope
                /// and the key value might be the zone name. Other examples might be a key indicating a deprecated
                /// resource and a suggested replacement, or a warning about invalid network settings (for example, if
                /// an instance attempts to perform IP forwarding but is not enabled for IP forwarding).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; }

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; }
            }
        }
    }

    /// <summary>The access controls set on the resource.</summary>
    public class ResourceAccessControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The GCP IAM Policy to set on the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpIamPolicy")]
        public virtual string GcpIamPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResourceUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Access Control Policy to set on this resource after updating the resource itself.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControl")]
        public virtual ResourceAccessControl AccessControl { get; set; }

        /// <summary>
        /// Output only. If errors are generated during update of the resource, this field will be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual ErrorData Error { get; set; }

        /// <summary>
        /// Output only. The expanded properties of the resource with reference values expanded. Returned as serialized
        /// YAML.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalProperties")]
        public virtual string FinalProperties { get; set; }

        /// <summary>Output only. The intent of the resource: `PREVIEW`, `UPDATE`, or `CANCEL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual string Intent { get; set; }

        /// <summary>Output only. URL of the manifest representing the update configuration of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifest")]
        public virtual string Manifest { get; set; }

        /// <summary>
        /// Output only. The set of updated properties for this resource, before references are expanded. Returned as
        /// serialized YAML.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual string Properties { get; set; }

        /// <summary>Output only. The state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. If warning messages are generated during processing of this resource, this field will be
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. If errors are generated during update of the resource, this field will be populated.
        /// </summary>
        public class ErrorData
        {
            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("errors")]
            public virtual System.Collections.Generic.IList<ErrorsData> Errors { get; set; }

            /// <summary>[Output Only] The array of errors encountered while processing this operation.</summary>
            public class ErrorsData
            {
                /// <summary>
                /// [Output Only] Optional error details WARNING: DO NOT MAKE VISIBLE This is for internal use-only
                /// (like componentization) (thus the visibility "none") and in case of public exposure it is strongly
                /// recommended to follow pattern of: https://aip.dev/193 and expose as details field.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
                public virtual System.Collections.Generic.IList<string> Arguments { get; set; }

                /// <summary>[Output Only] The error type identifier for this error.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("code")]
                public virtual string Code { get; set; }

                [Newtonsoft.Json.JsonPropertyAttribute("debugInfo")]
                public virtual DebugInfo DebugInfo { get; set; }

                /// <summary>
                /// [Output Only] An optional list of messages that contain the error details. There is a set of defined
                /// message types to use for providing details.The syntax depends on the error code. For example,
                /// QuotaExceededInfo will have details when the error code is QUOTA_EXCEEDED.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("errorDetails")]
                public virtual System.Collections.Generic.IList<ErrorDetailsData> ErrorDetails { get; set; }

                /// <summary>
                /// [Output Only] Indicates the field in the request that caused the error. This property is optional.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("location")]
                public virtual string Location { get; set; }

                /// <summary>[Output Only] An optional, human-readable error message.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("message")]
                public virtual string Message { get; set; }

                /// <summary>
                /// [Output Only] An optional list of messages that contain the error details. There is a set of defined
                /// message types to use for providing details.The syntax depends on the error code. For example,
                /// QuotaExceededInfo will have details when the error code is QUOTA_EXCEEDED.
                /// </summary>
                public class ErrorDetailsData
                {
                    [Newtonsoft.Json.JsonPropertyAttribute("errorInfo")]
                    public virtual ErrorInfo ErrorInfo { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("help")]
                    public virtual Help Help { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("localizedMessage")]
                    public virtual LocalizedMessage LocalizedMessage { get; set; }

                    [Newtonsoft.Json.JsonPropertyAttribute("quotaInfo")]
                    public virtual QuotaExceededInfo QuotaInfo { get; set; }
                }
            }
        }

        /// <summary>
        /// Output only. If warning messages are generated during processing of this resource, this field will be
        /// populated.
        /// </summary>
        public class WarningsData
        {
            /// <summary>
            /// [Output Only] A warning code, if applicable. For example, Compute Engine returns NO_RESULTS_ON_PAGE if
            /// there are no results in the response.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; }

            /// <summary>[Output Only] A human-readable description of the warning code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; }

            /// <summary>
            /// [Output Only] Metadata about this warning in key: value format. For example: "data": [ { "key": "scope",
            /// "value": "zones/us-east1-d" }
            /// </summary>
            public class DataData
            {
                /// <summary>
                /// [Output Only] A key that provides more detail on the warning being returned. For example, for
                /// warnings where there are no results in a list request for a particular zone, this key might be scope
                /// and the key value might be the zone name. Other examples might be a key indicating a deprecated
                /// resource and a suggested replacement, or a warning about invalid network settings (for example, if
                /// an instance attempts to perform IP forwarding but is not enabled for IP forwarding).
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; }

                /// <summary>[Output Only] A warning data value corresponding to the key.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; }
            }
        }
    }

    /// <summary>
    /// A response containing a partial list of resources and a page token used to build the next request if the request
    /// has been truncated.
    /// </summary>
    public class ResourcesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Resources contained in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<Resource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SetCommonInstanceMetadataOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output Only] The client operation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientOperationId")]
        public virtual string ClientOperationId { get; set; }

        /// <summary>
        /// [Output Only] Status information per location (location name is key). Example key: zones/us-central1-a
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perLocationOperations")]
        public virtual System.Collections.Generic.IDictionary<string, SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo> PerLocationOperations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SetCommonInstanceMetadataOperationMetadataPerLocationOperationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Output Only] If state is `ABANDONED` or `FAILED`, this field is populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// [Output Only] Status of the action, which can be one of the following: `PROPAGATING`, `PROPAGATED`,
        /// `ABANDONED`, `FAILED`, or `DONE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    public class TargetConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration to use for this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ConfigFile Config { get; set; }

        /// <summary>
        /// Specifies any files to import for this configuration. This can be used to import templates or other files.
        /// For example, you might import a text file in order to use the file in a template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imports")]
        public virtual System.Collections.Generic.IList<ImportFile> Imports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TestPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the 'resource'. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TestPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource type supported by Deployment Manager.</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<ulong> Id { get; set; }

        /// <summary>Output only. Creation timestamp in RFC3339 text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTime { get; set; }

        /// <summary>Name of the type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The Operation that most recently ran, or is currently running, on this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>Output only. Server defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response that returns all Types supported by Deployment Manager</summary>
    public class TypesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token used to continue a truncated list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. A list of resource types supported by Deployment Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<Type> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
