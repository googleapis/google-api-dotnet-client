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

namespace Google.Apis.ServiceManagement.v1
{
    /// <summary>The ServiceManagement Service.</summary>
    public class ServiceManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ServiceManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ServiceManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Services = new ServicesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "servicemanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://servicemanagement.googleapis.com/";
        #else
            "https://servicemanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://servicemanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Service Management API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your Google API service configuration</summary>
            public static string ServiceManagement = "https://www.googleapis.com/auth/service.management";

            /// <summary>View your Google API service configuration</summary>
            public static string ServiceManagementReadonly = "https://www.googleapis.com/auth/service.management.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Service Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your Google API service configuration</summary>
            public const string ServiceManagement = "https://www.googleapis.com/auth/service.management";

            /// <summary>View your Google API service configuration</summary>
            public const string ServiceManagementReadonly = "https://www.googleapis.com/auth/service.management.readonly";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }
    }

    /// <summary>A base abstract class for ServiceManagement requests.</summary>
    public abstract class ServiceManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ServiceManagementBaseServiceRequest instance.</summary>
        protected ServiceManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ServiceManagement parameter list.</summary>
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
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>Lists service operations that match the specified filter in the request.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists service operations that match the specified filter in the request.</summary>
        public class ListRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// A string for filtering Operations. The following filter fields are supported: * serviceName: Required.
            /// Only `=` operator is allowed. * startTime: The time this job was started, in ISO 8601 format. Allowed
            /// operators are `&amp;gt;=`, `&amp;gt;`, `&amp;lt;=`, and `&amp;lt;`. * status: Can be `done`,
            /// `in_progress`, or `failed`. Allowed operators are `=`, and `!=`. Filter expression supports conjunction
            /// (AND) and disjunction (OR) logical operators. However, the serviceName restriction must be at the
            /// top-level and can only be combined with other restrictions via the AND logical operator. Examples: *
            /// `serviceName={some-service}.googleapis.com` * `serviceName={some-service}.googleapis.com AND
            /// startTime&amp;gt;="2017-02-01"` * `serviceName={some-service}.googleapis.com AND status=done` *
            /// `serviceName={some-service}.googleapis.com AND (status=done OR startTime&amp;gt;="2017-02-01")`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>Not used.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>
            /// The maximum number of operations to return. If unspecified, defaults to 50. The maximum value is 100.
            /// </summary>
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
            public override string RestPath => "v1/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
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

    /// <summary>The "services" collection of methods.</summary>
    public class ServicesResource
    {
        private const string Resource = "services";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ServicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Configs = new ConfigsResource(service);
            Consumers = new ConsumersResource(service);
            Rollouts = new RolloutsResource(service);
        }

        /// <summary>Gets the Configs resource.</summary>
        public virtual ConfigsResource Configs { get; }

        /// <summary>The "configs" collection of methods.</summary>
        public class ConfigsResource
        {
            private const string Resource = "configs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new service configuration (version) for a managed service. This method only stores the service
            /// configuration. To roll out the service configuration to backend systems please call
            /// CreateServiceRollout. Only the 100 most recent service configurations and ones referenced by existing
            /// rollouts are kept for each service. The rest will be deleted eventually.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.ServiceManagement.v1.Data.Service body, string serviceName)
            {
                return new CreateRequest(service, body, serviceName);
            }

            /// <summary>
            /// Creates a new service configuration (version) for a managed service. This method only stores the service
            /// configuration. To roll out the service configuration to backend systems please call
            /// CreateServiceRollout. Only the 100 most recent service configurations and ones referenced by existing
            /// rollouts are kept for each service. The rest will be deleted eventually.
            /// </summary>
            public class CreateRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Service>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.Service body, string serviceName) : base(service)
                {
                    ServiceName = serviceName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.Service Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/configs";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a service configuration (version) for a managed service.</summary>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            /// <param name="configId">
            /// Required. The id of the service configuration resource. This field must be specified for the server to
            /// return all fields, including `SourceInfo`.
            /// </param>
            public virtual GetRequest Get(string serviceName, string configId)
            {
                return new GetRequest(service, serviceName, configId);
            }

            /// <summary>Gets a service configuration (version) for a managed service.</summary>
            public class GetRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Service>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string serviceName, string configId) : base(service)
                {
                    ServiceName = serviceName;
                    ConfigId = configId;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>
                /// Required. The id of the service configuration resource. This field must be specified for the server
                /// to return all fields, including `SourceInfo`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ConfigId { get; private set; }

                /// <summary>Specifies which parts of the Service Config should be returned in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Specifies which parts of the Service Config should be returned in the response.</summary>
                public enum ViewEnum
                {
                    /// <summary>Server response includes all fields except SourceInfo.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC = 0,

                    /// <summary>
                    /// Server response includes all fields including SourceInfo. SourceFiles are of type
                    /// 'google.api.servicemanagement.v1.ConfigFile' and are only available for configs created using
                    /// the SubmitConfigSource method.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/configs/{configId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
                        IsRequired = true,
                        ParameterType = "path",
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

            /// <summary>
            /// Lists the history of the service configuration for a managed service, from the newest to the oldest.
            /// </summary>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            public virtual ListRequest List(string serviceName)
            {
                return new ListRequest(service, serviceName);
            }

            /// <summary>
            /// Lists the history of the service configuration for a managed service, from the newest to the oldest.
            /// </summary>
            public class ListRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.ListServiceConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
                {
                    ServiceName = serviceName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>
                /// The max number of items to include in the response list. Page size is 50 if not specified. Maximum
                /// value is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token of the page to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/configs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
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
            /// Creates a new service configuration (version) for a managed service based on user-supplied configuration
            /// source files (for example: OpenAPI Specification). This method stores the source configurations as well
            /// as the generated service configuration. To rollout the service configuration to other services, please
            /// call CreateServiceRollout. Only the 100 most recent configuration sources and ones referenced by
            /// existing service configurtions are kept for each service. The rest will be deleted eventually. Operation
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            public virtual SubmitRequest Submit(Google.Apis.ServiceManagement.v1.Data.SubmitConfigSourceRequest body, string serviceName)
            {
                return new SubmitRequest(service, body, serviceName);
            }

            /// <summary>
            /// Creates a new service configuration (version) for a managed service based on user-supplied configuration
            /// source files (for example: OpenAPI Specification). This method stores the source configurations as well
            /// as the generated service configuration. To rollout the service configuration to other services, please
            /// call CreateServiceRollout. Only the 100 most recent configuration sources and ones referenced by
            /// existing service configurtions are kept for each service. The rest will be deleted eventually. Operation
            /// </summary>
            public class SubmitRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
            {
                /// <summary>Constructs a new Submit request.</summary>
                public SubmitRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.SubmitConfigSourceRequest body, string serviceName) : base(service)
                {
                    ServiceName = serviceName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.SubmitConfigSourceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "submit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/configs:submit";

                /// <summary>Initializes Submit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Consumers resource.</summary>
        public virtual ConsumersResource Consumers { get; }

        /// <summary>The "consumers" collection of methods.</summary>
        public class ConsumersResource
        {
            private const string Resource = "consumers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConsumersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

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
                        Pattern = @"^services/[^/]+/consumers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^services/[^/]+/consumers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^services/[^/]+/consumers/[^/]+$",
                    });
                }
            }
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
            }

            /// <summary>
            /// Creates a new service configuration rollout. Based on rollout, the Google Service Management will roll
            /// out the service configurations to different backend services. For example, the logging configuration
            /// will be pushed to Google Cloud Logging. Please note that any previous pending and running Rollouts and
            /// associated Operations will be automatically cancelled so that the latest Rollout will not be blocked by
            /// previous Rollouts. Only the 100 most recent (in any state) and the last 10 successful (if not already
            /// part of the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
            /// eventually. Operation
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.ServiceManagement.v1.Data.Rollout body, string serviceName)
            {
                return new CreateRequest(service, body, serviceName);
            }

            /// <summary>
            /// Creates a new service configuration rollout. Based on rollout, the Google Service Management will roll
            /// out the service configurations to different backend services. For example, the logging configuration
            /// will be pushed to Google Cloud Logging. Please note that any previous pending and running Rollouts and
            /// associated Operations will be automatically cancelled so that the latest Rollout will not be blocked by
            /// previous Rollouts. Only the 100 most recent (in any state) and the last 10 successful (if not already
            /// part of the set of 100 most recent) rollouts are kept for each service. The rest will be deleted
            /// eventually. Operation
            /// </summary>
            public class CreateRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.Rollout body, string serviceName) : base(service)
                {
                    ServiceName = serviceName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ServiceManagement.v1.Data.Rollout Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/rollouts";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a service configuration rollout.</summary>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            /// <param name="rolloutId">Required. The id of the rollout resource.</param>
            public virtual GetRequest Get(string serviceName, string rolloutId)
            {
                return new GetRequest(service, serviceName, rolloutId);
            }

            /// <summary>Gets a service configuration rollout.</summary>
            public class GetRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Rollout>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string serviceName, string rolloutId) : base(service)
                {
                    ServiceName = serviceName;
                    RolloutId = rolloutId;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>Required. The id of the rollout resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("rolloutId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string RolloutId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/rollouts/{rolloutId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("rolloutId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "rolloutId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists the history of the service configuration rollouts for a managed service, from the newest to the
            /// oldest.
            /// </summary>
            /// <param name="serviceName">
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </param>
            public virtual ListRequest List(string serviceName)
            {
                return new ListRequest(service, serviceName);
            }

            /// <summary>
            /// Lists the history of the service configuration rollouts for a managed service, from the newest to the
            /// oldest.
            /// </summary>
            public class ListRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.ListServiceRolloutsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
                {
                    ServiceName = serviceName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the service. See the [overview](/service-management/overview) for naming
                /// requirements. For example: `example.googleapis.com`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServiceName { get; private set; }

                /// <summary>
                /// Required. Use `filter` to return subset of rollouts. The following filters are supported: -- To
                /// limit the results to only those in [status](google.api.servicemanagement.v1.RolloutStatus)
                /// 'SUCCESS', use filter='status=SUCCESS' -- To limit the results to those in
                /// [status](google.api.servicemanagement.v1.RolloutStatus) 'CANCELLED' or 'FAILED', use
                /// filter='status=CANCELLED OR status=FAILED'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The max number of items to include in the response list. Page size is 50 if not specified. Maximum
                /// value is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The token of the page to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/services/{serviceName}/rollouts";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceName",
                        IsRequired = true,
                        ParameterType = "path",
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
        }

        /// <summary>
        /// Creates a new managed service. A managed service is immutable, and is subject to mandatory 30-day data
        /// retention. You cannot move a service or recreate it within 30 days after deletion. One producer project can
        /// own no more than 500 services. For security and reliability purposes, a production service should be hosted
        /// in a dedicated producer project. Operation
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.ServiceManagement.v1.Data.ManagedService body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a new managed service. A managed service is immutable, and is subject to mandatory 30-day data
        /// retention. You cannot move a service or recreate it within 30 days after deletion. One producer project can
        /// own no more than 500 services. For security and reliability purposes, a production service should be hosted
        /// in a dedicated producer project. Operation
        /// </summary>
        public class CreateRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.ManagedService body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceManagement.v1.Data.ManagedService Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes a managed service. This method will change the service to the `Soft-Delete` state for 30 days.
        /// Within this period, service producers may call UndeleteService to restore the service. After 30 days, the
        /// service will be permanently deleted. Operation
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the [overview](/service-management/overview) for naming requirements.
        /// For example: `example.googleapis.com`.
        /// </param>
        public virtual DeleteRequest Delete(string serviceName)
        {
            return new DeleteRequest(service, serviceName);
        }

        /// <summary>
        /// Deletes a managed service. This method will change the service to the `Soft-Delete` state for 30 days.
        /// Within this period, service producers may call UndeleteService to restore the service. After 30 days, the
        /// service will be permanently deleted. Operation
        /// </summary>
        public class DeleteRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from existing configurations) associated with
        /// GenerateConfigReportRequest.new_value If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the comparison between
        /// GenerateConfigReportRequest.new_value and GenerateConfigReportRequest.old_value. If
        /// GenerateConfigReportRequest.old_value is not specified, this method will compare
        /// GenerateConfigReportRequest.new_value with the last pushed service configuration.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual GenerateConfigReportRequest GenerateConfigReport(Google.Apis.ServiceManagement.v1.Data.GenerateConfigReportRequest body)
        {
            return new GenerateConfigReportRequest(service, body);
        }

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from existing configurations) associated with
        /// GenerateConfigReportRequest.new_value If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the comparison between
        /// GenerateConfigReportRequest.new_value and GenerateConfigReportRequest.old_value. If
        /// GenerateConfigReportRequest.old_value is not specified, this method will compare
        /// GenerateConfigReportRequest.new_value with the last pushed service configuration.
        /// </summary>
        public class GenerateConfigReportRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.GenerateConfigReportResponse>
        {
            /// <summary>Constructs a new GenerateConfigReport request.</summary>
            public GenerateConfigReportRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.GenerateConfigReportRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceManagement.v1.Data.GenerateConfigReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateConfigReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services:generateConfigReport";

            /// <summary>Initializes GenerateConfigReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets a managed service. Authentication is required unless the service is public.</summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the `ServiceManager` overview for naming requirements. For example:
        /// `example.googleapis.com`.
        /// </param>
        public virtual GetRequest Get(string serviceName)
        {
            return new GetRequest(service, serviceName);
        }

        /// <summary>Gets a managed service. Authentication is required unless the service is public.</summary>
        public class GetRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.ManagedService>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the service. See the `ServiceManager` overview for naming requirements. For
            /// example: `example.googleapis.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a service configuration (version) for a managed service.</summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the [overview](/service-management/overview) for naming requirements.
        /// For example: `example.googleapis.com`.
        /// </param>
        public virtual GetConfigRequest GetConfig(string serviceName)
        {
            return new GetConfigRequest(service, serviceName);
        }

        /// <summary>Gets a service configuration (version) for a managed service.</summary>
        public class GetConfigRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Service>
        {
            /// <summary>Constructs a new GetConfig request.</summary>
            public GetConfigRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>
            /// Required. The id of the service configuration resource. This field must be specified for the server to
            /// return all fields, including `SourceInfo`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ConfigId { get; set; }

            /// <summary>Specifies which parts of the Service Config should be returned in the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Specifies which parts of the Service Config should be returned in the response.</summary>
            public enum ViewEnum
            {
                /// <summary>Server response includes all fields except SourceInfo.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 0,

                /// <summary>
                /// Server response includes all fields including SourceInfo. SourceFiles are of type
                /// 'google.api.servicemanagement.v1.ConfigFile' and are only available for configs created using the
                /// SubmitConfigSource method.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}/config";

            /// <summary>Initializes GetConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
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

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does not
        /// have a policy set.
        /// </summary>
        public class GetIamPolicyRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceManagement.v1.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

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
                    Pattern = @"^services/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists managed services. Returns all public services. For authenticated users, also returns all services the
        /// calling user has "servicemanagement.services.get" permission for.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists managed services. Returns all public services. For authenticated users, also returns all services the
        /// calling user has "servicemanagement.services.get" permission for.
        /// </summary>
        public class ListRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.ListServicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Include services consumed by the specified consumer. The Google Service Management implementation
            /// accepts the following forms: - project:
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("consumerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ConsumerId { get; set; }

            /// <summary>
            /// The max number of items to include in the response list. Page size is 50 if not specified. Maximum value
            /// is 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Token identifying which result to start with; returned by a previous list call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Include services produced by the specified project.</summary>
            [Google.Apis.Util.RequestParameterAttribute("producerProjectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProducerProjectId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("consumerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "consumerId",
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
                RequestParameters.Add("producerProjectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "producerProjectId",
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
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
        /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        public class SetIamPolicyRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceManagement.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                    Pattern = @"^services/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this will
        /// return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be used for
        /// building permission-aware UIs and command-line tools, not for authorization checking. This operation may
        /// "fail open" without warning.
        /// </summary>
        public class TestIamPermissionsRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceManagement.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                    Pattern = @"^services/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the service using the configuration at the
        /// time the service was deleted. The target service must exist and must have been deleted within the last 30
        /// days. Operation
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the [overview](/service-management/overview) for naming requirements.
        /// For example: `example.googleapis.com`.
        /// </param>
        public virtual UndeleteRequest Undelete(string serviceName)
        {
            return new UndeleteRequest(service, serviceName);
        }

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the service using the configuration at the
        /// time the service was deleted. The target service must exist and must have been deleted within the last 30
        /// days. Operation
        /// </summary>
        public class UndeleteRequest : ServiceManagementBaseServiceRequest<Google.Apis.ServiceManagement.v1.Data.Operation>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the service. See the [overview](/service-management/overview) for naming
            /// requirements. For example: `example.googleapis.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.ServiceManagement.v1.Data
{
    /// <summary>
    /// Generated advice about this change, used for providing more information about how a change will affect the
    /// existing service.
    /// </summary>
    public class Advice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Useful description for why this advice was applied and what actions should be taken to mitigate any implied
        /// risks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Api is a light-weight descriptor for an API Interface. Interfaces are also described as "protocol buffer
    /// services" in some contexts, such as by the "service" keyword in a .proto file, but they are different from API
    /// Services, which represent a concrete implementation of an interface as opposed to simply a description of
    /// methods and bindings. They are also sometimes simply referred to as "APIs" in other contexts, such as the name
    /// of this message itself. See https://cloud.google.com/apis/design/glossary for detailed terminology.
    /// </summary>
    public class Api : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The methods of this interface, in unspecified order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methods")]
        public virtual System.Collections.Generic.IList<Method> Methods { get; set; }

        /// <summary>Included interfaces. See Mixin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mixins")]
        public virtual System.Collections.Generic.IList<Mixin> Mixins { get; set; }

        /// <summary>
        /// The fully qualified name of this interface, including package name followed by the interface's simple name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Any metadata attached to the interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>Source context for the protocol buffer service represented by this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContext")]
        public virtual SourceContext SourceContext { get; set; }

        /// <summary>The source syntax of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>
        /// A version string for this interface. If specified, must have the form `major-version.minor-version`, as in
        /// `1.10`. If the minor version is omitted, it defaults to zero. If the entire version field is empty, the
        /// major version is derived from the package name, as outlined below. If the field is not empty, the version in
        /// the package name will be verified to be consistent with what is provided here. The versioning schema uses
        /// [semantic versioning](http://semver.org) where the major version number indicates a breaking change and the
        /// minor version an additive, non-breaking change. Both version numbers are signals to users what to expect
        /// from different versions, and should be carefully chosen based on the product plan. The major version is also
        /// reflected in the package name of the interface, which must end in `v`, as in `google.feature.v1`. For major
        /// versions 0 and 1, the suffix can be omitted. Zero major versions must only be used for experimental, non-GA
        /// interfaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
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
    /// Configuration for an authentication provider, including support for [JSON Web Token
    /// (JWT)](https://tools.ietf.org/html/draft-ietf-oauth-json-web-token-32).
    /// </summary>
    public class AuthProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of JWT [audiences](https://tools.ietf.org/html/draft-ietf-oauth-json-web-token-32#section-4.1.3).
        /// that are allowed to access. A JWT containing any of these audiences will be accepted. When this setting is
        /// absent, JWTs with audiences: - "https://[service.name]/[google.protobuf.Api.name]" -
        /// "https://[service.name]/" will be accepted. For example, if no audiences are in the setting, LibraryService
        /// API will accept JWTs with the following audiences: -
        /// https://library-example.googleapis.com/google.example.library.v1.LibraryService -
        /// https://library-example.googleapis.com/ Example: audiences: bookstore_android.apps.googleusercontent.com,
        /// bookstore_web.apps.googleusercontent.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual string Audiences { get; set; }

        /// <summary>
        /// Redirect URL if JWT token is required but not present or is expired. Implement authorizationUrl of
        /// securityDefinitions in OpenAPI spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationUrl")]
        public virtual string AuthorizationUrl { get; set; }

        /// <summary>
        /// The unique identifier of the auth provider. It will be referred to by `AuthRequirement.provider_id`.
        /// Example: "bookstore_auth".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies the principal that issued the JWT. See
        /// https://tools.ietf.org/html/draft-ietf-oauth-json-web-token-32#section-4.1.1 Usually a URL or an email
        /// address. Example: https://securetoken.google.com Example: 1234567-compute@developer.gserviceaccount.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>
        /// URL of the provider's public key set to validate signature of the JWT. See [OpenID
        /// Discovery](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata). Optional if the key
        /// set document: - can be retrieved from [OpenID
        /// Discovery](https://openid.net/specs/openid-connect-discovery-1_0.html) of the issuer. - can be inferred from
        /// the email domain of the issuer (e.g. a Google service account). Example:
        /// https://www.googleapis.com/oauth2/v1/certs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwksUri")]
        public virtual string JwksUri { get; set; }

        /// <summary>
        /// Defines the locations to extract the JWT. JWT locations can be either from HTTP headers or URL query
        /// parameters. The rule is that the first match wins. The checking order is: checking all headers first, then
        /// URL query parameters. If not specified, default to use following 3 locations: 1) Authorization: Bearer 2)
        /// x-goog-iap-jwt-assertion 3) access_token query parameter Default locations can be specified as followings:
        /// jwt_locations: - header: Authorization value_prefix: "Bearer " - header: x-goog-iap-jwt-assertion - query:
        /// access_token
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtLocations")]
        public virtual System.Collections.Generic.IList<JwtLocation> JwtLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User-defined authentication requirements, including support for [JSON Web Token
    /// (JWT)](https://tools.ietf.org/html/draft-ietf-oauth-json-web-token-32).
    /// </summary>
    public class AuthRequirement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// NOTE: This will be deprecated soon, once AuthProvider.audiences is implemented and accepted in all the
        /// runtime components. The list of JWT
        /// [audiences](https://tools.ietf.org/html/draft-ietf-oauth-json-web-token-32#section-4.1.3). that are allowed
        /// to access. A JWT containing any of these audiences will be accepted. When this setting is absent, only JWTs
        /// with audience "https://Service_name/API_name" will be accepted. For example, if no audiences are in the
        /// setting, LibraryService API will only accept JWTs with the following audience
        /// "https://library-example.googleapis.com/google.example.library.v1.LibraryService". Example: audiences:
        /// bookstore_android.apps.googleusercontent.com, bookstore_web.apps.googleusercontent.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual string Audiences { get; set; }

        /// <summary>id from authentication provider. Example: provider_id: bookstore_auth</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerId")]
        public virtual string ProviderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Authentication` defines the authentication configuration for API methods provided by an API service. Example:
    /// name: calendar.googleapis.com authentication: providers: - id: google_calendar_auth jwks_uri:
    /// https://www.googleapis.com/oauth2/v1/certs issuer: https://securetoken.google.com rules: - selector: "*"
    /// requirements: provider_id: google_calendar_auth - selector: google.calendar.Delegate oauth: canonical_scopes:
    /// https://www.googleapis.com/auth/calendar.read
    /// </summary>
    public class Authentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines a set of authentication providers that a service supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providers")]
        public virtual System.Collections.Generic.IList<AuthProvider> Providers { get; set; }

        /// <summary>
        /// A list of authentication rules that apply to individual API methods. **NOTE:** All service configuration
        /// rules follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<AuthenticationRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Authentication rules for the service. By default, if a method has any authentication requirements, every request
    /// must include a valid credential matching one of the requirements. It's an error to include more than one kind of
    /// credential in a single request. If a method doesn't have any auth requirements, request credentials will be
    /// ignored.
    /// </summary>
    public class AuthenticationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the service accepts API keys without any other credential. This flag only applies to HTTP and gRPC
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowWithoutCredential")]
        public virtual System.Nullable<bool> AllowWithoutCredential { get; set; }

        /// <summary>The requirements for OAuth credentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth")]
        public virtual OAuthRequirements Oauth { get; set; }

        /// <summary>Requirements for additional authentication providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirements")]
        public virtual System.Collections.Generic.IList<AuthRequirement> Requirements { get; set; }

        /// <summary>Selects the methods to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`Backend` defines the backend configuration for a service.</summary>
    public class Backend : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of API backend rules that apply to individual API methods. **NOTE:** All service configuration rules
        /// follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<BackendRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A backend rule provides configuration for an individual API element.</summary>
    public class BackendRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The address of the API backend. The scheme is used to determine the backend protocol and security. The
        /// following schemes are accepted: SCHEME PROTOCOL SECURITY http:// HTTP None https:// HTTP TLS grpc:// gRPC
        /// None grpcs:// gRPC TLS It is recommended to explicitly include a scheme. Leaving out the scheme may cause
        /// constrasting behaviors across platforms. If the port is unspecified, the default is: - 80 for schemes
        /// without TLS - 443 for schemes with TLS For HTTP backends, use protocol to specify the protocol version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// The number of seconds to wait for a response from a request. The default varies based on the request
        /// protocol and deployment environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadline")]
        public virtual System.Nullable<double> Deadline { get; set; }

        /// <summary>
        /// When disable_auth is true, a JWT ID token won't be generated and the original "Authorization" HTTP header
        /// will be preserved. If the header is used to carry the original token and is expected by the backend, this
        /// field must be set to true to preserve the header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAuth")]
        public virtual System.Nullable<bool> DisableAuth { get; set; }

        /// <summary>
        /// The JWT audience is used when generating a JWT ID token for the backend. This ID token will be added in the
        /// HTTP "authorization" header, and sent to the backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtAudience")]
        public virtual string JwtAudience { get; set; }

        /// <summary>
        /// The number of seconds to wait for the completion of a long running operation. The default is no deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationDeadline")]
        public virtual System.Nullable<double> OperationDeadline { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pathTranslation")]
        public virtual string PathTranslation { get; set; }

        /// <summary>
        /// The protocol used for sending a request to the backend. The supported values are "http/1.1" and "h2". The
        /// default value is inferred from the scheme in the address field: SCHEME PROTOCOL http:// http/1.1 https://
        /// http/1.1 grpc:// h2 grpcs:// h2 For secure HTTP backends (https://) that support HTTP/2, set this field to
        /// "h2" for improved performance. Configuring this field to non-default values is only supported for secure
        /// HTTP backends. This field will be ignored for all other backends. See
        /// https://www.iana.org/assignments/tls-extensiontype-values/tls-extensiontype-values.xhtml#alpn-protocol-ids
        /// for more details on the supported values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Selects the methods to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Billing related configuration of the service. The following example shows how to configure monitored resources
    /// and metrics for billing, `consumer_destinations` is the only supported destination and the monitored resources
    /// need at least one label key `cloud.googleapis.com/location` to indicate the location of the billing usage, using
    /// different monitored resources between monitoring and billing is recommended so they can be evolved
    /// independently: monitored_resources: - type: library.googleapis.com/billing_branch labels: - key:
    /// cloud.googleapis.com/location description: | Predefined label to support billing location restriction. - key:
    /// city description: | Custom label to define the city where the library branch is located in. - key: name
    /// description: Custom label to define the name of the library branch. metrics: - name:
    /// library.googleapis.com/book/borrowed_count metric_kind: DELTA value_type: INT64 unit: "1" billing:
    /// consumer_destinations: - monitored_resource: library.googleapis.com/billing_branch metrics: -
    /// library.googleapis.com/book/borrowed_count
    /// </summary>
    public class Billing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Billing configurations for sending metrics to the consumer project. There can be multiple consumer
        /// destinations per service, each one must have a different monitored resource type. A metric can be used in at
        /// most one consumer destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDestinations")]
        public virtual System.Collections.Generic.IList<BillingDestination> ConsumerDestinations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration of a specific billing destination (Currently only support bill against consumer project).
    /// </summary>
    public class BillingDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Names of the metrics to report to this billing destination. Each name must be defined in Service.metrics
        /// section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// The monitored resource type. The type must be defined in Service.monitored_resources section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResource")]
        public virtual string MonitoredResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Change report associated with a particular service configuration. It contains a list of ConfigChanges based on
    /// the comparison between two service configurations.
    /// </summary>
    public class ChangeReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of changes between two service configurations. The changes will be alphabetically sorted based on the
        /// identifier of each change. A ConfigChange identifier is a dot separated path to the configuration. Example:
        /// visibility.rules[selector='LibraryService.CreateBook'].restriction
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configChanges")]
        public virtual System.Collections.Generic.IList<ConfigChange> ConfigChanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Output generated from semantically comparing two versions of a service configuration. Includes detailed
    /// information about a field that have changed with applicable advice about potential consequences for the change,
    /// such as backwards-incompatibility.
    /// </summary>
    public class ConfigChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Collection of advice provided for this change, useful for determining the possible impact of this change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advices")]
        public virtual System.Collections.Generic.IList<Advice> Advices { get; set; }

        /// <summary>The type for this change, either ADDED, REMOVED, or MODIFIED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeType")]
        public virtual string ChangeType { get; set; }

        /// <summary>
        /// Object hierarchy path to the change, with levels separated by a '.' character. For repeated fields, an
        /// applicable unique identifier field is used for the index (usually selector, name, or id). For maps, the term
        /// 'key' is used. If the field has no unique identifier, the numeric index is used. Examples: -
        /// visibility.rules[selector=="google.LibraryService.ListBooks"].restriction -
        /// quota.metric_rules[selector=="google"].metric_costs[key=="reads"].value - logging.producer_destinations[0]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("element")]
        public virtual string Element { get; set; }

        /// <summary>
        /// Value of the changed object in the new Service configuration, in JSON format. This field will not be
        /// populated if ChangeType == REMOVED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// Value of the changed object in the old Service configuration, in JSON format. This field will not be
        /// populated if ChangeType == ADDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic specification of a source configuration file</summary>
    public class ConfigFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bytes that constitute the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileContents")]
        public virtual string FileContents { get; set; }

        /// <summary>The file name of the configuration file (full or relative path).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The type of configuration file this represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileType")]
        public virtual string FileType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a service configuration with its name and id.</summary>
    public class ConfigRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of a service config. It must have the following format: "services/{service
        /// name}/configs/{config id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a source file which is used to generate the service configuration defined by `google.api.Service`.
    /// </summary>
    public class ConfigSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of source configuration files that are used to generate a service configuration (`google.api.Service`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<ConfigFile> Files { get; set; }

        /// <summary>
        /// A unique ID for a specific instance of this message, typically assigned by the client for tracking purpose.
        /// If empty, the server may choose to generate one instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Context` defines which contexts an API requests. Example: context: rules: - selector: "*" requested: -
    /// google.rpc.context.ProjectContext - google.rpc.context.OriginContext The above specifies that all methods in the
    /// API request `google.rpc.context.ProjectContext` and `google.rpc.context.OriginContext`. Available context types
    /// are defined in package `google.rpc.context`. This also provides mechanism to allowlist any protobuf message
    /// extension that can be sent in grpc metadata using “x-goog-ext--bin” and “x-goog-ext--jspb” format. For example,
    /// list any service specific protobuf types that can appear in grpc metadata as follows in your yaml file: Example:
    /// context: rules: - selector: "google.example.library.v1.LibraryService.CreateBook" allowed_request_extensions: -
    /// google.foo.v1.NewExtension allowed_response_extensions: - google.foo.v1.NewExtension You can also specify
    /// extension ID instead of fully qualified extension name here.
    /// </summary>
    public class Context : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of RPC context rules that apply to individual API methods. **NOTE:** All service configuration rules
        /// follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<ContextRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A context rule provides information about the context for an individual API element.</summary>
    public class ContextRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of full type names or extension IDs of extensions allowed in grpc side channel from client to
        /// backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedRequestExtensions")]
        public virtual System.Collections.Generic.IList<string> AllowedRequestExtensions { get; set; }

        /// <summary>
        /// A list of full type names or extension IDs of extensions allowed in grpc side channel from backend to
        /// client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedResponseExtensions")]
        public virtual System.Collections.Generic.IList<string> AllowedResponseExtensions { get; set; }

        /// <summary>A list of full type names of provided contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provided")]
        public virtual System.Collections.Generic.IList<string> Provided { get; set; }

        /// <summary>A list of full type names of requested contexts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requested")]
        public virtual System.Collections.Generic.IList<string> Requested { get; set; }

        /// <summary>Selects the methods to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selects and configures the service controller used by the service. The service controller handles features like
    /// abuse, quota, billing, logging, monitoring, etc.
    /// </summary>
    public class Control : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service control environment to use. If empty, no control plane feature (like quota and billing) will be
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Customize service error responses. For example, list any service specific protobuf types that can appear in
    /// error detail lists of error responses. Example: custom_error: types: - google.foo.v1.CustomError -
    /// google.foo.v1.AnotherError
    /// </summary>
    public class CustomError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of custom error rules that apply to individual API messages. **NOTE:** All service configuration
        /// rules follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<CustomErrorRule> Rules { get; set; }

        /// <summary>The list of custom error detail types, e.g. 'google.foo.v1.CustomError'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom error rule.</summary>
    public class CustomErrorRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mark this message as possible payload in error response. Otherwise, objects of this type will be filtered
        /// when they appear in error payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isErrorType")]
        public virtual System.Nullable<bool> IsErrorType { get; set; }

        /// <summary>Selects messages to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom pattern is used for defining custom HTTP verb.</summary>
    public class CustomHttpPattern : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of this custom HTTP verb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The path matched by this custom verb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Strategy used to delete a service. This strategy is a placeholder only used by the system generated rollout to
    /// delete a service.
    /// </summary>
    public class DeleteServiceStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a diagnostic message (error or warning)</summary>
    public class Diagnostic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of diagnostic information provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>File name and line number of the error or warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Message describing the error or warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Documentation` provides the information for describing a service. Example: documentation: summary: &amp;gt; The
    /// Google Calendar API gives access to most calendar features. pages: - name: Overview content: (== include
    /// google/foo/overview.md ==) - name: Tutorial content: (== include google/foo/tutorial.md ==) subpages; - name:
    /// Java content: (== include google/foo/tutorial_java.md ==) rules: - selector: google.calendar.Calendar.Get
    /// description: &amp;gt; ... - selector: google.calendar.Calendar.Put description: &amp;gt; ... Documentation is
    /// provided in markdown syntax. In addition to standard markdown features, definition lists, tables and fenced code
    /// blocks are supported. Section headers can be provided and are interpreted relative to the section nesting of the
    /// context where a documentation fragment is embedded. Documentation from the IDL is merged with documentation
    /// defined via the config at normalization time, where documentation provided by config rules overrides IDL
    /// provided. A number of constructs specific to the API platform are supported in documentation text. In order to
    /// reference a proto element, the following notation can be used: [fully.qualified.proto.name][] To override the
    /// display text used for the link, this can be used: [display text][fully.qualified.proto.name] Text can be
    /// excluded from doc using the following notation: (-- internal comment --) A few directives are available in
    /// documentation. Note that directives must appear on a single line to be properly identified. The `include`
    /// directive includes a markdown file from an external source: (== include path/to/file ==) The `resource_for`
    /// directive marks a message to be the resource of a collection in REST view. If it is not specified, tools attempt
    /// to infer the resource from the operations in a collection: (== resource_for v1.shelves.books ==) The directive
    /// `suppress_warning` does not directly affect documentation and is documented together with service config
    /// validation.
    /// </summary>
    public class Documentation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to the root of documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationRootUrl")]
        public virtual string DocumentationRootUrl { get; set; }

        /// <summary>
        /// Declares a single overview page. For example: documentation: summary: ... overview: (== include overview.md
        /// ==) This is a shortcut for the following declaration (using pages style): documentation: summary: ... pages:
        /// - name: Overview content: (== include overview.md ==) Note: you cannot specify both `overview` field and
        /// `pages` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual string Overview { get; set; }

        /// <summary>The top level pages for the documentation set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<Page> Pages { get; set; }

        /// <summary>
        /// A list of documentation rules that apply to individual API elements. **NOTE:** All service configuration
        /// rules follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<DocumentationRule> Rules { get; set; }

        /// <summary>
        /// Specifies the service root url if the default one (the service name from the yaml file) is not suitable.
        /// This can be seen in any fully specified service urls as well as sections that show a base that other urls
        /// are relative to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRootUrl")]
        public virtual string ServiceRootUrl { get; set; }

        /// <summary>
        /// A short description of what the service does. The summary must be plain text. It becomes the overview of the
        /// service displayed in Google Cloud Console. NOTE: This field is equivalent to the standard field
        /// `description`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A documentation rule provides information about individual API elements.</summary>
    public class DocumentationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecation description of the selected element(s). It can be provided if an element is marked as
        /// `deprecated`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecationDescription")]
        public virtual string DeprecationDescription { get; set; }

        /// <summary>
        /// The description is the comment in front of the selected proto element, such as a message, a method, a
        /// 'service' definition, or a field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The selector is a comma-separated list of patterns for any element such as a method, a field, an enum value.
        /// Each pattern is a qualified name of the element which may end in "*", indicating a wildcard. Wildcards are
        /// only allowed at the end and for a whole component of the qualified name, i.e. "foo.*" is ok, but not
        /// "foo.b*" or "foo.*.bar". A wildcard will match one or more components. To specify a default for all
        /// applicable elements, the whole pattern "*" is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation payload for EnableService method.</summary>
    public class EnableServiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Endpoint` describes a network address of a service that serves a set of APIs. It is commonly known as a service
    /// endpoint. A service may expose any number of service endpoints, and all service endpoints share the same service
    /// definition, such as quota limits and monitoring metrics. Example: type: google.api.Service name:
    /// library-example.googleapis.com endpoints: # Declares network address `https://library-example.googleapis.com` #
    /// for service `library-example.googleapis.com`. The `https` scheme # is implicit for all service endpoints. Other
    /// schemes may be # supported in the future. - name: library-example.googleapis.com allow_cors: false - name:
    /// content-staging-library-example.googleapis.com # Allows HTTP OPTIONS calls to be passed to the API frontend, for
    /// it # to decide whether the subsequent cross-origin request is allowed # to proceed. allow_cors: true
    /// </summary>
    public class Endpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Allowing [CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing), aka cross-domain traffic,
        /// would allow the backends served from this endpoint to receive and respond to HTTP OPTIONS requests. The
        /// response will be used by the browser to determine whether the subsequent cross-origin request is allowed to
        /// proceed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCors")]
        public virtual System.Nullable<bool> AllowCors { get; set; }

        /// <summary>The canonical name of this endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The specification of an Internet routable address of API frontend that will handle requests to this [API
        /// Endpoint](https://cloud.google.com/apis/design/glossary). It should be either a valid IPv4 address or a
        /// fully-qualified domain name. For example, "8.8.8.8" or "myservice.appspot.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Enum type definition.</summary>
    public class Enum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enum value definitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumvalue")]
        public virtual System.Collections.Generic.IList<EnumValue> Enumvalue { get; set; }

        /// <summary>Enum type name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>The source context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContext")]
        public virtual SourceContext SourceContext { get; set; }

        /// <summary>The source syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Enum value definition.</summary>
    public class EnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enum value name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Enum value number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>Protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

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

    /// <summary>A single field of a message type.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field cardinality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual string Cardinality { get; set; }

        /// <summary>The string value of the default value of this field. Proto2 syntax only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>The field JSON name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonName")]
        public virtual string JsonName { get; set; }

        /// <summary>The field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The field number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>
        /// The index of the field type in `Type.oneofs`, for message or enumeration types. The first type has index 1;
        /// zero means the type is not in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofIndex")]
        public virtual System.Nullable<int> OneofIndex { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>Whether to use alternative packed wire representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packed")]
        public virtual System.Nullable<bool> Packed { get; set; }

        /// <summary>
        /// The field type URL, without the scheme, for message or enumeration types. Example:
        /// `"type.googleapis.com/google.protobuf.Timestamp"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeUrl")]
        public virtual string TypeUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulation of flow-specific error details for debugging. Used as a details field on an error Status, not
    /// intended for external use.
    /// </summary>
    public class FlowErrorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of exception (as a class name).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionType")]
        public virtual string ExceptionType { get; set; }

        /// <summary>The step that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flowStepId")]
        public virtual string FlowStepId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GenerateConfigReport method.</summary>
    public class GenerateConfigReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Service configuration for which we want to generate the report. For this version of API, the
        /// supported types are google.api.servicemanagement.v1.ConfigRef, google.api.servicemanagement.v1.ConfigSource,
        /// and google.api.Service
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newConfig")]
        public virtual System.Collections.Generic.IDictionary<string, object> NewConfig { get; set; }

        /// <summary>
        /// Optional. Service configuration against which the comparison will be done. For this version of API, the
        /// supported types are google.api.servicemanagement.v1.ConfigRef, google.api.servicemanagement.v1.ConfigSource,
        /// and google.api.Service
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldConfig")]
        public virtual System.Collections.Generic.IDictionary<string, object> OldConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GenerateConfigReport method.</summary>
    public class GenerateConfigReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// list of ChangeReport, each corresponding to comparison between two service configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeReports")]
        public virtual System.Collections.Generic.IList<ChangeReport> ChangeReports { get; set; }

        /// <summary>Errors / Linter warnings associated with the service definition this report belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnostics")]
        public virtual System.Collections.Generic.IList<Diagnostic> Diagnostics { get; set; }

        /// <summary>ID of the service configuration this report belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Name of the service this report belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the HTTP configuration for an API service. It contains a list of HttpRule, each specifying the mapping
    /// of an RPC method to one or more HTTP REST API methods.
    /// </summary>
    public class Http : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When set to true, URL path parameters will be fully URI-decoded except in cases of single segment matches in
        /// reserved expansion, where "%2F" will be left encoded. The default behavior is to not decode RFC 6570
        /// reserved characters in multi segment matches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyDecodeReservedExpansion")]
        public virtual System.Nullable<bool> FullyDecodeReservedExpansion { get; set; }

        /// <summary>
        /// A list of HTTP configuration rules that apply to individual API methods. **NOTE:** All service configuration
        /// rules follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<HttpRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// # gRPC Transcoding gRPC Transcoding is a feature for mapping between a gRPC method and one or more HTTP REST
    /// endpoints. It allows developers to build a single API service that supports both gRPC APIs and REST APIs. Many
    /// systems, including [Google APIs](https://github.com/googleapis/googleapis), [Cloud
    /// Endpoints](https://cloud.google.com/endpoints), [gRPC Gateway](https://github.com/grpc-ecosystem/grpc-gateway),
    /// and [Envoy](https://github.com/envoyproxy/envoy) proxy support this feature and use it for large scale
    /// production services. `HttpRule` defines the schema of the gRPC/REST mapping. The mapping specifies how different
    /// portions of the gRPC request message are mapped to the URL path, URL query parameters, and HTTP request body. It
    /// also controls how the gRPC response message is mapped to the HTTP response body. `HttpRule` is typically
    /// specified as an `google.api.http` annotation on the gRPC method. Each mapping specifies a URL path template and
    /// an HTTP method. The path template may refer to one or more fields in the gRPC request message, as long as each
    /// field is a non-repeated field with a primitive (non-message) type. The path template controls how fields of the
    /// request message are mapped to the URL path. Example: service Messaging { rpc GetMessage(GetMessageRequest)
    /// returns (Message) { option (google.api.http) = { get: "/v1/{name=messages/*}" }; } } message GetMessageRequest {
    /// string name = 1; // Mapped to URL path. } message Message { string text = 1; // The resource content. } This
    /// enables an HTTP REST to gRPC mapping as below: HTTP | gRPC -----|----- `GET /v1/messages/123456` |
    /// `GetMessage(name: "messages/123456")` Any fields in the request message which are not bound by the path template
    /// automatically become HTTP query parameters if there is no HTTP request body. For example: service Messaging {
    /// rpc GetMessage(GetMessageRequest) returns (Message) { option (google.api.http) = {
    /// get:"/v1/messages/{message_id}" }; } } message GetMessageRequest { message SubMessage { string subfield = 1; }
    /// string message_id = 1; // Mapped to URL path. int64 revision = 2; // Mapped to URL query parameter `revision`.
    /// SubMessage sub = 3; // Mapped to URL query parameter `sub.subfield`. } This enables a HTTP JSON to RPC mapping
    /// as below: HTTP | gRPC -----|----- `GET /v1/messages/123456?revision=2&amp;amp;sub.subfield=foo` |
    /// `GetMessage(message_id: "123456" revision: 2 sub: SubMessage(subfield: "foo"))` Note that fields which are
    /// mapped to URL query parameters must have a primitive type or a repeated primitive type or a non-repeated message
    /// type. In the case of a repeated type, the parameter can be repeated in the URL as `...?param=A&amp;amp;param=B`.
    /// In the case of a message type, each field of the message is mapped to a separate parameter, such as
    /// `...?foo.a=A&amp;amp;foo.b=B&amp;amp;foo.c=C`. For HTTP methods that allow a request body, the `body` field
    /// specifies the mapping. Consider a REST update method on the message resource collection: service Messaging { rpc
    /// UpdateMessage(UpdateMessageRequest) returns (Message) { option (google.api.http) = { patch:
    /// "/v1/messages/{message_id}" body: "message" }; } } message UpdateMessageRequest { string message_id = 1; //
    /// mapped to the URL Message message = 2; // mapped to the body } The following HTTP JSON to RPC mapping is
    /// enabled, where the representation of the JSON in the request body is determined by protos JSON encoding: HTTP |
    /// gRPC -----|----- `PATCH /v1/messages/123456 { "text": "Hi!" }` | `UpdateMessage(message_id: "123456" message {
    /// text: "Hi!" })` The special name `*` can be used in the body mapping to define that every field not bound by the
    /// path template should be mapped to the request body. This enables the following alternative definition of the
    /// update method: service Messaging { rpc UpdateMessage(Message) returns (Message) { option (google.api.http) = {
    /// patch: "/v1/messages/{message_id}" body: "*" }; } } message Message { string message_id = 1; string text = 2; }
    /// The following HTTP JSON to RPC mapping is enabled: HTTP | gRPC -----|----- `PATCH /v1/messages/123456 { "text":
    /// "Hi!" }` | `UpdateMessage(message_id: "123456" text: "Hi!")` Note that when using `*` in the body mapping, it is
    /// not possible to have HTTP parameters, as all fields not bound by the path end in the body. This makes this
    /// option more rarely used in practice when defining REST APIs. The common usage of `*` is in custom methods which
    /// don't use the URL at all for transferring data. It is possible to define multiple HTTP methods for one RPC by
    /// using the `additional_bindings` option. Example: service Messaging { rpc GetMessage(GetMessageRequest) returns
    /// (Message) { option (google.api.http) = { get: "/v1/messages/{message_id}" additional_bindings { get:
    /// "/v1/users/{user_id}/messages/{message_id}" } }; } } message GetMessageRequest { string message_id = 1; string
    /// user_id = 2; } This enables the following two alternative HTTP JSON to RPC mappings: HTTP | gRPC -----|-----
    /// `GET /v1/messages/123456` | `GetMessage(message_id: "123456")` `GET /v1/users/me/messages/123456` |
    /// `GetMessage(user_id: "me" message_id: "123456")` ## Rules for HTTP mapping 1. Leaf request fields (recursive
    /// expansion nested messages in the request message) are classified into three categories: - Fields referred by the
    /// path template. They are passed via the URL path. - Fields referred by the HttpRule.body. They are passed via the
    /// HTTP request body. - All other fields are passed via the URL query parameters, and the parameter name is the
    /// field path in the request message. A repeated field can be represented as multiple query parameters under the
    /// same name. 2. If HttpRule.body is "*", there is no URL query parameter, all fields are passed via URL path and
    /// HTTP request body. 3. If HttpRule.body is omitted, there is no HTTP request body, all fields are passed via URL
    /// path and URL query parameters. ### Path template syntax Template = "/" Segments [ Verb ] ; Segments = Segment {
    /// "/" Segment } ; Segment = "*" | "**" | LITERAL | Variable ; Variable = "{" FieldPath [ "=" Segments ] "}" ;
    /// FieldPath = IDENT { "." IDENT } ; Verb = ":" LITERAL ; The syntax `*` matches a single URL path segment. The
    /// syntax `**` matches zero or more URL path segments, which must be the last part of the URL path except the
    /// `Verb`. The syntax `Variable` matches part of the URL path as specified by its template. A variable template
    /// must not contain other variables. If a variable matches a single path segment, its template may be omitted, e.g.
    /// `{var}` is equivalent to `{var=*}`. The syntax `LITERAL` matches literal text in the URL path. If the `LITERAL`
    /// contains any reserved character, such characters should be percent-encoded before the matching. If a variable
    /// contains exactly one path segment, such as `"{var}"` or `"{var=*}"`, when such a variable is expanded into a URL
    /// path on the client side, all characters except `[-_.~0-9a-zA-Z]` are percent-encoded. The server side does the
    /// reverse decoding. Such variables show up in the [Discovery
    /// Document](https://developers.google.com/discovery/v1/reference/apis) as `{var}`. If a variable contains multiple
    /// path segments, such as `"{var=foo/*}"` or `"{var=**}"`, when such a variable is expanded into a URL path on the
    /// client side, all characters except `[-_.~/0-9a-zA-Z]` are percent-encoded. The server side does the reverse
    /// decoding, except "%2F" and "%2f" are left unchanged. Such variables show up in the [Discovery
    /// Document](https://developers.google.com/discovery/v1/reference/apis) as `{+var}`. ## Using gRPC API Service
    /// Configuration gRPC API Service Configuration (service config) is a configuration language for configuring a gRPC
    /// service to become a user-facing product. The service config is simply the YAML representation of the
    /// `google.api.Service` proto message. As an alternative to annotating your proto file, you can configure gRPC
    /// transcoding in your service config YAML files. You do this by specifying a `HttpRule` that maps the gRPC method
    /// to a REST endpoint, achieving the same effect as the proto annotation. This can be particularly useful if you
    /// have a proto that is reused in multiple services. Note that any transcoding specified in the service config will
    /// override any matching transcoding configuration in the proto. Example: http: rules: # Selects a gRPC method and
    /// applies HttpRule to it. - selector: example.v1.Messaging.GetMessage get:
    /// /v1/messages/{message_id}/{sub.subfield} ## Special notes When gRPC Transcoding is used to map a gRPC to JSON
    /// REST endpoints, the proto to JSON conversion must follow the [proto3
    /// specification](https://developers.google.com/protocol-buffers/docs/proto3#json). While the single segment
    /// variable follows the semantics of [RFC 6570](https://tools.ietf.org/html/rfc6570) Section 3.2.2 Simple String
    /// Expansion, the multi segment variable **does not** follow RFC 6570 Section 3.2.3 Reserved Expansion. The reason
    /// is that the Reserved Expansion does not expand special characters like `?` and `#`, which would lead to invalid
    /// URLs. As the result, gRPC Transcoding uses a custom encoding for multi segment variables. The path variables
    /// **must not** refer to any repeated or mapped field, because client libraries are not capable of handling such
    /// variable expansion. The path variables **must not** capture the leading "/" character. The reason is that the
    /// most common use case "{var}" does not capture the leading "/" character. For consistency, all path variables
    /// must share the same behavior. Repeated message fields must not be mapped to URL query parameters, because no
    /// client library can support such complicated mapping. If an API needs to use a JSON array for request or response
    /// body, it can map the request or response body to a repeated field. However, some gRPC Transcoding
    /// implementations may not support this feature.
    /// </summary>
    public class HttpRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional HTTP bindings for the selector. Nested bindings must not contain an `additional_bindings` field
        /// themselves (that is, the nesting may only be one level deep).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalBindings")]
        public virtual System.Collections.Generic.IList<HttpRule> AdditionalBindings { get; set; }

        /// <summary>
        /// The name of the request field whose value is mapped to the HTTP request body, or `*` for mapping all request
        /// fields not captured by the path pattern to the HTTP body, or omitted for not having any HTTP request body.
        /// NOTE: the referred field must be present at the top-level of the request message type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// The custom pattern is used for specifying an HTTP method that is not included in the `pattern` field, such
        /// as HEAD, or "*" to leave the HTTP method unspecified for this rule. The wild-card rule is useful for
        /// services that provide content to Web (HTML) clients.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomHttpPattern Custom { get; set; }

        /// <summary>Maps to HTTP DELETE. Used for deleting a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delete")]
        public virtual string Delete { get; set; }

        /// <summary>Maps to HTTP GET. Used for listing and getting information about resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("get")]
        public virtual string Get { get; set; }

        /// <summary>Maps to HTTP PATCH. Used for updating a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patch")]
        public virtual string Patch { get; set; }

        /// <summary>Maps to HTTP POST. Used for creating a resource or performing an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("post")]
        public virtual string Post { get; set; }

        /// <summary>Maps to HTTP PUT. Used for replacing a resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("put")]
        public virtual string Put { get; set; }

        /// <summary>
        /// Optional. The name of the response field whose value is mapped to the HTTP response body. When omitted, the
        /// entire response message will be used as the HTTP response body. NOTE: The referred field must be present at
        /// the top-level of the response message type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseBody")]
        public virtual string ResponseBody { get; set; }

        /// <summary>Selects a method to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a location to extract JWT from an API request.</summary>
    public class JwtLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies HTTP header name to extract JWT token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>Specifies URL query parameter name to extract JWT token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The value prefix. The value format is "value_prefix{token}" Only applies to "in" header type. Must be empty
        /// for "in" query type. If not empty, the header value has to match (case sensitive) this prefix. If not
        /// matched, JWT will not be extracted. If matched, JWT will be extracted after the prefix is removed. For
        /// example, for "Authorization: Bearer {JWT}", value_prefix="Bearer " with a space at the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuePrefix")]
        public virtual string ValuePrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a label.</summary>
    public class LabelDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A human-readable description for the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The label key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The type of data that can be assigned to the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

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

    /// <summary>Response message for ListServiceConfigs method.</summary>
    public class ListServiceConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token of the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of service configuration resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigs")]
        public virtual System.Collections.Generic.IList<Service> ServiceConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListServiceRollouts method.</summary>
    public class ListServiceRolloutsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token of the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of rollout resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollouts")]
        public virtual System.Collections.Generic.IList<Rollout> Rollouts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListServices` method.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token that can be passed to `ListServices` to resume a paginated query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The returned services will only have the name field set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<ManagedService> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A description of a log type. Example in YAML format: - name: library.googleapis.com/activity_history
    /// description: The history of borrowing and returning library items. display_name: Activity labels: - key:
    /// /customer_id description: Identifier of a library customer
    /// </summary>
    public class LogDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A human-readable description of this log. This information appears in the documentation and can contain
        /// details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The human-readable name for this log. This information appears on the user interface and should be concise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The set of labels that are available to describe a specific log entry. Runtime requests that contain labels
        /// not specified here are considered invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>
        /// The name of the log. It must be less than 512 characters long and can include the following characters:
        /// upper- and lower-case alphanumeric characters [A-Za-z0-9], and punctuation characters including slash,
        /// underscore, hyphen, period [/_-.].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Logging configuration of the service. The following example shows how to configure logs to be sent to the
    /// producer and consumer projects. In the example, the `activity_history` log is sent to both the producer and
    /// consumer projects, whereas the `purchase_history` log is only sent to the producer project. monitored_resources:
    /// - type: library.googleapis.com/branch labels: - key: /city description: The city where the library branch is
    /// located in. - key: /name description: The name of the branch. logs: - name: activity_history labels: - key:
    /// /customer_id - name: purchase_history logging: producer_destinations: - monitored_resource:
    /// library.googleapis.com/branch logs: - activity_history - purchase_history consumer_destinations: -
    /// monitored_resource: library.googleapis.com/branch logs: - activity_history
    /// </summary>
    public class Logging : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Logging configurations for sending logs to the consumer project. There can be multiple consumer
        /// destinations, each one must have a different monitored resource type. A log can be used in at most one
        /// consumer destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDestinations")]
        public virtual System.Collections.Generic.IList<LoggingDestination> ConsumerDestinations { get; set; }

        /// <summary>
        /// Logging configurations for sending logs to the producer project. There can be multiple producer
        /// destinations, each one must have a different monitored resource type. A log can be used in at most one
        /// producer destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerDestinations")]
        public virtual System.Collections.Generic.IList<LoggingDestination> ProducerDestinations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration of a specific logging destination (the producer project or the consumer project).
    /// </summary>
    public class LoggingDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Names of the logs to be sent to this destination. Each name must be defined in the Service.logs section. If
        /// the log name is not a domain scoped name, it will be automatically prefixed with the service name followed
        /// by "/".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual System.Collections.Generic.IList<string> Logs { get; set; }

        /// <summary>
        /// The monitored resource type. The type must be defined in the Service.monitored_resources section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResource")]
        public virtual string MonitoredResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The full representation of a Service that is managed by Google Service Management.</summary>
    public class ManagedService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the project that produces and owns this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerProjectId")]
        public virtual string ProducerProjectId { get; set; }

        /// <summary>
        /// The name of the service. See the [overview](/service-management/overview) for naming requirements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Method represents a method of an API interface.</summary>
    public class Method : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The simple name of this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Any metadata attached to the method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>If true, the request is streamed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestStreaming")]
        public virtual System.Nullable<bool> RequestStreaming { get; set; }

        /// <summary>A URL of the input message type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestTypeUrl")]
        public virtual string RequestTypeUrl { get; set; }

        /// <summary>If true, the response is streamed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStreaming")]
        public virtual System.Nullable<bool> ResponseStreaming { get; set; }

        /// <summary>The URL of the output message type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseTypeUrl")]
        public virtual string ResponseTypeUrl { get; set; }

        /// <summary>The source syntax of this method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a metric type and its schema. Once a metric descriptor is created, deleting or altering it stops data
    /// collection and makes the metric type's existing data unusable.
    /// </summary>
    public class MetricDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A detailed description of the metric, which can be used in documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an
        /// ending period, for example "Request count". This field is optional but it is recommended to be set for any
        /// metrics associated with user-visible concepts, such as Quota.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The set of labels that can be used to describe a specific instance of this metric type. For example, the
        /// `appengine.googleapis.com/http/server/response_latencies` metric type has a label for the HTTP response
        /// code, `response_code`, so you can look at latencies for successful responses or just for responses that
        /// failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the metric definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Optional. Metadata which can be used to guide usage of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual MetricDescriptorMetadata Metadata { get; set; }

        /// <summary>
        /// Whether the metric records instantaneous values, changes to a value, etc. Some combinations of `metric_kind`
        /// and `value_type` might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricKind")]
        public virtual string MetricKind { get; set; }

        /// <summary>
        /// Read-only. If present, then a time series, which is identified partially by a metric type and a
        /// MonitoredResourceDescriptor, that is associated with this metric type can only be associated with one of the
        /// monitored resource types listed here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResourceTypes")]
        public virtual System.Collections.Generic.IList<string> MonitoredResourceTypes { get; set; }

        /// <summary>The resource name of the metric descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The metric type, including its DNS name prefix. The type is not URL-encoded. All user-defined metric types
        /// have the DNS name `custom.googleapis.com` or `external.googleapis.com`. Metric types should use a natural
        /// hierarchical grouping. For example: "custom.googleapis.com/invoice/paid/amount"
        /// "external.googleapis.com/prometheus/up" "appengine.googleapis.com/http/server/response_latencies"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The units in which the metric value is reported. It is only applicable if the `value_type` is `INT64`,
        /// `DOUBLE`, or `DISTRIBUTION`. The `unit` defines the representation of the stored metric values. Different
        /// systems might scale the values to be more easily displayed (so a value of `0.02kBy` _might_ be displayed as
        /// `20By`, and a value of `3523kBy` _might_ be displayed as `3.5MBy`). However, if the `unit` is `kBy`, then
        /// the value of the metric is always in thousands of bytes, no matter how it might be displayed. If you want a
        /// custom metric to record the exact number of CPU-seconds used by a job, you can create an `INT64 CUMULATIVE`
        /// metric whose `unit` is `s{CPU}` (or equivalently `1s{CPU}` or just `s`). If the job uses 12,005 CPU-seconds,
        /// then the value is written as `12005`. Alternatively, if you want a custom metric to record data in a more
        /// granular way, you can create a `DOUBLE CUMULATIVE` metric whose `unit` is `ks{CPU}`, and then write the
        /// value `12.005` (which is `12005/1000`), or use `Kis{CPU}` and write `11.723` (which is `12005/1024`). The
        /// supported units are a subset of [The Unified Code for Units of
        /// Measure](https://unitsofmeasure.org/ucum.html) standard: **Basic units (UNIT)** * `bit` bit * `By` byte *
        /// `s` second * `min` minute * `h` hour * `d` day * `1` dimensionless **Prefixes (PREFIX)** * `k` kilo (10^3) *
        /// `M` mega (10^6) * `G` giga (10^9) * `T` tera (10^12) * `P` peta (10^15) * `E` exa (10^18) * `Z` zetta
        /// (10^21) * `Y` yotta (10^24) * `m` milli (10^-3) * `u` micro (10^-6) * `n` nano (10^-9) * `p` pico (10^-12) *
        /// `f` femto (10^-15) * `a` atto (10^-18) * `z` zepto (10^-21) * `y` yocto (10^-24) * `Ki` kibi (2^10) * `Mi`
        /// mebi (2^20) * `Gi` gibi (2^30) * `Ti` tebi (2^40) * `Pi` pebi (2^50) **Grammar** The grammar also includes
        /// these connectors: * `/` division or ratio (as an infix operator). For examples, `kBy/{email}` or `MiBy/10ms`
        /// (although you should almost never have `/s` in a metric `unit`; rates should always be computed at query
        /// time from the underlying cumulative or delta value). * `.` multiplication or composition (as an infix
        /// operator). For examples, `GBy.d` or `k{watt}.h`. The grammar for a unit is as follows: Expression =
        /// Component { "." Component } { "/" Component } ; Component = ( [ PREFIX ] UNIT | "%" ) [ Annotation ] |
        /// Annotation | "1" ; Annotation = "{" NAME "}" ; Notes: * `Annotation` is just a comment if it follows a
        /// `UNIT`. If the annotation is used alone, then the unit is equivalent to `1`. For examples, `{request}/s ==
        /// 1/s`, `By{transmitted}/s == By/s`. * `NAME` is a sequence of non-blank printable ASCII characters not
        /// containing `{` or `}`. * `1` represents a unitary [dimensionless
        /// unit](https://en.wikipedia.org/wiki/Dimensionless_quantity) of 1, such as in `1/s`. It is typically used
        /// when none of the basic units are appropriate. For example, "new users per day" can be represented as `1/d`
        /// or `{new-users}/d` (and a metric value `5` would mean "5 new users). Alternatively, "thousands of page views
        /// per day" would be represented as `1000/d` or `k1/d` or `k{page_views}/d` (and a metric value of `5.3` would
        /// mean "5300 page views per day"). * `%` represents dimensionless value of 1/100, and annotates values giving
        /// a percentage (so the metric values are typically in the range of 0..100, and a metric value `3` means "3
        /// percent"). * `10^2.%` indicates a metric contains a ratio, typically in the range 0..1, that will be
        /// multiplied by 100 and displayed as a percentage (so a metric value `0.03` means "3 percent").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Whether the measurement is an integer, a floating-point number, etc. Some combinations of `metric_kind` and
        /// `value_type` might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional annotations that can be used to guide the usage of a metric.</summary>
    public class MetricDescriptorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The delay of data points caused by ingestion. Data points older than this age are guaranteed to be ingested
        /// and available to be read, excluding data loss due to errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestDelay")]
        public virtual object IngestDelay { get; set; }

        /// <summary>Deprecated. Must use the MetricDescriptor.launch_stage instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The sampling period of metric data points. For metrics which are written periodically, consecutive data
        /// points are stored at this time interval, excluding data loss due to errors. Metrics with a higher
        /// granularity have a smaller sampling period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePeriod")]
        public virtual object SamplePeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Bind API methods to metrics. Binding a method to a metric causes that metric's configured quota behaviors to
    /// apply to the method call.
    /// </summary>
    public class MetricRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics to update when the selected methods are called, and the associated cost applied to each metric. The
        /// key of the map is the metric name, and the values are the amount increased for the metric against which the
        /// quota limits are defined. The value must not be negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricCosts")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> MetricCosts { get; set; }

        /// <summary>Selects the methods to which this rule applies. Refer to selector for syntax details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Declares an API Interface to be included in this interface. The including interface must redeclare all the
    /// methods from the included interface, but documentation and options are inherited as follows: - If after comment
    /// and whitespace stripping, the documentation string of the redeclared method is empty, it will be inherited from
    /// the original method. - Each annotation belonging to the service config (http, visibility) which is not set in
    /// the redeclared method will be inherited. - If an http annotation is inherited, the path pattern will be modified
    /// as follows. Any version prefix will be replaced by the version of the including interface plus the root path if
    /// specified. Example of a simple mixin: package google.acl.v1; service AccessControl { // Get the underlying ACL
    /// object. rpc GetAcl(GetAclRequest) returns (Acl) { option (google.api.http).get = "/v1/{resource=**}:getAcl"; } }
    /// package google.storage.v2; service Storage { // rpc GetAcl(GetAclRequest) returns (Acl); // Get a data record.
    /// rpc GetData(GetDataRequest) returns (Data) { option (google.api.http).get = "/v2/{resource=**}"; } } Example of
    /// a mixin configuration: apis: - name: google.storage.v2.Storage mixins: - name: google.acl.v1.AccessControl The
    /// mixin construct implies that all methods in `AccessControl` are also declared with same name and
    /// request/response types in `Storage`. A documentation generator or annotation processor will see the effective
    /// `Storage.GetAcl` method after inheriting documentation and annotations as follows: service Storage { // Get the
    /// underlying ACL object. rpc GetAcl(GetAclRequest) returns (Acl) { option (google.api.http).get =
    /// "/v2/{resource=**}:getAcl"; } ... } Note how the version in the path pattern changed from `v1` to `v2`. If the
    /// `root` field in the mixin is specified, it should be a relative path under which inherited HTTP paths are
    /// placed. Example: apis: - name: google.storage.v2.Storage mixins: - name: google.acl.v1.AccessControl root: acls
    /// This implies the following inherited HTTP annotation: service Storage { // Get the underlying ACL object. rpc
    /// GetAcl(GetAclRequest) returns (Acl) { option (google.api.http).get = "/v2/acls/{resource=**}:getAcl"; } ... }
    /// </summary>
    public class Mixin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified name of the interface which is included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>If non-empty specifies a path under which inherited HTTP paths are rooted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("root")]
        public virtual string Root { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that describes the schema of a MonitoredResource object using a type name and a set of labels. For
    /// example, the monitored resource descriptor for Google Compute Engine VM instances has a type of `"gce_instance"`
    /// and specifies the use of the labels `"instance_id"` and `"zone"` to identify particular VM instances. Different
    /// APIs can support different monitored resource types. APIs generally provide a `list` method that returns the
    /// monitored resource descriptors used by the API.
    /// </summary>
    public class MonitoredResourceDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A detailed description of the monitored resource type that might be used in documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A concise name for the monitored resource type that might be displayed in user interfaces. It
        /// should be a Title Cased Noun Phrase, without any article or other determiners. For example, `"Google Cloud
        /// SQL Database"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. A set of labels used to describe instances of this monitored resource type. For example, an
        /// individual Google Cloud SQL database is identified by values for the labels `"database_id"` and `"zone"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the monitored resource definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Optional. The resource name of the monitored resource descriptor:
        /// `"projects/{project_id}/monitoredResourceDescriptors/{type}"` where {type} is the value of the `type` field
        /// in this object and {project_id} is a project ID that provides API-specific context for accessing the type.
        /// APIs that do not use project information can use the resource name format
        /// `"monitoredResourceDescriptors/{type}"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The monitored resource type. For example, the type `"cloudsql_database"` represents databases in
        /// Google Cloud SQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Monitoring configuration of the service. The example below shows how to configure monitored resources and
    /// metrics for monitoring. In the example, a monitored resource and two metrics are defined. The
    /// `library.googleapis.com/book/returned_count` metric is sent to both producer and consumer projects, whereas the
    /// `library.googleapis.com/book/num_overdue` metric is only sent to the consumer project. monitored_resources: -
    /// type: library.googleapis.com/Branch display_name: "Library Branch" description: "A branch of a library."
    /// launch_stage: GA labels: - key: resource_container description: "The Cloud container (ie. project id) for the
    /// Branch." - key: location description: "The location of the library branch." - key: branch_id description: "The
    /// id of the branch." metrics: - name: library.googleapis.com/book/returned_count display_name: "Books Returned"
    /// description: "The count of books that have been returned." launch_stage: GA metric_kind: DELTA value_type: INT64
    /// unit: "1" labels: - key: customer_id description: "The id of the customer." - name:
    /// library.googleapis.com/book/num_overdue display_name: "Books Overdue" description: "The current number of
    /// overdue books." launch_stage: GA metric_kind: GAUGE value_type: INT64 unit: "1" labels: - key: customer_id
    /// description: "The id of the customer." monitoring: producer_destinations: - monitored_resource:
    /// library.googleapis.com/Branch metrics: - library.googleapis.com/book/returned_count consumer_destinations: -
    /// monitored_resource: library.googleapis.com/Branch metrics: - library.googleapis.com/book/returned_count -
    /// library.googleapis.com/book/num_overdue
    /// </summary>
    public class Monitoring : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Monitoring configurations for sending metrics to the consumer project. There can be multiple consumer
        /// destinations. A monitored resource type may appear in multiple monitoring destinations if different
        /// aggregations are needed for different sets of metrics associated with that monitored resource type. A
        /// monitored resource and metric pair may only be used once in the Monitoring configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDestinations")]
        public virtual System.Collections.Generic.IList<MonitoringDestination> ConsumerDestinations { get; set; }

        /// <summary>
        /// Monitoring configurations for sending metrics to the producer project. There can be multiple producer
        /// destinations. A monitored resource type may appear in multiple monitoring destinations if different
        /// aggregations are needed for different sets of metrics associated with that monitored resource type. A
        /// monitored resource and metric pair may only be used once in the Monitoring configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerDestinations")]
        public virtual System.Collections.Generic.IList<MonitoringDestination> ProducerDestinations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration of a specific monitoring destination (the producer project or the consumer project).
    /// </summary>
    public class MonitoringDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Types of the metrics to report to this monitoring destination. Each type must be defined in Service.metrics
        /// section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// The monitored resource type. The type must be defined in Service.monitored_resources section.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResource")]
        public virtual string MonitoredResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OAuth scopes are a way to define data and permissions on data. For example, there are scopes defined for
    /// "Read-only access to Google Calendar" and "Access to Cloud Platform". Users can consent to a scope for an
    /// application, giving it permission to access that data on their behalf. OAuth scope specifications should be
    /// fairly coarse grained; a user will need to see and understand the text description of what your scope means. In
    /// most cases: use one or at most two OAuth scopes for an entire family of products. If your product has multiple
    /// APIs, you should probably be sharing the OAuth scope across all of those APIs. When you need finer grained OAuth
    /// consent screens: talk with your product management about how developers will use them in practice. Please note
    /// that even though each of the canonical scopes is enough for a request to be accepted and passed to the backend,
    /// a request can still fail due to the backend requiring additional scopes or permissions.
    /// </summary>
    public class OAuthRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of publicly documented OAuth scopes that are allowed access. An OAuth token containing any of these
        /// scopes will be accepted. Example: canonical_scopes: https://www.googleapis.com/auth/calendar,
        /// https://www.googleapis.com/auth/calendar.read
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalScopes")]
        public virtual string CanonicalScopes { get; set; }

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

    /// <summary>
    /// A message representing the message types used by a long-running operation. Example: rpc Export(ExportRequest)
    /// returns (google.longrunning.Operation) { option (google.longrunning.operation_info) = { response_type:
    /// "ExportResponse" metadata_type: "ExportMetadata" }; }
    /// </summary>
    public class OperationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The message name of the metadata type for this long-running operation. If the response is in a
        /// different package from the rpc, a fully-qualified message name must be used (e.g. `google.protobuf.Struct`).
        /// Note: Altering this value constitutes a breaking change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataType")]
        public virtual string MetadataType { get; set; }

        /// <summary>
        /// Required. The message name of the primary return type for this long-running operation. This type will be
        /// used to deserialize the LRO's response. If the response is in a different package from the rpc, a
        /// fully-qualified message name must be used (e.g. `google.protobuf.Struct`). Note: Altering this value
        /// constitutes a breaking change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseType")]
        public virtual string ResponseType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata associated with a long running operation resource.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Percentage of completion of this operation, ranging from 0 to 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercentage")]
        public virtual System.Nullable<int> ProgressPercentage { get; set; }

        /// <summary>The full name of the resources that this operation is directly associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceNames")]
        public virtual System.Collections.Generic.IList<string> ResourceNames { get; set; }

        /// <summary>The start time of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Detailed status information for each step. The order is undetermined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<Step> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protocol buffer option, which can be attached to a message, field, enumeration, etc.</summary>
    public class Option : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The option's name. For protobuf built-in options (options defined in descriptor.proto), this is the short
        /// name. For example, `"map_entry"`. For custom options, it should be the fully-qualified name. For example,
        /// `"google.api.http"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The option's value packed in an Any message. If the value is a primitive, the corresponding wrapper type
        /// defined in google/protobuf/wrappers.proto should be used. If the value is an enum, it should be stored as an
        /// int32 value using the google.protobuf.Int32Value type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a documentation page. A page can contain subpages to represent nested documentation set structure.
    /// </summary>
    public class Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Markdown content of the page. You can use (== include {path} ==) to include content from a Markdown
        /// file. The content can be used to produce the documentation page such as HTML format page.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// The name of the page. It will be used as an identity of the page to generate URI of the page, text of the
        /// link to this page in navigation, etc. The full page name (start from the root page name to this page
        /// concatenated with `.`) can be used as reference to the page in your documentation. For example: pages: -
        /// name: Tutorial content: (== include tutorial.md ==) subpages: - name: Java content: (== include
        /// tutorial_java.md ==) You can reference `Java` page using Markdown reference link syntax: `Java`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Subpages of this page. The order of subpages specified here will be honored in the generated docset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subpages")]
        public virtual System.Collections.Generic.IList<Page> Subpages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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

    /// <summary>
    /// Quota configuration helps to achieve fairness and budgeting in service usage. The metric based quota
    /// configuration works this way: - The service configuration defines a set of metrics. - For API calls, the
    /// quota.metric_rules maps methods to metrics with corresponding costs. - The quota.limits defines limits on the
    /// metrics, which will be used for quota checks at runtime. An example quota configuration in yaml format: quota:
    /// limits: - name: apiWriteQpsPerProject metric: library.googleapis.com/write_calls unit: "1/min/{project}" # rate
    /// limit for consumer projects values: STANDARD: 10000 # The metric rules bind all methods to the read_calls
    /// metric, # except for the UpdateBook and DeleteBook methods. These two methods # are mapped to the write_calls
    /// metric, with the UpdateBook method # consuming at twice rate as the DeleteBook method. metric_rules: - selector:
    /// "*" metric_costs: library.googleapis.com/read_calls: 1 - selector:
    /// google.example.library.v1.LibraryService.UpdateBook metric_costs: library.googleapis.com/write_calls: 2 -
    /// selector: google.example.library.v1.LibraryService.DeleteBook metric_costs: library.googleapis.com/write_calls:
    /// 1 Corresponding Metric definition: metrics: - name: library.googleapis.com/read_calls display_name: Read
    /// requests metric_kind: DELTA value_type: INT64 - name: library.googleapis.com/write_calls display_name: Write
    /// requests metric_kind: DELTA value_type: INT64
    /// </summary>
    public class Quota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of `QuotaLimit` definitions for the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IList<QuotaLimit> Limits { get; set; }

        /// <summary>
        /// List of `MetricRule` definitions, each one mapping a selected method to one or more metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricRules")]
        public virtual System.Collections.Generic.IList<MetricRule> MetricRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `QuotaLimit` defines a specific limit that applies over a specified duration for a limit type. There can be at
    /// most one limit for a duration and limit type combination defined within a `QuotaGroup`.
    /// </summary>
    public class QuotaLimit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Default number of tokens that can be consumed during the specified duration. This is the number of tokens
        /// assigned when a client application developer activates the service for his/her project. Specifying a value
        /// of 0 will block all requests. This can be used if you are provisioning quota to selected consumers and
        /// blocking others. Similarly, a value of -1 will indicate an unlimited quota. No other negative values are
        /// allowed. Used by group-based quotas only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLimit")]
        public virtual System.Nullable<long> DefaultLimit { get; set; }

        /// <summary>
        /// Optional. User-visible, extended description for this quota limit. Should be used only when more context is
        /// needed to understand this limit than provided by the limit's display name (see: `display_name`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// User-visible display name for this limit. Optional. If not set, the UI will provide a default display name
        /// based on the quota configuration. This field can be used to override the default display name generated from
        /// the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Duration of this limit in textual notation. Must be "100s" or "1d". Used by group-based quotas only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual string Duration { get; set; }

        /// <summary>
        /// Free tier value displayed in the Developers Console for this limit. The free tier is the number of tokens
        /// that will be subtracted from the billed amount when billing is enabled. This field can only be set on a
        /// limit with duration "1d", in a billable group; it is invalid on any other limit. If this field is not set,
        /// it defaults to 0, indicating that there is no free tier for this service. Used by group-based quotas only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeTier")]
        public virtual System.Nullable<long> FreeTier { get; set; }

        /// <summary>
        /// Maximum number of tokens that can be consumed during the specified duration. Client application developers
        /// can override the default limit up to this maximum. If specified, this value cannot be set to a value less
        /// than the default limit. If not specified, it is set to the default limit. To allow clients to apply
        /// overrides with no upper bound, set this to -1, indicating unlimited maximum quota. Used by group-based
        /// quotas only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLimit")]
        public virtual System.Nullable<long> MaxLimit { get; set; }

        /// <summary>
        /// The name of the metric this quota limit applies to. The quota limits with the same metric will be checked
        /// together during runtime. The metric must be defined within the service config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>
        /// Name of the quota limit. The name must be provided, and it must be unique within the service. The name can
        /// only include alphanumeric characters as well as '-'. The maximum length of the limit name is 64 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Specify the unit of the quota limit. It uses the same syntax as Metric.unit. The supported unit kinds are
        /// determined by the quota backend system. Here are some examples: * "1/min/{project}" for quota per minute per
        /// project. Note: the order of unit components is insignificant. The "1" at the beginning is required to follow
        /// the metric unit syntax.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Tiered limit values. You must specify this as a key:value pair, with an integer value that is the maximum
        /// number of requests allowed for the specified unit. Currently only STANDARD is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a proto annotation that describes a string field that refers to an API resource.</summary>
    public class ResourceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource type of a child collection that the annotated field references. This is useful for annotating
        /// the `parent` field that doesn't have a fixed resource type. Example: message ListLogEntriesRequest { string
        /// parent = 1 [(google.api.resource_reference) = { child_type: "logging.googleapis.com/LogEntry" }; }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childType")]
        public virtual string ChildType { get; set; }

        /// <summary>
        /// The resource type that the annotated field references. Example: message Subscription { string topic = 2
        /// [(google.api.resource_reference) = { type: "pubsub.googleapis.com/Topic" }]; } Occasionally, a field may
        /// reference an arbitrary resource. In this case, APIs use the special value * in their resource reference.
        /// Example: message GetIamPolicyRequest { string resource = 2 [(google.api.resource_reference) = { type: "*"
        /// }]; }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rollout resource that defines how service configuration versions are pushed to control plane systems.
    /// Typically, you create a new version of the service config, and then create a Rollout to push the service config.
    /// </summary>
    public class Rollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the rollout. Readonly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>This field is deprecated and will be deleted. Please remove usage of this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdBy")]
        public virtual string CreatedBy { get; set; }

        /// <summary>The strategy associated with a rollout to delete a `ManagedService`. Readonly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteServiceStrategy")]
        public virtual DeleteServiceStrategy DeleteServiceStrategy { get; set; }

        /// <summary>
        /// Optional. Unique identifier of this Rollout. Must be no longer than 63 characters and only lower case
        /// letters, digits, '.', '_' and '-' are allowed. If not specified by client, the server will generate one. The
        /// generated id will have the form of , where "date" is the create date in ISO 8601 format. "revision number"
        /// is a monotonically increasing positive number that is reset every day for each service. An example of the
        /// generated rollout_id is '2016-02-16r1'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutId")]
        public virtual string RolloutId { get; set; }

        /// <summary>The name of the service associated with this Rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// The status of this rollout. Readonly. In case of a failed rollout, the system will automatically rollback to
        /// the current Rollout version. Readonly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Google Service Control selects service configurations based on traffic percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficPercentStrategy")]
        public virtual TrafficPercentStrategy TrafficPercentStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Service` is the root object of Google API service configuration (service config). It describes the basic
    /// information about a logical service, such as the service name and the user-facing title, and delegates other
    /// aspects to sub-sections. Each sub-section is either a proto message or a repeated proto message that configures
    /// a specific aspect, such as auth. For more information, see each proto message definition. Example: type:
    /// google.api.Service name: calendar.googleapis.com title: Google Calendar API apis: - name:
    /// google.calendar.v3.Calendar visibility: rules: - selector: "google.calendar.v3.*" restriction: PREVIEW backend:
    /// rules: - selector: "google.calendar.v3.*" address: calendar.example.com authentication: providers: - id:
    /// google_calendar_auth jwks_uri: https://www.googleapis.com/oauth2/v1/certs issuer: https://securetoken.google.com
    /// rules: - selector: "*" requirements: provider_id: google_calendar_auth
    /// </summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of API interfaces exported by this service. Only the `name` field of the google.protobuf.Api needs to
        /// be provided by the configuration author, as the remaining fields will be derived from the IDL during the
        /// normalization process. It is an error to specify an API interface here which cannot be resolved against the
        /// associated IDL files.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apis")]
        public virtual System.Collections.Generic.IList<Api> Apis { get; set; }

        /// <summary>Auth configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authentication")]
        public virtual Authentication Authentication { get; set; }

        /// <summary>API backend configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backend")]
        public virtual Backend Backend { get; set; }

        /// <summary>Billing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billing")]
        public virtual Billing Billing { get; set; }

        /// <summary>
        /// Obsolete. Do not use. This field has no semantic meaning. The service config compiler always sets this field
        /// to `3`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVersion")]
        public virtual System.Nullable<long> ConfigVersion { get; set; }

        /// <summary>Context configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual Context Context { get; set; }

        /// <summary>Configuration for the service control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("control")]
        public virtual Control Control { get; set; }

        /// <summary>Custom error configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customError")]
        public virtual CustomError CustomError { get; set; }

        /// <summary>Additional API documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual Documentation Documentation { get; set; }

        /// <summary>
        /// Configuration for network endpoints. If this is empty, then an endpoint with the same name as the service is
        /// automatically generated to service all defined APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<Endpoint> Endpoints { get; set; }

        /// <summary>
        /// A list of all enum types included in this API service. Enums referenced directly or indirectly by the `apis`
        /// are automatically included. Enums which are not referenced but shall be included should be listed here by
        /// name by the configuration author. Example: enums: - name: google.someapi.v1.SomeEnum
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enums")]
        public virtual System.Collections.Generic.IList<Enum> Enums { get; set; }

        /// <summary>HTTP configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("http")]
        public virtual Http Http { get; set; }

        /// <summary>
        /// A unique ID for a specific instance of this message, typically assigned by the client for tracking purpose.
        /// Must be no longer than 63 characters and only lower case letters, digits, '.', '_' and '-' are allowed. If
        /// empty, the server may choose to generate one instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Logging configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual Logging Logging { get; set; }

        /// <summary>Defines the logs used by this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual System.Collections.Generic.IList<LogDescriptor> Logs { get; set; }

        /// <summary>Defines the metrics used by this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<MetricDescriptor> Metrics { get; set; }

        /// <summary>
        /// Defines the monitored resources used by this service. This is required by the Service.monitoring and
        /// Service.logging configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResources")]
        public virtual System.Collections.Generic.IList<MonitoredResourceDescriptor> MonitoredResources { get; set; }

        /// <summary>Monitoring configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoring")]
        public virtual Monitoring Monitoring { get; set; }

        /// <summary>
        /// The service name, which is a DNS-like logical identifier for the service, such as `calendar.googleapis.com`.
        /// The service name typically goes through DNS verification to make sure the owner of the service also owns the
        /// DNS name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The Google project that owns this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerProjectId")]
        public virtual string ProducerProjectId { get; set; }

        /// <summary>Quota configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quota")]
        public virtual Quota Quota { get; set; }

        /// <summary>Output only. The source information for this configuration if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceInfo")]
        public virtual SourceInfo SourceInfo { get; set; }

        /// <summary>System parameter configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemParameters")]
        public virtual SystemParameters SystemParameters { get; set; }

        /// <summary>
        /// A list of all proto message types included in this API service. It serves similar purpose as
        /// [google.api.Service.types], except that these types are not needed by user-defined APIs. Therefore, they
        /// will not show up in the generated discovery doc. This field should only be used to define system APIs in
        /// ESF.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemTypes")]
        public virtual System.Collections.Generic.IList<Type> SystemTypes { get; set; }

        /// <summary>The product title for this service, it is the name displayed in Google Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// A list of all proto message types included in this API service. Types referenced directly or indirectly by
        /// the `apis` are automatically included. Messages which are not referenced but shall be included, such as
        /// types used by the `google.protobuf.Any` type, should be listed here by name by the configuration author.
        /// Example: types: - name: google.protobuf.Int32
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<Type> Types { get; set; }

        /// <summary>Configuration controlling usage of this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usage")]
        public virtual Usage Usage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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

    /// <summary>
    /// `SourceContext` represents information about the source of a protobuf element, like the file in which it is
    /// defined.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The path-qualified name of the .proto file that contained the associated protobuf element. For example:
        /// `"google/protobuf/source_context.proto"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source information used to create a Service Config</summary>
    public class SourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All files used during config generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFiles")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> SourceFiles { get; set; }

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

    /// <summary>Represents the status of one operation step.</summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The short description of the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SubmitConfigSource method.</summary>
    public class SubmitConfigSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The source configuration for the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSource")]
        public virtual ConfigSource ConfigSource { get; set; }

        /// <summary>
        /// Optional. If set, this will result in the generation of a `google.api.Service` configuration based on the
        /// `ConfigSource` provided, but the generated config and the sources will NOT be persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SubmitConfigSource method.</summary>
    public class SubmitConfigSourceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generated service configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfig")]
        public virtual Service ServiceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Define a parameter's name and location. The parameter may be passed as either an HTTP header or a URL query
    /// parameter, and if both are passed the behavior is implementation-dependent.
    /// </summary>
    public class SystemParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Define the HTTP header name to use for the parameter. It is case insensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeader")]
        public virtual string HttpHeader { get; set; }

        /// <summary>Define the name of the parameter, such as "api_key" . It is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Define the URL query parameter name to use for the parameter. It is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlQueryParameter")]
        public virtual string UrlQueryParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Define a system parameter rule mapping system parameter definitions to methods.</summary>
    public class SystemParameterRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Define parameters. Multiple names may be defined for a parameter. For a given method call, only one of them
        /// should be used. If multiple names are used the behavior is implementation-dependent. If none of the
        /// specified names are present the behavior is parameter-dependent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<SystemParameter> Parameters { get; set; }

        /// <summary>
        /// Selects the methods to which this rule applies. Use '*' to indicate all methods in all APIs. Refer to
        /// selector for syntax details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ### System parameter configuration A system parameter is a special kind of parameter defined by the API system,
    /// not by an individual API. It is typically mapped to an HTTP header and/or a URL query parameter. This
    /// configuration specifies which methods change the names of the system parameters.
    /// </summary>
    public class SystemParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Define system parameters. The parameters defined here will override the default parameters implemented by
        /// the system. If this field is missing from the service config, default system parameters will be used.
        /// Default system parameters and names is implementation-dependent. Example: define api key for all methods
        /// system_parameters rules: - selector: "*" parameters: - name: api_key url_query_parameter: api_key Example:
        /// define 2 api key names for a specific method. system_parameters rules: - selector: "/ListShelves"
        /// parameters: - name: api_key http_header: Api-Key1 - name: api_key http_header: Api-Key2 **NOTE:** All
        /// service configuration rules follow "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<SystemParameterRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
    /// Strategy that specifies how clients of Google Service Controller want to send traffic to use different config
    /// versions. This is generally used by API proxy to split traffic based on your configured percentage for each
    /// config version. One example of how to gradually rollout a new service configuration using this strategy: Day 1
    /// Rollout { id: "example.googleapis.com/rollout_20160206" traffic_percent_strategy { percentages: {
    /// "example.googleapis.com/20160201": 70.00 "example.googleapis.com/20160206": 30.00 } } } Day 2 Rollout { id:
    /// "example.googleapis.com/rollout_20160207" traffic_percent_strategy: { percentages: {
    /// "example.googleapis.com/20160206": 100.00 } } }
    /// </summary>
    public class TrafficPercentStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maps service configuration IDs to their corresponding traffic percentage. Key is the service configuration
        /// ID, Value is the traffic percentage which must be greater than 0.0 and the sum must equal to 100.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentages")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<double>> Percentages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protocol buffer message type.</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>The fully qualified message name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The list of types appearing in `oneof` definitions in this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofs")]
        public virtual System.Collections.Generic.IList<string> Oneofs { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>The source context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContext")]
        public virtual SourceContext SourceContext { get; set; }

        /// <summary>The source syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for UndeleteService method.</summary>
    public class UndeleteServiceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Revived service resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual ManagedService Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration controlling usage of a service.</summary>
    public class Usage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of a channel used for sending notifications to the service producer. Google Service
        /// Management currently only supports [Google Cloud Pub/Sub](https://cloud.google.com/pubsub) as a notification
        /// channel. To use Google Cloud Pub/Sub as the channel, this must be the name of a Cloud Pub/Sub topic that
        /// uses the Cloud Pub/Sub topic name format documented in https://cloud.google.com/pubsub/docs/overview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerNotificationChannel")]
        public virtual string ProducerNotificationChannel { get; set; }

        /// <summary>
        /// Requirements that must be satisfied before a consumer project can use the service. Each requirement is of
        /// the form /; for example 'serviceusage.googleapis.com/billing-enabled'. For Google APIs, a Terms of Service
        /// requirement must be included here. Google Cloud APIs must include "serviceusage.googleapis.com/tos/cloud".
        /// Other Google APIs should include "serviceusage.googleapis.com/tos/universal". Additional ToS can be included
        /// based on the business needs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirements")]
        public virtual System.Collections.Generic.IList<string> Requirements { get; set; }

        /// <summary>
        /// A list of usage rules that apply to individual API methods. **NOTE:** All service configuration rules follow
        /// "last one wins" order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<UsageRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Usage configuration rules for the service. NOTE: Under development. Use this rule to configure unregistered
    /// calls for the service. Unregistered calls are calls that do not contain consumer project identity. (Example:
    /// calls that do not contain an API key). By default, API methods do not allow unregistered calls, and each method
    /// call must be identified by a consumer project identity. Use this rule to allow/disallow unregistered calls.
    /// Example of an API that wants to allow unregistered calls for entire service. usage: rules: - selector: "*"
    /// allow_unregistered_calls: true Example of a method that wants to allow unregistered calls. usage: rules: -
    /// selector: "google.example.library.v1.LibraryService.CreateBook" allow_unregistered_calls: true
    /// </summary>
    public class UsageRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the selected method allows unregistered calls, e.g. calls that don't identify any user or
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowUnregisteredCalls")]
        public virtual System.Nullable<bool> AllowUnregisteredCalls { get; set; }

        /// <summary>
        /// Selects the methods to which this rule applies. Use '*' to indicate all methods in all APIs. Refer to
        /// selector for syntax details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual string Selector { get; set; }

        /// <summary>
        /// If true, the selected method should skip service control and the control plane features, such as quota and
        /// billing, will not be available. This flag is used by Google Cloud Endpoints to bypass checks for internal
        /// methods, such as service health check methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipServiceControl")]
        public virtual System.Nullable<bool> SkipServiceControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
