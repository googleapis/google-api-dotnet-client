// Copyright 2026 Google LLC
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

namespace Google.Apis.DeviceRun.v1alpha
{
    /// <summary>The DeviceRun Service.</summary>
    public class DeviceRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeviceRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeviceRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://devicerun.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://devicerun.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "devicerun";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Device Run API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Device Run API.</summary>
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

    /// <summary>A base abstract class for DeviceRun requests.</summary>
    public abstract class DeviceRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeviceRunBaseServiceRequest instance.</summary>
        protected DeviceRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DeviceRun parameter list.</summary>
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
                Devices = new DevicesResource(service);
                Operations = new OperationsResource(service);
                Sessions = new SessionsResource(service);
                SoftwareVersions = new SoftwareVersionsResource(service);
            }

            /// <summary>Gets the Devices resource.</summary>
            public virtual DevicesResource Devices { get; }

            /// <summary>The "devices" collection of methods.</summary>
            public class DevicesResource
            {
                private const string Resource = "devices";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DevicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Returns information about a specific device.</summary>
                /// <param name="name">
                /// Required. The name of the device. Format: `projects/{project}/locations/global/devices/{device}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns information about a specific device.</summary>
                public class GetRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.CatalogDevice>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the device. Format:
                    /// `projects/{project}/locations/global/devices/{device}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/devices/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all devices.</summary>
                /// <param name="parent">
                /// Required. The parent of the collection of devices. Format: `projects/{project}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all devices.</summary>
                public class ListRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.CatalogListDevicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the collection of devices. Format:
                    /// `projects/{project}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An AIP-160 (https://google.aip.dev/160) filter expression restricting which devices
                    /// are returned. An empty filter returns all devices. Filtering is supported over the `Device`
                    /// fields, including nested fields via dot-path. Enum and string values must be double-quoted.
                    /// Examples: * `platform = "ANDROID"` * `platform = "ANDROID" AND os_version = "34"` *
                    /// `hardware_type = "PHYSICAL" AND form_factor = "PHONE"` * `android_details.build_type =
                    /// "userdebug"` * `availability.capacity = "HIGH"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of devices to return. The server may return fewer items than this
                    /// value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDevices` call. Provide this to receive the
                    /// subsequent page. When paginating, all other parameters provided to `ListDevices` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/devices";

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
                public virtual CancelRequest Cancel(Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningCancelOperationRequest body, string name)
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
                public class CancelRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:cancel";

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
                public class DeleteRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.Empty>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                public class GetRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningOperation>
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
                    public override string RestPath => "v1alpha/{+name}";

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
                public class ListRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningListOperationsResponse>
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

                    /// <summary>
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}/operations";

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
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Sessions resource.</summary>
            public virtual SessionsResource Sessions { get; }

            /// <summary>The "sessions" collection of methods.</summary>
            public class SessionsResource
            {
                private const string Resource = "sessions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SessionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Cancels an in-progress automation session. This RPC returns immediately and cancellation proceeds
                /// asynchronously. If the session is already finished, this RPC will have no effect.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the session. Format:
                /// "projects/{project}/locations/{location}/sessions/{session}"
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.DeviceRun.v1alpha.Data.CancelSessionRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Cancels an in-progress automation session. This RPC returns immediately and cancellation proceeds
                /// asynchronously. If the session is already finished, this RPC will have no effect.
                /// </summary>
                public class CancelRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.CancelSessionResponse>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DeviceRun.v1alpha.Data.CancelSessionRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the session. Format:
                    /// "projects/{project}/locations/{location}/sessions/{session}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeviceRun.v1alpha.Data.CancelSessionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sessions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Starts an automation session with the specified configuration. This method returns a long-running
                /// `Operation`, awaiting the completion of all jobs in the session.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this session will be created. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DeviceRun.v1alpha.Data.Session body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Starts an automation session with the specified configuration. This method returns a long-running
                /// `Operation`, awaiting the completion of all jobs in the session.
                /// </summary>
                public class CreateRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeviceRun.v1alpha.Data.Session body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this session will be created. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A unique identifier for this request. This request is only idempotent if a
                    /// `request_id` is provided, i.e. if a request with the same `request_id` is received, then the
                    /// previous result will be returned. The server will guarantee that for at least 60 minutes after
                    /// the first request. The value must be a UUID (e.g., 123e4567-e89b-12d3-a456-426655440000). See
                    /// github.com/google/uuid for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. The ID to use for the session, which will become the final component of the resource
                    /// name. If not provided, the server will generate a value for this field. When provided, this
                    /// value must be between 4 and 63 characters, and match the following regex: ^a-z{2,61}[a-z0-9]$.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("sessionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string SessionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeviceRun.v1alpha.Data.Session Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sessions";

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("sessionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sessionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a session. This RPC returns immediately and deletion proceeds asynchronously. It will cancel
                /// the session at first if it is still running.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the session. Format:
                /// `projects/{project}/locations/{location}/sessions/{session}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a session. This RPC returns immediately and deletion proceeds asynchronously. It will cancel
                /// the session at first if it is still running.
                /// </summary>
                public class DeleteRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the session. Format:
                    /// `projects/{project}/locations/{location}/sessions/{session}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A unique identifier for this request. This request is only idempotent if a
                    /// `request_id` is provided, i.e. if a request with the same `request_id` is received, then the
                    /// previous result will be returned. The server will guarantee that for at least 60 minutes after
                    /// the first request. The value must be a UUID (e.g., 123e4567-e89b-12d3-a456-426655440000). See
                    /// github.com/google/uuid for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sessions/[^/]+$",
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

                /// <summary>Returns information about a previously created automation session.</summary>
                /// <param name="name">
                /// Required. The name of the session. Format:
                /// `projects/{project}/locations/{location}/sessions/{session}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns information about a previously created automation session.</summary>
                public class GetRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.Session>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the session. Format:
                    /// `projects/{project}/locations/{location}/sessions/{session}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The view of the session to return. If not set, the default BASIC view will be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. The view of the session to return. If not set, the default BASIC view will be
                    /// returned.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_UNSPECIFIED")]
                        SESSIONVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Include basic view of the session but not the full contents. Only the
                        /// uid/display_name/status/result of the session and its jobs/executions will be included. This
                        /// is the default value (for GetSession).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_BASIC")]
                        SESSIONVIEWBASIC = 1,

                        /// <summary>Include everything.</summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_FULL")]
                        SESSIONVIEWFULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sessions/[^/]+$",
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
                /// Lists previously created automation sessions. Sessions may still be in-progress, or may have
                /// finished successfully, or unsuccessfully.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent value for ListSessionsRequest The parent of the collection of sessions. Format:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists previously created automation sessions. Sessions may still be in-progress, or may have
                /// finished successfully, or unsuccessfully.
                /// </summary>
                public class ListRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.ListSessionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent value for ListSessionsRequest The parent of the collection of sessions. Format:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The raw filter text to constrain the results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The order to sort results by. Supported values: `name`, `name desc`, `create_time`,
                    /// `create_time desc`. Values must use the snake_case field name; `createTime` is not accepted.
                    /// Ordering by `create_time` is not supported when listing across all locations (`locations/-`). If
                    /// unspecified, results are returned in an unspecified order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of sessions to return. The server may return fewer items than this
                    /// value. If unspecified, at most 500 sessions will be returned. The maximum value is 1000, values
                    /// above will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListSessions` call. Provide this to receive
                    /// the subsequent page. When paginating, all other parameters provided to `ListSessions` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. The view of the sessions to return. If not set, the `BASIC` view will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. The view of the sessions to return. If not set, the `BASIC` view will be returned.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_UNSPECIFIED")]
                        SESSIONVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Include basic view of the session but not the full contents. Only the
                        /// uid/display_name/status/result of the session and its jobs/executions will be included. This
                        /// is the default value (for GetSession).
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_BASIC")]
                        SESSIONVIEWBASIC = 1,

                        /// <summary>Include everything.</summary>
                        [Google.Apis.Util.StringValueAttribute("SESSION_VIEW_FULL")]
                        SESSIONVIEWFULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sessions";

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
            }

            /// <summary>Gets the SoftwareVersions resource.</summary>
            public virtual SoftwareVersionsResource SoftwareVersions { get; }

            /// <summary>The "softwareVersions" collection of methods.</summary>
            public class SoftwareVersionsResource
            {
                private const string Resource = "softwareVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SoftwareVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Returns information about a specific software version.</summary>
                /// <param name="name">
                /// Required. The name of the software version. Format:
                /// `projects/{project}/locations/global/softwareVersions/{software_version}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns information about a specific software version.</summary>
                public class GetRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.CatalogSoftwareVersion>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the software version. Format:
                    /// `projects/{project}/locations/global/softwareVersions/{software_version}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/softwareVersions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all software versions.</summary>
                /// <param name="parent">
                /// Required. The parent of the collection of software versions. Format:
                /// `projects/{project}/locations/global`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all software versions.</summary>
                public class ListRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.CatalogListSoftwareVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the collection of software versions. Format:
                    /// `projects/{project}/locations/global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An AIP-160 (https://google.aip.dev/160) filter expression restricting which software
                    /// versions are returned. An empty filter returns all software versions. Filtering is supported
                    /// over the `SoftwareVersion` fields, including nested fields via dot-path. Enum and string values
                    /// must be double-quoted. Examples: * `software_type = "ANDROIDX_TEST_ORCHESTRATOR"` *
                    /// `software_type = "ANDROIDX_TEST_ORCHESTRATOR" AND is_default = true` * `lifecycle.state =
                    /// "ACTIVE"` * `version = "1.4.1"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of software versions to return. The server may return fewer items
                    /// than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListSoftwareVersions` call. Provide this to
                    /// receive the subsequent page. When paginating, all other parameters provided to
                    /// `ListSoftwareVersions` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/softwareVersions";

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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.Location>
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
                public override string RestPath => "v1alpha/{+name}";

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

            /// <summary>
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            public class ListRequest : DeviceRunBaseServiceRequest<Google.Apis.DeviceRun.v1alpha.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field unless explicitly documented otherwise. This is primarily for
                /// internal usage.
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
                public override string RestPath => "v1alpha/{+name}/locations";

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
namespace Google.Apis.DeviceRun.v1alpha.Data
{
    /// <summary>Allocation config.</summary>
    public class AllocationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. At least one device config is required. If more than one device config is required, the multiple
        /// devices are allocated to each shard of the OmniLab job to run multi-device-interaction tests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceConfigs")]
        public virtual System.Collections.Generic.IList<DeviceConfig> DeviceConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Captures a bugreport from the device. The output will be written to a file named `bugreport.zip` in the
    /// execution output directory.
    /// </summary>
    public class AndroidBugreportDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to deliver the bugreport when the test passes. If false, the bugreport is skipped on pass
        /// to save time (default behavior). If true, the bugreport is always delivered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectOnPass")]
        public virtual System.Nullable<bool> CollectOnPass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Captures dumpsys output from the device. The output will be written to a file named `dumpsys.log` in the
    /// execution output directory.
    /// </summary>
    public class AndroidDumpsysDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to deliver the dumpsys when the test passes. If false, the dumpsys is skipped on pass to
        /// save time (default behavior). If true, the dumpsys is always delivered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectOnPass")]
        public virtual System.Nullable<bool> CollectOnPass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Installs Android packages on the device. At least one installable is specified when using this device action.
    /// Limits: - A maximum of 20 installables in total are allowed. - A maximum of 100 files are allowed in total
    /// across all installables.
    /// </summary>
    public class AndroidInstallPackagesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deprecated: use `pre_target_app_installables`, `target_app` and `post_target_app_installables`
        /// instead. The Android packages to install on the device. The installation will be performed in the order
        /// specified, before the installables of all other fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installables")]
        public virtual System.Collections.Generic.IList<AndroidInstallable> Installables { get; set; }

        /// <summary>
        /// Optional. The Android packages to install on the device after `target_app` (if specified) is installed. The
        /// installation will be performed in the order specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postTargetAppInstallables")]
        public virtual System.Collections.Generic.IList<AndroidInstallable> PostTargetAppInstallables { get; set; }

        /// <summary>
        /// Optional. The Android packages to install on the device before `target_app` (if specified) is installed. The
        /// installation will be performed in the order specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preTargetAppInstallables")]
        public virtual System.Collections.Generic.IList<AndroidInstallable> PreTargetAppInstallables { get; set; }

        /// <summary>
        /// Optional. The primary Android package to install, serving as the target package for subsequent actions and
        /// as the installation ordering anchor. Whether this package is treated as the application under test depends
        /// on the job action: - Actions that require an explicit target package (such as performance metrics
        /// collection, or accessibility scans) use this package to identify the application to inspect or drive. -
        /// Actions that discover or manage targets independently (such as Android instrumentation tests, where target
        /// packages are defined in the test runner manifest) treat this field primarily as an installation order anchor
        /// between pre- and post-installables. Optional. If omitted, all packages in `pre_target_app_installables` and
        /// `post_target_app_installables` are installed without a designated target package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetApp")]
        public virtual AndroidInstallable TargetApp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Android Installable represents the file(s) for installing an Android package on a device. This can be an APK,
    /// an Android App Bundle (AAB), or an APK Set.
    /// </summary>
    public class AndroidInstallable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Files that make up the package. Supported formats are distinguished by their file extension: -
        /// APK: One or more files with extension `.apk`. - App Bundle: A single file with extension `.aab`. - APK Set:
        /// A single file with extension `.apks`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<InputFile> Files { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The configuration of an Android instrumentation test. See
    /// https://developer.android.com/training/testing/instrumented-tests for more information on Android
    /// instrumentation tests.
    /// </summary>
    public class AndroidInstrumentationTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Additional test options to pass to the test runner. Passed to `am instrument` command as `-e`
        /// options, which will be passed to the instrumentation test runner using its `onCreate()` method. Formats
        /// supported in test_targets are not allowed to be used here. Limits: - Maximum number of entries: 32. -
        /// Maximum key size: 64 bytes (UTF-8). - Maximum value size: 1024 bytes (UTF-8).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTestOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalTestOptions { get; set; }

        /// <summary>
        /// Optional. Whether to enable code coverage collection for the test. A coverage file `coverage.ec` will be
        /// uploaded to the results folder. For this to work, your classes have to be instrumented offline (build time)
        /// by EMMA/JaCoCo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCodeCoverage")]
        public virtual System.Nullable<bool> EnableCodeCoverage { get; set; }

        /// <summary>
        /// Optional. The timeout of the instrumentation test. Default value: 5 min. Range: [1 min, 3 hours].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instrumentationTimeout")]
        public virtual object InstrumentationTimeout { get; set; }

        /// <summary>
        /// Optional. The version of the Android Test Orchestrator to use for the test. The available orchestrator
        /// versions can be retrieved from the catalog service. If set to "auto", the default orchestrator is used. If
        /// not set, no orchestrator is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestratorVersion")]
        public virtual string OrchestratorVersion { get; set; }

        /// <summary>
        /// Optional. Smart sharding strategy to split the job into multiple shards based on the test methods and their
        /// execution time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smartSharding")]
        public virtual AndroidInstrumentationTestSmartSharding SmartSharding { get; set; }

        /// <summary>Required. The test package to install and run the test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testInstallable")]
        public virtual AndroidInstallable TestInstallable { get; set; }

        /// <summary>
        /// Optional. Full class name of the test runner class. The class must be
        /// `androidx.test.runner.AndroidJUnitRunner` or a subclass of it. The default value is determined by examining
        /// the application's manifest. If multiple instrumentations are found, the first one in the manifest will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testRunnerClass")]
        public virtual string TestRunnerClass { get; set; }

        /// <summary>
        /// Optional. A list of test targets or target filters to run. Each target must be fully qualified with the
        /// package name or class name, in one of these formats: - `package package_name` - `notPackage
        /// com.package.to.skip` - `class package_name.class_name` - `class package_name.class_name#method_name` -
        /// `notClass com.foo.ClassToSkip` - `notClass com.foo.ClassName#testMethodToSkip` - `annotation
        /// com.foo.AnnotationToRun` - `notAnnotation com.foo.AnnotationToSkip` - `size [small|medium|large]` Formats
        /// like `testfile` or `notTestfile` won't be supported. If empty, all targets in the module will be run.
        /// Limits: - Maximum number of entries: 1024.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testTargets")]
        public virtual System.Collections.Generic.IList<string> TestTargets { get; set; }

        /// <summary>
        /// Optional. Uniform sharding strategy to split the job into multiple shards with equal number of test methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniformSharding")]
        public virtual AndroidInstrumentationTestUniformSharding UniformSharding { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The smart sharding strategy to split the job into multiple shards based on the test methods and their recorded
    /// execution time.
    /// </summary>
    public class AndroidInstrumentationTestSmartSharding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum number of shards to create. If unset or less than 1, system-defined max limits are
        /// used. This limit takes precedence if the targeted_shard_duration cannot be satisfied. Limits: - For physical
        /// devices, the number of shards must be &amp;lt;= 20. - For virtual devices, the number of shards must be
        /// &amp;lt;= 200.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxShardCount")]
        public virtual System.Nullable<int> MaxShardCount { get; set; }

        /// <summary>
        /// Required. The targeted duration of each shard. Limits: - Must be at least 2 minutes. - Must be at most 3
        /// hours. Shard duration is not guaranteed because smart sharding uses test case history and default durations
        /// which may not be accurate. Durations are calculated based on the following inputs: - Timing records from
        /// previous runs of the same test case. - For new test cases, the average duration of other known test cases. -
        /// A system-chosen, default duration if there are no previous timing records available. Because the actual
        /// shard duration can exceed the targeted shard duration, we recommend that you set the targeted value at least
        /// 5 minutes less than the maximum allowed instrumentation timeout. This approach avoids cancelling the shard
        /// before all tests can finish.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedShardDuration")]
        public virtual object TargetedShardDuration { get; set; }

        /// <summary>
        /// Required. The timing record file to use for smart sharding. If the file does not exist, smart sharding will
        /// use default test time (30s) for each test method to shard the job into multiple shards. This file will be
        /// overwritten with the latest timing record after the job is completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timingRecord")]
        public virtual InputFile TimingRecord { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Uniformly shards test cases given a total number of shards. It will be translated to `-e numShard` and `-e
    /// shardIndex` AndroidJUnitRunner arguments. With uniform sharding enabled, specifying either of these sharding
    /// arguments via `environment_variables` is invalid. Based on the sharding mechanism AndroidJUnitRunner uses, there
    /// is no guarantee that test cases will be distributed uniformly across all shards.
    /// </summary>
    public class AndroidInstrumentationTestUniformSharding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The total number of shards to create. This must always be a positive number that is no greater
        /// than the total number of test cases. Limits: - For physical devices, the number of shards must be &amp;lt;=
        /// 20. - For virtual devices, the number of shards must be &amp;lt;= 200.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Collects logcat output from the device. The output will be written to a file named `logcat.txt` in the execution
    /// output directory.
    /// </summary>
    public class AndroidLogcatDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mocks the location of the Android device.</summary>
    public class AndroidMockLocationDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The mock location to set on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LatLng Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of an Android native binary execution.</summary>
    public class AndroidNativeBinary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The file path of the Android native binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidNativeBinary")]
        public virtual InputFile AndroidNativeBinaryValue { get; set; }

        /// <summary>
        /// Optional. Arguments for running the binary file. The flags will be appended to the command line that invokes
        /// the binary. Limits: - Maximum number of entries: 64 - Maximum entry size: 1024 bytes (UTF-8)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Optional. A map of environment variables to set for the binary process. The keys are the variable names and
        /// the values are the variable values. Limits: - Maximum number of entries: 32 - Maximum key size: 64 bytes
        /// (UTF-8) - Key regex: `a-zA-Z_*` - Maximum value size: 1024 bytes (UTF-8)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVars")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvVars { get; set; }

        /// <summary>Optional. The timeout of the execution. Default value: 5 min. Range: [1 min, 3 hours].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTimeout")]
        public virtual object ExecutionTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the orientation of the device.</summary>
    public class AndroidOrientationDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The orientation to set the device to. One of `portrait` or `landscape`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orientation")]
        public virtual string Orientation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pulls directories and files from the device at the end of the run. Files will be copied to the '/artifacts'
    /// directory, with the absolute path structure preserved. Note that: 1. A clean device is provided for the run. 2.
    /// Any existing files in the output directory may be overwritten. 3. Pulling files is best effort. Will skip files
    /// if they don't exist on the device.
    /// </summary>
    public class AndroidPullFilesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Absolute directory or file paths to pull from the device. Limits: - A maximum of 10 paths are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pushes files to the device at the beginning of the run. Files are overwritten if a file with the same path
    /// already exists on the device, if device permissions allow.
    /// </summary>
    public class AndroidPushFilesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Configs of pushing files to the device. Limits: - A maximum of 50 files are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileConfigs")]
        public virtual System.Collections.Generic.IList<AndroidPushFilesDeviceActionFileConfig> FileConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of pushing a file to the device.</summary>
    public class AndroidPushFilesDeviceActionFileConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The destination path on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPath")]
        public virtual string DestinationPath { get; set; }

        /// <summary>Required. The file to be pushed to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFile")]
        public virtual InputFile SourceFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Records a video of the device screen during the run. The video will be written to a file named `video.mp4` in
    /// the execution output directory.
    /// </summary>
    public class AndroidRecordVideoDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to discard and not upload the recording when the test passes. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discardOnPass")]
        public virtual System.Nullable<bool> DiscardOnPass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Switches the locale (language and region) of the device.</summary>
    public class AndroidSwitchLocaleDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The locale (language and region) to switch the device to. The format is `language-region`, e.g.
        /// "en-US", "zh-CN", etc. The typical language value is a two or three-letter language code as defined in
        /// ISO639. The typical region value is a two-letter ISO 3166 code or a three-digit UN M.49 area code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localeCode")]
        public virtual string LocaleCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to cancel a session.</summary>
    public class CancelSessionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of the cancel session request.</summary>
    public class CancelSessionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelResult")]
        public virtual string CancelResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android-specific device attributes.</summary>
    public class CatalogAndroidDeviceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Mirrors the AOSP `ro.build.type` property, e.g. "user", "userdebug", "eng". Empty if unknown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildType")]
        public virtual string BuildType { get; set; }

        /// <summary>
        /// Output only. Lists ABIs supported by the device (android.os.Build.SUPPORTED_ABIS), most preferred first,
        /// e.g. "arm64-v8a".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedAbis")]
        public virtual System.Collections.Generic.IList<string> SupportedAbis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AndroidX Test Orchestrator-specific attributes. Reserved for future orchestrator-only fields.</summary>
    public class CatalogAndroidxTestOrchestratorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-product metadata for the Automation (DeviceRun) product.</summary>
    public class CatalogAutomationSupport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single routable device configuration in the catalog.</summary>
    public class CatalogDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Reasons for access denial. This model is accessible/usable if this list is empty, otherwise the
        /// model is viewable only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessDeniedReasons")]
        public virtual System.Collections.Generic.IList<string> AccessDeniedReasons { get; set; }

        /// <summary>Output only. Contains Android-specific attributes (set when platform == ANDROID).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDetails")]
        public virtual CatalogAndroidDeviceDetails AndroidDetails { get; set; }

        /// <summary>Output only. Reports the current fleet availability for this device configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual CatalogDeviceAvailability Availability { get; set; }

        /// <summary>Output only. Provides a human-readable display name, e.g. "Pixel 5".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Specifies the form factor of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>Output only. Indicates whether the device is physical or virtual.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareType")]
        public virtual string HardwareType { get; set; }

        /// <summary>Output only. Contains iOS-specific attributes (set when platform == IOS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosDetails")]
        public virtual CatalogIosDeviceDetails IosDetails { get; set; }

        /// <summary>Output only. The lab hosting this device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labInfo")]
        public virtual CatalogLabInfo LabInfo { get; set; }

        /// <summary>
        /// Output only. Additional information. Informational only. May change over the lifecycle of a device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The device lifecycle (maturity stage and removal date).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual CatalogLifecycle Lifecycle { get; set; }

        /// <summary>Output only. Specifies the hardware manufacturer of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>
        /// Output only. Provides a human-readable model identifier for this device, independent of OS version. May be
        /// empty. Platform-dependent: * Android physical: hardware codename (android.os.Build.DEVICE), e.g. "shiba". *
        /// Android virtual: AVD model identifier, e.g. "MediumPhone.arm". * iOS: model identifier, e.g. "iphone14pro".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelCode")]
        public virtual string ModelCode { get; set; }

        /// <summary>
        /// Identifier. Identifies the device resource. Format:
        /// `projects/{project}/locations/{location}/devices/{device}`. The {device} segment is an opaque, stable
        /// string. Clients must not parse it to derive or assume device-specific details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Specifies the OS version, e.g. "30" (Android API level) or "17.4" (iOS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>Output only. Specifies the platform of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// Output only. Measurements of the primary device screen. Informational only. Unset for devices without a
        /// screen (e.g. some wearables).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryScreen")]
        public virtual CatalogScreenMetrics PrimaryScreen { get; set; }

        /// <summary>Output only. Products/Services supported by this device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedProducts")]
        public virtual System.Collections.Generic.IList<CatalogSupportedProduct> SupportedProducts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fleet availability for a device configuration.</summary>
    public class CatalogDeviceAvailability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies the current availability bucket (idle, immediately allocatable devices) for this
        /// device configuration. This is a best-effort snapshot, refreshed periodically. It fluctuates depending on
        /// traffic as other requests allocate devices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("available")]
        public virtual string Available { get; set; }

        /// <summary>
        /// Output only. Specifies the current capacity bucket for this device configuration. Represents the total
        /// number of online devices (idle or in use).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacity")]
        public virtual string Capacity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-product metadata for the DeviceStreaming product.</summary>
    public class CatalogDeviceStreamingSupport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies the minimum Android Studio version that supports this device. Optional; only set when
        /// the device is known to work only at or above a certain Android Studio version. Expected format
        /// "major.minor.micro.patch", e.g. "5921.22.2211.8881706".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumAndroidStudioVersion")]
        public virtual string MinimumAndroidStudioVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>iOS-specific device attributes. Reserved for future iOS-only fields.</summary>
    public class CatalogIosDeviceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The lab hosting a device.</summary>
    public class CatalogLabInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Display name of the lab where the device is hosted. If empty, the device is hosted in a Google
        /// owned lab.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The Unicode country/region code (CLDR) of the lab where the device is hosted, e.g. "US" for
        /// United States, "KR" for South Korea. Empty when the hosting region is not published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Catalog resource lifecycle: maturity state plus key lifecycle dates.</summary>
    public class CatalogLifecycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Specifies the date the resource is scheduled to be removed from the catalog. Only set when
        /// `state == DEPRECATED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removalDate")]
        public virtual Date RemovalDate { get; set; }

        /// <summary>Output only. Specifies the current maturity state of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response including listed devices.</summary>
    public class CatalogListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<CatalogDevice> Devices { get; set; }

        /// <summary>
        /// Token to receive the next page of devices. This will be absent if the end of the response list has been
        /// reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response including listed software versions.</summary>
    public class CatalogListSoftwareVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to receive the next page of software versions. This will be absent if the end of the response list has
        /// been reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of software versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareVersions")]
        public virtual System.Collections.Generic.IList<CatalogSoftwareVersion> SoftwareVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Screen measurements of a device.</summary>
    public class CatalogScreenMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Pixel density in dots per inch (dpi).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("densityDpi")]
        public virtual System.Nullable<int> DensityDpi { get; set; }

        /// <summary>Output only. Height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPx")]
        public virtual System.Nullable<int> HeightPx { get; set; }

        /// <summary>Output only. Width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPx")]
        public virtual System.Nullable<int> WidthPx { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single software version in the catalog.</summary>
    public class CatalogSoftwareVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains AndroidX Test Orchestrator-specific attributes (set when software_type ==
        /// ANDROIDX_TEST_ORCHESTRATOR).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidxTestOrchestratorDetails")]
        public virtual CatalogAndroidxTestOrchestratorDetails AndroidxTestOrchestratorDetails { get; set; }

        /// <summary>
        /// Output only. Provides a human-readable name for this version, e.g. "AndroidX Test Orchestrator 1.4.1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Indicates whether the system uses this version when a request does not select one explicitly.
        /// Exactly one version per `software_type` is the default, and it may change over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>Output only. The version lifecycle (maturity stage and removal date).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual CatalogLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Identifier. Identifies the software version resource. Format:
        /// `projects/{project}/locations/{location}/softwareVersions/{software_version}`. The {software_version}
        /// segment is an opaque, stable string. Clients must not parse it to derive or assume the version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Specifies which software this is a version of. Filter on this field to narrow the collection to
        /// a single kind of software, for example `software_type = "ANDROIDX_TEST_ORCHESTRATOR"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareType")]
        public virtual string SoftwareType { get; set; }

        /// <summary>
        /// Output only. Specifies the version identifier, e.g. "1.4.1". Unique within a `software_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>Output only. Contains Xcode-specific attributes (set when software_type == XCODE).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcodeDetails")]
        public virtual CatalogXcodeDetails XcodeDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Declares that a device supports a given Device Cloud product, with optional per-product metadata. Discriminated
    /// by which product-specific message is set; adding a new product = new oneof arm + new per-product message.
    /// </summary>
    public class CatalogSupportedProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Represents Automation, which is DeviceRun-backed automated test execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automation")]
        public virtual CatalogAutomationSupport Automation { get; set; }

        /// <summary>Output only. Represents DeviceStreaming, which is interactive remote device streaming.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceStreaming")]
        public virtual CatalogDeviceStreamingSupport DeviceStreaming { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Xcode-specific attributes.</summary>
    public class CatalogXcodeDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Lists the iOS versions this Xcode can run tests against, e.g. "16.6". This is a property of the
        /// toolchain, so it says nothing about whether a device on that iOS version is available; list the `Device`
        /// collection to find out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedIosVersions")]
        public virtual System.Collections.Generic.IList<string> SupportedIosVersions { get; set; }

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

    /// <summary>The action to be performed on a device.</summary>
    public class DeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Captures a bugreport from the device unless the test result is pass.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidBugreport")]
        public virtual AndroidBugreportDeviceAction AndroidBugreport { get; set; }

        /// <summary>Captures a dumpsys from the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDumpsys")]
        public virtual AndroidDumpsysDeviceAction AndroidDumpsys { get; set; }

        /// <summary>Installs Android packages on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInstallPackages")]
        public virtual AndroidInstallPackagesDeviceAction AndroidInstallPackages { get; set; }

        /// <summary>Collects logcat output from the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidLogcat")]
        public virtual AndroidLogcatDeviceAction AndroidLogcat { get; set; }

        /// <summary>Mocks the location of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidMockLocation")]
        public virtual AndroidMockLocationDeviceAction AndroidMockLocation { get; set; }

        /// <summary>Sets the orientation of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidOrientation")]
        public virtual AndroidOrientationDeviceAction AndroidOrientation { get; set; }

        /// <summary>Pulls directories and files from the device at the end of the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPullFiles")]
        public virtual AndroidPullFilesDeviceAction AndroidPullFiles { get; set; }

        /// <summary>Pushes files to the device at the beginning of the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPushFiles")]
        public virtual AndroidPushFilesDeviceAction AndroidPushFiles { get; set; }

        /// <summary>Records a video of the device screen during the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidRecordVideo")]
        public virtual AndroidRecordVideoDeviceAction AndroidRecordVideo { get; set; }

        /// <summary>Switches the locale (language and region) of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSwitchLocale")]
        public virtual AndroidSwitchLocaleDeviceAction AndroidSwitchLocale { get; set; }

        /// <summary>Collects the exported iOS App Privacy Report during the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppPrivacyReport")]
        public virtual IosAppPrivacyReportDeviceAction IosAppPrivacyReport { get; set; }

        /// <summary>Installs additional iOS packages on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosInstallPackages")]
        public virtual IosInstallPackagesDeviceAction IosInstallPackages { get; set; }

        /// <summary>Pulls directories and files from the iOS device sandbox at the end of the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosPullFiles")]
        public virtual IosPullFilesDeviceAction IosPullFiles { get; set; }

        /// <summary>Pushes files to the iOS device sandbox at the beginning of the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosPushFiles")]
        public virtual IosPushFilesDeviceAction IosPushFiles { get; set; }

        /// <summary>Records a video of the iOS device screen during the run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosRecordVideo")]
        public virtual IosRecordVideoDeviceAction IosRecordVideo { get; set; }

        /// <summary>Switches the locale (language and region) of the iOS application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosSwitchLocale")]
        public virtual IosSwitchLocaleDeviceAction IosSwitchLocale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of a run on a device.</summary>
    public class DeviceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The actions to be performed on the device. Actions will be executed in the order they are
        /// specified in the list. Each action type can at most have 1 instance in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<DeviceAction> Actions { get; set; }

        /// <summary>Required. The requirement of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirement")]
        public virtual DeviceRequirement Requirement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The requirement of a device.</summary>
    public class DeviceRequirement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The device ID of a device in the catalog. The device ID is the last part of a device's resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

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

    /// <summary>The runtime information and result report of a single on-device execution attempt.</summary>
    public class ExecutionReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display_name set by users in the ExecutionConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of the execution.</summary>
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

        /// <summary>Output only. The unique identifier of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. The output files of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFiles")]
        public virtual System.Collections.Generic.IList<OutputFile> OutputFiles { get; set; }

        /// <summary>Output only. The result of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual Result Result { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of the execution.</summary>
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

        /// <summary>Output only. The status of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>Output only. Non-fatal warnings collected during the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A path to a file or directory in Google Cloud Storage.</summary>
    public class GcsPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Google Cloud Storage path of the file or directory. Format: `gs:///`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Input file.</summary>
    public class InputFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An input file in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsInputFile")]
        public virtual GcsPath GcsInputFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Collects the exported iOS App Privacy Report during the test run. When enabled, the iOS device records
    /// application activity (such as network access, domain requests, and sensitive resource access like photos,
    /// camera, or location) and exports Apple's official App Privacy Report. The report will be written to a file named
    /// `AppActivityReport.ndjson` in the execution output directory.
    /// </summary>
    public class IosAppPrivacyReportDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Installs iOS packages on the device.</summary>
    public class IosInstallPackagesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Additional iOS packages (IPAs) to install on the device. Limits: - A maximum of 20 IPAs are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipas")]
        public virtual System.Collections.Generic.IList<InputFile> Ipas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pulls directories and files from the iOS device sandbox at the end of the run.</summary>
    public class IosPullFilesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Absolute directory or file paths to pull from the device. Limits: - A maximum of 10 paths are
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<IosPullFilesDeviceActionPathConfig> Paths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of pulling a file or directory from the iOS device.</summary>
    public class IosPullFilesDeviceActionPathConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The bundle ID of the application sandbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Required. The device path relative to the app sandbox, e.g. "/Documents/output/".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePath")]
        public virtual string DevicePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pushes files to the iOS device sandbox at the beginning of the run.</summary>
    public class IosPushFilesDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Configs of pushing files to the device. Limits: - A maximum of 50 files are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileConfigs")]
        public virtual System.Collections.Generic.IList<IosPushFilesDeviceActionFileConfig> FileConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of pushing a file to the iOS device.</summary>
    public class IosPushFilesDeviceActionFileConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The bundle ID of the application sandbox.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Required. The destination path relative to the app sandbox, e.g. "/Documents/file.txt".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPath")]
        public virtual string DestinationPath { get; set; }

        /// <summary>Required. The file to be pushed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFile")]
        public virtual InputFile SourceFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Records a video of the iOS device screen during the run. The video will be written to a file named `video.mp4`
    /// in the execution output directory.
    /// </summary>
    public class IosRecordVideoDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to discard the video if the test passes. If not specified, the default is false (always
        /// keep the video).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discardOnPass")]
        public virtual System.Nullable<bool> DiscardOnPass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Switches the locale (language and region) of the iOS application.</summary>
    public class IosSwitchLocaleDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The locale (language and region) to switch the app to. The format is `language-region` or
        /// `language`, e.g. "en-US", "zh-CN", "ja", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localeCode")]
        public virtual string LocaleCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of an iOS XCTest.</summary>
    public class IosXcTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The .zip containing the .xctestrun file and the contents of the DerivedData/Build/Products
        /// directory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testsZip")]
        public virtual InputFile TestsZip { get; set; }

        /// <summary>Optional. The timeout of the test. Default value: 5 min. Range: [1 min, 3 hours].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcTestTimeout")]
        public virtual object XcTestTimeout { get; set; }

        /// <summary>
        /// Optional. The Xcode version that should be used for the test. If not set, a system-default Xcode version is
        /// used. The available Xcode versions can be retrieved from the catalog service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xcodeVersion")]
        public virtual string XcodeVersion { get; set; }

        /// <summary>Optional. An .xctestrun file that will override the .xctestrun file in the tests zip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xctestrun")]
        public virtual InputFile Xctestrun { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the summary of an issue (error or warning) with structured details.</summary>
    public class IssueSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Human-readable explanation of the issue in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// Output only. The reason of the issue. This is a constant value that identifies the proximate cause of the
        /// issue. This should be at most 63 characters and match a regular expression of `A-Z*[A-Z0-9]`, which
        /// represents UPPER_SNAKE_CASE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Output only. The issue classification based on responsibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The action to be performed in a job.</summary>
    public class JobAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Android instrumentation test.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInstrumentationTest")]
        public virtual AndroidInstrumentationTest AndroidInstrumentationTest { get; set; }

        /// <summary>Android native binary execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidNativeBinary")]
        public virtual AndroidNativeBinary AndroidNativeBinary { get; set; }

        /// <summary>iOS XCTest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosXcTest")]
        public virtual IosXcTest IosXcTest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of a job.</summary>
    public class JobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Job action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual JobAction Action { get; set; }

        /// <summary>Required. Allocation config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocationConfig")]
        public virtual AllocationConfig AllocationConfig { get; set; }

        /// <summary>
        /// Optional. User-settable, human-readable name for the job. If set, it must be unique within the session. If
        /// not set, the display name will default to `job-`, where `` is the 0-based index of the job in the session
        /// formatted as three digits (e.g., job-000, job-001, ...). Maximum size is 63 bytes when encoded as UTF-8. If
        /// set, must match regex: `^A-Za-z0-9*$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. User-defined metadata for tracking or categorization. These labels do not affect job execution and
        /// are surfaced in the JobReport. Limits: - Maximum number of entries: 16. - Maximum key size: 32 bytes
        /// (UTF-8). - Maximum value size: 1024 bytes (UTF-8).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Job settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual JobSettings Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The runtime information and result report of a job.</summary>
    public class JobReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The display_name set by users in the JobConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of the job.</summary>
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

        /// <summary>Output only. Reports of the execution attempts of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionReports")]
        public virtual System.Collections.Generic.IList<ExecutionReport> ExecutionReports { get; set; }

        /// <summary>Output only. The unique identifier of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. The original labels provided by the user during job creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The output files of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFiles")]
        public virtual System.Collections.Generic.IList<OutputFile> OutputFiles { get; set; }

        /// <summary>Output only. The result of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual Result Result { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of the job.</summary>
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

        /// <summary>Output only. The status of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>Output only. Non-fatal warnings collected during the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job settings to control the job execution.</summary>
    public class JobSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The retry settings of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrySettings")]
        public virtual RetrySettings RetrySettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees
    /// latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard.
    /// Values must be within normalized ranges.
    /// </summary>
    public class LatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; }

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; }

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

    /// <summary>Response including listed sessions.</summary>
    public class ListSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to receive the next page of sessions. This will be absent if the end of the response list has been
        /// reached.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessions")]
        public virtual System.Collections.Generic.IList<Session> Sessions { get; set; }

        /// <summary>Unordered list. Sessions that could not be reached.</summary>
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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        /// <summary>Output only. The time the operation finished running.</summary>
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
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
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

    /// <summary>Output file.</summary>
    public class OutputFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An output file in Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsOutputFile")]
        public virtual GcsPath GcsOutputFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a session/job/execution.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Detailed result cause diagnostics. Set if type is not PASSED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual ResultCause Cause { get; set; }

        /// <summary>Output only. The result type of the session/job/execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultType")]
        public virtual string ResultType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the cause of the non-passed result occurred during the execution.</summary>
    public class ResultCause : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Structured cause detail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual IssueSummary Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retry settings.</summary>
    public class RetrySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The default retry strategy. Allows an Execution to retry on test failures and infrastructure
        /// errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flakyTestRetryStrategy")]
        public virtual RetrySettingsFlakyTestRetryStrategy FlakyTestRetryStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Default retry strategy. It will retry on test failures for up to flaky_test_attempts (including the initial
    /// run). It also retries on infra issues for up to 2 attempts (including the initial run). So in total, an
    /// execution can run up to flaky_test_attempts * 2 times in the worst case.
    /// </summary>
    public class RetrySettingsFlakyTestRetryStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The total attempts for flaky tests, including the initial run. Default value: 1 (no retry). Range:
        /// [1, 5].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flakyTestAttempts")]
        public virtual System.Nullable<int> FlakyTestAttempts { get; set; }

        /// <summary>
        /// Optional. Whether to retry the test failures in parallel. By default, the test is retried sequentially. If
        /// true, when the initial attempt fails, (flaky_test_attempts - 1) attempts will be triggered at the same time
        /// to run in parallel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelRetry")]
        public virtual System.Nullable<bool> ParallelRetry { get; set; }

        /// <summary>
        /// Optional. The mode of test reduction for retry. If the test runner doesn't support the specified test
        /// reduction mode, the request will be rejected with an `INVALID_ARGUMENT` error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testReductionMode")]
        public virtual string TestReductionMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A session resource in the AutomationSession API. At a high level, `Session` describes the configuration of one
    /// or multiple jobs, the state transitions it goes through, and the results.
    /// </summary>
    public class Session : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The resource name of the session. Format:
        /// `projects/{project}/locations/{location}/sessions/{session}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Configuration used to create the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionConfig")]
        public virtual SessionConfig SessionConfig { get; set; }

        /// <summary>Output only. The runtime information and result report of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionReport")]
        public virtual SessionReport SessionReport { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SessionConfig is used to create a session.</summary>
    public class SessionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User-settable, human-readable name for the session. Maximum size is 63 bytes when encoded as
        /// UTF-8. If set, must match regex: `^A-Za-z0-9*$`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Configs of the jobs in the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobConfigs")]
        public virtual System.Collections.Generic.IList<JobConfig> JobConfigs { get; set; }

        /// <summary>Optional. Notification config for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual SessionConfigSessionNotificationConfig NotificationConfig { get; set; }

        /// <summary>Required. Output file directory config for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDirectoryConfig")]
        public virtual SessionConfigSessionOutputFileDirectoryConfig OutputDirectoryConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config to control session notification.</summary>
    public class SessionConfigSessionNotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Pub/Sub topics to which session events are published. Format:
        /// `projects/{project}/topics/{topic}`. See
        /// https://cloud.google.com/pubsub/docs/admin#topic_and_subscription_name_restrictions
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual System.Collections.Generic.IList<string> PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config to control session output file directory.</summary>
    public class SessionConfigSessionOutputFileDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to write output files directly under the output directory instead of nesting them under
        /// service-generated subdirectories. By default (`false`), output files are stored under `////`. When `true`,
        /// the session ID subdirectory is never appended, and the job display name subdirectory is appended only when
        /// the session has more than one job. Output files are therefore stored under: - `//` for a single-job session.
        /// - `///` for a multi-job session. Set this to `true` when the output directory is already unique per session
        /// (for example, when a CI system generates it), to avoid redundant nesting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatDirectoryStructure")]
        public virtual System.Nullable<bool> FlatDirectoryStructure { get; set; }

        /// <summary>
        /// The Google Cloud Storage path of the output directory (e.g. `gs://my-bucket/output`). The bucket must exist.
        /// If the bucket is located in another project or uses fine-grained access controls, ensure the Device Run
        /// Service Agent of the project (`service-@gcp-sa-devicerun.iam.gserviceaccount.com`) is granted access to the
        /// bucket (such as `roles/storage.objectUser`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsOutputDirectory")]
        public virtual GcsPath GcsOutputDirectory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The runtime information and result report of a session.</summary>
    public class SessionReport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of the session.</summary>
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

        /// <summary>Output only. The unique identifier of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Reports of the jobs in the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobReports")]
        public virtual System.Collections.Generic.IList<JobReport> JobReports { get; set; }

        /// <summary>Output only. The result of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual Result Result { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of the session.</summary>
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

        /// <summary>Output only. The status of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of a session/job/execution.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Human-readable, detailed descriptions of the session/job/execution's progress. For example:
        /// "Provisioning a device", "Starting Test". Each message should contain only one line of text. During the
        /// course of execution new data may be appended to the end of progress_messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressMessages")]
        public virtual System.Collections.Generic.IList<string> ProgressMessages { get; set; }

        /// <summary>Output only. The status type of the session/job/execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusType")]
        public virtual string StatusType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Non-fatal operational anomaly, lint observation, or execution insight.</summary>
    public class Warning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Detailed warning summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual IssueSummary Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
