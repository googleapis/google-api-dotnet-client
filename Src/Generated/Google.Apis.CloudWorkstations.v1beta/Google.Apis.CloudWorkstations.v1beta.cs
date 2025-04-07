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

namespace Google.Apis.CloudWorkstations.v1beta
{
    /// <summary>The CloudWorkstations Service.</summary>
    public class CloudWorkstationsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudWorkstationsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudWorkstationsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://workstations.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://workstations.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "workstations";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Workstations API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Workstations API.</summary>
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

    /// <summary>A base abstract class for CloudWorkstations requests.</summary>
    public abstract class CloudWorkstationsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudWorkstationsBaseServiceRequest instance.</summary>
        protected CloudWorkstationsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudWorkstations parameter list.</summary>
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
                WorkstationClusters = new WorkstationClustersResource(service);
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
                public virtual CancelRequest Cancel(Google.Apis.CloudWorkstations.v1beta.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudWorkstations.v1beta.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:cancel";

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
                public class DeleteRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.GoogleProtobufEmpty>
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
                    public override string RestPath => "v1beta/{+name}";

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
                public class GetRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
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
                    public override string RestPath => "v1beta/{+name}";

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
                public class ListRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1beta/{+name}/operations";

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

            /// <summary>Gets the WorkstationClusters resource.</summary>
            public virtual WorkstationClustersResource WorkstationClusters { get; }

            /// <summary>The "workstationClusters" collection of methods.</summary>
            public class WorkstationClustersResource
            {
                private const string Resource = "workstationClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkstationClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    WorkstationConfigs = new WorkstationConfigsResource(service);
                }

                /// <summary>Gets the WorkstationConfigs resource.</summary>
                public virtual WorkstationConfigsResource WorkstationConfigs { get; }

                /// <summary>The "workstationConfigs" collection of methods.</summary>
                public class WorkstationConfigsResource
                {
                    private const string Resource = "workstationConfigs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WorkstationConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Workstations = new WorkstationsResource(service);
                    }

                    /// <summary>Gets the Workstations resource.</summary>
                    public virtual WorkstationsResource Workstations { get; }

                    /// <summary>The "workstations" collection of methods.</summary>
                    public class WorkstationsResource
                    {
                        private const string Resource = "workstations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public WorkstationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a new workstation.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. Parent resource name.</param>
                        public virtual CreateRequest Create(Google.Apis.CloudWorkstations.v1beta.Data.Workstation body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>Creates a new workstation.</summary>
                        public class CreateRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.Workstation body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Parent resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. If set, validate the request and preview the review, but do not actually apply
                            /// it.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Required. ID to use for the workstation.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("workstationId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string WorkstationId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.Workstation Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/workstations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
                                });
                                RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "validateOnly",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("workstationId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "workstationId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes the specified workstation.</summary>
                        /// <param name="name">Required. Name of the workstation to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>Deletes the specified workstation.</summary>
                        public class DeleteRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the workstation to delete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. If set, the request will be rejected if the latest version of the workstation
                            /// on the server does not have this ETag.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Etag { get; set; }

                            /// <summary>
                            /// Optional. If set, validate the request and preview the review, but do not actually apply
                            /// it.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                                RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "etag",
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
                        /// Returns a short-lived credential that can be used to send authenticated and authorized
                        /// traffic to a workstation. Once generated this token cannot be revoked and is good for the
                        /// lifetime of the token.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="workstation">
                        /// Required. Name of the workstation for which the access token should be generated.
                        /// </param>
                        public virtual GenerateAccessTokenRequest GenerateAccessToken(Google.Apis.CloudWorkstations.v1beta.Data.GenerateAccessTokenRequest body, string workstation)
                        {
                            return new GenerateAccessTokenRequest(this.service, body, workstation);
                        }

                        /// <summary>
                        /// Returns a short-lived credential that can be used to send authenticated and authorized
                        /// traffic to a workstation. Once generated this token cannot be revoked and is good for the
                        /// lifetime of the token.
                        /// </summary>
                        public class GenerateAccessTokenRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.GenerateAccessTokenResponse>
                        {
                            /// <summary>Constructs a new GenerateAccessToken request.</summary>
                            public GenerateAccessTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.GenerateAccessTokenRequest body, string workstation) : base(service)
                            {
                                Workstation = workstation;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the workstation for which the access token should be generated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("workstation", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Workstation { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.GenerateAccessTokenRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "generateAccessToken";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+workstation}:generateAccessToken";

                            /// <summary>Initializes GenerateAccessToken parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("workstation", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "workstation",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns the requested workstation.</summary>
                        /// <param name="name">Required. Name of the requested resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Returns the requested workstation.</summary>
                        public class GetRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Workstation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the requested resource.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                        {
                            return new GetIamPolicyRequest(this.service, resource);
                        }

                        /// <summary>
                        /// Gets the access control policy for a resource. Returns an empty policy if the resource
                        /// exists and does not have a policy set.
                        /// </summary>
                        public class GetIamPolicyRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Policy>
                        {
                            /// <summary>Constructs a new GetIamPolicy request.</summary>
                            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                            {
                                Resource = resource;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>
                            /// Optional. The maximum policy version that will be used to format the policy. Valid
                            /// values are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests
                            /// for policies with any conditional role bindings must specify version 3. Policies with no
                            /// conditional role bindings may specify any valid value or leave the field unset. The
                            /// policy in the response might use the policy version that you specified, or it might use
                            /// a lower policy version. For example, if you specify version 3, but the policy has no
                            /// conditional role bindings, the response uses version 1. To learn which resources support
                            /// conditions in their IAM policies, see the [IAM
                            /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+resource}:getIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
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

                        /// <summary>Returns all Workstations using the specified workstation configuration.</summary>
                        /// <param name="parent">Required. Parent resource name.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Returns all Workstations using the specified workstation configuration.</summary>
                        public class ListRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListWorkstationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. Parent resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Filter the Workstations to be listed. Possible filters are described in
                            /// https://google.aip.dev/160.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional. Maximum number of items to return.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. next_page_token value returned from a previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/workstations";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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
                        /// Returns all workstations using the specified workstation configuration on which the caller
                        /// has the "workstations.workstations.use" permission.
                        /// </summary>
                        /// <param name="parent">Required. Parent resource name.</param>
                        public virtual ListUsableRequest ListUsable(string parent)
                        {
                            return new ListUsableRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Returns all workstations using the specified workstation configuration on which the caller
                        /// has the "workstations.workstations.use" permission.
                        /// </summary>
                        public class ListUsableRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListUsableWorkstationsResponse>
                        {
                            /// <summary>Constructs a new ListUsable request.</summary>
                            public ListUsableRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. Parent resource name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Optional. Maximum number of items to return.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. next_page_token value returned from a previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "listUsable";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+parent}/workstations:listUsable";

                            /// <summary>Initializes ListUsable parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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

                        /// <summary>Updates an existing workstation.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Identifier. Full name of this workstation.</param>
                        public virtual PatchRequest Patch(Google.Apis.CloudWorkstations.v1beta.Data.Workstation body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>Updates an existing workstation.</summary>
                        public class PatchRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.Workstation body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Identifier. Full name of this workstation.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. If set and the workstation configuration is not found, a new workstation
                            /// configuration is created. In this situation, update_mask is ignored.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> AllowMissing { get; set; }

                            /// <summary>
                            /// Required. Mask specifying which fields in the workstation configuration should be
                            /// updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>
                            /// Optional. If set, validate the request and preview the review, but do not actually apply
                            /// it.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ValidateOnly { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.Workstation Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "allowMissing",
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
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest body, string resource)
                        {
                            return new SetIamPolicyRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                        /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                        /// </summary>
                        public class SetIamPolicyRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Policy>
                        {
                            /// <summary>Constructs a new SetIamPolicy request.</summary>
                            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy is being specified. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "setIamPolicy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+resource}:setIamPolicy";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Starts running a workstation so that users can connect to it.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. Name of the workstation to start.</param>
                        public virtual StartRequest Start(Google.Apis.CloudWorkstations.v1beta.Data.StartWorkstationRequest body, string name)
                        {
                            return new StartRequest(this.service, body, name);
                        }

                        /// <summary>Starts running a workstation so that users can connect to it.</summary>
                        public class StartRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Start request.</summary>
                            public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.StartWorkstationRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the workstation to start.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.StartWorkstationRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "start";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}:start";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Stops running a workstation, reducing costs.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. Name of the workstation to stop.</param>
                        public virtual StopRequest Stop(Google.Apis.CloudWorkstations.v1beta.Data.StopWorkstationRequest body, string name)
                        {
                            return new StopRequest(this.service, body, name);
                        }

                        /// <summary>Stops running a workstation, reducing costs.</summary>
                        public class StopRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Stop request.</summary>
                            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.StopWorkstationRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the workstation to stop.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.StopWorkstationRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "stop";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+name}:stop";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="resource">
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </param>
                        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest body, string resource)
                        {
                            return new TestIamPermissionsRequest(this.service, body, resource);
                        }

                        /// <summary>
                        /// Returns permissions that a caller has on the specified resource. If the resource does not
                        /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This
                        /// operation is designed to be used for building permission-aware UIs and command-line tools,
                        /// not for authorization checking. This operation may "fail open" without warning.
                        /// </summary>
                        public class TestIamPermissionsRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsResponse>
                        {
                            /// <summary>Constructs a new TestIamPermissions request.</summary>
                            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest body, string resource) : base(service)
                            {
                                Resource = resource;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value
                            /// for this field.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Resource { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "testIamPermissions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/{+resource}:testIamPermissions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+/workstations/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new workstation configuration.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Parent resource name.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new workstation configuration.</summary>
                    public class CreateRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. If set, validate the request and preview the review, but do not actually apply it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Required. ID to use for the workstation configuration.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("workstationConfigId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string WorkstationConfigId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/workstationConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("workstationConfigId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "workstationConfigId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified workstation configuration.</summary>
                    /// <param name="name">Required. Name of the workstation configuration to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified workstation configuration.</summary>
                    public class DeleteRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the workstation configuration to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set, the request is rejected if the latest version of the workstation
                        /// configuration on the server does not have this ETag.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. If set, any workstations in the workstation configuration are also deleted.
                        /// Otherwise, the request works only if the workstation configuration has no workstations.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

                        /// <summary>
                        /// Optional. If set, validate the request and preview the review, but do not actually apply it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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

                    /// <summary>Returns the requested workstation configuration.</summary>
                    /// <param name="name">Required. Name of the requested resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns the requested workstation configuration.</summary>
                    public class GetRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the requested resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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
                    public class GetIamPolicyRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Policy>
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
                        public override string RestPath => "v1beta/{+resource}:getIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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

                    /// <summary>Returns all workstation configurations in the specified cluster.</summary>
                    /// <param name="parent">Required. Parent resource name.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Returns all workstation configurations in the specified cluster.</summary>
                    public class ListRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListWorkstationConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter the WorkstationConfigs to be listed. Possible filters are described in
                        /// https://google.aip.dev/160.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Maximum number of items to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/workstationConfigs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
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
                    /// Returns all workstation configurations in the specified cluster on which the caller has the
                    /// "workstations.workstation.create" permission.
                    /// </summary>
                    /// <param name="parent">Required. Parent resource name.</param>
                    public virtual ListUsableRequest ListUsable(string parent)
                    {
                        return new ListUsableRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Returns all workstation configurations in the specified cluster on which the caller has the
                    /// "workstations.workstation.create" permission.
                    /// </summary>
                    public class ListUsableRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListUsableWorkstationConfigsResponse>
                    {
                        /// <summary>Constructs a new ListUsable request.</summary>
                        public ListUsableRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Maximum number of items to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listUsable";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/workstationConfigs:listUsable";

                        /// <summary>Initializes ListUsable parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
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

                    /// <summary>Updates an existing workstation configuration.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Identifier. Full name of this workstation configuration.</param>
                    public virtual PatchRequest Patch(Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates an existing workstation configuration.</summary>
                    public class PatchRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Identifier. Full name of this workstation configuration.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set and the workstation configuration is not found, a new workstation
                        /// configuration will be created. In this situation, update_mask is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Required. Mask specifying which fields in the workstation configuration should be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>
                        /// Optional. If set, validate the request and preview the review, but do not actually apply it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudWorkstations.v1beta.Data.WorkstationConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                        Google.Apis.CloudWorkstations.v1beta.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+resource}:setIamPolicy";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
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
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                        Google.Apis.CloudWorkstations.v1beta.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+resource}:testIamPermissions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+/workstationConfigs/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new workstation cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Parent resource name.</param>
                public virtual CreateRequest Create(Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new workstation cluster.</summary>
                public class CreateRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Parent resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not actually apply it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Required. ID to use for the workstation cluster.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("workstationClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WorkstationClusterId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/workstationClusters";

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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("workstationClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workstationClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the specified workstation cluster.</summary>
                /// <param name="name">Required. Name of the workstation cluster to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified workstation cluster.</summary>
                public class DeleteRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the workstation cluster to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set, the request will be rejected if the latest version of the workstation cluster
                    /// on the server does not have this ETag.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. If set, any workstation configurations and workstations in the workstation cluster are
                    /// also deleted. Otherwise, the request only works if the workstation cluster has no configurations
                    /// or workstations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not apply it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
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

                /// <summary>Returns the requested workstation cluster.</summary>
                /// <param name="name">Required. Name of the requested resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the requested workstation cluster.</summary>
                public class GetRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the requested resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns all workstation clusters in the specified location.</summary>
                /// <param name="parent">Required. Parent resource name.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Returns all workstation clusters in the specified location.</summary>
                public class ListRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.ListWorkstationClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter the WorkstationClusters to be listed. Possible filters are described in
                    /// https://google.aip.dev/160.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. next_page_token value returned from a previous List request, if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/workstationClusters";

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

                /// <summary>Updates an existing workstation cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Identifier. Full name of this workstation cluster.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an existing workstation cluster.</summary>
                public class PatchRequest : CloudWorkstationsBaseServiceRequest<Google.Apis.CloudWorkstations.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifier. Full name of this workstation cluster.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set, and the workstation cluster is not found, a new workstation cluster will be
                    /// created. In this situation, update_mask is ignored.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Required. Mask that specifies which fields in the workstation cluster should be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. If set, validate the request and preview the review, but do not actually apply it.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudWorkstations.v1beta.Data.WorkstationCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workstationClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
        }
    }
}
namespace Google.Apis.CloudWorkstations.v1beta.Data
{
    /// <summary>An accelerator card attached to the instance.</summary>
    public class Accelerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Number of accelerator cards exposed to the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>
        /// Optional. Type of accelerator resource to attach to the instance, for example, `"nvidia-tesla-p100"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>
    /// A boost configuration is a set of resources that a workstation can use to increase its performance. If you
    /// specify a boost configuration, upon startup, workstation users can choose to use a VM provisioned under the
    /// boost config by passing the boost config ID in the start request. If the workstation user does not provide a
    /// boost config ID in the start request, the system will choose a VM from the pool provisioned under the default
    /// config.
    /// </summary>
    public class BoostConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of the type and count of accelerator cards attached to the boost instance. Defaults to
        /// `none`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<Accelerator> Accelerators { get; set; }

        /// <summary>
        /// Optional. The size of the boot disk for the VM in gigabytes (GB). The minimum boot disk size is `30` GB.
        /// Defaults to `50` GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>
        /// Optional. Whether to enable nested virtualization on boosted Cloud Workstations VMs running using this boost
        /// configuration. Defaults to false. Nested virtualization lets you run virtual machine (VM) instances inside
        /// your workstation. Before enabling nested virtualization, consider the following important considerations.
        /// Cloud Workstations instances are subject to the [same restrictions as Compute Engine
        /// instances](https://cloud.google.com/compute/docs/instances/nested-virtualization/overview#restrictions): *
        /// **Organization policy**: projects, folders, or organizations may be restricted from creating nested VMs if
        /// the **Disable VM nested virtualization** constraint is enforced in the organization policy. For more
        /// information, see the Compute Engine section, [Checking whether nested virtualization is
        /// allowed](https://cloud.google.com/compute/docs/instances/nested-virtualization/managing-constraint#checking_whether_nested_virtualization_is_allowed).
        /// * **Performance**: nested VMs might experience a 10% or greater decrease in performance for workloads that
        /// are CPU-bound and possibly greater than a 10% decrease for workloads that are input/output bound. *
        /// **Machine Type**: nested virtualization can only be enabled on boost configurations that specify a
        /// machine_type in the N1 or N2 machine series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNestedVirtualization")]
        public virtual System.Nullable<bool> EnableNestedVirtualization { get; set; }

        /// <summary>Required. The ID to be used for the boost configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. The type of machine that boosted VM instances will use—for example, `e2-standard-4`. For more
        /// information about machine types that Cloud Workstations supports, see the list of [available machine
        /// types](https://cloud.google.com/workstations/docs/available-machine-types). Defaults to `e2-standard-4`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The number of boost VMs that the system should keep idle so that workstations can be boosted
        /// quickly. Defaults to `0`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolSize")]
        public virtual System.Nullable<int> PoolSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Docker container.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Arguments passed to the entrypoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Optional. If set, overrides the default ENTRYPOINT specified by the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>Optional. Environment variables passed to the container's entrypoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IDictionary<string, string> Env { get; set; }

        /// <summary>
        /// Optional. A Docker container image that defines a custom environment. Cloud Workstations provides a number
        /// of [preconfigured images](https://cloud.google.com/workstations/docs/preconfigured-base-images), but you can
        /// create your own [custom container
        /// images](https://cloud.google.com/workstations/docs/custom-container-images). If using a private image, the
        /// `host.gceInstance.serviceAccount` field must be specified in the workstation configuration. If using a
        /// custom container image, the service account must have [Artifact Registry
        /// Reader](https://cloud.google.com/artifact-registry/docs/access-control#roles) permission to pull the
        /// specified image. Otherwise, the image must be publicly accessible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>Optional. If set, overrides the USER specified in the image with the given uid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runAsUser")]
        public virtual System.Nullable<int> RunAsUser { get; set; }

        /// <summary>Optional. If set, overrides the default DIR specified by the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A customer-managed encryption key (CMEK) for the Compute Engine resources of the associated workstation
    /// configuration. Specify the name of your Cloud KMS encryption key and the default service account. We recommend
    /// that you use a separate service account and follow [Cloud KMS best
    /// practices](https://cloud.google.com/kms/docs/separation-of-duties).
    /// </summary>
    public class CustomerEncryptionKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. The name of the Google Cloud KMS encryption key. For example,
        /// `"projects/PROJECT_ID/locations/REGION/keyRings/KEY_RING/cryptoKeys/KEY_NAME"`. The key must be in the same
        /// region as the workstation configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Immutable. The service account to use with the specified KMS key. We recommend that you use a separate
        /// service account and follow KMS best practices. For more information, see [Separation of
        /// duties](https://cloud.google.com/kms/docs/separation-of-duties) and `gcloud kms keys add-iam-policy-binding`
        /// [`--member`](https://cloud.google.com/sdk/gcloud/reference/kms/keys/add-iam-policy-binding#--member).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyServiceAccount")]
        public virtual string KmsKeyServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for a custom domain.</summary>
    public class DomainConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Immutable. Domain used by Workstations for HTTP ingress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ephemeral directory which won't persist across workstation sessions. It is freshly created on every
    /// workstation start operation.
    /// </summary>
    public class EphemeralDirectory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An EphemeralDirectory backed by a Compute Engine persistent disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcePd")]
        public virtual GcePersistentDisk GcePd { get; set; }

        /// <summary>Required. Location of this directory in the running workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

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

    /// <summary>A set of Compute Engine Confidential VM instance options.</summary>
    public class GceConfidentialInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the instance has confidential compute enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableConfidentialCompute")]
        public virtual System.Nullable<bool> EnableConfidentialCompute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A runtime using a Compute Engine instance.</summary>
    public class GceInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of the type and count of accelerator cards attached to the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<Accelerator> Accelerators { get; set; }

        /// <summary>
        /// Optional. A list of the boost configurations that workstations created using this workstation configuration
        /// are allowed to use. If specified, users will have the option to choose from the list of boost configs when
        /// starting a workstation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostConfigs")]
        public virtual System.Collections.Generic.IList<BoostConfig> BoostConfigs { get; set; }

        /// <summary>
        /// Optional. The size of the boot disk for the VM in gigabytes (GB). The minimum boot disk size is `30` GB.
        /// Defaults to `50` GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>Optional. A set of Compute Engine Confidential VM instance options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialInstanceConfig")]
        public virtual GceConfidentialInstanceConfig ConfidentialInstanceConfig { get; set; }

        /// <summary>
        /// Optional. When set to true, disables public IP addresses for VMs. If you disable public IP addresses, you
        /// must set up Private Google Access or Cloud NAT on your network. If you use Private Google Access and you use
        /// `private.googleapis.com` or `restricted.googleapis.com` for Container Registry and Artifact Registry, make
        /// sure that you set up DNS records for domains `*.gcr.io` and `*.pkg.dev`. Defaults to false (VMs have public
        /// IP addresses).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePublicIpAddresses")]
        public virtual System.Nullable<bool> DisablePublicIpAddresses { get; set; }

        /// <summary>Optional. Whether to disable SSH access to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableSsh")]
        public virtual System.Nullable<bool> DisableSsh { get; set; }

        /// <summary>
        /// Optional. Whether to enable nested virtualization on Cloud Workstations VMs created using this workstation
        /// configuration. Defaults to false. Nested virtualization lets you run virtual machine (VM) instances inside
        /// your workstation. Before enabling nested virtualization, consider the following important considerations.
        /// Cloud Workstations instances are subject to the [same restrictions as Compute Engine
        /// instances](https://cloud.google.com/compute/docs/instances/nested-virtualization/overview#restrictions): *
        /// **Organization policy**: projects, folders, or organizations may be restricted from creating nested VMs if
        /// the **Disable VM nested virtualization** constraint is enforced in the organization policy. For more
        /// information, see the Compute Engine section, [Checking whether nested virtualization is
        /// allowed](https://cloud.google.com/compute/docs/instances/nested-virtualization/managing-constraint#checking_whether_nested_virtualization_is_allowed).
        /// * **Performance**: nested VMs might experience a 10% or greater decrease in performance for workloads that
        /// are CPU-bound and possibly greater than a 10% decrease for workloads that are input/output bound. *
        /// **Machine Type**: nested virtualization can only be enabled on workstation configurations that specify a
        /// machine_type in the N1 or N2 machine series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNestedVirtualization")]
        public virtual System.Nullable<bool> EnableNestedVirtualization { get; set; }

        /// <summary>
        /// Optional. The type of machine to use for VM instances—for example, `"e2-standard-4"`. For more information
        /// about machine types that Cloud Workstations supports, see the list of [available machine
        /// types](https://cloud.google.com/workstations/docs/available-machine-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. The number of VMs that the system should keep idle so that new workstations can be started quickly
        /// for new users. Defaults to `0` in the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolSize")]
        public virtual System.Nullable<int> PoolSize { get; set; }

        /// <summary>
        /// Output only. Number of instances currently available in the pool for faster workstation startup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pooledInstances")]
        public virtual System.Nullable<int> PooledInstances { get; set; }

        /// <summary>
        /// Optional. The email address of the service account for Cloud Workstations VMs created with this
        /// configuration. When specified, be sure that the service account has `logging.logEntries.create` and
        /// `monitoring.timeSeries.create` permissions on the project so it can write logs out to Cloud Logging. If
        /// using a custom container image, the service account must have [Artifact Registry
        /// Reader](https://cloud.google.com/artifact-registry/docs/access-control#roles) permission to pull the
        /// specified image. If you as the administrator want to be able to `ssh` into the underlying VM, you need to
        /// set this value to a service account for which you have the `iam.serviceAccounts.actAs` permission.
        /// Conversely, if you don't want anyone to be able to `ssh` into the underlying VM, use a service account where
        /// no one has that permission. If not set, VMs run with a service account provided by the Cloud Workstations
        /// service, and the image must be publicly accessible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. Scopes to grant to the service_account. When specified, users of workstations under this
        /// configuration must have `iam.serviceAccounts.actAs` on the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountScopes")]
        public virtual System.Collections.Generic.IList<string> ServiceAccountScopes { get; set; }

        /// <summary>Optional. A set of Compute Engine Shielded instance options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual GceShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// Optional. Network tags to add to the Compute Engine VMs backing the workstations. This option applies
        /// [network tags](https://cloud.google.com/vpc/docs/add-remove-network-tags) to VMs created with this
        /// configuration. These network tags enable the creation of [firewall
        /// rules](https://cloud.google.com/workstations/docs/configure-firewall-rules).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Optional. Resource manager tags to be bound to this instance. Tag keys and values have the same definition
        /// as [resource manager tags](https://cloud.google.com/resource-manager/docs/tags/tags-overview). Keys must be
        /// in the format `tagKeys/{tag_key_id}`, and values are in the format `tagValues/456`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> VmTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Compute Engine instance host.</summary>
    public class GceInstanceHost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Output only. The ID of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Output only. The name of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Output only. The zone of the Compute Engine instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An EphemeralDirectory is backed by a Compute Engine persistent disk.</summary>
    public class GcePersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Type of the disk to use. Defaults to `"pd-standard"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Whether the disk is read only. If true, the disk may be shared by multiple VMs and source_snapshot
        /// must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// Optional. Name of the disk image to use as the source for the disk. Must be empty if source_snapshot is set.
        /// Updating source_image will update content in the ephemeral directory after the workstation is restarted.
        /// Only file systems supported by Container-Optimized OS (COS) are explicitly supported. For a list of
        /// supported file systems, please refer to the [COS
        /// documentation](https://cloud.google.com/container-optimized-os/docs/concepts/supported-filesystems). This
        /// field is mutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>
        /// Optional. Name of the snapshot to use as the source for the disk. Must be empty if source_image is set. Must
        /// be empty if read_only is false. Updating source_snapshot will update content in the ephemeral directory
        /// after the workstation is restarted. Only file systems supported by Container-Optimized OS (COS) are
        /// explicitly supported. For a list of supported file systems, see [the filesystems available in
        /// Container-Optimized
        /// OS](https://cloud.google.com/container-optimized-os/docs/concepts/supported-filesystems). This field is
        /// mutable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSnapshot")]
        public virtual string SourceSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Persistent Directory backed by a Compute Engine regional persistent disk. The persistent_directories field is
    /// repeated, but it may contain only one entry. It creates a [persistent
    /// disk](https://cloud.google.com/compute/docs/disks/persistent-disks) that mounts to the workstation VM at `/home`
    /// when the session starts and detaches when the session ends. If this field is empty, workstations created with
    /// this configuration do not have a persistent home directory.
    /// </summary>
    public class GceRegionalPersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The [type of the persistent disk](https://cloud.google.com/compute/docs/disks#disk-types) for the
        /// home directory. Defaults to `"pd-standard"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// Optional. Type of file system that the disk should be formatted with. The workstation image must support
        /// this file system type. Must be empty if source_snapshot is set. Defaults to `"ext4"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fsType")]
        public virtual string FsType { get; set; }

        /// <summary>
        /// Optional. Whether the persistent disk should be deleted when the workstation is deleted. Valid values are
        /// `DELETE` and `RETAIN`. Defaults to `DELETE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reclaimPolicy")]
        public virtual string ReclaimPolicy { get; set; }

        /// <summary>
        /// Optional. The GB capacity of a persistent home directory for each workstation created with this
        /// configuration. Must be empty if source_snapshot is set. Valid values are `10`, `50`, `100`, `200`, `500`, or
        /// `1000`. Defaults to `200`. If less than `200` GB, the disk_type must be `"pd-balanced"` or `"pd-ssd"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>
        /// Optional. Name of the snapshot to use as the source for the disk. If set, size_gb and fs_type must be empty.
        /// Must be formatted as ext4 file system with no partitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSnapshot")]
        public virtual string SourceSnapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of Compute Engine Shielded instance options.</summary>
    public class GceShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the instance has integrity monitoring enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>Optional. Whether the instance has Secure Boot enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>Optional. Whether the instance has the vTPM enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableVtpm")]
        public virtual System.Nullable<bool> EnableVtpm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GenerateAccessToken.</summary>
    public class GenerateAccessTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Desired expiration time of the access token. This value must be at most 24 hours in the future. If a value
        /// is not specified, the token's expiration time will be set to a default value of 1 hour in the future.
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
        /// Optional. Port for which the access token should be generated. If specified, the generated access token
        /// grants access only to the specified port of the workstation. If specified, values must be within the range
        /// [1 - 65535]. If not specified, the generated access token grants access to all ports of the workstation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Desired lifetime duration of the access token. This value must be at most 24 hours. If a value is not
        /// specified, the token's lifetime will be set to a default value of 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GenerateAccessToken.</summary>
    public class GenerateAccessTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The generated bearer access token. To use this token, include it in an Authorization header of an HTTP
        /// request sent to the associated workstation's hostname—for example, `Authorization: Bearer `.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Time at which the generated token will expire.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime host for a workstation.</summary>
    public class Host : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a Compute Engine instance as the host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceInstance")]
        public virtual GceInstance GceInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTP options for the running workstations.</summary>
    public class HttpOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. By default, the workstations service makes sure that all requests to the workstation are
        /// authenticated. CORS preflight requests do not include cookies or custom headers, and so are considered
        /// unauthenticated and blocked by the workstations service. Enabling this option allows these unauthenticated
        /// CORS preflight requests through to the workstation, where it becomes the responsibility of the destination
        /// server in the workstation to validate the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedUnauthenticatedCorsPreflightRequests")]
        public virtual System.Nullable<bool> AllowedUnauthenticatedCorsPreflightRequests { get; set; }

        /// <summary>
        /// Optional. By default, the workstations service replaces references to localhost, 127.0.0.1, and 0.0.0.0 with
        /// the workstation's hostname in http responses from the workstation so that applications under development run
        /// properly on the workstation. This may intefere with some applications, and so this option allows that
        /// behavior to be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableLocalhostReplacement")]
        public virtual System.Nullable<bool> DisableLocalhostReplacement { get; set; }

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

    /// <summary>Response message for ListUsableWorkstationConfigs.</summary>
    public class ListUsableWorkstationConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The requested configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workstationConfigs")]
        public virtual System.Collections.Generic.IList<WorkstationConfig> WorkstationConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListUsableWorkstations.</summary>
    public class ListUsableWorkstationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The requested workstations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workstations")]
        public virtual System.Collections.Generic.IList<Workstation> Workstations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkstationClusters.</summary>
    public class ListWorkstationClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The requested workstation clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workstationClusters")]
        public virtual System.Collections.Generic.IList<WorkstationCluster> WorkstationClusters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkstationConfigs.</summary>
    public class ListWorkstationConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The requested configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workstationConfigs")]
        public virtual System.Collections.Generic.IList<WorkstationConfig> WorkstationConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListWorkstations.</summary>
    public class ListWorkstationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. Unreachable resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The requested workstations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workstations")]
        public virtual System.Collections.Generic.IList<Workstation> Workstations { get; set; }

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

    /// <summary>Metadata for long-running operations.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time that the operation was created.</summary>
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

        /// <summary>Output only. Time that the operation finished running.</summary>
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

        /// <summary>Output only. Identifies whether the user has requested cancellation of the operation.</summary>
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

    /// <summary>
    /// A directory to persist across workstation sessions. Updates to this field will not update existing workstations
    /// and will only take effect on new workstations.
    /// </summary>
    public class PersistentDirectory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A PersistentDirectory backed by a Compute Engine persistent disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcePd")]
        public virtual GceRegionalPersistentDisk GcePd { get; set; }

        /// <summary>Optional. Location of this directory in the running workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

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

    /// <summary>
    /// A PortRange defines a range of ports. Both first and last are inclusive. To specify a single port, both first
    /// and last should be the same.
    /// </summary>
    public class PortRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Starting port number for the current range of ports. Valid ports are 22, 80, and ports within the
        /// range 1024-65535.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<int> First { get; set; }

        /// <summary>
        /// Required. Ending port number for the current range of ports. Valid ports are 22, 80, and ports within the
        /// range 1024-65535.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("last")]
        public virtual System.Nullable<int> Last { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for private workstation clusters.</summary>
    public class PrivateClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional projects that are allowed to attach to the workstation cluster's service attachment. By
        /// default, the workstation cluster's project and the VPC host project (if different) are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedProjects")]
        public virtual System.Collections.Generic.IList<string> AllowedProjects { get; set; }

        /// <summary>
        /// Output only. Hostname for the workstation cluster. This field will be populated only when private endpoint
        /// is enabled. To access workstations in the workstation cluster, create a new DNS zone mapping this domain
        /// name to an internal IP address and a forwarding rule mapping that address to the service attachment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterHostname")]
        public virtual string ClusterHostname { get; set; }

        /// <summary>Immutable. Whether Workstations endpoint is private.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateEndpoint")]
        public virtual System.Nullable<bool> EnablePrivateEndpoint { get; set; }

        /// <summary>
        /// Output only. Service attachment URI for the workstation cluster. The service attachment is created when
        /// private endpoint is enabled. To access workstations in the workstation cluster, configure access to the
        /// managed service using [Private Service
        /// Connect](https://cloud.google.com/vpc/docs/configure-private-service-connect-services).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachmentUri")]
        public virtual string ServiceAttachmentUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A readiness check to be performed on a workstation.</summary>
    public class ReadinessCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Path to which the request should be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Optional. Port to which the request should be sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime host for the workstation.</summary>
    public class RuntimeHost : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a Compute Engine instance as the host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceInstanceHost")]
        public virtual GceInstanceHost GceInstanceHost { get; set; }

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

    /// <summary>Request message for StartWorkstation.</summary>
    public class StartWorkstationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set, the workstation starts using the boost configuration with the specified ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostConfig")]
        public virtual string BoostConfig { get; set; }

        /// <summary>
        /// Optional. If set, the request will be rejected if the latest version of the workstation on the server does
        /// not have this ETag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. If set, validate the request and preview the review, but do not actually apply it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
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

    /// <summary>Request message for StopWorkstation.</summary>
    public class StopWorkstationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set, the request will be rejected if the latest version of the workstation on the server does
        /// not have this ETag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. If set, validate the request and preview the review, but do not actually apply it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
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

    /// <summary>A single instance of a developer workstation with its own persistent storage.</summary>
    public class Workstation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client-specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. List of available boost configuration IDs that this workstation can be boosted up to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostConfigs")]
        public virtual System.Collections.Generic.IList<WorkstationBoostConfig> BoostConfigs { get; set; }

        /// <summary>Output only. Status conditions describing the workstation's current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Status> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this workstation was created.</summary>
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
        /// Output only. Whether this workstation is in degraded mode, in which case it may require user action to
        /// restore full functionality. The conditions field contains detailed information about the status of the
        /// workstation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("degraded")]
        public virtual System.Nullable<bool> Degraded { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Time when this workstation was soft-deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Human-readable name for this workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Environment variables passed to the workstation container's entrypoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IDictionary<string, string> Env { get; set; }

        /// <summary>
        /// Optional. Checksum computed by the server. May be sent on update and delete requests to make sure that the
        /// client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Host to which clients can send HTTPS traffic that will be received by the workstation.
        /// Authorized traffic will be received to the workstation as HTTP on port 80. To send traffic to a different
        /// port, clients may prefix the host with the destination port in the format `{port}-{host}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Output only. The name of the Google Cloud KMS encryption key used to encrypt this workstation. The KMS key
        /// can only be configured in the WorkstationConfig. The expected format is
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/workstations/docs/label-resources) that are applied to the
        /// workstation and that are also propagated to the underlying Compute Engine resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Identifier. Full name of this workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Indicates whether this workstation is currently being updated to match its intended state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Optional. Output only. Runtime host for the workstation when in STATE_RUNNING.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeHost")]
        public virtual RuntimeHost RuntimeHost { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Optional. The source workstation from which this workstation's persistent directories were cloned on
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceWorkstation")]
        public virtual string SourceWorkstation { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Output only. Time when this workstation was most recently successfully started, regardless of the
        /// workstation's initial state.
        /// </summary>
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

        /// <summary>Output only. Current state of the workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. A system-assigned unique identifier for this workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when this workstation was most recently updated.</summary>
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
    /// Boost configuration for this workstation. This object is populated from the parent workstation configuration.
    /// </summary>
    public class WorkstationBoostConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Boost configuration ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A workstation cluster resource in the Cloud Workstations API. Defines a group of workstations in a particular
    /// region and the VPC network they're attached to.
    /// </summary>
    public class WorkstationCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client-specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Status conditions describing the workstation cluster's current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Status> Conditions { get; set; }

        /// <summary>
        /// Output only. The private IP address of the control plane for this workstation cluster. Workstation VMs need
        /// access to this IP address to work with the service, so make sure that your firewall rules allow egress from
        /// the workstation VMs to this address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneIp")]
        public virtual string ControlPlaneIp { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this workstation cluster was created.</summary>
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
        /// Output only. Whether this workstation cluster is in degraded mode, in which case it may require user action
        /// to restore full functionality. The conditions field contains detailed information about the status of the
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("degraded")]
        public virtual System.Nullable<bool> Degraded { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Time when this workstation cluster was soft-deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Human-readable name for this workstation cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Configuration options for a custom domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainConfig")]
        public virtual DomainConfig DomainConfig { get; set; }

        /// <summary>
        /// Optional. Checksum computed by the server. May be sent on update and delete requests to make sure that the
        /// client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/workstations/docs/label-resources) that are applied to the
        /// workstation cluster and that are also propagated to the underlying Compute Engine resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Identifier. Full name of this workstation cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Name of the Compute Engine network in which instances associated with this workstation cluster
        /// will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Optional. Configuration for private workstation cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateClusterConfig")]
        public virtual PrivateClusterConfig PrivateClusterConfig { get; set; }

        /// <summary>
        /// Output only. Indicates whether this workstation cluster is currently being updated to match its intended
        /// state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// Immutable. Name of the Compute Engine subnetwork in which instances associated with this workstation cluster
        /// will be created. Must be part of the subnetwork specified for this workstation cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. Tag keys/values directly bound to this resource. For example:
        /// "123/environment": "production", "123/costCenter": "marketing"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>Output only. A system-assigned unique identifier for this workstation cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when this workstation cluster was most recently updated.</summary>
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
    /// A workstation configuration resource in the Cloud Workstations API. Workstation configurations act as templates
    /// for workstations. The workstation configuration defines details such as the workstation virtual machine (VM)
    /// instance type, persistent storage, container image defining environment, which IDE or Code Editor to use, and
    /// more. Administrators and platform teams can also use [Identity and Access Management
    /// (IAM)](https://cloud.google.com/iam/docs/overview) rules to grant access to teams or to individual developers.
    /// </summary>
    public class WorkstationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of PortRanges specifying single ports or ranges of ports that are externally accessible in
        /// the workstation. Allowed ports must be one of 22, 80, or within range 1024-65535. If not specified defaults
        /// to ports 22, 80, and ports 1024-65535.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPorts")]
        public virtual System.Collections.Generic.IList<PortRange> AllowedPorts { get; set; }

        /// <summary>Optional. Client-specified annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. Status conditions describing the workstation configuration's current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Status> Conditions { get; set; }

        /// <summary>
        /// Optional. Container that runs upon startup for each workstation using this workstation configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual Container Container { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when this workstation configuration was created.</summary>
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
        /// Output only. Whether this workstation configuration is in degraded mode, in which case it may require user
        /// action to restore full functionality. The conditions field contains detailed information about the status of
        /// the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("degraded")]
        public virtual System.Nullable<bool> Degraded { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. Time when this workstation configuration was soft-deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Disables support for plain TCP connections in the workstation. By default the service supports TCP
        /// connections through a websocket relay. Setting this option to true disables that relay, which prevents the
        /// usage of services that require plain TCP connections, such as SSH. When enabled, all communication must
        /// occur over HTTPS or WSS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTcpConnections")]
        public virtual System.Nullable<bool> DisableTcpConnections { get; set; }

        /// <summary>Optional. Human-readable name for this workstation configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Whether to enable Linux `auditd` logging on the workstation. When enabled, a service_account must
        /// also be specified that has `roles/logging.logWriter` and `roles/monitoring.metricWriter` on the project.
        /// Operating system audit logging is distinct from [Cloud Audit
        /// Logs](https://cloud.google.com/workstations/docs/audit-logging) and [Container output
        /// logging](https://cloud.google.com/workstations/docs/container-output-logging#overview). Operating system
        /// audit logs are available in the [Cloud Logging](https://cloud.google.com/logging/docs) console by querying:
        /// resource.type="gce_instance" log_name:"/logs/linux-auditd"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAuditAgent")]
        public virtual System.Nullable<bool> EnableAuditAgent { get; set; }

        /// <summary>
        /// Immutable. Encrypts resources of this workstation configuration using a customer-managed encryption key
        /// (CMEK). If specified, the boot disk of the Compute Engine instance and the persistent disk are encrypted
        /// using this encryption key. If this field is not set, the disks are encrypted using a generated key.
        /// Customer-managed encryption keys do not protect disk metadata. If the customer-managed encryption key is
        /// rotated, when the workstation instance is stopped, the system attempts to recreate the persistent disk with
        /// the new version of the key. Be sure to keep older versions of the key until the persistent disk is
        /// recreated. Otherwise, data on the persistent disk might be lost. If the encryption key is revoked, the
        /// workstation session automatically stops within 7 hours. Immutable after the workstation configuration is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual CustomerEncryptionKey EncryptionKey { get; set; }

        /// <summary>Optional. Ephemeral directories which won't persist across workstation sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralDirectories")]
        public virtual System.Collections.Generic.IList<EphemeralDirectory> EphemeralDirectories { get; set; }

        /// <summary>
        /// Optional. Checksum computed by the server. May be sent on update and delete requests to make sure that the
        /// client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Grant creator of a workstation `roles/workstations.policyAdmin` role along with
        /// `roles/workstations.user` role on the workstation created by them. This allows workstation users to share
        /// access to either their entire workstation, or individual ports. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantWorkstationAdminRoleOnCreate")]
        public virtual System.Nullable<bool> GrantWorkstationAdminRoleOnCreate { get; set; }

        /// <summary>Optional. Runtime host for the workstation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual Host Host { get; set; }

        /// <summary>
        /// Optional. HTTP options that customize the behavior of the workstation service's HTTP proxy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpOptions")]
        public virtual HttpOptions HttpOptions { get; set; }

        /// <summary>
        /// Optional. Number of seconds to wait before automatically stopping a workstation after it last received user
        /// traffic. A value of `"0s"` indicates that Cloud Workstations VMs created with this configuration should
        /// never time out due to idleness. Provide
        /// [duration](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#duration)
        /// terminated by `s` for seconds—for example, `"7200s"` (2 hours). The default is `"1200s"` (20 minutes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/workstations/docs/label-resources) that are applied to the
        /// workstation configuration and that are also propagated to the underlying Compute Engine resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Maximum number of workstations under this configuration a user can have
        /// `workstations.workstation.use` permission on. Only enforced on CreateWorkstation API calls on the user
        /// issuing the API request. Can be overridden by: - granting a user
        /// workstations.workstationConfigs.exemptMaxUsableWorkstationLimit permission, or - having a user with that
        /// permission create a workstation and granting another user `workstations.workstation.use` permission on that
        /// workstation. If not specified, defaults to `0`, which indicates unlimited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUsableWorkstations")]
        public virtual System.Nullable<int> MaxUsableWorkstations { get; set; }

        /// <summary>Identifier. Full name of this workstation configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Directories to persist across workstation sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentDirectories")]
        public virtual System.Collections.Generic.IList<PersistentDirectory> PersistentDirectories { get; set; }

        /// <summary>
        /// Optional. Readiness checks to perform when starting a workstation using this workstation configuration. Mark
        /// a workstation as running only after all specified readiness checks return 200 status codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readinessChecks")]
        public virtual System.Collections.Generic.IList<ReadinessCheck> ReadinessChecks { get; set; }

        /// <summary>
        /// Output only. Indicates whether this workstation configuration is currently being updated to match its
        /// intended state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Optional. Immutable. Specifies the zones used to replicate the VM and disk resources within the region. If
        /// set, exactly two zones within the workstation cluster's region must be specified—for example,
        /// `['us-central1-a', 'us-central1-f']`. If this field is empty, two default zones within the region are used.
        /// Immutable after the workstation configuration is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicaZones")]
        public virtual System.Collections.Generic.IList<string> ReplicaZones { get; set; }

        /// <summary>
        /// Optional. Number of seconds that a workstation can run until it is automatically shut down. We recommend
        /// that workstations be shut down daily to reduce costs and so that security updates can be applied upon
        /// restart. The idle_timeout and running_timeout fields are independent of each other. Note that the
        /// running_timeout field shuts down VMs after the specified time, regardless of whether or not the VMs are
        /// idle. Provide duration terminated by `s` for seconds—for example, `"54000s"` (15 hours). Defaults to
        /// `"43200s"` (12 hours). A value of `"0s"` indicates that workstations using this configuration should never
        /// time out. If encryption_key is set, it must be greater than `"0s"` and less than `"86400s"` (24 hours).
        /// Warning: A value of `"0s"` indicates that Cloud Workstations VMs created with this configuration have no
        /// maximum running time. This is strongly discouraged because you incur costs and will not pick up security
        /// updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runningTimeout")]
        public virtual object RunningTimeout { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzi")]
        public virtual System.Nullable<bool> SatisfiesPzi { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Output only. A system-assigned unique identifier for this workstation configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time when this workstation configuration was most recently updated.</summary>
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
}
