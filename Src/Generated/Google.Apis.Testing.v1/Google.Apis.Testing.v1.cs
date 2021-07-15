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

namespace Google.Apis.Testing.v1
{
    /// <summary>The Testing Service.</summary>
    public class TestingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TestingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TestingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            ApplicationDetailService = new ApplicationDetailServiceResource(this);
            Projects = new ProjectsResource(this);
            TestEnvironmentCatalog = new TestEnvironmentCatalogResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "testing";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://testing.googleapis.com/";
        #else
            "https://testing.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://testing.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Testing API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Testing API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the ApplicationDetailService resource.</summary>
        public virtual ApplicationDetailServiceResource ApplicationDetailService { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the TestEnvironmentCatalog resource.</summary>
        public virtual TestEnvironmentCatalogResource TestEnvironmentCatalog { get; }
    }

    /// <summary>A base abstract class for Testing requests.</summary>
    public abstract class TestingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TestingBaseServiceRequest instance.</summary>
        protected TestingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Testing parameter list.</summary>
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

    /// <summary>The "applicationDetailService" collection of methods.</summary>
    public class ApplicationDetailServiceResource
    {
        private const string Resource = "applicationDetailService";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ApplicationDetailServiceResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the details of an Android application APK.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual GetApkDetailsRequest GetApkDetails(Google.Apis.Testing.v1.Data.FileReference body)
        {
            return new GetApkDetailsRequest(service, body);
        }

        /// <summary>Gets the details of an Android application APK.</summary>
        public class GetApkDetailsRequest : TestingBaseServiceRequest<Google.Apis.Testing.v1.Data.GetApkDetailsResponse>
        {
            /// <summary>Constructs a new GetApkDetails request.</summary>
            public GetApkDetailsRequest(Google.Apis.Services.IClientService service, Google.Apis.Testing.v1.Data.FileReference body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Testing.v1.Data.FileReference Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getApkDetails";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/applicationDetailService/getApkDetails";

            /// <summary>Initializes GetApkDetails parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
            TestMatrices = new TestMatricesResource(service);
        }

        /// <summary>Gets the TestMatrices resource.</summary>
        public virtual TestMatricesResource TestMatrices { get; }

        /// <summary>The "testMatrices" collection of methods.</summary>
        public class TestMatricesResource
        {
            private const string Resource = "testMatrices";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TestMatricesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Cancels unfinished test executions in a test matrix. This call returns immediately and cancellation
            /// proceeds asynchronously. If the matrix is already final, this operation will have no effect. May return
            /// any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to read
            /// project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the Test Matrix does not exist
            /// </summary>
            /// <param name="projectId">Cloud project that owns the test.</param>
            /// <param name="testMatrixId">Test matrix that will be canceled.</param>
            public virtual CancelRequest Cancel(string projectId, string testMatrixId)
            {
                return new CancelRequest(service, projectId, testMatrixId);
            }

            /// <summary>
            /// Cancels unfinished test executions in a test matrix. This call returns immediately and cancellation
            /// proceeds asynchronously. If the matrix is already final, this operation will have no effect. May return
            /// any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to read
            /// project - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the Test Matrix does not exist
            /// </summary>
            public class CancelRequest : TestingBaseServiceRequest<Google.Apis.Testing.v1.Data.CancelTestMatrixResponse>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, string projectId, string testMatrixId) : base(service)
                {
                    ProjectId = projectId;
                    TestMatrixId = testMatrixId;
                    InitParameters();
                }

                /// <summary>Cloud project that owns the test.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Test matrix that will be canceled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("testMatrixId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TestMatrixId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/testMatrices/{testMatrixId}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("testMatrixId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "testMatrixId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Creates and runs a matrix of tests according to the given specifications. Unsupported environments will
            /// be returned in the state UNSUPPORTED. A test matrix is limited to use at most 2000 devices in parallel.
            /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
            /// authorized to write to project - INVALID_ARGUMENT - if the request is malformed or if the matrix tries
            /// to use too many simultaneous devices.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">The GCE project under which this job will run.</param>
            public virtual CreateRequest Create(Google.Apis.Testing.v1.Data.TestMatrix body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>
            /// Creates and runs a matrix of tests according to the given specifications. Unsupported environments will
            /// be returned in the state UNSUPPORTED. A test matrix is limited to use at most 2000 devices in parallel.
            /// May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not
            /// authorized to write to project - INVALID_ARGUMENT - if the request is malformed or if the matrix tries
            /// to use too many simultaneous devices.
            /// </summary>
            public class CreateRequest : TestingBaseServiceRequest<Google.Apis.Testing.v1.Data.TestMatrix>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Testing.v1.Data.TestMatrix body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The GCE project under which this job will run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// A string id used to detect duplicated requests. Ids are automatically scoped to a project, so users
                /// should ensure the ID is unique per-project. A UUID is recommended. Optional, but strongly
                /// recommended.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Testing.v1.Data.TestMatrix Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/testMatrices";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
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
            /// Checks the status of a test matrix. May return any of the following canonical error codes: -
            /// PERMISSION_DENIED - if the user is not authorized to read project - INVALID_ARGUMENT - if the request is
            /// malformed - NOT_FOUND - if the Test Matrix does not exist
            /// </summary>
            /// <param name="projectId">Cloud project that owns the test matrix.</param>
            /// <param name="testMatrixId">Unique test matrix id which was assigned by the service.</param>
            public virtual GetRequest Get(string projectId, string testMatrixId)
            {
                return new GetRequest(service, projectId, testMatrixId);
            }

            /// <summary>
            /// Checks the status of a test matrix. May return any of the following canonical error codes: -
            /// PERMISSION_DENIED - if the user is not authorized to read project - INVALID_ARGUMENT - if the request is
            /// malformed - NOT_FOUND - if the Test Matrix does not exist
            /// </summary>
            public class GetRequest : TestingBaseServiceRequest<Google.Apis.Testing.v1.Data.TestMatrix>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string testMatrixId) : base(service)
                {
                    ProjectId = projectId;
                    TestMatrixId = testMatrixId;
                    InitParameters();
                }

