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

namespace Google.Apis.NetworkManagement.v1beta1
{
    /// <summary>The NetworkManagement Service.</summary>
    public class NetworkManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public NetworkManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public NetworkManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://networkmanagement.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://networkmanagement.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "networkmanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Network Management API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Network Management API.</summary>
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

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for NetworkManagement requests.</summary>
    public abstract class NetworkManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new NetworkManagementBaseServiceRequest instance.</summary>
        protected NetworkManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes NetworkManagement parameter list.</summary>
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
                Global = new GlobalResource(service);
                VpcFlowLogsConfigs = new VpcFlowLogsConfigsResource(service);
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
                    Operations = new OperationsResource(service);
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:cancel";

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
                                Pattern = @"^organizations/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Empty>
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
                                Pattern = @"^organizations/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
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
                                Pattern = @"^organizations/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListOperationsResponse>
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

            /// <summary>Gets the VpcFlowLogsConfigs resource.</summary>
            public virtual VpcFlowLogsConfigsResource VpcFlowLogsConfigs { get; }

            /// <summary>The "vpcFlowLogsConfigs" collection of methods.</summary>
            public class VpcFlowLogsConfigsResource
            {
                private const string Resource = "vpcFlowLogsConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VpcFlowLogsConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new `VpcFlowLogsConfig`. If a configuration with the exact same settings already exists
                /// (even if the ID is different), the creation fails. Notes: 1. Creating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - creating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the VPC Flow Logs configuration to create:
                /// `projects/{project_id}/locations/global` `organizations/{organization_id}/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new `VpcFlowLogsConfig`. If a configuration with the exact same settings already exists
                /// (even if the ID is different), the creation fails. Notes: 1. Creating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - creating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                public class CreateRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the VPC Flow Logs configuration to create:
                    /// `projects/{project_id}/locations/global` `organizations/{organization_id}/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the `VpcFlowLogsConfig`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("vpcFlowLogsConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VpcFlowLogsConfigId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/vpcFlowLogsConfigs";

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
                        RequestParameters.Add("vpcFlowLogsConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "vpcFlowLogsConfigId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a specific `VpcFlowLogsConfig`.</summary>
                /// <param name="name">
                /// Required. `VpcFlowLogsConfig` resource name using one of the form:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a specific `VpcFlowLogsConfig`.</summary>
                public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. `VpcFlowLogsConfig` resource name using one of the form:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a specific `VpcFlowLogsConfig`.</summary>
                /// <param name="name">
                /// Required. `VpcFlowLogsConfig` resource name using the form:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific `VpcFlowLogsConfig`.</summary>
                public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. `VpcFlowLogsConfig` resource name using the form:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all `VpcFlowLogsConfigs` in a given organization.</summary>
                /// <param name="parent">
                /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                /// `organizations/{organization_id}/locations/global`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all `VpcFlowLogsConfigs` in a given organization.</summary>
                public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListVpcFlowLogsConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                    /// `organizations/{organization_id}/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists the `VpcFlowLogsConfigs` that match the filter expression. A filter expression
                    /// must use the supported [CEL logic operators]
                    /// (https://cloud.google.com/vpc/docs/about-flow-logs-records#supported_cel_logic_operators).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field to use to sort the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Optional. Number of `VpcFlowLogsConfigs` to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Page token from an earlier query, as returned in `next_page_token`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/vpcFlowLogsConfigs";

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

                /// <summary>
                /// Updates an existing `VpcFlowLogsConfig`. If a configuration with the exact same settings already
                /// exists (even if the ID is different), the creation fails. Notes: 1. Updating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - updating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Unique name of the configuration using one of the forms:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an existing `VpcFlowLogsConfig`. If a configuration with the exact same settings already
                /// exists (even if the ID is different), the creation fails. Notes: 1. Updating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - updating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                public class PatchRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Unique name of the configuration using one of the forms:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Location>
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
                        Pattern = @"^organizations/[^/]+/locations/[^/]+$",
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
            public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1beta1/{+name}/locations";

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
                        Pattern = @"^organizations/[^/]+$",
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
                VpcFlowLogsConfigs = new VpcFlowLogsConfigsResource(service);
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
                    ConnectivityTests = new ConnectivityTestsResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the ConnectivityTests resource.</summary>
                public virtual ConnectivityTestsResource ConnectivityTests { get; }

                /// <summary>The "connectivityTests" collection of methods.</summary>
                public class ConnectivityTestsResource
                {
                    private const string Resource = "connectivityTests";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectivityTestsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new Connectivity Test. After you create a test, the reachability analysis is performed
                    /// as part of the long running operation, which completes when the analysis completes. If the
                    /// endpoint specifications in `ConnectivityTest` are invalid (for example, containing non-existent
                    /// resources in the network, or you don't have read permissions to the network configurations of
                    /// listed projects), then the reachability result returns a value of `UNKNOWN`. If the endpoint
                    /// specifications in `ConnectivityTest` are incomplete, the reachability result returns a value of
                    /// AMBIGUOUS. For more information, see the Connectivity Test documentation.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource of the Connectivity Test to create:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new Connectivity Test. After you create a test, the reachability analysis is performed
                    /// as part of the long running operation, which completes when the analysis completes. If the
                    /// endpoint specifications in `ConnectivityTest` are invalid (for example, containing non-existent
                    /// resources in the network, or you don't have read permissions to the network configurations of
                    /// listed projects), then the reachability result returns a value of `UNKNOWN`. If the endpoint
                    /// specifications in `ConnectivityTest` are incomplete, the reachability result returns a value of
                    /// AMBIGUOUS. For more information, see the Connectivity Test documentation.
                    /// </summary>
                    public class CreateRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the Connectivity Test to create:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The logical name of the Connectivity Test in your project with the following
                        /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with
                        /// a letter. * Must be between 1-40 characters. * Must end with a number or a letter. * Must be
                        /// unique within the customer project
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("testId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/connectivityTests";

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
                            RequestParameters.Add("testId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "testId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a specific `ConnectivityTest`.</summary>
                    /// <param name="name">
                    /// Required. Connectivity Test resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a specific `ConnectivityTest`.</summary>
                    public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Connectivity Test resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the details of a specific Connectivity Test.</summary>
                    /// <param name="name">
                    /// Required. `ConnectivityTest` resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the details of a specific Connectivity Test.</summary>
                    public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. `ConnectivityTest` resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
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
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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

                    /// <summary>Lists all Connectivity Tests owned by a project.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource of the Connectivity Tests:
                    /// `projects/{project_id}/locations/global`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all Connectivity Tests owned by a project.</summary>
                    public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListConnectivityTestsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource of the Connectivity Tests:
                        /// `projects/{project_id}/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Lists the `ConnectivityTests` that match the filter expression. A filter expression filters
                        /// the resources listed in the response. The expression must be of the form ` ` where
                        /// operators: `&amp;lt;`, `&amp;gt;`, `&amp;lt;=`, `&amp;gt;=`, `!=`, `=`, `:` are supported
                        /// (colon `:` represents a HAS operator which is roughly synonymous with equality). can refer
                        /// to a proto or JSON field, or a synthetic field. Field names can be camelCase or snake_case.
                        /// Examples: - Filter by name: name =
                        /// "projects/proj-1/locations/global/connectivityTests/test-1 - Filter by labels: - Resources
                        /// that have a key called `foo` labels.foo:* - Resources that have a key called `foo` whose
                        /// value is `bar` labels.foo = bar
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Field to use to sort the list.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Number of `ConnectivityTests` to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token from an earlier query, as returned in `next_page_token`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/connectivityTests";

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

                    /// <summary>
                    /// Updates the configuration of an existing `ConnectivityTest`. After you update a test, the
                    /// reachability analysis is performed as part of the long running operation, which completes when
                    /// the analysis completes. The Reachability state in the test resource is updated with the new
                    /// result. If the endpoint specifications in `ConnectivityTest` are invalid (for example, they
                    /// contain non-existent resources in the network, or the user does not have read permissions to the
                    /// network configurations of listed projects), then the reachability result returns a value of
                    /// UNKNOWN. If the endpoint specifications in `ConnectivityTest` are incomplete, the reachability
                    /// result returns a value of `AMBIGUOUS`. See the documentation in `ConnectivityTest` for more
                    /// details.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. Unique name of the resource using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Updates the configuration of an existing `ConnectivityTest`. After you update a test, the
                    /// reachability analysis is performed as part of the long running operation, which completes when
                    /// the analysis completes. The Reachability state in the test resource is updated with the new
                    /// result. If the endpoint specifications in `ConnectivityTest` are invalid (for example, they
                    /// contain non-existent resources in the network, or the user does not have read permissions to the
                    /// network configurations of listed projects), then the reachability result returns a value of
                    /// UNKNOWN. If the endpoint specifications in `ConnectivityTest` are incomplete, the reachability
                    /// result returns a value of `AMBIGUOUS`. See the documentation in `ConnectivityTest` for more
                    /// details.
                    /// </summary>
                    public class PatchRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. Unique name of the resource using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.ConnectivityTest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    /// Rerun an existing `ConnectivityTest`. After the user triggers the rerun, the reachability
                    /// analysis is performed as part of the long running operation, which completes when the analysis
                    /// completes. Even though the test configuration remains the same, the reachability result may
                    /// change due to underlying network configuration changes. If the endpoint specifications in
                    /// `ConnectivityTest` become invalid (for example, specified resources are deleted in the network,
                    /// or you lost read permissions to the network configurations of listed projects), then the
                    /// reachability result returns a value of `UNKNOWN`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Connectivity Test resource name using the form:
                    /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                    /// </param>
                    public virtual RerunRequest Rerun(Google.Apis.NetworkManagement.v1beta1.Data.RerunConnectivityTestRequest body, string name)
                    {
                        return new RerunRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Rerun an existing `ConnectivityTest`. After the user triggers the rerun, the reachability
                    /// analysis is performed as part of the long running operation, which completes when the analysis
                    /// completes. Even though the test configuration remains the same, the reachability result may
                    /// change due to underlying network configuration changes. If the endpoint specifications in
                    /// `ConnectivityTest` become invalid (for example, specified resources are deleted in the network,
                    /// or you lost read permissions to the network configurations of listed projects), then the
                    /// reachability result returns a value of `UNKNOWN`.
                    /// </summary>
                    public class RerunRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                    {
                        /// <summary>Constructs a new Rerun request.</summary>
                        public RerunRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.RerunConnectivityTestRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Connectivity Test resource name using the form:
                        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.RerunConnectivityTestRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rerun";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:rerun";

                        /// <summary>Initializes Rerun parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.NetworkManagement.v1beta1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.NetworkManagement.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/global/connectivityTests/[^/]+$",
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
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of `1`, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.NetworkManagement.v1beta1.Data.CancelOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+name}:cancel";

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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Empty>
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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/locations/global/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListOperationsResponse>
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

            /// <summary>Gets the VpcFlowLogsConfigs resource.</summary>
            public virtual VpcFlowLogsConfigsResource VpcFlowLogsConfigs { get; }

            /// <summary>The "vpcFlowLogsConfigs" collection of methods.</summary>
            public class VpcFlowLogsConfigsResource
            {
                private const string Resource = "vpcFlowLogsConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VpcFlowLogsConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new `VpcFlowLogsConfig`. If a configuration with the exact same settings already exists
                /// (even if the ID is different), the creation fails. Notes: 1. Creating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - creating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the VPC Flow Logs configuration to create:
                /// `projects/{project_id}/locations/global` `organizations/{organization_id}/locations/global`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new `VpcFlowLogsConfig`. If a configuration with the exact same settings already exists
                /// (even if the ID is different), the creation fails. Notes: 1. Creating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - creating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                public class CreateRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the VPC Flow Logs configuration to create:
                    /// `projects/{project_id}/locations/global` `organizations/{organization_id}/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. ID of the `VpcFlowLogsConfig`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("vpcFlowLogsConfigId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VpcFlowLogsConfigId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/vpcFlowLogsConfigs";

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
                        RequestParameters.Add("vpcFlowLogsConfigId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "vpcFlowLogsConfigId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a specific `VpcFlowLogsConfig`.</summary>
                /// <param name="name">
                /// Required. `VpcFlowLogsConfig` resource name using one of the form:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a specific `VpcFlowLogsConfig`.</summary>
                public class DeleteRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. `VpcFlowLogsConfig` resource name using one of the form:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a specific `VpcFlowLogsConfig`.</summary>
                /// <param name="name">
                /// Required. `VpcFlowLogsConfig` resource name using the form:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a specific `VpcFlowLogsConfig`.</summary>
                public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. `VpcFlowLogsConfig` resource name using the form:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all `VpcFlowLogsConfigs` in a given project.</summary>
                /// <param name="parent">
                /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                /// `organizations/{organization_id}/locations/global`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all `VpcFlowLogsConfigs` in a given project.</summary>
                public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListVpcFlowLogsConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                    /// `organizations/{organization_id}/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists the `VpcFlowLogsConfigs` that match the filter expression. A filter expression
                    /// must use the supported [CEL logic operators]
                    /// (https://cloud.google.com/vpc/docs/about-flow-logs-records#supported_cel_logic_operators).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Field to use to sort the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Optional. Number of `VpcFlowLogsConfigs` to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Page token from an earlier query, as returned in `next_page_token`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/vpcFlowLogsConfigs";

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

                /// <summary>
                /// Updates an existing `VpcFlowLogsConfig`. If a configuration with the exact same settings already
                /// exists (even if the ID is different), the creation fails. Notes: 1. Updating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - updating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Unique name of the configuration using one of the forms:
                /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an existing `VpcFlowLogsConfig`. If a configuration with the exact same settings already
                /// exists (even if the ID is different), the creation fails. Notes: 1. Updating a configuration with
                /// state=DISABLED will fail 2. The following fields are not considered as `settings` for the purpose of
                /// the check mentioned above, therefore - updating another configuration with the same fields but
                /// different values for the following fields will fail as well: * name * create_time * update_time *
                /// labels * description
                /// </summary>
                public class PatchRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Unique name of the configuration using one of the forms:
                    /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                    /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.NetworkManagement.v1beta1.Data.VpcFlowLogsConfig Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vpcFlowLogsConfigs/[^/]+$",
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

                /// <summary>QueryOrgVpcFlowLogsConfigs lists Organization resources for a given project.</summary>
                /// <param name="parent">
                /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                /// </param>
                public virtual QueryOrgVpcFlowLogsConfigsRequest QueryOrgVpcFlowLogsConfigs(string parent)
                {
                    return new QueryOrgVpcFlowLogsConfigsRequest(this.service, parent);
                }

                /// <summary>QueryOrgVpcFlowLogsConfigs lists Organization resources for a given project.</summary>
                public class QueryOrgVpcFlowLogsConfigsRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.QueryOrgVpcFlowLogsConfigsResponse>
                {
                    /// <summary>Constructs a new QueryOrgVpcFlowLogsConfigs request.</summary>
                    public QueryOrgVpcFlowLogsConfigsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the VpcFlowLogsConfig: `projects/{project_id}/locations/global`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Lists the `VpcFlowLogsConfigs` that match the filter expression. A filter expression
                    /// must use the supported [CEL logic operators]
                    /// (https://cloud.google.com/vpc/docs/about-flow-logs-records#supported_cel_logic_operators).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Number of `VpcFlowLogsConfigs` to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Page token from an earlier query, as returned in `next_page_token`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryOrgVpcFlowLogsConfigs";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/vpcFlowLogsConfigs:queryOrgVpcFlowLogsConfigs";

                    /// <summary>Initializes QueryOrgVpcFlowLogsConfigs parameter list.</summary>
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
            public class GetRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.Location>
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
            public class ListRequest : NetworkManagementBaseServiceRequest<Google.Apis.NetworkManagement.v1beta1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1beta1/{+name}/locations";

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
        }
    }
}
namespace Google.Apis.NetworkManagement.v1beta1.Data
{
    /// <summary>Details of the final state "abort" and associated resource.</summary>
    public class AbortInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Causes that the analysis is aborted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>IP address that caused the abort.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// List of project IDs the user specified in the request but lacks access to. In this case, analysis is aborted
        /// with the PERMISSION_DENIED cause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectsMissingPermission")]
        public virtual System.Collections.Generic.IList<string> ProjectsMissingPermission { get; set; }

        /// <summary>URI of the resource that caused the abort.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for the App Engine service version attributes.</summary>
    public class AppEngineVersionEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An [App Engine](https://cloud.google.com/appengine) [service
        /// version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions) name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with an App Engine version.</summary>
    public class AppEngineVersionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of an App Engine version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>App Engine execution environment for a version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>Runtime of the App Engine version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtime")]
        public virtual string Runtime { get; set; }

        /// <summary>URI of an App Engine version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Cloud Function attributes.</summary>
    public class CloudFunctionEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A [Cloud Function](https://cloud.google.com/functions) name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Cloud Function.</summary>
    public class CloudFunctionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Location in which the Cloud Function is deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>URI of a Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Latest successfully deployed version id of the Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual System.Nullable<long> VersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper for Cloud Run revision attributes.</summary>
    public class CloudRunRevisionEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The URI of the Cloud Run service that the revision belongs to. The format is:
        /// projects/{project}/locations/{location}/services/{service}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceUri")]
        public virtual string ServiceUri { get; set; }

        /// <summary>
        /// A [Cloud Run](https://cloud.google.com/run)
        /// [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) URI. The format is:
        /// projects/{project}/locations/{location}/revisions/{revision}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Cloud Run revision.</summary>
    public class CloudRunRevisionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Cloud Run revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Location in which this revision is deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>URI of Cloud Run service this revision belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceUri")]
        public virtual string ServiceUri { get; set; }

        /// <summary>URI of a Cloud Run revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Cloud SQL instance.</summary>
    public class CloudSQLInstanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>External IP address of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Internal IP address of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>URI of a Cloud SQL instance network or empty string if the instance does not have one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Region in which the Cloud SQL instance is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Connectivity Test for a network reachability analysis.</summary>
    public class ConnectivityTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the analysis should skip firewall checking. Default value is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bypassFirewallChecks")]
        public virtual System.Nullable<bool> BypassFirewallChecks { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the test was created.</summary>
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

        /// <summary>The user-supplied description of the Connectivity Test. Maximum of 512 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Destination specification of the Connectivity Test. You can use a combination of destination IP
        /// address, URI of a supported endpoint, project ID, or VPC network to identify the destination location.
        /// Reachability analysis proceeds even if the destination location is ambiguous. However, the test result might
        /// include endpoints or use a destination that you don't intend to test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Endpoint Destination { get; set; }

        /// <summary>Output only. The display name of a Connectivity Test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource labels to represent user-provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Unique name of the resource using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The probing details of this test from the latest run, present for applicable tests only. The
        /// details are updated when creating a new test, updating an existing test, or triggering a one-time rerun of
        /// an existing test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probingDetails")]
        public virtual ProbingDetails ProbingDetails { get; set; }

        /// <summary>IP Protocol of the test. When not provided, "TCP" is assumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// Output only. The reachability details of this test from the latest run. The details are updated when
        /// creating a new test, updating an existing test, or triggering a one-time rerun of an existing test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachabilityDetails")]
        public virtual ReachabilityDetails ReachabilityDetails { get; set; }

        /// <summary>
        /// Other projects that may be relevant for reachability analysis. This is applicable to scenarios where a test
        /// can cross project boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedProjects")]
        public virtual System.Collections.Generic.IList<string> RelatedProjects { get; set; }

        /// <summary>
        /// Output only. The reachability details of this test from the latest run for the return path. The details are
        /// updated when creating a new test, updating an existing test, or triggering a one-time rerun of an existing
        /// test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnReachabilityDetails")]
        public virtual ReachabilityDetails ReturnReachabilityDetails { get; set; }

        /// <summary>
        /// Whether run analysis for the return path from destination to source. Default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roundTrip")]
        public virtual System.Nullable<bool> RoundTrip { get; set; }

        /// <summary>
        /// Required. Source specification of the Connectivity Test. You can use a combination of source IP address, URI
        /// of a supported endpoint, project ID, or VPC network to identify the source location. Reachability analysis
        /// might proceed even if the source location is ambiguous. However, the test result might include endpoints or
        /// use a source that you don't intend to test.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Endpoint Source { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the test's configuration was updated.</summary>
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

    /// <summary>Details of the final state "deliver" and associated resource.</summary>
    public class DeliverInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Recognized type of a Google Service the packet is delivered to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleServiceType")]
        public virtual string GoogleServiceType { get; set; }

        /// <summary>IP address of the target (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>PSC Google API target the packet is delivered to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscGoogleApiTarget")]
        public virtual string PscGoogleApiTarget { get; set; }

        /// <summary>URI of the resource that the packet is delivered to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Name of the Cloud Storage Bucket the packet is delivered to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBucket")]
        public virtual string StorageBucket { get; set; }

        /// <summary>Target type where the packet is delivered to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a serverless direct VPC egress connection.</summary>
    public class DirectVpcEgressConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of direct access network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Region in which the Direct VPC egress is deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Selected starting IP address, from the selected IP range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedIpAddress")]
        public virtual string SelectedIpAddress { get; set; }

        /// <summary>Selected IP range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedIpRange")]
        public virtual string SelectedIpRange { get; set; }

        /// <summary>URI of direct access subnetwork.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworkUri")]
        public virtual string SubnetworkUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the final state "drop" and associated resource.</summary>
    public class DropInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cause that the packet is dropped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>Destination IP address of the dropped packet (if relevant).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>Region of the dropped packet (if relevant).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of the resource that caused the drop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Source IP address of the dropped packet (if relevant).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of a network edge location as per https://cloud.google.com/vpc/docs/edge-locations.
    /// </summary>
    public class EdgeLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the metropolitan area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metropolitanArea")]
        public virtual string MetropolitanArea { get; set; }

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

    /// <summary>Source or destination of the Connectivity Test.</summary>
    public class Endpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An [AlloyDB Instance](https://cloud.google.com/alloydb) URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alloyDbInstance")]
        public virtual string AlloyDbInstance { get; set; }

        /// <summary>
        /// An [App Engine](https://cloud.google.com/appengine) [service
        /// version](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions).
        /// Applicable only to source endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineVersion")]
        public virtual AppEngineVersionEndpoint AppEngineVersion { get; set; }

        /// <summary>
        /// A [Cloud Function](https://cloud.google.com/functions). Applicable only to source endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudFunction")]
        public virtual CloudFunctionEndpoint CloudFunction { get; set; }

        /// <summary>
        /// A [Cloud Run](https://cloud.google.com/run)
        /// [revision](https://cloud.google.com/run/docs/reference/rest/v1/namespaces.revisions/get) Applicable only to
        /// source endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRunRevision")]
        public virtual CloudRunRevisionEndpoint CloudRunRevision { get; set; }

        /// <summary>A [Cloud SQL](https://cloud.google.com/sql) instance URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual string CloudSqlInstance { get; set; }

        /// <summary>
        /// A forwarding rule and its corresponding IP address represent the frontend configuration of a Google Cloud
        /// load balancer. Forwarding rules are also used for protocol forwarding, Private Service Connect and other
        /// network services to provide forwarding information in the control plane. Applicable only to destination
        /// endpoint. Format: projects/{project}/global/forwardingRules/{id} or
        /// projects/{project}/regions/{region}/forwardingRules/{id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual string ForwardingRule { get; set; }

        /// <summary>Output only. Specifies the type of the target of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRuleTarget")]
        public virtual string ForwardingRuleTarget { get; set; }

        /// <summary>
        /// DNS endpoint of [Google Kubernetes Engine cluster control
        /// plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture). Requires
        /// gke_master_cluster to be set, can't be used simultaneoulsly with ip_address or network. Applicable only to
        /// destination endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>
        /// A cluster URI for [Google Kubernetes Engine cluster control
        /// plane](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeMasterCluster")]
        public virtual string GkeMasterCluster { get; set; }

        /// <summary>A Compute Engine instance URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The IP address of the endpoint, which can be an external or internal IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// Output only. ID of the load balancer the forwarding rule points to. Empty for forwarding rules not related
        /// to load balancers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerId")]
        public virtual string LoadBalancerId { get; set; }

        /// <summary>Output only. Type of the load balancer the forwarding rule points to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

        /// <summary>A VPC network URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Type of the network where the endpoint is located. Applicable only to source endpoint, as destination
        /// network type can be inferred from the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkType")]
        public virtual string NetworkType { get; set; }

        /// <summary>The IP protocol port of the endpoint. Only applicable when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Project ID where the endpoint is located. The project ID can be derived from the URI if you provide a
        /// endpoint or network URI. The following are two cases where you may need to provide the project ID: 1. Only
        /// the IP address is specified, and the IP address is within a Google Cloud project. 2. When you are using
        /// Shared VPC and the IP address that you provide is from the service project. In this case, the network that
        /// the IP address resides in is defined in the host project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// A [Redis Cluster](https://cloud.google.com/memorystore/docs/cluster) URI. Applicable only to destination
        /// endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisCluster")]
        public virtual string RedisCluster { get; set; }

        /// <summary>
        /// A [Redis Instance](https://cloud.google.com/memorystore/docs/redis) URI. Applicable only to destination
        /// endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisInstance")]
        public virtual string RedisInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For display only. The specification of the endpoints for the test. EndpointInfo is derived from source and
    /// destination Endpoint and validated by the backend data plane model.
    /// </summary>
    public class EndpointInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>URI of the network where this packet is sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationNetworkUri")]
        public virtual string DestinationNetworkUri { get; set; }

        /// <summary>Destination port. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>URI of the source telemetry agent this packet originates from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceAgentUri")]
        public virtual string SourceAgentUri { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>URI of the network where this packet originates from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNetworkUri")]
        public virtual string SourceNetworkUri { get; set; }

        /// <summary>Source port. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

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

    /// <summary>
    /// For display only. Metadata associated with a VPC firewall rule, an implied VPC firewall rule, or a firewall
    /// policy rule.
    /// </summary>
    public class FirewallInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible values: ALLOW, DENY, APPLY_SECURITY_PROFILE_GROUP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Possible values: INGRESS, EGRESS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// The display name of the firewall rule. This field might be empty for firewall policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The firewall rule's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallRuleType")]
        public virtual string FirewallRuleType { get; set; }

        /// <summary>
        /// The URI of the VPC network that the firewall rule is associated with. This field is not applicable to
        /// hierarchical firewall policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>
        /// The name of the firewall policy that this rule is associated with. This field is not applicable to VPC
        /// firewall rules and implied VPC firewall rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>
        /// The priority of the firewall policy that this rule is associated with. This field is not applicable to VPC
        /// firewall rules and implied VPC firewall rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyPriority")]
        public virtual System.Nullable<int> PolicyPriority { get; set; }

        /// <summary>
        /// The URI of the firewall policy that this rule is associated with. This field is not applicable to VPC
        /// firewall rules and implied VPC firewall rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyUri")]
        public virtual string PolicyUri { get; set; }

        /// <summary>The priority of the firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>The target service accounts specified by the firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetServiceAccounts")]
        public virtual System.Collections.Generic.IList<string> TargetServiceAccounts { get; set; }

        /// <summary>
        /// The target tags defined by the VPC firewall rule. This field is not applicable to firewall policy rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTags")]
        public virtual System.Collections.Generic.IList<string> TargetTags { get; set; }

        /// <summary>The URI of the firewall rule. This field is not applicable to implied VPC firewall rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the final state "forward" and associated resource.</summary>
    public class ForwardInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IP address of the target (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>URI of the resource that the packet is forwarded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Target type where this packet is forwarded to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine forwarding rule.</summary>
    public class ForwardingRuleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Name of the load balancer the forwarding rule belongs to. Empty for forwarding rules not related to load
        /// balancers (like PSC forwarding rules).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerName")]
        public virtual string LoadBalancerName { get; set; }

        /// <summary>Port range defined in the forwarding rule that matches the packet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedPortRange")]
        public virtual string MatchedPortRange { get; set; }

        /// <summary>Protocol defined in the forwarding rule that matches the packet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedProtocol")]
        public virtual string MatchedProtocol { get; set; }

        /// <summary>Network URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>PSC Google API target this forwarding rule targets (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscGoogleApiTarget")]
        public virtual string PscGoogleApiTarget { get; set; }

        /// <summary>URI of the PSC service attachment this forwarding rule targets (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachmentUri")]
        public virtual string PscServiceAttachmentUri { get; set; }

        /// <summary>Region of the forwarding rule. Set only for regional forwarding rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Target type of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>URI of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>VIP of the forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vip")]
        public virtual string Vip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Google Kubernetes Engine (GKE) cluster master.</summary>
    public class GKEMasterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of a GKE cluster network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterNetworkUri")]
        public virtual string ClusterNetworkUri { get; set; }

        /// <summary>URI of a GKE cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterUri")]
        public virtual string ClusterUri { get; set; }

        /// <summary>DNS endpoint of a GKE cluster control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsEndpoint")]
        public virtual string DnsEndpoint { get; set; }

        /// <summary>External IP address of a GKE cluster control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Internal IP address of a GKE cluster control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For display only. Details of a Google Service sending packets to a VPC network. Although the source IP might be
    /// a publicly routable address, some Google Services use special routes within Google production infrastructure to
    /// reach Compute Engine Instances. https://cloud.google.com/vpc/docs/routes#special_return_paths
    /// </summary>
    public class GoogleServiceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Recognized type of a Google Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleServiceType")]
        public virtual string GoogleServiceType { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine instance.</summary>
    public class InstanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>External IP address of the network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIp")]
        public virtual string ExternalIp { get; set; }

        /// <summary>Name of the network interface of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interface")]
        public virtual string Interface__ { get; set; }

        /// <summary>Internal IP address of the network interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalIp")]
        public virtual string InternalIp { get; set; }

        /// <summary>Network tags configured on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkTags")]
        public virtual System.Collections.Generic.IList<string> NetworkTags { get; set; }

        /// <summary>URI of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>URI of the PSC network attachment the NIC is attached to (if relevant).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscNetworkAttachmentUri")]
        public virtual string PscNetworkAttachmentUri { get; set; }

        /// <summary>
        /// Indicates whether the Compute Engine instance is running. Deprecated: use the `status` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("running")]
        public virtual System.Nullable<bool> Running { get; set; }

        /// <summary>Service account authorized for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The status of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>URI of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes measured latency distribution.</summary>
    public class LatencyDistribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Representative latency percentiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyPercentiles")]
        public virtual System.Collections.Generic.IList<LatencyPercentile> LatencyPercentiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Latency percentile rank and value.</summary>
    public class LatencyPercentile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// percent-th percentile of latency observed, in microseconds. Fraction of percent/100 of samples have latency
        /// lower or equal to the value of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyMicros")]
        public virtual System.Nullable<long> LatencyMicros { get; set; }

        /// <summary>Percentage of samples this data point applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListConnectivityTests` method.</summary>
    public class ListConnectivityTestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to fetch the next set of Connectivity Tests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of Connectivity Tests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ConnectivityTest> Resources { get; set; }

        /// <summary>Locations that could not be reached (when querying all locations with `-`).</summary>
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

    /// <summary>Response for the `ListVpcFlowLogsConfigs` method.</summary>
    public class ListVpcFlowLogsConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to fetch the next set of configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached (when querying all locations with `-`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of VPC Flow Log configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcFlowLogsConfigs")]
        public virtual System.Collections.Generic.IList<VpcFlowLogsConfig> VpcFlowLogsConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a specific load balancer backend.</summary>
    public class LoadBalancerBackend : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine instance or network endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>A list of firewall rule URIs allowing probes from health check IP ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckAllowingFirewallRules")]
        public virtual System.Collections.Generic.IList<string> HealthCheckAllowingFirewallRules { get; set; }

        /// <summary>A list of firewall rule URIs blocking probes from health check IP ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckBlockingFirewallRules")]
        public virtual System.Collections.Generic.IList<string> HealthCheckBlockingFirewallRules { get; set; }

        /// <summary>State of the health check firewall configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckFirewallState")]
        public virtual string HealthCheckFirewallState { get; set; }

        /// <summary>URI of a Compute Engine instance or network endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with the load balancer backend.</summary>
    public class LoadBalancerBackendInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the backend bucket this backend targets (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendBucketUri")]
        public virtual string BackendBucketUri { get; set; }

        /// <summary>URI of the backend service this backend belongs to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendServiceUri")]
        public virtual string BackendServiceUri { get; set; }

        /// <summary>
        /// Output only. Health check firewalls configuration state for the backend. This is a result of the static
        /// firewall analysis (verifying that health check traffic from required IP ranges to the backend is allowed or
        /// not). The backend might still be unhealthy even if these firewalls are configured. Please refer to the
        /// documentation for more information: https://cloud.google.com/load-balancing/docs/firewall-rules
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckFirewallsConfigState")]
        public virtual string HealthCheckFirewallsConfigState { get; set; }

        /// <summary>URI of the health check attached to this backend (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckUri")]
        public virtual string HealthCheckUri { get; set; }

        /// <summary>URI of the instance group this backend belongs to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroupUri")]
        public virtual string InstanceGroupUri { get; set; }

        /// <summary>
        /// URI of the backend instance (if applicable). Populated for instance group backends, and zonal NEG backends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceUri")]
        public virtual string InstanceUri { get; set; }

        /// <summary>
        /// Display name of the backend. For example, it might be an instance name for the instance group backends, or
        /// an IP address and port for zonal network endpoint group backends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>URI of the network endpoint group this backend belongs to (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkEndpointGroupUri")]
        public virtual string NetworkEndpointGroupUri { get; set; }

        /// <summary>PSC Google API target this PSC NEG backend targets (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscGoogleApiTarget")]
        public virtual string PscGoogleApiTarget { get; set; }

        /// <summary>URI of the PSC service attachment this PSC NEG backend targets (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachmentUri")]
        public virtual string PscServiceAttachmentUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a load balancer.</summary>
    public class LoadBalancerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of load balancer's backend configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendType")]
        public virtual string BackendType { get; set; }

        /// <summary>Backend configuration URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendUri")]
        public virtual string BackendUri { get; set; }

        /// <summary>Information for the loadbalancer backends.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual System.Collections.Generic.IList<LoadBalancerBackend> Backends { get; set; }

        /// <summary>
        /// URI of the health check for the load balancer. Deprecated and no longer populated as different load balancer
        /// backends might have different health checks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckUri")]
        public virtual string HealthCheckUri { get; set; }

        /// <summary>Type of the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

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

    /// <summary>For display only. Metadata associated with NAT.</summary>
    public class NatInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of Cloud NAT Gateway. Only valid when type is CLOUD_NAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("natGatewayName")]
        public virtual string NatGatewayName { get; set; }

        /// <summary>URI of the network where NAT translation takes place.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Destination IP address after NAT translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDestinationIp")]
        public virtual string NewDestinationIp { get; set; }

        /// <summary>Destination port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDestinationPort")]
        public virtual System.Nullable<int> NewDestinationPort { get; set; }

        /// <summary>Source IP address after NAT translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSourceIp")]
        public virtual string NewSourceIp { get; set; }

        /// <summary>Source port after NAT translation. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSourcePort")]
        public virtual System.Nullable<int> NewSourcePort { get; set; }

        /// <summary>Destination IP address before NAT translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldDestinationIp")]
        public virtual string OldDestinationIp { get; set; }

        /// <summary>Destination port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldDestinationPort")]
        public virtual System.Nullable<int> OldDestinationPort { get; set; }

        /// <summary>Source IP address before NAT translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldSourceIp")]
        public virtual string OldSourceIp { get; set; }

        /// <summary>Source port before NAT translation. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldSourcePort")]
        public virtual System.Nullable<int> OldSourcePort { get; set; }

        /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Uri of the Cloud Router. Only valid when type is CLOUD_NAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routerUri")]
        public virtual string RouterUri { get; set; }

        /// <summary>Type of NAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine network.</summary>
    public class NetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The IP range of the subnet matching the source IP address of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedIpRange")]
        public virtual string MatchedIpRange { get; set; }

        /// <summary>URI of the subnet matching the source IP address of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedSubnetUri")]
        public virtual string MatchedSubnetUri { get; set; }

        /// <summary>The region of the subnet matching the source IP address of the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a Compute Engine network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

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

    /// <summary>Metadata describing an Operation</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Specifies if cancellation was requested for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

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

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>
        /// Target of the operation - for example projects/project-1/locations/global/connectivityTests/test-1
        /// </summary>
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

    /// <summary>Results of active probing from the last run of the test.</summary>
    public class ProbingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason probing was aborted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abortCause")]
        public virtual string AbortCause { get; set; }

        /// <summary>
        /// The EdgeLocation from which a packet, destined to the internet, will egress the Google network. This will
        /// only be populated for a connectivity test which has an internet destination address. The absence of this
        /// field *must not* be used as an indication that the destination is part of the Google network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEgressLocation")]
        public virtual EdgeLocation DestinationEgressLocation { get; set; }

        /// <summary>Probing results for all edge devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edgeResponses")]
        public virtual System.Collections.Generic.IList<SingleEdgeResponse> EdgeResponses { get; set; }

        /// <summary>
        /// The source and destination endpoints derived from the test input and used for active probing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointInfo")]
        public virtual EndpointInfo EndpointInfo { get; set; }

        /// <summary>Details about an internal failure or the cancellation of active probing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Whether all relevant edge devices were probed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probedAllDevices")]
        public virtual System.Nullable<bool> ProbedAllDevices { get; set; }

        /// <summary>
        /// Latency as measured by active probing in one direction: from the source to the destination endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probingLatency")]
        public virtual LatencyDistribution ProbingLatency { get; set; }

        /// <summary>The overall result of active probing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>Number of probes sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentProbeCount")]
        public virtual System.Nullable<int> SentProbeCount { get; set; }

        /// <summary>Number of probes that reached the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulProbeCount")]
        public virtual System.Nullable<int> SuccessfulProbeCount { get; set; }

        private string _verifyTimeRaw;

        private object _verifyTime;

        /// <summary>The time that reachability was assessed through active probing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyTime")]
        public virtual string VerifyTimeRaw
        {
            get => _verifyTimeRaw;
            set
            {
                _verifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _verifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VerifyTimeDateTimeOffset instead.")]
        public virtual object VerifyTime
        {
            get => _verifyTime;
            set
            {
                _verifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _verifyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VerifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VerifyTimeRaw);
            set => VerifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with ProxyConnection.</summary>
    public class ProxyConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the network where connection is proxied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Destination IP address of a new connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDestinationIp")]
        public virtual string NewDestinationIp { get; set; }

        /// <summary>Destination port of a new connection. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newDestinationPort")]
        public virtual System.Nullable<int> NewDestinationPort { get; set; }

        /// <summary>Source IP address of a new connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSourceIp")]
        public virtual string NewSourceIp { get; set; }

        /// <summary>Source port of a new connection. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSourcePort")]
        public virtual System.Nullable<int> NewSourcePort { get; set; }

        /// <summary>Destination IP address of an original connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldDestinationIp")]
        public virtual string OldDestinationIp { get; set; }

        /// <summary>Destination port of an original connection. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldDestinationPort")]
        public virtual System.Nullable<int> OldDestinationPort { get; set; }

        /// <summary>Source IP address of an original connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldSourceIp")]
        public virtual string OldSourceIp { get; set; }

        /// <summary>Source port of an original connection. Only valid when protocol is TCP or UDP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldSourcePort")]
        public virtual System.Nullable<int> OldSourcePort { get; set; }

        /// <summary>IP protocol in string format, for example: "TCP", "UDP", "ICMP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Uri of proxy subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetUri")]
        public virtual string SubnetUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `QueryVpcFlowLogsConfigs` method.</summary>
    public class QueryOrgVpcFlowLogsConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Page token to fetch the next set of configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached (when querying all locations with `-`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>List of VPC Flow Log configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcFlowLogsConfigs")]
        public virtual System.Collections.Generic.IList<VpcFlowLogsConfig> VpcFlowLogsConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results of the configuration analysis from the last run of the test.</summary>
    public class ReachabilityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The details of a failure or a cancellation of reachability analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The overall result of the test's configuration analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>
        /// Result may contain a list of traces if a test has multiple possible paths in the network, such as when
        /// destination endpoint is a load balancer with multiple backends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> Traces { get; set; }

        private string _verifyTimeRaw;

        private object _verifyTime;

        /// <summary>The time of the configuration analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyTime")]
        public virtual string VerifyTimeRaw
        {
            get => _verifyTimeRaw;
            set
            {
                _verifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _verifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use VerifyTimeDateTimeOffset instead.")]
        public virtual object VerifyTime
        {
            get => _verifyTime;
            set
            {
                _verifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _verifyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="VerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? VerifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(VerifyTimeRaw);
            set => VerifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Redis Cluster.</summary>
    public class RedisClusterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Discovery endpoint IP address of a Redis Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryEndpointIpAddress")]
        public virtual string DiscoveryEndpointIpAddress { get; set; }

        /// <summary>Name of a Redis Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Name of the region in which the Redis Cluster is defined. For example, "us-central1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// URI of the network containing the Redis Cluster endpoints in format
        /// "projects/{project_id}/global/networks/{network_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Secondary endpoint IP address of a Redis Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryEndpointIpAddress")]
        public virtual string SecondaryEndpointIpAddress { get; set; }

        /// <summary>
        /// URI of a Redis Cluster in format "projects/{project_id}/locations/{location}/clusters/{cluster_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Cloud Redis Instance.</summary>
    public class RedisInstanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a Cloud Redis Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URI of a Cloud Redis Instance network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Primary endpoint IP address of a Cloud Redis Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEndpointIp")]
        public virtual string PrimaryEndpointIp { get; set; }

        /// <summary>Read endpoint IP address of a Cloud Redis Instance (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readEndpointIp")]
        public virtual string ReadEndpointIp { get; set; }

        /// <summary>Region in which the Cloud Redis Instance is defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a Cloud Redis Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `RerunConnectivityTest` method.</summary>
    public class RerunConnectivityTestRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine route.</summary>
    public class RouteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For ADVERTISED routes, the URI of their next hop, i.e. the URI of the hybrid endpoint (VPN tunnel,
        /// Interconnect attachment, NCC router appliance) the advertised prefix is advertised through, or URI of the
        /// source peered network. Deprecated in favor of the next_hop_uri field, not used in new tests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertisedRouteNextHopUri")]
        public virtual string AdvertisedRouteNextHopUri { get; set; }

        /// <summary>
        /// For ADVERTISED dynamic routes, the URI of the Cloud Router that advertised the corresponding IP prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertisedRouteSourceRouterUri")]
        public virtual string AdvertisedRouteSourceRouterUri { get; set; }

        /// <summary>Destination IP range of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destIpRange")]
        public virtual string DestIpRange { get; set; }

        /// <summary>Destination port ranges of the route. POLICY_BASED routes only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destPortRanges")]
        public virtual System.Collections.Generic.IList<string> DestPortRanges { get; set; }

        /// <summary>Name of a route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Instance tags of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTags")]
        public virtual System.Collections.Generic.IList<string> InstanceTags { get; set; }

        /// <summary>
        /// For PEERING_SUBNET and PEERING_DYNAMIC routes that are advertised by NCC Hub, the URI of the corresponding
        /// route in NCC Hub's routing table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nccHubRouteUri")]
        public virtual string NccHubRouteUri { get; set; }

        /// <summary>
        /// URI of the NCC Hub the route is advertised by. PEERING_SUBNET and PEERING_DYNAMIC routes that are advertised
        /// by NCC Hub only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nccHubUri")]
        public virtual string NccHubUri { get; set; }

        /// <summary>
        /// URI of the destination NCC Spoke. PEERING_SUBNET and PEERING_DYNAMIC routes that are advertised by NCC Hub
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nccSpokeUri")]
        public virtual string NccSpokeUri { get; set; }

        /// <summary>URI of a VPC network where route is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>
        /// String type of the next hop of the route (for example, "VPN tunnel"). Deprecated in favor of the
        /// next_hop_type and next_hop_uri fields, not used in new tests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHop")]
        public virtual string NextHop { get; set; }

        /// <summary>URI of a VPC network where the next hop resource is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHopNetworkUri")]
        public virtual string NextHopNetworkUri { get; set; }

        /// <summary>Type of next hop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHopType")]
        public virtual string NextHopType { get; set; }

        /// <summary>URI of the next hop resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextHopUri")]
        public virtual string NextHopUri { get; set; }

        /// <summary>
        /// For PEERING_SUBNET, PEERING_STATIC and PEERING_DYNAMIC routes, the name of the originating
        /// SUBNET/STATIC/DYNAMIC route.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatingRouteDisplayName")]
        public virtual string OriginatingRouteDisplayName { get; set; }

        /// <summary>
        /// For PEERING_SUBNET and PEERING_STATIC routes, the URI of the originating SUBNET/STATIC route.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originatingRouteUri")]
        public virtual string OriginatingRouteUri { get; set; }

        /// <summary>Priority of the route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>Protocols of the route. POLICY_BASED routes only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocols")]
        public virtual System.Collections.Generic.IList<string> Protocols { get; set; }

        /// <summary>
        /// Region of the route. DYNAMIC, PEERING_DYNAMIC, POLICY_BASED and ADVERTISED routes only. If set for
        /// POLICY_BASED route, this is a region of VLAN attachments for Cloud Interconnect the route applies to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// Indicates where route is applicable. Deprecated, routes with NCC_HUB scope are not included in the trace in
        /// new tests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeScope")]
        public virtual string RouteScope { get; set; }

        /// <summary>Type of route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeType")]
        public virtual string RouteType { get; set; }

        /// <summary>Source IP address range of the route. POLICY_BASED routes only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("srcIpRange")]
        public virtual string SrcIpRange { get; set; }

        /// <summary>Source port ranges of the route. POLICY_BASED routes only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("srcPortRanges")]
        public virtual System.Collections.Generic.IList<string> SrcPortRanges { get; set; }

        /// <summary>
        /// URI of a route. SUBNET, STATIC, PEERING_SUBNET (only for peering network) and POLICY_BASED routes only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a serverless public connection.</summary>
    public class ServerlessExternalConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selected starting IP address, from the Google dynamic address pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedIpAddress")]
        public virtual string SelectedIpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with the serverless network endpoint group backend.</summary>
    public class ServerlessNegInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URI of the serverless network endpoint group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negUri")]
        public virtual string NegUri { get; set; }

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

    /// <summary>Probing results for a single edge device.</summary>
    public class SingleEdgeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The EdgeLocation from which a packet, destined to the internet, will egress the Google network. This will
        /// only be populated for a connectivity test which has an internet destination address. The absence of this
        /// field *must not* be used as an indication that the destination is part of the Google network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationEgressLocation")]
        public virtual EdgeLocation DestinationEgressLocation { get; set; }

        /// <summary>Router name in the format '{router}.{metroshard}'. For example: pf01.aaa01, pr02.aaa01.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationRouter")]
        public virtual string DestinationRouter { get; set; }

        /// <summary>
        /// Latency as measured by active probing in one direction: from the source to the destination endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("probingLatency")]
        public virtual LatencyDistribution ProbingLatency { get; set; }

        /// <summary>The overall result of active probing for this egress device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>Number of probes sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentProbeCount")]
        public virtual System.Nullable<int> SentProbeCount { get; set; }

        /// <summary>Number of probes that reached the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulProbeCount")]
        public virtual System.Nullable<int> SuccessfulProbeCount { get; set; }

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
    /// A simulated forwarding path is composed of multiple steps. Each step has a well-defined state and an associated
    /// configuration.
    /// </summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display information of the final state "abort" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abort")]
        public virtual AbortInfo Abort { get; set; }

        /// <summary>Display information of an App Engine service version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineVersion")]
        public virtual AppEngineVersionInfo AppEngineVersion { get; set; }

        /// <summary>This is a step that leads to the final state Drop.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("causesDrop")]
        public virtual System.Nullable<bool> CausesDrop { get; set; }

        /// <summary>Display information of a Cloud Function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudFunction")]
        public virtual CloudFunctionInfo CloudFunction { get; set; }

        /// <summary>Display information of a Cloud Run revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRunRevision")]
        public virtual CloudRunRevisionInfo CloudRunRevision { get; set; }

        /// <summary>Display information of a Cloud SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual CloudSQLInstanceInfo CloudSqlInstance { get; set; }

        /// <summary>Display information of the final state "deliver" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliver")]
        public virtual DeliverInfo Deliver { get; set; }

        /// <summary>A description of the step. Usually this is a summary of the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display information of a serverless direct VPC egress connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directVpcEgressConnection")]
        public virtual DirectVpcEgressConnectionInfo DirectVpcEgressConnection { get; set; }

        /// <summary>Display information of the final state "drop" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drop")]
        public virtual DropInfo Drop { get; set; }

        /// <summary>
        /// Display information of the source and destination under analysis. The endpoint information in an
        /// intermediate state may differ with the initial input, as it might be modified by state like NAT, or
        /// Connection Proxy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual EndpointInfo Endpoint { get; set; }

        /// <summary>Display information of a Compute Engine firewall rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewall")]
        public virtual FirewallInfo Firewall { get; set; }

        /// <summary>Display information of the final state "forward" and reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forward")]
        public virtual ForwardInfo Forward { get; set; }

        /// <summary>Display information of a Compute Engine forwarding rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual ForwardingRuleInfo ForwardingRule { get; set; }

        /// <summary>Display information of a Google Kubernetes Engine cluster master.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeMaster")]
        public virtual GKEMasterInfo GkeMaster { get; set; }

        /// <summary>Display information of a Google service</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleService")]
        public virtual GoogleServiceInfo GoogleService { get; set; }

        /// <summary>Display information of a Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual InstanceInfo Instance { get; set; }

        /// <summary>
        /// Display information of the load balancers. Deprecated in favor of the `load_balancer_backend_info` field,
        /// not used in new tests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual LoadBalancerInfo LoadBalancer { get; set; }

        /// <summary>Display information of a specific load balancer backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerBackendInfo")]
        public virtual LoadBalancerBackendInfo LoadBalancerBackendInfo { get; set; }

        /// <summary>Display information of a NAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nat")]
        public virtual NatInfo Nat { get; set; }

        /// <summary>Display information of a Google Cloud network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual NetworkInfo Network { get; set; }

        /// <summary>Project ID that contains the configuration this step is validating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Display information of a ProxyConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyConnection")]
        public virtual ProxyConnectionInfo ProxyConnection { get; set; }

        /// <summary>Display information of a Redis Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisCluster")]
        public virtual RedisClusterInfo RedisCluster { get; set; }

        /// <summary>Display information of a Redis Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisInstance")]
        public virtual RedisInstanceInfo RedisInstance { get; set; }

        /// <summary>Display information of a Compute Engine route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("route")]
        public virtual RouteInfo Route { get; set; }

        /// <summary>Display information of a serverless public (external) connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverlessExternalConnection")]
        public virtual ServerlessExternalConnectionInfo ServerlessExternalConnection { get; set; }

        /// <summary>
        /// Display information of a Serverless network endpoint group backend. Used only for return traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverlessNeg")]
        public virtual ServerlessNegInfo ServerlessNeg { get; set; }

        /// <summary>Each step is in one of the pre-defined states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Display information of a Storage Bucket. Used only for return traces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageBucket")]
        public virtual StorageBucketInfo StorageBucket { get; set; }

        /// <summary>Display information of a VPC connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcConnector")]
        public virtual VpcConnectorInfo VpcConnector { get; set; }

        /// <summary>Display information of a Compute Engine VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnGateway")]
        public virtual VpnGatewayInfo VpnGateway { get; set; }

        /// <summary>Display information of a Compute Engine VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnTunnel")]
        public virtual VpnTunnelInfo VpnTunnel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with Storage Bucket.</summary>
    public class StorageBucketInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage Bucket name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

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
    /// Trace represents one simulated packet forwarding path. * Each trace contains multiple ordered steps. * Each step
    /// is in a particular state with associated configuration. * State is categorized as final or non-final states. *
    /// Each final state has a reason associated. * Each trace must end with a final state (the last step).
    /// ```
    /// |---------------------Trace----------------------| Step1(State) Step2(State) --- StepN(State(final))
    /// ```
    /// </summary>
    public class Trace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Derived from the source and destination endpoints definition specified by user request, and validated by the
        /// data plane model. If there are multiple traces starting from different source locations, then the
        /// endpoint_info may be different between traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointInfo")]
        public virtual EndpointInfo EndpointInfo { get; set; }

        /// <summary>
        /// ID of trace. For forward traces, this ID is unique for each trace. For return traces, it matches ID of
        /// associated forward trace. A single forward trace can be associated with none, one or more than one return
        /// trace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardTraceId")]
        public virtual System.Nullable<int> ForwardTraceId { get; set; }

        /// <summary>
        /// A trace of a test contains multiple steps from the initial state to the final state (delivered, dropped,
        /// forwarded, or aborted). The steps are ordered by the processing sequence within the simulated network state
        /// machine. It is critical to preserve the order of the steps and avoid reordering or sorting them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<Step> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a VPC connector.</summary>
    public class VpcConnectorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a VPC connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Location in which the VPC connector is deployed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>URI of a VPC connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A configuration to generate VPC Flow Logs.</summary>
    public class VpcFlowLogsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The aggregation interval for the logs. Default value is INTERVAL_5_SEC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationInterval")]
        public virtual string AggregationInterval { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the config was created.</summary>
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
        /// Optional. Determines whether to include cross project annotations in the logs. This field is available only
        /// for organization configurations. If not specified in org configs will be set to
        /// CROSS_PROJECT_METADATA_ENABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossProjectMetadata")]
        public virtual string CrossProjectMetadata { get; set; }

        /// <summary>
        /// Optional. The user-supplied description of the VPC Flow Logs configuration. Maximum of 512 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Export filter used to define which VPC Flow Logs should be logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterExpr")]
        public virtual string FilterExpr { get; set; }

        /// <summary>
        /// Optional. The value of the field must be in (0, 1]. The sampling rate of VPC Flow Logs where 1.0 means all
        /// collected logs are reported. Setting the sampling rate to 0.0 is not allowed. If you want to disable VPC
        /// Flow Logs, use the state field instead. Default value is 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flowSampling")]
        public virtual System.Nullable<float> FlowSampling { get; set; }

        /// <summary>
        /// Traffic will be logged from the Interconnect Attachment. Format:
        /// projects/{project_id}/regions/{region}/interconnectAttachments/{name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interconnectAttachment")]
        public virtual string InterconnectAttachment { get; set; }

        /// <summary>Optional. Resource labels to represent user-provided metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Configures whether all, none or a subset of metadata fields should be added to the reported VPC
        /// flow logs. Default value is INCLUDE_ALL_METADATA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual string Metadata { get; set; }

        /// <summary>
        /// Optional. Custom metadata fields to include in the reported VPC flow logs. Can only be specified if
        /// "metadata" was set to CUSTOM_METADATA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataFields")]
        public virtual System.Collections.Generic.IList<string> MetadataFields { get; set; }

        /// <summary>
        /// Identifier. Unique name of the configuration using one of the forms:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
        /// `organizations/{organization_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Traffic will be logged from VMs, VPN tunnels and Interconnect Attachments within the network. Format:
        /// projects/{project_id}/global/networks/{name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The state of the VPC Flow Log configuration. Default value is ENABLED. When creating a new
        /// configuration, it must be enabled. Setting state=DISABLED will pause the log generation for this config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Traffic will be logged from VMs within the subnetwork. Format:
        /// projects/{project_id}/regions/{region}/subnetworks/{name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnet")]
        public virtual string Subnet { get; set; }

        /// <summary>
        /// Output only. A diagnostic bit - describes the state of the configured target resource for diagnostic
        /// purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResourceState")]
        public virtual string TargetResourceState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the config was updated.</summary>
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
        /// Traffic will be logged from the VPN Tunnel. Format: projects/{project_id}/regions/{region}/vpnTunnels/{name}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnTunnel")]
        public virtual string VpnTunnel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine VPN gateway.</summary>
    public class VpnGatewayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>IP address of the VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>URI of a Compute Engine network where the VPN gateway is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Name of a Google Cloud region where this VPN gateway is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a VPN gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// A VPN tunnel that is associated with this VPN gateway. There may be multiple VPN tunnels configured on a VPN
        /// gateway, and only the one relevant to the test is displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnTunnelUri")]
        public virtual string VpnTunnelUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For display only. Metadata associated with a Compute Engine VPN tunnel.</summary>
    public class VpnTunnelInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URI of a Compute Engine network where the VPN tunnel is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUri")]
        public virtual string NetworkUri { get; set; }

        /// <summary>Name of a Google Cloud region where this VPN tunnel is configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>URI of a VPN gateway at remote end of the tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteGateway")]
        public virtual string RemoteGateway { get; set; }

        /// <summary>Remote VPN gateway's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteGatewayIp")]
        public virtual string RemoteGatewayIp { get; set; }

        /// <summary>Type of the routing policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingType")]
        public virtual string RoutingType { get; set; }

        /// <summary>URI of the VPN gateway at local end of the tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceGateway")]
        public virtual string SourceGateway { get; set; }

        /// <summary>Local VPN gateway's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceGatewayIp")]
        public virtual string SourceGatewayIp { get; set; }

        /// <summary>URI of a VPN tunnel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
