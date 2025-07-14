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

namespace Google.Apis.ArtifactRegistry.v1
{
    /// <summary>The ArtifactRegistry Service.</summary>
    public class ArtifactRegistryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ArtifactRegistryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ArtifactRegistryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://artifactregistry.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://artifactregistry.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "artifactregistry";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Artifact Registry API.</summary>
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
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Artifact Registry API.</summary>
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
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for ArtifactRegistry requests.</summary>
    public abstract class ArtifactRegistryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ArtifactRegistryBaseServiceRequest instance.</summary>
        protected ArtifactRegistryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ArtifactRegistry parameter list.</summary>
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
                Operations = new OperationsResource(service);
                Repositories = new RepositoriesResource(service);
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
                public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
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
            }

            /// <summary>Gets the Repositories resource.</summary>
            public virtual RepositoriesResource Repositories { get; }

            /// <summary>The "repositories" collection of methods.</summary>
            public class RepositoriesResource
            {
                private const string Resource = "repositories";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RepositoriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AptArtifacts = new AptArtifactsResource(service);
                    Attachments = new AttachmentsResource(service);
                    DockerImages = new DockerImagesResource(service);
                    Files = new FilesResource(service);
                    GenericArtifacts = new GenericArtifactsResource(service);
                    GoModules = new GoModulesResource(service);
                    GoogetArtifacts = new GoogetArtifactsResource(service);
                    KfpArtifacts = new KfpArtifactsResource(service);
                    MavenArtifacts = new MavenArtifactsResource(service);
                    NpmPackages = new NpmPackagesResource(service);
                    Packages = new PackagesResource(service);
                    PythonPackages = new PythonPackagesResource(service);
                    Rules = new RulesResource(service);
                    YumArtifacts = new YumArtifactsResource(service);
                }

                /// <summary>Gets the AptArtifacts resource.</summary>
                public virtual AptArtifactsResource AptArtifacts { get; }

                /// <summary>The "aptArtifacts" collection of methods.</summary>
                public class AptArtifactsResource
                {
                    private const string Resource = "aptArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AptArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Imports Apt artifacts. The returned Operation will complete once the resources are imported.
                    /// Package, Version, and File resources are created based on the imported artifacts. Imported
                    /// artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be imported.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.ArtifactRegistry.v1.Data.ImportAptArtifactsRequest body, string parent)
                    {
                        return new ImportRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Imports Apt artifacts. The returned Operation will complete once the resources are imported.
                    /// Package, Version, and File resources are created based on the imported artifacts. Imported
                    /// artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class ImportRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.ImportAptArtifactsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be imported.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.ImportAptArtifactsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/aptArtifacts:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads an Apt artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads an Apt artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/aptArtifacts:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads an Apt artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadAptArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/aptArtifacts:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the Attachments resource.</summary>
                public virtual AttachmentsResource Attachments { get; }

                /// <summary>The "attachments" collection of methods.</summary>
                public class AttachmentsResource
                {
                    private const string Resource = "attachments";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AttachmentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates an attachment. The returned Operation will finish once the attachment has been created.
                    /// Its response will be the created attachment.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the parent resource where the attachment will be created.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ArtifactRegistry.v1.Data.Attachment body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates an attachment. The returned Operation will finish once the attachment has been created.
                    /// Its response will be the created attachment.
                    /// </summary>
                    public class CreateRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Attachment body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource where the attachment will be created.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The attachment id to use for this attachment.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("attachmentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AttachmentId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.Attachment Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/attachments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                            RequestParameters.Add("attachmentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "attachmentId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes an attachment. The returned Operation will finish once the attachments has been deleted.
                    /// It will not have any Operation metadata and will return a `google.protobuf.Empty` response.
                    /// </summary>
                    /// <param name="name">Required. The name of the attachment to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes an attachment. The returned Operation will finish once the attachments has been deleted.
                    /// It will not have any Operation metadata and will return a `google.protobuf.Empty` response.
                    /// </summary>
                    public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the attachment to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/attachments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets an attachment.</summary>
                    /// <param name="name">Required. The name of the attachment to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets an attachment.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Attachment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the attachment to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/attachments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists attachments.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose attachments will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists attachments.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListAttachmentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource whose attachments will be listed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression for filtering the results of the request. Filter rules are case
                        /// insensitive. The fields eligible for filtering are: * `target` * `type` *
                        /// `attachment_namespace`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The maximum number of attachments to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/attachments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Gets the DockerImages resource.</summary>
                public virtual DockerImagesResource DockerImages { get; }

                /// <summary>The "dockerImages" collection of methods.</summary>
                public class DockerImagesResource
                {
                    private const string Resource = "dockerImages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DockerImagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a docker image.</summary>
                    /// <param name="name">Required. The name of the docker images.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a docker image.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.DockerImage>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the docker images.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/dockerImages/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists docker images.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose docker images will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists docker images.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListDockerImagesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource whose docker images will be listed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The field to order the results by.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The maximum number of artifacts to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dockerImages";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Gets the Files resource.</summary>
                public virtual FilesResource Files { get; }

                /// <summary>The "files" collection of methods.</summary>
                public class FilesResource
                {
                    private const string Resource = "files";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FilesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Deletes a file and all of its content. It is only allowed on generic repositories. The returned
                    /// operation will complete once the file has been deleted.
                    /// </summary>
                    /// <param name="name">Required. The name of the file to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a file and all of its content. It is only allowed on generic repositories. The returned
                    /// operation will complete once the file has been deleted.
                    /// </summary>
                    public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the file to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/files/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Download a file.</summary>
                    /// <param name="name">Required. The name of the file to download.</param>
                    public virtual DownloadRequest Download(string name)
                    {
                        return new DownloadRequest(this.service, name);
                    }

                    /// <summary>Download a file.</summary>
                    public class DownloadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.DownloadFileResponse>
                    {
                        /// <summary>Constructs a new Download request.</summary>
                        public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                            InitParameters();
                        }

                        /// <summary>Required. The name of the file to download.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "download";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:download";

                        /// <summary>Initializes Download parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/files/[^/]+$",
                            });
                        }

                        /// <summary>Gets the media downloader.</summary>
                        public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

                        /// <summary>
                        /// <para>Synchronously download the media into the given stream.</para>
                        /// <para>
                        /// Warning: This method hides download errors; use
                        /// <see cref="DownloadWithStatus(System.IO.Stream)"/> instead.
                        /// </para>
                        /// </summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        public virtual void Download(System.IO.Stream stream)
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = null;
                            mediaDownloader.Download(this.GenerateRequestUri(), stream);
                        }

                        /// <summary>Synchronously download the media into the given stream.</summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        /// <returns>
                        /// The final status of the download; including whether the download succeeded or failed.
                        /// </returns>
                        public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = null;
                            return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                        }

                        /// <summary>Asynchronously download the media into the given stream.</summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = null;
                            return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
                        }

                        /// <summary>Asynchronously download the media into the given stream.</summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                            System.Threading.CancellationToken cancellationToken)
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = null;
                            return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                        }

                        /// <summary>Synchronously download a range of the media into the given stream.</summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = range;
                            return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                        }

                        /// <summary>Asynchronously download a range of the media into the given stream.</summary>
                        /// <remarks>
                        /// This method uses the <see cref="MediaDownloader"/> property to perform the download.
                        /// Progress event handlers and other configuration may be performed using that property prior
                        /// to calling this method.
                        /// </remarks>
                        public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                            System.Net.Http.Headers.RangeHeaderValue range,
                            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
                        {
                            var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                            mediaDownloader.Range = range;
                            return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                        }
                    }

                    /// <summary>Gets a file.</summary>
                    /// <param name="name">Required. The name of the file to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a file.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1File>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the file to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/files/.*$",
                            });
                        }
                    }

                    /// <summary>Lists files.</summary>
                    /// <param name="parent">
                    /// Required. The name of the repository whose files will be listed. For example:
                    /// "projects/p1/locations/us-central1/repositories/repo1
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists files.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListFilesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the repository whose files will be listed. For example:
                        /// "projects/p1/locations/us-central1/repositories/repo1
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// An expression for filtering the results of the request. Filter rules are case insensitive.
                        /// The fields eligible for filtering are: * `name` * `owner` * `annotations` Examples of using
                        /// a filter: To filter the results of your request to files with the name `my_file.txt` in
                        /// project `my-project` in the `us-central` region, in repository `my-repo`, append the
                        /// following filter expression to your request: *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/files/my-file.txt"`
                        /// You can also use wildcards to match any number of characters before or after the value: *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/files/my-*"` *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/files/*file.txt"` *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/files/*file*"` To
                        /// filter the results of your request to files owned by the version `1.0` in package `pkg1`,
                        /// append the following filter expression to your request: *
                        /// `owner="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/1.0"`
                        /// To filter the results of your request to files with the annotation key-value pair
                        /// [`external_link`: `external_link_value`], append the following filter expression to your
                        /// request: * `"annotations.external_link:external_link_value"` To filter just for a specific
                        /// annotation key `external_link`, append the following filter expression to your request: *
                        /// `"annotations.external_link"` If the annotation key or value contains special characters,
                        /// you can escape them by surrounding the value with backticks. For example, to filter the
                        /// results of your request to files with the annotation key-value pair
                        /// [`external.link`:`https://example.com/my-file`], append the following filter expression to
                        /// your request: * `` "annotations.`external.link`:`https://example.com/my-file`" `` You can
                        /// also filter with annotations with a wildcard to match any number of characters before or
                        /// after the value: * `` "annotations.*_link:`*example.com*`" ``
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The field to order the results by.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The maximum number of files to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/files";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Updates a file.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the file, for example:
                    /// `projects/p1/locations/us-central1/repositories/repo1/files/a%2Fb%2Fc.txt`. If the file ID part
                    /// contains slashes, they are escaped.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1File body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a file.</summary>
                    public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1File>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1File body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the file, for example:
                        /// `projects/p1/locations/us-central1/repositories/repo1/files/a%2Fb%2Fc.txt`. If the file ID
                        /// part contains slashes, they are escaped.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1File Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/files/[^/]+$",
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
                    /// Directly uploads a file to a repository. The returned Operation will complete once the resources
                    /// are uploaded.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the repository where the file will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a file to a repository. The returned Operation will complete once the resources
                    /// are uploaded.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadFileMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the repository where the file will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/files:upload";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a file to a repository. The returned Operation will complete once the resources
                    /// are uploaded.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the repository where the file will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadFileMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>
                        /// Required. The resource name of the repository where the file will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadFileRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/files:upload"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the GenericArtifacts resource.</summary>
                public virtual GenericArtifactsResource GenericArtifacts { get; }

                /// <summary>The "genericArtifacts" collection of methods.</summary>
                public class GenericArtifactsResource
                {
                    private const string Resource = "genericArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GenericArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Directly uploads a Generic artifact. The returned operation will complete once the resources are
                    /// uploaded. Package, version, and file resources are created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will raise an `ALREADY_EXISTS` error.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the generic artifact will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a Generic artifact. The returned operation will complete once the resources are
                    /// uploaded. Package, version, and file resources are created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will raise an `ALREADY_EXISTS` error.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name of the repository where the generic artifact will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/genericArtifacts:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a Generic artifact. The returned operation will complete once the resources are
                    /// uploaded. Package, version, and file resources are created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will raise an `ALREADY_EXISTS` error.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the generic artifact will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>
                        /// The resource name of the repository where the generic artifact will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGenericArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/genericArtifacts:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the GoModules resource.</summary>
                public virtual GoModulesResource GoModules { get; }

                /// <summary>The "goModules" collection of methods.</summary>
                public class GoModulesResource
                {
                    private const string Resource = "goModules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GoModulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Directly uploads a Go module. The returned Operation will complete once the Go module is
                    /// uploaded. Package, Version, and File resources are created based on the uploaded Go module.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the Go module will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a Go module. The returned Operation will complete once the Go module is
                    /// uploaded. Package, Version, and File resources are created based on the uploaded Go module.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The resource name of the repository where the Go module will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/goModules:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a Go module. The returned Operation will complete once the Go module is
                    /// uploaded. Package, Version, and File resources are created based on the uploaded Go module.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the Go module will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>The resource name of the repository where the Go module will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGoModuleRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/goModules:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the GoogetArtifacts resource.</summary>
                public virtual GoogetArtifactsResource GoogetArtifacts { get; }

                /// <summary>The "googetArtifacts" collection of methods.</summary>
                public class GoogetArtifactsResource
                {
                    private const string Resource = "googetArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GoogetArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Imports GooGet artifacts. The returned Operation will complete once the resources are imported.
                    /// Package, Version, and File resources are created based on the imported artifacts. Imported
                    /// artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be imported.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.ArtifactRegistry.v1.Data.ImportGoogetArtifactsRequest body, string parent)
                    {
                        return new ImportRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Imports GooGet artifacts. The returned Operation will complete once the resources are imported.
                    /// Package, Version, and File resources are created based on the imported artifacts. Imported
                    /// artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class ImportRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.ImportGoogetArtifactsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be imported.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.ImportGoogetArtifactsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/googetArtifacts:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a GooGet artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a GooGet artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/googetArtifacts:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a GooGet artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadGoogetArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/googetArtifacts:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the KfpArtifacts resource.</summary>
                public virtual KfpArtifactsResource KfpArtifacts { get; }

                /// <summary>The "kfpArtifacts" collection of methods.</summary>
                public class KfpArtifactsResource
                {
                    private const string Resource = "kfpArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public KfpArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Directly uploads a KFP artifact. The returned Operation will complete once the resource is
                    /// uploaded. Package, Version, and File resources will be created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will be overwritten.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the KFP artifact will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a KFP artifact. The returned Operation will complete once the resource is
                    /// uploaded. Package, Version, and File resources will be created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will be overwritten.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource name of the repository where the KFP artifact will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/kfpArtifacts:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a KFP artifact. The returned Operation will complete once the resource is
                    /// uploaded. Package, Version, and File resources will be created based on the uploaded artifact.
                    /// Uploaded artifacts that conflict with existing resources will be overwritten.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The resource name of the repository where the KFP artifact will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>
                        /// The resource name of the repository where the KFP artifact will be uploaded.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadKfpArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/kfpArtifacts:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>Gets the MavenArtifacts resource.</summary>
                public virtual MavenArtifactsResource MavenArtifacts { get; }

                /// <summary>The "mavenArtifacts" collection of methods.</summary>
                public class MavenArtifactsResource
                {
                    private const string Resource = "mavenArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MavenArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a maven artifact.</summary>
                    /// <param name="name">Required. The name of the maven artifact.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a maven artifact.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.MavenArtifact>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the maven artifact.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/mavenArtifacts/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists maven artifacts.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose maven artifacts will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists maven artifacts.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListMavenArtifactsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource whose maven artifacts will be listed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of artifacts to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/mavenArtifacts";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Gets the NpmPackages resource.</summary>
                public virtual NpmPackagesResource NpmPackages { get; }

                /// <summary>The "npmPackages" collection of methods.</summary>
                public class NpmPackagesResource
                {
                    private const string Resource = "npmPackages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NpmPackagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a npm package.</summary>
                    /// <param name="name">Required. The name of the npm package.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a npm package.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.NpmPackage>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the npm package.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/npmPackages/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists npm packages.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose npm packages will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists npm packages.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListNpmPackagesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource whose npm packages will be listed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of artifacts to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/npmPackages";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Gets the Packages resource.</summary>
                public virtual PackagesResource Packages { get; }

                /// <summary>The "packages" collection of methods.</summary>
                public class PackagesResource
                {
                    private const string Resource = "packages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PackagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Tags = new TagsResource(service);
                        Versions = new VersionsResource(service);
                    }

                    /// <summary>Gets the Tags resource.</summary>
                    public virtual TagsResource Tags { get; }

                    /// <summary>The "tags" collection of methods.</summary>
                    public class TagsResource
                    {
                        private const string Resource = "tags";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TagsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a tag.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">The name of the parent resource where the tag will be created.</param>
                        public virtual CreateRequest Create(Google.Apis.ArtifactRegistry.v1.Data.Tag body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>Creates a tag.</summary>
                        public class CreateRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Tag>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Tag body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the parent resource where the tag will be created.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The tag id to use for this repository.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("tagId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string TagId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ArtifactRegistry.v1.Data.Tag Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tags";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
                                });
                                RequestParameters.Add("tagId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "tagId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes a tag.</summary>
                        /// <param name="name">The name of the tag to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>Deletes a tag.</summary>
                        public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the tag to delete.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/tags/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets a tag.</summary>
                        /// <param name="name">The name of the tag to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets a tag.</summary>
                        public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Tag>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the tag to retrieve.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/tags/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists tags.</summary>
                        /// <param name="parent">
                        /// The name of the parent package whose tags will be listed. For example:
                        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists tags.</summary>
                        public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListTagsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the parent package whose tags will be listed. For example:
                            /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// An expression for filtering the results of the request. Filter rules are case
                            /// insensitive. The fields eligible for filtering are: * `name` * `version` Examples of
                            /// using a filter: To filter the results of your request to tags with the name `my-tag` in
                            /// package `my-package` in repository `my-repo` in project "`y-project` in the us-central
                            /// region, append the following filter expression to your request: *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/tags/my-tag"`
                            /// You can also use wildcards to match any number of characters before or after the value:
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/tags/my*"`
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/tags/*tag"`
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/tags/*tag*"`
                            /// To filter the results of your request to tags applied to the version `1.0` in package
                            /// `my-package`, append the following filter expression to your request: *
                            /// `version="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/1.0"`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>The maximum number of tags to return. Maximum page size is 1,000.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The next_page_token value returned from a previous list request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tags";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
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

                        /// <summary>Updates a tag.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// The name of the tag, for example:
                        /// "projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/tags/tag1". If the
                        /// package part contains slashes, the slashes are escaped. The tag part can only have
                        /// characters in [a-zA-Z0-9\-._~:@], anything else must be URL encoded.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.Tag body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates a tag.</summary>
                        public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Tag>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Tag body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the tag, for example:
                            /// "projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/tags/tag1". If the
                            /// package part contains slashes, the slashes are escaped. The tag part can only have
                            /// characters in [a-zA-Z0-9\-._~:@], anything else must be URL encoded.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The update mask applies to the resource. For the `FieldMask` definition, see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ArtifactRegistry.v1.Data.Tag Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/tags/[^/]+$",
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

                    /// <summary>Gets the Versions resource.</summary>
                    public virtual VersionsResource Versions { get; }

                    /// <summary>The "versions" collection of methods.</summary>
                    public class VersionsResource
                    {
                        private const string Resource = "versions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Deletes multiple versions across a repository. The returned operation will complete once the
                        /// versions have been deleted.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">The name of the repository holding all requested versions.</param>
                        public virtual BatchDeleteRequest BatchDelete(Google.Apis.ArtifactRegistry.v1.Data.BatchDeleteVersionsRequest body, string parent)
                        {
                            return new BatchDeleteRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Deletes multiple versions across a repository. The returned operation will complete once the
                        /// versions have been deleted.
                        /// </summary>
                        public class BatchDeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new BatchDelete request.</summary>
                            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.BatchDeleteVersionsRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the repository holding all requested versions.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ArtifactRegistry.v1.Data.BatchDeleteVersionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "batchDelete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/versions:batchDelete";

                            /// <summary>Initializes BatchDelete parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes a version and all of its content. The returned operation will complete once the
                        /// version has been deleted.
                        /// </summary>
                        /// <param name="name">The name of the version to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Deletes a version and all of its content. The returned operation will complete once the
                        /// version has been deleted.
                        /// </summary>
                        public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the version to delete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// By default, a version that is tagged may not be deleted. If force=true, the version and
                            /// any tags pointing to the version are deleted.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> Force { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "force",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Gets a version</summary>
                        /// <param name="name">The name of the version to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets a version</summary>
                        public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Version>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the version to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The view that should be returned in the response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>The view that should be returned in the response.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>
                                /// The default / unset value. The API will default to the BASIC view.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("VERSION_VIEW_UNSPECIFIED")]
                                VERSIONVIEWUNSPECIFIED = 0,

                                /// <summary>
                                /// Includes basic information about the version, but not any related tags.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 1,

                                /// <summary>Include everything.</summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 2,
                            }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Lists versions.</summary>
                        /// <param name="parent">The name of the parent resource whose versions will be listed.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists versions.</summary>
                        public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>The name of the parent resource whose versions will be listed.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. An expression for filtering the results of the request. Filter rules are case
                            /// insensitive. The fields eligible for filtering are: * `name` * `annotations` Examples of
                            /// using a filter: To filter the results of your request to versions with the name
                            /// `my-version` in project `my-project` in the `us-central` region, in repository
                            /// `my-repo`, append the following filter expression to your request: *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/my-version"`
                            /// You can also use wildcards to match any number of characters before or after the value:
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/*version"`
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/my*"`
                            /// *
                            /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package/versions/*version*"`
                            /// To filter the results of your request to versions with the annotation key-value pair
                            /// [`external_link`: `external_link_value`], append the following filter expression to your
                            /// request: * `"annotations.external_link:external_link_value"` To filter just for a
                            /// specific annotation key `external_link`, append the following filter expression to your
                            /// request: * `"annotations.external_link"` If the annotation key or value contains special
                            /// characters, you can escape them by surrounding the value with backticks. For example, to
                            /// filter the results of your request to versions with the annotation key-value pair
                            /// [`external.link`:`https://example.com/my-version`], append the following filter
                            /// expression to your request: * ``
                            /// "annotations.`external.link`:`https://example.com/my-version`" `` You can also filter
                            /// with annotations with a wildcard to match any number of characters before or after the
                            /// value: * `` "annotations.*_link:`*example.com*`" ``
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. The field to order the results by.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>The maximum number of versions to return. Maximum page size is 1,000.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The next_page_token value returned from a previous list request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>The view that should be returned in the response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>The view that should be returned in the response.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>
                                /// The default / unset value. The API will default to the BASIC view.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("VERSION_VIEW_UNSPECIFIED")]
                                VERSIONVIEWUNSPECIFIED = 0,

                                /// <summary>
                                /// Includes basic information about the version, but not any related tags.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 1,

                                /// <summary>Include everything.</summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 2,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/versions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
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
                                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "view",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Updates a version.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// The name of the version, for example:
                        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/versions/art1`. If the
                        /// package or version ID parts contain slashes, the slashes are escaped.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.Version body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates a version.</summary>
                        public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Version>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Version body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the version, for example:
                            /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/versions/art1`. If
                            /// the package or version ID parts contain slashes, the slashes are escaped.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The update mask applies to the resource. For the `FieldMask` definition, see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.ArtifactRegistry.v1.Data.Version Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+/versions/[^/]+$",
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

                    /// <summary>
                    /// Deletes a package and all of its versions and tags. The returned operation will complete once
                    /// the package has been deleted.
                    /// </summary>
                    /// <param name="name">Required. The name of the package to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a package and all of its versions and tags. The returned operation will complete once
                    /// the package has been deleted.
                    /// </summary>
                    public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the package to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a package.</summary>
                    /// <param name="name">Required. The name of the package to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a package.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Package>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the package to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists packages.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose packages will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists packages.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListPackagesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the parent resource whose packages will be listed.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression for filtering the results of the request. Filter rules are case
                        /// insensitive. The fields eligible for filtering are: * `name` * `annotations` Examples of
                        /// using a filter: To filter the results of your request to packages with the name `my-package`
                        /// in project `my-project` in the `us-central` region, in repository `my-repo`, append the
                        /// following filter expression to your request: *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-package"`
                        /// You can also use wildcards to match any number of characters before or after the value: *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/my-*"` *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/*package"` *
                        /// `name="projects/my-project/locations/us-central1/repositories/my-repo/packages/*pack*"` To
                        /// filter the results of your request to packages with the annotation key-value pair
                        /// [`external_link`: `external_link_value`], append the following filter expression to your
                        /// request": * `"annotations.external_link:external_link_value"` To filter the results just for
                        /// a specific annotation key `external_link`, append the following filter expression to your
                        /// request: * `"annotations.external_link"` If the annotation key or value contains special
                        /// characters, you can escape them by surrounding the value with backticks. For example, to
                        /// filter the results of your request to packages with the annotation key-value pair
                        /// [`external.link`:`https://example.com/my-package`], append the following filter expression
                        /// to your request: * `` "annotations.`external.link`:`https://example.com/my-package`" `` You
                        /// can also filter with annotations with a wildcard to match any number of characters before or
                        /// after the value: * `` "annotations.*_link:`*example.com*`" ``
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. The field to order the results by.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The maximum number of packages to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/packages";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Updates a package.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the package, for example:
                    /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`. If the package ID part
                    /// contains slashes, the slashes are escaped.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.Package body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a package.</summary>
                    public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Package>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Package body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the package, for example:
                        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`. If the package ID part
                        /// contains slashes, the slashes are escaped.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.Package Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/packages/[^/]+$",
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

                /// <summary>Gets the PythonPackages resource.</summary>
                public virtual PythonPackagesResource PythonPackages { get; }

                /// <summary>The "pythonPackages" collection of methods.</summary>
                public class PythonPackagesResource
                {
                    private const string Resource = "pythonPackages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public PythonPackagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets a python package.</summary>
                    /// <param name="name">Required. The name of the python package.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a python package.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.PythonPackage>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the python package.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/pythonPackages/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists python packages.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent resource whose python packages will be listed.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists python packages.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListPythonPackagesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent resource whose python packages will be listed.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of artifacts to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/pythonPackages";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Gets the Rules resource.</summary>
                public virtual RulesResource Rules { get; }

                /// <summary>The "rules" collection of methods.</summary>
                public class RulesResource
                {
                    private const string Resource = "rules";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RulesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a rule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the parent resource where the rule will be created.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a rule.</summary>
                    public class CreateRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the parent resource where the rule will be created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The rule id to use for this repository.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("ruleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RuleId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                            RequestParameters.Add("ruleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ruleId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a rule.</summary>
                    /// <param name="name">Required. The name of the rule to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a rule.</summary>
                    public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the rule to delete.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/rules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a rule.</summary>
                    /// <param name="name">Required. The name of the rule to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets a rule.</summary>
                    public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the rule to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/rules/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists rules.</summary>
                    /// <param name="parent">
                    /// Required. The name of the parent repository whose rules will be listed. For example:
                    /// `projects/p1/locations/us-central1/repositories/repo1`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists rules.</summary>
                    public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListRulesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the parent repository whose rules will be listed. For example:
                        /// `projects/p1/locations/us-central1/repositories/repo1`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of rules to return. Maximum page size is 1,000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/rules";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                    /// <summary>Updates a rule.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the rule, for example:
                    /// `projects/p1/locations/us-central1/repositories/repo1/rules/rule1`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates a rule.</summary>
                    public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the rule, for example:
                        /// `projects/p1/locations/us-central1/repositories/repo1/rules/rule1`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.GoogleDevtoolsArtifactregistryV1Rule Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+/rules/[^/]+$",
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

                /// <summary>Gets the YumArtifacts resource.</summary>
                public virtual YumArtifactsResource YumArtifacts { get; }

                /// <summary>The "yumArtifacts" collection of methods.</summary>
                public class YumArtifactsResource
                {
                    private const string Resource = "yumArtifacts";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public YumArtifactsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Imports Yum (RPM) artifacts. The returned Operation will complete once the resources are
                    /// imported. Package, Version, and File resources are created based on the imported artifacts.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be imported.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.ArtifactRegistry.v1.Data.ImportYumArtifactsRequest body, string parent)
                    {
                        return new ImportRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Imports Yum (RPM) artifacts. The returned Operation will complete once the resources are
                    /// imported. Package, Version, and File resources are created based on the imported artifacts.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class ImportRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.ImportYumArtifactsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be imported.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.ImportYumArtifactsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/yumArtifacts:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a Yum artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    public virtual UploadRequest Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest body, string parent)
                    {
                        return new UploadRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Directly uploads a Yum artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    public class UploadRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactMediaResponse>
                    {
                        /// <summary>Constructs a new Upload request.</summary>
                        public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "upload";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/yumArtifacts:create";

                        /// <summary>Initializes Upload parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Directly uploads a Yum artifact. The returned Operation will complete once the resources are
                    /// uploaded. Package, Version, and File resources are created based on the imported artifact.
                    /// Imported artifacts that conflict with existing resources are ignored.
                    /// </summary>
                    /// <remarks>
                    /// Considerations regarding <paramref name="stream"/>:
                    /// <list type="bullet">
                    /// <item>
                    /// <description>
                    /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                    /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                    /// from its current position
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>
                    /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                    /// completed
                    /// </description>
                    /// </item>
                    /// <item>
                    /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                    /// </item>
                    /// </list>
                    /// </remarks>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the parent resource where the artifacts will be uploaded.
                    /// </param>
                    /// <param name="stream">The stream to upload. See remarks for further information.</param>
                    /// <param name="contentType">The content type of the stream to upload.</param>
                    public virtual UploadMediaUpload Upload(Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                    {
                        return new UploadMediaUpload(service, body, parent, stream, contentType);
                    }

                    /// <summary>Upload media upload which supports resumable upload.</summary>
                    public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest, Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactMediaResponse>
                    {
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
                        /// API key. Your API key identifies your project and provides you with API access, quota, and
                        /// reports. Required unless you provide an OAuth 2.0 token.
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
                        /// Available to use for quota purposes for server-side applications. Can be any arbitrary
                        /// string assigned to a user, but should not exceed 40 characters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string QuotaUser { get; set; }

                        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadType { get; set; }

                        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string UploadProtocol { get; set; }

                        /// <summary>The name of the parent resource where the artifacts will be uploaded.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Constructs a new Upload media upload instance.</summary>
                        /// <remarks>
                        /// Considerations regarding <paramref name="stream"/>:
                        /// <list type="bullet">
                        /// <item>
                        /// <description>
                        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c>
                        /// before reading commences. If <paramref name="stream"/> is not seekable, then it will be read
                        /// from its current position
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>
                        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                        /// completed
                        /// </description>
                        /// </item>
                        /// <item>
                        /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                        /// </item>
                        /// </list>
                        /// </remarks>
                        public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.UploadYumArtifactRequest body, string parent, System.IO.Stream stream, string contentType)
                            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/yumArtifacts:create"), "POST", stream, contentType)
                        {
                            Parent = parent;
                            Body = body;
                        }
                    }
                }

                /// <summary>
                /// Creates a repository. The returned Operation will finish once the repository has been created. Its
                /// response will be the created Repository.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the parent resource where the repository will be created.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.ArtifactRegistry.v1.Data.Repository body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a repository. The returned Operation will finish once the repository has been created. Its
                /// response will be the created Repository.
                /// </summary>
                public class CreateRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Repository body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent resource where the repository will be created.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The repository id to use for this repository.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("repositoryId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RepositoryId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ArtifactRegistry.v1.Data.Repository Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/repositories";

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
                        RequestParameters.Add("repositoryId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "repositoryId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a repository and all of its contents. The returned Operation will finish once the repository
                /// has been deleted. It will not have any Operation metadata and will return a google.protobuf.Empty
                /// response.
                /// </summary>
                /// <param name="name">Required. The name of the repository to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a repository and all of its contents. The returned Operation will finish once the repository
                /// has been deleted. It will not have any Operation metadata and will return a google.protobuf.Empty
                /// response.
                /// </summary>
                public class DeleteRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the repository to delete.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a repository.</summary>
                /// <param name="name">Required. The name of the repository to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a repository.</summary>
                public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Repository>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the repository to retrieve.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the IAM policy for a given resource.</summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>Gets the IAM policy for a given resource.</summary>
                public class GetIamPolicyRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Lists repositories.</summary>
                /// <param name="parent">
                /// Required. The name of the parent resource whose repositories will be listed.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists repositories.</summary>
                public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListRepositoriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the parent resource whose repositories will be listed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Filter rules are case
                    /// insensitive. The fields eligible for filtering are: * `name` Examples of using a filter: To
                    /// filter the results of your request to repositories with the name `my-repo` in project
                    /// `my-project` in the `us-central` region, append the following filter expression to your request:
                    /// * `name="projects/my-project/locations/us-central1/repositories/my-repo"` You can also use
                    /// wildcards to match any number of characters before or after the value: *
                    /// `name="projects/my-project/locations/us-central1/repositories/my-*"` *
                    /// `name="projects/my-project/locations/us-central1/repositories/*repo"` *
                    /// `name="projects/my-project/locations/us-central1/repositories/*repo*"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. The field to order the results by.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The maximum number of repositories to return. Maximum page size is 1,000.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/repositories";

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

                /// <summary>Updates a repository.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name of the repository, for example: `projects/p1/locations/us-central1/repositories/repo1`. For
                /// each location in a project, repository names must be unique.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.ArtifactRegistry.v1.Data.Repository body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a repository.</summary>
                public class PatchRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Repository>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.Repository body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the repository, for example: `projects/p1/locations/us-central1/repositories/repo1`.
                    /// For each location in a project, repository names must be unique.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The update mask applies to the resource. For the `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ArtifactRegistry.v1.Data.Repository Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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

                /// <summary>Updates the IAM policy for a given resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ArtifactRegistry.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>Updates the IAM policy for a given resource.</summary>
                public class SetIamPolicyRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.ArtifactRegistry.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
                        });
                    }
                }

                /// <summary>Tests if the caller has a list of permissions on a resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ArtifactRegistry.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>Tests if the caller has a list of permissions on a resource.</summary>
                public class TestIamPermissionsRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.ArtifactRegistry.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/repositories/[^/]+$",
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
            public class GetRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.Location>
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

            /// <summary>Retrieves the VPCSC Config for the Project.</summary>
            /// <param name="name">Required. The name of the VPCSCConfig resource.</param>
            public virtual GetVpcscConfigRequest GetVpcscConfig(string name)
            {
                return new GetVpcscConfigRequest(this.service, name);
            }

            /// <summary>Retrieves the VPCSC Config for the Project.</summary>
            public class GetVpcscConfigRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.VPCSCConfig>
            {
                /// <summary>Constructs a new GetVpcscConfig request.</summary>
                public GetVpcscConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the VPCSCConfig resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getVpcscConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetVpcscConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/vpcscConfig$",
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
            public class ListRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
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

            /// <summary>Updates the VPCSC Config for the Project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the project's VPC SC Config. Always of the form:
            /// projects/{projectID}/locations/{location}/vpcscConfig In update request: never set In response: always
            /// set
            /// </param>
            public virtual UpdateVpcscConfigRequest UpdateVpcscConfig(Google.Apis.ArtifactRegistry.v1.Data.VPCSCConfig body, string name)
            {
                return new UpdateVpcscConfigRequest(this.service, body, name);
            }

            /// <summary>Updates the VPCSC Config for the Project.</summary>
            public class UpdateVpcscConfigRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.VPCSCConfig>
            {
                /// <summary>Constructs a new UpdateVpcscConfig request.</summary>
                public UpdateVpcscConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.VPCSCConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the project's VPC SC Config. Always of the form:
                /// projects/{projectID}/locations/{location}/vpcscConfig In update request: never set In response:
                /// always set
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Field mask to support partial updates.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ArtifactRegistry.v1.Data.VPCSCConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateVpcscConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateVpcscConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/vpcscConfig$",
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

        /// <summary>Retrieves the Settings for the Project.</summary>
        /// <param name="name">Required. The name of the projectSettings resource.</param>
        public virtual GetProjectSettingsRequest GetProjectSettings(string name)
        {
            return new GetProjectSettingsRequest(this.service, name);
        }

        /// <summary>Retrieves the Settings for the Project.</summary>
        public class GetProjectSettingsRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ProjectSettings>
        {
            /// <summary>Constructs a new GetProjectSettings request.</summary>
            public GetProjectSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the projectSettings resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getProjectSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetProjectSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/projectSettings$",
                });
            }
        }

        /// <summary>Updates the Settings for the Project.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The name of the project's settings. Always of the form: projects/{project-id}/projectSettings In update
        /// request: never set In response: always set
        /// </param>
        public virtual UpdateProjectSettingsRequest UpdateProjectSettings(Google.Apis.ArtifactRegistry.v1.Data.ProjectSettings body, string name)
        {
            return new UpdateProjectSettingsRequest(this.service, body, name);
        }

        /// <summary>Updates the Settings for the Project.</summary>
        public class UpdateProjectSettingsRequest : ArtifactRegistryBaseServiceRequest<Google.Apis.ArtifactRegistry.v1.Data.ProjectSettings>
        {
            /// <summary>Constructs a new UpdateProjectSettings request.</summary>
            public UpdateProjectSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.ArtifactRegistry.v1.Data.ProjectSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The name of the project's settings. Always of the form: projects/{project-id}/projectSettings In update
            /// request: never set In response: always set
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Field mask to support partial updates.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ArtifactRegistry.v1.Data.ProjectSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateProjectSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateProjectSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/projectSettings$",
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
namespace Google.Apis.ArtifactRegistry.v1.Data
{
    /// <summary>
    /// A detailed representation of an Apt artifact. Information in the record is derived from the archive's control
    /// file. See https://www.debian.org/doc/debian-policy/ch-controlfields.html
    /// </summary>
    public class AptArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Operating system architecture of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. Repository component of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("component")]
        public virtual string Component { get; set; }

        /// <summary>Output only. Contents of the artifact's control metadata file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlFile")]
        public virtual string ControlFile { get; set; }

        /// <summary>Output only. The Artifact Registry resource name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The Apt package name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Output only. An artifact is a binary or source package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an Apt remote repository.</summary>
    public class AptRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigAptRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Apt repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigAptRepositoryPublicRepository PublicRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Attachment refers to additional metadata that can be attached to artifacts in Artifact Registry. An
    /// attachment consists of one or more files.
    /// </summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User annotations. These attributes can only be set and used by the user, and not by Artifact
        /// Registry. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// The namespace this attachment belongs to. E.g. If an attachment is created by artifact analysis, namespace
        /// is set to `artifactanalysis.googleapis.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentNamespace")]
        public virtual string AttachmentNamespace { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the attachment was created.</summary>
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
        /// Required. The files that belong to this attachment. If the file ID part contains slashes, they are escaped.
        /// E.g. `projects/p1/locations/us-central1/repositories/repo1/files/sha:`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>
        /// The name of the attachment. E.g. `projects/p1/locations/us/repositories/repo/attachments/sbom`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The name of the OCI version that this attachment created. Only populated for Docker
        /// attachments. E.g. `projects/p1/locations/us-central1/repositories/repo1/packages/p1/versions/v1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociVersionName")]
        public virtual string OciVersionName { get; set; }

        /// <summary>
        /// Required. The target the attachment is for, can be a Version, Package or Repository. E.g.
        /// `projects/p1/locations/us-central1/repositories/repo1/packages/p1/versions/v1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Type of attachment. E.g. `application/vnd.spdx+json`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the attachment was last updated.</summary>
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

    /// <summary>The metadata of an LRO from deleting multiple versions.</summary>
    public class BatchDeleteVersionsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The versions the operation failed to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedVersions")]
        public virtual System.Collections.Generic.IList<string> FailedVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to delete multiple versions across a repository.</summary>
    public class BatchDeleteVersionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The names of the versions to delete. The maximum number of versions deleted per batch is
        /// determined by the service and is dependent on the available resources in the region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>If true, the request is performed without deleting data, following AIP-163.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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

    /// <summary>Artifact policy configuration for repository cleanup policies.</summary>
    public class CleanupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Policy condition for matching versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual CleanupPolicyCondition Condition { get; set; }

        /// <summary>The user-provided ID of the cleanup policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentVersions")]
        public virtual CleanupPolicyMostRecentVersions MostRecentVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CleanupPolicyCondition is a set of conditions attached to a CleanupPolicy. If multiple entries are set, all must
    /// be satisfied for the condition to be satisfied.
    /// </summary>
    public class CleanupPolicyCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Match versions newer than a duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newerThan")]
        public virtual object NewerThan { get; set; }

        /// <summary>Match versions older than a duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("olderThan")]
        public virtual object OlderThan { get; set; }

        /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> PackageNamePrefixes { get; set; }

        /// <summary>Match versions by tag prefix. Applied on any prefix match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagPrefixes")]
        public virtual System.Collections.Generic.IList<string> TagPrefixes { get; set; }

        /// <summary>Match versions by tag status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagState")]
        public virtual string TagState { get; set; }

        /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> VersionNamePrefixes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CleanupPolicyMostRecentVersions is an alternate condition of a CleanupPolicy for retaining a minimum number of
    /// versions.
    /// </summary>
    public class CleanupPolicyMostRecentVersions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Minimum number of versions to keep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepCount")]
        public virtual System.Nullable<int> KeepCount { get; set; }

        /// <summary>List of package name prefixes that will apply this rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> PackageNamePrefixes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common remote repository settings type.</summary>
    public class CommonRemoteRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A common public repository base for remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DockerImage represents a docker artifact. The following fields are returned as untyped metadata in the Version
    /// resource, using camelcase keys (i.e. metadata.imageSizeBytes): * imageSizeBytes * mediaType * buildTime
    /// </summary>
    public class DockerImage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _buildTimeRaw;

        private object _buildTime;

        /// <summary>
        /// The time this image was built. This field is returned as the 'metadata.buildTime' field in the Version
        /// resource. The build time is returned to the client as an RFC 3339 string, which can be easily used with the
        /// JavaScript Date constructor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildTime")]
        public virtual string BuildTimeRaw
        {
            get => _buildTimeRaw;
            set
            {
                _buildTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildTimeDateTimeOffset instead.")]
        public virtual object BuildTime
        {
            get => _buildTime;
            set
            {
                _buildTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildTimeRaw);
            set => BuildTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Calculated size of the image. This field is returned as the 'metadata.imageSizeBytes' field in the Version
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageSizeBytes")]
        public virtual System.Nullable<long> ImageSizeBytes { get; set; }

        /// <summary>
        /// Media type of this image, e.g. "application/vnd.docker.distribution.manifest.v2+json". This field is
        /// returned as the 'metadata.mediaType' field in the Version resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaType")]
        public virtual string MediaType { get; set; }

        /// <summary>
        /// Required. registry_location, project_id, repository_name and image id forms a unique image
        /// name:`projects//locations//repositories//dockerImages/`. For example,
        /// "projects/test-project/locations/us-west4/repositories/test-repo/dockerImages/
        /// nginx@sha256:e9954c1fc875017be1c3e36eca16be2d9e9bccc4bf072163515467d6a823c7cf", where "us-west4" is the
        /// registry_location, "test-project" is the project_id, "test-repo" is the repository_name and
        /// "nginx@sha256:e9954c1fc875017be1c3e36eca16be2d9e9bccc4bf072163515467d6a823c7cf" is the image's digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Tags attached to this image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the docker image was last updated.</summary>
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

        private string _uploadTimeRaw;

        private object _uploadTime;

        /// <summary>Time the image was uploaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadTime")]
        public virtual string UploadTimeRaw
        {
            get => _uploadTimeRaw;
            set
            {
                _uploadTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _uploadTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UploadTimeDateTimeOffset instead.")]
        public virtual object UploadTime
        {
            get => _uploadTime;
            set
            {
                _uploadTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _uploadTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UploadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UploadTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UploadTimeRaw);
            set => UploadTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. URL to access the image. Example:
        /// us-west4-docker.pkg.dev/test-project/test-repo/nginx@sha256:e9954c1fc875017be1c3e36eca16be2d9e9bccc4bf072163515467d6a823c7cf
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Docker remote repository.</summary>
    public class DockerRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigDockerRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Docker repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual string PublicRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DockerRepositoryConfig is docker related repository details. Provides additional configuration details for
    /// repositories of the docker format type.
    /// </summary>
    public class DockerRepositoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does
        /// not prevent tags from being created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("immutableTags")]
        public virtual System.Nullable<bool> ImmutableTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to download a file.</summary>
    public class DownloadFileResponse : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>GenericArtifact represents a generic artifact</summary>
    public class GenericArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the Generic module is created.</summary>
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
        /// Resource name of the generic artifact. project, location, repository, package_id and version_id create a
        /// unique generic artifact. i.e. "projects/test-project/locations/us-west4/repositories/test-repo/
        /// genericArtifacts/package_id:version_id"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the Generic module is updated.</summary>
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

        /// <summary>The version of the generic artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GoModule represents a Go module.</summary>
    public class GoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the Go module is created.</summary>
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

        /// <summary>The resource name of a Go module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the Go module is updated.</summary>
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
        /// The version of the Go module. Must be a valid canonical version as defined in
        /// https://go.dev/ref/mod#glos-canonical-version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detailed representation of a GooGet artifact.</summary>
    public class GoogetArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Operating system architecture of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The Artifact Registry resource name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The GooGet package name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Files store content that is potentially associated with Packages or Versions.</summary>
    public class GoogleDevtoolsArtifactregistryV1File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the File was created.</summary>
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

        private string _fetchTimeRaw;

        private object _fetchTime;

        /// <summary>
        /// Output only. The time when the last attempt to refresh the file's data was made. Only set when the
        /// repository is remote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchTime")]
        public virtual string FetchTimeRaw
        {
            get => _fetchTimeRaw;
            set
            {
                _fetchTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _fetchTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FetchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FetchTimeDateTimeOffset instead.")]
        public virtual object FetchTime
        {
            get => _fetchTime;
            set
            {
                _fetchTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _fetchTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FetchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FetchTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FetchTimeRaw);
            set => FetchTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The hashes of the file content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashes")]
        public virtual System.Collections.Generic.IList<Hash> Hashes { get; set; }

        /// <summary>
        /// The name of the file, for example:
        /// `projects/p1/locations/us-central1/repositories/repo1/files/a%2Fb%2Fc.txt`. If the file ID part contains
        /// slashes, they are escaped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The name of the Package or Version that owns this file, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual string Owner { get; set; }

        /// <summary>The size of the File in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the File was last updated.</summary>
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

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigAptRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the upstream remote repository, for ex: "https://my.apt.registry/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publicly available Apt repositories constructed from a common repository base and a custom repository path.
    /// </summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigAptRepositoryPublicRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A common public repository base for Apt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryBase")]
        public virtual string RepositoryBase { get; set; }

        /// <summary>A custom field to define a path to a specific repository from the base.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryPath")]
        public virtual string RepositoryPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigDockerRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the custom remote repository, for ex: "https://registry-1.docker.io".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigMavenRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the upstream remote repository, for ex: "https://my.maven.registry/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigNpmRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the upstream remote repository, for ex: "https://my.npm.registry/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigPythonRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the upstream remote repository, for ex: "https://my.python.registry/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-specified publicly available remote repository.</summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigYumRepositoryCustomRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An http/https uri reference to the upstream remote repository, for ex: "https://my.yum.registry/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publicly available Yum repositories constructed from a common repository base and a custom repository path.
    /// </summary>
    public class GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigYumRepositoryPublicRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A common public repository base for Yum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryBase")]
        public virtual string RepositoryBase { get; set; }

        /// <summary>A custom field to define a path to a specific repository from the base.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryPath")]
        public virtual string RepositoryPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule defines the deny or allow action of the operation it applies to and the conditions required for the rule
    /// to apply. You can set one rule for an entire repository and one rule for each package within.
    /// </summary>
    public class GoogleDevtoolsArtifactregistryV1Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action this rule takes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Optional. A CEL expression for conditions that must be met in order for the rule to apply. If not provided,
        /// the rule matches all objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// The name of the rule, for example: `projects/p1/locations/us-central1/repositories/repo1/rules/rule1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The package ID the rule applies to. If empty, this rule applies to all packages inside the repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageId")]
        public virtual string PackageId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A hash of file content.</summary>
    public class Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The algorithm used to compute the hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error information explaining why a package was not imported.</summary>
    public class ImportAptArtifactsErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed error status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Google Cloud Storage location requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportAptArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location where the artifacts currently reside.</summary>
    public class ImportAptArtifactsGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage paths URI (e.g., gs://my_bucket//my_object).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>Supports URI wildcards for matching multiple objects from a single URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useWildcards")]
        public virtual System.Nullable<bool> UseWildcards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for importing artifacts.</summary>
    public class ImportAptArtifactsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to import new apt artifacts.</summary>
    public class ImportAptArtifactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage location where input content is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportAptArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message from importing APT artifacts.</summary>
    public class ImportAptArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Apt artifacts imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptArtifacts")]
        public virtual System.Collections.Generic.IList<AptArtifact> AptArtifacts { get; set; }

        /// <summary>Detailed error info for packages that were not imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ImportAptArtifactsErrorInfo> Errors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error information explaining why a package was not imported.</summary>
    public class ImportGoogetArtifactsErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed error status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Google Cloud Storage location requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportGoogetArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location where the artifacts currently reside.</summary>
    public class ImportGoogetArtifactsGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage paths URI (e.g., `gs://my_bucket/my_object`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>Supports URI wildcards for matching multiple objects from a single URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useWildcards")]
        public virtual System.Nullable<bool> UseWildcards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for importing artifacts.</summary>
    public class ImportGoogetArtifactsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to import new googet artifacts.</summary>
    public class ImportGoogetArtifactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage location where input content is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportGoogetArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message from importing artifacts.</summary>
    public class ImportGoogetArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed error info for packages that were not imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ImportGoogetArtifactsErrorInfo> Errors { get; set; }

        /// <summary>The GooGet artifacts updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googetArtifacts")]
        public virtual System.Collections.Generic.IList<GoogetArtifact> GoogetArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error information explaining why a package was not imported.</summary>
    public class ImportYumArtifactsErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detailed error status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Google Cloud Storage location requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportYumArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Storage location where the artifacts currently reside.</summary>
    public class ImportYumArtifactsGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage paths URI (e.g., gs://my_bucket//my_object).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>Supports URI wildcards for matching multiple objects from a single URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useWildcards")]
        public virtual System.Nullable<bool> UseWildcards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for importing artifacts.</summary>
    public class ImportYumArtifactsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to import new yum artifacts.</summary>
    public class ImportYumArtifactsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage location where input content is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual ImportYumArtifactsGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message from importing YUM artifacts.</summary>
    public class ImportYumArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed error info for packages that were not imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<ImportYumArtifactsErrorInfo> Errors { get; set; }

        /// <summary>The yum artifacts imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumArtifacts")]
        public virtual System.Collections.Generic.IList<YumArtifact> YumArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detailed representation of a KFP artifact.</summary>
    public class KfpArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of the KFP artifact. Since users don't directly interact with this resource, the
        /// name will be derived from the associated version. For example, when version =
        /// ".../versions/sha256:abcdef...", the name will be ".../kfpArtifacts/sha256:abcdef...".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The version associated with the KFP artifact. Must follow the Semantic Versioning standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing attachments.</summary>
    public class ListAttachmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The attachments returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>
        /// The token to retrieve the next page of attachments, or empty if there are no more attachments to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing docker images.</summary>
    public class ListDockerImagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The docker images returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerImages")]
        public virtual System.Collections.Generic.IList<DockerImage> DockerImages { get; set; }

        /// <summary>
        /// The token to retrieve the next page of artifacts, or empty if there are no more artifacts to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing files.</summary>
    public class ListFilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The files returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsArtifactregistryV1File> Files { get; set; }

        /// <summary>
        /// The token to retrieve the next page of files, or empty if there are no more files to return.
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

    /// <summary>The response from listing maven artifacts.</summary>
    public class ListMavenArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maven artifacts returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<MavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// The token to retrieve the next page of artifacts, or empty if there are no more artifacts to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing npm packages.</summary>
    public class ListNpmPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of artifacts, or empty if there are no more artifacts to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The npm packages returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<NpmPackage> NpmPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing packages.</summary>
    public class ListPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of packages, or empty if there are no more packages to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The packages returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<Package> Packages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing python packages.</summary>
    public class ListPythonPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of artifacts, or empty if there are no more artifacts to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The python packages returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<PythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing repositories.</summary>
    public class ListRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of repositories, or empty if there are no more repositories to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The repositories returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositories")]
        public virtual System.Collections.Generic.IList<Repository> Repositories { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing rules.</summary>
    public class ListRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of rules, or empty if there are no more rules to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The rules returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsArtifactregistryV1Rule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing tags.</summary>
    public class ListTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of tags, or empty if there are no more tags to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The tags returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from listing versions.</summary>
    public class ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token to retrieve the next page of versions, or empty if there are no more versions to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The versions returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<Version> Versions { get; set; }

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

    /// <summary>MavenArtifact represents a maven artifact.</summary>
    public class MavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Artifact ID for the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the artifact was created.</summary>
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

        /// <summary>Group ID for the artifact. Example: com.google.guava</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// Required. registry_location, project_id, repository_name and maven_artifact forms a unique artifact For
        /// example, "projects/test-project/locations/us-west4/repositories/test-repo/mavenArtifacts/
        /// com.google.guava:guava:31.0-jre", where "us-west4" is the registry_location, "test-project" is the
        /// project_id, "test-repo" is the repository_name and "com.google.guava:guava:31.0-jre" is the maven artifact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. URL to access the pom file of the artifact. Example:
        /// us-west4-maven.pkg.dev/test-project/test-repo/com/google/guava/guava/31.0/guava-31.0.pom
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pomUri")]
        public virtual string PomUri { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time the artifact was updated.</summary>
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

        /// <summary>Version of this artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Maven remote repository.</summary>
    public class MavenRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigMavenRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Maven repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual string PublicRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details. Provides additional configuration details for
    /// repositories of the maven format type.
    /// </summary>
    public class MavenRepositoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The repository with this flag will allow publishing the same snapshot versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSnapshotOverwrites")]
        public virtual System.Nullable<bool> AllowSnapshotOverwrites { get; set; }

        /// <summary>Version policy defines the versions that the registry will accept.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionPolicy")]
        public virtual string VersionPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NpmPackage represents an npm artifact.</summary>
    public class NpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the package was created.</summary>
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
        /// Required. registry_location, project_id, repository_name and npm_package forms a unique package For example,
        /// "projects/test-project/locations/us-west4/repositories/test-repo/npmPackages/ npm_test:1.0.0", where
        /// "us-west4" is the registry_location, "test-project" is the project_id, "test-repo" is the repository_name
        /// and npm_test:1.0.0" is the npm package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Package for the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Tags attached to this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time the package was updated.</summary>
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

        /// <summary>Version of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Npm remote repository.</summary>
    public class NpmRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigNpmRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Npm repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual string PublicRepository { get; set; }

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

    /// <summary>Metadata type for longrunning-operations, currently empty.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Packages are named collections of versions.</summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time when the package was created.</summary>
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

        /// <summary>The display name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The name of the package, for example: `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`.
        /// If the package ID part contains slashes, the slashes are escaped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// The time when the package was last updated. This includes publishing a new version of the package.
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

    /// <summary>The Artifact Registry settings that apply to a Project.</summary>
    public class ProjectSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The redirection state of the legacy repositories in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyRedirectionState")]
        public virtual string LegacyRedirectionState { get; set; }

        /// <summary>
        /// The name of the project's settings. Always of the form: projects/{project-id}/projectSettings In update
        /// request: never set In response: always set
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The percentage of pull traffic to redirect from GCR to AR when using partial redirection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullPercent")]
        public virtual System.Nullable<int> PullPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PythonPackage represents a python artifact.</summary>
    public class PythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the package was created.</summary>
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
        /// Required. registry_location, project_id, repository_name and python_package forms a unique package
        /// name:`projects//locations//repository//pythonPackages/`. For example,
        /// "projects/test-project/locations/us-west4/repositories/test-repo/pythonPackages/ python_package:1.0.0",
        /// where "us-west4" is the registry_location, "test-project" is the project_id, "test-repo" is the
        /// repository_name and python_package:1.0.0" is the python package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Package for the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time the package was updated.</summary>
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
        /// Required. URL to access the package. Example:
        /// us-west4-python.pkg.dev/test-project/test-repo/python_package/file-name-1.0.0.tar.gz
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Version of this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Python remote repository.</summary>
    public class PythonRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigPythonRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Python repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual string PublicRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Remote repository configuration.</summary>
    public class RemoteRepositoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specific settings for an Apt remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptRepository")]
        public virtual AptRepository AptRepository { get; set; }

        /// <summary>Common remote repository settings. Used as the remote repository upstream URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonRepository")]
        public virtual CommonRemoteRepository CommonRepository { get; set; }

        /// <summary>The description of the remote source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Input only. A create/update remote repo option to avoid making a HEAD/GET request to validate a remote repo
        /// and any supplied upstream credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableUpstreamValidation")]
        public virtual System.Nullable<bool> DisableUpstreamValidation { get; set; }

        /// <summary>Specific settings for a Docker remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerRepository")]
        public virtual DockerRepository DockerRepository { get; set; }

        /// <summary>Specific settings for a Maven remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenRepository")]
        public virtual MavenRepository MavenRepository { get; set; }

        /// <summary>Specific settings for an Npm remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmRepository")]
        public virtual NpmRepository NpmRepository { get; set; }

        /// <summary>Specific settings for a Python remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonRepository")]
        public virtual PythonRepository PythonRepository { get; set; }

        /// <summary>Optional. The credentials used to access the remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamCredentials")]
        public virtual UpstreamCredentials UpstreamCredentials { get; set; }

        /// <summary>Specific settings for a Yum remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumRepository")]
        public virtual YumRepository YumRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Repository for storing artifacts with a specific format.</summary>
    public class Repository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cleanup policies for this repository. Cleanup policies indicate when certain package versions can
        /// be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique
        /// within a repository and be under 128 characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanupPolicies")]
        public virtual System.Collections.Generic.IDictionary<string, CleanupPolicy> CleanupPolicies { get; set; }

        /// <summary>
        /// Optional. If true, the cleanup pipeline is prevented from deleting versions in this repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cleanupPolicyDryRun")]
        public virtual System.Nullable<bool> CleanupPolicyDryRun { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the repository was created.</summary>
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

        /// <summary>The user-provided description of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. If this is true, an unspecified repo type will be treated as error rather than defaulting to
        /// standard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disallowUnspecifiedMode")]
        public virtual System.Nullable<bool> DisallowUnspecifiedMode { get; set; }

        /// <summary>
        /// Docker repository config contains repository level configuration for the repositories of docker type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerConfig")]
        public virtual DockerRepositoryConfig DockerConfig { get; set; }

        /// <summary>Optional. The format of packages that are stored in the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// The Cloud KMS resource name of the customer managed encryption key that's used to encrypt the contents of
        /// the Repository. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`.
        /// This value may not be changed after the Repository has been created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Labels with user-defined metadata. This field may contain up to 64 entries. Label keys and values may be no
        /// longer than 63 characters. Label keys must begin with a lowercase letter and may only contain lowercase
        /// letters, numeric characters, underscores, and dashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Maven repository config contains repository level configuration for the repositories of maven type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenConfig")]
        public virtual MavenRepositoryConfig MavenConfig { get; set; }

        /// <summary>Optional. The mode of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// The name of the repository, for example: `projects/p1/locations/us-central1/repositories/repo1`. For each
        /// location in a project, repository names must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The repository endpoint, for example: `us-docker.pkg.dev/my-proj/my-repo`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registryUri")]
        public virtual string RegistryUri { get; set; }

        /// <summary>Configuration specific for a Remote Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteRepositoryConfig")]
        public virtual RemoteRepositoryConfig RemoteRepositoryConfig { get; set; }

        /// <summary>Output only. Whether or not this repository satisfies PZI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Whether or not this repository satisfies PZS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Output only. The size, in bytes, of all artifact storage in this repository. Repositories that are generally
        /// available or in public preview use this to calculate storage costs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the repository was last updated.</summary>
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

        /// <summary>Configuration specific for a Virtual Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualRepositoryConfig")]
        public virtual VirtualRepositoryConfig VirtualRepositoryConfig { get; set; }

        /// <summary>
        /// Optional. Config and state for vulnerability scanning of resources within this Repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityScanningConfig")]
        public virtual VulnerabilityScanningConfig VulnerabilityScanningConfig { get; set; }

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

    /// <summary>
    /// Tags point to a version and represent an alternative name that can be used to access the version.
    /// </summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the tag, for example:
        /// "projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/tags/tag1". If the package part contains
        /// slashes, the slashes are escaped. The tag part can only have characters in [a-zA-Z0-9\-._~:@], anything else
        /// must be URL encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the version the tag refers to, for example:
        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/versions/sha256:5243811` If the package
        /// or version ID parts contain slashes, the slashes are escaped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

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

    /// <summary>The response to upload an artifact.</summary>
    public class UploadAptArtifactMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation to be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading artifacts.</summary>
    public class UploadAptArtifactMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload an artifact.</summary>
    public class UploadAptArtifactRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response of the completed artifact upload operation. This response is contained in the Operation and
    /// available to users.
    /// </summary>
    public class UploadAptArtifactResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Apt artifacts updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptArtifacts")]
        public virtual System.Collections.Generic.IList<AptArtifact> AptArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload a generic artifact.</summary>
    public class UploadFileMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation that will be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload a file.</summary>
    public class UploadFileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The ID of the file. If left empty will default to sha256 digest of the content uploaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload a generic artifact.</summary>
    public class UploadGenericArtifactMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation that will be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading generic artifacts.</summary>
    public class UploadGenericArtifactMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request to upload a generic artifact. The created GenericArtifact will have the resource name
    /// {parent}/genericArtifacts/package_id:version_id. The created file will have the resource name
    /// {parent}/files/package_id:version_id:filename.
    /// </summary>
    public class UploadGenericArtifactRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the file of the generic artifact to be uploaded. E.g. `example-file.zip` The filename is limited
        /// to letters, numbers, and url safe characters, i.e. [a-zA-Z0-9-_.~@].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>
        /// The ID of the package of the generic artifact. If the package does not exist, a new package will be created.
        /// The `package_id` should start and end with a letter or number, only contain letters, numbers, hyphens,
        /// underscores, and periods, and not exceed 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageId")]
        public virtual string PackageId { get; set; }

        /// <summary>
        /// The ID of the version of the generic artifact. If the version does not exist, a new version will be created.
        /// The version_id must start and end with a letter or number, can only contain lowercase letters, numbers, the
        /// following characters [-.+~:], i.e.[a-z0-9-.+~:] and cannot exceed a total of 128 characters. Creating a
        /// version called `latest` is not allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload a Go module.</summary>
    public class UploadGoModuleMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation to be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading go modules.</summary>
    public class UploadGoModuleMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload a Go module.</summary>
    public class UploadGoModuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload an artifact.</summary>
    public class UploadGoogetArtifactMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation to be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading artifacts.</summary>
    public class UploadGoogetArtifactMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload an artifact.</summary>
    public class UploadGoogetArtifactRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response of the completed artifact upload operation. This response is contained in the Operation and
    /// available to users.
    /// </summary>
    public class UploadGoogetArtifactResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The GooGet artifacts updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googetArtifacts")]
        public virtual System.Collections.Generic.IList<GoogetArtifact> GoogetArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload an artifact.</summary>
    public class UploadKfpArtifactMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation that will be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading KFP artifacts.</summary>
    public class UploadKfpArtifactMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload an artifact.</summary>
    public class UploadKfpArtifactRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the package version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Tags to be created with the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to upload an artifact.</summary>
    public class UploadYumArtifactMediaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation to be returned to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The operation metadata for uploading artifacts.</summary>
    public class UploadYumArtifactMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to upload an artifact.</summary>
    public class UploadYumArtifactRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response of the completed artifact upload operation. This response is contained in the Operation and
    /// available to users.
    /// </summary>
    public class UploadYumArtifactResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Yum artifacts updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumArtifacts")]
        public virtual System.Collections.Generic.IList<YumArtifact> YumArtifacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The credentials to access the remote repository.</summary>
    public class UpstreamCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Use username and password to access the remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usernamePasswordCredentials")]
        public virtual UsernamePasswordCredentials UsernamePasswordCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact policy configuration for the repository contents.</summary>
    public class UpstreamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user-provided ID of the upstream policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>
        /// A reference to the repository resource, for example: `projects/p1/locations/us-central1/repositories/repo1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Username and password credentials.</summary>
    public class UsernamePasswordCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Secret Manager key version that holds the password to access the remote repository. Must be in the
        /// format of `projects/{project}/secrets/{secret}/versions/{version}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>The username to access the remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Artifact Registry VPC SC config that apply to a Project.</summary>
    public class VPCSCConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the project's VPC SC Config. Always of the form:
        /// projects/{projectID}/locations/{location}/vpcscConfig In update request: never set In response: always set
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The project per location VPC SC policy that defines the VPC SC behavior for the Remote Repository
        /// (Allow/Deny).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcscPolicy")]
        public virtual string VpcscPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The body of a version resource. A version resource represents a collection of components, such as files and
    /// other data. This may correspond to a version in many package management schemes.
    /// </summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time when the version was created.</summary>
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

        /// <summary>Optional. Description of the version, as specified in its metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Repository-specific Metadata stored against this version. The fields returned are defined by
        /// the underlying repository-specific resource. Currently, the resources could be: DockerImage MavenArtifact
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The name of the version, for example:
        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1/versions/art1`. If the package or
        /// version ID parts contain slashes, the slashes are escaped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. A list of related tags. Will contain up to 100 tags that reference this version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedTags")]
        public virtual System.Collections.Generic.IList<Tag> RelatedTags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time when the version was last updated.</summary>
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

    /// <summary>Virtual repository configuration.</summary>
    public class VirtualRepositoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies
        /// cannot be set on a standard repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamPolicies")]
        public virtual System.Collections.Generic.IList<UpstreamPolicy> UpstreamPolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Config on whether to perform vulnerability scanning for resources in this repository, as well as output fields
    /// describing current state.
    /// </summary>
    public class VulnerabilityScanningConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config for whether this repository has vulnerability scanning disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementConfig")]
        public virtual string EnablementConfig { get; set; }

        /// <summary>
        /// Output only. State of feature enablement, combining repository enablement config and API enablement state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>Output only. Reason for the repository state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementStateReason")]
        public virtual string EnablementStateReason { get; set; }

        private string _lastEnableTimeRaw;

        private object _lastEnableTime;

        /// <summary>Output only. The last time this repository config was enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEnableTime")]
        public virtual string LastEnableTimeRaw
        {
            get => _lastEnableTimeRaw;
            set
            {
                _lastEnableTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastEnableTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastEnableTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastEnableTimeDateTimeOffset instead.")]
        public virtual object LastEnableTime
        {
            get => _lastEnableTime;
            set
            {
                _lastEnableTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastEnableTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastEnableTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastEnableTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastEnableTimeRaw);
            set => LastEnableTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detailed representation of a Yum artifact.</summary>
    public class YumArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Operating system architecture of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. The Artifact Registry resource name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The yum package name of the artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Output only. An artifact is a binary or source package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a Yum remote repository.</summary>
    public class YumRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customer-specified remote repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigYumRepositoryCustomRepository CustomRepository { get; set; }

        /// <summary>One of the publicly available Yum repositories supported by Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicRepository")]
        public virtual GoogleDevtoolsArtifactregistryV1RemoteRepositoryConfigYumRepositoryPublicRepository PublicRepository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