                /// <summary>Cloud project that owns the test matrix.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Unique test matrix id which was assigned by the service.</summary>
                [Google.Apis.Util.RequestParameterAttribute("testMatrixId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TestMatrixId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/testMatrices/{testMatrixId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("testMatrixId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "testMatrixId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "testEnvironmentCatalog" collection of methods.</summary>
    public class TestEnvironmentCatalogResource
    {
        private const string Resource = "testEnvironmentCatalog";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TestEnvironmentCatalogResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the catalog of supported test environments. May return any of the following canonical error codes: -
        /// INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the environment type does not exist -
        /// INTERNAL - if an internal error occurred
        /// </summary>
        /// <param name="environmentType">Required. The type of environment that should be listed.</param>
        public virtual GetRequest Get(GetRequest.EnvironmentTypeEnum environmentType)
        {
            return new GetRequest(service, environmentType);
        }

        /// <summary>
        /// Gets the catalog of supported test environments. May return any of the following canonical error codes: -
        /// INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the environment type does not exist -
        /// INTERNAL - if an internal error occurred
        /// </summary>
        public class GetRequest : TestingBaseServiceRequest<Google.Apis.Testing.v1.Data.TestEnvironmentCatalog>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, EnvironmentTypeEnum environmentType) : base(service)
            {
                EnvironmentType = environmentType;
                InitParameters();
            }

            /// <summary>Required. The type of environment that should be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("environmentType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual EnvironmentTypeEnum EnvironmentType { get; private set; }

            /// <summary>Required. The type of environment that should be listed.</summary>
            public enum EnvironmentTypeEnum
            {
                /// <summary>Do not use. For proto versioning only.</summary>
                [Google.Apis.Util.StringValueAttribute("ENVIRONMENT_TYPE_UNSPECIFIED")]
                ENVIRONMENTTYPEUNSPECIFIED = 0,

                /// <summary>A device running a version of the Android OS.</summary>
                [Google.Apis.Util.StringValueAttribute("ANDROID")]
                ANDROID = 1,

                /// <summary>A device running a version of iOS.</summary>
                [Google.Apis.Util.StringValueAttribute("IOS")]
                IOS = 2,

                /// <summary>A network configuration to use when running a test.</summary>
                [Google.Apis.Util.StringValueAttribute("NETWORK_CONFIGURATION")]
                NETWORKCONFIGURATION = 3,

                /// <summary>The software environment provided by TestExecutionService.</summary>
                [Google.Apis.Util.StringValueAttribute("PROVIDED_SOFTWARE")]
                PROVIDEDSOFTWARE = 4,

                /// <summary>The IP blocks used by devices in the test environment.</summary>
                [Google.Apis.Util.StringValueAttribute("DEVICE_IP_BLOCKS")]
                DEVICEIPBLOCKS = 5,
            }

            /// <summary>For authorization, the cloud project requesting the TestEnvironmentCatalog.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/testEnvironmentCatalog/{environmentType}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("environmentType", new Google.Apis.Discovery.Parameter
                {
                    Name = "environmentType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Testing.v1.Data
{
    /// <summary>Identifies an account and how to log into it.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An automatic google login account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleAuto")]
        public virtual GoogleAuto GoogleAuto { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single Android device.</summary>
    public class AndroidDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the Android device to be used. Use the TestEnvironmentDiscoveryService to get supported
        /// options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidModelId")]
        public virtual string AndroidModelId { get; set; }

        /// <summary>
        /// Required. The id of the Android OS version to be used. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidVersionId")]
        public virtual string AndroidVersionId { get; set; }

        /// <summary>
        /// Required. The locale the test device used for testing. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// Required. How the device is oriented during the test. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The currently supported Android devices.</summary>
    public class AndroidDeviceCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of supported Android device models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<AndroidModel> Models { get; set; }

        /// <summary>The set of supported runtime configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeConfiguration")]
        public virtual AndroidRuntimeConfiguration RuntimeConfiguration { get; set; }

        /// <summary>The set of supported Android OS versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<AndroidVersion> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Android device configurations in which the test is to be executed.</summary>
    public class AndroidDeviceList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDevices")]
        public virtual System.Collections.Generic.IList<AndroidDevice> AndroidDevices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A test of an Android application that can control an Android component independently of its normal lifecycle.
    /// Android instrumentation tests run an application APK and test APK inside the same process on a virtual or
    /// physical AndroidDevice. They also specify a test runner class, such as com.google.GoogleTestRunner, which can
    /// vary on the specific instrumentation framework chosen. See for more information on types of Android tests.
    /// </summary>
    public class AndroidInstrumentationTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The APK for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appApk")]
        public virtual FileReference AppApk { get; set; }

        /// <summary>A multi-apk app bundle for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundle")]
        public virtual AppBundle AppBundle { get; set; }

        /// <summary>
        /// The java package for the application under test. The default value is determined by examining the
        /// application's manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appPackageId")]
        public virtual string AppPackageId { get; set; }

        /// <summary>
        /// The option of whether running each test within its own invocation of instrumentation with Android Test
        /// Orchestrator or not. ** Orchestrator is only compatible with AndroidJUnitRunner version 1.0 or higher! **
        /// Orchestrator offers the following benefits: - No shared state - Crashes are isolated - Logs are scoped per
        /// test See for more information about Android Test Orchestrator. If not set, the test will be run without the
        /// orchestrator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestratorOption")]
        public virtual string OrchestratorOption { get; set; }

        /// <summary>The option to run tests in multiple shards in parallel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardingOption")]
        public virtual ShardingOption ShardingOption { get; set; }

        /// <summary>Required. The APK containing the test code to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testApk")]
        public virtual FileReference TestApk { get; set; }

        /// <summary>
        /// The java package for the test to be executed. The default value is determined by examining the application's
        /// manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testPackageId")]
        public virtual string TestPackageId { get; set; }

        /// <summary>
        /// The InstrumentationTestRunner class. The default value is determined by examining the application's
        /// manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testRunnerClass")]
        public virtual string TestRunnerClass { get; set; }

        /// <summary>
        /// Each target must be fully qualified with the package name or class name, in one of these formats: - "package
        /// package_name" - "class package_name.class_name" - "class package_name.class_name#method_name" If empty, all
        /// targets in the module will be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargets")]
        public virtual System.Collections.Generic.IList<string> TestTargets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of Android device configuration permutations is defined by the the cross-product of the given axes.
    /// Internally, the given AndroidMatrix will be expanded into a set of AndroidDevices. Only supported permutations
    /// will be instantiated. Invalid permutations (e.g., incompatible models/versions) are ignored.
    /// </summary>
    public class AndroidMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The ids of the set of Android device to be used. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidModelIds")]
        public virtual System.Collections.Generic.IList<string> AndroidModelIds { get; set; }

        /// <summary>
        /// Required. The ids of the set of Android OS version to be used. Use the TestEnvironmentDiscoveryService to
        /// get supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidVersionIds")]
        public virtual System.Collections.Generic.IList<string> AndroidVersionIds { get; set; }

        /// <summary>
        /// Required. The set of locales the test device will enable for testing. Use the
        /// TestEnvironmentDiscoveryService to get supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locales")]
        public virtual System.Collections.Generic.IList<string> Locales { get; set; }

        /// <summary>
        /// Required. The set of orientations to test with. Use the TestEnvironmentDiscoveryService to get supported
        /// options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientations")]
        public virtual System.Collections.Generic.IList<string> Orientations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of an Android device tests may be run on.</summary>
    public class AndroidModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The company that this device is branded with. Example: "Google", "Samsung".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>The name of the industrial design. This corresponds to android.os.Build.DEVICE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codename")]
        public virtual string Codename { get; set; }

        /// <summary>Whether this device is virtual or physical.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual string Form { get; set; }

        /// <summary>Whether this device is a phone, tablet, wearable, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>The unique opaque id for this model. Use this for invoking the TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// True if and only if tests with this model are recorded by stitching together screenshots. See
        /// use_low_spec_video_recording in device config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowFpsVideoRecording")]
        public virtual System.Nullable<bool> LowFpsVideoRecording { get; set; }

        /// <summary>The manufacturer of this device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>
        /// The human-readable marketing name for this device model. Examples: "Nexus 5", "Galaxy S5".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Screen density in DPI. This corresponds to ro.sf.lcd_density</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensity")]
        public virtual System.Nullable<int> ScreenDensity { get; set; }

        /// <summary>Screen size in the horizontal (X) dimension measured in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenX")]
        public virtual System.Nullable<int> ScreenX { get; set; }

        /// <summary>Screen size in the vertical (Y) dimension measured in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenY")]
        public virtual System.Nullable<int> ScreenY { get; set; }

        /// <summary>
        /// The list of supported ABIs for this device. This corresponds to either android.os.Build.SUPPORTED_ABIS (for
        /// API level 21 and above) or android.os.Build.CPU_ABI/CPU_ABI2. The most preferred ABI is the first element in
        /// the list. Elements are optionally prefixed by "version_id:" (where version_id is the id of an
        /// AndroidVersion), denoting an ABI that is supported only on a particular version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedAbis")]
        public virtual System.Collections.Generic.IList<string> SupportedAbis { get; set; }

        /// <summary>The set of Android versions this device supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedVersionIds")]
        public virtual System.Collections.Generic.IList<string> SupportedVersionIds { get; set; }

        /// <summary>Tags for this dimension. Examples: "default", "preview", "deprecated".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// URL of a thumbnail image (photo) of the device. e.g.
        /// https://lh3.googleusercontent.com/90WcauuJiCYABEl8U0lcZeuS5STUbf2yW...
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A test of an android application that explores the application on a virtual or physical Android Device, finding
    /// culprits and crashes as it goes. Next tag: 30
    /// </summary>
    public class AndroidRoboTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The APK for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appApk")]
        public virtual FileReference AppApk { get; set; }

        /// <summary>A multi-apk app bundle for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundle")]
        public virtual AppBundle AppBundle { get; set; }

        /// <summary>The initial activity that should be used to start the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInitialActivity")]
        public virtual string AppInitialActivity { get; set; }

        /// <summary>
        /// The java package for the application under test. The default value is determined by examining the
        /// application's manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appPackageId")]
        public virtual string AppPackageId { get; set; }

        /// <summary>
        /// The max depth of the traversal stack Robo can explore. Needs to be at least 2 to make Robo explore the app
        /// beyond the first activity. Default is 50.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDepth")]
        public virtual System.Nullable<int> MaxDepth { get; set; }

        /// <summary>The max number of steps Robo can execute. Default is no limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSteps")]
        public virtual System.Nullable<int> MaxSteps { get; set; }

        /// <summary>
        /// A set of directives Robo should apply during the crawl. This allows users to customize the crawl. For
        /// example, the username and password for a test account can be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboDirectives")]
        public virtual System.Collections.Generic.IList<RoboDirective> RoboDirectives { get; set; }

        /// <summary>
        /// The mode in which Robo should run. Most clients should allow the server to populate this field
        /// automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboMode")]
        public virtual string RoboMode { get; set; }

        /// <summary>A JSON file with a sequence of actions Robo should perform as a prologue for the crawl.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roboScript")]
        public virtual FileReference RoboScript { get; set; }

        /// <summary>
        /// The intents used to launch the app for the crawl. If none are provided, then the main launcher activity is
        /// launched. If some are provided, then only those provided are launched (the main launcher activity must be
        /// provided explicitly).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startingIntents")]
        public virtual System.Collections.Generic.IList<RoboStartingIntent> StartingIntents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android configuration that can be selected at the time a test is run.</summary>
    public class AndroidRuntimeConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of available locales.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locales")]
        public virtual System.Collections.Generic.IList<Locale> Locales { get; set; }

        /// <summary>The set of available orientations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientations")]
        public virtual System.Collections.Generic.IList<Orientation> Orientations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A test of an Android Application with a Test Loop. The intent \ will be implicitly added, since Games is the
    /// only user of this api, for the time being.
    /// </summary>
    public class AndroidTestLoop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The APK for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appApk")]
        public virtual FileReference AppApk { get; set; }

        /// <summary>A multi-apk app bundle for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundle")]
        public virtual AppBundle AppBundle { get; set; }

        /// <summary>
        /// The java package for the application under test. The default is determined by examining the application's
        /// manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appPackageId")]
        public virtual string AppPackageId { get; set; }

        /// <summary>
        /// The list of scenario labels that should be run during the test. The scenario labels should map to labels
        /// defined in the application's manifest. For example, player_experience and
        /// com.google.test.loops.player_experience add all of the loops labeled in the manifest with the
        /// com.google.test.loops.player_experience name to the execution. Scenarios can also be specified in the
        /// scenarios field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenarioLabels")]
        public virtual System.Collections.Generic.IList<string> ScenarioLabels { get; set; }

        /// <summary>
        /// The list of scenarios that should be run during the test. The default is all test loops, derived from the
        /// application's manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenarios")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Scenarios { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A version of the Android OS.</summary>
    public class AndroidVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API level for this Android version. Examples: 18, 19.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiLevel")]
        public virtual System.Nullable<int> ApiLevel { get; set; }

        /// <summary>The code name for this Android version. Examples: "JellyBean", "KitKat".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeName")]
        public virtual string CodeName { get; set; }

        /// <summary>Market share for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual Distribution Distribution { get; set; }

        /// <summary>An opaque id for this Android version. Use this id to invoke the TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The date this Android version became available in the market.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseDate")]
        public virtual Date ReleaseDate { get; set; }

        /// <summary>Tags for this dimension. Examples: "default", "preview", "deprecated".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>A string representing this version of the Android OS. Examples: "4.3", "4.4".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionString")]
        public virtual string VersionString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Android package file to install.</summary>
    public class Apk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The path to an APK to be installed on the device before the test begins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual FileReference Location { get; set; }

        /// <summary>
        /// The java package for the APK to be installed. Value is determined by examining the application's manifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android application details based on application manifest and apk archive contents.</summary>
    public class ApkDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("apkManifest")]
        public virtual ApkManifest ApkManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Android app manifest. See http://developer.android.com/guide/topics/manifest/manifest-intro.html
    /// </summary>
    public class ApkManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User-readable name for the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationLabel")]
        public virtual string ApplicationLabel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intentFilters")]
        public virtual System.Collections.Generic.IList<IntentFilter> IntentFilters { get; set; }

        /// <summary>Maximum API level on which the application is designed to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSdkVersion")]
        public virtual System.Nullable<int> MaxSdkVersion { get; set; }

        /// <summary>Minimum API level required for the application to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSdkVersion")]
        public virtual System.Nullable<int> MinSdkVersion { get; set; }

        /// <summary>Full Java-style package name for this application, e.g. "com.example.foo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Specifies the API Level on which the application is designed to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSdkVersion")]
        public virtual System.Nullable<int> TargetSdkVersion { get; set; }

        /// <summary>Permissions declared to be used by the application</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesPermission")]
        public virtual System.Collections.Generic.IList<string> UsesPermission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Android App Bundle file format, containing a BundleConfig.pb file, a base module directory, zero or more
    /// dynamic feature module directories. See https://developer.android.com/guide/app-bundle/build for guidance on
    /// building App Bundles.
    /// </summary>
    public class AppBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>.aab file representing the app bundle under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleLocation")]
        public virtual FileReference BundleLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the current state of the specified test matrix.</summary>
    public class CancelTestMatrixResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The current rolled-up state of the test matrix. If this state is already final, then the cancelation request
        /// will have no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testState")]
        public virtual string TestState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the client which invoked the test.</summary>
    public class ClientInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of detailed information about client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientInfoDetails")]
        public virtual System.Collections.Generic.IList<ClientInfoDetail> ClientInfoDetails { get; set; }

        /// <summary>Required. Client name, such as gcloud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Key-value pair of detailed information about the client which invoked the test. Examples: {'Version', '1.0'},
    /// {'Release Track', 'BETA'}.
    /// </summary>
    public class ClientInfoDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The key of detailed client information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. The value of detailed client information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>A single device file description.</summary>
    public class DeviceFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reference to an opaque binary blob file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obbFile")]
        public virtual ObbFile ObbFile { get; set; }

        /// <summary>A reference to a regular file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regularFile")]
        public virtual RegularFile RegularFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single device IP block</summary>
    public class DeviceIpBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date this block was added to Firebase Test Lab</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addedDate")]
        public virtual Date AddedDate { get; set; }

        /// <summary>An IP address block in CIDR notation eg: 34.68.194.64/29</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("block")]
        public virtual string Block { get; set; }

        /// <summary>Whether this block is used by physical or virtual devices</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual string Form { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of IP blocks used by the Firebase Test Lab</summary>
    public class DeviceIpBlockCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device IP blocks used by Firebase Test Lab</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipBlocks")]
        public virtual System.Collections.Generic.IList<DeviceIpBlock> IpBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data about the relative number of devices running a given configuration of the Android platform.
    /// </summary>
    public class Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The estimated fraction (0-1) of the total market with this configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketShare")]
        public virtual System.Nullable<double> MarketShare { get; set; }

        /// <summary>Output only. The time this distribution was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementTime")]
        public virtual object MeasurementTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environment in which the test is run.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Android device which must be used with an Android test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDevice")]
        public virtual AndroidDevice AndroidDevice { get; set; }

        /// <summary>An iOS device which must be used with an iOS test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosDevice")]
        public virtual IosDevice IosDevice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The matrix of environments in which the test is to be executed.</summary>
    public class EnvironmentMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Android devices; the test will be run only on the specified devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDeviceList")]
        public virtual AndroidDeviceList AndroidDeviceList { get; set; }

        /// <summary>A matrix of Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidMatrix")]
        public virtual AndroidMatrix AndroidMatrix { get; set; }

        /// <summary>A list of iOS devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosDeviceList")]
        public virtual IosDeviceList IosDeviceList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A key-value pair passed as an environment variable to the test.</summary>
    public class EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key for the environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value for the environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a file, used for user inputs.</summary>
    public class FileReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A path to a file in Google Cloud Storage. Example: gs://build-app-1414623860166/app%40debug-unaligned.apk
        /// These paths are expected to be url encoded (percent encoding)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the details of the specified Android application APK.</summary>
    public class GetApkDetailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of the Android APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apkDetail")]
        public virtual ApkDetail ApkDetail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Enables automatic Google account login. If set, the service automatically generates a Google test account and
    /// adds it to the device, before executing the test. Note that test accounts might be reused. Many applications
    /// show their full set of functionalities when an account is present on the device. Logging into the device with
    /// these generated accounts allows testing more functionalities.
    /// </summary>
    public class GoogleAuto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A storage location within Google cloud storage (GCS).</summary>
    public class GoogleCloudStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The path to a directory in GCS that will eventually contain the results for this test. The
        /// requesting user must have write access on the bucket in the supplied path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The section of an tag. https://developer.android.com/guide/topics/manifest/intent-filter-element.html
    /// </summary>
    public class IntentFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The android:name value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionNames")]
        public virtual System.Collections.Generic.IList<string> ActionNames { get; set; }

        /// <summary>The android:name value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryNames")]
        public virtual System.Collections.Generic.IList<string> CategoryNames { get; set; }

        /// <summary>The android:mimeType value of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single iOS device.</summary>
    public class IosDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The id of the iOS device to be used. Use the TestEnvironmentDiscoveryService to get supported
        /// options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosModelId")]
        public virtual string IosModelId { get; set; }

        /// <summary>
        /// Required. The id of the iOS major software version to be used. Use the TestEnvironmentDiscoveryService to
        /// get supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosVersionId")]
        public virtual string IosVersionId { get; set; }

        /// <summary>
        /// Required. The locale the test device used for testing. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// Required. How the device is oriented during the test. Use the TestEnvironmentDiscoveryService to get
        /// supported options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The currently supported iOS devices.</summary>
    public class IosDeviceCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of supported iOS device models.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("models")]
        public virtual System.Collections.Generic.IList<IosModel> Models { get; set; }

        /// <summary>The set of supported runtime configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeConfiguration")]
        public virtual IosRuntimeConfiguration RuntimeConfiguration { get; set; }

        /// <summary>The set of supported iOS software versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<IosVersion> Versions { get; set; }

        /// <summary>The set of supported Xcode versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcodeVersions")]
        public virtual System.Collections.Generic.IList<XcodeVersion> XcodeVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A file or directory to install on the device before the test starts.</summary>
    public class IosDeviceFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The bundle id of the app where this file lives. iOS apps sandbox their own filesystem, so app files must
        /// specify which app installed on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>The source file</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual FileReference Content { get; set; }

        /// <summary>Location of the file on the device, inside the app's sandboxed filesystem</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePath")]
        public virtual string DevicePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of iOS device configurations in which the test is to be executed.</summary>
    public class IosDeviceList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of iOS devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosDevices")]
        public virtual System.Collections.Generic.IList<IosDevice> IosDevices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of an iOS device tests may be run on.</summary>
    public class IosModel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device capabilities. Copied from
        /// https://developer.apple.com/library/archive/documentation/DeviceInformation/Reference/iOSDeviceCompatibility/DeviceCompatibilityMatrix/DeviceCompatibilityMatrix.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCapabilities")]
        public virtual System.Collections.Generic.IList<string> DeviceCapabilities { get; set; }

        /// <summary>Whether this device is a phone, tablet, wearable, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>The unique opaque id for this model. Use this for invoking the TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The human-readable name for this device model. Examples: "iPhone 4s", "iPad Mini 2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Screen density in DPI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensity")]
        public virtual System.Nullable<int> ScreenDensity { get; set; }

        /// <summary>Screen size in the horizontal (X) dimension measured in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenX")]
        public virtual System.Nullable<int> ScreenX { get; set; }

        /// <summary>Screen size in the vertical (Y) dimension measured in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenY")]
        public virtual System.Nullable<int> ScreenY { get; set; }

        /// <summary>The set of iOS major software versions this device supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedVersionIds")]
        public virtual System.Collections.Generic.IList<string> SupportedVersionIds { get; set; }

        /// <summary>Tags for this dimension. Examples: "default", "preview", "deprecated".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>iOS configuration that can be selected at the time a test is run.</summary>
    public class IosRuntimeConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of available locales.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locales")]
        public virtual System.Collections.Generic.IList<Locale> Locales { get; set; }

        /// <summary>The set of available orientations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientations")]
        public virtual System.Collections.Generic.IList<Orientation> Orientations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A test of an iOS application that implements one or more game loop scenarios. This test type accepts an archived
    /// application (.ipa file) and a list of integer scenarios that will be executed on the app sequentially.
    /// </summary>
    public class IosTestLoop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The bundle id for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundleId")]
        public virtual string AppBundleId { get; set; }

        /// <summary>Required. The .ipa of the application to test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appIpa")]
        public virtual FileReference AppIpa { get; set; }

        /// <summary>
        /// The list of scenarios that should be run during the test. Defaults to the single scenario 0 if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenarios")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Scenarios { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of how to set up an iOS device prior to running the test.</summary>
    public class IosTestSetup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>iOS apps to install in addition to those being directly tested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalIpas")]
        public virtual System.Collections.Generic.IList<FileReference> AdditionalIpas { get; set; }

        /// <summary>
        /// The network traffic profile used for running the test. Available network profiles can be queried by using
        /// the NETWORK_CONFIGURATION environment type when calling
        /// TestEnvironmentDiscoveryService.GetTestEnvironmentCatalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkProfile")]
        public virtual string NetworkProfile { get; set; }

        /// <summary>
        /// List of directories on the device to upload to Cloud Storage at the end of the test. Directories should
        /// either be in a shared directory (e.g. /private/var/mobile/Media) or within an accessible directory inside
        /// the app's filesystem (e.g. /Documents) by specifying the bundle id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullDirectories")]
        public virtual System.Collections.Generic.IList<IosDeviceFile> PullDirectories { get; set; }

        /// <summary>List of files to push to the device before starting the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushFiles")]
        public virtual System.Collections.Generic.IList<IosDeviceFile> PushFiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An iOS version.</summary>
    public class IosVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An opaque id for this iOS version. Use this id to invoke the TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>An integer representing the major iOS version. Examples: "8", "9".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorVersion")]
        public virtual System.Nullable<int> MajorVersion { get; set; }

        /// <summary>An integer representing the minor iOS version. Examples: "1", "2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minorVersion")]
        public virtual System.Nullable<int> MinorVersion { get; set; }

        /// <summary>The available Xcode versions for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedXcodeVersionIds")]
        public virtual System.Collections.Generic.IList<string> SupportedXcodeVersionIds { get; set; }

        /// <summary>Tags for this dimension. Examples: "default", "preview", "deprecated".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A test of an iOS application that uses the XCTest framework. Xcode supports the option to "build for testing",
    /// which generates an .xctestrun file that contains a test specification (arguments, test methods, etc). This test
    /// type accepts a zip file containing the .xctestrun file and the corresponding contents of the Build/Products
    /// directory that contains all the binaries needed to run the tests.
    /// </summary>
    public class IosXcTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The bundle id for the application under test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundleId")]
        public virtual string AppBundleId { get; set; }

        /// <summary>
        /// The option to test special app entitlements. Setting this would re-sign the app having special entitlements
        /// with an explicit application-identifier. Currently supports testing aps-environment entitlement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSpecialEntitlements")]
        public virtual System.Nullable<bool> TestSpecialEntitlements { get; set; }

        /// <summary>
        /// Required. The .zip containing the .xctestrun file and the contents of the DerivedData/Build/Products
        /// directory. The .xctestrun file in this zip is ignored if the xctestrun field is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testsZip")]
        public virtual FileReference TestsZip { get; set; }

        /// <summary>
        /// The Xcode version that should be used for the test. Use the TestEnvironmentDiscoveryService to get supported
        /// options. Defaults to the latest Xcode version Firebase Test Lab supports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcodeVersion")]
        public virtual string XcodeVersion { get; set; }

        /// <summary>
        /// An .xctestrun file that will override the .xctestrun file in the tests zip. Because the .xctestrun file
        /// contains environment variables along with test methods to run and/or ignore, this can be useful for sharding
        /// tests. Default is taken from the tests zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xctestrun")]
        public virtual FileReference Xctestrun { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies an intent that starts the main launcher activity.</summary>
    public class LauncherActivityIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location/region designation for language.</summary>
    public class Locale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id for this locale. Example: "en_US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A human-friendly name for this language/locale. Example: "English".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A human-friendly string representing the region for this locale. Example: "United States". Not present for
        /// every locale.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Tags for this dimension. Example: "default".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shards test cases into the specified groups of packages, classes, and/or methods. With manual sharding enabled,
    /// specifying test targets via environment_variables or in InstrumentationTest is invalid.
    /// </summary>
    public class ManualSharding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Group of packages, classes, and/or test methods to be run for each shard. When any physical
        /// devices are selected, the number of test_targets_for_shard must be &amp;gt;= 1 and &amp;lt;= 50. When no
        /// physical devices are selected, the number must be &amp;gt;= 1 and &amp;lt;= 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargetsForShard")]
        public virtual System.Collections.Generic.IList<TestTargetsForShard> TestTargetsForShard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class NetworkConfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The emulation rule applying to the download traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downRule")]
        public virtual TrafficRule DownRule { get; set; }

        /// <summary>The unique opaque id for this network traffic configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The emulation rule applying to the upload traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upRule")]
        public virtual TrafficRule UpRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class NetworkConfigurationCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("configurations")]
        public virtual System.Collections.Generic.IList<NetworkConfiguration> Configurations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An opaque binary blob file to install on the device before the test starts.</summary>
    public class ObbFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Opaque Binary Blob (OBB) file(s) to install on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obb")]
        public virtual FileReference Obb { get; set; }

        /// <summary>
        /// Required. OBB file name which must conform to the format as specified by Android e.g.
        /// [main|patch].0300110.com.example.android.obb which will be installed into \/Android/obb/\/ on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obbFileName")]
        public virtual string ObbFileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Screen orientation of the device.</summary>
    public class Orientation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id for this orientation. Example: "portrait".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A human-friendly name for this orientation. Example: "portrait".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Tags for this dimension. Example: "default".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The currently provided software environment on the devices under test.</summary>
    public class ProvidedSoftwareCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A string representing the current version of AndroidX Test Orchestrator that is used in the environment. The
        /// package is available at https://maven.google.com/web/index.html#androidx.test:orchestrator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidxOrchestratorVersion")]
        public virtual string AndroidxOrchestratorVersion { get; set; }

        /// <summary>
        /// A string representing the current version of Android Test Orchestrator that is used in the environment. The
        /// package is available at https://maven.google.com/web/index.html#com.android.support.test:orchestrator.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestratorVersion")]
        public virtual string OrchestratorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A file or directory to install on the device before the test starts.</summary>
    public class RegularFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The source file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual FileReference Content { get; set; }

        /// <summary>
        /// Required. Where to put the content on the device. Must be an absolute, allowlisted path. If the file exists,
        /// it will be replaced. The following device-side directories and any of their subdirectories are allowlisted:
        /// ${EXTERNAL_STORAGE}, /sdcard, or /storage ${ANDROID_DATA}/local/tmp, or /data/local/tmp Specifying a path
        /// outside of these directory trees is invalid. The paths /sdcard and /data will be made available and treated
        /// as implicit path substitutions. E.g. if /sdcard on a particular device does not map to external storage, the
        /// system will replace it with the external storage path prefix for that device and copy the file there. It is
        /// strongly advised to use the Environment API in app and test code to access files on the device in a portable
        /// way.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePath")]
        public virtual string DevicePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Locations where the results of running the test are stored.</summary>
    public class ResultStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStorage")]
        public virtual GoogleCloudStorage GoogleCloudStorage { get; set; }

        /// <summary>Output only. URL to the results in the Firebase Web Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsUrl")]
        public virtual string ResultsUrl { get; set; }

        /// <summary>Output only. The tool results execution that results are written to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResultsExecution")]
        public virtual ToolResultsExecution ToolResultsExecution { get; set; }

        /// <summary>
        /// The tool results history that contains the tool results execution that results are written to. If not
        /// provided, the service will choose an appropriate value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResultsHistory")]
        public virtual ToolResultsHistory ToolResultsHistory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Directs Robo to interact with a specific UI element if it is encountered during the crawl. Currently, Robo can
    /// perform text entry or element click.
    /// </summary>
    public class RoboDirective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of action that Robo should perform on the specified element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// The text that Robo is directed to set. If left empty, the directive will be treated as a CLICK on the
        /// element matching the resource_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputText")]
        public virtual string InputText { get; set; }

        /// <summary>
        /// Required. The android resource name of the target UI element. For example, in Java: R.string.foo in xml:
        /// @string/foo Only the "foo" part is needed. Reference doc:
        /// https://developer.android.com/guide/topics/resources/accessing-resources.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for specifying the start activities to crawl.</summary>
    public class RoboStartingIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An intent that starts the main launcher activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launcherActivity")]
        public virtual LauncherActivityIntent LauncherActivity { get; set; }

        /// <summary>An intent that starts an activity with specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startActivity")]
        public virtual StartActivityIntent StartActivity { get; set; }

        /// <summary>Timeout in seconds for each intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output only. Details about the shard.</summary>
    public class Shard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numShards")]
        public virtual System.Nullable<int> NumShards { get; set; }

        /// <summary>Output only. The index of the shard among all the shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardIndex")]
        public virtual System.Nullable<int> ShardIndex { get; set; }

        /// <summary>Output only. Test targets for each shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargetsForShard")]
        public virtual TestTargetsForShard TestTargetsForShard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for enabling sharding.</summary>
    public class ShardingOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Shards test cases into the specified groups of packages, classes, and/or methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualSharding")]
        public virtual ManualSharding ManualSharding { get; set; }

        /// <summary>Uniformly shards test cases given a total number of shards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniformSharding")]
        public virtual UniformSharding UniformSharding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A starting intent specified by an action, uri, and categories.</summary>
    public class StartActivityIntent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action name. Required for START_ACTIVITY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Intent categories to set on the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>URI for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SystraceSetup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Systrace duration in seconds. Should be between 1 and 30 seconds. 0 disables systrace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationSeconds")]
        public virtual System.Nullable<int> DurationSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional details about the progress of the running test.</summary>
    public class TestDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If the TestState is ERROR, then this string will contain human-readable details about the
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Output only. Human-readable, detailed descriptions of the test's progress. For example: "Provisioning a
        /// device", "Starting Test". During the course of execution new data may be appended to the end of
        /// progress_messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressMessages")]
        public virtual System.Collections.Generic.IList<string> ProgressMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a test environment.</summary>
    public class TestEnvironmentCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Supported Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDeviceCatalog")]
        public virtual AndroidDeviceCatalog AndroidDeviceCatalog { get; set; }

        /// <summary>The IP blocks used by devices in the test environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIpBlockCatalog")]
        public virtual DeviceIpBlockCatalog DeviceIpBlockCatalog { get; set; }

        /// <summary>Supported iOS devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosDeviceCatalog")]
        public virtual IosDeviceCatalog IosDeviceCatalog { get; set; }

        /// <summary>Supported network configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfigurationCatalog")]
        public virtual NetworkConfigurationCatalog NetworkConfigurationCatalog { get; set; }

        /// <summary>The software test environment provided by TestExecutionService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareCatalog")]
        public virtual ProvidedSoftwareCatalog SoftwareCatalog { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single test executed in a single environment.</summary>
    public class TestExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. How the host machine(s) are configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>Output only. Unique id set by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Id of the containing TestMatrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matrixId")]
        public virtual string MatrixId { get; set; }

        /// <summary>Output only. The cloud project that owns the test execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. Details about the shard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shard")]
        public virtual Shard Shard { get; set; }

        /// <summary>Output only. Indicates the current progress of the test execution (e.g., FINISHED).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Additional details about the running test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testDetails")]
        public virtual TestDetails TestDetails { get; set; }

        /// <summary>Output only. How to run the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSpecification")]
        public virtual TestSpecification TestSpecification { get; set; }

        /// <summary>Output only. The time this test execution was initially created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>Output only. Where the results for this execution are written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResultsStep")]
        public virtual ToolResultsStep ToolResultsStep { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TestMatrix captures all details about a test. It contains the environment configuration, test specification,
    /// test executions and overall state and outcome.
    /// </summary>
    public class TestMatrix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the client which invoked the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientInfo")]
        public virtual ClientInfo ClientInfo { get; set; }

        /// <summary>Required. The devices the tests are being executed on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentMatrix")]
        public virtual EnvironmentMatrix EnvironmentMatrix { get; set; }

        /// <summary>
        /// If true, only a single attempt at most will be made to run each execution/shard in the matrix. Flaky test
        /// attempts are not affected. Normally, 2 or more attempts are made if a potential infrastructure issue is
        /// detected. This feature is for latency sensitive workloads. The incidence of execution failures may be
        /// significantly greater for fail-fast matrices and support is more limited because of that expectation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failFast")]
        public virtual System.Nullable<bool> FailFast { get; set; }

        /// <summary>
        /// The number of times a TestExecution should be re-attempted if one or more of its test cases fail for any
        /// reason. The maximum number of reruns allowed is 10. Default is 0, which implies no reruns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flakyTestAttempts")]
        public virtual System.Nullable<int> FlakyTestAttempts { get; set; }

        /// <summary>
        /// Output only. Describes why the matrix is considered invalid. Only useful for matrices in the INVALID state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidMatrixDetails")]
        public virtual string InvalidMatrixDetails { get; set; }

        /// <summary>
        /// Output Only. The overall outcome of the test. Only set when the test matrix state is FINISHED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcomeSummary")]
        public virtual string OutcomeSummary { get; set; }

        /// <summary>The cloud project that owns the test matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. Where the results for the matrix are written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultStorage")]
        public virtual ResultStorage ResultStorage { get; set; }

        /// <summary>Output only. Indicates the current progress of the test matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The list of test executions that the service creates for this matrix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testExecutions")]
        public virtual System.Collections.Generic.IList<TestExecution> TestExecutions { get; set; }

        /// <summary>Output only. Unique id set by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testMatrixId")]
        public virtual string TestMatrixId { get; set; }

        /// <summary>Required. How to run the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSpecification")]
        public virtual TestSpecification TestSpecification { get; set; }

        /// <summary>Output only. The time this test matrix was initially created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of how to set up the Android device prior to running the test.</summary>
    public class TestSetup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device will be logged in on this account for the duration of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual Account Account { get; set; }

        /// <summary>APKs to install in addition to those being directly tested. Currently capped at 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalApks")]
        public virtual System.Collections.Generic.IList<Apk> AdditionalApks { get; set; }

        /// <summary>
        /// List of directories on the device to upload to GCS at the end of the test; they must be absolute paths under
        /// /sdcard, /storage or /data/local/tmp. Path names are restricted to characters a-z A-Z 0-9 _ - . + and /
        /// Note: The paths /sdcard and /data will be made available and treated as implicit path substitutions. E.g. if
        /// /sdcard on a particular device does not map to external storage, the system will replace it with the
        /// external storage path prefix for that device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directoriesToPull")]
        public virtual System.Collections.Generic.IList<string> DirectoriesToPull { get; set; }

        /// <summary>Whether to prevent all runtime permissions to be granted at app install</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dontAutograntPermissions")]
        public virtual System.Nullable<bool> DontAutograntPermissions { get; set; }

        /// <summary>Environment variables to set for the test (only applicable for instrumentation tests).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IList<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>List of files to push to the device before starting the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesToPush")]
        public virtual System.Collections.Generic.IList<DeviceFile> FilesToPush { get; set; }

        /// <summary>
        /// The network traffic profile used for running the test. Available network profiles can be queried by using
        /// the NETWORK_CONFIGURATION environment type when calling
        /// TestEnvironmentDiscoveryService.GetTestEnvironmentCatalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkProfile")]
        public virtual string NetworkProfile { get; set; }

        /// <summary>
        /// Deprecated: Systrace uses Python 2 which has been sunset 2020-01-01. Support of Systrace may stop at any
        /// time, at which point no Systrace file will be provided in the results. Systrace configuration for the run.
        /// If set a systrace will be taken, starting on test start and lasting for the configured duration. The
        /// systrace file thus obtained is put in the results bucket together with the other artifacts from the run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systrace")]
        public virtual SystraceSetup Systrace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of how to run the test.</summary>
    public class TestSpecification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Android instrumentation test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInstrumentationTest")]
        public virtual AndroidInstrumentationTest AndroidInstrumentationTest { get; set; }

        /// <summary>An Android robo test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidRoboTest")]
        public virtual AndroidRoboTest AndroidRoboTest { get; set; }

        /// <summary>An Android Application with a Test Loop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidTestLoop")]
        public virtual AndroidTestLoop AndroidTestLoop { get; set; }

        /// <summary>Disables performance metrics recording. May reduce test latency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePerformanceMetrics")]
        public virtual System.Nullable<bool> DisablePerformanceMetrics { get; set; }

        /// <summary>Disables video recording. May reduce test latency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableVideoRecording")]
        public virtual System.Nullable<bool> DisableVideoRecording { get; set; }

        /// <summary>An iOS application with a test loop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosTestLoop")]
        public virtual IosTestLoop IosTestLoop { get; set; }

        /// <summary>Test setup requirements for iOS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosTestSetup")]
        public virtual IosTestSetup IosTestSetup { get; set; }

        /// <summary>An iOS XCTest, via an .xctestrun file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosXcTest")]
        public virtual IosXcTest IosXcTest { get; set; }

        /// <summary>Test setup requirements for Android e.g. files to install, bootstrap scripts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testSetup")]
        public virtual TestSetup TestSetup { get; set; }

        /// <summary>
        /// Max time a test execution is allowed to run before it is automatically cancelled. The default value is 5
        /// min.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTimeout")]
        public virtual object TestTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Test targets for a shard.</summary>
    public class TestTargetsForShard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group of packages, classes, and/or test methods to be run for each shard. The targets need to be specified
        /// in AndroidJUnitRunner argument format. For example, "package com.my.packages" "class
        /// com.my.package.MyClass". The number of shard_test_targets must be greater than 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargets")]
        public virtual System.Collections.Generic.IList<string> TestTargets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a tool results execution resource. This has the results of a TestMatrix.</summary>
    public class ToolResultsExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A tool results execution ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>Output only. A tool results history ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; }

        /// <summary>Output only. The cloud project that owns the tool results execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a tool results history resource.</summary>
    public class ToolResultsHistory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A tool results history ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; }

        /// <summary>Required. The cloud project that owns the tool results history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a tool results step resource. This has the results of a TestExecution.</summary>
    public class ToolResultsStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A tool results execution ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>Output only. A tool results history ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historyId")]
        public virtual string HistoryId { get; set; }

        /// <summary>Output only. The cloud project that owns the tool results step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Output only. A tool results step ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepId")]
        public virtual string StepId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network emulation parameters.</summary>
    public class TrafficRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bandwidth in kbits/second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidth")]
        public virtual System.Nullable<float> Bandwidth { get; set; }

        /// <summary>Burst size in kbits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("burst")]
        public virtual System.Nullable<float> Burst { get; set; }

        /// <summary>Packet delay, must be &gt;= 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delay")]
        public virtual object Delay { get; set; }

        /// <summary>Packet duplication ratio (0.0 - 1.0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packetDuplicationRatio")]
        public virtual System.Nullable<float> PacketDuplicationRatio { get; set; }

        /// <summary>Packet loss ratio (0.0 - 1.0).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packetLossRatio")]
        public virtual System.Nullable<float> PacketLossRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Uniformly shards test cases given a total number of shards. For Instrumentation test, it will be translated to
    /// "-e numShard" "-e shardIndex" AndroidJUnitRunner arguments. With uniform sharding enabled, specifying these
    /// sharding arguments via environment_variables is invalid.
    /// </summary>
    public class UniformSharding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Total number of shards. When any physical devices are selected, the number must be &amp;gt;= 1 and
        /// &amp;lt;= 50. When no physical devices are selected, the number must be &amp;gt;= 1 and &amp;lt;= 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numShards")]
        public virtual System.Nullable<int> NumShards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Xcode version that an iOS version is compatible with.</summary>
    public class XcodeVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tags for this Xcode version. Example: "default".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The id for this version. Example: "9.2".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
