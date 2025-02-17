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

namespace Google.Apis.OnDemandScanning.v1beta1
{
    /// <summary>The OnDemandScanning Service.</summary>
    public class OnDemandScanningService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OnDemandScanningService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OnDemandScanningService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://ondemandscanning.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://ondemandscanning.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "ondemandscanning";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the On-Demand Scanning API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the On-Demand Scanning API.</summary>
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

    /// <summary>A base abstract class for OnDemandScanning requests.</summary>
    public abstract class OnDemandScanningBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OnDemandScanningBaseServiceRequest instance.</summary>
        protected OnDemandScanningBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OnDemandScanning parameter list.</summary>
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
                Scans = new ScansResource(service);
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
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(this.service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.Empty>
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
                public class DeleteRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.Empty>
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
                public class GetRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.Operation>
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
                public class ListRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.ListOperationsResponse>
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

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                /// <param name="name">The name of the operation resource to wait on.</param>
                public virtual WaitRequest Wait(string name)
                {
                    return new WaitRequest(this.service, name);
                }

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                public class WaitRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Wait request.</summary>
                    public WaitRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to wait on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The maximum duration to wait before timing out. If left blank, the wait will be at most the time
                    /// permitted by the underlying HTTP/RPC protocol. If RPC context deadline is also specified, the
                    /// shorter one will be used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("timeout", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object Timeout { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "wait";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:wait";

                    /// <summary>Initializes Wait parameter list.</summary>
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
                        RequestParameters.Add("timeout", new Google.Apis.Discovery.Parameter
                        {
                            Name = "timeout",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Scans resource.</summary>
            public virtual ScansResource Scans { get; }

            /// <summary>The "scans" collection of methods.</summary>
            public class ScansResource
            {
                private const string Resource = "scans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ScansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Vulnerabilities = new VulnerabilitiesResource(service);
                }

                /// <summary>Gets the Vulnerabilities resource.</summary>
                public virtual VulnerabilitiesResource Vulnerabilities { get; }

                /// <summary>The "vulnerabilities" collection of methods.</summary>
                public class VulnerabilitiesResource
                {
                    private const string Resource = "vulnerabilities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VulnerabilitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists vulnerabilities resulting from a successfully completed scan.</summary>
                    /// <param name="parent">
                    /// Required. The parent of the collection of Vulnerabilities being requested. Format:
                    /// projects/[project_name]/locations/[location]/scans/[scan_id]
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists vulnerabilities resulting from a successfully completed scan.</summary>
                    public class ListRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.ListVulnerabilitiesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent of the collection of Vulnerabilities being requested. Format:
                        /// projects/[project_name]/locations/[location]/scans/[scan_id]
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The number of vulnerabilities to retrieve.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The page token, resulting from a previous call to ListVulnerabilities.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta1/{+parent}/vulnerabilities";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/scans/[^/]+$",
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

                /// <summary>Initiates an analysis of the provided packages.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the resource for which analysis is requested. Format:
                /// projects/[project_name]/locations/[location]
                /// </param>
                public virtual AnalyzePackagesRequest AnalyzePackages(Google.Apis.OnDemandScanning.v1beta1.Data.AnalyzePackagesRequest body, string parent)
                {
                    return new AnalyzePackagesRequest(this.service, body, parent);
                }

                /// <summary>Initiates an analysis of the provided packages.</summary>
                public class AnalyzePackagesRequest : OnDemandScanningBaseServiceRequest<Google.Apis.OnDemandScanning.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new AnalyzePackages request.</summary>
                    public AnalyzePackagesRequest(Google.Apis.Services.IClientService service, Google.Apis.OnDemandScanning.v1beta1.Data.AnalyzePackagesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the resource for which analysis is requested. Format:
                    /// projects/[project_name]/locations/[location]
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OnDemandScanning.v1beta1.Data.AnalyzePackagesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "analyzePackages";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/scans:analyzePackages";

                    /// <summary>Initializes AnalyzePackages parameter list.</summary>
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
            }
        }
    }
}
namespace Google.Apis.OnDemandScanning.v1beta1.Data
{
    /// <summary>An alias to a repo revision.</summary>
    public class AliasContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alias kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates which analysis completed successfully. Multiple types of analysis can be performed on a single
    /// resource.
    /// </summary>
    public class AnalysisCompleted : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("analysisType")]
        public virtual System.Collections.Generic.IList<string> AnalysisType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AnalyzePackagesMetadata contains metadata for an active scan of a container image.</summary>
    public class AnalyzePackagesMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>When the scan was created.</summary>
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

        /// <summary>The resource URI of the container image being scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AnalyzePackagesMetadata contains metadata for an active scan of a container image.</summary>
    public class AnalyzePackagesMetadataV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>When the scan was created.</summary>
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

        /// <summary>The resource URI of the container image being scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AnalyzePackagesRequest is the request to analyze a list of packages and create Vulnerability Occurrences for it.
    /// </summary>
    public class AnalyzePackagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The packages to analyze.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<PackageData> Packages { get; set; }

        /// <summary>Required. The resource URI of the container image being scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AnalyzePackagesResponse contains the information necessary to find results for the given scan.
    /// </summary>
    public class AnalyzePackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the scan resource created by this successful scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scan")]
        public virtual string Scan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AnalyzePackagesResponse contains the information necessary to find results for the given scan.
    /// </summary>
    public class AnalyzePackagesResponseV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the scan resource created by this successful scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scan")]
        public virtual string Scan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact describes a build product.</summary>
    public class Artifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash or checksum value of a binary, or Docker Registry 2.0 digest of a container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual string Checksum { get; set; }

        /// <summary>
        /// Artifact ID, if any; for container images, this will be a URL by digest like
        /// `gcr.io/projectID/imagename@sha256:123456`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Related artifact names. This may be the path to a binary or jar file, or in the case of a container build,
        /// the name used to push the container image to Google Container Registry, as presented to `docker push`. Note
        /// that a single Artifact ID can have multiple names, for example if two tags are applied to one image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Occurrence that represents a single "attestation". The authenticity of an attestation can be verified using the
    /// attached signature. If the verifier trusts the public key of the signer, then verifying the signature is
    /// sufficient to establish trust. In this circumstance, the authority to which this attestation is attached is
    /// primarily useful for lookup (how to find this attestation if you already know the authority and artifact to be
    /// verified) and intent (for which authority this attestation was intended to sign.
    /// </summary>
    public class AttestationOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One or more JWTs encoding a self-contained attestation. Each JWT encodes the payload that it verifies within
        /// the JWT itself. Verifier implementation SHOULD ignore the `serialized_payload` field when verifying these
        /// JWTs. If only JWTs are present on this AttestationOccurrence, then the `serialized_payload` SHOULD be left
        /// empty. Each JWT SHOULD encode a claim specific to the `resource_uri` of this Occurrence, but this is not
        /// validated by Grafeas metadata API implementations. The JWT itself is opaque to Grafeas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwts")]
        public virtual System.Collections.Generic.IList<Jwt> Jwts { get; set; }

        /// <summary>Required. The serialized payload that is verified by one or more `signatures`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializedPayload")]
        public virtual string SerializedPayload { get; set; }

        /// <summary>
        /// One or more signatures over `serialized_payload`. Verifier implementations should consider this attestation
        /// message verified if at least one `signature` verifies `serialized_payload`. See `Signature` in common.proto
        /// for more details on signature structure and verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<Signature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BaseImage describes a base image of a container image.</summary>
    public class BaseImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The number of layers that the base image is composed of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numLayers")]
        public virtual string NumLayers { get; set; }

        /// <summary>The repository name in which the base image is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BinarySourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The binary package. This is significant when the source is different than the binary itself. Historically if
        /// they've differed, we've stored the name of the source and its version in the package/version fields, but we
        /// should also store the binary package info, as that's what's actually installed. See b/175908657#comment15.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryVersion")]
        public virtual PackageVersion BinaryVersion { get; set; }

        /// <summary>
        /// The source package. Similar to the above, this is significant when the source is different than the binary
        /// itself. Since the top-level package/version fields are based on an if/else, we need a separate field for
        /// both binary and source if we want to know definitively where the data is coming from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVersion")]
        public virtual PackageVersion SourceVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BuildDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buildType")]
        public virtual string BuildType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalParameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> ExternalParameters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("internalParameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> InternalParameters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resolvedDependencies")]
        public virtual System.Collections.Generic.IList<ResourceDescriptor> ResolvedDependencies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BuildMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishedOnRaw;

