// Copyright 2023 Google LLC
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

namespace Google.Apis.ChecksService.v1alpha
{
    /// <summary>The ChecksService Service.</summary>
    public class ChecksServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChecksServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChecksServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Media = new MediaResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "checks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://checks.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://checks.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }
    }

    /// <summary>A base abstract class for ChecksService requests.</summary>
    public abstract class ChecksServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChecksServiceBaseServiceRequest instance.</summary>
        protected ChecksServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ChecksService parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apps = new AppsResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
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
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.ChecksService.v1alpha.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.ChecksService.v1alpha.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChecksService.v1alpha.Data.CancelOperationRequest Body { get; set; }

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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/operations/[^/]+$",
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
                public class DeleteRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Empty>
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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/operations/[^/]+$",
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
                public class GetRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Operation>
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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/operations/[^/]+$",
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
                public class ListRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.ListOperationsResponse>
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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+$",
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
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to wait on.</param>
                public virtual WaitRequest Wait(Google.Apis.ChecksService.v1alpha.Data.WaitOperationRequest body, string name)
                {
                    return new WaitRequest(this.service, body, name);
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
                public class WaitRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Wait request.</summary>
                    public WaitRequest(Google.Apis.Services.IClientService service, Google.Apis.ChecksService.v1alpha.Data.WaitOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to wait on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ChecksService.v1alpha.Data.WaitOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "wait";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:wait";

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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/operations/[^/]+$",
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
                /// Gets a report. By default, only the name and results_uri fields are returned. You can include other
                /// fields by listing them in the `fields` URL query parameter. For example, `?fields=name,checks` will
                /// return the name and checks fields.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the report. Example: `accounts/123/apps/456/reports/789`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets a report. By default, only the name and results_uri fields are returned. You can include other
                /// fields by listing them in the `fields` URL query parameter. For example, `?fields=name,checks` will
                /// return the name and checks fields.
                /// </summary>
                public class GetRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaReport>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the report. Example: `accounts/123/apps/456/reports/789`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An [AIP-160](https://google.aip.dev/160) filter string to filter checks within the
                    /// report. Only checks that match the filter string are included in the response. Example: `state =
                    /// FAILED`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("checksFilter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ChecksFilter { get; set; }

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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/reports/[^/]+$",
                        });
                        RequestParameters.Add("checksFilter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "checksFilter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists reports for the specified app. By default, only the name and results_uri fields are returned.
                /// You can include other fields by listing them in the `fields` URL query parameter. For example,
                /// `?fields=reports(name,checks)` will return the name and checks fields.
                /// </summary>
                /// <param name="parent">Required. Resource name of the app. Example: `accounts/123/apps/456`</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists reports for the specified app. By default, only the name and results_uri fields are returned.
                /// You can include other fields by listing them in the `fields` URL query parameter. For example,
                /// `?fields=reports(name,checks)` will return the name and checks fields.
                /// </summary>
                public class ListRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaListReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the app. Example: `accounts/123/apps/456`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An [AIP-160](https://google.aip.dev/160) filter string to filter checks within
                    /// reports. Only checks that match the filter string are included in the response. Example: `state
                    /// = FAILED`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("checksFilter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ChecksFilter { get; set; }

                    /// <summary>
                    /// Optional. An [AIP-160](https://google.aip.dev/160) filter string to filter reports. Example:
                    /// `appBundle.releaseType = PRE_RELEASE`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of reports to return. If unspecified, at most 10 reports will be
                    /// returned. The maximum value is 50; values above 50 will be coerced to 50.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token received from a previous `ListReports` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListReports` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/reports";

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
                            Pattern = @"^accounts/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("checksFilter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "checksFilter",
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

            /// <summary>Gets an app.</summary>
            /// <param name="name">Required. Resource name of the app. Example: `accounts/123/apps/456`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an app.</summary>
            public class GetRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.GoogleChecksAccountV1alphaApp>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the app. Example: `accounts/123/apps/456`</summary>
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
                        Pattern = @"^accounts/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the apps under the given account.</summary>
            /// <param name="parent">Required. The parent account. Example: `accounts/123`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists the apps under the given account.</summary>
            public class ListRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.GoogleChecksAccountV1alphaListAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent account. Example: `accounts/123`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of results to return. The server may further constrain the maximum
                /// number of results returned in a single page. If unspecified, the server will decide the number of
                /// results to be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token received from a previous `ListApps` call. Provide this to retrieve the
                /// subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/apps";

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
                        Pattern = @"^accounts/[^/]+$",
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

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Analyzes the uploaded app bundle and returns a google.longrunning.Operation containing the generated Report.
        /// ## Example (upload only) Send a regular POST request with the header `X-Goog-Upload-Protocol: raw`.
        /// ```
        /// POST
        /// https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: raw Content-Length: Content-Type: application/octet-stream
        /// ```
        /// ## Example (upload
        /// with metadata) Send a multipart POST request where the first body part contains the metadata JSON and the
        /// second body part contains the binary upload. Include the header `X-Goog-Upload-Protocol: multipart`.
        /// ```
        /// POST https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: multipart Content-Length: ? Content-Type: multipart/related; boundary=BOUNDARY
        /// --BOUNDARY Content-Type: application/json {"code_reference_id":"db5bcc20f94055fb5bc08cbb9b0e7a5530308786"}
        /// --BOUNDARY --BOUNDARY--
        /// ```
        /// *Note:* Metadata-only requests are not supported.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. Resource name of the app. Example: `accounts/123/apps/456`</param>
        public virtual UploadRequest Upload(Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest body, string parent)
        {
            return new UploadRequest(this.service, body, parent);
        }

        /// <summary>
        /// Analyzes the uploaded app bundle and returns a google.longrunning.Operation containing the generated Report.
        /// ## Example (upload only) Send a regular POST request with the header `X-Goog-Upload-Protocol: raw`.
        /// ```
        /// POST
        /// https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: raw Content-Length: Content-Type: application/octet-stream
        /// ```
        /// ## Example (upload
        /// with metadata) Send a multipart POST request where the first body part contains the metadata JSON and the
        /// second body part contains the binary upload. Include the header `X-Goog-Upload-Protocol: multipart`.
        /// ```
        /// POST https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: multipart Content-Length: ? Content-Type: multipart/related; boundary=BOUNDARY
        /// --BOUNDARY Content-Type: application/json {"code_reference_id":"db5bcc20f94055fb5bc08cbb9b0e7a5530308786"}
        /// --BOUNDARY --BOUNDARY--
        /// ```
        /// *Note:* Metadata-only requests are not supported.
        /// </summary>
        public class UploadRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Operation>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the app. Example: `accounts/123/apps/456`</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/{+parent}/reports:analyzeUpload";

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
                    Pattern = @"^accounts/[^/]+/apps/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Analyzes the uploaded app bundle and returns a google.longrunning.Operation containing the generated Report.
        /// ## Example (upload only) Send a regular POST request with the header `X-Goog-Upload-Protocol: raw`.
        /// ```
        /// POST
        /// https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: raw Content-Length: Content-Type: application/octet-stream
        /// ```
        /// ## Example (upload
        /// with metadata) Send a multipart POST request where the first body part contains the metadata JSON and the
        /// second body part contains the binary upload. Include the header `X-Goog-Upload-Protocol: multipart`.
        /// ```
        /// POST https://checks.googleapis.com/upload/v1alpha/{parent=accounts/*/apps/*}/reports:analyzeUpload HTTP/1.1
        /// X-Goog-Upload-Protocol: multipart Content-Length: ? Content-Type: multipart/related; boundary=BOUNDARY
        /// --BOUNDARY Content-Type: application/json {"code_reference_id":"db5bcc20f94055fb5bc08cbb9b0e7a5530308786"}
        /// --BOUNDARY --BOUNDARY--
        /// ```
        /// *Note:* Metadata-only requests are not supported.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. Resource name of the app. Example: `accounts/123/apps/456`</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest body, string parent, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, parent, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest, Google.Apis.ChecksService.v1alpha.Data.Operation>
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Required. Resource name of the app. Example: `accounts/123/apps/456`</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.ChecksService.v1alpha.Data.GoogleChecksReportV1alphaAnalyzeUploadRequest body, string parent, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1alpha/{+parent}/reports:analyzeUpload"), "POST", stream, contentType)
            {
                Parent = parent;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.ChecksService.v1alpha.Data
{
    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Represents an app in Checks.</summary>
    public class GoogleChecksAccountV1alphaApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the app. Example: `accounts/123/apps/456`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The app's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for AccountService.ListApps.</summary>
    public class GoogleChecksAccountV1alphaListAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<GoogleChecksAccountV1alphaApp> Apps { get; set; }

        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for ReportService.AnalyzeUpload.</summary>
    public class GoogleChecksReportV1alphaAnalyzeUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Git commit hash or changelist number associated with the upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeReferenceId")]
        public virtual string CodeReferenceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the analyzed app bundle.</summary>
    public class GoogleChecksReportV1alphaAppBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique id of the bundle. For example: "com.google.Gmail".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>Git commit hash or changelist number associated with the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeReferenceId")]
        public virtual string CodeReferenceId { get; set; }

        /// <summary>Identifies the type of release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseType")]
        public virtual string ReleaseType { get; set; }

        /// <summary>
        /// The user-visible version of the bundle such as the Android `versionName` or iOS
        /// `CFBundleShortVersionString`. For example: "7.21.1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>
        /// The version used throughout the operating system and store to identify the build such as the Android
        /// `versionCode` or iOS `CFBundleVersion`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionId")]
        public virtual string VersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A check that was run on your app.</summary>
    public class GoogleChecksReportV1alphaCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Regulations and policies that serve as the legal basis for the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citations")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckCitation> Citations { get; set; }

        /// <summary>Evidence that substantiates the check result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evidence")]
        public virtual GoogleChecksReportV1alphaCheckEvidence Evidence { get; set; }

        /// <summary>
        /// Regions that are impacted by the check. For more info, see https://google.aip.dev/143#countries-and-regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>The urgency or risk level of the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The result after running the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Additional information about the check state in relation to past reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual GoogleChecksReportV1alphaCheckStateMetadata StateMetadata { get; set; }

        /// <summary>
        /// The type of check that was run. A type will only appear once in a report's list of checks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Regulation or policy that serves as the legal basis for the check.</summary>
    public class GoogleChecksReportV1alphaCheckCitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Citation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence concerning data security.</summary>
    public class GoogleChecksReportV1alphaCheckDataSecurityEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Evidence related to data in transit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataInTransitInfo")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckDataSecurityEvidenceDataInTransitInfo> DataInTransitInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence related to data in transit detected in your app.</summary>
    public class GoogleChecksReportV1alphaCheckDataSecurityEvidenceDataInTransitInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL contacted by your app. This includes the protocol, domain, and URL parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence concerning a data type that was found in your app.</summary>
    public class GoogleChecksReportV1alphaCheckDataTypeEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type that was found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Evidence collected about the data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeEvidence")]
        public virtual GoogleChecksReportV1alphaDataTypeEvidence DataTypeEvidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence concerning an endpoint that was contacted by your app.</summary>
    public class GoogleChecksReportV1alphaCheckEndpointEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The endpoint that was contacted by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual GoogleChecksReportV1alphaEndpoint Endpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence collected from endpoint restriction violation analysis.</summary>
    public class GoogleChecksReportV1alphaCheckEndpointRestrictionViolationEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Endpoints in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointDetails")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckEndpointRestrictionViolationEvidenceEndpointDetails> EndpointDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the endpoint in violation.</summary>
    public class GoogleChecksReportV1alphaCheckEndpointRestrictionViolationEvidenceEndpointDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The endpoint in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual GoogleChecksReportV1alphaEndpoint Endpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence for a check.</summary>
    public class GoogleChecksReportV1alphaCheckEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Evidence concerning data security.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSecurity")]
        public virtual GoogleChecksReportV1alphaCheckDataSecurityEvidence DataSecurity { get; set; }

        /// <summary>Evidence concerning data types found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypes")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckDataTypeEvidence> DataTypes { get; set; }

        /// <summary>Evidence collected from endpoint restriction violation analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointRestrictionViolations")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckEndpointRestrictionViolationEvidence> EndpointRestrictionViolations { get; set; }

        /// <summary>Evidence concerning endpoints that were contacted by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckEndpointEvidence> Endpoints { get; set; }

        /// <summary>Evidence collected from permission restriction violation analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionRestrictionViolations")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckPermissionRestrictionViolationEvidence> PermissionRestrictionViolations { get; set; }

        /// <summary>Evidence concerning permissions that were found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckPermissionEvidence> Permissions { get; set; }

        /// <summary>Evidence collected from your privacy policy(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyTexts")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckPrivacyPolicyTextEvidence> PrivacyPolicyTexts { get; set; }

        /// <summary>Evidence concerning SDK issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkIssues")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckSdkIssueEvidence> SdkIssues { get; set; }

        /// <summary>Evidence collected from SDK restriction violation analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkRestrictionViolations")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckSdkRestrictionViolationEvidence> SdkRestrictionViolations { get; set; }

        /// <summary>Evidence concerning SDKs that were found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdks")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckSdkEvidence> Sdks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence concerning a permission that was found in your app.</summary>
    public class GoogleChecksReportV1alphaCheckPermissionEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permission that was found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual GoogleChecksReportV1alphaPermission Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence collected from permission restriction violation analysis.</summary>
    public class GoogleChecksReportV1alphaCheckPermissionRestrictionViolationEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permissions in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionDetails")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckPermissionRestrictionViolationEvidencePermissionDetails> PermissionDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the permission in violation.</summary>
    public class GoogleChecksReportV1alphaCheckPermissionRestrictionViolationEvidencePermissionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permission in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual GoogleChecksReportV1alphaPermission Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence collected from your privacy policy(s).</summary>
    public class GoogleChecksReportV1alphaCheckPrivacyPolicyTextEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The privacy policy fragment that was used during the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyFragment")]
        public virtual GoogleChecksReportV1alphaPolicyFragment PolicyFragment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence conerning an SDK that was found in your app.</summary>
    public class GoogleChecksReportV1alphaCheckSdkEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SDK that was found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdk")]
        public virtual GoogleChecksReportV1alphaSdk Sdk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence concerning an SDK issue.</summary>
    public class GoogleChecksReportV1alphaCheckSdkIssueEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SDK with an issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdk")]
        public virtual GoogleChecksReportV1alphaSdk Sdk { get; set; }

        /// <summary>The SDK version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual string SdkVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence collected from SDK restriction violation analysis.</summary>
    public class GoogleChecksReportV1alphaCheckSdkRestrictionViolationEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SDKs in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkDetails")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheckSdkRestrictionViolationEvidenceSdkDetails> SdkDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the SDK in violation.</summary>
    public class GoogleChecksReportV1alphaCheckSdkRestrictionViolationEvidenceSdkDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SDK in violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdk")]
        public virtual GoogleChecksReportV1alphaSdk Sdk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the check state in relation to past reports.</summary>
    public class GoogleChecksReportV1alphaCheckStateMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicators related to the check state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badges")]
        public virtual System.Collections.Generic.IList<string> Badges { get; set; }

        private string _firstFailingTimeRaw;

        private object _firstFailingTime;

        /// <summary>The time when the check first started failing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstFailingTime")]
        public virtual string FirstFailingTimeRaw
        {
            get => _firstFailingTimeRaw;
            set
            {
                _firstFailingTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstFailingTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstFailingTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstFailingTimeDateTimeOffset instead.")]
        public virtual object FirstFailingTime
        {
            get => _firstFailingTime;
            set
            {
                _firstFailingTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstFailingTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstFailingTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstFailingTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstFailingTimeRaw);
            set => FirstFailingTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _lastFailingTimeRaw;

        private object _lastFailingTime;

        /// <summary>The last time the check failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastFailingTime")]
        public virtual string LastFailingTimeRaw
        {
            get => _lastFailingTimeRaw;
            set
            {
                _lastFailingTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastFailingTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastFailingTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastFailingTimeDateTimeOffset instead.")]
        public virtual object LastFailingTime
        {
            get => _lastFailingTime;
            set
            {
                _lastFailingTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastFailingTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastFailingTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastFailingTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastFailingTimeRaw);
            set => LastFailingTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the data monitoring section of the report.</summary>
    public class GoogleChecksReportV1alphaDataMonitoring : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data types that your app shares or collects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypes")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataMonitoringDataTypeResult> DataTypes { get; set; }

        /// <summary>Endpoints that were found by dynamic analysis of your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataMonitoringEndpointResult> Endpoints { get; set; }

        /// <summary>Permissions that your app uses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataMonitoringPermissionResult> Permissions { get; set; }

        /// <summary>SDKs that your app uses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdks")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataMonitoringSdkResult> Sdks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a data type that was found in your app.</summary>
    public class GoogleChecksReportV1alphaDataMonitoringDataTypeResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type that was shared or collected by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Evidence collected about the data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeEvidence")]
        public virtual GoogleChecksReportV1alphaDataTypeEvidence DataTypeEvidence { get; set; }

        /// <summary>Metadata about the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleChecksReportV1alphaDataMonitoringResultMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an endpoint that was contacted by your app.</summary>
    public class GoogleChecksReportV1alphaDataMonitoringEndpointResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The endpoint that was contacted by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual GoogleChecksReportV1alphaEndpoint Endpoint { get; set; }

        /// <summary>The number of times this endpoint was contacted by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hitCount")]
        public virtual System.Nullable<int> HitCount { get; set; }

        /// <summary>Metadata about the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleChecksReportV1alphaDataMonitoringResultMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a permission that was found in your app.</summary>
    public class GoogleChecksReportV1alphaDataMonitoringPermissionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleChecksReportV1alphaDataMonitoringResultMetadata Metadata { get; set; }

        /// <summary>The permission that was found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual GoogleChecksReportV1alphaPermission Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a data monitoring result.</summary>
    public class GoogleChecksReportV1alphaDataMonitoringResultMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Badges that apply to this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badges")]
        public virtual System.Collections.Generic.IList<string> Badges { get; set; }

        private string _firstDetectedTimeRaw;

        private object _firstDetectedTime;

        /// <summary>
        /// The timestamp when this result was first detected within the last 8 weeks. If not set, it wasn't detected
        /// within the last 8 weeks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstDetectedTime")]
        public virtual string FirstDetectedTimeRaw
        {
            get => _firstDetectedTimeRaw;
            set
            {
                _firstDetectedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstDetectedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstDetectedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstDetectedTimeDateTimeOffset instead.")]
        public virtual object FirstDetectedTime
        {
            get => _firstDetectedTime;
            set
            {
                _firstDetectedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstDetectedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstDetectedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstDetectedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstDetectedTimeRaw);
            set => FirstDetectedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Your app's version name when this result was last detected within the last 8 weeks. If not set, it wasn't
        /// detected within the last 8 weeks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDetectedAppVersion")]
        public virtual string LastDetectedAppVersion { get; set; }

        private string _lastDetectedTimeRaw;

        private object _lastDetectedTime;

        /// <summary>
        /// The timestamp when this result was last detected within the last 8 weeks. If not set, it wasn't detected
        /// within the last 8 weeks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDetectedTime")]
        public virtual string LastDetectedTimeRaw
        {
            get => _lastDetectedTimeRaw;
            set
            {
                _lastDetectedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastDetectedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastDetectedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastDetectedTimeDateTimeOffset instead.")]
        public virtual object LastDetectedTime
        {
            get => _lastDetectedTime;
            set
            {
                _lastDetectedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastDetectedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastDetectedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastDetectedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastDetectedTimeRaw);
            set => LastDetectedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an SDK that was found in your app.</summary>
    public class GoogleChecksReportV1alphaDataMonitoringSdkResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleChecksReportV1alphaDataMonitoringResultMetadata Metadata { get; set; }

        /// <summary>The SDK that was found in your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdk")]
        public virtual GoogleChecksReportV1alphaSdk Sdk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence based on an endpoint that data was sent to.</summary>
    public class GoogleChecksReportV1alphaDataTypeEndpointEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set of SDKs that are attributed to the exfiltration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributedSdks")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataTypeEndpointEvidenceAttributedSdk> AttributedSdks { get; set; }

        /// <summary>Endpoints the data type was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointDetails")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataTypeEndpointEvidenceEndpointDetails> EndpointDetails { get; set; }

        /// <summary>Type of data that was exfiltrated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exfiltratedDataType")]
        public virtual string ExfiltratedDataType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of SDK that is attributed to the exfiltration.</summary>
    public class GoogleChecksReportV1alphaDataTypeEndpointEvidenceAttributedSdk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SDK that is attributed to the exfiltration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdk")]
        public virtual GoogleChecksReportV1alphaSdk Sdk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the endpoint the data type was sent to.</summary>
    public class GoogleChecksReportV1alphaDataTypeEndpointEvidenceEndpointDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Endpoint the data type was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual GoogleChecksReportV1alphaEndpoint Endpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence collected about a data type.</summary>
    public class GoogleChecksReportV1alphaDataTypeEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of endpoints the data type was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataTypeEndpointEvidence> Endpoints { get; set; }

        /// <summary>List of included permissions that imply collection of the data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataTypePermissionEvidence> Permissions { get; set; }

        /// <summary>List of privacy policy texts that imply collection of the data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyTexts")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaDataTypePrivacyPolicyTextEvidence> PrivacyPolicyTexts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence based on the inclusion of a permission.</summary>
    public class GoogleChecksReportV1alphaDataTypePermissionEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permission declared by your app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual GoogleChecksReportV1alphaPermission Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Evidence based on information from the privacy policy.</summary>
    public class GoogleChecksReportV1alphaDataTypePrivacyPolicyTextEvidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The privacy policy fragment that implies collection of the data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyFragment")]
        public virtual GoogleChecksReportV1alphaPolicyFragment PolicyFragment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an endpoint.</summary>
    public class GoogleChecksReportV1alphaEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain name (e.g. ads.google.com).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for ReportService.ListReports.</summary>
    public class GoogleChecksReportV1alphaListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The reports for the specified app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaReport> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a permission.</summary>
    public class GoogleChecksReportV1alphaPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permission identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a policy fragment.</summary>
    public class GoogleChecksReportV1alphaPolicyFragment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HTML content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlContent")]
        public virtual string HtmlContent { get; set; }

        /// <summary>Policy URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Privacy report.</summary>
    public class GoogleChecksReportV1alphaReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the analyzed app bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appBundle")]
        public virtual GoogleChecksReportV1alphaAppBundle AppBundle { get; set; }

        /// <summary>List of checks that were run on the app bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checks")]
        public virtual System.Collections.Generic.IList<GoogleChecksReportV1alphaCheck> Checks { get; set; }

        /// <summary>Information related to data monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataMonitoring")]
        public virtual GoogleChecksReportV1alphaDataMonitoring DataMonitoring { get; set; }

        /// <summary>Resource name of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A URL to view results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultsUri")]
        public virtual string ResultsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an SDK.</summary>
    public class GoogleChecksReportV1alphaSdk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SDK identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

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

    /// <summary>The request message for Operations.WaitOperation.</summary>
    public class WaitOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum duration to wait before timing out. If left blank, the wait will be at most the time permitted
        /// by the underlying HTTP/RPC protocol. If RPC context deadline is also specified, the shorter one will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
