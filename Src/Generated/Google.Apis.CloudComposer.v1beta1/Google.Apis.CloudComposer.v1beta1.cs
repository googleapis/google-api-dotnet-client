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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "composer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://composer.googleapis.com/";
        #else
            "https://composer.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://composer.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Composer API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Composer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
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
                    return new CheckUpgradeRequest(service, body, environment);
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
                    return new CreateRequest(service, body, parent);
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

                /// <summary>Delete an environment.</summary>
                /// <param name="name">
                /// The environment to delete, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
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

                /// <summary>Get an existing environment.</summary>
                /// <param name="name">
                /// The resource name of the environment to get, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
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
                    return new ListRequest(service, parent);
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

                /// <summary>Update an environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the environment to update, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudComposer.v1beta1.Data.Environment body, string name)
                {
                    return new PatchRequest(service, body, name);
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
                    /// greater than or equal to 3 must be provided in the `config.nodeCount` field. *
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
                    /// cleared. It is an error to provide both this mask and a mask specifying one or more individual
                    /// environment variables. * `config.softwareConfig.imageVersion` * Upgrade the version of the
                    /// environment in-place. Refer to `SoftwareConfig.image_version` for information on how to format
                    /// the new image version. Additionally, the new image version cannot effect a version downgrade and
                    /// must match the current image version's Composer major version and Airflow major and minor
                    /// versions. Consult the [Cloud Composer Version
                    /// List](https://cloud.google.com/composer/docs/concepts/versioning/composer-versions) for valid
                    /// values. * `config.softwareConfig.schedulerCount` * Horizontally scale the number of schedulers
                    /// in Airflow. A positive integer not greater than the number of nodes must be provided in the
                    /// `config.softwareConfig.schedulerCount` field. * `config.databaseConfig.machineType` * Cloud SQL
                    /// machine type used by Airflow database. It has to be one of: db-n1-standard-2, db-n1-standard-4,
                    /// db-n1-standard-8 or db-n1-standard-16. * `config.webServerConfig.machineType` * Machine type on
                    /// which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
                    /// composer-n1-webserver-4 or composer-n1-webserver-8. * `config.maintenanceWindow` * Maintenance
                    /// window during which Cloud Composer components may be under maintenance.
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

                /// <summary>Restart Airflow web server.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the environment to restart the web server for, in the form:
                /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
                /// </param>
                public virtual RestartWebServerRequest RestartWebServer(Google.Apis.CloudComposer.v1beta1.Data.RestartWebServerRequest body, string name)
                {
                    return new RestartWebServerRequest(service, body, name);
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
                    return new ListRequest(service, parent);
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
                    return new DeleteRequest(service, name);
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
                    return new GetRequest(service, name);
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
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
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
        /// `composer-([0-9]+\.[0-9]+\.[0-9]+|latest)-airflow-[0-9]+\.[0-9]+(\.[0-9]+.*)?`. When used as input, the
        /// server also checks if the provided version is supported and denies the request for an unsupported version.
        /// The Cloud Composer portion of the version is a [semantic version](https://semver.org) or `latest`. When the
        /// patch version is omitted, the current Cloud Composer patch version is selected. When `latest` is provided
        /// instead of an explicit version number, the server replaces `latest` with the current Cloud Composer version
        /// and stores that version number in the same field. The portion of the image version that follows `airflow-`
        /// is an official Apache Airflow repository [release
        /// name](https://github.com/apache/incubator-airflow/releases). See also [Version List]
        /// (/composer/docs/concepts/versioning/composer-versions).
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

    /// <summary>The configuration of Cloud SQL instance that is used by the Apache Airflow software.</summary>
    public class DatabaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cloud SQL machine type used by Airflow database. It has to be one of: db-n1-standard-2,
        /// db-n1-standard-4, db-n1-standard-8 or db-n1-standard-16. If not specified, db-n1-standard-2 will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The encryption options for the Cloud Composer environment and its dependencies.</summary>
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
        /// <summary>Configuration parameters for this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual EnvironmentConfig Config { get; set; }

        /// <summary>Output only. The time at which this environment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. User-defined labels for this environment. The labels map can contain no more than 64 entries.
        /// Entries of the labels map are UTF8 strings that comply with the following restrictions: * Keys must conform
        /// to regexp: \p{Ll}\p{Lo}{0,62} * Values must conform to regexp: [\p{Ll}\p{Lo}\p{N}_-]{0,63} * Both keys and
        /// values are additionally constrained to be &amp;lt;= 128 bytes in size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name of the environment, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}" EnvironmentId must start with a
        /// lowercase letter followed by up to 63 lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The current state of the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time at which this environment was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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
        /// may be split into multiple chunks, each with a size of at least 4 hours. If this value is omitted, Cloud
        /// Composer components may be subject to maintenance at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>The configuration used for the Kubernetes Engine cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual NodeConfig NodeConfig { get; set; }

        /// <summary>
        /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>The configuration used for the Private IP Cloud Composer environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEnvironmentConfig")]
        public virtual PrivateEnvironmentConfig PrivateEnvironmentConfig { get; set; }

        /// <summary>The configuration settings for software inside the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareConfig")]
        public virtual SoftwareConfig SoftwareConfig { get; set; }

        /// <summary>Optional. The configuration settings for the Airflow web server App Engine instance.</summary>
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

    /// <summary>Configuration for controlling how IPs are allocated in the GKE cluster.</summary>
    public class IPAllocationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The IP address range used to allocate IP addresses to pods in the cluster. This field is
        /// applicable only when `use_ip_aliases` is true. Set to blank to have GKE choose a range with the default
        /// size. Set to /netmask (e.g. `/14`) to have GKE choose a range with a specific netmask. Set to a
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`) from the
        /// RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range to
        /// use. Specify `cluster_secondary_range_name` or `cluster_ipv4_cidr_block` but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIpv4CidrBlock")]
        public virtual string ClusterIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. The name of the cluster's secondary range used to allocate IP addresses to pods. Specify either
        /// `cluster_secondary_range_name` or `cluster_ipv4_cidr_block` but not both. This field is applicable only when
        /// `use_ip_aliases` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterSecondaryRangeName")]
        public virtual string ClusterSecondaryRangeName { get; set; }

        /// <summary>
        /// Optional. The IP address range of the services IP addresses in this cluster. This field is applicable only
        /// when `use_ip_aliases` is true. Set to blank to have GKE choose a range with the default size. Set to
        /// /netmask (e.g. `/14`) to have GKE choose a range with a specific netmask. Set to a
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`) from the
        /// RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range to
        /// use. Specify `services_secondary_range_name` or `services_ipv4_cidr_block` but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesIpv4CidrBlock")]
        public virtual string ServicesIpv4CidrBlock { get; set; }

        /// <summary>
        /// Optional. The name of the services' secondary range used to allocate IP addresses to the cluster. Specify
        /// either `services_secondary_range_name` or `services_ipv4_cidr_block` but not both. This field is applicable
        /// only when `use_ip_aliases` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesSecondaryRangeName")]
        public virtual string ServicesSecondaryRangeName { get; set; }

        /// <summary>
        /// Optional. Whether or not to enable Alias IPs in the GKE cluster. If `true`, a VPC-native cluster is created.
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

        /// <summary>The string identifier of the ImageVersion, in the form: "composer-x.y.z-airflow-a.b(.c)"</summary>
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

    /// <summary>
    /// The configuration settings for Cloud Composer maintenance window. The following example: {
    /// "startTime":"2019-08-01T01:00:00Z" "endTime":"2019-08-01T07:00:00Z" "recurrence":"FREQ=WEEKLY;BYDAY=TU,WE" }
    /// would define a maintenance window between 01 and 07 hours UTC during each Tuesday and Wednesday.
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Maintenance window end time. It is used only to calculate the duration of the maintenance window.
        /// The value for end_time must be in the future, relative to `start_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Required. Maintenance window recurrence. Format is a subset of
        /// [RFC-5545](https://tools.ietf.org/html/rfc5545) `RRULE`. The only allowed values for `FREQ` field are
        /// `FREQ=DAILY` and `FREQ=WEEKLY;BYDAY=...` Example values: `FREQ=WEEKLY;BYDAY=TU,WE`, `FREQ=DAILY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrence")]
        public virtual string Recurrence { get; set; }

        /// <summary>Required. Start time of the first recurrence of the maintenance window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration information for the Kubernetes Engine nodes running the Apache Airflow software.
    /// </summary>
    public class NodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The disk size in GB used for node VMs. Minimum size is 20GB. If unspecified, defaults to 100GB.
        /// Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

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
        /// field will be propagated to the unspecified field.
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
        /// the `machineTypeId` defaults to "n1-standard-1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The maximum number of pods per node in the Cloud Composer GKE cluster. The value must be between 8
        /// and 110 and it can be set only if the environment is VPC-native. The default value is 32. Values of this
        /// field will be propagated both to the `default-pool` node pool of the newly created GKE cluster, and to the
        /// default "Maximum Pods per Node" value which is used for newly created node pools if their value is not
        /// explicitly set during node pool creation. For more information, see [Optimizing IP address allocation]
        /// (https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr). Cannot be updated.
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
        /// defaults to ["https://www.googleapis.com/auth/cloud-platform"]. Cannot be updated.
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

    /// <summary>Metadata describing an operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time the operation was submitted to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The time when the operation terminated, regardless of its success. This field is unset if the
        /// operation is still ongoing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

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
        /// Optional. If `true`, a Private IP Cloud Composer environment is created. If this field is set to true,
        /// `IPAllocationPolicy.use_ip_aliases` must be set to true .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateEnvironment")]
        public virtual System.Nullable<bool> EnablePrivateEnvironment { get; set; }

        /// <summary>
        /// Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateClusterConfig")]
        public virtual PrivateClusterConfig PrivateClusterConfig { get; set; }

        /// <summary>
        /// Optional. The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from
        /// private_cluster_config.master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerIpv4CidrBlock")]
        public virtual string WebServerIpv4CidrBlock { get; set; }

        /// <summary>Output only. The IP range reserved for the tenant project's App Engine VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webServerIpv4ReservedRange")]
        public virtual string WebServerIpv4ReservedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Restart Airflow web server.</summary>
    public class RestartWebServerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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
        /// The version of the software running in the environment. This encapsulates both the version of Cloud Composer
        /// functionality and the version of Apache Airflow. It must match the regular expression
        /// `composer-([0-9]+\.[0-9]+\.[0-9]+|latest)-airflow-[0-9]+\.[0-9]+(\.[0-9]+.*)?`. When used as input, the
        /// server also checks if the provided version is supported and denies the request for an unsupported version.
        /// The Cloud Composer portion of the version is a [semantic version](https://semver.org) or `latest`. When the
        /// patch version is omitted, the current Cloud Composer patch version is selected. When `latest` is provided
        /// instead of an explicit version number, the server replaces `latest` with the current Cloud Composer version
        /// and stores that version number in the same field. The portion of the image version that follows *airflow-*
        /// is an official Apache Airflow repository [release
        /// name](https://github.com/apache/incubator-airflow/releases). See also [Version
        /// List](/composer/docs/concepts/versioning/composer-versions).
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
        /// processes. Can be set to '2' or '3'. If not specified, the default is '3'. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonVersion")]
        public virtual string PythonVersion { get; set; }

        /// <summary>Optional. The number of schedulers for Airflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedulerCount")]
        public virtual System.Nullable<int> SchedulerCount { get; set; }

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

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
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
        /// <summary>Optional. Resources used by Airflow schedulers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduler")]
        public virtual SchedulerResource Scheduler { get; set; }

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
