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

namespace Google.Apis.SecurityPosture.v1
{
    /// <summary>The SecurityPosture Service.</summary>
    public class SecurityPostureService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SecurityPostureService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SecurityPostureService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://securityposture.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://securityposture.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "securityposture";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Security Posture API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Security Posture API.</summary>
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

    /// <summary>A base abstract class for SecurityPosture requests.</summary>
    public abstract class SecurityPostureBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SecurityPostureBaseServiceRequest instance.</summary>
        protected SecurityPostureBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SecurityPosture parameter list.</summary>
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
                Operations = new OperationsResource(service);
                PostureDeployments = new PostureDeploymentsResource(service);
                PostureTemplates = new PostureTemplatesResource(service);
                Postures = new PosturesResource(service);
                Reports = new ReportsResource(service);
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
                public virtual CancelRequest Cancel(Google.Apis.SecurityPosture.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Empty>
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
                public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
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
                public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PostureDeployments resource.</summary>
            public virtual PostureDeploymentsResource PostureDeployments { get; }

            /// <summary>The "postureDeployments" collection of methods.</summary>
            public class PostureDeploymentsResource
            {
                private const string Resource = "postureDeployments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PostureDeploymentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new PostureDeployment in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityPosture.v1.Data.PostureDeployment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new PostureDeployment in a given project and location.</summary>
                public class CreateRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.PostureDeployment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. An identifier for the posture deployment.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("postureDeploymentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PostureDeploymentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.PostureDeployment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postureDeployments";

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
                        RequestParameters.Add("postureDeploymentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "postureDeploymentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a PostureDeployment.</summary>
                /// <param name="name">
                /// Required. The name of the posture deployment, in the format
                /// `organizations/{organization}/locations/global/postureDeployments/{posture_id}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a PostureDeployment.</summary>
                public class DeleteRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the posture deployment, in the format
                    /// `organizations/{organization}/locations/global/postureDeployments/{posture_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An opaque identifier for the current version of the posture deployment. If you provide
                    /// this value, then it must match the existing value. If the values don't match, then the request
                    /// fails with an ABORTED error. If you omit this value, then the posture deployment is deleted
                    /// regardless of its current `etag` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postureDeployments/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details for a PostureDeployment.</summary>
                /// <param name="name">
                /// Required. The name of the PostureDeployment, in the format
                /// `organizations/{organization}/locations/global/postureDeployments/{posture_deployment_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details for a PostureDeployment.</summary>
                public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.PostureDeployment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the PostureDeployment, in the format
                    /// `organizations/{organization}/locations/global/postureDeployments/{posture_deployment_id}`.
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postureDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists every PostureDeployment in a project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists every PostureDeployment in a project and location.</summary>
                public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListPostureDeploymentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A filter to apply to the list of postures, in the format defined in [AIP-160:
                    /// Filtering](https://google.aip.dev/160).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of posture deployments to return. The default value is `500`. If
                    /// you exceed the maximum value of `1000`, then the service uses the maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A pagination token returned from a previous request to list posture deployments.
                    /// Provide this token to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postureDeployments";

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
                /// Updates an existing PostureDeployment. To prevent concurrent updates from overwriting each other,
                /// always follow the read-modify-write pattern when you update a posture deployment: 1. Call
                /// GetPostureDeployment to get the current version of the deployment. 2. Update the fields in the
                /// deployment as needed. 3. Call UpdatePostureDeployment to update the deployment. Ensure that your
                /// request includes the `etag` value from the GetPostureDeployment response. **Important:** If you omit
                /// the `etag` when you call UpdatePostureDeployment, then the updated deployment unconditionally
                /// overwrites the existing deployment.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. The name of the posture deployment, in the format
                /// `organizations/{organization}/locations/global/postureDeployments/{deployment_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityPosture.v1.Data.PostureDeployment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates an existing PostureDeployment. To prevent concurrent updates from overwriting each other,
                /// always follow the read-modify-write pattern when you update a posture deployment: 1. Call
                /// GetPostureDeployment to get the current version of the deployment. 2. Update the fields in the
                /// deployment as needed. 3. Call UpdatePostureDeployment to update the deployment. Ensure that your
                /// request includes the `etag` value from the GetPostureDeployment response. **Important:** If you omit
                /// the `etag` when you call UpdatePostureDeployment, then the updated deployment unconditionally
                /// overwrites the existing deployment.
                /// </summary>
                public class PatchRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.PostureDeployment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. The name of the posture deployment, in the format
                    /// `organizations/{organization}/locations/global/postureDeployments/{deployment_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The fields in the PostureDeployment to update. You can update only the following
                    /// fields: * PostureDeployment.posture_id * PostureDeployment.posture_revision_id
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.PostureDeployment Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postureDeployments/[^/]+$",
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

            /// <summary>Gets the PostureTemplates resource.</summary>
            public virtual PostureTemplatesResource PostureTemplates { get; }

            /// <summary>The "postureTemplates" collection of methods.</summary>
            public class PostureTemplatesResource
            {
                private const string Resource = "postureTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PostureTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a single revision of a PostureTemplate.</summary>
                /// <param name="name">
                /// Required. The name of the PostureTemplate, in the format
                /// `organizations/{organization}/locations/global/postureTemplates/{posture_template}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a single revision of a PostureTemplate.</summary>
                public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.PostureTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the PostureTemplate, in the format
                    /// `organizations/{organization}/locations/global/postureTemplates/{posture_template}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The posture template revision to retrieve. If not specified, the most recently updated
                    /// revision is retrieved.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RevisionId { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postureTemplates/[^/]+$",
                        });
                        RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "revisionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists every PostureTemplate in a given organization and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists every PostureTemplate in a given organization and location.</summary>
                public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListPostureTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A filter to apply to the list of postures, in the format defined in [AIP-160:
                    /// Filtering](https://google.aip.dev/160).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of posture templates to return. The default value is `500`. If you
                    /// exceed the maximum value of `1000`, then the service uses the maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A pagination token returned from a previous request to list posture templates. Provide
                    /// this token to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postureTemplates";

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

            /// <summary>Gets the Postures resource.</summary>
            public virtual PosturesResource Postures { get; }

            /// <summary>The "postures" collection of methods.</summary>
            public class PosturesResource
            {
                private const string Resource = "postures";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PosturesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Posture.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityPosture.v1.Data.Posture body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Posture.</summary>
                public class CreateRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.Posture body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. An identifier for the posture.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("postureId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PostureId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.Posture Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postures";

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
                        RequestParameters.Add("postureId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "postureId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes all revisions of a Posture. You can only delete a posture if none of its revisions are
                /// deployed.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the Posture, in the format
                /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes all revisions of a Posture. You can only delete a posture if none of its revisions are
                /// deployed.
                /// </summary>
                public class DeleteRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Posture, in the format
                    /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An opaque identifier for the current version of the posture. If you provide this
                    /// value, then it must match the existing value. If the values don't match, then the request fails
                    /// with an ABORTED error. If you omit this value, then the posture is deleted regardless of its
                    /// current `etag` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postures/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Extracts existing policies from an organization, folder, or project, and applies them to another
                /// organization, folder, or project as a Posture. If the other organization, folder, or project already
                /// has a posture, then the result of the long-running operation is an ALREADY_EXISTS error.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual ExtractRequest Extract(Google.Apis.SecurityPosture.v1.Data.ExtractPostureRequest body, string parent)
                {
                    return new ExtractRequest(this.service, body, parent);
                }

                /// <summary>
                /// Extracts existing policies from an organization, folder, or project, and applies them to another
                /// organization, folder, or project as a Posture. If the other organization, folder, or project already
                /// has a posture, then the result of the long-running operation is an ALREADY_EXISTS error.
                /// </summary>
                public class ExtractRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Extract request.</summary>
                    public ExtractRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.ExtractPostureRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.ExtractPostureRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "extract";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postures:extract";

                    /// <summary>Initializes Extract parameter list.</summary>
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
                    }
                }

                /// <summary>Gets a single revision of a Posture.</summary>
                /// <param name="name">
                /// Required. The name of the Posture, in the format
                /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a single revision of a Posture.</summary>
                public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Posture>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Posture, in the format
                    /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The posture revision to retrieve. If not specified, the most recently updated revision
                    /// is retrieved.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RevisionId { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postures/[^/]+$",
                        });
                        RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "revisionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists the most recent revisions of all Posture resources in a specified organization and location.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the most recent revisions of all Posture resources in a specified organization and location.
                /// </summary>
                public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListPosturesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A filter to apply to the list of postures, in the format defined in [AIP-160:
                    /// Filtering](https://google.aip.dev/160).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of postures to return. The default value is `500`. If you exceed the maximum
                    /// value of `1000`, then the service uses the maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous request to list postures. Provide this token to
                    /// retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/postures";

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

                /// <summary>Lists all revisions of a single Posture.</summary>
                /// <param name="name">
                /// Required. The name of the Posture, in the format
                /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                /// </param>
                public virtual ListRevisionsRequest ListRevisions(string name)
                {
                    return new ListRevisionsRequest(this.service, name);
                }

                /// <summary>Lists all revisions of a single Posture.</summary>
                public class ListRevisionsRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListPostureRevisionsResponse>
                {
                    /// <summary>Constructs a new ListRevisions request.</summary>
                    public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Posture, in the format
                    /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of posture revisions to return. The default value is `500`. If you
                    /// exceed the maximum value of `1000`, then the service uses the maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A pagination token from a previous request to list posture revisions. Provide this
                    /// token to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listRevisions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:listRevisions";

                    /// <summary>Initializes ListRevisions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postures/[^/]+$",
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
                /// Updates a revision of an existing Posture. If the posture revision that you update is currently
                /// deployed, then a new revision of the posture is created. To prevent concurrent updates from
                /// overwriting each other, always follow the read-modify-write pattern when you update a posture: 1.
                /// Call GetPosture to get the current version of the posture. 2. Update the fields in the posture as
                /// needed. 3. Call UpdatePosture to update the posture. Ensure that your request includes the `etag`
                /// value from the GetPosture response. **Important:** If you omit the `etag` when you call
                /// UpdatePosture, then the updated posture unconditionally overwrites the existing posture.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Identifier. The name of the posture, in the format
                /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityPosture.v1.Data.Posture body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a revision of an existing Posture. If the posture revision that you update is currently
                /// deployed, then a new revision of the posture is created. To prevent concurrent updates from
                /// overwriting each other, always follow the read-modify-write pattern when you update a posture: 1.
                /// Call GetPosture to get the current version of the posture. 2. Update the fields in the posture as
                /// needed. 3. Call UpdatePosture to update the posture. Ensure that your request includes the `etag`
                /// value from the GetPosture response. **Important:** If you omit the `etag` when you call
                /// UpdatePosture, then the updated posture unconditionally overwrites the existing posture.
                /// </summary>
                public class PatchRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.Posture body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Identifier. The name of the posture, in the format
                    /// `organizations/{organization}/locations/global/postures/{posture_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The revision ID of the posture to update. If the posture revision that you update is
                    /// currently deployed, then a new revision of the posture is created.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("revisionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RevisionId { get; set; }

                    /// <summary>
                    /// Required. The fields in the Posture to update. You can update only the following fields: *
                    /// Posture.description * Posture.policy_sets * Posture.state
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.Posture Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/postures/[^/]+$",
                        });
                        RequestParameters.Add("revisionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "revisionId",
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
            }

            /// <summary>Gets the Reports resource.</summary>
            public virtual ReportsResource Reports { get; }

            /// <summary>The "reports" collection of methods.</summary>
            public class ReportsResource
            {
                private const string Resource = "reports";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReportsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Validates a specified infrastructure-as-code (IaC) configuration, and creates a Report with the
                /// validation results. Only Terraform configurations are supported. Only modified assets are validated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual CreateIaCValidationReportRequest CreateIaCValidationReport(Google.Apis.SecurityPosture.v1.Data.CreateIaCValidationReportRequest body, string parent)
                {
                    return new CreateIaCValidationReportRequest(this.service, body, parent);
                }

                /// <summary>
                /// Validates a specified infrastructure-as-code (IaC) configuration, and creates a Report with the
                /// validation results. Only Terraform configurations are supported. Only modified assets are validated.
                /// </summary>
                public class CreateIaCValidationReportRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Operation>
                {
                    /// <summary>Constructs a new CreateIaCValidationReport request.</summary>
                    public CreateIaCValidationReportRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityPosture.v1.Data.CreateIaCValidationReportRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityPosture.v1.Data.CreateIaCValidationReportRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createIaCValidationReport";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reports:createIaCValidationReport";

                    /// <summary>Initializes CreateIaCValidationReport parameter list.</summary>
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
                    }
                }

                /// <summary>Gets details for a Report.</summary>
                /// <param name="name">
                /// Required. The name of the report, in the format
                /// `organizations/{organization}/locations/global/reports/{report_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details for a Report.</summary>
                public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Report>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the report, in the format
                    /// `organizations/{organization}/locations/global/reports/{report_id}`.
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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/reports/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists every Report in a given organization and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the format `organizations/{organization}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists every Report in a given organization and location.</summary>
                public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the format
                    /// `organizations/{organization}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A filter to apply to the list of reports, in the format defined in [AIP-160:
                    /// Filtering](https://google.aip.dev/160).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of reports to return. The default value is `500`. If you exceed the
                    /// maximum value of `1000`, then the service uses the maximum value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A pagination token returned from a previous request to list reports. Provide this
                    /// token to retrieve the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reports";

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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.Location>
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

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : SecurityPostureBaseServiceRequest<Google.Apis.SecurityPosture.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.SecurityPosture.v1.Data
{
    /// <summary>Details of a Cloud Asset Inventory asset that caused a violation.</summary>
    public class AssetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about the Cloud Asset Inventory asset that violated a policy. The format of this information can
        /// change at any time without prior notice. Your application must not depend on this information in any way.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>
        /// The type of Cloud Asset Inventory asset. For a list of asset types, see [Supported asset
        /// types](https://cloud.google.com/asset-inventory/docs/supported-asset-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a compliance standard that the policy helps enforce.</summary>
    public class ComplianceStandard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The control in the compliance standard that the policy helps enforce. For example, `AC-3`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("control")]
        public virtual string Control { get; set; }

        /// <summary>
        /// Optional. The compliance standard that the policy helps enforce. For example, `NIST SP 800-53`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a constraint in a Policy.</summary>
    public class Constraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A predefined organization policy constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyConstraint")]
        public virtual OrgPolicyConstraint OrgPolicyConstraint { get; set; }

        /// <summary>Optional. A custom organization policy constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyConstraintCustom")]
        public virtual OrgPolicyConstraintCustom OrgPolicyConstraintCustom { get; set; }

        /// <summary>Optional. A custom module for Security Health Analytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityHealthAnalyticsCustomModule")]
        public virtual SecurityHealthAnalyticsCustomModule SecurityHealthAnalyticsCustomModule { get; set; }

        /// <summary>Optional. A built-in detector for Security Health Analytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityHealthAnalyticsModule")]
        public virtual SecurityHealthAnalyticsModule SecurityHealthAnalyticsModule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateIaCValidationReport.</summary>
    public class CreateIaCValidationReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The infrastructure-as-code (IaC) configuration to validate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iac")]
        public virtual IaC Iac { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A custom module configuration for Security Health Analytics. Use `CustomConfig` to create custom detectors that
    /// generate custom findings for resources that you specify.
    /// </summary>
    public class CustomConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Definitions of custom source properties to include in findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customOutput")]
        public virtual CustomOutputSpec CustomOutput { get; set; }

        /// <summary>
        /// Optional. A description of the vulnerability or misconfiguration that the custom module detects. The
        /// description appears in each finding. Provide enough information to help an investigator understand the
        /// finding. The value must be enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The Common Expression Language (CEL) expression to evaluate. When the expression evaluates to
        /// `true` for a resource, a finding is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual Expr Predicate { get; set; }

        /// <summary>
        /// Required. An explanation of the steps that security teams can take to resolve the detected issue. The
        /// explanation appears in each finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual string Recommendation { get; set; }

        /// <summary>Required. The resource types that the custom module operates on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual ResourceSelector ResourceSelector { get; set; }

        /// <summary>Required. The severity of findings generated by the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definitions of custom source properties that can appear in findings.</summary>
    public class CustomOutputSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The custom source properties that can appear in findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<Property> Properties { get; set; }

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

    /// <summary>Request message for ExtractPosture.</summary>
    public class ExtractPostureRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. An identifier for the posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureId")]
        public virtual string PostureId { get; set; }

        /// <summary>
        /// Required. The organization, folder, or project from which policies are extracted. Must be within the
        /// organization defined in parent. Use one of the following formats: * `organization/{organization_number}` *
        /// `folder/{folder_number}` * `project/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workload")]
        public virtual string Workload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A custom, user-defined constraint. You can apply the constraint only to the resource types specified in the
    /// constraint, and only within the organization where the constraint is defined. _When you create a custom
    /// constraint, it is not enforced automatically._ You must use an organization policy to [enforce the
    /// constraint](https://cloud.google.com/resource-manager/help/organization-policy/constraints/enforce).
    /// </summary>
    public class GoogleCloudSecuritypostureV1CustomConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to allow or deny the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>
        /// A Common Expression Language (CEL) condition expression that must evaluate to `true` for the constraint to
        /// be enforced. The maximum length is 1000 characters. For example: +
        /// `resource.instanceName.matches('(production|test)_(.+_)?[\d]+')`: Evaluates to `true` if the resource's
        /// `instanceName` attribute contains the following: + The prefix `production` or `test` + An underscore (`_`) +
        /// Optional: One or more characters, followed by an underscore (`_`) + One or more digits +
        /// `resource.management.auto_upgrade == true`: Evaluates to `true` if the resource's `management.auto_upgrade`
        /// attribute is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>A description of the constraint. The maximum length is 2000 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>A display name for the constraint. The maximum length is 200 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The types of operations that the constraint applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodTypes")]
        public virtual System.Collections.Generic.IList<string> MethodTypes { get; set; }

        /// <summary>
        /// Immutable. The name of the constraint, in the format
        /// `organizations/{organization_id}/customConstraints/custom.{custom_constraint_id}`. For example,
        /// `organizations/123456789012/customConstraints/custom.createOnlyE2TypeVms`. Must contain 1 to 62 characters,
        /// excluding the prefix `organizations/{organization_id}/customConstraints/custom.`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The resource type that the constraint applies to, in the format
        /// `{canonical_service_name}/{resource_type_name}`. For example, `compute.googleapis.com/Instance`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last time at which the constraint was updated or created.</summary>
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

    /// <summary>A rule that defines the allowed and denied values for an organization policy constraint.</summary>
    public class GoogleCloudSecuritypostureV1PolicyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to allow any value for a list constraint. Valid only for list constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAll")]
        public virtual System.Nullable<bool> AllowAll { get; set; }

        /// <summary>
        /// A condition that determines whether this rule is used to evaluate the policy. When set, the
        /// google.type.Expr.expression field must contain 1 to 10 subexpressions, joined by the `||` or
        /// `&amp;amp;&amp;amp;` operators. Each subexpression must use the `resource.matchTag()` or
        /// `resource.matchTagId()` Common Expression Language (CEL) function. The `resource.matchTag()` function takes
        /// the following arguments: * `key_name`: the namespaced name of the tag key, with the organization ID and a
        /// slash (`/`) as a prefix; for example, `123456789012/environment` * `value_name`: the short name of the tag
        /// value For example: `resource.matchTag('123456789012/environment, 'prod')` The `resource.matchTagId()`
        /// function takes the following arguments: * `key_id`: the permanent ID of the tag key; for example,
        /// `tagKeys/123456789012` * `value_id`: the permanent ID of the tag value; for example,
        /// `tagValues/567890123456` For example: `resource.matchTagId('tagKeys/123456789012',
        /// 'tagValues/567890123456')`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>Whether to deny all values for a list constraint. Valid only for list constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyAll")]
        public virtual System.Nullable<bool> DenyAll { get; set; }

        /// <summary>Whether to enforce the constraint. Valid only for boolean constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual System.Nullable<bool> Enforce { get; set; }

        /// <summary>
        /// Optional. Required for managed constraints if parameters are defined. Passes parameter values when policy
        /// enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition.
        /// For example: { "allowedLocations" : ["us-east1", "us-west1"], "allowAll" : true }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Optional. The resource types policies can support, only used for managed constraints. Method type is
        /// `GOVERN_TAGS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual ResourceTypes ResourceTypes { get; set; }

        /// <summary>The allowed and denied values for a list constraint. Valid only for list constraints.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual GoogleCloudSecuritypostureV1PolicyRuleStringValues Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The allowed and denied values for a list constraint. For all constraints, these fields can contain literal
    /// values. Optionally, you can add the `is:` prefix to these values. If the value contains a colon (`:`), then the
    /// `is:` prefix is required. Some constraints allow you to specify a portion of the resource hierarchy, known as a
    /// [_hierarchy subtree_](https://cloud.google.com/resource-manager/help/organization-policy/hierarchy-subtree),
    /// that the constraint applies to. To specify a hierarchy subtree, use the `under:` prefix, followed by a value
    /// with one of these formats: - `projects/{project_id}` (for example, `projects/tokyo-rain-123`) -
    /// `folders/{folder_id}` (for example, `folders/1234567890123`) - `organizations/{organization_id}` (for example,
    /// `organizations/123456789012`) A constraint's `supports_under` field indicates whether you can specify a
    /// hierarchy subtree. To learn which predefined constraints let you specify a hierarchy subtree, see the
    /// [constraints
    /// reference](https://cloud.google.com/resource-manager/help/organization-policy/constraints/reference).
    /// </summary>
    public class GoogleCloudSecuritypostureV1PolicyRuleStringValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The allowed values for the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>The denied values for the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deniedValues")]
        public virtual System.Collections.Generic.IList<string> DeniedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an infrastructure-as-code (IaC) configuration.</summary>
    public class IaC : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A Terraform plan file, formatted as a stringified JSON object. To learn how to generate a
        /// Terraform plan file in JSON format, see [JSON output
        /// format](https://developer.hashicorp.com/terraform/internals/json-format) in the Terraform documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tfPlan")]
        public virtual string TfPlan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an infrastructure-as-code (IaC) validation report.</summary>
    public class IaCValidationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information about the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>A list of every Violation found in the IaC configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violations")]
        public virtual System.Collections.Generic.IList<Violation> Violations { get; set; }

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

    /// <summary>Response message for ListPostureDeployments.</summary>
    public class ListPostureDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token. To retrieve the next page of results, call the method again with this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of PostureDeployment resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployments")]
        public virtual System.Collections.Generic.IList<PostureDeployment> PostureDeployments { get; set; }

        /// <summary>Locations that were temporarily unavailable and could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPostureRevisions.</summary>
    public class ListPostureRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token. To retrieve the next page of results, call the method again with this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of revisions for the Posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<Posture> Revisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPostureTemplates.</summary>
    public class ListPostureTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token. To retrieve the next page of results, call the method again with this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of PostureTemplate resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureTemplates")]
        public virtual System.Collections.Generic.IList<PostureTemplate> PostureTemplates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPostures.</summary>
    public class ListPosturesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token. To retrieve the next page of results, call the method again with this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Posture resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postures")]
        public virtual System.Collections.Generic.IList<Posture> Postures { get; set; }

        /// <summary>Locations that were temporarily unavailable and could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListReports.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token. To retrieve the next page of results, call the method again with this token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Report resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>Locations that were temporarily unavailable and could not be reached.</summary>
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

    /// <summary>Metadata for an Operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the operation was created.</summary>
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

        /// <summary>Output only. The time at which the operation finished running.</summary>
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
        /// Output only. An error message. Returned when a PostureDeployment enters a failure state like UPDATE_FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Output only. Whether a request to cancel the operation has been received. For operations that have been
        /// cancelled successfully, the Operation.error field contains the error code CANCELLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. The status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. The server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. The name of the action executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A predefined organization policy constraint.</summary>
    public class OrgPolicyConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A unique identifier for the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cannedConstraintId")]
        public virtual string CannedConstraintId { get; set; }

        /// <summary>Required. The rules enforced by the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritypostureV1PolicyRule> PolicyRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom organization policy constraint.</summary>
    public class OrgPolicyConstraintCustom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Metadata for the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConstraint")]
        public virtual GoogleCloudSecuritypostureV1CustomConstraint CustomConstraint { get; set; }

        /// <summary>Required. The rules enforced by the constraint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritypostureV1PolicyRule> PolicyRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a policy, including the constraints that it includes.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The compliance standards that the policy helps enforce.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandards")]
        public virtual System.Collections.Generic.IList<ComplianceStandard> ComplianceStandards { get; set; }

        /// <summary>Required. The constraints that the policy includes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual Constraint Constraint { get; set; }

        /// <summary>Optional. A description of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. A user-specified identifier for the policy. In a PolicySet, each policy must have a unique
        /// identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a policy that was violated.</summary>
    public class PolicyDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The compliance standards that the policy maps to. For example, `CIS-2.0 1.15`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandards")]
        public virtual System.Collections.Generic.IList<string> ComplianceStandards { get; set; }

        /// <summary>
        /// Information about the constraint that was violated. The format of this information can change at any time
        /// without prior notice. Your application must not depend on this information in any way.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>The type of constraint that was violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraintType")]
        public virtual string ConstraintType { get; set; }

        /// <summary>A description of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group of one or more Policy resources.</summary>
    public class PolicySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A description of the policy set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The Policy resources in the policy set. Each policy must have a policy_id that's unique within the
        /// policy set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<Policy> Policies { get; set; }

        /// <summary>Required. An identifier for the policy set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySetId")]
        public virtual string PolicySetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a posture.</summary>
    public class Posture : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The user-specified annotations for the posture. For details about the values you can use in an
        /// annotation, see [AIP-148: Standard fields](https://google.aip.dev/148#annotations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. The categories that the posture belongs to, as determined by the Security Posture API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the posture was created.</summary>
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

        /// <summary>Optional. A description of the posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. An opaque identifier for the current version of the posture at the specified `revision_id`. To
        /// prevent concurrent updates from overwriting each other, always provide the `etag` when you update a posture.
        /// You can also provide the `etag` when you delete a posture, to help ensure that you're deleting the intended
        /// version of the posture.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. Identifier. The name of the posture, in the format
        /// `organizations/{organization}/locations/global/postures/{posture_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The PolicySet resources that the posture includes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySets")]
        public virtual System.Collections.Generic.IList<PolicySet> PolicySets { get; set; }

        /// <summary>Output only. Whether the posture is in the process of being updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Output only. Immutable. An opaque eight-character string that identifies the revision of the posture. A
        /// posture can have multiple revisions; when you deploy a posture, you deploy a specific revision of the
        /// posture.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Required. The state of the posture at the specified `revision_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the posture was last updated.</summary>
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
    /// Details for a Posture deployment on an organization, folder, or project. You can deploy at most one posture to
    /// each organization, folder, or project. The parent resource for a posture deployment is always the organization,
    /// even if the deployment applies to a folder or project.
    /// </summary>
    public class PostureDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The user-specified annotations for the posture deployment. For details about the values you can
        /// use in an annotation, see [AIP-148: Standard fields](https://google.aip.dev/148#annotations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. The categories that the posture deployment belongs to, as determined by the Security Posture
        /// API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the posture deployment was created.</summary>
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

        /// <summary>Optional. A description of the posture deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The posture ID that was specified for the deployment. Present only if the posture deployment is
        /// in a failed state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredPostureId")]
        public virtual string DesiredPostureId { get; set; }

        /// <summary>
        /// Output only. The revision ID of the posture that was specified for the deployment. Present only if the
        /// deployment is in a failed state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredPostureRevisionId")]
        public virtual string DesiredPostureRevisionId { get; set; }

        /// <summary>
        /// Optional. An opaque identifier for the current version of the posture deployment. To prevent concurrent
        /// updates from overwriting each other, always provide the `etag` when you update a posture deployment. You can
        /// also provide the `etag` when you delete a posture deployment, to help ensure that you're deleting the
        /// intended posture deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. A description of why the posture deployment failed. Present only if the deployment is in a
        /// failed state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureMessage")]
        public virtual string FailureMessage { get; set; }

        /// <summary>
        /// Required. Identifier. The name of the posture deployment, in the format
        /// `organizations/{organization}/locations/global/postureDeployments/{deployment_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The posture used in the deployment, in the format
        /// `organizations/{organization}/locations/global/postures/{posture_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureId")]
        public virtual string PostureId { get; set; }

        /// <summary>Required. The revision ID of the posture used in the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureRevisionId")]
        public virtual string PostureRevisionId { get; set; }

        /// <summary>Output only. Whether the posture deployment is in the process of being updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The state of the posture deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Required. The organization, folder, or project where the posture is deployed. Uses one of the following
        /// formats: * `organizations/{organization_number}` * `folders/{folder_number}` * `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResource")]
        public virtual string TargetResource { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the posture deployment was last updated.</summary>
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

    /// <summary>Details of a posture deployment.</summary>
    public class PostureDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier for the PolicySet that the relevant policy belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySet")]
        public virtual string PolicySet { get; set; }

        /// <summary>
        /// The posture used in the deployment, in the format
        /// `organizations/{organization}/locations/global/postures/{posture_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posture")]
        public virtual string Posture { get; set; }

        /// <summary>
        /// The name of the posture deployment, in the format
        /// `organizations/{organization}/locations/global/postureDeployments/{deployment_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployment")]
        public virtual string PostureDeployment { get; set; }

        /// <summary>
        /// The organization, folder, or project where the posture is deployed. Uses one of the following formats: *
        /// `organizations/{organization_number}` * `folders/{folder_number}` * `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeploymentTargetResource")]
        public virtual string PostureDeploymentTargetResource { get; set; }

        /// <summary>The revision ID of the posture used in the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureRevisionId")]
        public virtual string PostureRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of a posture template.</summary>
    public class PostureTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The categories that the posture template belongs to, as determined by the Security Posture API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>Output only. A description of the posture template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Identifier. The name of the posture template, in the format
        /// `organizations/{organization}/locations/global/postureTemplates/{posture_template}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The PolicySet resources that the posture template includes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySets")]
        public virtual System.Collections.Generic.IList<PolicySet> PolicySets { get; set; }

        /// <summary>Output only. A string that identifies the revision of the posture template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. The state of the posture template at the specified `revision_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A name-value pair used as a custom source property.</summary>
    public class Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the custom source property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The CEL expression for the value of the custom source property. For resource properties, you can
        /// return the value of the property or a string enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueExpression")]
        public virtual Expr ValueExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a report.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the report was created.</summary>
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

        /// <summary>Output only. An infrastructure-as-code (IaC) validation report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iacValidationReport")]
        public virtual IaCValidationReport IacValidationReport { get; set; }

        /// <summary>
        /// Required. The name of the report, in the format
        /// `organizations/{organization}/locations/global/reports/{report_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the report was last updated.</summary>
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

    /// <summary>A selector for the resource types to run the detector on.</summary>
    public class ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource types to run the detector on. Each custom module can specify up to 5 resource types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set multiple resource types for one policy, for example: resourceTypes: included: -
    /// compute.googleapis.com/Instance - compute.googleapis.com/Disk Constraint definition contains an empty resource
    /// type in order to support multiple resource types in the policy. Only supports managed constraints. Method type
    /// is `GOVERN_TAGS`. Refer go/multi-resource-support-force-tags-gmc to get more details.
    /// </summary>
    public class ResourceTypes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource types we currently support.
        /// cloud/orgpolicy/customconstraintconfig/prod/resource_types.prototext
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("included")]
        public virtual System.Collections.Generic.IList<string> Included { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom module for Security Health Analytics.</summary>
    public class SecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Configuration settings for the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual CustomConfig Config { get; set; }

        /// <summary>
        /// Optional. The display name of the custom module. This value is used as the finding category for all the
        /// asset violation findings that the custom module returns. The display name must contain between 1 and 128
        /// alphanumeric characters or underscores, and it must start with a lowercase letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Immutable. The unique identifier for the custom module. Contains 1 to 20 digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Whether the custom module is enabled at a specified level of the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleEnablementState")]
        public virtual string ModuleEnablementState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A built-in detector for Security Health Analytics.</summary>
    public class SecurityHealthAnalyticsModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the detector is enabled at a specified level of the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleEnablementState")]
        public virtual string ModuleEnablementState { get; set; }

        /// <summary>
        /// Required. The name of the detector. For example, `BIGQUERY_TABLE_CMEK_DISABLED`. This field is also used as
        /// the finding category for all the asset violation findings that the detector returns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

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

    /// <summary>Details of a violation.</summary>
    public class Violation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of the asset that caused the violation. For details about the format of the full
        /// resource name for each asset type, see [Resource name
        /// format](https://cloud.google.com/asset-inventory/docs/resource-name-format).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetId")]
        public virtual string AssetId { get; set; }

        /// <summary>A description of the steps that you can take to fix the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        /// <summary>The policy that was violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        /// <summary>The severity of the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Details of the Cloud Asset Inventory asset that caused the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatedAsset")]
        public virtual AssetDetails ViolatedAsset { get; set; }

        /// <summary>Details of the policy that was violated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatedPolicy")]
        public virtual PolicyDetails ViolatedPolicy { get; set; }

        /// <summary>
        /// Details for the posture that was violated. This field is present only if the violated policy belongs to a
        /// deployed posture.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatedPosture")]
        public virtual PostureDetails ViolatedPosture { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