        private object _finishedOn;

        [Newtonsoft.Json.JsonPropertyAttribute("finishedOn")]
        public virtual string FinishedOnRaw
        {
            get => _finishedOnRaw;
            set
            {
                _finishedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishedOnDateTimeOffset instead.")]
        public virtual object FinishedOn
        {
            get => _finishedOn;
            set
            {
                _finishedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishedOn = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishedOnRaw);
            set => FinishedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("invocationId")]
        public virtual string InvocationId { get; set; }

        private string _startedOnRaw;

        private object _startedOn;

        [Newtonsoft.Json.JsonPropertyAttribute("startedOn")]
        public virtual string StartedOnRaw
        {
            get => _startedOnRaw;
            set
            {
                _startedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartedOnDateTimeOffset instead.")]
        public virtual object StartedOn
        {
            get => _startedOn;
            set
            {
                _startedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startedOn = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartedOnRaw);
            set => StartedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a build occurrence.</summary>
    public class BuildOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In-Toto Slsa Provenance V1 represents a slsa provenance meeting the slsa spec, wrapped in an in-toto
        /// statement. This allows for direct jsonification of a to-spec in-toto slsa statement with a to-spec slsa
        /// provenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inTotoSlsaProvenanceV1")]
        public virtual InTotoSlsaProvenanceV1 InTotoSlsaProvenanceV1 { get; set; }

        /// <summary>
        /// Deprecated. See InTotoStatement for the replacement. In-toto Provenance representation as defined in spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intotoProvenance")]
        public virtual InTotoProvenance IntotoProvenance { get; set; }

        /// <summary>
        /// In-toto Statement representation as defined in spec. The intoto_statement can contain any type of
        /// provenance. The serialized payload of the statement can be stored and signed in the Occurrence's envelope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intotoStatement")]
        public virtual InTotoStatement IntotoStatement { get; set; }

        /// <summary>The actual provenance for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual BuildProvenance Provenance { get; set; }

        /// <summary>
        /// Serialized JSON representation of the provenance, used in generating the build signature in the
        /// corresponding build note. After verifying the signature, `provenance_bytes` can be unmarshalled and compared
        /// to the provenance to confirm that it is unchanged. A base64-encoded string representation of the provenance
        /// bytes is used for the signature in order to interoperate with openssl which expects this format for
        /// signature verification. The serialized form is captured both to avoid ambiguity in how the provenance is
        /// marshalled to json as well to prevent incompatibilities with future changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provenanceBytes")]
        public virtual string ProvenanceBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of a build. Contains all information needed to verify the full details about the build from source to
    /// completion.
    /// </summary>
    public class BuildProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Special options applied to this build. This is a catch-all field where build providers can enter any desired
        /// additional details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> BuildOptions { get; set; }

        /// <summary>Version string of the builder at the time this build was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderVersion")]
        public virtual string BuilderVersion { get; set; }

        /// <summary>Output of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtArtifacts")]
        public virtual System.Collections.Generic.IList<Artifact> BuiltArtifacts { get; set; }

        /// <summary>Commands requested by the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<Command> Commands { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time at which the build was created.</summary>
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
        /// E-mail address of the user who initiated this build. Note that this was the user's e-mail address at the
        /// time the build was initiated; this address may not represent the same end-user for all time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Time at which execution of the build was finished.</summary>
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

        /// <summary>Required. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URI where any logs for this provenance were written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsUri")]
        public virtual string LogsUri { get; set; }

        /// <summary>ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Details of the Source input to the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual Source SourceProvenance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time at which execution of the build was started.</summary>
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

        /// <summary>Trigger identifier if the build was triggered automatically; empty if not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BuilderConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Common Vulnerability Scoring System. For details, see https://www.first.org/cvss/specification-document This is
    /// a message we will try to use for storing various versions of CVSS rather than making a separate proto for
    /// storing a specific version.
    /// </summary>
    public class CVSS : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("authentication")]
        public virtual string Authentication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<float> BaseScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exploitabilityScore")]
        public virtual System.Nullable<float> ExploitabilityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impactScore")]
        public virtual System.Nullable<float> ImpactScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The category to which the update belongs.</summary>
    public class Category : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryId")]
        public virtual string CategoryId { get; set; }

        /// <summary>The localized name of the category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A CloudRepoSourceContext denotes a particular revision in a Google Cloud Source Repo.</summary>
    public class CloudRepoSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>The ID of the repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoId")]
        public virtual RepoId RepoId { get; set; }

        /// <summary>A revision ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Command describes a step performed as part of the build pipeline.</summary>
    public class Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Command-line arguments used when executing this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Working directory (relative to project source root) used when running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Environment variables set before running this command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// Optional unique identifier for this command, used in wait_for to reference this command as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. Name of the command, as presented on the command line, or if the command is packaged as a Docker
        /// container, as presented to `docker pull`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID(s) of the command(s) that this command depends on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates that the builder claims certain fields in this message to be complete.</summary>
    public class Completeness : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the builder claims that recipe.arguments is complete, meaning that all external inputs are properly
        /// captured in the recipe.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Nullable<bool> Arguments { get; set; }

        /// <summary>If true, the builder claims that recipe.environment is claimed to be complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Nullable<bool> Environment { get; set; }

        /// <summary>
        /// If true, the builder claims that materials are complete, usually through some controls to prevent network
        /// access. Sometimes called "hermetic".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Nullable<bool> Materials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An indication that the compliance checks in the associated ComplianceNote were not satisfied for particular
    /// resources or a specified reason.
    /// </summary>
    public class ComplianceOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nonComplianceReason")]
        public virtual string NonComplianceReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nonCompliantFiles")]
        public virtual System.Collections.Generic.IList<NonCompliantFile> NonCompliantFiles { get; set; }

        /// <summary>The OS and config version the benchmark was run on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual ComplianceVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the CIS benchmark version that is applicable to a given OS and os version.</summary>
    public class ComplianceVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the document that defines this benchmark, e.g. "CIS Container-Optimized OS".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benchmarkDocument")]
        public virtual string BenchmarkDocument { get; set; }

        /// <summary>The CPE URI (https://cpe.mitre.org/specification/) this benchmark is applicable to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>
        /// The version of the benchmark. This is set to the version of the OS-specific CIS document the benchmark is
        /// defined in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated. Prefer to use a regular Occurrence, and populate the Envelope at the top level of the Occurrence.
    /// </summary>
    public class DSSEAttestationOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If doing something security critical, make sure to verify the signatures in this metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envelope")]
        public virtual Envelope Envelope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("statement")]
        public virtual InTotoStatement Statement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The period during which some deployable was active in a runtime.</summary>
    public class DeploymentOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Address of the runtime element hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Configuration used to create this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        private string _deployTimeRaw;

        private object _deployTime;

        /// <summary>Required. Beginning of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployTime")]
        public virtual string DeployTimeRaw
        {
            get => _deployTimeRaw;
            set
            {
                _deployTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deployTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeployTimeDateTimeOffset instead.")]
        public virtual object DeployTime
        {
            get => _deployTime;
            set
            {
                _deployTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deployTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeployTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeployTimeRaw);
            set => DeployTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Platform hosting this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// Output only. Resource URI for the artifact being deployed taken from the deployable field with the same
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual System.Collections.Generic.IList<string> ResourceUri { get; set; }

        private string _undeployTimeRaw;

        private object _undeployTime;

        /// <summary>End of the lifetime of this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("undeployTime")]
        public virtual string UndeployTimeRaw
        {
            get => _undeployTimeRaw;
            set
            {
                _undeployTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _undeployTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UndeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UndeployTimeDateTimeOffset instead.")]
        public virtual object UndeployTime
        {
            get => _undeployTime;
            set
            {
                _undeployTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _undeployTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UndeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UndeployTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UndeployTimeRaw);
            set => UndeployTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Identity of the user that triggered this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides information about the analysis status of a discovered resource.</summary>
    public class DiscoveryOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("analysisCompleted")]
        public virtual AnalysisCompleted AnalysisCompleted { get; set; }

        /// <summary>
        /// Indicates any errors encountered during analysis of a resource. There could be 0 or more of these errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisError")]
        public virtual System.Collections.Generic.IList<Status> AnalysisError { get; set; }

        /// <summary>The status of discovery for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatus")]
        public virtual string AnalysisStatus { get; set; }

        /// <summary>
        /// When an error is encountered this will contain a LocalizedMessage under details to show to the user. The
        /// LocalizedMessage is output only and populated by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisStatusError")]
        public virtual Status AnalysisStatusError { get; set; }

        private string _archiveTimeRaw;

        private object _archiveTime;

        /// <summary>Output only. The time occurrences related to this discovery occurrence were archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveTime")]
        public virtual string ArchiveTimeRaw
        {
            get => _archiveTimeRaw;
            set
            {
                _archiveTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _archiveTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ArchiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ArchiveTimeDateTimeOffset instead.")]
        public virtual object ArchiveTime
        {
            get => _archiveTime;
            set
            {
                _archiveTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _archiveTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ArchiveTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ArchiveTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ArchiveTimeRaw);
            set => ArchiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Whether the resource is continuously analyzed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousAnalysis")]
        public virtual string ContinuousAnalysis { get; set; }

        /// <summary>The CPE of the resource being scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpe")]
        public virtual string Cpe { get; set; }

        private string _lastScanTimeRaw;

        private object _lastScanTime;

        /// <summary>The last time this resource was scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastScanTime")]
        public virtual string LastScanTimeRaw
        {
            get => _lastScanTimeRaw;
            set
            {
                _lastScanTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastScanTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastScanTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastScanTimeDateTimeOffset instead.")]
        public virtual object LastScanTime
        {
            get => _lastScanTime;
            set
            {
                _lastScanTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastScanTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastScanTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastScanTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastScanTimeRaw);
            set => LastScanTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The status of an SBOM generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sbomStatus")]
        public virtual SBOMStatus SbomStatus { get; set; }

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
    /// MUST match https://github.com/secure-systems-lab/dsse/blob/master/envelope.proto. An authenticated message of
    /// arbitrary type.
    /// </summary>
    public class Envelope : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("payloadType")]
        public virtual string PayloadType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<EnvelopeSignature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnvelopeSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("keyid")]
        public virtual string Keyid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sig")]
        public virtual string Sig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container message for hashes of byte content of files, used in source messages to verify integrity of source
    /// input to the build.
    /// </summary>
    public class FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates the location at which a package was found.</summary>
    public class FileLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For jars that are contained inside .war files, this filepath can indicate the path to war file combined with
        /// the path to jar file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of properties that uniquely identify a given Docker image.</summary>
    public class Fingerprint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The layer ID of the final layer in the Docker image's v1 representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v1Name")]
        public virtual string V1Name { get; set; }

        /// <summary>Required. The ordered list of v2 blobs that represent a given image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Blob")]
        public virtual System.Collections.Generic.IList<string> V2Blob { get; set; }

        /// <summary>
        /// Output only. The name of the image's v2 blobs computed via: [bottom] := v2_blobbottom := sha256(v2_blob[N] +
        /// " " + v2_name[N+1]) Only the name of the final blob is kept.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("v2Name")]
        public virtual string V2Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SourceContext referring to a Gerrit project.</summary>
    public class GerritSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An alias, which may be a branch or tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliasContext")]
        public virtual AliasContext AliasContext { get; set; }

        /// <summary>
        /// The full project name within the host. Projects may be nested, so "project/subproject" is a valid project
        /// name. The "repo name" is the hostURI/project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerritProject")]
        public virtual string GerritProject { get; set; }

        /// <summary>The URI of a running Gerrit instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>A revision (commit) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A GitSourceContext denotes a particular revision in a third party Git repository (e.g., GitHub).
    /// </summary>
    public class GitSourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Git commit hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Git repository URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates the location at which a package was found.</summary>
    public class GrafeasV1FileLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For jars that are contained inside .war files, this filepath can indicate the path to war file combined with
        /// the path to jar file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual string FilePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies the entity that executed the recipe, which is trusted to have correctly performed the operation and
    /// populated this provenance.
    /// </summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaBuilder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates that the builder claims certain fields in this message to be complete.</summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaCompleteness : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Nullable<bool> Environment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Nullable<bool> Materials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Nullable<bool> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes where the config file that kicked off the build came from. This is effectively a pointer to the source
    /// where buildConfig came from.
    /// </summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaConfigSource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("entryPoint")]
        public virtual string EntryPoint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the event that kicked off the build.</summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaInvocation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("configSource")]
        public virtual GrafeasV1SlsaProvenanceZeroTwoSlsaConfigSource ConfigSource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, object> Environment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The collection of artifacts that influenced the build including sources, dependencies, build tools, base images,
    /// and so on.
    /// </summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaMaterial : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Other properties of the build.</summary>
    public class GrafeasV1SlsaProvenanceZeroTwoSlsaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _buildFinishedOnRaw;

        private object _buildFinishedOn;

        [Newtonsoft.Json.JsonPropertyAttribute("buildFinishedOn")]
        public virtual string BuildFinishedOnRaw
        {
            get => _buildFinishedOnRaw;
            set
            {
                _buildFinishedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildFinishedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildFinishedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildFinishedOnDateTimeOffset instead.")]
        public virtual object BuildFinishedOn
        {
            get => _buildFinishedOn;
            set
            {
                _buildFinishedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildFinishedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildFinishedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildFinishedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildFinishedOnRaw);
            set => BuildFinishedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("buildInvocationId")]
        public virtual string BuildInvocationId { get; set; }

        private string _buildStartedOnRaw;

        private object _buildStartedOn;

        [Newtonsoft.Json.JsonPropertyAttribute("buildStartedOn")]
        public virtual string BuildStartedOnRaw
        {
            get => _buildStartedOnRaw;
            set
            {
                _buildStartedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildStartedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildStartedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildStartedOnDateTimeOffset instead.")]
        public virtual object BuildStartedOn
        {
            get => _buildStartedOn;
            set
            {
                _buildStartedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildStartedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildStartedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildStartedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildStartedOnRaw);
            set => BuildStartedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("completeness")]
        public virtual GrafeasV1SlsaProvenanceZeroTwoSlsaCompleteness Completeness { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reproducible")]
        public virtual System.Nullable<bool> Reproducible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of hash that was performed, e.g. "SHA-256".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The unique identifier of the update.</summary>
    public class Identity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The revision number of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>The revision independent identifier of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateId")]
        public virtual string UpdateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the derived image portion of the DockerImage relationship. This image would be produced from a
    /// Dockerfile with FROM .
    /// </summary>
    public class ImageOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This contains the base image URL for the derived image occurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseResourceUrl")]
        public virtual string BaseResourceUrl { get; set; }

        /// <summary>
        /// Output only. The number of layers by which this image differs from the associated image basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual System.Nullable<int> Distance { get; set; }

        /// <summary>Required. The fingerprint of the derived image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual Fingerprint Fingerprint { get; set; }

        /// <summary>
        /// This contains layer-specific metadata, if populated it has length "distance" and is ordered with [distance]
        /// being the layer immediately following the base image and [1] being the final layer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layerInfo")]
        public virtual System.Collections.Generic.IList<Layer> LayerInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InTotoProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builderConfig")]
        public virtual BuilderConfig BuilderConfig { get; set; }

        /// <summary>
        /// The collection of artifacts that influenced the build including sources, dependencies, build tools, base
        /// images, and so on. This is considered to be incomplete unless metadata.completeness.materials is true. Unset
        /// or null is equivalent to empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<string> Materials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual Metadata Metadata { get; set; }

        /// <summary>
        /// Identifies the configuration used for the build. When combined with materials, this SHOULD fully describe
        /// the build, such that re-running this recipe results in bit-for-bit identical output (if the build is
        /// reproducible). required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipe")]
        public virtual Recipe Recipe { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InTotoSlsaProvenanceV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>InToto spec defined at https://github.com/in-toto/attestation/tree/main/spec#statement</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("_type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual SlsaProvenanceV1 Predicate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("predicateType")]
        public virtual string PredicateType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual System.Collections.Generic.IList<Subject> Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Spec defined at https://github.com/in-toto/attestation/tree/main/spec#statement The serialized InTotoStatement
    /// will be stored as Envelope.payload. Envelope.payloadType is always "application/vnd.in-toto+json".
    /// </summary>
    public class InTotoStatement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always `https://in-toto.io/Statement/v0.1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("_type")]
        public virtual string Type { get; set; }

        /// <summary>`https://slsa.dev/provenance/v0.1` for SlsaProvenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicateType")]
        public virtual string PredicateType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("provenance")]
        public virtual InTotoProvenance Provenance { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("slsaProvenance")]
        public virtual SlsaProvenance SlsaProvenance { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("slsaProvenanceZeroTwo")]
        public virtual SlsaProvenanceZeroTwo SlsaProvenanceZeroTwo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual System.Collections.Generic.IList<Subject> Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Justification provides the justification when the state of the assessment if NOT_AFFECTED.</summary>
    public class Justification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional details on why this justification was chosen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The justification type for this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justificationType")]
        public virtual string JustificationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Jwt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The compact encoding of a JWS, which is always three base64 encoded strings joined by periods. For details,
        /// see: https://tools.ietf.org/html/rfc7515.html#section-3.1
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compactJwt")]
        public virtual string CompactJwt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates a language package available between this package and the customer's resource artifact.
    /// </summary>
    public class LanguagePackageDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Layer holds metadata specific to a layer of a Docker image.</summary>
    public class Layer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The recovered arguments to the Dockerfile directive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual string Arguments { get; set; }

        /// <summary>
        /// Required. The recovered Dockerfile directive used to construct this layer. See
        /// https://docs.docker.com/engine/reference/builder/ for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directive")]
        public virtual string Directive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about the layer a package was found in. This should be the same as the LayerDetails message in
    /// google3/third_party/scalibr/binary/proto/scan_result.proto.
    /// </summary>
    public class LayerDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base images the layer is found within.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImages")]
        public virtual System.Collections.Generic.IList<BaseImage> BaseImages { get; set; }

        /// <summary>
        /// The layer build command that was used to build the layer. This may not be found in all layers depending on
        /// how the container image is built.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>The diff ID (sha256 hash) of the layer in the container image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffId")]
        public virtual string DiffId { get; set; }

        /// <summary>The index of the layer in the container image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>License information.</summary>
    public class License : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Comments</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual string Comments { get; set; }

        /// <summary>
        /// Often a single license can be used to represent the licensing terms. Sometimes it is necessary to include a
        /// choice of one or more licenses or some combination of license identifiers. Examples: "LGPL-2.1-only OR MIT",
        /// "LGPL-2.1-only AND MIT", "GPL-2.0-or-later WITH Bison-exception-2.2".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

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

    /// <summary>ListVulnerabilitiesResponse contains a single page of vulnerabilities resulting from a scan.</summary>
    public class ListVulnerabilitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A page token that can be used in a subsequent call to ListVulnerabilities to continue retrieving results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of Vulnerability Occurrences resulting from a scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrences")]
        public virtual System.Collections.Generic.IList<Occurrence> Occurrences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An occurrence of a particular package installation found within a system's filesystem. E.g., glibc was found in
    /// `/var/lib/dpkg/status`.
    /// </summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated. The CPE URI in [CPE format](https://cpe.mitre.org/specification/)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The path from which we gathered that this package/version is installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Deprecated. The version installed at this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Maintainer : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Material : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Other properties of the build.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _buildFinishedOnRaw;

        private object _buildFinishedOn;

        /// <summary>The timestamp of when the build completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildFinishedOn")]
        public virtual string BuildFinishedOnRaw
        {
            get => _buildFinishedOnRaw;
            set
            {
                _buildFinishedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildFinishedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildFinishedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildFinishedOnDateTimeOffset instead.")]
        public virtual object BuildFinishedOn
        {
            get => _buildFinishedOn;
            set
            {
                _buildFinishedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildFinishedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildFinishedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildFinishedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildFinishedOnRaw);
            set => BuildFinishedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifies the particular build invocation, which can be useful for finding associated logs or other ad-hoc
        /// analysis. The value SHOULD be globally unique, per in-toto Provenance spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildInvocationId")]
        public virtual string BuildInvocationId { get; set; }

        private string _buildStartedOnRaw;

        private object _buildStartedOn;

        /// <summary>The timestamp of when the build started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStartedOn")]
        public virtual string BuildStartedOnRaw
        {
            get => _buildStartedOnRaw;
            set
            {
                _buildStartedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildStartedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildStartedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildStartedOnDateTimeOffset instead.")]
        public virtual object BuildStartedOn
        {
            get => _buildStartedOn;
            set
            {
                _buildStartedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildStartedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildStartedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildStartedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildStartedOnRaw);
            set => BuildStartedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Indicates that the builder claims certain fields in this message to be complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeness")]
        public virtual Completeness Completeness { get; set; }

        /// <summary>
        /// If true, the builder claims that running the recipe on materials will produce bit-for-bit identical output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reproducible")]
        public virtual System.Nullable<bool> Reproducible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about files that caused a compliance check to fail. display_command is a single command that can be used
    /// to display a list of non compliant files. When there is no such command, we can also iterate a list of non
    /// compliant file using 'path'.
    /// </summary>
    public class NonCompliantFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Command to display the non-compliant files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayCommand")]
        public virtual string DisplayCommand { get; set; }

        /// <summary>Empty if `display_command` is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Explains why a file is non compliant for a CIS check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instance of an analysis type that has been found on a resource.</summary>
    public class Occurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes an attestation of an artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual AttestationOccurrence Attestation { get; set; }

        /// <summary>Describes a verifiable build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual BuildOccurrence Build { get; set; }

        /// <summary>Describes a compliance violation on a linked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliance")]
        public virtual ComplianceOccurrence Compliance { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time this occurrence was created.</summary>
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

        /// <summary>Describes the deployment of an artifact on a runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual DeploymentOccurrence Deployment { get; set; }

        /// <summary>Describes when a resource was discovered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discovery")]
        public virtual DiscoveryOccurrence Discovery { get; set; }

        /// <summary>Describes an attestation of an artifact using dsse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsseAttestation")]
        public virtual DSSEAttestationOccurrence DsseAttestation { get; set; }

        /// <summary>https://github.com/secure-systems-lab/dsse</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envelope")]
        public virtual Envelope Envelope { get; set; }

        /// <summary>Describes how this resource derives from the basis in the associated note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageOccurrence Image { get; set; }

        /// <summary>
        /// Output only. This explicitly denotes which of the occurrence details are specified. This field can be used
        /// as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. The name of the occurrence in the form of `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The analysis note associated with this occurrence, in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`. This field can be used as a filter in list requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteName")]
        public virtual string NoteName { get; set; }

        /// <summary>Describes the installation of a package on the linked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual PackageOccurrence Package { get; set; }

        /// <summary>A description of actions that can be taken to remedy the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>
        /// Required. Immutable. A URI that represents the resource for which the occurrence applies. For example,
        /// `https://gcr.io/project/image@sha256:123abc` for a Docker image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>Describes a specific SBOM reference occurrences.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sbomReference")]
        public virtual SBOMReferenceOccurrence SbomReference { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time this occurrence was last updated.</summary>
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

        /// <summary>Describes an available package upgrade on the linked resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgrade")]
        public virtual UpgradeOccurrence Upgrade { get; set; }

        /// <summary>Describes a security vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual VulnerabilityOccurrence Vulnerability { get; set; }

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

    public class PackageData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The architecture of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>A bundle containing the binary and source information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binarySourceInfo")]
        public virtual System.Collections.Generic.IList<BinarySourceInfo> BinarySourceInfo { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryVersion")]
        public virtual PackageVersion BinaryVersion { get; set; }

        /// <summary>
        /// The cpe_uri in [cpe format] (https://cpe.mitre.org/specification/) in which the vulnerability may manifest.
        /// Examples include distro or storage location for vulnerable jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>
        /// The dependency chain between this package and the user's artifact. List in order from the customer's package
        /// under review first, to the current package last. Inclusive of the original package and the current package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencyChain")]
        public virtual System.Collections.Generic.IList<LanguagePackageDependency> DependencyChain { get; set; }

        /// <summary>The path to the jar file / go binary file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileLocation")]
        public virtual System.Collections.Generic.IList<FileLocation> FileLocation { get; set; }

        /// <summary>
        /// HashDigest stores the SHA512 hash digest of the jar file if the package is of type Maven. This field will be
        /// unset for non Maven packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashDigest")]
        public virtual string HashDigest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("layerDetails")]
        public virtual LayerDetails LayerDetails { get; set; }

        /// <summary>
        /// The list of licenses found that are related to a given package. Note that licenses may also be stored on the
        /// BinarySourceInfo. If there is no BinarySourceInfo (because there's no concept of source vs binary), then it
        /// will be stored here, while if there are BinarySourceInfos, it will be stored there, as one source can have
        /// multiple binaries with different licenses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        /// <summary>The maintainer of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintainer")]
        public virtual Maintainer Maintainer { get; set; }

        /// <summary>The OS affected by a vulnerability Used to generate the cpe_uri for OS packages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("os")]
        public virtual string Os { get; set; }

        /// <summary>The version of the OS Used to generate the cpe_uri for OS packages</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The package being analysed for vulnerabilities</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>The type of package: os, maven, go, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>CVEs that this package is no longer vulnerable to go/drydock-dd-custom-binary-scanning</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchedCve")]
        public virtual System.Collections.Generic.IList<string> PatchedCve { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVersion")]
        public virtual PackageVersion SourceVersion { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unused")]
        public virtual string Unused { get; set; }

        /// <summary>The version of the package being analysed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A detail for a distro and package this vulnerability occurrence was found in and its associated fix (if one is
    /// available).
    /// </summary>
    public class PackageIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [CPE URI](https://cpe.mitre.org/specification/) this vulnerability was found in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedCpeUri")]
        public virtual string AffectedCpeUri { get; set; }

        /// <summary>Required. The package this vulnerability was found in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedPackage")]
        public virtual string AffectedPackage { get; set; }

        /// <summary>
        /// Required. The version of the package that is installed on the resource affected by this vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedVersion")]
        public virtual Version AffectedVersion { get; set; }

        /// <summary>
        /// Output only. The distro or language system assigned severity for this vulnerability when that is available
        /// and note provider assigned severity when it is not available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSeverity")]
        public virtual string EffectiveSeverity { get; set; }

        /// <summary>The location at which this package was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileLocation")]
        public virtual System.Collections.Generic.IList<GrafeasV1FileLocation> FileLocation { get; set; }

        /// <summary>Output only. Whether a fix is available for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixAvailable")]
        public virtual System.Nullable<bool> FixAvailable { get; set; }

        /// <summary>
        /// The [CPE URI](https://cpe.mitre.org/specification/) this vulnerability was fixed in. It is possible for this
        /// to be different from the affected_cpe_uri.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedCpeUri")]
        public virtual string FixedCpeUri { get; set; }

        /// <summary>
        /// The package this vulnerability was fixed in. It is possible for this to be different from the
        /// affected_package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPackage")]
        public virtual string FixedPackage { get; set; }

        /// <summary>
        /// Required. The version of the package this vulnerability was fixed in. Setting this to VersionKind.MAXIMUM
        /// means no fix is yet available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedVersion")]
        public virtual Version FixedVersion { get; set; }

        /// <summary>The type of package (e.g. OS, MAVEN, GO).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details on how a particular software package was installed on a system.</summary>
    public class PackageOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The CPU architecture for which packages in this distribution channel were built. Architecture
        /// will be blank for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// Output only. The cpe_uri in [CPE format](https://cpe.mitre.org/specification/) denoting the package manager
        /// version distributing a package. The cpe_uri will be blank for language packages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>Licenses that have been declared by the authors of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("license")]
        public virtual License License { get; set; }

        /// <summary>All of the places within the filesystem versions of this package have been found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual System.Collections.Generic.IList<Location> Location { get; set; }

        /// <summary>Required. Output only. The name of the installed package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The type of package; whether native or non native (e.g., ruby gems, node.js packages, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>Output only. The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PackageVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The licenses associated with this package. Note that this has to go on the PackageVersion level, because we
        /// can have cases with images with the same source having different licences. E.g. in Alpine, musl and
        /// musl-utils both have the same origin musl, but have different sets of licenses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenses")]
        public virtual System.Collections.Generic.IList<string> Licenses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selects a repo using a Google Cloud Platform project ID (e.g., winged-cargo-31) and a repo name within that
    /// project.
    /// </summary>
    public class ProjectRepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of the repo. Leave empty for the default repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProvenanceBuilder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("builderDependencies")]
        public virtual System.Collections.Generic.IList<ResourceDescriptor> BuilderDependencies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Collections.Generic.IDictionary<string, string> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Steps taken to build the artifact. For a TaskRun, typically each container corresponds to one step in the
    /// recipe.
    /// </summary>
    public class Recipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Collection of all external inputs that influenced the build on top of recipe.definedInMaterial and
        /// recipe.entryPoint. For example, if the recipe type were "make", then this might be the flags passed to make
        /// aside from the target, which is captured in recipe.entryPoint. Since the arguments field can greatly vary in
        /// structure, depending on the builder and recipe type, this is of form "Any".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Arguments { get; set; }

        /// <summary>
        /// Index in materials containing the recipe steps that are not implied by recipe.type. For example, if the
        /// recipe type were "make", then this would point to the source containing the Makefile, not the make program
        /// itself. Set to -1 if the recipe doesn't come from a material, as zero is default unset value for int64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definedInMaterial")]
        public virtual System.Nullable<long> DefinedInMaterial { get; set; }

        /// <summary>
        /// String identifying the entry point into the build. This is often a path to a configuration file and/or a
        /// target label within that file. The syntax and meaning are defined by recipe.type. For example, if the recipe
        /// type were "make", then this would reference the directory in which to run make as well as which target to
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPoint")]
        public virtual string EntryPoint { get; set; }

        /// <summary>
        /// Any other builder-controlled inputs necessary for correctly evaluating the recipe. Usually only needed for
        /// reproducing the build but not evaluated as part of policy. Since the environment field can greatly vary in
        /// structure, depending on the builder and recipe type, this is of form "Any".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Environment { get; set; }

        /// <summary>
        /// URI indicating what type of recipe was performed. It determines the meaning of recipe.entryPoint,
        /// recipe.arguments, recipe.environment, and materials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for any related URL information.</summary>
    public class RelatedUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label to describe usage of the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Specific URL associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies details on how to handle (and presumably, fix) a vulnerability.</summary>
    public class Remediation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains a comprehensive human-readable discussion of the remediation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The type of remediation that can be applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediationType")]
        public virtual string RemediationType { get; set; }

        /// <summary>Contains the URL where to obtain the remediation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediationUri")]
        public virtual RelatedUrl RemediationUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unique identifier for a Cloud Repo.</summary>
    public class RepoId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A combination of a project ID and a repo name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectRepoId")]
        public virtual ProjectRepoId ProjectRepoId { get; set; }

        /// <summary>A server-assigned, globally unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResourceDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, object> Annotations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("downloadLocation")]
        public virtual string DownloadLocation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediaType")]
        public virtual string MediaType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RunDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("builder")]
        public virtual ProvenanceBuilder Builder { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("byproducts")]
        public virtual System.Collections.Generic.IList<ResourceDescriptor> Byproducts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual BuildMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The occurrence representing an SBOM reference as applied to a specific resource. The occurrence follows the DSSE
    /// specification. See https://github.com/secure-systems-lab/dsse/blob/master/envelope.md for more details.
    /// </summary>
    public class SBOMReferenceOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actual payload that contains the SBOM reference data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual SbomReferenceIntotoPayload Payload { get; set; }

        /// <summary>
        /// The kind of payload that SbomReferenceIntotoPayload takes. Since it's in the intoto format, this value is
        /// expected to be 'application/vnd.in-toto+json'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadType")]
        public virtual string PayloadType { get; set; }

        /// <summary>The signatures over the payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<EnvelopeSignature> Signatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of an SBOM generation.</summary>
    public class SBOMStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If there was an error generating an SBOM, this will indicate what that error was.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>The progress of the SBOM generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sbomState")]
        public virtual string SbomState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The actual payload that contains the SBOM Reference data. The payload follows the intoto statement
    /// specification. See https://github.com/in-toto/attestation/blob/main/spec/v1.0/statement.md for more details.
    /// </summary>
    public class SbomReferenceIntotoPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier for the schema of the Statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("_type")]
        public virtual string Type { get; set; }

        /// <summary>Additional parameters of the Predicate. Includes the actual data about the SBOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual SbomReferenceIntotoPredicate Predicate { get; set; }

        /// <summary>URI identifying the type of the Predicate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicateType")]
        public virtual string PredicateType { get; set; }

        /// <summary>
        /// Set of software artifacts that the attestation applies to. Each element represents a single software
        /// artifact.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual System.Collections.Generic.IList<Subject> Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A predicate which describes the SBOM being referenced.</summary>
    public class SbomReferenceIntotoPredicate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A map of algorithm to digest of the contents of the SBOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        /// <summary>The location of the SBOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The mime type of the SBOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The person or system referring this predicate to the consumer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrerId")]
        public virtual string ReferrerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Verifiers (e.g. Kritis implementations) MUST verify signatures with respect to the trust anchors defined in
    /// policy (e.g. a Kritis policy). Typically this means that the verifier has been configured with a map from
    /// `public_key_id` to public key material (and any required parameters, e.g. signing algorithm). In particular,
    /// verification implementations MUST NOT treat the signature `public_key_id` as anything more than a key lookup
    /// hint. The `public_key_id` DOES NOT validate or authenticate a public key; it only provides a mechanism for
    /// quickly selecting a public key ALREADY CONFIGURED on the verifier through a trusted channel. Verification
    /// implementations MUST reject signatures in any of the following circumstances: * The `public_key_id` is not
    /// recognized by the verifier. * The public key that `public_key_id` refers to does not verify the signature with
    /// respect to the payload. The `signature` contents SHOULD NOT be "attached" (where the payload is included with
    /// the serialized `signature` bytes). Verifiers MUST ignore any "attached" payload and only verify signatures with
    /// respect to explicitly provided payload (e.g. a `payload` field on the proto message that holds this Signature,
    /// or the canonical serialization of the proto message that holds this signature).
    /// </summary>
    public class Signature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier for the public key that verifies this signature. * The `public_key_id` is required. * The
        /// `public_key_id` SHOULD be an RFC3986 conformant URI. * When possible, the `public_key_id` SHOULD be an
        /// immutable reference, such as a cryptographic digest. Examples of valid `public_key_id`s: OpenPGP V4 public
        /// key fingerprint: * "openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA" See
        /// https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr for more details on this scheme. RFC6920
        /// digest-named SubjectPublicKeyInfo (digest of the DER serialization): *
        /// "ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU" *
        /// "nih:///sha-256;703f68f42aba2c6de30f488a5ea122fef76324679c9bf89791ba95a1271589a5"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyId")]
        public virtual string PublicKeyId { get; set; }

        /// <summary>
        /// The content of the signature, an opaque bytestring. The payload that this signature verifies MUST be
        /// unambiguously provided with the Signature during verification. A wrapper message might provide the payload
        /// explicitly. Alternatively, a message might have a canonical serialization that can always be unambiguously
        /// computed to derive the payload.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string SignatureValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SlsaBuilder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates that the builder claims certain fields in this message to be complete.</summary>
    public class SlsaCompleteness : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the builder claims that recipe.arguments is complete, meaning that all external inputs are properly
        /// captured in the recipe.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Nullable<bool> Arguments { get; set; }

        /// <summary>If true, the builder claims that recipe.environment is claimed to be complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Nullable<bool> Environment { get; set; }

        /// <summary>
        /// If true, the builder claims that materials are complete, usually through some controls to prevent network
        /// access. Sometimes called "hermetic".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Nullable<bool> Materials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Other properties of the build.</summary>
    public class SlsaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _buildFinishedOnRaw;

        private object _buildFinishedOn;

        /// <summary>The timestamp of when the build completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildFinishedOn")]
        public virtual string BuildFinishedOnRaw
        {
            get => _buildFinishedOnRaw;
            set
            {
                _buildFinishedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildFinishedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildFinishedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildFinishedOnDateTimeOffset instead.")]
        public virtual object BuildFinishedOn
        {
            get => _buildFinishedOn;
            set
            {
                _buildFinishedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildFinishedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildFinishedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildFinishedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildFinishedOnRaw);
            set => BuildFinishedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifies the particular build invocation, which can be useful for finding associated logs or other ad-hoc
        /// analysis. The value SHOULD be globally unique, per in-toto Provenance spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildInvocationId")]
        public virtual string BuildInvocationId { get; set; }

        private string _buildStartedOnRaw;

        private object _buildStartedOn;

        /// <summary>The timestamp of when the build started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStartedOn")]
        public virtual string BuildStartedOnRaw
        {
            get => _buildStartedOnRaw;
            set
            {
                _buildStartedOn = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _buildStartedOnRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BuildStartedOnRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BuildStartedOnDateTimeOffset instead.")]
        public virtual object BuildStartedOn
        {
            get => _buildStartedOn;
            set
            {
                _buildStartedOnRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _buildStartedOn = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BuildStartedOnRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BuildStartedOnDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BuildStartedOnRaw);
            set => BuildStartedOnRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Indicates that the builder claims certain fields in this message to be complete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeness")]
        public virtual SlsaCompleteness Completeness { get; set; }

        /// <summary>
        /// If true, the builder claims that running the recipe on materials will produce bit-for-bit identical output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reproducible")]
        public virtual System.Nullable<bool> Reproducible { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SlsaProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builder")]
        public virtual SlsaBuilder Builder { get; set; }

        /// <summary>
        /// The collection of artifacts that influenced the build including sources, dependencies, build tools, base
        /// images, and so on. This is considered to be incomplete unless metadata.completeness.materials is true. Unset
        /// or null is equivalent to empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<Material> Materials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual SlsaMetadata Metadata { get; set; }

        /// <summary>
        /// Identifies the configuration used for the build. When combined with materials, this SHOULD fully describe
        /// the build, such that re-running this recipe results in bit-for-bit identical output (if the build is
        /// reproducible). required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipe")]
        public virtual SlsaRecipe Recipe { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Keep in sync with schema at
    /// https://github.com/slsa-framework/slsa/blob/main/docs/provenance/schema/v1/provenance.proto Builder renamed to
    /// ProvenanceBuilder because of Java conflicts.
    /// </summary>
    public class SlsaProvenanceV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buildDefinition")]
        public virtual BuildDefinition BuildDefinition { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("runDetails")]
        public virtual RunDetails RunDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>See full explanation of fields at slsa.dev/provenance/v0.2.</summary>
    public class SlsaProvenanceZeroTwo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buildConfig")]
        public virtual System.Collections.Generic.IDictionary<string, object> BuildConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("buildType")]
        public virtual string BuildType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("builder")]
        public virtual GrafeasV1SlsaProvenanceZeroTwoSlsaBuilder Builder { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("invocation")]
        public virtual GrafeasV1SlsaProvenanceZeroTwoSlsaInvocation Invocation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<GrafeasV1SlsaProvenanceZeroTwoSlsaMaterial> Materials { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GrafeasV1SlsaProvenanceZeroTwoSlsaMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Steps taken to build the artifact. For a TaskRun, typically each container corresponds to one step in the
    /// recipe.
    /// </summary>
    public class SlsaRecipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Collection of all external inputs that influenced the build on top of recipe.definedInMaterial and
        /// recipe.entryPoint. For example, if the recipe type were "make", then this might be the flags passed to make
        /// aside from the target, which is captured in recipe.entryPoint. Depending on the recipe Type, the structure
        /// may be different.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arguments")]
        public virtual System.Collections.Generic.IDictionary<string, object> Arguments { get; set; }

        /// <summary>
        /// Index in materials containing the recipe steps that are not implied by recipe.type. For example, if the
        /// recipe type were "make", then this would point to the source containing the Makefile, not the make program
        /// itself. Set to -1 if the recipe doesn't come from a material, as zero is default unset value for int64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definedInMaterial")]
        public virtual System.Nullable<long> DefinedInMaterial { get; set; }

        /// <summary>
        /// String identifying the entry point into the build. This is often a path to a configuration file and/or a
        /// target label within that file. The syntax and meaning are defined by recipe.type. For example, if the recipe
        /// type were "make", then this would reference the directory in which to run make as well as which target to
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPoint")]
        public virtual string EntryPoint { get; set; }

        /// <summary>
        /// Any other builder-controlled inputs necessary for correctly evaluating the recipe. Usually only needed for
        /// reproducing the build but not evaluated as part of policy. Depending on the recipe Type, the structure may
        /// be different.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, object> Environment { get; set; }

        /// <summary>
        /// URI indicating what type of recipe was performed. It determines the meaning of recipe.entryPoint,
        /// recipe.arguments, recipe.environment, and materials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source describes the location of the source used for the build.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If provided, some of the source code used for the build may be found in these locations, in the case where
        /// the source repository had multiple remotes or submodules. This list will not include the context specified
        /// in the context field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalContexts")]
        public virtual System.Collections.Generic.IList<SourceContext> AdditionalContexts { get; set; }

        /// <summary>If provided, the input binary artifacts for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactStorageSourceUri")]
        public virtual string ArtifactStorageSourceUri { get; set; }

        /// <summary>If provided, the source code used for the build came from this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual SourceContext Context { get; set; }

        /// <summary>
        /// Hash(es) of the build source, which can be used to verify that the original source integrity was maintained
        /// in the build. The keys to this map are file paths used as build source and the values contain the hash
        /// values for those files. If the build source came in a single package such as a gzipped tarfile (.tar.gz),
        /// the FileHash will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, FileHashes> FileHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SourceContext is a reference to a tree of files. A SourceContext together with a path point to a unique
    /// revision of a single file or directory.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A SourceContext referring to a revision in a Google Cloud Source Repo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRepo")]
        public virtual CloudRepoSourceContext CloudRepo { get; set; }

        /// <summary>A SourceContext referring to a Gerrit project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gerrit")]
        public virtual GerritSourceContext Gerrit { get; set; }

        /// <summary>A SourceContext referring to any third party Git repo (e.g., GitHub).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("git")]
        public virtual GitSourceContext Git { get; set; }

        /// <summary>Labels with user defined metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

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

    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// `"": ""` Algorithms can be e.g. sha256, sha512 See
        /// https://github.com/in-toto/attestation/blob/main/spec/field_types.md#DigestSet
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual System.Collections.Generic.IDictionary<string, string> Digest { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Upgrade Distribution represents metadata about the Upgrade for each operating system (CPE). Some
    /// distributions have additional metadata around updates, classifying them into various categories and severities.
    /// </summary>
    public class UpgradeDistribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The operating system classification of this Upgrade, as specified by the upstream operating system upgrade
        /// feed. For Windows the classification is one of the category_ids listed at
        /// https://docs.microsoft.com/en-us/previous-versions/windows/desktop/ff357803(v=vs.85)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual string Classification { get; set; }

        /// <summary>
        /// Required - The specific operating system this metadata applies to. See https://cpe.mitre.org/specification/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The cve tied to this Upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual System.Collections.Generic.IList<string> Cve { get; set; }

        /// <summary>The severity as specified by the upstream operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Upgrade Occurrence represents that a specific resource_url could install a specific upgrade. This presence is
    /// supplied via local sources (i.e. it is present in the mirror and the running system has noticed its
    /// availability). For Windows, both distribution and windows_update contain information for the Windows update.
    /// </summary>
    public class UpgradeOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metadata about the upgrade for available for the specific operating system for the resource_url. This allows
        /// efficient filtering, as well as making it easier to use the occurrence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual UpgradeDistribution Distribution { get; set; }

        /// <summary>Required for non-Windows OS. The package this Upgrade is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("package")]
        public virtual string Package { get; set; }

        /// <summary>
        /// Required for non-Windows OS. The version of the package in a machine + human readable form.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parsedVersion")]
        public virtual Version ParsedVersion { get; set; }

        /// <summary>Required for Windows OS. Represents the metadata about the Windows update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsUpdate")]
        public virtual WindowsUpdate WindowsUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version contains structured information about the version of a package.</summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epoch")]
        public virtual System.Nullable<int> Epoch { get; set; }

        /// <summary>
        /// Human readable version string. This string is of the form :- and is only set when kind is NORMAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>
        /// Whether this version is specifying part of an inclusive range. Grafeas does not have the capability to
        /// specify version ranges; instead we have fields that specify start version and end versions. At times this is
        /// insufficient - we also need to specify whether the version is included in the range or is excluded from the
        /// range. This boolean is expected to be set to true when the version is included in a range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusive")]
        public virtual System.Nullable<bool> Inclusive { get; set; }

        /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The iteration of the package build from the above version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VexAssessment provides all publisher provided Vex information that is related to this vulnerability.
    /// </summary>
    public class VexAssessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Holds the MITRE standard Common Vulnerabilities and Exposures (CVE) tracking number for the vulnerability.
        /// Deprecated: Use vulnerability_id instead to denote CVEs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual string Cve { get; set; }

        /// <summary>Contains information about the impact of this vulnerability, this will change with time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impacts")]
        public virtual System.Collections.Generic.IList<string> Impacts { get; set; }

        /// <summary>
        /// Justification provides the justification when the state of the assessment if NOT_AFFECTED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual Justification Justification { get; set; }

        /// <summary>
        /// The VulnerabilityAssessment note from which this VexAssessment was generated. This will be of the form:
        /// `projects/[PROJECT_ID]/notes/[NOTE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noteName")]
        public virtual string NoteName { get; set; }

        /// <summary>Holds a list of references associated with this vulnerability item and assessment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUris")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUris { get; set; }

        /// <summary>Specifies details on how to handle (and presumably, fix) a vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediations")]
        public virtual System.Collections.Generic.IList<Remediation> Remediations { get; set; }

        /// <summary>Provides the state of this Vulnerability assessment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The vulnerability identifier for this Assessment. Will hold one of common identifiers e.g. CVE, GHSA etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityId")]
        public virtual string VulnerabilityId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An occurrence of a severity vulnerability on a resource.</summary>
    public class VulnerabilityOccurrence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The CVSS score of this vulnerability. CVSS score is on a scale of 0 - 10 where 0 indicates low
        /// severity and 10 indicates high severity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScore")]
        public virtual System.Nullable<float> CvssScore { get; set; }

        /// <summary>The cvss v2 score for the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV2")]
        public virtual CVSS CvssV2 { get; set; }

        /// <summary>Output only. CVSS version used to populate cvss_score and severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssVersion")]
        public virtual string CvssVersion { get; set; }

        /// <summary>The cvss v3 score for the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual CVSS Cvssv3 { get; set; }

        /// <summary>
        /// The distro assigned severity for this vulnerability when it is available, otherwise this is the note
        /// provider assigned severity. When there are multiple PackageIssues for this vulnerability, they can have
        /// different effective severities because some might be provided by the distro while others are provided by the
        /// language ecosystem for a language pack. For this reason, it is advised to use the effective severity on the
        /// PackageIssue level. In the case where multiple PackageIssues have differing effective severities, this field
        /// should be the highest severity for any of the PackageIssues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSeverity")]
        public virtual string EffectiveSeverity { get; set; }

        /// <summary>Occurrence-specific extra details about the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extraDetails")]
        public virtual string ExtraDetails { get; set; }

        /// <summary>Output only. Whether at least one of the affected packages has a fix available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixAvailable")]
        public virtual System.Nullable<bool> FixAvailable { get; set; }

        /// <summary>Output only. A detailed description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDescription")]
        public virtual string LongDescription { get; set; }

        /// <summary>
        /// Required. The set of affected locations and their fixes (if available) within the associated resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageIssue")]
        public virtual System.Collections.Generic.IList<PackageIssue> PackageIssue { get; set; }

        /// <summary>Output only. URLs related to this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedUrls")]
        public virtual System.Collections.Generic.IList<RelatedUrl> RelatedUrls { get; set; }

        /// <summary>Output only. The note provider assigned severity of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. A one sentence description of this vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>
        /// The type of package; whether native or non native (e.g., ruby gems, node.js packages, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("vexAssessment")]
        public virtual VexAssessment VexAssessment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Windows Update represents the metadata about the update for the Windows operating system. The fields in this
    /// message come from the Windows Update API documented at
    /// https://docs.microsoft.com/en-us/windows/win32/api/wuapi/nn-wuapi-iupdate.
    /// </summary>
    public class WindowsUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of categories to which the update belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<Category> Categories { get; set; }

        /// <summary>The localized description of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required - The unique identifier for the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identity")]
        public virtual Identity Identity { get; set; }

        /// <summary>The Microsoft Knowledge Base article IDs that are associated with the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kbArticleIds")]
        public virtual System.Collections.Generic.IList<string> KbArticleIds { get; set; }

        private string _lastPublishedTimestampRaw;

        private object _lastPublishedTimestamp;

        /// <summary>The last published timestamp of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPublishedTimestamp")]
        public virtual string LastPublishedTimestampRaw
        {
            get => _lastPublishedTimestampRaw;
            set
            {
                _lastPublishedTimestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastPublishedTimestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastPublishedTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastPublishedTimestampDateTimeOffset instead.")]
        public virtual object LastPublishedTimestamp
        {
            get => _lastPublishedTimestamp;
            set
            {
                _lastPublishedTimestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastPublishedTimestamp = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastPublishedTimestampRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastPublishedTimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastPublishedTimestampRaw);
            set => LastPublishedTimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The hyperlink to the support information for the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrl")]
        public virtual string SupportUrl { get; set; }

        /// <summary>The localized title of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
