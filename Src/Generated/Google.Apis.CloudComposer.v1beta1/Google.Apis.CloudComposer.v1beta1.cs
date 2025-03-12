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

namespace Google.Apis.CloudComposer.v1beta1
{
    /// <summary>The CloudComposer Service.</summary>
    public class CloudComposerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudComposerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudComposerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://composer.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://composer.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "composer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Composer API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Composer API.</summary>
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

    /// <summary>A base abstract class for CloudComposer requests.</summary>
    public abstract class CloudComposerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudComposerBaseServiceRequest instance.</summary>
        protected CloudComposerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudComposer parameter list.</summary>
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
                Environments = new EnvironmentsResource(service);
                ImageVersions = new ImageVersionsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Environments resource.</summary>
            public virtual EnvironmentsResource Environments { get; }

            /// <summary>The "environments" collection of methods.</summary>
            public class EnvironmentsResource
            {
                private const string Resource = "environments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EnvironmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    UserWorkloadsConfigMaps = new UserWorkloadsConfigMapsResource(service);
                    UserWorkloadsSecrets = new UserWorkloadsSecretsResource(service);
                    Workloads = new WorkloadsResource(service);
                }

                /// <summary>Gets the UserWorkloadsConfigMaps resource.</summary>
                public virtual UserWorkloadsConfigMapsResource UserWorkloadsConfigMaps { get; }

