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

namespace Google.Apis.CloudVideoIntelligence.v1
{
    /// <summary>The CloudVideoIntelligence Service.</summary>
    public class CloudVideoIntelligenceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudVideoIntelligenceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudVideoIntelligenceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            Videos = new VideosResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://videointelligence.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://videointelligence.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "videointelligence";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Video Intelligence API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Video Intelligence API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Videos resource.</summary>
        public virtual VideosResource Videos { get; }
    }

    /// <summary>A base abstract class for CloudVideoIntelligence requests.</summary>
    public abstract class CloudVideoIntelligenceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudVideoIntelligenceBaseServiceRequest instance.</summary>
        protected CloudVideoIntelligenceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudVideoIntelligence parameter list.</summary>
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
            Projects = new ProjectsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(string name)
                    {
                        return new CancelRequest(this.service, name);
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
                    public class CancelRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/operations/{+name}:cancel";

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
                    public class DeleteRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleProtobufEmpty>
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
                        public override string RestPath => "v1/operations/{+name}";

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
                    public class GetRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningOperation>
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
                        public override string RestPath => "v1/operations/{+name}";

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
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
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
                public class CancelRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleProtobufEmpty>
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
                public class GetRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningOperation>
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
                public class ListRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningListOperationsResponse>
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

    /// <summary>The "videos" collection of methods.</summary>
    public class VideosResource
    {
        private const string Resource = "videos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VideosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface. `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnnotateRequest Annotate(Google.Apis.CloudVideoIntelligence.v1.Data.GoogleCloudVideointelligenceV1AnnotateVideoRequest body)
        {
            return new AnnotateRequest(this.service, body);
        }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface. `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        public class AnnotateRequest : CloudVideoIntelligenceBaseServiceRequest<Google.Apis.CloudVideoIntelligence.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Annotate request.</summary>
            public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudVideoIntelligence.v1.Data.GoogleCloudVideointelligenceV1AnnotateVideoRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudVideoIntelligence.v1.Data.GoogleCloudVideointelligenceV1AnnotateVideoRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "annotate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/videos:annotate";

            /// <summary>Initializes Annotate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.CloudVideoIntelligence.v1.Data
{
    /// <summary>
    /// Video annotation progress. Included in the `metadata` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1AnnotateVideoProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Progress metadata for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationProgress")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1VideoAnnotationProgress> AnnotationProgress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video annotation request.</summary>
    public class GoogleCloudVideointelligenceV1AnnotateVideoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Requested video annotation features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<string> Features { get; set; }

        /// <summary>
        /// The video data bytes. If unset, the input video(s) should be specified via the `input_uri`. If set,
        /// `input_uri` must be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputContent")]
        public virtual string InputContent { get; set; }

        /// <summary>
        /// Input video location. Currently, only [Cloud Storage](https://cloud.google.com/storage/) URIs are supported.
        /// URIs must be specified in the following format: `gs://bucket-id/object-id` (other URI formats return
        /// google.rpc.Code.INVALID_ARGUMENT). For more information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/request-endpoints). To identify multiple videos, a video URI may
        /// include wildcards in the `object-id`. Supported wildcards: '*' to match 0 or more characters; '?' to match 1
        /// character. If unset, the input video should be embedded in the request as `input_content`. If set,
        /// `input_content` must be unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>
        /// Optional. Cloud region where annotation should take place. Supported cloud regions are: `us-east1`,
        /// `us-west1`, `europe-west1`, `asia-east1`. If no region is specified, the region will be determined based on
        /// video file location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Optional. Location where the output (in JSON format) should be stored. Currently, only [Cloud
        /// Storage](https://cloud.google.com/storage/) URIs are supported. These must be specified in the following
        /// format: `gs://bucket-id/object-id` (other URI formats return google.rpc.Code.INVALID_ARGUMENT). For more
        /// information, see [Request URIs](https://cloud.google.com/storage/docs/request-endpoints).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputUri")]
        public virtual string OutputUri { get; set; }

        /// <summary>Additional video context and/or feature-specific parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoContext")]
        public virtual GoogleCloudVideointelligenceV1VideoContext VideoContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation response. Included in the `response` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1AnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation results for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1VideoAnnotationResults> AnnotationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected attribute represented by name in string format.</summary>
    public class GoogleCloudVideointelligenceV1DetectedAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected attribute confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The name of the attribute, for example, glasses, dark_glasses, mouth_open. A full list of supported type
        /// names will be provided in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text value of the detection result. For example, the value for "HairColor" can be "black", "blonde", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected landmark represented by name in string format and a 2D location.</summary>
    public class GoogleCloudVideointelligenceV1DetectedLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence score of the detected landmark. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of this landmark, for example, left_hand, right_shoulder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The 2D point of the detected landmark using the normalized image coordindate system. The normalized
        /// coordinates have the range from 0 to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual GoogleCloudVideointelligenceV1NormalizedVertex Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity from video analysis.</summary>
    public class GoogleCloudVideointelligenceV1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description, e.g., `Fixed-gear bicycle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Language code for `description` in BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Explicit content annotation (based on per-frame visual signals only). If no explicit content has been detected
    /// in a frame, no annotations are present for that frame.
    /// </summary>
    public class GoogleCloudVideointelligenceV1ExplicitContentAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where explicit content was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1ExplicitContentFrame> Frames { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for EXPLICIT_CONTENT_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1ExplicitContentDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Model to use for explicit content detection. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for explicit content.</summary>
    public class GoogleCloudVideointelligenceV1ExplicitContentFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Likelihood of the pornography content..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pornographyLikelihood")]
        public virtual string PornographyLikelihood { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1FaceFrame> Frames { get; set; }

        /// <summary>All video segments where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1FaceSegment> Segments { get; set; }

        /// <summary>Thumbnail of a representative face view (in JPEG format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Face detection annotation.</summary>
    public class GoogleCloudVideointelligenceV1FaceDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The face tracks with attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for FACE_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1FaceDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to enable face attributes detection, such as glasses, dark_glasses, mouth_open etc. Ignored if
        /// 'include_bounding_boxes' is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAttributes")]
        public virtual System.Nullable<bool> IncludeAttributes { get; set; }

        /// <summary>Whether bounding boxes are included in the face annotation output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeBoundingBoxes")]
        public virtual System.Nullable<bool> IncludeBoundingBoxes { get; set; }

        /// <summary>
        /// Model to use for face detection. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1FaceFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Normalized Bounding boxes in a frame. There can be more than one boxes if the same face is detected in
        /// multiple locations within the current frame.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBoxes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1NormalizedBoundingBox> NormalizedBoundingBoxes { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for face detection.</summary>
    public class GoogleCloudVideointelligenceV1FaceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Video segment where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label annotation.</summary>
    public class GoogleCloudVideointelligenceV1LabelAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common categories for the detected entity. For example, when the label is `Terrier`, the category is likely
        /// `dog`. And in some cases there might be more than one categories e.g., `Terrier` could also be a `pet`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1Entity> CategoryEntities { get; set; }

        /// <summary>Detected entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1Entity Entity { get; set; }

        /// <summary>All video frames where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelFrame> Frames { get; set; }

        /// <summary>All video segments where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelSegment> Segments { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for LABEL_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1LabelDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The confidence threshold we perform filtering on the labels from frame-level detection. If not set, it is
        /// set to 0.4 by default. The valid range for this threshold is [0.1, 0.9]. Any value set outside of this range
        /// will be clipped. Note: For best results, follow the default threshold. We will update the default threshold
        /// everytime when we release a new model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameConfidenceThreshold")]
        public virtual System.Nullable<float> FrameConfidenceThreshold { get; set; }

        /// <summary>
        /// What labels should be detected with LABEL_DETECTION, in addition to video-level labels or segment-level
        /// labels. If unspecified, defaults to `SHOT_MODE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelDetectionMode")]
        public virtual string LabelDetectionMode { get; set; }

        /// <summary>
        /// Model to use for label detection. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Whether the video has been shot from a stationary (i.e., non-moving) camera. When set to true, might improve
        /// detection accuracy for moving objects. Should be used with `SHOT_AND_FRAME_MODE` enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stationaryCamera")]
        public virtual System.Nullable<bool> StationaryCamera { get; set; }

        /// <summary>
        /// The confidence threshold we perform filtering on the labels from video-level and shot-level detections. If
        /// not set, it's set to 0.3 by default. The valid range for this threshold is [0.1, 0.9]. Any value set outside
        /// of this range will be clipped. Note: For best results, follow the default threshold. We will update the
        /// default threshold everytime when we release a new model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoConfidenceThreshold")]
        public virtual System.Nullable<float> VideoConfidenceThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1LabelFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1LabelSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation corresponding to one detected, tracked and recognized logo class.</summary>
    public class GoogleCloudVideointelligenceV1LogoRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entity category information to specify the logo class that all the logo tracks within this
        /// LogoRecognitionAnnotation are recognized as.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1Entity Entity { get; set; }

        /// <summary>
        /// All video segments where the recognized logo appears. There might be multiple instances of the same logo
        /// class appearing in one VideoSegment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1VideoSegment> Segments { get; set; }

        /// <summary>
        /// All logo tracks where the recognized logo appears. Each track corresponds to one logo instance appearing in
        /// consecutive frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding box. The normalized vertex coordinates are relative to the original image. Range: [0, 1].
    /// </summary>
    public class GoogleCloudVideointelligenceV1NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bottom Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Left X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Right X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Top Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding polygon for text (that might not be aligned with axis). Contains list of the corner points
    /// in clockwise order starting from top-left corner. For example, for a rectangular bounding box: When the text is
    /// horizontal it might look like: 0----1 | | 3----2 When it's clockwise rotated 180 degrees around the top-left
    /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3). Note that values can be
    /// less than 0, or greater than 1 due to trignometric calculations for location of the box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized vertices of the bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1NormalizedVertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVideointelligenceV1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotations corresponding to one tracked object.</summary>
    public class GoogleCloudVideointelligenceV1ObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object category's labeling confidence of this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity to specify the object category that this track is labeled as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1Entity Entity { get; set; }

        /// <summary>
        /// Information corresponding to all frames where this object track appears. Non-streaming batch mode: it may be
        /// one or multiple ObjectTrackingFrame messages in frames. Streaming mode: it can only be one
        /// ObjectTrackingFrame message in frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1ObjectTrackingFrame> Frames { get; set; }

        /// <summary>
        /// Non-streaming batch mode ONLY. Each object track corresponds to one video segment where it appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>
        /// Streaming mode ONLY. In streaming mode, we do not know the end time of a tracked object before it is
        /// completed. Hence, there is no VideoSegment info returned. Instead, we provide a unique identifiable integer
        /// track_id so that the customers can correlate the results of the ongoing ObjectTrackAnnotation of the same
        /// track_id over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Nullable<long> TrackId { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for OBJECT_TRACKING.</summary>
    public class GoogleCloudVideointelligenceV1ObjectTrackingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Model to use for object tracking. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotations for object detection and tracking. This field stores per frame location, time
    /// offset, and confidence.
    /// </summary>
    public class GoogleCloudVideointelligenceV1ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized bounding box location of this object track for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>The timestamp of the frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person detection annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1PersonDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected tracks of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for PERSON_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1PersonDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to enable person attributes detection, such as cloth color (black, blue, etc), type (coat, dress,
        /// etc), pattern (plain, floral, etc), hair, etc. Ignored if 'include_bounding_boxes' is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeAttributes")]
        public virtual System.Nullable<bool> IncludeAttributes { get; set; }

        /// <summary>Whether bounding boxes are included in the person detection annotation output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeBoundingBoxes")]
        public virtual System.Nullable<bool> IncludeBoundingBoxes { get; set; }

        /// <summary>
        /// Whether to enable pose landmarks detection. Ignored if 'include_bounding_boxes' is set to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includePoseLandmarks")]
        public virtual System.Nullable<bool> IncludePoseLandmarks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for SHOT_CHANGE_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1ShotChangeDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Model to use for shot change detection. Supported values: "builtin/stable" (the default if unset),
        /// "builtin/latest", and "builtin/legacy".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides "hints" to the speech recognizer to favor specific words and phrases in the results.</summary>
    public class GoogleCloudVideointelligenceV1SpeechContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of strings containing words and phrases "hints" so that the speech recognition is more
        /// likely to recognize them. This can be used to improve the accuracy for specific words and phrases, for
        /// example, if specific commands are typically spoken by the user. This can also be used to add additional
        /// words to the vocabulary of the recognizer. See [usage
        /// limits](https://cloud.google.com/speech/limits#content).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phrases")]
        public virtual System.Collections.Generic.IList<string> Phrases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class GoogleCloudVideointelligenceV1SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// Output only. A list of word-specific information for each recognized word. Note: When
        /// `enable_speaker_diarization` is set to true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class GoogleCloudVideointelligenceV1SpeechTranscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Output only. The [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag of the language in this
        /// result. This language code was detected to have the most likelihood of being spoken in the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for SPEECH_TRANSCRIPTION.</summary>
    public class GoogleCloudVideointelligenceV1SpeechTranscriptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. For file formats, such as MXF or MKV, supporting multiple audio tracks, specify up to two tracks.
        /// Default: track 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioTracks")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AudioTracks { get; set; }

        /// <summary>
        /// Optional. If set, specifies the estimated number of speakers in the conversation. If not set, defaults to
        /// '2'. Ignored unless enable_speaker_diarization is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diarizationSpeakerCount")]
        public virtual System.Nullable<int> DiarizationSpeakerCount { get; set; }

        /// <summary>
        /// Optional. If 'true', adds punctuation to recognition result hypotheses. This feature is only available in
        /// select languages. Setting this for requests in other languages has no effect at all. The default 'false'
        /// value does not add punctuation to result hypotheses. NOTE: "This is currently offered as an experimental
        /// service, complimentary to all users. In the future this may be exclusively available as a premium feature."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutomaticPunctuation")]
        public virtual System.Nullable<bool> EnableAutomaticPunctuation { get; set; }

        /// <summary>
        /// Optional. If 'true', enables speaker detection for each recognized word in the top alternative of the
        /// recognition result using a speaker_tag provided in the WordInfo. Note: When this is true, we send all the
        /// words from the beginning of the audio for the top alternative in every consecutive response. This is done in
        /// order to improve our speaker tags as our models learn to identify the speakers in the conversation over
        /// time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSpeakerDiarization")]
        public virtual System.Nullable<bool> EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// Optional. If `true`, the top result includes a list of words and the confidence for those words. If `false`,
        /// no word-level confidence information is returned. The default is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWordConfidence")]
        public virtual System.Nullable<bool> EnableWordConfidence { get; set; }

        /// <summary>
        /// Optional. If set to `true`, the server will attempt to filter out profanities, replacing all but the initial
        /// character in each filtered word with asterisks, e.g. "f***". If set to `false` or omitted, profanities won't
        /// be filtered out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterProfanity")]
        public virtual System.Nullable<bool> FilterProfanity { get; set; }

        /// <summary>
        /// Required. *Required* The language of the supplied audio as a
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. Example: "en-US". See [Language
        /// Support](https://cloud.google.com/speech/docs/languages) for a list of the currently supported language
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Maximum number of recognition hypotheses to be returned. Specifically, the maximum number of
        /// `SpeechRecognitionAlternative` messages within each `SpeechTranscription`. The server may return fewer than
        /// `max_alternatives`. Valid values are `0`-`30`. A value of `0` or `1` will return a maximum of one. If
        /// omitted, will return a maximum of one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAlternatives")]
        public virtual System.Nullable<int> MaxAlternatives { get; set; }

        /// <summary>Optional. A means to provide context to assist the speech recognition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1SpeechContext> SpeechContexts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations related to one detected OCR text snippet. This will contain the corresponding text, confidence
    /// value, and frame level information for each detection.
    /// </summary>
    public class GoogleCloudVideointelligenceV1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video segments where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1TextSegment> Segments { get; set; }

        /// <summary>The detected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config for TEXT_DETECTION.</summary>
    public class GoogleCloudVideointelligenceV1TextDetectionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Language hint can be specified if the language to be detected is known a priori. It can increase the
        /// accuracy of the detection. Language hint must be language code in BCP-47 format. Automatic language
        /// detection is performed if no hint is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageHints")]
        public virtual System.Collections.Generic.IList<string> LanguageHints { get; set; }

        /// <summary>
        /// Model to use for text detection. Supported values: "builtin/stable" (the default if unset) and
        /// "builtin/latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotation results for text annotation (OCR). Contains information regarding timestamp and
    /// bounding box locations for the frames containing detected OCR text snippets.
    /// </summary>
    public class GoogleCloudVideointelligenceV1TextFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding polygon of the detected text for this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1NormalizedBoundingPoly RotatedBoundingBox { get; set; }

        /// <summary>Timestamp of this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for text detection.</summary>
    public class GoogleCloudVideointelligenceV1TextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence for the track of detected text. It is calculated as the highest over all frames where OCR
        /// detected text appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Information related to the frames where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1TextFrame> Frames { get; set; }

        /// <summary>Video segment where a text snippet was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For tracking related features. An object at time_offset with attributes, and located with
    /// normalized_bounding_box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1TimestampedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The attributes of the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The detected landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1DetectedLandmark> Landmarks { get; set; }

        /// <summary>Normalized Bounding box in a frame, where the object is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track of an object instance.</summary>
    public class GoogleCloudVideointelligenceV1Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Attributes in the track level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The confidence score of the tracked object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment of a track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>The object with timestamp and attributes per frame in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampedObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1TimestampedObject> TimestampedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation progress for a single video.</summary>
    public class GoogleCloudVideointelligenceV1VideoAnnotationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which feature is being tracked if the request contains more than one feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Approximate percentage processed thus far. Guaranteed to be 100 when fully processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Specifies which segment is being tracked if the request contains more than one segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time of the most recent update.</summary>
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

    /// <summary>Annotation results for a single video.</summary>
    public class GoogleCloudVideointelligenceV1VideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, indicates an error. Note that for a single `AnnotateVideoRequest` some videos may succeed and some
        /// may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Explicit content annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Deprecated. Please use `face_detection_annotations` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>Face detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1FaceDetectionAnnotation> FaceDetectionAnnotations { get; set; }

        /// <summary>Label annotations on frame level. There is exactly one element for each unique label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelAnnotation> FrameLabelAnnotations { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Annotations for list of logos detected, tracked and recognized in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoRecognitionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LogoRecognitionAnnotation> LogoRecognitionAnnotations { get; set; }

        /// <summary>Annotations for list of objects detected and tracked in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Person detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1PersonDetectionAnnotation> PersonDetectionAnnotations { get; set; }

        /// <summary>Video segment on which the annotation is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1VideoSegment Segment { get; set; }

        /// <summary>
        /// Topical label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelAnnotation> SegmentLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label. Compared to the existing topical `segment_label_annotations`, this field presents more
        /// fine-grained, segment-level labels detected in video content and is made available only when the client sets
        /// `LabelDetectionConfig.model` to "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelAnnotation> SegmentPresenceLabelAnnotations { get; set; }

        /// <summary>Shot annotations. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1VideoSegment> ShotAnnotations { get; set; }

        /// <summary>
        /// Topical label annotations on shot level. There is exactly one element for each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelAnnotation> ShotLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on shot level. There is exactly one element for each unique label. Compared to
        /// the existing topical `shot_label_annotations`, this field presents more fine-grained, shot-level labels
        /// detected in video content and is made available only when the client sets `LabelDetectionConfig.model` to
        /// "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1LabelAnnotation> ShotPresenceLabelAnnotations { get; set; }

        /// <summary>Speech transcription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1SpeechTranscription> SpeechTranscriptions { get; set; }

        /// <summary>
        /// OCR text detection and tracking. Annotations for list of detected text snippets. Each will have list of
        /// frame information associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1TextAnnotation> TextAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video context and/or feature-specific parameters.</summary>
    public class GoogleCloudVideointelligenceV1VideoContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Config for EXPLICIT_CONTENT_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitContentDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1ExplicitContentDetectionConfig ExplicitContentDetectionConfig { get; set; }

        /// <summary>Config for FACE_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1FaceDetectionConfig FaceDetectionConfig { get; set; }

        /// <summary>Config for LABEL_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1LabelDetectionConfig LabelDetectionConfig { get; set; }

        /// <summary>Config for OBJECT_TRACKING.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectTrackingConfig")]
        public virtual GoogleCloudVideointelligenceV1ObjectTrackingConfig ObjectTrackingConfig { get; set; }

        /// <summary>Config for PERSON_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1PersonDetectionConfig PersonDetectionConfig { get; set; }

        /// <summary>
        /// Video segments to annotate. The segments may overlap and are not required to be contiguous or span the whole
        /// video. If unspecified, each video is treated as a single segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1VideoSegment> Segments { get; set; }

        /// <summary>Config for SHOT_CHANGE_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotChangeDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1ShotChangeDetectionConfig ShotChangeDetectionConfig { get; set; }

        /// <summary>Config for SPEECH_TRANSCRIPTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptionConfig")]
        public virtual GoogleCloudVideointelligenceV1SpeechTranscriptionConfig SpeechTranscriptionConfig { get; set; }

        /// <summary>Config for TEXT_DETECTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDetectionConfig")]
        public virtual GoogleCloudVideointelligenceV1TextDetectionConfig TextDetectionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment.</summary>
    public class GoogleCloudVideointelligenceV1VideoSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the end of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the start of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Word-specific information for recognized words. Word information is only included in the response when certain
    /// request parameters are set, such as `enable_word_time_offsets`.
    /// </summary>
    public class GoogleCloudVideointelligenceV1WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from 1 up to
        /// diarization_speaker_count, and is only set if speaker diarization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation progress. Included in the `metadata` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2AnnotateVideoProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Progress metadata for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationProgress")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2VideoAnnotationProgress> AnnotationProgress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation response. Included in the `response` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2AnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation results for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2VideoAnnotationResults> AnnotationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected attribute represented by name in string format.</summary>
    public class GoogleCloudVideointelligenceV1beta2DetectedAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected attribute confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The name of the attribute, for example, glasses, dark_glasses, mouth_open. A full list of supported type
        /// names will be provided in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text value of the detection result. For example, the value for "HairColor" can be "black", "blonde", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected landmark represented by name in string format and a 2D location.</summary>
    public class GoogleCloudVideointelligenceV1beta2DetectedLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence score of the detected landmark. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of this landmark, for example, left_hand, right_shoulder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The 2D point of the detected landmark using the normalized image coordindate system. The normalized
        /// coordinates have the range from 0 to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual GoogleCloudVideointelligenceV1beta2NormalizedVertex Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity from video analysis.</summary>
    public class GoogleCloudVideointelligenceV1beta2Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description, e.g., `Fixed-gear bicycle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Language code for `description` in BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Explicit content annotation (based on per-frame visual signals only). If no explicit content has been detected
    /// in a frame, no annotations are present for that frame.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2ExplicitContentAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where explicit content was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2ExplicitContentFrame> Frames { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for explicit content.</summary>
    public class GoogleCloudVideointelligenceV1beta2ExplicitContentFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Likelihood of the pornography content..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pornographyLikelihood")]
        public virtual string PornographyLikelihood { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1beta2FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2FaceFrame> Frames { get; set; }

        /// <summary>All video segments where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2FaceSegment> Segments { get; set; }

        /// <summary>Thumbnail of a representative face view (in JPEG format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Face detection annotation.</summary>
    public class GoogleCloudVideointelligenceV1beta2FaceDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The face tracks with attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1beta2FaceFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Normalized Bounding boxes in a frame. There can be more than one boxes if the same face is detected in
        /// multiple locations within the current frame.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBoxes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2NormalizedBoundingBox> NormalizedBoundingBoxes { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for face detection.</summary>
    public class GoogleCloudVideointelligenceV1beta2FaceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Video segment where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label annotation.</summary>
    public class GoogleCloudVideointelligenceV1beta2LabelAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common categories for the detected entity. For example, when the label is `Terrier`, the category is likely
        /// `dog`. And in some cases there might be more than one categories e.g., `Terrier` could also be a `pet`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2Entity> CategoryEntities { get; set; }

        /// <summary>Detected entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1beta2Entity Entity { get; set; }

        /// <summary>All video frames where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelFrame> Frames { get; set; }

        /// <summary>All video segments where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelSegment> Segments { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1beta2LabelFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1beta2LabelSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation corresponding to one detected, tracked and recognized logo class.</summary>
    public class GoogleCloudVideointelligenceV1beta2LogoRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entity category information to specify the logo class that all the logo tracks within this
        /// LogoRecognitionAnnotation are recognized as.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1beta2Entity Entity { get; set; }

        /// <summary>
        /// All video segments where the recognized logo appears. There might be multiple instances of the same logo
        /// class appearing in one VideoSegment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2VideoSegment> Segments { get; set; }

        /// <summary>
        /// All logo tracks where the recognized logo appears. Each track corresponds to one logo instance appearing in
        /// consecutive frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding box. The normalized vertex coordinates are relative to the original image. Range: [0, 1].
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bottom Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Left X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Right X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Top Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding polygon for text (that might not be aligned with axis). Contains list of the corner points
    /// in clockwise order starting from top-left corner. For example, for a rectangular bounding box: When the text is
    /// horizontal it might look like: 0----1 | | 3----2 When it's clockwise rotated 180 degrees around the top-left
    /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3). Note that values can be
    /// less than 0, or greater than 1 due to trignometric calculations for location of the box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized vertices of the bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2NormalizedVertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotations corresponding to one tracked object.</summary>
    public class GoogleCloudVideointelligenceV1beta2ObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object category's labeling confidence of this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity to specify the object category that this track is labeled as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1beta2Entity Entity { get; set; }

        /// <summary>
        /// Information corresponding to all frames where this object track appears. Non-streaming batch mode: it may be
        /// one or multiple ObjectTrackingFrame messages in frames. Streaming mode: it can only be one
        /// ObjectTrackingFrame message in frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2ObjectTrackingFrame> Frames { get; set; }

        /// <summary>
        /// Non-streaming batch mode ONLY. Each object track corresponds to one video segment where it appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>
        /// Streaming mode ONLY. In streaming mode, we do not know the end time of a tracked object before it is
        /// completed. Hence, there is no VideoSegment info returned. Instead, we provide a unique identifiable integer
        /// track_id so that the customers can correlate the results of the ongoing ObjectTrackAnnotation of the same
        /// track_id over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Nullable<long> TrackId { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotations for object detection and tracking. This field stores per frame location, time
    /// offset, and confidence.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized bounding box location of this object track for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1beta2NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>The timestamp of the frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person detection annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1beta2PersonDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected tracks of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class GoogleCloudVideointelligenceV1beta2SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// Output only. A list of word-specific information for each recognized word. Note: When
        /// `enable_speaker_diarization` is set to true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class GoogleCloudVideointelligenceV1beta2SpeechTranscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Output only. The [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag of the language in this
        /// result. This language code was detected to have the most likelihood of being spoken in the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations related to one detected OCR text snippet. This will contain the corresponding text, confidence
    /// value, and frame level information for each detection.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video segments where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2TextSegment> Segments { get; set; }

        /// <summary>The detected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotation results for text annotation (OCR). Contains information regarding timestamp and
    /// bounding box locations for the frames containing detected OCR text snippets.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2TextFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding polygon of the detected text for this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1beta2NormalizedBoundingPoly RotatedBoundingBox { get; set; }

        /// <summary>Timestamp of this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for text detection.</summary>
    public class GoogleCloudVideointelligenceV1beta2TextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence for the track of detected text. It is calculated as the highest over all frames where OCR
        /// detected text appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Information related to the frames where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2TextFrame> Frames { get; set; }

        /// <summary>Video segment where a text snippet was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For tracking related features. An object at time_offset with attributes, and located with
    /// normalized_bounding_box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2TimestampedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The attributes of the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The detected landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2DetectedLandmark> Landmarks { get; set; }

        /// <summary>Normalized Bounding box in a frame, where the object is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1beta2NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track of an object instance.</summary>
    public class GoogleCloudVideointelligenceV1beta2Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Attributes in the track level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The confidence score of the tracked object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment of a track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>The object with timestamp and attributes per frame in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampedObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2TimestampedObject> TimestampedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation progress for a single video.</summary>
    public class GoogleCloudVideointelligenceV1beta2VideoAnnotationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which feature is being tracked if the request contains more than one feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Approximate percentage processed thus far. Guaranteed to be 100 when fully processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Specifies which segment is being tracked if the request contains more than one segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time of the most recent update.</summary>
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

    /// <summary>Annotation results for a single video.</summary>
    public class GoogleCloudVideointelligenceV1beta2VideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, indicates an error. Note that for a single `AnnotateVideoRequest` some videos may succeed and some
        /// may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Explicit content annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1beta2ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Deprecated. Please use `face_detection_annotations` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>Face detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2FaceDetectionAnnotation> FaceDetectionAnnotations { get; set; }

        /// <summary>Label annotations on frame level. There is exactly one element for each unique label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelAnnotation> FrameLabelAnnotations { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Annotations for list of logos detected, tracked and recognized in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoRecognitionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LogoRecognitionAnnotation> LogoRecognitionAnnotations { get; set; }

        /// <summary>Annotations for list of objects detected and tracked in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Person detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2PersonDetectionAnnotation> PersonDetectionAnnotations { get; set; }

        /// <summary>Video segment on which the annotation is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1beta2VideoSegment Segment { get; set; }

        /// <summary>
        /// Topical label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelAnnotation> SegmentLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label. Compared to the existing topical `segment_label_annotations`, this field presents more
        /// fine-grained, segment-level labels detected in video content and is made available only when the client sets
        /// `LabelDetectionConfig.model` to "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelAnnotation> SegmentPresenceLabelAnnotations { get; set; }

        /// <summary>Shot annotations. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2VideoSegment> ShotAnnotations { get; set; }

        /// <summary>
        /// Topical label annotations on shot level. There is exactly one element for each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelAnnotation> ShotLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on shot level. There is exactly one element for each unique label. Compared to
        /// the existing topical `shot_label_annotations`, this field presents more fine-grained, shot-level labels
        /// detected in video content and is made available only when the client sets `LabelDetectionConfig.model` to
        /// "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2LabelAnnotation> ShotPresenceLabelAnnotations { get; set; }

        /// <summary>Speech transcription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2SpeechTranscription> SpeechTranscriptions { get; set; }

        /// <summary>
        /// OCR text detection and tracking. Annotations for list of detected text snippets. Each will have list of
        /// frame information associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1beta2TextAnnotation> TextAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment.</summary>
    public class GoogleCloudVideointelligenceV1beta2VideoSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the end of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the start of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Word-specific information for recognized words. Word information is only included in the response when certain
    /// request parameters are set, such as `enable_word_time_offsets`.
    /// </summary>
    public class GoogleCloudVideointelligenceV1beta2WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from 1 up to
        /// diarization_speaker_count, and is only set if speaker diarization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation progress. Included in the `metadata` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1AnnotateVideoProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Progress metadata for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationProgress")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1VideoAnnotationProgress> AnnotationProgress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation response. Included in the `response` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1AnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation results for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1VideoAnnotationResults> AnnotationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected attribute represented by name in string format.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1DetectedAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected attribute confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The name of the attribute, for example, glasses, dark_glasses, mouth_open. A full list of supported type
        /// names will be provided in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text value of the detection result. For example, the value for "HairColor" can be "black", "blonde", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected landmark represented by name in string format and a 2D location.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1DetectedLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence score of the detected landmark. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of this landmark, for example, left_hand, right_shoulder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The 2D point of the detected landmark using the normalized image coordindate system. The normalized
        /// coordinates have the range from 0 to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual GoogleCloudVideointelligenceV1p1beta1NormalizedVertex Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity from video analysis.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description, e.g., `Fixed-gear bicycle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Language code for `description` in BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Explicit content annotation (based on per-frame visual signals only). If no explicit content has been detected
    /// in a frame, no annotations are present for that frame.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1ExplicitContentAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where explicit content was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1ExplicitContentFrame> Frames { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for explicit content.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1ExplicitContentFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Likelihood of the pornography content..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pornographyLikelihood")]
        public virtual string PornographyLikelihood { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1FaceFrame> Frames { get; set; }

        /// <summary>All video segments where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1FaceSegment> Segments { get; set; }

        /// <summary>Thumbnail of a representative face view (in JPEG format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Face detection annotation.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1FaceDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The face tracks with attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1FaceFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Normalized Bounding boxes in a frame. There can be more than one boxes if the same face is detected in
        /// multiple locations within the current frame.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBoxes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingBox> NormalizedBoundingBoxes { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for face detection.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1FaceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Video segment where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label annotation.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1LabelAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common categories for the detected entity. For example, when the label is `Terrier`, the category is likely
        /// `dog`. And in some cases there might be more than one categories e.g., `Terrier` could also be a `pet`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1Entity> CategoryEntities { get; set; }

        /// <summary>Detected entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p1beta1Entity Entity { get; set; }

        /// <summary>All video frames where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelFrame> Frames { get; set; }

        /// <summary>All video segments where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelSegment> Segments { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1LabelFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1LabelSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation corresponding to one detected, tracked and recognized logo class.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1LogoRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entity category information to specify the logo class that all the logo tracks within this
        /// LogoRecognitionAnnotation are recognized as.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p1beta1Entity Entity { get; set; }

        /// <summary>
        /// All video segments where the recognized logo appears. There might be multiple instances of the same logo
        /// class appearing in one VideoSegment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1VideoSegment> Segments { get; set; }

        /// <summary>
        /// All logo tracks where the recognized logo appears. Each track corresponds to one logo instance appearing in
        /// consecutive frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding box. The normalized vertex coordinates are relative to the original image. Range: [0, 1].
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bottom Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Left X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Right X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Top Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding polygon for text (that might not be aligned with axis). Contains list of the corner points
    /// in clockwise order starting from top-left corner. For example, for a rectangular bounding box: When the text is
    /// horizontal it might look like: 0----1 | | 3----2 When it's clockwise rotated 180 degrees around the top-left
    /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3). Note that values can be
    /// less than 0, or greater than 1 due to trignometric calculations for location of the box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized vertices of the bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1NormalizedVertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotations corresponding to one tracked object.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1ObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object category's labeling confidence of this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity to specify the object category that this track is labeled as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p1beta1Entity Entity { get; set; }

        /// <summary>
        /// Information corresponding to all frames where this object track appears. Non-streaming batch mode: it may be
        /// one or multiple ObjectTrackingFrame messages in frames. Streaming mode: it can only be one
        /// ObjectTrackingFrame message in frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1ObjectTrackingFrame> Frames { get; set; }

        /// <summary>
        /// Non-streaming batch mode ONLY. Each object track corresponds to one video segment where it appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Streaming mode ONLY. In streaming mode, we do not know the end time of a tracked object before it is
        /// completed. Hence, there is no VideoSegment info returned. Instead, we provide a unique identifiable integer
        /// track_id so that the customers can correlate the results of the ongoing ObjectTrackAnnotation of the same
        /// track_id over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Nullable<long> TrackId { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotations for object detection and tracking. This field stores per frame location, time
    /// offset, and confidence.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized bounding box location of this object track for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>The timestamp of the frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person detection annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1PersonDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected tracks of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class GoogleCloudVideointelligenceV1p1beta1SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// Output only. A list of word-specific information for each recognized word. Note: When
        /// `enable_speaker_diarization` is set to true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1SpeechTranscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Output only. The [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag of the language in this
        /// result. This language code was detected to have the most likelihood of being spoken in the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations related to one detected OCR text snippet. This will contain the corresponding text, confidence
    /// value, and frame level information for each detection.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video segments where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1TextSegment> Segments { get; set; }

        /// <summary>The detected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotation results for text annotation (OCR). Contains information regarding timestamp and
    /// bounding box locations for the frames containing detected OCR text snippets.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1TextFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding polygon of the detected text for this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingPoly RotatedBoundingBox { get; set; }

        /// <summary>Timestamp of this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for text detection.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1TextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence for the track of detected text. It is calculated as the highest over all frames where OCR
        /// detected text appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Information related to the frames where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1TextFrame> Frames { get; set; }

        /// <summary>Video segment where a text snippet was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For tracking related features. An object at time_offset with attributes, and located with
    /// normalized_bounding_box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1TimestampedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The attributes of the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The detected landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1DetectedLandmark> Landmarks { get; set; }

        /// <summary>Normalized Bounding box in a frame, where the object is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p1beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track of an object instance.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Attributes in the track level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The confidence score of the tracked object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment of a track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>The object with timestamp and attributes per frame in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampedObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1TimestampedObject> TimestampedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation progress for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1VideoAnnotationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which feature is being tracked if the request contains more than one feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Approximate percentage processed thus far. Guaranteed to be 100 when fully processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Specifies which segment is being tracked if the request contains more than one segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time of the most recent update.</summary>
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

    /// <summary>Annotation results for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1VideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, indicates an error. Note that for a single `AnnotateVideoRequest` some videos may succeed and some
        /// may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Explicit content annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1p1beta1ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Deprecated. Please use `face_detection_annotations` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>Face detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1FaceDetectionAnnotation> FaceDetectionAnnotations { get; set; }

        /// <summary>Label annotations on frame level. There is exactly one element for each unique label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelAnnotation> FrameLabelAnnotations { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Annotations for list of logos detected, tracked and recognized in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoRecognitionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LogoRecognitionAnnotation> LogoRecognitionAnnotations { get; set; }

        /// <summary>Annotations for list of objects detected and tracked in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Person detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1PersonDetectionAnnotation> PersonDetectionAnnotations { get; set; }

        /// <summary>Video segment on which the annotation is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p1beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Topical label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelAnnotation> SegmentLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label. Compared to the existing topical `segment_label_annotations`, this field presents more
        /// fine-grained, segment-level labels detected in video content and is made available only when the client sets
        /// `LabelDetectionConfig.model` to "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelAnnotation> SegmentPresenceLabelAnnotations { get; set; }

        /// <summary>Shot annotations. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1VideoSegment> ShotAnnotations { get; set; }

        /// <summary>
        /// Topical label annotations on shot level. There is exactly one element for each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelAnnotation> ShotLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on shot level. There is exactly one element for each unique label. Compared to
        /// the existing topical `shot_label_annotations`, this field presents more fine-grained, shot-level labels
        /// detected in video content and is made available only when the client sets `LabelDetectionConfig.model` to
        /// "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1LabelAnnotation> ShotPresenceLabelAnnotations { get; set; }

        /// <summary>Speech transcription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1SpeechTranscription> SpeechTranscriptions { get; set; }

        /// <summary>
        /// OCR text detection and tracking. Annotations for list of detected text snippets. Each will have list of
        /// frame information associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p1beta1TextAnnotation> TextAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment.</summary>
    public class GoogleCloudVideointelligenceV1p1beta1VideoSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the end of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the start of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Word-specific information for recognized words. Word information is only included in the response when certain
    /// request parameters are set, such as `enable_word_time_offsets`.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p1beta1WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from 1 up to
        /// diarization_speaker_count, and is only set if speaker diarization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation progress. Included in the `metadata` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1AnnotateVideoProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Progress metadata for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationProgress")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1VideoAnnotationProgress> AnnotationProgress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation response. Included in the `response` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1AnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation results for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1VideoAnnotationResults> AnnotationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected attribute represented by name in string format.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1DetectedAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected attribute confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The name of the attribute, for example, glasses, dark_glasses, mouth_open. A full list of supported type
        /// names will be provided in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text value of the detection result. For example, the value for "HairColor" can be "black", "blonde", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected landmark represented by name in string format and a 2D location.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1DetectedLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence score of the detected landmark. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of this landmark, for example, left_hand, right_shoulder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The 2D point of the detected landmark using the normalized image coordindate system. The normalized
        /// coordinates have the range from 0 to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual GoogleCloudVideointelligenceV1p2beta1NormalizedVertex Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity from video analysis.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description, e.g., `Fixed-gear bicycle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Language code for `description` in BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Explicit content annotation (based on per-frame visual signals only). If no explicit content has been detected
    /// in a frame, no annotations are present for that frame.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1ExplicitContentAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where explicit content was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1ExplicitContentFrame> Frames { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for explicit content.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1ExplicitContentFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Likelihood of the pornography content..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pornographyLikelihood")]
        public virtual string PornographyLikelihood { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1FaceFrame> Frames { get; set; }

        /// <summary>All video segments where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1FaceSegment> Segments { get; set; }

        /// <summary>Thumbnail of a representative face view (in JPEG format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Face detection annotation.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1FaceDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The face tracks with attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1FaceFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Normalized Bounding boxes in a frame. There can be more than one boxes if the same face is detected in
        /// multiple locations within the current frame.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBoxes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingBox> NormalizedBoundingBoxes { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for face detection.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1FaceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Video segment where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label annotation.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1LabelAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common categories for the detected entity. For example, when the label is `Terrier`, the category is likely
        /// `dog`. And in some cases there might be more than one categories e.g., `Terrier` could also be a `pet`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1Entity> CategoryEntities { get; set; }

        /// <summary>Detected entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p2beta1Entity Entity { get; set; }

        /// <summary>All video frames where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelFrame> Frames { get; set; }

        /// <summary>All video segments where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelSegment> Segments { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1LabelFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1LabelSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation corresponding to one detected, tracked and recognized logo class.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1LogoRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entity category information to specify the logo class that all the logo tracks within this
        /// LogoRecognitionAnnotation are recognized as.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p2beta1Entity Entity { get; set; }

        /// <summary>
        /// All video segments where the recognized logo appears. There might be multiple instances of the same logo
        /// class appearing in one VideoSegment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1VideoSegment> Segments { get; set; }

        /// <summary>
        /// All logo tracks where the recognized logo appears. Each track corresponds to one logo instance appearing in
        /// consecutive frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding box. The normalized vertex coordinates are relative to the original image. Range: [0, 1].
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bottom Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Left X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Right X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Top Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding polygon for text (that might not be aligned with axis). Contains list of the corner points
    /// in clockwise order starting from top-left corner. For example, for a rectangular bounding box: When the text is
    /// horizontal it might look like: 0----1 | | 3----2 When it's clockwise rotated 180 degrees around the top-left
    /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3). Note that values can be
    /// less than 0, or greater than 1 due to trignometric calculations for location of the box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized vertices of the bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1NormalizedVertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotations corresponding to one tracked object.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1ObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object category's labeling confidence of this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity to specify the object category that this track is labeled as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p2beta1Entity Entity { get; set; }

        /// <summary>
        /// Information corresponding to all frames where this object track appears. Non-streaming batch mode: it may be
        /// one or multiple ObjectTrackingFrame messages in frames. Streaming mode: it can only be one
        /// ObjectTrackingFrame message in frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1ObjectTrackingFrame> Frames { get; set; }

        /// <summary>
        /// Non-streaming batch mode ONLY. Each object track corresponds to one video segment where it appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Streaming mode ONLY. In streaming mode, we do not know the end time of a tracked object before it is
        /// completed. Hence, there is no VideoSegment info returned. Instead, we provide a unique identifiable integer
        /// track_id so that the customers can correlate the results of the ongoing ObjectTrackAnnotation of the same
        /// track_id over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Nullable<long> TrackId { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotations for object detection and tracking. This field stores per frame location, time
    /// offset, and confidence.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized bounding box location of this object track for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>The timestamp of the frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person detection annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1PersonDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected tracks of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class GoogleCloudVideointelligenceV1p2beta1SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// Output only. A list of word-specific information for each recognized word. Note: When
        /// `enable_speaker_diarization` is set to true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1SpeechTranscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Output only. The [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag of the language in this
        /// result. This language code was detected to have the most likelihood of being spoken in the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations related to one detected OCR text snippet. This will contain the corresponding text, confidence
    /// value, and frame level information for each detection.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video segments where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1TextSegment> Segments { get; set; }

        /// <summary>The detected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotation results for text annotation (OCR). Contains information regarding timestamp and
    /// bounding box locations for the frames containing detected OCR text snippets.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1TextFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding polygon of the detected text for this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingPoly RotatedBoundingBox { get; set; }

        /// <summary>Timestamp of this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for text detection.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1TextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence for the track of detected text. It is calculated as the highest over all frames where OCR
        /// detected text appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Information related to the frames where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1TextFrame> Frames { get; set; }

        /// <summary>Video segment where a text snippet was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For tracking related features. An object at time_offset with attributes, and located with
    /// normalized_bounding_box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1TimestampedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The attributes of the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The detected landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1DetectedLandmark> Landmarks { get; set; }

        /// <summary>Normalized Bounding box in a frame, where the object is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p2beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track of an object instance.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Attributes in the track level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The confidence score of the tracked object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment of a track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>The object with timestamp and attributes per frame in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampedObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1TimestampedObject> TimestampedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation progress for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1VideoAnnotationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which feature is being tracked if the request contains more than one feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Approximate percentage processed thus far. Guaranteed to be 100 when fully processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Specifies which segment is being tracked if the request contains more than one segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time of the most recent update.</summary>
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

    /// <summary>Annotation results for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1VideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, indicates an error. Note that for a single `AnnotateVideoRequest` some videos may succeed and some
        /// may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Explicit content annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1p2beta1ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Deprecated. Please use `face_detection_annotations` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>Face detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1FaceDetectionAnnotation> FaceDetectionAnnotations { get; set; }

        /// <summary>Label annotations on frame level. There is exactly one element for each unique label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelAnnotation> FrameLabelAnnotations { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Annotations for list of logos detected, tracked and recognized in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoRecognitionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LogoRecognitionAnnotation> LogoRecognitionAnnotations { get; set; }

        /// <summary>Annotations for list of objects detected and tracked in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Person detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1PersonDetectionAnnotation> PersonDetectionAnnotations { get; set; }

        /// <summary>Video segment on which the annotation is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p2beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Topical label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelAnnotation> SegmentLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label. Compared to the existing topical `segment_label_annotations`, this field presents more
        /// fine-grained, segment-level labels detected in video content and is made available only when the client sets
        /// `LabelDetectionConfig.model` to "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelAnnotation> SegmentPresenceLabelAnnotations { get; set; }

        /// <summary>Shot annotations. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1VideoSegment> ShotAnnotations { get; set; }

        /// <summary>
        /// Topical label annotations on shot level. There is exactly one element for each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelAnnotation> ShotLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on shot level. There is exactly one element for each unique label. Compared to
        /// the existing topical `shot_label_annotations`, this field presents more fine-grained, shot-level labels
        /// detected in video content and is made available only when the client sets `LabelDetectionConfig.model` to
        /// "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1LabelAnnotation> ShotPresenceLabelAnnotations { get; set; }

        /// <summary>Speech transcription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1SpeechTranscription> SpeechTranscriptions { get; set; }

        /// <summary>
        /// OCR text detection and tracking. Annotations for list of detected text snippets. Each will have list of
        /// frame information associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p2beta1TextAnnotation> TextAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment.</summary>
    public class GoogleCloudVideointelligenceV1p2beta1VideoSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the end of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the start of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Word-specific information for recognized words. Word information is only included in the response when certain
    /// request parameters are set, such as `enable_word_time_offsets`.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p2beta1WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from 1 up to
        /// diarization_speaker_count, and is only set if speaker diarization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation progress. Included in the `metadata` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1AnnotateVideoProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Progress metadata for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationProgress")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1VideoAnnotationProgress> AnnotationProgress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video annotation response. Included in the `response` field of the `Operation` returned by the `GetOperation`
    /// call of the `google::longrunning::Operations` service.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1AnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Annotation results for all videos specified in `AnnotateVideoRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1VideoAnnotationResults> AnnotationResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Celebrity definition.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1Celebrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description of additional information about the celebrity, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The celebrity name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the celebrity. Have the format `video-intelligence/kg-mid` indicates a celebrity from
        /// preloaded gallery. kg-mid is the id in Google knowledge graph, which is unique for the celebrity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Celebrity recognition annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1CelebrityRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The tracks detected from the input video, including recognized celebrities and other detected faces in the
        /// video.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celebrityTracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1CelebrityTrack> CelebrityTracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The annotation result of a celebrity face track. RecognizedCelebrity field could be empty if the face track does
    /// not have any matched celebrities.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1CelebrityTrack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Top N match of the celebrities for the face in this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celebrities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1RecognizedCelebrity> Celebrities { get; set; }

        /// <summary>A track of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceTrack")]
        public virtual GoogleCloudVideointelligenceV1p3beta1Track FaceTrack { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected attribute represented by name in string format.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1DetectedAttribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected attribute confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// The name of the attribute, for example, glasses, dark_glasses, mouth_open. A full list of supported type
        /// names will be provided in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Text value of the detection result. For example, the value for "HairColor" can be "black", "blonde", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A generic detected landmark represented by name in string format and a 2D location.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1DetectedLandmark : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence score of the detected landmark. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The name of this landmark, for example, left_hand, right_shoulder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The 2D point of the detected landmark using the normalized image coordindate system. The normalized
        /// coordinates have the range from 0 to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual GoogleCloudVideointelligenceV1p3beta1NormalizedVertex Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detected entity from video analysis.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual description, e.g., `Fixed-gear bicycle`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Opaque entity ID. Some IDs may be available in [Google Knowledge Graph Search
        /// API](https://developers.google.com/knowledge-graph/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Language code for `description` in BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Explicit content annotation (based on per-frame visual signals only). If no explicit content has been detected
    /// in a frame, no annotations are present for that frame.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1ExplicitContentAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where explicit content was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1ExplicitContentFrame> Frames { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for explicit content.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1ExplicitContentFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Likelihood of the pornography content..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pornographyLikelihood")]
        public virtual string PornographyLikelihood { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1FaceAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video frames where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1FaceFrame> Frames { get; set; }

        /// <summary>All video segments where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1FaceSegment> Segments { get; set; }

        /// <summary>Thumbnail of a representative face view (in JPEG format).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Face detection annotation.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1FaceDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The thumbnail of a person's face.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnail")]
        public virtual string Thumbnail { get; set; }

        /// <summary>The face tracks with attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated. No effect.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1FaceFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Normalized Bounding boxes in a frame. There can be more than one boxes if the same face is detected in
        /// multiple locations within the current frame.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBoxes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingBox> NormalizedBoundingBoxes { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for face detection.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1FaceSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Video segment where a face was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label annotation.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1LabelAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Common categories for the detected entity. For example, when the label is `Terrier`, the category is likely
        /// `dog`. And in some cases there might be more than one categories e.g., `Terrier` could also be a `pet`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryEntities")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1Entity> CategoryEntities { get; set; }

        /// <summary>Detected entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p3beta1Entity Entity { get; set; }

        /// <summary>All video frames where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelFrame> Frames { get; set; }

        /// <summary>All video segments where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelSegment> Segments { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video frame level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1LabelFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for label detection.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1LabelSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Confidence that the label is accurate. Range: [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment where a label was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation corresponding to one detected, tracked and recognized logo class.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1LogoRecognitionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entity category information to specify the logo class that all the logo tracks within this
        /// LogoRecognitionAnnotation are recognized as.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p3beta1Entity Entity { get; set; }

        /// <summary>
        /// All video segments where the recognized logo appears. There might be multiple instances of the same logo
        /// class appearing in one VideoSegment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1VideoSegment> Segments { get; set; }

        /// <summary>
        /// All logo tracks where the recognized logo appears. Each track corresponds to one logo instance appearing in
        /// consecutive frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding box. The normalized vertex coordinates are relative to the original image. Range: [0, 1].
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bottom Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<float> Bottom { get; set; }

        /// <summary>Left X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<float> Left { get; set; }

        /// <summary>Right X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<float> Right { get; set; }

        /// <summary>Top Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<float> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Normalized bounding polygon for text (that might not be aligned with axis). Contains list of the corner points
    /// in clockwise order starting from top-left corner. For example, for a rectangular bounding box: When the text is
    /// horizontal it might look like: 0----1 | | 3----2 When it's clockwise rotated 180 degrees around the top-left
    /// corner it becomes: 2----3 | | 1----0 and the vertex order will still be (0, 1, 2, 3). Note that values can be
    /// less than 0, or greater than 1 due to trignometric calculations for location of the box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingPoly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Normalized vertices of the bounding polygon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertices")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1NormalizedVertex> Vertices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A vertex represents a 2D point in the image. NOTE: the normalized vertex coordinates are relative to the
    /// original image and range from 0 to 1.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1NormalizedVertex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>X coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<float> X { get; set; }

        /// <summary>Y coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<float> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotations corresponding to one tracked object.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1ObjectTrackingAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Object category's labeling confidence of this track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Entity to specify the object category that this track is labeled as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual GoogleCloudVideointelligenceV1p3beta1Entity Entity { get; set; }

        /// <summary>
        /// Information corresponding to all frames where this object track appears. Non-streaming batch mode: it may be
        /// one or multiple ObjectTrackingFrame messages in frames. Streaming mode: it can only be one
        /// ObjectTrackingFrame message in frames.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1ObjectTrackingFrame> Frames { get; set; }

        /// <summary>
        /// Non-streaming batch mode ONLY. Each object track corresponds to one video segment where it appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Streaming mode ONLY. In streaming mode, we do not know the end time of a tracked object before it is
        /// completed. Hence, there is no VideoSegment info returned. Instead, we provide a unique identifiable integer
        /// track_id so that the customers can correlate the results of the ongoing ObjectTrackAnnotation of the same
        /// track_id over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual System.Nullable<long> TrackId { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotations for object detection and tracking. This field stores per frame location, time
    /// offset, and confidence.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1ObjectTrackingFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The normalized bounding box location of this object track for the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>The timestamp of the frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person detection annotation per video.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1PersonDetectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The detected tracks of a person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1Track> Tracks { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The recognized celebrity with confidence score.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1RecognizedCelebrity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recognized celebrity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celebrity")]
        public virtual GoogleCloudVideointelligenceV1p3beta1Celebrity Celebrity { get; set; }

        /// <summary>Recognition confidence. Range [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class GoogleCloudVideointelligenceV1p3beta1SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// Output only. A list of word-specific information for each recognized word. Note: When
        /// `enable_speaker_diarization` is set to true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1SpeechTranscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// Output only. The [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag of the language in this
        /// result. This language code was detected to have the most likelihood of being spoken in the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `StreamingAnnotateVideoResponse` is the only message returned to the client by `StreamingAnnotateVideo`. A
    /// series of zero or more `StreamingAnnotateVideoResponse` messages are streamed back to the client.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1StreamingAnnotateVideoResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Streaming annotation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResults")]
        public virtual GoogleCloudVideointelligenceV1p3beta1StreamingVideoAnnotationResults AnnotationResults { get; set; }

        /// <summary>
        /// Google Cloud Storage URI that stores annotation results of one streaming session in JSON format. It is the
        /// annotation_result_storage_directory from the request followed by '/cloud_project_number-session_id'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotationResultsUri")]
        public virtual string AnnotationResultsUri { get; set; }

        /// <summary>If set, returns a google.rpc.Status message that specifies the error for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Streaming annotation results corresponding to a portion of the video that is currently being processed. Only ONE
    /// type of annotation will be specified in the response.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1StreamingVideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explicit content annotation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1p3beta1ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Timestamp of the processed frame in microseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameTimestamp")]
        public virtual object FrameTimestamp { get; set; }

        /// <summary>Label annotation results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> LabelAnnotations { get; set; }

        /// <summary>Object tracking results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Shot annotation results. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1VideoSegment> ShotAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Annotations related to one detected OCR text snippet. This will contain the corresponding text, confidence
    /// value, and frame level information for each detection.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1TextAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All video segments where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1TextSegment> Segments { get; set; }

        /// <summary>The detected text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Feature version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Video frame level annotation results for text annotation (OCR). Contains information regarding timestamp and
    /// bounding box locations for the frames containing detected OCR text snippets.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1TextFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding polygon of the detected text for this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotatedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingPoly RotatedBoundingBox { get; set; }

        /// <summary>Timestamp of this frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment level annotation results for text detection.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1TextSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Confidence for the track of detected text. It is calculated as the highest over all frames where OCR
        /// detected text appears.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Information related to the frames where OCR detected text appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1TextFrame> Frames { get; set; }

        /// <summary>Video segment where a text snippet was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For tracking related features. An object at time_offset with attributes, and located with
    /// normalized_bounding_box.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1TimestampedObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The attributes of the object in the bounding box.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The detected landmarks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landmarks")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1DetectedLandmark> Landmarks { get; set; }

        /// <summary>Normalized Bounding box in a frame, where the object is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedBoundingBox")]
        public virtual GoogleCloudVideointelligenceV1p3beta1NormalizedBoundingBox NormalizedBoundingBox { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the video frame for this object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOffset")]
        public virtual object TimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track of an object instance.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Attributes in the track level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1DetectedAttribute> Attributes { get; set; }

        /// <summary>Optional. The confidence score of the tracked object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Video segment of a track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>The object with timestamp and attributes per frame in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampedObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1TimestampedObject> TimestampedObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation progress for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1VideoAnnotationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which feature is being tracked if the request contains more than one feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual string Feature { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Approximate percentage processed thus far. Guaranteed to be 100 when fully processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Specifies which segment is being tracked if the request contains more than one segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Time of the most recent update.</summary>
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

    /// <summary>Annotation results for a single video.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1VideoAnnotationResults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Celebrity recognition annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("celebrityRecognitionAnnotations")]
        public virtual GoogleCloudVideointelligenceV1p3beta1CelebrityRecognitionAnnotation CelebrityRecognitionAnnotations { get; set; }

        /// <summary>
        /// If set, indicates an error. Note that for a single `AnnotateVideoRequest` some videos may succeed and some
        /// may fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>Explicit content annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitAnnotation")]
        public virtual GoogleCloudVideointelligenceV1p3beta1ExplicitContentAnnotation ExplicitAnnotation { get; set; }

        /// <summary>Deprecated. Please use `face_detection_annotations` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1FaceAnnotation> FaceAnnotations { get; set; }

        /// <summary>Face detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faceDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1FaceDetectionAnnotation> FaceDetectionAnnotations { get; set; }

        /// <summary>Label annotations on frame level. There is exactly one element for each unique label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frameLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> FrameLabelAnnotations { get; set; }

        /// <summary>Video file location in [Cloud Storage](https://cloud.google.com/storage/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputUri")]
        public virtual string InputUri { get; set; }

        /// <summary>Annotations for list of logos detected, tracked and recognized in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logoRecognitionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LogoRecognitionAnnotation> LogoRecognitionAnnotations { get; set; }

        /// <summary>Annotations for list of objects detected and tracked in video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1ObjectTrackingAnnotation> ObjectAnnotations { get; set; }

        /// <summary>Person detection annotations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personDetectionAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1PersonDetectionAnnotation> PersonDetectionAnnotations { get; set; }

        /// <summary>Video segment on which the annotation is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual GoogleCloudVideointelligenceV1p3beta1VideoSegment Segment { get; set; }

        /// <summary>
        /// Topical label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> SegmentLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on video level or user-specified segment level. There is exactly one element for
        /// each unique label. Compared to the existing topical `segment_label_annotations`, this field presents more
        /// fine-grained, segment-level labels detected in video content and is made available only when the client sets
        /// `LabelDetectionConfig.model` to "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> SegmentPresenceLabelAnnotations { get; set; }

        /// <summary>Shot annotations. Each shot is represented as a video segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1VideoSegment> ShotAnnotations { get; set; }

        /// <summary>
        /// Topical label annotations on shot level. There is exactly one element for each unique label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> ShotLabelAnnotations { get; set; }

        /// <summary>
        /// Presence label annotations on shot level. There is exactly one element for each unique label. Compared to
        /// the existing topical `shot_label_annotations`, this field presents more fine-grained, shot-level labels
        /// detected in video content and is made available only when the client sets `LabelDetectionConfig.model` to
        /// "builtin/latest" in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shotPresenceLabelAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1LabelAnnotation> ShotPresenceLabelAnnotations { get; set; }

        /// <summary>Speech transcription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechTranscriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1SpeechTranscription> SpeechTranscriptions { get; set; }

        /// <summary>
        /// OCR text detection and tracking. Annotations for list of detected text snippets. Each will have list of
        /// frame information associated with it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnnotations")]
        public virtual System.Collections.Generic.IList<GoogleCloudVideointelligenceV1p3beta1TextAnnotation> TextAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video segment.</summary>
    public class GoogleCloudVideointelligenceV1p3beta1VideoSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the end of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeOffset")]
        public virtual object EndTimeOffset { get; set; }

        /// <summary>
        /// Time-offset, relative to the beginning of the video, corresponding to the start of the segment (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeOffset")]
        public virtual object StartTimeOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Word-specific information for recognized words. Word information is only included in the response when certain
    /// request parameters are set, such as `enable_word_time_offsets`.
    /// </summary>
    public class GoogleCloudVideointelligenceV1p3beta1WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater
        /// likelihood that the recognized words are correct. This field is set only for the top alternative. This field
        /// is not guaranteed to be accurate and users should not rely on it to be always provided. The default of 0.0
        /// is a sentinel value indicating `confidence` was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from 1 up to
        /// diarization_speaker_count, and is only set if speaker diarization is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
}