                /// <summary>The "userWorkloadsConfigMaps" collection of methods.</summary>
                public class UserWorkloadsConfigMapsResource
                {
                    private const string Resource = "userWorkloadsConfigMaps";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UserWorkloadsConfigMapsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The environment name to create a ConfigMap for, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class CreateRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The environment name to create a ConfigMap for, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/userWorkloadsConfigMaps";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The ConfigMap to delete, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class DeleteRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The ConfigMap to delete, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsConfigMaps/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets an existing user workloads ConfigMap. This method is supported for Cloud Composer
                    /// environments in versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the ConfigMap to get, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets an existing user workloads ConfigMap. This method is supported for Cloud Composer
                    /// environments in versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class GetRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the ConfigMap to get, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsConfigMaps/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists user workloads ConfigMaps. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. List ConfigMaps in the given environment, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists user workloads ConfigMaps. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListUserWorkloadsConfigMapsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. List ConfigMaps in the given environment, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The maximum number of ConfigMaps to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/userWorkloadsConfigMaps";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
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
                    /// Updates a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the ConfigMap, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
                    /// </param>
                    public virtual UpdateRequest Update(Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap body, string name)
                    {
                        return new UpdateRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a user workloads ConfigMap. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class UpdateRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the ConfigMap, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsConfigMap Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsConfigMaps/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the UserWorkloadsSecrets resource.</summary>
                public virtual UserWorkloadsSecretsResource UserWorkloadsSecrets { get; }

                /// <summary>The "userWorkloadsSecrets" collection of methods.</summary>
                public class UserWorkloadsSecretsResource
                {
                    private const string Resource = "userWorkloadsSecrets";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UserWorkloadsSecretsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The environment name to create a Secret for, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class CreateRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The environment name to create a Secret for, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/userWorkloadsSecrets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The Secret to delete, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class DeleteRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Secret to delete, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsSecrets/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets an existing user workloads Secret. Values of the "data" field in the response are cleared.
                    /// This method is supported for Cloud Composer environments in versions
                    /// composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The resource name of the Secret to get, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets an existing user workloads Secret. Values of the "data" field in the response are cleared.
                    /// This method is supported for Cloud Composer environments in versions
                    /// composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class GetRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Secret to get, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsSecrets/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists user workloads Secrets. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. List Secrets in the given environment, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists user workloads Secrets. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListUserWorkloadsSecretsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. List Secrets in the given environment, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The maximum number of Secrets to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/userWorkloadsSecrets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
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
                    /// Updates a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the Secret, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
                    /// </param>
                    public virtual UpdateRequest Update(Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret body, string name)
                    {
                        return new UpdateRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates a user workloads Secret. This method is supported for Cloud Composer environments in
                    /// versions composer-3-airflow-*.*.*-build.* and newer.
                    /// </summary>
                    public class UpdateRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the Secret, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudComposer.v1beta1.Data.UserWorkloadsSecret Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+/userWorkloadsSecrets/[^/]+$",
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
                    }

                    /// <summary>
                    /// Lists workloads in a Cloud Composer environment. Workload is a unit that runs a single Composer
                    /// component. This method is supported for Cloud Composer environments in versions
                    /// composer-2.*.*-airflow-*.*.* and newer.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The environment name to get workloads for, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists workloads in a Cloud Composer environment. Workload is a unit that runs a single Composer
                    /// component. This method is supported for Cloud Composer environments in versions
                    /// composer-2.*.*-airflow-*.*.* and newer.
                    /// </summary>
                    public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListWorkloadsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The environment name to get workloads for, in the form:
                        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The list filter. Currently only supports equality on the type field. The value of
                        /// a field specified in the filter expression must be one ComposerWorkloadType enum option.
                        /// It's possible to get multiple types using "OR" operator, e.g.: "type=SCHEDULER OR
                        /// type=CELERY_WORKER". If not specified, all items are returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. The maximum number of environments to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous List request, if any.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
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

                /// <summary>
                /// Check if an upgrade operation on the environment will succeed. In case of problems detailed info can
                /// be found in the returned Operation.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the environment to check upgrade for, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual CheckUpgradeRequest CheckUpgrade(Google.Apis.CloudComposer.v1beta1.Data.CheckUpgradeRequest body, string environment)
                {
                    return new CheckUpgradeRequest(this.service, body, environment);
                }

                /// <summary>
                /// Check if an upgrade operation on the environment will succeed. In case of problems detailed info can
                /// be found in the returned Operation.
                /// </summary>
                public class CheckUpgradeRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new CheckUpgrade request.</summary>
                    public CheckUpgradeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.CheckUpgradeRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment to check upgrade for, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.CheckUpgradeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkUpgrade";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:checkUpgrade";

                    /// <summary>Initializes CheckUpgrade parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Create a new environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent must be of the form "projects/{projectId}/locations/{locationId}".
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudComposer.v1beta1.Data.Environment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new environment.</summary>
                public class CreateRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.Environment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The parent must be of the form "projects/{projectId}/locations/{locationId}".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.Environment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/environments";

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

                /// <summary>Triggers database failover (only for highly resilient environments).</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// Target environment: "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual DatabaseFailoverRequest DatabaseFailover(Google.Apis.CloudComposer.v1beta1.Data.DatabaseFailoverRequest body, string environment)
                {
                    return new DatabaseFailoverRequest(this.service, body, environment);
                }

                /// <summary>Triggers database failover (only for highly resilient environments).</summary>
                public class DatabaseFailoverRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new DatabaseFailover request.</summary>
                    public DatabaseFailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.DatabaseFailoverRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Target environment: "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.DatabaseFailoverRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "databaseFailover";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:databaseFailover";

                    /// <summary>Initializes DatabaseFailover parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Delete an environment.</summary>
                /// <param name="name">
                /// The environment to delete, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete an environment.</summary>
                public class DeleteRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The environment to delete, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Executes Airflow CLI command.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the environment in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}".
                /// </param>
                public virtual ExecuteAirflowCommandRequest ExecuteAirflowCommand(Google.Apis.CloudComposer.v1beta1.Data.ExecuteAirflowCommandRequest body, string environment)
                {
                    return new ExecuteAirflowCommandRequest(this.service, body, environment);
                }

                /// <summary>Executes Airflow CLI command.</summary>
                public class ExecuteAirflowCommandRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ExecuteAirflowCommandResponse>
                {
                    /// <summary>Constructs a new ExecuteAirflowCommand request.</summary>
                    public ExecuteAirflowCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.ExecuteAirflowCommandRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.ExecuteAirflowCommandRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "executeAirflowCommand";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:executeAirflowCommand";

                    /// <summary>Initializes ExecuteAirflowCommand parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Fetches database properties.</summary>
                /// <param name="environment">
                /// Required. The resource name of the environment, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual FetchDatabasePropertiesRequest FetchDatabaseProperties(string environment)
                {
                    return new FetchDatabasePropertiesRequest(this.service, environment);
                }

                /// <summary>Fetches database properties.</summary>
                public class FetchDatabasePropertiesRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.FetchDatabasePropertiesResponse>
                {
                    /// <summary>Constructs a new FetchDatabaseProperties request.</summary>
                    public FetchDatabasePropertiesRequest(Google.Apis.Services.IClientService service, string environment) : base(service)
                    {
                        Environment = environment;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the environment, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchDatabaseProperties";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:fetchDatabaseProperties";

                    /// <summary>Initializes FetchDatabaseProperties parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Get an existing environment.</summary>
                /// <param name="name">
                /// The resource name of the environment to get, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get an existing environment.</summary>
                public class GetRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Environment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment to get, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>List environments.</summary>
                /// <param name="parent">
                /// List environments in the given project and location, in the form:
                /// "projects/{projectId}/locations/{locationId}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List environments.</summary>
                public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListEnvironmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// List environments in the given project and location, in the form:
                    /// "projects/{projectId}/locations/{locationId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of environments to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/environments";

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

                /// <summary>
                /// Loads a snapshot of a Cloud Composer environment. As a result of this operation, a snapshot of
                /// environment's specified in LoadSnapshotRequest is loaded into the environment.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the target environment in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual LoadSnapshotRequest LoadSnapshot(Google.Apis.CloudComposer.v1beta1.Data.LoadSnapshotRequest body, string environment)
                {
                    return new LoadSnapshotRequest(this.service, body, environment);
                }

                /// <summary>
                /// Loads a snapshot of a Cloud Composer environment. As a result of this operation, a snapshot of
                /// environment's specified in LoadSnapshotRequest is loaded into the environment.
                /// </summary>
                public class LoadSnapshotRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new LoadSnapshot request.</summary>
                    public LoadSnapshotRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.LoadSnapshotRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the target environment in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.LoadSnapshotRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "loadSnapshot";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:loadSnapshot";

                    /// <summary>Initializes LoadSnapshot parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Update an environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the environment to update, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudComposer.v1beta1.Data.Environment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Update an environment.</summary>
                public class PatchRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.Environment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the environment to update, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of paths, relative to `Environment`, of fields to update. For
                    /// example, to set the version of scikit-learn to install in the environment to 0.19.0 and to
                    /// remove an existing installation of argparse, the `updateMask` parameter would include the
                    /// following two `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
                    /// "config.softwareConfig.pypiPackages.argparse". The included patch environment would specify the
                    /// scikit-learn version as follows: { "config":{ "softwareConfig":{ "pypiPackages":{
                    /// "scikit-learn":"==0.19.0" } } } } Note that in the above example, any existing PyPI packages
                    /// other than scikit-learn and argparse will be unaffected. Only one update type may be included in
                    /// a single request's `updateMask`. For example, one cannot update both the PyPI packages and
                    /// labels in the same request. However, it is possible to update multiple members of a map field
                    /// simultaneously in the same request. For example, to set the labels "label1" and "label2" while
                    /// clearing "label3" (assuming it already exists), one can provide the paths "labels.label1",
                    /// "labels.label2", and "labels.label3" and populate the patch environment as follows: { "labels":{
                    /// "label1":"new-label1-value" "label2":"new-label2-value" } } Note that in the above example, any
                    /// existing labels that are not included in the `updateMask` will be unaffected. It is also
                    /// possible to replace an entire map field by providing the map field's path in the `updateMask`.
                    /// The new value of the field will be that which is provided in the patch environment. For example,
                    /// to delete all pre-existing user-specified PyPI packages and install botocore at version 1.7.14,
                    /// the `updateMask` would contain the path "config.softwareConfig.pypiPackages", and the patch
                    /// environment would be the following: { "config":{ "softwareConfig":{ "pypiPackages":{
                    /// "botocore":"==1.7.14" } } } } **Note:** Only the following fields can be updated: *
                    /// `config.softwareConfig.pypiPackages` * Replace all custom custom PyPI packages. If a replacement
                    /// package map is not included in `environment`, all custom PyPI packages are cleared. It is an
                    /// error to provide both this mask and a mask specifying an individual package. *
                    /// `config.softwareConfig.pypiPackages.`packagename * Update the custom PyPI package *packagename*,
                    /// preserving other packages. To delete the package, include it in `updateMask`, and omit the
                    /// mapping for it in `environment.config.softwareConfig.pypiPackages`. It is an error to provide
                    /// both a mask of this form and the `config.softwareConfig.pypiPackages` mask. * `labels` * Replace
                    /// all environment labels. If a replacement labels map is not included in `environment`, all labels
                    /// are cleared. It is an error to provide both this mask and a mask specifying one or more
                    /// individual labels. * `labels.`labelName * Set the label named *labelName*, while preserving
                    /// other labels. To delete the label, include it in `updateMask` and omit its mapping in
                    /// `environment.labels`. It is an error to provide both a mask of this form and the `labels` mask.
                    /// * `config.nodeCount` * Horizontally scale the number of nodes in the environment. An integer
                    /// greater than or equal to 3 must be provided in the `config.nodeCount` field. Supported for Cloud
                    /// Composer environments in versions composer-1.*.*-airflow-*.*.*. *
                    /// `config.webServerNetworkAccessControl` * Replace the environment's current
                    /// WebServerNetworkAccessControl. * `config.softwareConfig.airflowConfigOverrides` * Replace all
                    /// Apache Airflow config overrides. If a replacement config overrides map is not included in
                    /// `environment`, all config overrides are cleared. It is an error to provide both this mask and a
                    /// mask specifying one or more individual config overrides. *
                    /// `config.softwareConfig.airflowConfigOverrides.`section-name * Override the Apache Airflow config
                    /// property *name* in the section named *section*, preserving other properties. To delete the
                    /// property override, include it in `updateMask` and omit its mapping in
                    /// `environment.config.softwareConfig.airflowConfigOverrides`. It is an error to provide both a
                    /// mask of this form and the `config.softwareConfig.airflowConfigOverrides` mask. *
                    /// `config.softwareConfig.envVariables` * Replace all environment variables. If a replacement
                    /// environment variable map is not included in `environment`, all custom environment variables are
                    /// cleared. * `config.softwareConfig.imageVersion` * Upgrade the version of the environment
                    /// in-place. Refer to `SoftwareConfig.image_version` for information on how to format the new image
                    /// version. Additionally, the new image version cannot effect a version downgrade, and must match
                    /// the current image version's Composer and Airflow major versions. Consult the [Cloud Composer
                    /// version list](/composer/docs/concepts/versioning/composer-versions) for valid values. *
                    /// `config.softwareConfig.schedulerCount` * Horizontally scale the number of schedulers in Airflow.
                    /// A positive integer not greater than the number of nodes must be provided in the
                    /// `config.softwareConfig.schedulerCount` field. Supported for Cloud Composer environments in
                    /// versions composer-1.*.*-airflow-2.*.*. * `config.softwareConfig.cloudDataLineageIntegration` *
                    /// Configuration for Cloud Data Lineage integration. * `config.databaseConfig.machineType` * Cloud
                    /// SQL machine type used by Airflow database. It has to be one of: db-n1-standard-2,
                    /// db-n1-standard-4, db-n1-standard-8 or db-n1-standard-16. Supported for Cloud Composer
                    /// environments in versions composer-1.*.*-airflow-*.*.*. * `config.webServerConfig.machineType` *
                    /// Machine type on which Airflow web server is running. It has to be one of:
                    /// composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Supported for Cloud
                    /// Composer environments in versions composer-1.*.*-airflow-*.*.*. * `config.maintenanceWindow` *
                    /// Maintenance window during which Cloud Composer components may be under maintenance. *
                    /// `config.workloadsConfig` * The workloads configuration settings for the GKE cluster associated
                    /// with the Cloud Composer environment. Supported for Cloud Composer environments in versions
                    /// composer-2.*.*-airflow-*.*.* and newer. * `config.environmentSize` * The size of the Cloud
                    /// Composer environment. Supported for Cloud Composer environments in versions
                    /// composer-2.*.*-airflow-*.*.* and newer.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.Environment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
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

                /// <summary>Polls Airflow CLI command execution and fetches logs.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the environment in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual PollAirflowCommandRequest PollAirflowCommand(Google.Apis.CloudComposer.v1beta1.Data.PollAirflowCommandRequest body, string environment)
                {
                    return new PollAirflowCommandRequest(this.service, body, environment);
                }

                /// <summary>Polls Airflow CLI command execution and fetches logs.</summary>
                public class PollAirflowCommandRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.PollAirflowCommandResponse>
                {
                    /// <summary>Constructs a new PollAirflowCommand request.</summary>
                    public PollAirflowCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.PollAirflowCommandRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.PollAirflowCommandRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "pollAirflowCommand";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:pollAirflowCommand";

                    /// <summary>Initializes PollAirflowCommand parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Restart Airflow web server.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the environment to restart the web server for, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual RestartWebServerRequest RestartWebServer(Google.Apis.CloudComposer.v1beta1.Data.RestartWebServerRequest body, string name)
                {
                    return new RestartWebServerRequest(this.service, body, name);
                }

                /// <summary>Restart Airflow web server.</summary>
                public class RestartWebServerRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new RestartWebServer request.</summary>
                    public RestartWebServerRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.RestartWebServerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment to restart the web server for, in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.RestartWebServerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restartWebServer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:restartWebServer";

                    /// <summary>Initializes RestartWebServer parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a snapshots of a Cloud Composer environment. As a result of this operation, snapshot of
                /// environment's state is stored in a location specified in the SaveSnapshotRequest.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the source environment in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual SaveSnapshotRequest SaveSnapshot(Google.Apis.CloudComposer.v1beta1.Data.SaveSnapshotRequest body, string environment)
                {
                    return new SaveSnapshotRequest(this.service, body, environment);
                }

                /// <summary>
                /// Creates a snapshots of a Cloud Composer environment. As a result of this operation, snapshot of
                /// environment's state is stored in a location specified in the SaveSnapshotRequest.
                /// </summary>
                public class SaveSnapshotRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new SaveSnapshot request.</summary>
                    public SaveSnapshotRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.SaveSnapshotRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the source environment in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.SaveSnapshotRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "saveSnapshot";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:saveSnapshot";

                    /// <summary>Initializes SaveSnapshot parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops Airflow CLI command execution.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="environment">
                /// The resource name of the environment in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}".
                /// </param>
                public virtual StopAirflowCommandRequest StopAirflowCommand(Google.Apis.CloudComposer.v1beta1.Data.StopAirflowCommandRequest body, string environment)
                {
                    return new StopAirflowCommandRequest(this.service, body, environment);
                }

                /// <summary>Stops Airflow CLI command execution.</summary>
                public class StopAirflowCommandRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.StopAirflowCommandResponse>
                {
                    /// <summary>Constructs a new StopAirflowCommand request.</summary>
                    public StopAirflowCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudComposer.v1beta1.Data.StopAirflowCommandRequest body, string environment) : base(service)
                    {
                        Environment = environment;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the environment in the form:
                    /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Environment { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudComposer.v1beta1.Data.StopAirflowCommandRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stopAirflowCommand";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+environment}:stopAirflowCommand";

                    /// <summary>Initializes StopAirflowCommand parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environment",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/environments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ImageVersions resource.</summary>
            public virtual ImageVersionsResource ImageVersions { get; }

            /// <summary>The "imageVersions" collection of methods.</summary>
            public class ImageVersionsResource
            {
                private const string Resource = "imageVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImageVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List ImageVersions for provided location.</summary>
                /// <param name="parent">
                /// List ImageVersions in the given project and location, in the form:
                /// "projects/{projectId}/locations/{locationId}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List ImageVersions for provided location.</summary>
                public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListImageVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// List ImageVersions in the given project and location, in the form:
                    /// "projects/{projectId}/locations/{locationId}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Whether or not image versions from old releases should be included.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includePastReleases", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludePastReleases { get; set; }

                    /// <summary>The maximum number of image_versions to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/imageVersions";

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
                        RequestParameters.Add("includePastReleases", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includePastReleases",
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
                public class DeleteRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Empty>
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
                public class GetRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.Operation>
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
                public class ListRequest : CloudComposerBaseServiceRequest<Google.Apis.CloudComposer.v1beta1.Data.ListOperationsResponse>
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
namespace Google.Apis.CloudComposer.v1beta1.Data
{
    /// <summary>The policy for airflow metadata database retention.</summary>
    public class AirflowMetadataRetentionPolicyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. How many days data should be retained for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionDays")]
        public virtual System.Nullable<int> RetentionDays { get; set; }

        /// <summary>Optional. Retention can be either enabled or disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionMode")]
        public virtual string RetentionMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Allowed IP range with user-provided description.</summary>
    public class AllowedIpRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User-provided description. It must contain at most 300 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// IP address or range, defined using CIDR notation, of requests that this rule applies to. Examples:
        /// `192.168.1.1` or `192.168.0.0/16` or `2001:db8::/32` or `2001:0db8:0000:0042:0000:8a2e:0370:7334`. IP range
        /// prefixes should be properly truncated. For example, `1.2.3.4/24` should be truncated to `1.2.3.0/24`.
        /// Similarly, for IPv6, `2001:db8::1/32` should be truncated to `2001:db8::/32`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to check whether image upgrade will succeed.</summary>
    public class CheckUpgradeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The version of the software running in the environment. This encapsulates both the version of Cloud Composer
        /// functionality and the version of Apache Airflow. It must match the regular expression
        /// `composer-([0-9]+(\.[0-9]+\.[0-9]+(-preview\.[0-9]+)?)?|latest)-airflow-([0-9]+(\.[0-9]+(\.[0-9]+)?)?)`.
        /// When used as input, the server also checks if the provided version is supported and denies the request for
        /// an unsupported version. The Cloud Composer portion of the image version is a full [semantic
        /// version](https://semver.org), or an alias in the form of major version number or `latest`. When an alias is
        /// provided, the server replaces it with the current Cloud Composer version that satisfies the alias. The
        /// Apache Airflow portion of the image version is a full semantic version that points to one of the supported
        /// Apache Airflow versions, or an alias in the form of only major or major.minor versions specified. When an
        /// alias is provided, the server replaces it with the latest Apache Airflow version that satisfies the alias
        /// and is supported in the given Cloud Composer version. In all cases, the resolved image version is stored in
        /// the same field. See also [version list](/composer/docs/concepts/versioning/composer-versions) and
        /// [versioning overview](/composer/docs/concepts/versioning/composer-versioning-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing information about the result of an upgrade check operation.</summary>
    public class CheckUpgradeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Url for a docker build log of an upgraded image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildLogUri")]
        public virtual string BuildLogUri { get; set; }

        /// <summary>Output only. Whether build has succeeded or failed on modules conflicts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsPypiModulesConflict")]
        public virtual string ContainsPypiModulesConflict { get; set; }

        /// <summary>Composer image for which the build was happening.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>
        /// Output only. Extract from a docker image build log containing information about pypi modules conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pypiConflictBuildLogExtract")]
        public virtual string PypiConflictBuildLogExtract { get; set; }

        /// <summary>
        /// Pypi dependencies specified in the environment configuration, at the time when the build was triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pypiDependencies")]
        public virtual System.Collections.Generic.IDictionary<string, string> PypiDependencies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CIDR block with an optional name.</summary>
    public class CidrBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CIDR block that must be specified in CIDR notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrBlock")]
        public virtual string CidrBlockValue { get; set; }

        /// <summary>User-defined name that identifies the CIDR block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Cloud Data Lineage integration.</summary>
    public class CloudDataLineageIntegration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether or not Cloud Data Lineage integration is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a single workload.</summary>
    public class ComposerWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Status of a workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ComposerWorkloadStatus Status { get; set; }

        /// <summary>Type of a workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Workload status.</summary>
    public class ComposerWorkloadStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Detailed message of the status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedStatusMessage")]
        public virtual string DetailedStatusMessage { get; set; }

        /// <summary>Output only. Workload state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Text to provide more descriptive status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for resources used by Airflow DAG processors. This field is supported for Cloud Composer
    /// environments in versions composer-3-airflow-*.*.*-build.* and newer.
    /// </summary>
    public class DagProcessorResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The number of DAG processors. If not provided or set to 0, a single DAG processor instance will be
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Optional. CPU request and limit for a single Airflow DAG processor replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<float> Cpu { get; set; }

        /// <summary>Optional. Memory (GB) request and limit for a single Airflow DAG processor replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<float> MemoryGb { get; set; }

        /// <summary>Optional. Storage (GB) request and limit for a single Airflow DAG processor replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageGb")]
        public virtual System.Nullable<float> StorageGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration setting for Airflow database data retention mechanism.</summary>
    public class DataRetentionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The number of days describing for how long to store event-based records in airflow database. If
        /// the retention mechanism is enabled this value must be a positive integer otherwise, value should be set to
        /// 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airflowDatabaseRetentionDays")]
        public virtual System.Nullable<int> AirflowDatabaseRetentionDays { get; set; }

        /// <summary>Optional. The retention policy for airflow metadata database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airflowMetadataRetentionConfig")]
        public virtual AirflowMetadataRetentionPolicyConfig AirflowMetadataRetentionConfig { get; set; }

        /// <summary>Optional. The configuration settings for task logs retention</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskLogsRetentionConfig")]
        public virtual TaskLogsRetentionConfig TaskLogsRetentionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of Cloud SQL instance that is used by the Apache Airflow software.</summary>
    public class DatabaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud SQL machine type used by Airflow database. It has to be one of: db-n1-standard-2,
        /// db-n1-standard-4, db-n1-standard-8 or db-n1-standard-16. If not specified, db-n1-standard-2 will be used.
        /// Supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The Compute Engine zone where the Airflow database is created. If zone is provided, it must be in
        /// the region selected for the environment. If zone is not provided, a zone is automatically selected. The zone
        /// can only be set during environment creation. Supported for Cloud Composer environments in versions
        /// composer-2.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to trigger database failover (only for highly resilient environments).</summary>
    public class DatabaseFailoverRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for DatabaseFailoverRequest.</summary>
    public class DatabaseFailoverResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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
    /// The encryption options for the Cloud Composer environment and its dependencies. Supported for Cloud Composer
    /// environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Customer-managed Encryption Key available through Google's Key Management Service. Cannot be
        /// updated. If not specified, Google-managed key will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An environment for running orchestration tasks.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration parameters for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual EnvironmentConfig Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this environment was created.</summary>
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
        /// Optional. User-defined labels for this environment. The labels map can contain no more than 64 entries.
        /// Entries of the labels map are UTF8 strings that comply with the following restrictions: * Keys must conform
        /// to regexp: \p{Ll}\p{Lo}{0,62} * Values must conform to regexp: [\p{Ll}\p{Lo}\p{N}_-]{0,63} * Both keys and
        /// values are additionally constrained to be &amp;lt;= 128 bytes in size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}" EnvironmentId must start with a
        /// lowercase letter followed by up to 63 lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>The current state of the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Storage configuration for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageConfig")]
        public virtual StorageConfig StorageConfig { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this environment was last modified.</summary>
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

        /// <summary>
        /// Output only. The UUID (Universally Unique IDentifier) associated with this environment. This value is
        /// generated when the environment is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uuid")]
        public virtual string Uuid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information for an environment.</summary>
    public class EnvironmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The 'bring your own identity' variant of the URI of the Apache Airflow Web UI hosted within
        /// this environment, to be accessed with external identities using workforce identity federation (see [Access
        /// environments with workforce identity
        /// federation](/composer/docs/composer-2/access-environments-with-workforce-identity-federation)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airflowByoidUri")]
        public virtual string AirflowByoidUri { get; set; }

        /// <summary>
        /// Output only. The URI of the Apache Airflow Web UI hosted within this environment (see [Airflow web
        /// interface](/composer/docs/how-to/accessing/airflow-web-interface)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airflowUri")]
        public virtual string AirflowUri { get; set; }

        /// <summary>
        /// Output only. The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects
        /// reside in a flat namespace, a hierarchical file tree can be simulated using "/"-delimited object name
        /// prefixes. DAG objects for this environment reside in a simulated directory with the given prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagGcsPrefix")]
        public virtual string DagGcsPrefix { get; set; }

        /// <summary>Optional. The configuration setting for Airflow database data retention mechanism.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionConfig")]
        public virtual DataRetentionConfig DataRetentionConfig { get; set; }

        /// <summary>
        /// Optional. The configuration settings for Cloud SQL instance used internally by Apache Airflow software.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseConfig")]
        public virtual DatabaseConfig DatabaseConfig { get; set; }

        /// <summary>
        /// Optional. The encryption options for the Cloud Composer environment and its dependencies. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Optional. The size of the Cloud Composer environment. This field is supported for Cloud Composer
        /// environments in versions composer-2.*.*-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentSize")]
        public virtual string EnvironmentSize { get; set; }

        /// <summary>Output only. The Kubernetes Engine cluster used to run this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeCluster")]
        public virtual string GkeCluster { get; set; }

        /// <summary>
        /// Optional. The maintenance window is the period when Cloud Composer components may undergo maintenance. It is
        /// defined so that maintenance is not executed during peak hours or critical time periods. The system will not
        /// be under maintenance for every occurrence of this window, but when maintenance is planned, it will be
        /// scheduled during the window. The maintenance window period must encompass at least 12 hours per week. This
        /// may be split into multiple chunks, each with a size of at least 4 hours. If this value is omitted, the
        /// default value for maintenance window is applied. By default, maintenance windows are from 00:00:00 to
        /// 04:00:00 (GMT) on Friday, Saturday, and Sunday every week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Optional. The configuration options for GKE cluster master authorized networks. By default master authorized
        /// networks feature is: - in case of private environment: enabled with no external networks allowlisted. - in
        /// case of public environment: disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterAuthorizedNetworksConfig")]
        public virtual MasterAuthorizedNetworksConfig MasterAuthorizedNetworksConfig { get; set; }

        /// <summary>Optional. The configuration used for the Kubernetes Engine cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual NodeConfig NodeConfig { get; set; }

        /// <summary>
        /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment. This field
        /// is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Optional. The configuration used for the Private IP Cloud Composer environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEnvironmentConfig")]
        public virtual PrivateEnvironmentConfig PrivateEnvironmentConfig { get; set; }

        /// <summary>
        /// Optional. The Recovery settings configuration of an environment. This field is supported for Cloud Composer
        /// environments in versions composer-2.*.*-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryConfig")]
        public virtual RecoveryConfig RecoveryConfig { get; set; }

        /// <summary>
        /// Optional. Resilience mode of the Cloud Composer Environment. This field is supported for Cloud Composer
        /// environments in versions composer-2.2.0-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resilienceMode")]
        public virtual string ResilienceMode { get; set; }

        /// <summary>Optional. The configuration settings for software inside the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareConfig")]
        public virtual SoftwareConfig SoftwareConfig { get; set; }

        /// <summary>
        /// Optional. The configuration settings for the Airflow web server App Engine instance. This field is supported
        /// for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerConfig")]
        public virtual WebServerConfig WebServerConfig { get; set; }

        /// <summary>
        /// Optional. The network-level access control policy for the Airflow web server. If unspecified, no
        /// network-level access restrictions will be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerNetworkAccessControl")]
        public virtual WebServerNetworkAccessControl WebServerNetworkAccessControl { get; set; }

        /// <summary>
        /// Optional. The workloads configuration settings for the GKE cluster associated with the Cloud Composer
        /// environment. The GKE cluster runs Airflow scheduler, web server and workers workloads. This field is
        /// supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadsConfig")]
        public virtual WorkloadsConfig WorkloadsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execute Airflow Command request.</summary>
    public class ExecuteAirflowCommandRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Airflow command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>
        /// Parameters for the Airflow command/subcommand as an array of arguments. It may contain positional arguments
        /// like `["my-dag-id"]`, key-value parameters like `["--foo=bar"]` or `["--foo","bar"]`, or other flags like
        /// `["-f"]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<string> Parameters { get; set; }

        /// <summary>Airflow subcommand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subcommand")]
        public virtual string Subcommand { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to ExecuteAirflowCommandRequest.</summary>
    public class ExecuteAirflowCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error message. Empty if there was no error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>The unique ID of the command execution for polling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>The name of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pod")]
        public virtual string Pod { get; set; }

        /// <summary>The namespace of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podNamespace")]
        public virtual string PodNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about how a command ended.</summary>
    public class ExitInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error message. Empty if there was no error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>The exit code from the command execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for FetchDatabasePropertiesRequest.</summary>
    public class FetchDatabasePropertiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The availability status of the failover replica. A false status indicates that the failover replica is out
        /// of sync. The primary instance can only fail over to the failover replica when the status is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFailoverReplicaAvailable")]
        public virtual System.Nullable<bool> IsFailoverReplicaAvailable { get; set; }

        /// <summary>The Compute Engine zone that the instance is currently serving from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryGceZone")]
        public virtual string PrimaryGceZone { get; set; }

        /// <summary>
        /// The Compute Engine zone that the failover instance is currently serving from for a regional Cloud SQL
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryGceZone")]
        public virtual string SecondaryGceZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for controlling how IPs are allocated in the GKE cluster.</summary>
    public class IPAllocationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The IP address range used to allocate IP addresses to pods in the cluster. For Cloud Composer
        /// environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when `use_ip_aliases`
        /// is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. `/14`) to have
        /// GKE choose a range with a specific netmask. Set to a
        /// [CIDR](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`) from the
        /// RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range to
        /// use. Specify `cluster_secondary_range_name` or `cluster_ipv4_cidr_block` but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIpv4CidrBlock")]
        public virtual string ClusterIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. The name of the cluster's secondary range used to allocate IP addresses to pods. Specify either
        /// `cluster_secondary_range_name` or `cluster_ipv4_cidr_block` but not both. For Cloud Composer environments in
        /// versions composer-1.*.*-airflow-*.*.*, this field is applicable only when `use_ip_aliases` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterSecondaryRangeName")]
        public virtual string ClusterSecondaryRangeName { get; set; }

        /// <summary>
        /// Optional. The IP address range of the services IP addresses in this cluster. For Cloud Composer environments
        /// in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when `use_ip_aliases` is true. Set
        /// to blank to have GKE choose a range with the default size. Set to /netmask (e.g. `/14`) to have GKE choose a
        /// range with a specific netmask. Set to a [CIDR](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing)
        /// notation (e.g. `10.96.0.0/14`) from the RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`,
        /// `192.168.0.0/16`) to pick a specific range to use. Specify `services_secondary_range_name` or
        /// `services_ipv4_cidr_block` but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesIpv4CidrBlock")]
        public virtual string ServicesIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. The name of the services' secondary range used to allocate IP addresses to the cluster. Specify
        /// either `services_secondary_range_name` or `services_ipv4_cidr_block` but not both. For Cloud Composer
        /// environments in versions composer-1.*.*-airflow-*.*.*, this field is applicable only when `use_ip_aliases`
        /// is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesSecondaryRangeName")]
        public virtual string ServicesSecondaryRangeName { get; set; }

        /// <summary>
        /// Optional. Whether or not to enable Alias IPs in the GKE cluster. If `true`, a VPC-native cluster is created.
        /// This field is only supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// Environments in newer versions always use VPC-native GKE clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useIpAliases")]
        public virtual System.Nullable<bool> UseIpAliases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Image Version information</summary>
    public class ImageVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether it is impossible to create an environment with the image version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationDisabled")]
        public virtual System.Nullable<bool> CreationDisabled { get; set; }

        /// <summary>The string identifier of the ImageVersion, in the form: "composer-x.y.z-airflow-a.b.c"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersionId")]
        public virtual string ImageVersionId { get; set; }

        /// <summary>
        /// Whether this is the default ImageVersion used by Composer during environment creation if no input
        /// ImageVersion is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The date of the version release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseDate")]
        public virtual Date ReleaseDate { get; set; }

        /// <summary>supported python versions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedPythonVersions")]
        public virtual System.Collections.Generic.IList<string> SupportedPythonVersions { get; set; }

        /// <summary>Whether it is impossible to upgrade an environment running with the image version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeDisabled")]
        public virtual System.Nullable<bool> UpgradeDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about a single line from logs.</summary>
    public class Line : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text content of the log line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Number of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<int> LineNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environments in a project and location.</summary>
    public class ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of environments returned by a ListEnvironmentsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<Environment> Environments { get; set; }

        /// <summary>The page token used to query for the next page if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ImageVersions in a project and location.</summary>
    public class ListImageVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of supported ImageVersions in a location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersions")]
        public virtual System.Collections.Generic.IList<ImageVersion> ImageVersions { get; set; }

        /// <summary>The page token used to query for the next page if one exists.</summary>
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

    /// <summary>The user workloads ConfigMaps for a given environment.</summary>
    public class ListUserWorkloadsConfigMapsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to query for the next page if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ConfigMaps returned by a ListUserWorkloadsConfigMapsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userWorkloadsConfigMaps")]
        public virtual System.Collections.Generic.IList<UserWorkloadsConfigMap> UserWorkloadsConfigMaps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The user workloads Secrets for a given environment.</summary>
    public class ListUserWorkloadsSecretsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to query for the next page if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Secrets returned by a ListUserWorkloadsSecretsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userWorkloadsSecrets")]
        public virtual System.Collections.Generic.IList<UserWorkloadsSecret> UserWorkloadsSecrets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to ListWorkloadsRequest.</summary>
    public class ListWorkloadsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The page token used to query for the next page if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of environment workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloads")]
        public virtual System.Collections.Generic.IList<ComposerWorkload> Workloads { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to load a snapshot into a Cloud Composer environment.</summary>
    public class LoadSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not to skip setting Airflow overrides when loading the environment's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipAirflowOverridesSetting")]
        public virtual System.Nullable<bool> SkipAirflowOverridesSetting { get; set; }

        /// <summary>
        /// Whether or not to skip setting environment variables when loading the environment's state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipEnvironmentVariablesSetting")]
        public virtual System.Nullable<bool> SkipEnvironmentVariablesSetting { get; set; }

        /// <summary>Whether or not to skip copying Cloud Storage data when loading the environment's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipGcsDataCopying")]
        public virtual System.Nullable<bool> SkipGcsDataCopying { get; set; }

        /// <summary>Whether or not to skip installing Pypi packages when loading the environment's state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipPypiPackagesInstallation")]
        public virtual System.Nullable<bool> SkipPypiPackagesInstallation { get; set; }

        /// <summary>
        /// A Cloud Storage path to a snapshot to load, e.g.:
        /// "gs://my-bucket/snapshots/project_location_environment_timestamp".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotPath")]
        public virtual string SnapshotPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to LoadSnapshotRequest.</summary>
    public class LoadSnapshotResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration settings for Cloud Composer maintenance window. The following example:
    /// ```
    /// {
    /// "startTime":"2019-08-01T01:00:00Z" "endTime":"2019-08-01T07:00:00Z" "recurrence":"FREQ=WEEKLY;BYDAY=TU,WE" }
    /// ```
    /// would define a maintenance window between 01 and 07 hours UTC during each Tuesday and Wednesday.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Required. Maintenance window end time. It is used only to calculate the duration of the maintenance window.
        /// The value for end_time must be in the future, relative to `start_time`.
        /// </summary>
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
        /// Required. Maintenance window recurrence. Format is a subset of
        /// [RFC-5545](https://tools.ietf.org/html/rfc5545) `RRULE`. The only allowed values for `FREQ` field are
        /// `FREQ=DAILY` and `FREQ=WEEKLY;BYDAY=...` Example values: `FREQ=WEEKLY;BYDAY=TU,WE`, `FREQ=DAILY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrence")]
        public virtual string Recurrence { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. Start time of the first recurrence of the maintenance window.</summary>
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

    /// <summary>
    /// Configuration options for the master authorized networks feature. Enabled master authorized networks will
    /// disallow all external traffic to access Kubernetes master through HTTPS except traffic from the given CIDR
    /// blocks, Google Compute Engine Public IPs and Google Prod IPs.
    /// </summary>
    public class MasterAuthorizedNetworksConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Up to 50 external networks that could access Kubernetes master through HTTPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrBlocks")]
        public virtual System.Collections.Generic.IList<CidrBlock> CidrBlocks { get; set; }

        /// <summary>Optional. Whether or not master authorized networks feature is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for networking connections in the Composer 2 environment.</summary>
    public class NetworkingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates the user requested specific connection type between Tenant and Customer projects. You
        /// cannot set networking connection type in public IP environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration information for the Kubernetes Engine nodes running the Apache Airflow software.
    /// </summary>
    public class NodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The IP range in CIDR notation to use internally by Cloud Composer. IP addresses are not reserved -
        /// and the same range can be used by multiple Cloud Composer environments. In case of overlap, IPs from this
        /// range will not be accessible in the user's VPC network. Cannot be updated. If not specified, the default
        /// value of '100.64.128.0/20' is used. This field is supported for Cloud Composer environments in versions
        /// composer-3-airflow-*.*.*-build.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("composerInternalIpv4CidrBlock")]
        public virtual string ComposerInternalIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. Network Attachment that Cloud Composer environment is connected to, which provides connectivity
        /// with a user's VPC network. Takes precedence over network and subnetwork settings. If not provided, but
        /// network and subnetwork are defined during environment, it will be provisioned. If not provided and network
        /// and subnetwork are also empty, then connectivity to user's VPC network is disabled. Network attachment must
        /// be provided in format projects/{project}/regions/{region}/networkAttachments/{networkAttachment}. This field
        /// is supported for Cloud Composer environments in versions composer-3-airflow-*.*.*-build.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("composerNetworkAttachment")]
        public virtual string ComposerNetworkAttachment { get; set; }

        /// <summary>
        /// Optional. The disk size in GB used for node VMs. Minimum size is 30GB. If unspecified, defaults to 100GB.
        /// Cannot be updated. This field is supported for Cloud Composer environments in versions
        /// composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Deploys 'ip-masq-agent' daemon set in the GKE cluster and defines nonMasqueradeCIDRs equals to pod
        /// IP range so IP masquerading is used for all destination addresses, except between pods traffic. See:
        /// https://cloud.google.com/kubernetes-engine/docs/how-to/ip-masquerade-agent
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIpMasqAgent")]
        public virtual System.Nullable<bool> EnableIpMasqAgent { get; set; }

        /// <summary>Optional. The IPAllocationPolicy fields for the GKE cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAllocationPolicy")]
        public virtual IPAllocationPolicy IpAllocationPolicy { get; set; }

        /// <summary>
        /// Optional. The Compute Engine [zone](/compute/docs/regions-zones) in which to deploy the VMs used to run the
        /// Apache Airflow software, specified as a [relative resource
        /// name](/apis/design/resource_names#relative_resource_name). For example:
        /// "projects/{projectId}/zones/{zoneId}". This `location` must belong to the enclosing environment's project
        /// and location. If both this field and `nodeConfig.machineType` are specified, `nodeConfig.machineType` must
        /// belong to this `location`; if both are unspecified, the service will pick a zone in the Compute Engine
        /// region corresponding to the Cloud Composer location, and propagate that choice to both fields. If only one
        /// field (`location` or `nodeConfig.machineType`) is specified, the location information from the specified
        /// field will be propagated to the unspecified field. This field is supported for Cloud Composer environments
        /// in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. The Compute Engine [machine type](/compute/docs/machine-types) used for cluster instances,
        /// specified as a [relative resource name](/apis/design/resource_names#relative_resource_name). For example:
        /// "projects/{projectId}/zones/{zoneId}/machineTypes/{machineTypeId}". The `machineType` must belong to the
        /// enclosing environment's project and location. If both this field and `nodeConfig.location` are specified,
        /// this `machineType` must belong to the `nodeConfig.location`; if both are unspecified, the service will pick
        /// a zone in the Compute Engine region corresponding to the Cloud Composer location, and propagate that choice
        /// to both fields. If exactly one of this field and `nodeConfig.location` is specified, the location
        /// information from the specified field will be propagated to the unspecified field. The `machineTypeId` must
        /// not be a [shared-core machine type](/compute/docs/machine-types#sharedcore). If this field is unspecified,
        /// the `machineTypeId` defaults to "n1-standard-1". This field is supported for Cloud Composer environments in
        /// versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The maximum number of pods per node in the Cloud Composer GKE cluster. The value must be between 8
        /// and 110 and it can be set only if the environment is VPC-native. The default value is 32. Values of this
        /// field will be propagated both to the `default-pool` node pool of the newly created GKE cluster, and to the
        /// default "Maximum Pods per Node" value which is used for newly created node pools if their value is not
        /// explicitly set during node pool creation. For more information, see [Optimizing IP address allocation]
        /// (https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr). Cannot be updated. This field is
        /// supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPodsPerNode")]
        public virtual System.Nullable<int> MaxPodsPerNode { get; set; }

        /// <summary>
        /// Optional. The Compute Engine network to be used for machine communications, specified as a [relative
        /// resource name](/apis/design/resource_names#relative_resource_name). For example:
        /// "projects/{projectId}/global/networks/{networkId}". If unspecified, the default network in the environment's
        /// project is used. If a [Custom Subnet Network](/vpc/docs/vpc#vpc_networks_and_subnets) is provided,
        /// `nodeConfig.subnetwork` must also be provided. For [Shared VPC](/vpc/docs/shared-vpc) subnetwork
        /// requirements, see `nodeConfig.subnetwork`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The set of Google API scopes to be made available on all node VMs. If `oauth_scopes` is empty,
        /// defaults to ["https://www.googleapis.com/auth/cloud-platform"]. Cannot be updated. This field is supported
        /// for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthScopes")]
        public virtual System.Collections.Generic.IList<string> OauthScopes { get; set; }

        /// <summary>
        /// Optional. The Google Cloud Platform Service Account to be used by the workloads. If a service account is not
        /// specified, the "default" Compute Engine service account is used. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. The Compute Engine subnetwork to be used for machine communications, specified as a [relative
        /// resource name](/apis/design/resource_names#relative_resource_name). For example:
        /// "projects/{projectId}/regions/{regionId}/subnetworks/{subnetworkId}" If a subnetwork is provided,
        /// `nodeConfig.network` must also be provided, and the subnetwork must belong to the enclosing environment's
        /// project and location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// Optional. The list of instance tags applied to all node VMs. Tags are used to identify valid sources or
        /// targets for network firewalls. Each tag within the list must comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt). Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

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

    /// <summary>Metadata describing an operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was submitted to the server.</summary>
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

        /// <summary>
        /// Output only. The time when the operation terminated, regardless of its success. This field is unset if the
        /// operation is still ongoing.
        /// </summary>
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

        /// <summary>Output only. The type of operation being performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>
        /// Output only. The resource being operated on, as a [relative resource name](
        /// /apis/design/resource_names#relative_resource_name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Output only. The UUID of the resource being operated on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUuid")]
        public virtual string ResourceUuid { get; set; }

        /// <summary>Output only. The current operation state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Poll Airflow Command request.</summary>
    public class PollAirflowCommandRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the command execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>Line number from which new logs should be fetched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLineNumber")]
        public virtual System.Nullable<int> NextLineNumber { get; set; }

        /// <summary>The name of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pod")]
        public virtual string Pod { get; set; }

        /// <summary>The namespace of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podNamespace")]
        public virtual string PodNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to PollAirflowCommandRequest.</summary>
    public class PollAirflowCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result exit status of the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitInfo")]
        public virtual ExitInfo ExitInfo { get; set; }

        /// <summary>
        /// Output from the command execution. It may not contain the full output and the caller may need to poll for
        /// more lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual System.Collections.Generic.IList<Line> Output { get; set; }

        /// <summary>Whether the command execution has finished and there is no more output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputEnd")]
        public virtual System.Nullable<bool> OutputEnd { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for the private GKE cluster in a Cloud Composer environment.</summary>
    public class PrivateClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If `true`, access to the public endpoint of the GKE cluster is denied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateEndpoint")]
        public virtual System.Nullable<bool> EnablePrivateEndpoint { get; set; }

        /// <summary>
        /// Optional. The CIDR block from which IPv4 range for GKE master will be reserved. If left blank, the default
        /// value of '172.16.0.0/23' is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterIpv4CidrBlock")]
        public virtual string MasterIpv4CidrBlock { get; set; }

        /// <summary>
        /// Output only. The IP range in CIDR notation to use for the hosted master network. This range is used for
        /// assigning internal IP addresses to the cluster master or set of masters and to the internal load balancer
        /// virtual IP. This range must not overlap with any other ranges in use within the cluster's network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterIpv4ReservedRange")]
        public virtual string MasterIpv4ReservedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration information for configuring a Private IP Cloud Composer environment.</summary>
    public class PrivateEnvironmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When specified, the environment will use Private Service Connect instead of VPC peerings to
        /// connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP
        /// address from this subnetwork.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudComposerConnectionSubnetwork")]
        public virtual string CloudComposerConnectionSubnetwork { get; set; }

        /// <summary>
        /// Optional. The CIDR block from which IP range for Cloud Composer Network in tenant project will be reserved.
        /// Needs to be disjoint from private_cluster_config.master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block. This
        /// field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudComposerNetworkIpv4CidrBlock")]
        public virtual string CloudComposerNetworkIpv4CidrBlock { get; set; }

        /// <summary>
        /// Output only. The IP range reserved for the tenant project's Cloud Composer network. This field is supported
        /// for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudComposerNetworkIpv4ReservedRange")]
        public virtual string CloudComposerNetworkIpv4ReservedRange { get; set; }

        /// <summary>
        /// Optional. The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be
        /// disjoint from web_server_ipv4_cidr_block
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlIpv4CidrBlock")]
        public virtual string CloudSqlIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. If `true`, builds performed during operations that install Python packages have only private
        /// connectivity to Google services (including Artifact Registry) and VPC network (if either
        /// `NodeConfig.network` and `NodeConfig.subnetwork` fields or `NodeConfig.composer_network_attachment` field
        /// are specified). If `false`, the builds also have access to the internet. This field is supported for Cloud
        /// Composer environments in versions composer-3-airflow-*.*.*-build.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateBuildsOnly")]
        public virtual System.Nullable<bool> EnablePrivateBuildsOnly { get; set; }

        /// <summary>
        /// Optional. If `true`, a Private IP Cloud Composer environment is created. If this field is set to true,
        /// `IPAllocationPolicy.use_ip_aliases` must be set to true for Cloud Composer environments in versions
        /// composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateEnvironment")]
        public virtual System.Nullable<bool> EnablePrivateEnvironment { get; set; }

        /// <summary>
        /// Optional. When enabled, IPs from public (non-RFC1918) ranges can be used for
        /// `IPAllocationPolicy.cluster_ipv4_cidr_block` and `IPAllocationPolicy.service_ipv4_cidr_block`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivatelyUsedPublicIps")]
        public virtual System.Nullable<bool> EnablePrivatelyUsedPublicIps { get; set; }

        /// <summary>Optional. Configuration for the network connections configuration in the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkingConfig")]
        public virtual NetworkingConfig NetworkingConfig { get; set; }

        /// <summary>
        /// Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateClusterConfig")]
        public virtual PrivateClusterConfig PrivateClusterConfig { get; set; }

        /// <summary>
        /// Optional. The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from
        /// private_cluster_config.master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block. This field is supported for
        /// Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerIpv4CidrBlock")]
        public virtual string WebServerIpv4CidrBlock { get; set; }

        /// <summary>
        /// Output only. The IP range reserved for the tenant project's App Engine VMs. This field is supported for
        /// Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerIpv4ReservedRange")]
        public virtual string WebServerIpv4ReservedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Recovery settings of an environment.</summary>
    public class RecoveryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The configuration for scheduled snapshot creation mechanism.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledSnapshotsConfig")]
        public virtual ScheduledSnapshotsConfig ScheduledSnapshotsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Restart Airflow web server.</summary>
    public class RestartWebServerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a snapshot of a Cloud Composer environment.</summary>
    public class SaveSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Location in a Cloud Storage where the snapshot is going to be stored, e.g.: "gs://my-bucket/snapshots".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotLocation")]
        public virtual string SnapshotLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to SaveSnapshotRequest.</summary>
    public class SaveSnapshotResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully-resolved Cloud Storage path of the created snapshot, e.g.:
        /// "gs://my-bucket/snapshots/project_location_environment_timestamp". This field is populated only if the
        /// snapshot creation was successful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotPath")]
        public virtual string SnapshotPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for scheduled snapshot creation mechanism.</summary>
    public class ScheduledSnapshotsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether scheduled snapshots creation is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The cron expression representing the time when snapshots creation mechanism runs. This field is
        /// subject to additional validation around frequency of execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotCreationSchedule")]
        public virtual string SnapshotCreationSchedule { get; set; }

        /// <summary>Optional. The Cloud Storage location for storing automatically created snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotLocation")]
        public virtual string SnapshotLocation { get; set; }

        /// <summary>Optional. Time zone that sets the context to interpret snapshot_creation_schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    public class SchedulerResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of schedulers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Optional. CPU request and limit for a single Airflow scheduler replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<float> Cpu { get; set; }

        /// <summary>Optional. Memory (GB) request and limit for a single Airflow scheduler replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<float> MemoryGb { get; set; }

        /// <summary>Optional. Storage (GB) request and limit for a single Airflow scheduler replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageGb")]
        public virtual System.Nullable<float> StorageGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the selection and configuration of software inside the environment.</summary>
    public class SoftwareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Apache Airflow configuration properties to override. Property keys contain the section and
        /// property names, separated by a hyphen, for example "core-dags_are_paused_at_creation". Section names must
        /// not contain hyphens ("-"), opening square brackets ("["), or closing square brackets ("]"). The property
        /// name must not be empty and must not contain an equals sign ("=") or semicolon (";"). Section and property
        /// names must not contain a period ("."). Apache Airflow configuration property names must be written in
        /// [snake_case](https://en.wikipedia.org/wiki/Snake_case). Property values can contain any character, and can
        /// be written in any lower/upper case format. Certain Apache Airflow configuration property values are
        /// [blocked](/composer/docs/concepts/airflow-configurations), and cannot be overridden.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("airflowConfigOverrides")]
        public virtual System.Collections.Generic.IDictionary<string, string> AirflowConfigOverrides { get; set; }

        /// <summary>Optional. The configuration for Cloud Data Lineage integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDataLineageIntegration")]
        public virtual CloudDataLineageIntegration CloudDataLineageIntegration { get; set; }

        /// <summary>
        /// Optional. Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver
        /// processes. Environment variable names must match the regular expression `a-zA-Z_*`. They cannot specify
        /// Apache Airflow software configuration overrides (they cannot match the regular expression
        /// `AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+`), and they cannot match any of the following reserved names: *
        /// `AIRFLOW_HOME` * `C_FORCE_ROOT` * `CONTAINER_NAME` * `DAGS_FOLDER` * `GCP_PROJECT` * `GCS_BUCKET` *
        /// `GKE_CLUSTER_NAME` * `SQL_DATABASE` * `SQL_INSTANCE` * `SQL_PASSWORD` * `SQL_PROJECT` * `SQL_REGION` *
        /// `SQL_USER`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvVariables { get; set; }

        /// <summary>
        /// Optional. The version of the software running in the environment. This encapsulates both the version of
        /// Cloud Composer functionality and the version of Apache Airflow. It must match the regular expression
        /// `composer-([0-9]+(\.[0-9]+\.[0-9]+(-preview\.[0-9]+)?)?|latest)-airflow-([0-9]+(\.[0-9]+(\.[0-9]+)?)?)`.
        /// When used as input, the server also checks if the provided version is supported and denies the request for
        /// an unsupported version. The Cloud Composer portion of the image version is a full [semantic
        /// version](https://semver.org), or an alias in the form of major version number or `latest`. When an alias is
        /// provided, the server replaces it with the current Cloud Composer version that satisfies the alias. The
        /// Apache Airflow portion of the image version is a full semantic version that points to one of the supported
        /// Apache Airflow versions, or an alias in the form of only major or major.minor versions specified. When an
        /// alias is provided, the server replaces it with the latest Apache Airflow version that satisfies the alias
        /// and is supported in the given Cloud Composer version. In all cases, the resolved image version is stored in
        /// the same field. See also [version list](/composer/docs/concepts/versioning/composer-versions) and
        /// [versioning overview](/composer/docs/concepts/versioning/composer-versioning-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageVersion")]
        public virtual string ImageVersion { get; set; }

        /// <summary>
        /// Optional. Custom Python Package Index (PyPI) packages to be installed in the environment. Keys refer to the
        /// lowercase package name such as "numpy" and values are the lowercase extras and version specifier such as
        /// "==1.12.0", "[devel,gcp_api]", or "[devel]&amp;gt;=1.8.2, &amp;lt;1.9.2". To specify a package without
        /// pinning it to a version specifier, use the empty string as the value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pypiPackages")]
        public virtual System.Collections.Generic.IDictionary<string, string> PypiPackages { get; set; }

        /// <summary>
        /// Optional. The major version of Python used to run the Apache Airflow scheduler, worker, and webserver
        /// processes. Can be set to '2' or '3'. If not specified, the default is '3'. Cannot be updated. This field is
        /// only supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*. Environments in
        /// newer versions always use Python major version 3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonVersion")]
        public virtual string PythonVersion { get; set; }

        /// <summary>
        /// Optional. The number of schedulers for Airflow. This field is supported for Cloud Composer environments in
        /// versions composer-1.*.*-airflow-2.*.*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedulerCount")]
        public virtual System.Nullable<int> SchedulerCount { get; set; }

        /// <summary>
        /// Optional. Whether or not the web server uses custom plugins. If unspecified, the field defaults to
        /// `PLUGINS_ENABLED`. This field is supported for Cloud Composer environments in versions
        /// composer-3-airflow-*.*.*-build.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerPluginsMode")]
        public virtual string WebServerPluginsMode { get; set; }

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

    /// <summary>Stop Airflow Command request.</summary>
    public class StopAirflowCommandRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the command execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>
        /// If true, the execution is terminated forcefully (SIGKILL). If false, the execution is stopped gracefully,
        /// giving it time for cleanup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The name of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pod")]
        public virtual string Pod { get; set; }

        /// <summary>The namespace of the pod where the command is executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podNamespace")]
        public virtual string PodNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to StopAirflowCommandRequest.</summary>
    public class StopAirflowCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the execution is still running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDone")]
        public virtual System.Nullable<bool> IsDone { get; set; }

        /// <summary>Output message from stopping execution request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("output")]
        public virtual System.Collections.Generic.IList<string> Output { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for data storage in the environment.</summary>
    public class StorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the Cloud Storage bucket used by the environment. No `gs://` prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration setting for Task Logs.</summary>
    public class TaskLogsRetentionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The mode of storage for Airflow workers task logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageMode")]
        public virtual string StorageMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for resources used by Airflow triggerers.</summary>
    public class TriggererResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of triggerers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Optional. CPU request and limit for a single Airflow triggerer replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<float> Cpu { get; set; }

        /// <summary>Optional. Memory (GB) request and limit for a single Airflow triggerer replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<float> MemoryGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User workloads ConfigMap used by Airflow tasks that run with Kubernetes executor or KubernetesPodOperator.
    /// </summary>
    public class UserWorkloadsConfigMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The "data" field of Kubernetes ConfigMap, organized in key-value pairs. For details see:
        /// https://kubernetes.io/docs/concepts/configuration/configmap/ Example: { "example_key": "example_value",
        /// "another_key": "another_value" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// Identifier. The resource name of the ConfigMap, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsConfigMaps/{userWorkloadsConfigMapId}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User workloads Secret used by Airflow tasks that run with Kubernetes executor or KubernetesPodOperator.
    /// </summary>
    public class UserWorkloadsSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The "data" field of Kubernetes Secret, organized in key-value pairs, which can contain sensitive
        /// values such as a password, a token, or a key. The values for all keys have to be base64-encoded strings. For
        /// details see: https://kubernetes.io/docs/concepts/configuration/secret/ Example: { "example":
        /// "ZXhhbXBsZV92YWx1ZQ==", "another-example": "YW5vdGhlcl9leGFtcGxlX3ZhbHVl" }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, string> Data { get; set; }

        /// <summary>
        /// Identifier. The resource name of the Secret, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}/userWorkloadsSecrets/{userWorkloadsSecretId}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration settings for the Airflow web server App Engine instance. Supported for Cloud Composer
    /// environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public class WebServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
        /// composer-n1-webserver-4 or composer-n1-webserver-8. If not specified, composer-n1-webserver-2 will be used.
        /// Value custom is returned only in response, if Airflow web server parameters were manually changed to a
        /// non-standard values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network-level access control policy for the Airflow web server.</summary>
    public class WebServerNetworkAccessControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of allowed IP ranges with descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIpRanges")]
        public virtual System.Collections.Generic.IList<AllowedIpRange> AllowedIpRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    public class WebServerResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. CPU request and limit for Airflow web server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<float> Cpu { get; set; }

        /// <summary>Optional. Memory (GB) request and limit for Airflow web server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<float> MemoryGb { get; set; }

        /// <summary>Optional. Storage (GB) request and limit for Airflow web server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageGb")]
        public virtual System.Nullable<float> StorageGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    public class WorkerResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. CPU request and limit for a single Airflow worker replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<float> Cpu { get; set; }

        /// <summary>Optional. Maximum number of workers for autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCount")]
        public virtual System.Nullable<int> MaxCount { get; set; }

        /// <summary>Optional. Memory (GB) request and limit for a single Airflow worker replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<float> MemoryGb { get; set; }

        /// <summary>Optional. Minimum number of workers for autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCount")]
        public virtual System.Nullable<int> MinCount { get; set; }

        /// <summary>Optional. Storage (GB) request and limit for a single Airflow worker replica.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageGb")]
        public virtual System.Nullable<float> StorageGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Kubernetes workloads configuration for GKE cluster associated with the Cloud Composer environment. Supported
    /// for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    public class WorkloadsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Resources used by Airflow DAG processors. This field is supported for Cloud Composer environments
        /// in versions composer-3-airflow-*.*.*-build.* and newer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dagProcessor")]
        public virtual DagProcessorResource DagProcessor { get; set; }

        /// <summary>Optional. Resources used by Airflow schedulers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduler")]
        public virtual SchedulerResource Scheduler { get; set; }

        /// <summary>Optional. Resources used by Airflow triggerers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerer")]
        public virtual TriggererResource Triggerer { get; set; }

        /// <summary>Optional. Resources used by Airflow web server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServer")]
        public virtual WebServerResource WebServer { get; set; }

        /// <summary>Optional. Resources used by Airflow workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("worker")]
        public virtual WorkerResource Worker { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
