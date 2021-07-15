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

namespace Google.Apis.AndroidManagement.v1
{
    /// <summary>The AndroidManagement Service.</summary>
    public class AndroidManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Enterprises = new EnterprisesResource(this);
            SignupUrls = new SignupUrlsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "androidmanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://androidmanagement.googleapis.com/";
        #else
            "https://androidmanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://androidmanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Android Management API.</summary>
        public class Scope
        {
            /// <summary>Manage Android devices and apps for your customers</summary>
            public static string Androidmanagement = "https://www.googleapis.com/auth/androidmanagement";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Android Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage Android devices and apps for your customers</summary>
            public const string Androidmanagement = "https://www.googleapis.com/auth/androidmanagement";
        }

        /// <summary>Gets the Enterprises resource.</summary>
        public virtual EnterprisesResource Enterprises { get; }

        /// <summary>Gets the SignupUrls resource.</summary>
        public virtual SignupUrlsResource SignupUrls { get; }
    }

    /// <summary>A base abstract class for AndroidManagement requests.</summary>
    public abstract class AndroidManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AndroidManagementBaseServiceRequest instance.</summary>
        protected AndroidManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AndroidManagement parameter list.</summary>
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

    /// <summary>The "enterprises" collection of methods.</summary>
    public class EnterprisesResource
    {
        private const string Resource = "enterprises";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EnterprisesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Applications = new ApplicationsResource(service);
            Devices = new DevicesResource(service);
            EnrollmentTokens = new EnrollmentTokensResource(service);
            Policies = new PoliciesResource(service);
            WebApps = new WebAppsResource(service);
            WebTokens = new WebTokensResource(service);
        }

        /// <summary>Gets the Applications resource.</summary>
        public virtual ApplicationsResource Applications { get; }

        /// <summary>The "applications" collection of methods.</summary>
        public class ApplicationsResource
        {
            private const string Resource = "applications";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApplicationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets info about an application.</summary>
            /// <param name="name">
            /// The name of the application in the form enterprises/{enterpriseId}/applications/{package_name}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets info about an application.</summary>
            public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Application>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the application in the form enterprises/{enterpriseId}/applications/{package_name}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The preferred language for localized application info, as a BCP47 tag (e.g. "en-US", "de"). If not
                /// specified the default language of the application will be used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

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
                        Pattern = @"^enterprises/[^/]+/applications/[^/]+$",
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
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
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns google.rpc.Code.UNIMPLEMENTED. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to Code.CANCELLED.
                /// </summary>
                public class CancelRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
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
                            Pattern = @"^enterprises/[^/]+/devices/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns google.rpc.Code.UNIMPLEMENTED.
                /// </summary>
                public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
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
                            Pattern = @"^enterprises/[^/]+/devices/[^/]+/operations/[^/]+$",
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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Operation>
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
                            Pattern = @"^enterprises/[^/]+/devices/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.NOTE: the name binding allows API services to override the binding
                /// to use different resource name schemes, such as users/*/operations. To override the binding, API
                /// services can add a binding such as "/v1/{name=users/*}/operations" to their service configuration.
                /// For backwards compatibility, the default name includes the operations collection id, however
                /// overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^enterprises/[^/]+/devices/[^/]+/operations$",
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

            /// <summary>Deletes a device. This operation wipes the device.</summary>
            /// <param name="name">
            /// The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a device. This operation wipes the device.</summary>
            public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional flags that control the device wiping behavior.</summary>
                [Google.Apis.Util.RequestParameterAttribute("wipeDataFlags", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<WipeDataFlagsEnum> WipeDataFlags { get; set; }

                /// <summary>Optional flags that control the device wiping behavior.</summary>
                public enum WipeDataFlagsEnum
                {
                    /// <summary>This value is ignored.</summary>
                    [Google.Apis.Util.StringValueAttribute("WIPE_DATA_FLAG_UNSPECIFIED")]
                    WIPEDATAFLAGUNSPECIFIED = 0,

                    /// <summary>Preserve the factory reset protection data on the device.</summary>
                    [Google.Apis.Util.StringValueAttribute("PRESERVE_RESET_PROTECTION_DATA")]
                    PRESERVERESETPROTECTIONDATA = 1,

                    /// <summary>Additionally wipe the device's external storage (such as SD cards).</summary>
                    [Google.Apis.Util.StringValueAttribute("WIPE_EXTERNAL_STORAGE")]
                    WIPEEXTERNALSTORAGE = 2,
                }

                /// <summary>
                /// Optional. A short message displayed to the user before wiping the work profile on personal devices.
                /// This has no effect on company owned devices. The maximum message length is 200 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("wipeReasonMessage", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string WipeReasonMessage { get; set; }

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
                        Pattern = @"^enterprises/[^/]+/devices/[^/]+$",
                    });
                    RequestParameters.Add("wipeDataFlags", new Google.Apis.Discovery.Parameter
                    {
                        Name = "wipeDataFlags",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("wipeReasonMessage", new Google.Apis.Discovery.Parameter
                    {
                        Name = "wipeReasonMessage",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a device.</summary>
            /// <param name="name">
            /// The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a device.</summary>
            public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Device>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.</summary>
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
                        Pattern = @"^enterprises/[^/]+/devices/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Issues a command to a device. The Operation resource returned contains a Command in its metadata field.
            /// Use the get operation method to get the status of the command.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.
            /// </param>
            public virtual IssueCommandRequest IssueCommand(Google.Apis.AndroidManagement.v1.Data.Command body, string name)
            {
                return new IssueCommandRequest(service, body, name);
            }

            /// <summary>
            /// Issues a command to a device. The Operation resource returned contains a Command in its metadata field.
            /// Use the get operation method to get the status of the command.
            /// </summary>
            public class IssueCommandRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Operation>
            {
                /// <summary>Constructs a new IssueCommand request.</summary>
                public IssueCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.Command body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.Command Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "issueCommand";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:issueCommand";

                /// <summary>Initializes IssueCommand parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^enterprises/[^/]+/devices/[^/]+$",
                    });
                }
            }

            /// <summary>Lists devices for a given enterprise.</summary>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists devices for a given enterprise.</summary>
            public class ListRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.ListDevicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The requested page size. The actual page size may be fixed to a min or max value.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results returned by the server.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/devices";

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
                        Pattern = @"^enterprises/[^/]+$",
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

            /// <summary>Updates a device.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidManagement.v1.Data.Device body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a device.</summary>
            public class PatchRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Device>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.Device body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The field mask indicating the fields to update. If not set, all modifiable fields will be modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.Device Body { get; set; }

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
                        Pattern = @"^enterprises/[^/]+/devices/[^/]+$",
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

        /// <summary>Gets the EnrollmentTokens resource.</summary>
        public virtual EnrollmentTokensResource EnrollmentTokens { get; }

        /// <summary>The "enrollmentTokens" collection of methods.</summary>
        public class EnrollmentTokensResource
        {
            private const string Resource = "enrollmentTokens";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EnrollmentTokensResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates an enrollment token for a given enterprise.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidManagement.v1.Data.EnrollmentToken body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an enrollment token for a given enterprise.</summary>
            public class CreateRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.EnrollmentToken>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.EnrollmentToken body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.EnrollmentToken Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/enrollmentTokens";

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
                        Pattern = @"^enterprises/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an enrollment token. This operation invalidates the token, preventing its future use.
            /// </summary>
            /// <param name="name">
            /// The name of the enrollment token in the form
            /// enterprises/{enterpriseId}/enrollmentTokens/{enrollmentTokenId}.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an enrollment token. This operation invalidates the token, preventing its future use.
            /// </summary>
            public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the enrollment token in the form
                /// enterprises/{enterpriseId}/enrollmentTokens/{enrollmentTokenId}.
                /// </summary>
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
                        Pattern = @"^enterprises/[^/]+/enrollmentTokens/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Policies resource.</summary>
        public virtual PoliciesResource Policies { get; }

        /// <summary>The "policies" collection of methods.</summary>
        public class PoliciesResource
        {
            private const string Resource = "policies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes a policy. This operation is only permitted if no devices are currently referencing the policy.
            /// </summary>
            /// <param name="name">
            /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a policy. This operation is only permitted if no devices are currently referencing the policy.
            /// </summary>
            public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
                /// </summary>
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
                        Pattern = @"^enterprises/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a policy.</summary>
            /// <param name="name">
            /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a policy.</summary>
            public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Policy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
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
                        Pattern = @"^enterprises/[^/]+/policies/[^/]+$",
                    });
                }
            }

            /// <summary>Lists policies for a given enterprise.</summary>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists policies for a given enterprise.</summary>
            public class ListRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.ListPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The requested page size. The actual page size may be fixed to a min or max value.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results returned by the server.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/policies";

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
                        Pattern = @"^enterprises/[^/]+$",
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

            /// <summary>Updates or creates a policy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidManagement.v1.Data.Policy body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates or creates a policy.</summary>
            public class PatchRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Policy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.Policy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The field mask indicating the fields to update. If not set, all modifiable fields will be modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.Policy Body { get; set; }

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
                        Pattern = @"^enterprises/[^/]+/policies/[^/]+$",
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

        /// <summary>Gets the WebApps resource.</summary>
        public virtual WebAppsResource WebApps { get; }

        /// <summary>The "webApps" collection of methods.</summary>
        public class WebAppsResource
        {
            private const string Resource = "webApps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebAppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a web app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidManagement.v1.Data.WebApp body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a web app.</summary>
            public class CreateRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.WebApp>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.WebApp body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.WebApp Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/webApps";

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
                        Pattern = @"^enterprises/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a web app.</summary>
            /// <param name="name">
            /// The name of the web app in the form enterprises/{enterpriseId}/webApps/{packageName}.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a web app.</summary>
            public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the web app in the form enterprises/{enterpriseId}/webApps/{packageName}.
                /// </summary>
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
                        Pattern = @"^enterprises/[^/]+/webApps/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a web app.</summary>
            /// <param name="name">
            /// The name of the web app in the form enterprises/{enterpriseId}/webApp/{packageName}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a web app.</summary>
            public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.WebApp>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the web app in the form enterprises/{enterpriseId}/webApp/{packageName}.
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
                        Pattern = @"^enterprises/[^/]+/webApps/[^/]+$",
                    });
                }
            }

            /// <summary>Lists web apps for a given enterprise.</summary>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists web apps for a given enterprise.</summary>
            public class ListRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.ListWebAppsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The requested page size. The actual page size may be fixed to a min or max value.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>A token identifying a page of results returned by the server.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/webApps";

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
                        Pattern = @"^enterprises/[^/]+$",
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

            /// <summary>Updates a web app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the web app in the form enterprises/{enterpriseId}/webApps/{packageName}.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidManagement.v1.Data.WebApp body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a web app.</summary>
            public class PatchRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.WebApp>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.WebApp body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the web app in the form enterprises/{enterpriseId}/webApps/{packageName}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The field mask indicating the fields to update. If not set, all modifiable fields will be modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.WebApp Body { get; set; }

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
                        Pattern = @"^enterprises/[^/]+/webApps/[^/]+$",
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

        /// <summary>Gets the WebTokens resource.</summary>
        public virtual WebTokensResource WebTokens { get; }

        /// <summary>The "webTokens" collection of methods.</summary>
        public class WebTokensResource
        {
            private const string Resource = "webTokens";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebTokensResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a web token to access an embeddable managed Google Play web UI for a given enterprise.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidManagement.v1.Data.WebToken body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a web token to access an embeddable managed Google Play web UI for a given enterprise.
            /// </summary>
            public class CreateRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.WebToken>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.WebToken body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidManagement.v1.Data.WebToken Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/webTokens";

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
                        Pattern = @"^enterprises/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Creates an enterprise. This is the last step in the enterprise signup flow.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.AndroidManagement.v1.Data.Enterprise body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates an enterprise. This is the last step in the enterprise signup flow.</summary>
        public class CreateRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.Enterprise body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Whether the enterprise admin has seen and agreed to the managed Google Play Agreement
            /// (https://www.android.com/enterprise/terms/). Always set this to true when creating an EMM-managed
            /// enterprise. Do not create the enterprise until the admin has viewed and accepted the agreement.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("agreementAccepted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AgreementAccepted { get; set; }

            /// <summary>
            /// The enterprise token appended to the callback URL. Only set this when creating a customer-managed
            /// enterprise.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("enterpriseToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EnterpriseToken { get; set; }

            /// <summary>The ID of the Google Cloud Platform project which will own the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }

            /// <summary>
            /// The name of the SignupUrl used to sign up for the enterprise. Only set this when creating a
            /// customer-managed enterprise.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("signupUrlName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SignupUrlName { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidManagement.v1.Data.Enterprise Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/enterprises";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("agreementAccepted", new Google.Apis.Discovery.Parameter
                {
                    Name = "agreementAccepted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enterpriseToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "enterpriseToken",
                    IsRequired = false,
                    ParameterType = "query",
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
                RequestParameters.Add("signupUrlName", new Google.Apis.Discovery.Parameter
                {
                    Name = "signupUrlName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes an enterprise. Only available for EMM-managed enterprises.</summary>
        /// <param name="name">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes an enterprise. Only available for EMM-managed enterprises.</summary>
        public class DeleteRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
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
                    Pattern = @"^enterprises/[^/]+$",
                });
            }
        }

        /// <summary>Gets an enterprise.</summary>
        /// <param name="name">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets an enterprise.</summary>
        public class GetRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
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
                    Pattern = @"^enterprises/[^/]+$",
                });
            }
        }

        /// <summary>Lists EMM-managed enterprises. Only BASIC fields are returned.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists EMM-managed enterprises. Only BASIC fields are returned.</summary>
        public class ListRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.ListEnterprisesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The requested page size. The actual page size may be fixed to a min or max value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token identifying a page of results returned by the server.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. The Cloud project ID of the EMM managing the enterprises.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }

            /// <summary>Specifies which Enterprise fields to return. This method only supports BASIC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Specifies which Enterprise fields to return. This method only supports BASIC.</summary>
            public enum ViewEnum
            {
                /// <summary>The API will default to the BASIC view for the List method.</summary>
                [Google.Apis.Util.StringValueAttribute("ENTERPRISE_VIEW_UNSPECIFIED")]
                ENTERPRISEVIEWUNSPECIFIED = 0,

                /// <summary>Includes name and enterprise_display_name fields.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC = 1,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/enterprises";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
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

        /// <summary>Updates an enterprise.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the enterprise in the form enterprises/{enterpriseId}.</param>
        public virtual PatchRequest Patch(Google.Apis.AndroidManagement.v1.Data.Enterprise body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates an enterprise.</summary>
        public class PatchRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.Enterprise>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidManagement.v1.Data.Enterprise body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the enterprise in the form enterprises/{enterpriseId}.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The field mask indicating the fields to update. If not set, all modifiable fields will be modified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidManagement.v1.Data.Enterprise Body { get; set; }

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
                    Pattern = @"^enterprises/[^/]+$",
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

    /// <summary>The "signupUrls" collection of methods.</summary>
    public class SignupUrlsResource
    {
        private const string Resource = "signupUrls";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SignupUrlsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates an enterprise signup URL.</summary>
        public virtual CreateRequest Create()
        {
            return new CreateRequest(service);
        }

        /// <summary>Creates an enterprise signup URL.</summary>
        public class CreateRequest : AndroidManagementBaseServiceRequest<Google.Apis.AndroidManagement.v1.Data.SignupUrl>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The callback URL that the admin will be redirected to after successfully creating an enterprise. Before
            /// redirecting there the system will add a query parameter to this URL named enterpriseToken which will
            /// contain an opaque token to be used for the create enterprise request. The URL will be parsed then
            /// reformatted in order to add the enterpriseToken parameter, so there may be some minor formatting
            /// changes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("callbackUrl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CallbackUrl { get; set; }

            /// <summary>The ID of the Google Cloud Platform project which will own the enterprise.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ProjectId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/signupUrls";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("callbackUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "callbackUrl",
                    IsRequired = false,
                    ParameterType = "query",
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
namespace Google.Apis.AndroidManagement.v1.Data
{
    /// <summary>
    /// Security policies set to the most secure values by default. To maintain the security posture of a device, we
    /// don't recommend overriding any of the default values.
    /// </summary>
    public class AdvancedSecurityOverrides : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Controls Common Criteria Mode—security standards defined in the Common Criteria for Information Technology
        /// Security Evaluation (https://www.commoncriteriaportal.org/) (CC). Enabling Common Criteria Mode increases
        /// certain security components on a device, including AES-GCM encryption of Bluetooth Long Term Keys, and Wi-Fi
        /// configuration stores.Warning: Common Criteria Mode enforces a strict security model typically only required
        /// for IT products used in national security systems and other highly sensitive organizations. Standard device
        /// use may be affected. Only enabled if required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonCriteriaMode")]
        public virtual string CommonCriteriaMode { get; set; }

        /// <summary>
        /// Controls access to developer settings: developer options and safe boot. Replaces safeBootDisabled
        /// (deprecated) and debuggingFeaturesAllowed (deprecated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerSettings")]
        public virtual string DeveloperSettings { get; set; }

        /// <summary>
        /// Whether Google Play Protect verification (https://support.google.com/accounts/answer/2812853) is enforced.
        /// Replaces ensureVerifyAppsEnabled (deprecated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePlayProtectVerifyApps")]
        public virtual string GooglePlayProtectVerifyApps { get; set; }

        /// <summary>
        /// The policy for untrusted apps (apps from unknown sources) enforced on the device. Replaces
        /// install_unknown_sources_allowed (deprecated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("untrustedAppsPolicy")]
        public virtual string UntrustedAppsPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an always-on VPN connection.</summary>
    public class AlwaysOnVpnPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disallows networking when the VPN is not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockdownEnabled")]
        public virtual System.Nullable<bool> LockdownEnabled { get; set; }

        /// <summary>The package name of the VPN app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A compliance rule condition which is satisfied if the Android Framework API level on the device doesn't meet a
    /// minimum requirement. There can only be one rule with this type of condition per policy.
    /// </summary>
    public class ApiLevelCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum desired Android Framework API level. If the device doesn't meet the minimum requirement, this
        /// condition is satisfied. Must be greater than zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minApiLevel")]
        public virtual System.Nullable<int> MinApiLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Id to name association of a app track.</summary>
    public class AppTrackInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The track name associated with the trackId, set in the Play Console. The name is modifiable from Play
        /// Console.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackAlias")]
        public virtual string TrackAlias { get; set; }

        /// <summary>
        /// The unmodifiable unique track identifier, taken from the releaseTrackId in the URL of the Play Console page
        /// that displays the app’s track information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackId")]
        public virtual string TrackId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an app.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Application tracks visible to the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appTracks")]
        public virtual System.Collections.Generic.IList<AppTrackInfo> AppTracks { get; set; }

        /// <summary>The set of managed properties available to be pre-configured for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedProperties")]
        public virtual System.Collections.Generic.IList<ManagedProperty> ManagedProperties { get; set; }

        /// <summary>The name of the app in the form enterprises/{enterpriseId}/applications/{package_name}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The permissions required by the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<ApplicationPermission> Permissions { get; set; }

        /// <summary>The title of the app. Localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app-related event.</summary>
    public class ApplicationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>App event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A permission required by the app.</summary>
    public class ApplicationPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A longer description of the permission, providing more detail on what it affects. Localized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name of the permission. Localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An opaque string uniquely identifying the permission. Not localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy for an individual app.</summary>
    public class ApplicationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of the app’s track IDs that a device belonging to the enterprise can access. If the list contains
        /// multiple track IDs, devices receive the latest version among all accessible tracks. If the list contains no
        /// track IDs, devices only have access to the app’s production track. More details about each track are
        /// available in AppTrackInfo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibleTrackIds")]
        public virtual System.Collections.Generic.IList<string> AccessibleTrackIds { get; set; }

        /// <summary>Controls the auto-update mode for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpdateMode")]
        public virtual string AutoUpdateMode { get; set; }

        /// <summary>
        /// Controls whether the app can communicate with itself across a device’s work and personal profiles, subject
        /// to user consent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedWorkAndPersonalApp")]
        public virtual string ConnectedWorkAndPersonalApp { get; set; }

        /// <summary>
        /// The default policy for all permissions requested by the app. If specified, this overrides the policy-level
        /// default_permission_policy which applies to all apps. It does not override the permission_grants which
        /// applies to all apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPermissionPolicy")]
        public virtual string DefaultPermissionPolicy { get; set; }

        /// <summary>The scopes delegated to the app from Android Device Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegatedScopes")]
        public virtual System.Collections.Generic.IList<string> DelegatedScopes { get; set; }

        /// <summary>Whether the app is disabled. When disabled, the app data is still preserved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The type of installation to perform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installType")]
        public virtual string InstallType { get; set; }

        /// <summary>
        /// Whether the app is allowed to lock itself in full-screen mode. DEPRECATED. Use InstallType KIOSK or
        /// kioskCustomLauncherEnabled to to configure a dedicated device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockTaskAllowed")]
        public virtual System.Nullable<bool> LockTaskAllowed { get; set; }

        /// <summary>
        /// Managed configuration applied to the app. The format for the configuration is dictated by the
        /// ManagedProperty values supported by the app. Each field name in the managed configuration must match the key
        /// field of the ManagedProperty. The field value must be compatible with the type of the ManagedProperty:
        /// *type* *JSON value* BOOL true or false STRING string INTEGER number CHOICE string MULTISELECT array of
        /// strings HIDDEN string BUNDLE_ARRAY array of objects
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfiguration")]
        public virtual System.Collections.Generic.IDictionary<string, object> ManagedConfiguration { get; set; }

        /// <summary>
        /// The managed configurations template for the app, saved from the managed configurations iframe. This field is
        /// ignored if managed_configuration is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedConfigurationTemplate")]
        public virtual ManagedConfigurationTemplate ManagedConfigurationTemplate { get; set; }

        /// <summary>
        /// The minimum version of the app that runs on the device. If set, the device attempts to update the app to at
        /// least this version code. If the app is not up-to-date, the device will contain a NonComplianceDetail with
        /// non_compliance_reason set to APP_NOT_UPDATED. The app must already be published to Google Play with a
        /// version code greater than or equal to this value. At most 20 apps may specify a minimum version code per
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersionCode")]
        public virtual System.Nullable<int> MinimumVersionCode { get; set; }

        /// <summary>The package name of the app. For example, com.google.android.youtube for the YouTube app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Explicit permission grants or denials for the app. These values override the default_permission_policy and
        /// permission_grants which apply to all apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionGrants")]
        public virtual System.Collections.Generic.IList<PermissionGrant> PermissionGrants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information reported about an installed app.</summary>
    public class ApplicationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationSource")]
        public virtual string ApplicationSource { get; set; }

        /// <summary>The display name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>List of app events. The most recent 20 events are stored in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<ApplicationEvent> Events { get; set; }

        /// <summary>The package name of the app that installed this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installerPackageName")]
        public virtual string InstallerPackageName { get; set; }

        /// <summary>List of keyed app states reported by the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyedAppStates")]
        public virtual System.Collections.Generic.IList<KeyedAppState> KeyedAppStates { get; set; }

        /// <summary>Package name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// The SHA-256 hash of the app's APK file, which can be used to verify the app hasn't been modified. Each byte
        /// of the hash value is represented as a two-digit hexadecimal number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageSha256Hash")]
        public virtual string PackageSha256Hash { get; set; }

        /// <summary>
        /// The SHA-1 hash of each android.content.pm.Signature
        /// (https://developer.android.com/reference/android/content/pm/Signature.html) associated with the app package.
        /// Each byte of each hash value is represented as a two-digit hexadecimal number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingKeyCertFingerprints")]
        public virtual System.Collections.Generic.IList<string> SigningKeyCertFingerprints { get; set; }

        /// <summary>Application state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The app version code, which can be used to determine whether one version is more recent than another.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The app version as displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings controlling the behavior of application reports.</summary>
    public class ApplicationReportingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether removed apps are included in application reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRemovedApps")]
        public virtual System.Nullable<bool> IncludeRemovedApps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An action to block access to apps and data on a fully managed device or in a work profile. This action also
    /// triggers a device or work profile to displays a user-facing notification with information (where possible) on
    /// how to correct the compliance issue. Note: wipeAction must also be specified.
    /// </summary>
    public class BlockAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of days the policy is non-compliant before the device or work profile is blocked. To block access
        /// immediately, set to 0. blockAfterDays must be less than wipeAfterDays.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockAfterDays")]
        public virtual System.Nullable<int> BlockAfterDays { get; set; }

        /// <summary>
        /// Specifies the scope of this BlockAction. Only applicable to devices that are company-owned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockScope")]
        public virtual string BlockScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Controls apps' access to private keys. The rule determines which private key, if any, Android Device Policy
    /// grants to the specified app. Access is granted either when the app calls KeyChain.choosePrivateKeyAlias
    /// (https://developer.android.com/reference/android/security/KeyChain#choosePrivateKeyAlias%28android.app.Activity,%20android.security.KeyChainAliasCallback,%20java.lang.String[],%20java.security.Principal[],%20java.lang.String,%20int,%20java.lang.String%29)
    /// (or any overloads) to request a private key alias for a given URL, or for rules that are not URL-specific (that
    /// is, if urlPattern is not set, or set to the empty string or .*) on Android 11 and above, directly so that the
    /// app can call KeyChain.getPrivateKey
    /// (https://developer.android.com/reference/android/security/KeyChain#getPrivateKey%28android.content.Context,%20java.lang.String%29),
    /// without first having to call KeyChain.choosePrivateKeyAlias.When an app calls KeyChain.choosePrivateKeyAlias if
    /// more than one choosePrivateKeyRules matches, the last matching rule defines which key alias to return.
    /// </summary>
    public class ChoosePrivateKeyRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The package names to which this rule applies. The hash of the signing certificate for each app is verified
        /// against the hash provided by Play. If no package names are specified, then the alias is provided to all apps
        /// that call KeyChain.choosePrivateKeyAlias
        /// (https://developer.android.com/reference/android/security/KeyChain#choosePrivateKeyAlias%28android.app.Activity,%20android.security.KeyChainAliasCallback,%20java.lang.String[],%20java.security.Principal[],%20java.lang.String,%20int,%20java.lang.String%29)
        /// or any overloads (but not without calling KeyChain.choosePrivateKeyAlias, even on Android 11 and above). Any
        /// app with the same Android UID as a package specified here will have access when they call
        /// KeyChain.choosePrivateKeyAlias.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageNames")]
        public virtual System.Collections.Generic.IList<string> PackageNames { get; set; }

        /// <summary>The alias of the private key to be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyAlias")]
        public virtual string PrivateKeyAlias { get; set; }

        /// <summary>
        /// The URL pattern to match against the URL of the request. If not set or empty, it matches all URLs. This uses
        /// the regular expression syntax of java.util.regex.Pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlPattern")]
        public virtual string UrlPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A command.</summary>
    public class Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The timestamp at which the command was created. The timestamp is automatically generated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The duration for which the command is valid. The command will expire if not executed by the device during
        /// this time. The default duration if unspecified is ten minutes. There is no maximum duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// If the command failed, an error code explaining the failure. This is not set when the command is cancelled
        /// by the caller.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>For commands of type RESET_PASSWORD, optionally specifies the new password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPassword")]
        public virtual string NewPassword { get; set; }

        /// <summary>For commands of type RESET_PASSWORD, optionally specifies flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetPasswordFlags")]
        public virtual System.Collections.Generic.IList<string> ResetPasswordFlags { get; set; }

        /// <summary>The type of the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The resource name of the user that owns the device in the form enterprises/{enterpriseId}/users/{userId}.
        /// This is automatically generated by the server based on the device the command is sent to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about Common Criteria Mode—security standards defined in the Common Criteria for Information
    /// Technology Security Evaluation (https://www.commoncriteriaportal.org/) (CC).This information is only available
    /// if statusReportingSettings.commonCriteriaModeEnabled is true in the device's policy.
    /// </summary>
    public class CommonCriteriaModeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Common Criteria Mode is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonCriteriaModeStatus")]
        public virtual string CommonCriteriaModeStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule declaring which mitigating actions to take when a device is not compliant with its policy. For every
    /// rule, there is always an implicit mitigating action to set policy_compliant to false for the Device resource,
    /// and display a message on the device indicating that the device is not compliant with its policy. Other
    /// mitigating actions may optionally be taken as well, depending on the field values in the rule.
    /// </summary>
    public class ComplianceRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A condition which is satisfied if the Android Framework API level on the device doesn't meet a minimum
        /// requirement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiLevelCondition")]
        public virtual ApiLevelCondition ApiLevelCondition { get; set; }

        /// <summary>
        /// If set to true, the rule includes a mitigating action to disable apps so that the device is effectively
        /// disabled, but app data is preserved. If the device is running an app in locked task mode, the app will be
        /// closed and a UI showing the reason for non-compliance will be displayed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableApps")]
        public virtual System.Nullable<bool> DisableApps { get; set; }

        /// <summary>
        /// A condition which is satisfied if there exists any matching NonComplianceDetail for the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonComplianceDetailCondition")]
        public virtual NonComplianceDetailCondition NonComplianceDetailCondition { get; set; }

        /// <summary>
        /// If set, the rule includes a mitigating action to disable apps specified in the list, but app data is
        /// preserved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageNamesToDisable")]
        public virtual System.Collections.Generic.IList<string> PackageNamesToDisable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contact details for LaForge enterprises.</summary>
    public class ContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email address for a point of contact, which will be used to send important announcements related to managed
        /// Google Play.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>The email of the data protection officer. The email is validated but not verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProtectionOfficerEmail")]
        public virtual string DataProtectionOfficerEmail { get; set; }

        /// <summary>The name of the data protection officer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProtectionOfficerName")]
        public virtual string DataProtectionOfficerName { get; set; }

        /// <summary>
        /// The phone number of the data protection officer The phone number is validated but not verified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProtectionOfficerPhone")]
        public virtual string DataProtectionOfficerPhone { get; set; }

        /// <summary>The email of the EU representative. The email is validated but not verified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("euRepresentativeEmail")]
        public virtual string EuRepresentativeEmail { get; set; }

        /// <summary>The name of the EU representative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("euRepresentativeName")]
        public virtual string EuRepresentativeName { get; set; }

        /// <summary>
        /// The phone number of the EU representative. The phone number is validated but not verified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("euRepresentativePhone")]
        public virtual string EuRepresentativePhone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This feature is not generally available.</summary>
    public class ContentProviderEndpoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signingCertsSha256")]
        public virtual System.Collections.Generic.IList<string> SigningCertsSha256 { get; set; }

        /// <summary>This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: A full date, with non-zero year, month, and day values A month and day value, with a zero
    /// year, such as an anniversary A year on its own, with zero month and day values A year and month value, with a
    /// zero day, such as a credit card expiration dateRelated types are google.type.TimeOfDay and
    /// google.protobuf.Timestamp.
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

    /// <summary>
    /// A device owned by an enterprise. Unless otherwise noted, all fields are read-only and can't be modified by
    /// enterprises.devices.patch.
    /// </summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API level of the Android platform version running on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiLevel")]
        public virtual System.Nullable<int> ApiLevel { get; set; }

        /// <summary>
        /// Reports for apps installed on the device. This information is only available when
        /// application_reports_enabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationReports")]
        public virtual System.Collections.Generic.IList<ApplicationReport> ApplicationReports { get; set; }

        /// <summary>
        /// The password requirements currently applied to the device. The applied requirements may be slightly
        /// different from those specified in passwordPolicies in some cases. fieldPath is set based on
        /// passwordPolicies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedPasswordPolicies")]
        public virtual System.Collections.Generic.IList<PasswordRequirements> AppliedPasswordPolicies { get; set; }

        /// <summary>The name of the policy currently applied to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedPolicyName")]
        public virtual string AppliedPolicyName { get; set; }

        /// <summary>The version of the policy currently applied to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedPolicyVersion")]
        public virtual System.Nullable<long> AppliedPolicyVersion { get; set; }

        /// <summary>The state currently applied to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliedState")]
        public virtual string AppliedState { get; set; }

        /// <summary>
        /// Information about Common Criteria Mode—security standards defined in the Common Criteria for Information
        /// Technology Security Evaluation (https://www.commoncriteriaportal.org/) (CC).This information is only
        /// available if statusReportingSettings.commonCriteriaModeEnabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonCriteriaModeInfo")]
        public virtual CommonCriteriaModeInfo CommonCriteriaModeInfo { get; set; }

        /// <summary>
        /// Device settings information. This information is only available if deviceSettingsEnabled is true in the
        /// device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSettings")]
        public virtual DeviceSettings DeviceSettings { get; set; }

        /// <summary>
        /// If the device state is DISABLED, an optional message that is displayed on the device indicating the reason
        /// the device is disabled. This field can be modified by a patch request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledReason")]
        public virtual UserFacingMessage DisabledReason { get; set; }

        /// <summary>
        /// Detailed information about displays on the device. This information is only available if displayInfoEnabled
        /// is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displays")]
        public virtual System.Collections.Generic.IList<Display> Displays { get; set; }

        /// <summary>The time of device enrollment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentTime")]
        public virtual object EnrollmentTime { get; set; }

        /// <summary>
        /// If the device was enrolled with an enrollment token with additional data provided, this field contains that
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentTokenData")]
        public virtual string EnrollmentTokenData { get; set; }

        /// <summary>
        /// If the device was enrolled with an enrollment token, this field contains the name of the token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentTokenName")]
        public virtual string EnrollmentTokenName { get; set; }

        /// <summary>Detailed information about the device hardware.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareInfo")]
        public virtual HardwareInfo HardwareInfo { get; set; }

        /// <summary>
        /// Hardware status samples in chronological order. This information is only available if hardwareStatusEnabled
        /// is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareStatusSamples")]
        public virtual System.Collections.Generic.IList<HardwareStatus> HardwareStatusSamples { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPolicyComplianceReportTime")]
        public virtual object LastPolicyComplianceReportTime { get; set; }

        /// <summary>The last time the device fetched its policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastPolicySyncTime")]
        public virtual object LastPolicySyncTime { get; set; }

        /// <summary>The last time the device sent a status report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStatusReportTime")]
        public virtual object LastStatusReportTime { get; set; }

        /// <summary>
        /// The type of management mode Android Device Policy takes on the device. This influences which policy settings
        /// are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementMode")]
        public virtual string ManagementMode { get; set; }

        /// <summary>
        /// Events related to memory and storage measurements in chronological order. This information is only available
        /// if memoryInfoEnabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryEvents")]
        public virtual System.Collections.Generic.IList<MemoryEvent> MemoryEvents { get; set; }

        /// <summary>
        /// Memory information. This information is only available if memoryInfoEnabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryInfo")]
        public virtual MemoryInfo MemoryInfo { get; set; }

        /// <summary>The name of the device in the form enterprises/{enterpriseId}/devices/{deviceId}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Device network information. This information is only available if networkInfoEnabled is true in the device's
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInfo")]
        public virtual NetworkInfo NetworkInfo { get; set; }

        /// <summary>Details about policy settings that the device is not compliant with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonComplianceDetails")]
        public virtual System.Collections.Generic.IList<NonComplianceDetail> NonComplianceDetails { get; set; }

        /// <summary>Ownership of the managed device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownership")]
        public virtual string Ownership { get; set; }

        /// <summary>Whether the device is compliant with its policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyCompliant")]
        public virtual System.Nullable<bool> PolicyCompliant { get; set; }

        /// <summary>
        /// The name of the policy applied to the device, in the form enterprises/{enterpriseId}/policies/{policyId}. If
        /// not specified, the policy_name for the device's user is applied. This field can be modified by a patch
        /// request. You can specify only the policyId when calling enterprises.devices.patch, as long as the policyId
        /// doesn’t contain any slashes. The rest of the policy name is inferred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyName")]
        public virtual string PolicyName { get; set; }

        /// <summary>
        /// Power management events on the device in chronological order. This information is only available if
        /// powerManagementEventsEnabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerManagementEvents")]
        public virtual System.Collections.Generic.IList<PowerManagementEvent> PowerManagementEvents { get; set; }

        /// <summary>
        /// If the same physical device has been enrolled multiple times, this field contains its previous device names.
        /// The serial number is used as the unique identifier to determine if the same physical device has enrolled
        /// previously. The names are in chronological order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousDeviceNames")]
        public virtual System.Collections.Generic.IList<string> PreviousDeviceNames { get; set; }

        /// <summary>Device's security posture value that reflects how secure the device is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPosture")]
        public virtual SecurityPosture SecurityPosture { get; set; }

        /// <summary>
        /// Detailed information about the device software. This information is only available if softwareInfoEnabled is
        /// true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareInfo")]
        public virtual SoftwareInfo SoftwareInfo { get; set; }

        /// <summary>
        /// The state to be applied to the device. This field can be modified by a patch request. Note that when calling
        /// enterprises.devices.patch, ACTIVE and DISABLED are the only allowable values. To enter the device into a
        /// DELETED state, call enterprises.devices.delete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Map of selected system properties name and value related to the device. This information is only available
        /// if systemPropertiesEnabled is true in the device's policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemProperties")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemProperties { get; set; }

        /// <summary>The user who owns the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>
        /// The resource name of the user that owns this device in the form enterprises/{enterpriseId}/users/{userId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about security related device settings on device.</summary>
    public class DeviceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether ADB (https://developer.android.com/studio/command-line/adb.html) is enabled on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adbEnabled")]
        public virtual System.Nullable<bool> AdbEnabled { get; set; }

        /// <summary>Whether developer mode is enabled on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developmentSettingsEnabled")]
        public virtual System.Nullable<bool> DevelopmentSettingsEnabled { get; set; }

        /// <summary>Encryption status from DevicePolicyManager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionStatus")]
        public virtual string EncryptionStatus { get; set; }

        /// <summary>Whether the device is secured with PIN/password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDeviceSecure")]
        public virtual System.Nullable<bool> IsDeviceSecure { get; set; }

        /// <summary>Whether the storage encryption is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEncrypted")]
        public virtual System.Nullable<bool> IsEncrypted { get; set; }

        /// <summary>Whether installing apps from unknown sources is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownSourcesEnabled")]
        public virtual System.Nullable<bool> UnknownSourcesEnabled { get; set; }

        /// <summary>
        /// Whether Google Play Protect verification (https://support.google.com/accounts/answer/2812853) is enforced on
        /// the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifyAppsEnabled")]
        public virtual System.Nullable<bool> VerifyAppsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device display information.</summary>
    public class Display : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display density expressed as dots-per-inch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("density")]
        public virtual System.Nullable<int> Density { get; set; }

        /// <summary>Unique display id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayId")]
        public virtual System.Nullable<int> DisplayId { get; set; }

        /// <summary>Display height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Name of the display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Refresh rate of the display in frames per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshRate")]
        public virtual System.Nullable<int> RefreshRate { get; set; }

        /// <summary>State of the display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Display width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for Empty is empty JSON
    /// object {}.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An enrollment token.</summary>
    public class EnrollmentToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional, arbitrary data associated with the enrollment token. This could contain, for example, the ID of an
        /// org unit the device is assigned to after enrollment. After a device enrolls with the token, this data will
        /// be exposed in the enrollment_token_data field of the Device resource. The data must be 1024 characters or
        /// less; otherwise, the creation request will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalData")]
        public virtual string AdditionalData { get; set; }

        /// <summary>
        /// Controls whether personal usage is allowed on a device provisioned with this enrollment token.For
        /// company-owned devices: Enabling personal usage allows the user to set up a work profile on the device.
        /// Disabling personal usage requires the user provision the device as a fully managed device.For
        /// personally-owned devices: Enabling personal usage allows the user to set up a work profile on the device.
        /// Disabling personal usage will prevent the device from provisioning. Personal usage cannot be disabled on
        /// personally-owned device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPersonalUsage")]
        public virtual string AllowPersonalUsage { get; set; }

        /// <summary>
        /// The length of time the enrollment token is valid, ranging from 1 minute to 90 days. If not specified, the
        /// default duration is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The expiration time of the token. This is a read-only field generated by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTimestamp")]
        public virtual object ExpirationTimestamp { get; set; }

        /// <summary>
        /// The name of the enrollment token, which is generated by the server during creation, in the form
        /// enterprises/{enterpriseId}/enrollmentTokens/{enrollmentTokenId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Whether the enrollment token is for one time use only. If the flag is set to true, only one device can use
        /// it for registration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeOnly")]
        public virtual System.Nullable<bool> OneTimeOnly { get; set; }

        /// <summary>
        /// The name of the policy initially applied to the enrolled device, in the form
        /// enterprises/{enterpriseId}/policies/{policyId}. If not specified, the policy_name for the device’s user is
        /// applied. If user_name is also not specified, enterprises/{enterpriseId}/policies/default is applied by
        /// default. When updating this field, you can specify only the policyId as long as the policyId doesn’t contain
        /// any slashes. The rest of the policy name will be inferred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyName")]
        public virtual string PolicyName { get; set; }

        /// <summary>
        /// A JSON string whose UTF-8 representation can be used to generate a QR code to enroll a device with this
        /// enrollment token. To enroll a device using NFC, the NFC record must contain a serialized
        /// java.util.Properties representation of the properties in the JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qrCode")]
        public virtual string QrCode { get; set; }

        /// <summary>
        /// The user associated with this enrollment token. If it's specified when the enrollment token is created and
        /// the user does not exist, the user will be created. This field must not contain personally identifiable
        /// information. Only the account_identifier field needs to be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>
        /// The token value that's passed to the device and authorizes the device to enroll. This is a read-only field
        /// generated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration applied to an enterprise.</summary>
    public class Enterprise : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated and unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appAutoApprovalEnabled")]
        public virtual System.Nullable<bool> AppAutoApprovalEnabled { get; set; }

        /// <summary>The enterprise contact info of an EMM-managed enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactInfo")]
        public virtual ContactInfo ContactInfo { get; set; }

        /// <summary>The types of Google Pub/Sub notifications enabled for the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledNotificationTypes")]
        public virtual System.Collections.Generic.IList<string> EnabledNotificationTypes { get; set; }

        /// <summary>The name of the enterprise displayed to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterpriseDisplayName")]
        public virtual string EnterpriseDisplayName { get; set; }

        /// <summary>
        /// An image displayed as a logo during device provisioning. Supported types are: image/bmp, image/gif,
        /// image/x-ico, image/jpeg, image/png, image/webp, image/vnd.wap.wbmp, image/x-adobe-dng.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual ExternalData Logo { get; set; }

        /// <summary>
        /// The name of the enterprise which is generated by the server during creation, in the form
        /// enterprises/{enterpriseId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A color in RGB format that indicates the predominant color to display in the device management app UI. The
        /// color components are stored as follows: (red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue, where
        /// the value of each component is between 0 and 255, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryColor")]
        public virtual System.Nullable<int> PrimaryColor { get; set; }

        /// <summary>
        /// The topic that Cloud Pub/Sub notifications are published to, in the form projects/{project}/topics/{topic}.
        /// This field is only required if Pub/Sub notifications are enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>Sign-in details of the enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signinDetails")]
        public virtual System.Collections.Generic.IList<SigninDetail> SigninDetails { get; set; }

        /// <summary>
        /// Terms and conditions that must be accepted when provisioning a device for this enterprise. A page of terms
        /// is generated for each value in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsAndConditions")]
        public virtual System.Collections.Generic.IList<TermsAndConditions> TermsAndConditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data hosted at an external location. The data is to be downloaded by Android Device Policy and verified against
    /// the hash.
    /// </summary>
    public class ExternalData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The base-64 encoded SHA-256 hash of the content hosted at url. If the content doesn't match this hash,
        /// Android Device Policy won't use the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary>
        /// The absolute URL to the data, which must use either the http or https scheme. Android Device Policy doesn't
        /// provide any credentials in the GET request, so the URL must be publicly accessible. Including a long, random
        /// component in the URL may be used to prevent attackers from discovering the URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A system freeze period. When a device’s clock is within the freeze period, all incoming system updates
    /// (including security patches) are blocked and won’t be installed. When a device is outside the freeze period,
    /// normal update behavior applies. Leap years are ignored in freeze period calculations, in particular: * If Feb.
    /// 29th is set as the start or end date of a freeze period, the freeze period will start or end on Feb. 28th
    /// instead. * When a device’s system clock reads Feb. 29th, it’s treated as Feb. 28th. * When calculating the
    /// number of days in a freeze period or the time between two freeze periods, Feb. 29th is ignored and not counted
    /// as a day.
    /// </summary>
    public class FreezePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The end date (inclusive) of the freeze period. Must be no later than 90 days from the start date. If the end
        /// date is earlier than the start date, the freeze period is considered wrapping year-end. Note: year must not
        /// be set. For example, {"month": 1,"date": 30}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// The start date (inclusive) of the freeze period. Note: year must not be set. For example, {"month":
        /// 1,"date": 30}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about device hardware. The fields related to temperature thresholds are only available if
    /// hardwareStatusEnabled is true in the device's policy.
    /// </summary>
    public class HardwareInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Battery shutdown temperature thresholds in Celsius for each battery on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryShutdownTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> BatteryShutdownTemperatures { get; set; }

        /// <summary>Battery throttling temperature thresholds in Celsius for each battery on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryThrottlingTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> BatteryThrottlingTemperatures { get; set; }

        /// <summary>Brand of the device. For example, Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>CPU shutdown temperature thresholds in Celsius for each CPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuShutdownTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> CpuShutdownTemperatures { get; set; }

        /// <summary>CPU throttling temperature thresholds in Celsius for each CPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuThrottlingTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> CpuThrottlingTemperatures { get; set; }

        /// <summary>Baseband version. For example, MDM9625_104662.22.05.34p.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceBasebandVersion")]
        public virtual string DeviceBasebandVersion { get; set; }

        /// <summary>GPU shutdown temperature thresholds in Celsius for each GPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuShutdownTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> GpuShutdownTemperatures { get; set; }

        /// <summary>GPU throttling temperature thresholds in Celsius for each GPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuThrottlingTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> GpuThrottlingTemperatures { get; set; }

        /// <summary>Name of the hardware. For example, Angler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardware")]
        public virtual string Hardware { get; set; }

        /// <summary>Manufacturer. For example, Motorola.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>The model of the device. For example, Asus Nexus 7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The device serial number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>Device skin shutdown temperature thresholds in Celsius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skinShutdownTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> SkinShutdownTemperatures { get; set; }

        /// <summary>Device skin throttling temperature thresholds in Celsius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skinThrottlingTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> SkinThrottlingTemperatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Hardware status. Temperatures may be compared to the temperature thresholds available in hardwareInfo to
    /// determine hardware health.
    /// </summary>
    public class HardwareStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current battery temperatures in Celsius for each battery on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> BatteryTemperatures { get; set; }

        /// <summary>Current CPU temperatures in Celsius for each CPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> CpuTemperatures { get; set; }

        /// <summary>
        /// CPU usages in percentage for each core available on the device. Usage is 0 for each unplugged core. Empty
        /// array implies that CPU usage is not supported in the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUsages")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> CpuUsages { get; set; }

        /// <summary>The time the measurements were taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Fan speeds in RPM for each fan on the device. Empty array means that there are no fans or fan speed is not
        /// supported on the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fanSpeeds")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> FanSpeeds { get; set; }

        /// <summary>Current GPU temperatures in Celsius for each GPU on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> GpuTemperatures { get; set; }

        /// <summary>Current device skin temperatures in Celsius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skinTemperatures")]
        public virtual System.Collections.Generic.IList<System.Nullable<float>> SkinTemperatures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response on issuing a command. This is currently empty as a placeholder.</summary>
    public class IssueCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Keyed app state reported by the app.</summary>
    public class KeyedAppState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of the app state on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optionally, a machine-readable value to be read by the EMM. For example, setting values that the admin can
        /// choose to query against in the EMM console (e.g. “notify me if the battery_warning data &amp;lt; 10”).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// The key for the app state. Acts as a point of reference for what the app is providing state for. For
        /// example, when providing managed configuration feedback, this key could be the managed configuration key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The time the app state was most recently updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>
        /// Optionally, a free-form message string to explain the app state. If the state was triggered by a particular
        /// value (e.g. a managed configuration value), it should be included in the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The severity of the app state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings controlling the behavior of a device in kiosk mode. To enable kiosk mode, set
    /// kioskCustomLauncherEnabled to true or specify an app in the policy with installType KIOSK.
    /// </summary>
    public class KioskCustomization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies whether the Settings app is allowed in kiosk mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSettings")]
        public virtual string DeviceSettings { get; set; }

        /// <summary>
        /// Sets the behavior of a device in kiosk mode when a user presses and holds (long-presses) the Power button.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerButtonActions")]
        public virtual string PowerButtonActions { get; set; }

        /// <summary>Specifies whether system info and notifications are disabled in kiosk mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusBar")]
        public virtual string StatusBar { get; set; }

        /// <summary>
        /// Specifies whether system error dialogs for crashed or unresponsive apps are blocked in kiosk mode. When
        /// blocked, the system will force-stop the app as if the user chooses the "close app" option on the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemErrorWarnings")]
        public virtual string SystemErrorWarnings { get; set; }

        /// <summary>
        /// Specifies which navigation features are enabled (e.g. Home, Overview buttons) in kiosk mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemNavigation")]
        public virtual string SystemNavigation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An action to launch an app.</summary>
    public class LaunchAppAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Package name of app to be launched</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a request to list devices for a given enterprise.</summary>
    public class ListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>If there are more results, a token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a request to list enterprises.</summary>
    public class ListEnterprisesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of enterprises.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enterprises")]
        public virtual System.Collections.Generic.IList<Enterprise> Enterprises { get; set; }

        /// <summary>If there are more results, a token to retrieve next page of results.</summary>
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

    /// <summary>Response to a request to list policies for a given enterprise.</summary>
    public class ListPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If there are more results, a token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<Policy> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a request to list web apps for a given enterprise.</summary>
    public class ListWebAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If there are more results, a token to retrieve next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of web apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webApps")]
        public virtual System.Collections.Generic.IList<WebApp> WebApps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The managed configurations template for the app, saved from the managed configurations iframe.
    /// </summary>
    public class ManagedConfigurationTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional, a map containing configuration variables defined for the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConfigurationVariables { get; set; }

        /// <summary>The ID of the managed configurations template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual string TemplateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Managed property.</summary>
    public class ManagedProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The default value of the property. BUNDLE_ARRAY properties don't have a default value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>
        /// A longer description of the property, providing more detail of what it affects. Localized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>For CHOICE or MULTISELECT properties, the list of possible entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<ManagedPropertyEntry> Entries { get; set; }

        /// <summary>
        /// The unique key that the app uses to identify the property, e.g. "com.google.android.gm.fieldname".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// For BUNDLE_ARRAY properties, the list of nested properties. A BUNDLE_ARRAY property is at most two levels
        /// deep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nestedProperties")]
        public virtual System.Collections.Generic.IList<ManagedProperty> NestedProperties { get; set; }

        /// <summary>The name of the property. Localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The type of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entry of a managed property.</summary>
    public class ManagedPropertyEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the value. Localized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The machine-readable value of the entry, which should be used in the configuration. Not localized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event related to memory and storage measurements.</summary>
    public class MemoryEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of free bytes in the medium, or for EXTERNAL_STORAGE_DETECTED, the total capacity in bytes of the
        /// storage medium.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteCount")]
        public virtual System.Nullable<long> ByteCount { get; set; }

        /// <summary>The creation time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about device memory and storage.</summary>
    public class MemoryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total internal storage on device in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalInternalStorage")]
        public virtual System.Nullable<long> TotalInternalStorage { get; set; }

        /// <summary>Total RAM on device in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRam")]
        public virtual System.Nullable<long> TotalRam { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Device network info.</summary>
    public class NetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IMEI number of the GSM device. For example, A1000031212.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>MEID number of the CDMA device. For example, A00000292788E1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>Alphabetic name of current registered operator. For example, Vodafone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperatorName")]
        public virtual string NetworkOperatorName { get; set; }

        /// <summary>
        /// Provides telephony information associated with each SIM card on the device. Only supported on fully managed
        /// devices starting from Android API level 23.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telephonyInfos")]
        public virtual System.Collections.Generic.IList<TelephonyInfo> TelephonyInfos { get; set; }

        /// <summary>Wi-Fi MAC address of the device. For example, 7c:11:11:11:11:11.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddress")]
        public virtual string WifiMacAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides detail about non-compliance with a policy setting.</summary>
    public class NonComplianceDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the policy setting could not be applied, the current value of the setting on the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentValue")]
        public virtual object CurrentValue { get; set; }

        /// <summary>
        /// For settings with nested fields, if a particular nested field is out of compliance, this specifies the full
        /// path to the offending field. The path is formatted in the same way the policy JSON field would be referenced
        /// in JavaScript, that is: 1) For object-typed fields, the field name is followed by a dot then by a subfield
        /// name. 2) For array-typed fields, the field name is followed by the array index enclosed in brackets. For
        /// example, to indicate a problem with the url field in the externalData field in the 3rd application, the path
        /// would be applications[2].externalData.url
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldPath")]
        public virtual string FieldPath { get; set; }

        /// <summary>
        /// If package_name is set and the non-compliance reason is APP_NOT_INSTALLED or APP_NOT_UPDATED, the detailed
        /// reason the app can't be installed or updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationFailureReason")]
        public virtual string InstallationFailureReason { get; set; }

        /// <summary>The reason the device is not in compliance with the setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonComplianceReason")]
        public virtual string NonComplianceReason { get; set; }

        /// <summary>The package name indicating which app is out of compliance, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The name of the policy setting. This is the JSON field name of a top-level Policy field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingName")]
        public virtual string SettingName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A compliance rule condition which is satisfied if there exists any matching NonComplianceDetail for the device.
    /// A NonComplianceDetail matches a NonComplianceDetailCondition if all the fields which are set within the
    /// NonComplianceDetailCondition match the corresponding NonComplianceDetail fields.
    /// </summary>
    public class NonComplianceDetailCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reason the device is not in compliance with the setting. If not set, then this condition matches any
        /// reason.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonComplianceReason")]
        public virtual string NonComplianceReason { get; set; }

        /// <summary>
        /// The package name of the app that's out of compliance. If not set, then this condition matches any package
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// The name of the policy setting. This is the JSON field name of a top-level Policy field. If not set, then
        /// this condition matches any setting name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingName")]
        public virtual string SettingName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This feature is not generally available.</summary>
    public class OncCertificateProvider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateReferences")]
        public virtual System.Collections.Generic.IList<string> CertificateReferences { get; set; }

        /// <summary>This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentProviderEndpoint")]
        public virtual ContentProviderEndpoint ContentProviderEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is false, it means the operation is still in progress. If true, the operation is completed, and
        /// either error or response is available.
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
        /// use the default HTTP mapping, the name should be a resource name ending with operations/{unique_id}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update,
        /// the response should be the resource. For other methods, the response should have the type XxxResponse, where
        /// Xxx is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of package names.</summary>
    public class PackageNameList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of package names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageNames")]
        public virtual System.Collections.Generic.IList<string> PackageNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Requirements for the password used to unlock a device.</summary>
    public class PasswordRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of incorrect device-unlock passwords that can be entered before a device is wiped. A value of 0 means
        /// there is no restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumFailedPasswordsForWipe")]
        public virtual System.Nullable<int> MaximumFailedPasswordsForWipe { get; set; }

        /// <summary>Password expiration timeout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordExpirationTimeout")]
        public virtual object PasswordExpirationTimeout { get; set; }

        /// <summary>
        /// The length of the password history. After setting this field, the user won't be able to enter a new password
        /// that is the same as any password in the history. A value of 0 means there is no restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordHistoryLength")]
        public virtual System.Nullable<int> PasswordHistoryLength { get; set; }

        /// <summary>
        /// The minimum allowed password length. A value of 0 means there is no restriction. Only enforced when
        /// password_quality is NUMERIC, NUMERIC_COMPLEX, ALPHABETIC, ALPHANUMERIC, or COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumLength")]
        public virtual System.Nullable<int> PasswordMinimumLength { get; set; }

        /// <summary>
        /// Minimum number of letters required in the password. Only enforced when password_quality is COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumLetters")]
        public virtual System.Nullable<int> PasswordMinimumLetters { get; set; }

        /// <summary>
        /// Minimum number of lower case letters required in the password. Only enforced when password_quality is
        /// COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumLowerCase")]
        public virtual System.Nullable<int> PasswordMinimumLowerCase { get; set; }

        /// <summary>
        /// Minimum number of non-letter characters (numerical digits or symbols) required in the password. Only
        /// enforced when password_quality is COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumNonLetter")]
        public virtual System.Nullable<int> PasswordMinimumNonLetter { get; set; }

        /// <summary>
        /// Minimum number of numerical digits required in the password. Only enforced when password_quality is COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumNumeric")]
        public virtual System.Nullable<int> PasswordMinimumNumeric { get; set; }

        /// <summary>
        /// Minimum number of symbols required in the password. Only enforced when password_quality is COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumSymbols")]
        public virtual System.Nullable<int> PasswordMinimumSymbols { get; set; }

        /// <summary>
        /// Minimum number of upper case letters required in the password. Only enforced when password_quality is
        /// COMPLEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordMinimumUpperCase")]
        public virtual System.Nullable<int> PasswordMinimumUpperCase { get; set; }

        /// <summary>The required password quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordQuality")]
        public virtual string PasswordQuality { get; set; }

        /// <summary>The scope that the password requirement applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordScope")]
        public virtual string PasswordScope { get; set; }

        /// <summary>
        /// The length of time after a device or work profile is unlocked using a strong form of authentication
        /// (password, PIN, pattern) that it can be unlocked using any other authentication method (e.g. fingerprint,
        /// trust agents, face). After the specified time period elapses, only strong forms of authentication can be
        /// used to unlock the device or work profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirePasswordUnlock")]
        public virtual string RequirePasswordUnlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an Android permission and its grant state.</summary>
    public class PermissionGrant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Android permission or group, e.g. android.permission.READ_CALENDAR or android.permission_group.CALENDAR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The policy for granting the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A default activity for handling intents that match a particular intent filter. Note: To set up a kiosk, use
    /// InstallType to KIOSK rather than use persistent preferred activities.
    /// </summary>
    public class PersistentPreferredActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The intent actions to match in the filter. If any actions are included in the filter, then an intent's
        /// action must be one of those values for it to match. If no actions are included, the intent action is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>
        /// The intent categories to match in the filter. An intent includes the categories that it requires, all of
        /// which must be included in the filter in order to match. In other words, adding a category to the filter has
        /// no impact on matching unless that category is specified in the intent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// The activity that should be the default intent handler. This should be an Android component name, e.g.
        /// com.android.enterprise.app/.MainActivity. Alternatively, the value may be the package name of an app, which
        /// causes Android Device Policy to choose an appropriate activity from the app to handle the intent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receiverActivity")]
        public virtual string ReceiverActivity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policies for apps in the personal profile of a company-owned device with a work profile.</summary>
    public class PersonalApplicationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of installation to perform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installType")]
        public virtual string InstallType { get; set; }

        /// <summary>The package name of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policies controlling personal usage on a company-owned device with a work profile.</summary>
    public class PersonalUsagePolicies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account types that can't be managed by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTypesWithManagementDisabled")]
        public virtual System.Collections.Generic.IList<string> AccountTypesWithManagementDisabled { get; set; }

        /// <summary>Whether camera is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cameraDisabled")]
        public virtual System.Nullable<bool> CameraDisabled { get; set; }

        /// <summary>Controls how long the work profile can stay off. The duration must be at least 3 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDaysWithWorkOff")]
        public virtual System.Nullable<int> MaxDaysWithWorkOff { get; set; }

        /// <summary>Policy applied to applications in the personal profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalApplications")]
        public virtual System.Collections.Generic.IList<PersonalApplicationPolicy> PersonalApplications { get; set; }

        /// <summary>
        /// Used together with personalApplications to control how apps in the personal profile are allowed or blocked.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalPlayStoreMode")]
        public virtual string PersonalPlayStoreMode { get; set; }

        /// <summary>Whether screen capture is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenCaptureDisabled")]
        public virtual System.Nullable<bool> ScreenCaptureDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A policy resource represents a group of settings that govern the behavior of a managed device and the apps
    /// installed on it.
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account types that can't be managed by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountTypesWithManagementDisabled")]
        public virtual System.Collections.Generic.IList<string> AccountTypesWithManagementDisabled { get; set; }

        /// <summary>Whether adding new users and profiles is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addUserDisabled")]
        public virtual System.Nullable<bool> AddUserDisabled { get; set; }

        /// <summary>Whether adjusting the master volume is disabled. Also mutes the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adjustVolumeDisabled")]
        public virtual System.Nullable<bool> AdjustVolumeDisabled { get; set; }

        /// <summary>
        /// Security policies set to the most secure values by default. To maintain the security posture of a device, we
        /// don't recommend overriding any of the default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedSecurityOverrides")]
        public virtual AdvancedSecurityOverrides AdvancedSecurityOverrides { get; set; }

        /// <summary>
        /// Configuration for an always-on VPN connection. Use with vpn_config_disabled to prevent modification of this
        /// setting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysOnVpnPackage")]
        public virtual AlwaysOnVpnPackage AlwaysOnVpnPackage { get; set; }

        /// <summary>
        /// The app tracks for Android Device Policy the device can access. The device receives the latest version among
        /// all accessible tracks. If no tracks are specified, then the device only uses the production track.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDevicePolicyTracks")]
        public virtual System.Collections.Generic.IList<string> AndroidDevicePolicyTracks { get; set; }

        /// <summary>
        /// Deprecated. Use autoUpdateMode instead.When autoUpdateMode is set to AUTO_UPDATE_POSTPONED or
        /// AUTO_UPDATE_HIGH_PRIORITY, this field has no effect.The app auto update policy, which controls when
        /// automatic app updates can be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appAutoUpdatePolicy")]
        public virtual string AppAutoUpdatePolicy { get; set; }

        /// <summary>Policy applied to apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<ApplicationPolicy> Applications { get; set; }

        /// <summary>
        /// Whether auto date, time, and time zone are enabled on a company-owned device. If this is set, then
        /// autoTimeRequired is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoDateAndTimeZone")]
        public virtual string AutoDateAndTimeZone { get; set; }

        /// <summary>
        /// Whether auto time is required, which prevents the user from manually setting the date and time. If
        /// autoDateAndTimeZone is set, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoTimeRequired")]
        public virtual System.Nullable<bool> AutoTimeRequired { get; set; }

        /// <summary>
        /// Whether applications other than the ones configured in applications are blocked from being installed. When
        /// set, applications that were installed under a previous policy but no longer appear in the policy are
        /// automatically uninstalled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockApplicationsEnabled")]
        public virtual System.Nullable<bool> BlockApplicationsEnabled { get; set; }

        /// <summary>Whether configuring bluetooth is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bluetoothConfigDisabled")]
        public virtual System.Nullable<bool> BluetoothConfigDisabled { get; set; }

        /// <summary>Whether bluetooth contact sharing is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bluetoothContactSharingDisabled")]
        public virtual System.Nullable<bool> BluetoothContactSharingDisabled { get; set; }

        /// <summary>
        /// Whether bluetooth is disabled. Prefer this setting over bluetooth_config_disabled because
        /// bluetooth_config_disabled can be bypassed by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bluetoothDisabled")]
        public virtual System.Nullable<bool> BluetoothDisabled { get; set; }

        /// <summary>Whether all cameras on the device are disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cameraDisabled")]
        public virtual System.Nullable<bool> CameraDisabled { get; set; }

        /// <summary>Whether configuring cell broadcast is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellBroadcastsConfigDisabled")]
        public virtual System.Nullable<bool> CellBroadcastsConfigDisabled { get; set; }

        /// <summary>Rules for determining apps' access to private keys. See ChoosePrivateKeyRule for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choosePrivateKeyRules")]
        public virtual System.Collections.Generic.IList<ChoosePrivateKeyRule> ChoosePrivateKeyRules { get; set; }

        /// <summary>
        /// Rules declaring which mitigating actions to take when a device is not compliant with its policy. When the
        /// conditions for multiple rules are satisfied, all of the mitigating actions for the rules are taken. There is
        /// a maximum limit of 100 rules. Use policy enforcement rules instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceRules")]
        public virtual System.Collections.Generic.IList<ComplianceRule> ComplianceRules { get; set; }

        /// <summary>Whether creating windows besides app windows is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createWindowsDisabled")]
        public virtual System.Nullable<bool> CreateWindowsDisabled { get; set; }

        /// <summary>Whether configuring user credentials is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialsConfigDisabled")]
        public virtual System.Nullable<bool> CredentialsConfigDisabled { get; set; }

        /// <summary>Whether roaming data services are disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRoamingDisabled")]
        public virtual System.Nullable<bool> DataRoamingDisabled { get; set; }

        /// <summary>Whether the user is allowed to enable debugging features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debuggingFeaturesAllowed")]
        public virtual System.Nullable<bool> DebuggingFeaturesAllowed { get; set; }

        /// <summary>The default permission policy for runtime permission requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPermissionPolicy")]
        public virtual string DefaultPermissionPolicy { get; set; }

        /// <summary>The device owner information to be shown on the lock screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceOwnerLockScreenInfo")]
        public virtual UserFacingMessage DeviceOwnerLockScreenInfo { get; set; }

        /// <summary>Whether encryption is enabled</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionPolicy")]
        public virtual string EncryptionPolicy { get; set; }

        /// <summary>Whether app verification is force-enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ensureVerifyAppsEnabled")]
        public virtual System.Nullable<bool> EnsureVerifyAppsEnabled { get; set; }

        /// <summary>Whether factory resetting from settings is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("factoryResetDisabled")]
        public virtual System.Nullable<bool> FactoryResetDisabled { get; set; }

        /// <summary>
        /// Email addresses of device administrators for factory reset protection. When the device is factory reset, it
        /// will require one of these admins to log in with the Google account email and password to unlock the device.
        /// If no admins are specified, the device won't provide factory reset protection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frpAdminEmails")]
        public virtual System.Collections.Generic.IList<string> FrpAdminEmails { get; set; }

        /// <summary>
        /// Whether the user is allowed to have fun. Controls whether the Easter egg game in Settings is disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("funDisabled")]
        public virtual System.Nullable<bool> FunDisabled { get; set; }

        /// <summary>Whether user installation of apps is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installAppsDisabled")]
        public virtual System.Nullable<bool> InstallAppsDisabled { get; set; }

        /// <summary>This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installUnknownSourcesAllowed")]
        public virtual System.Nullable<bool> InstallUnknownSourcesAllowed { get; set; }

        /// <summary>Whether the keyguard is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyguardDisabled")]
        public virtual System.Nullable<bool> KeyguardDisabled { get; set; }

        /// <summary>Disabled keyguard customizations, such as widgets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyguardDisabledFeatures")]
        public virtual System.Collections.Generic.IList<string> KeyguardDisabledFeatures { get; set; }

        /// <summary>
        /// Whether the kiosk custom launcher is enabled. This replaces the home screen with a launcher that locks down
        /// the device to the apps installed via the applications setting. Apps appear on a single page in alphabetical
        /// order. Use kioskCustomization to further configure the kiosk device behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kioskCustomLauncherEnabled")]
        public virtual System.Nullable<bool> KioskCustomLauncherEnabled { get; set; }

        /// <summary>
        /// Settings controlling the behavior of a device in kiosk mode. To enable kiosk mode, set
        /// kioskCustomLauncherEnabled to true or specify an app in the policy with installType KIOSK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kioskCustomization")]
        public virtual KioskCustomization KioskCustomization { get; set; }

        /// <summary>The degree of location detection enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationMode")]
        public virtual string LocationMode { get; set; }

        /// <summary>A message displayed to the user in the device administators settings screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longSupportMessage")]
        public virtual UserFacingMessage LongSupportMessage { get; set; }

        /// <summary>
        /// Maximum time in milliseconds for user activity until the device locks. A value of 0 means there is no
        /// restriction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumTimeToLock")]
        public virtual System.Nullable<long> MaximumTimeToLock { get; set; }

        /// <summary>The minimum allowed Android API level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumApiLevel")]
        public virtual System.Nullable<int> MinimumApiLevel { get; set; }

        /// <summary>Whether configuring mobile networks is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileNetworksConfigDisabled")]
        public virtual System.Nullable<bool> MobileNetworksConfigDisabled { get; set; }

        /// <summary>Whether adding or removing accounts is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifyAccountsDisabled")]
        public virtual System.Nullable<bool> ModifyAccountsDisabled { get; set; }

        /// <summary>Whether the user mounting physical external media is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPhysicalMediaDisabled")]
        public virtual System.Nullable<bool> MountPhysicalMediaDisabled { get; set; }

        /// <summary>The name of the policy in the form enterprises/{enterpriseId}/policies/{policyId}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Whether the network escape hatch is enabled. If a network connection can't be made at boot time, the escape
        /// hatch prompts the user to temporarily connect to a network in order to refresh the device policy. After
        /// applying policy, the temporary network will be forgotten and the device will continue booting. This prevents
        /// being unable to connect to a network if there is no suitable network in the last policy and the device boots
        /// into an app in lock task mode, or the user is otherwise unable to reach device settings.Note: Setting
        /// wifiConfigDisabled to true will override this setting under specific circumstances. Please see
        /// wifiConfigDisabled for further details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkEscapeHatchEnabled")]
        public virtual System.Nullable<bool> NetworkEscapeHatchEnabled { get; set; }

        /// <summary>Whether resetting network settings is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkResetDisabled")]
        public virtual System.Nullable<bool> NetworkResetDisabled { get; set; }

        /// <summary>This feature is not generally available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oncCertificateProviders")]
        public virtual System.Collections.Generic.IList<OncCertificateProvider> OncCertificateProviders { get; set; }

        /// <summary>Network configuration for the device. See configure networks for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openNetworkConfiguration")]
        public virtual System.Collections.Generic.IDictionary<string, object> OpenNetworkConfiguration { get; set; }

        /// <summary>Whether using NFC to beam data from apps is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outgoingBeamDisabled")]
        public virtual System.Nullable<bool> OutgoingBeamDisabled { get; set; }

        /// <summary>Whether outgoing calls are disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outgoingCallsDisabled")]
        public virtual System.Nullable<bool> OutgoingCallsDisabled { get; set; }

        /// <summary>
        /// Password requirement policies. Different policies can be set for work profile or fully managed devices by
        /// setting the password_scope field in the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordPolicies")]
        public virtual System.Collections.Generic.IList<PasswordRequirements> PasswordPolicies { get; set; }

        /// <summary>
        /// Password requirements. The field password_requirements.require_password_unlock must not be set. DEPRECATED -
        /// Use password_policies.Note:Complexity-based values of PasswordQuality, that is, COMPLEXITY_LOW,
        /// COMPLEXITY_MEDIUM, and COMPLEXITY_HIGH, cannot be used here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordRequirements")]
        public virtual PasswordRequirements PasswordRequirements { get; set; }

        /// <summary>
        /// Explicit permission or group grants or denials for all apps. These values override the
        /// default_permission_policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionGrants")]
        public virtual System.Collections.Generic.IList<PermissionGrant> PermissionGrants { get; set; }

        /// <summary>
        /// Specifies permitted accessibility services. If the field is not set, any accessibility service can be used.
        /// If the field is set, only the accessibility services in this list and the system's built-in accessibility
        /// service can be used. In particular, if the field is set to empty, only the system's built-in accessibility
        /// servicess can be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedAccessibilityServices")]
        public virtual PackageNameList PermittedAccessibilityServices { get; set; }

        /// <summary>
        /// If present, only the input methods provided by packages in this list are permitted. If this field is
        /// present, but the list is empty, then only system input methods are permitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permittedInputMethods")]
        public virtual PackageNameList PermittedInputMethods { get; set; }

        /// <summary>Default intent handler activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentPreferredActivities")]
        public virtual System.Collections.Generic.IList<PersistentPreferredActivity> PersistentPreferredActivities { get; set; }

        /// <summary>Policies managing personal usage on a company-owned device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personalUsagePolicies")]
        public virtual PersonalUsagePolicies PersonalUsagePolicies { get; set; }

        /// <summary>
        /// This mode controls which apps are available to the user in the Play Store and the behavior on the device
        /// when apps are removed from the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playStoreMode")]
        public virtual string PlayStoreMode { get; set; }

        /// <summary>Rules that define the behavior when a particular policy can not be applied on device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyEnforcementRules")]
        public virtual System.Collections.Generic.IList<PolicyEnforcementRule> PolicyEnforcementRules { get; set; }

        /// <summary>
        /// Allows showing UI on a device for a user to choose a private key alias if there are no matching rules in
        /// ChoosePrivateKeyRules. For devices below Android P, setting this may leave enterprise keys vulnerable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeySelectionEnabled")]
        public virtual System.Nullable<bool> PrivateKeySelectionEnabled { get; set; }

        /// <summary>
        /// The network-independent global HTTP proxy. Typically proxies should be configured per-network in
        /// open_network_configuration. However for unusual configurations like general internal filtering a global HTTP
        /// proxy may be useful. If the proxy is not accessible, network access may break. The global proxy is only a
        /// recommendation and some apps may ignore it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedGlobalProxy")]
        public virtual ProxyInfo RecommendedGlobalProxy { get; set; }

        /// <summary>Whether removing other users is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeUserDisabled")]
        public virtual System.Nullable<bool> RemoveUserDisabled { get; set; }

        /// <summary>Whether rebooting the device into safe boot is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeBootDisabled")]
        public virtual System.Nullable<bool> SafeBootDisabled { get; set; }

        /// <summary>Whether screen capture is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenCaptureDisabled")]
        public virtual System.Nullable<bool> ScreenCaptureDisabled { get; set; }

        /// <summary>Whether changing the user icon is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setUserIconDisabled")]
        public virtual System.Nullable<bool> SetUserIconDisabled { get; set; }

        /// <summary>Whether changing the wallpaper is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setWallpaperDisabled")]
        public virtual System.Nullable<bool> SetWallpaperDisabled { get; set; }

        /// <summary>Actions to take during the setup process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupActions")]
        public virtual System.Collections.Generic.IList<SetupAction> SetupActions { get; set; }

        /// <summary>Whether location sharing is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareLocationDisabled")]
        public virtual System.Nullable<bool> ShareLocationDisabled { get; set; }

        /// <summary>
        /// A message displayed to the user in the settings screen wherever functionality has been disabled by the
        /// admin. If the message is longer than 200 characters it may be truncated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortSupportMessage")]
        public virtual UserFacingMessage ShortSupportMessage { get; set; }

        /// <summary>
        /// Flag to skip hints on the first use. Enterprise admin can enable the system recommendation for apps to skip
        /// their user tutorial and other introductory hints on first start-up.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipFirstUseHintsEnabled")]
        public virtual System.Nullable<bool> SkipFirstUseHintsEnabled { get; set; }

        /// <summary>Whether sending and receiving SMS messages is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smsDisabled")]
        public virtual System.Nullable<bool> SmsDisabled { get; set; }

        /// <summary>
        /// Whether the status bar is disabled. This disables notifications, quick settings, and other screen overlays
        /// that allow escape from full-screen mode. DEPRECATED. To disable the status bar on a kiosk device, use
        /// InstallType KIOSK or kioskCustomLauncherEnabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusBarDisabled")]
        public virtual System.Nullable<bool> StatusBarDisabled { get; set; }

        /// <summary>Status reporting settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusReportingSettings")]
        public virtual StatusReportingSettings StatusReportingSettings { get; set; }

        /// <summary>
        /// The battery plugged in modes for which the device stays on. When using this setting, it is recommended to
        /// clear maximum_time_to_lock so that the device doesn't lock itself while it stays on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stayOnPluggedModes")]
        public virtual System.Collections.Generic.IList<string> StayOnPluggedModes { get; set; }

        /// <summary>
        /// The system update policy, which controls how OS updates are applied. If the update type is WINDOWED, the
        /// update window will automatically apply to Play app updates as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemUpdate")]
        public virtual SystemUpdate SystemUpdate { get; set; }

        /// <summary>Whether configuring tethering and portable hotspots is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tetheringConfigDisabled")]
        public virtual System.Nullable<bool> TetheringConfigDisabled { get; set; }

        /// <summary>Whether user uninstallation of applications is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uninstallAppsDisabled")]
        public virtual System.Nullable<bool> UninstallAppsDisabled { get; set; }

        /// <summary>Whether the microphone is muted and adjusting microphone volume is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmuteMicrophoneDisabled")]
        public virtual System.Nullable<bool> UnmuteMicrophoneDisabled { get; set; }

        /// <summary>Whether transferring files over USB is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usbFileTransferDisabled")]
        public virtual System.Nullable<bool> UsbFileTransferDisabled { get; set; }

        /// <summary>Whether USB storage is enabled. Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usbMassStorageEnabled")]
        public virtual System.Nullable<bool> UsbMassStorageEnabled { get; set; }

        /// <summary>
        /// The version of the policy. This is a read-only field. The version is incremented each time the policy is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>Whether configuring VPN is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpnConfigDisabled")]
        public virtual System.Nullable<bool> VpnConfigDisabled { get; set; }

        /// <summary>
        /// Whether configuring Wi-Fi access points is disabled.Note: If a network connection can't be made at boot time
        /// and configuring Wi-Fi is disabled then network escape hatch will be shown in order to refresh the device
        /// policy (see networkEscapeHatchEnabled).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiConfigDisabled")]
        public virtual System.Nullable<bool> WifiConfigDisabled { get; set; }

        /// <summary>DEPRECATED - Use wifi_config_disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiConfigsLockdownEnabled")]
        public virtual System.Nullable<bool> WifiConfigsLockdownEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule that defines the actions to take if a device or work profile is not compliant with the policy specified
    /// in settingName.
    /// </summary>
    public class PolicyEnforcementRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An action to block access to apps and data on a fully managed device or in a work profile. This action also
        /// triggers a user-facing notification with information (where possible) on how to correct the compliance
        /// issue. Note: wipeAction must also be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockAction")]
        public virtual BlockAction BlockAction { get; set; }

        /// <summary>The top-level policy to enforce. For example, applications or passwordPolicies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settingName")]
        public virtual string SettingName { get; set; }

        /// <summary>
        /// An action to reset a fully managed device or delete a work profile. Note: blockAction must also be
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wipeAction")]
        public virtual WipeAction WipeAction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional details regarding the security posture of the device.</summary>
    public class PostureDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Corresponding admin-facing advice to mitigate this security risk and improve the security posture of the
        /// device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advice")]
        public virtual System.Collections.Generic.IList<UserFacingMessage> Advice { get; set; }

        /// <summary>A specific security risk that negatively affects the security posture of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityRisk")]
        public virtual string SecurityRisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A power management event.</summary>
    public class PowerManagementEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For BATTERY_LEVEL_COLLECTED events, the battery level as a percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryLevel")]
        public virtual System.Nullable<float> BatteryLevel { get; set; }

        /// <summary>The creation time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Event type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration info for an HTTP proxy. For a direct proxy, set the host, port, and excluded_hosts fields. For a
    /// PAC script proxy, set the pac_uri field.
    /// </summary>
    public class ProxyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For a direct proxy, the hosts for which the proxy is bypassed. The host names may contain wildcards such as
        /// *.example.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedHosts")]
        public virtual System.Collections.Generic.IList<string> ExcludedHosts { get; set; }

        /// <summary>The host of the direct proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The URI of the PAC script used to configure the proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pacUri")]
        public virtual string PacUri { get; set; }

        /// <summary>The port of the direct proxy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The security posture of the device, as determined by the current device state and the policies applied.
    /// </summary>
    public class SecurityPosture : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device's security posture value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePosture")]
        public virtual string DevicePosture { get; set; }

        /// <summary>Additional details regarding the security posture of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDetails")]
        public virtual System.Collections.Generic.IList<PostureDetail> PostureDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An action executed during setup.</summary>
    public class SetupAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual UserFacingMessage Description { get; set; }

        /// <summary>An action to launch an app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchApp")]
        public virtual LaunchAppAction LaunchApp { get; set; }

        /// <summary>Title of this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual UserFacingMessage Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource containing sign in details for an enterprise.</summary>
    public class SigninDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Controls whether personal usage is allowed on a device provisioned with this enrollment token.For
        /// company-owned devices: Enabling personal usage allows the user to set up a work profile on the device.
        /// Disabling personal usage requires the user provision the device as a fully managed device.For
        /// personally-owned devices: Enabling personal usage allows the user to set up a work profile on the device.
        /// Disabling personal usage will prevent the device from provisioning. Personal usage cannot be disabled on
        /// personally-owned device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPersonalUsage")]
        public virtual string AllowPersonalUsage { get; set; }

        /// <summary>
        /// A JSON string whose UTF-8 representation can be used to generate a QR code to enroll a device with this
        /// enrollment token. To enroll a device using NFC, the NFC record must contain a serialized
        /// java.util.Properties representation of the properties in the JSON. This is a read-only field generated by
        /// the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qrCode")]
        public virtual string QrCode { get; set; }

        /// <summary>
        /// An enterprise wide enrollment token used to trigger custom sign-in flow. This is a read-only field generated
        /// by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signinEnrollmentToken")]
        public virtual string SigninEnrollmentToken { get; set; }

        /// <summary>
        /// Sign-in URL for authentication when device is provisioned with a sign-in enrollment token. The sign-in
        /// endpoint should finish authentication flow with a URL in the form of
        /// https://enterprise.google.com/android/enroll?et= for a successful login, or
        /// https://enterprise.google.com/android/enroll/invalid for a failed login.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signinUrl")]
        public virtual string SigninUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An enterprise signup URL.</summary>
    public class SignupUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the resource. Use this value in the signupUrl field when calling enterprises.create to complete
        /// the enterprise signup flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A URL where an enterprise admin can register their enterprise. The page can't be rendered in an iframe.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about device software.</summary>
    public class SoftwareInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Android build ID string meant for displaying to the user. For example, shamu-userdebug 6.0.1 MOB30I 2756745
        /// dev-keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidBuildNumber")]
        public virtual string AndroidBuildNumber { get; set; }

        /// <summary>Build time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidBuildTime")]
        public virtual object AndroidBuildTime { get; set; }

        /// <summary>The Android Device Policy app version code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDevicePolicyVersionCode")]
        public virtual System.Nullable<int> AndroidDevicePolicyVersionCode { get; set; }

        /// <summary>The Android Device Policy app version as displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidDevicePolicyVersionName")]
        public virtual string AndroidDevicePolicyVersionName { get; set; }

        /// <summary>The user-visible Android version string. For example, 6.0.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidVersion")]
        public virtual string AndroidVersion { get; set; }

        /// <summary>The system bootloader version number, e.g. 0.6.7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; }

        /// <summary>
        /// SHA-256 hash of android.content.pm.Signature
        /// (https://developer.android.com/reference/android/content/pm/Signature.html) associated with the system
        /// package, which can be used to verify that the system build hasn't been modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceBuildSignature")]
        public virtual string DeviceBuildSignature { get; set; }

        /// <summary>Kernel version, for example, 2.6.32.9-g103d848.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceKernelVersion")]
        public virtual string DeviceKernelVersion { get; set; }

        /// <summary>An IETF BCP 47 language code for the primary locale on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryLanguageCode")]
        public virtual string PrimaryLanguageCode { get; set; }

        /// <summary>Security patch level, e.g. 2016-05-01.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchLevel")]
        public virtual string SecurityPatchLevel { get; set; }

        /// <summary>Information about a potential pending system update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemUpdateInfo")]
        public virtual SystemUpdateInfo SystemUpdateInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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

    /// <summary>Settings controlling the behavior of status reports.</summary>
    public class StatusReportingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Application reporting settings. Only applicable if application_reports_enabled is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationReportingSettings")]
        public virtual ApplicationReportingSettings ApplicationReportingSettings { get; set; }

        /// <summary>Whether app reports are enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationReportsEnabled")]
        public virtual System.Nullable<bool> ApplicationReportsEnabled { get; set; }

        /// <summary>Whether Common Criteria Mode reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonCriteriaModeEnabled")]
        public virtual System.Nullable<bool> CommonCriteriaModeEnabled { get; set; }

        /// <summary>Whether device settings reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSettingsEnabled")]
        public virtual System.Nullable<bool> DeviceSettingsEnabled { get; set; }

        /// <summary>
        /// Whether displays reporting is enabled. Report data is not available for personally owned devices with work
        /// profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayInfoEnabled")]
        public virtual System.Nullable<bool> DisplayInfoEnabled { get; set; }

        /// <summary>
        /// Whether hardware status reporting is enabled. Report data is not available for personally owned devices with
        /// work profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareStatusEnabled")]
        public virtual System.Nullable<bool> HardwareStatusEnabled { get; set; }

        /// <summary>Whether memory reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryInfoEnabled")]
        public virtual System.Nullable<bool> MemoryInfoEnabled { get; set; }

        /// <summary>Whether network info reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInfoEnabled")]
        public virtual System.Nullable<bool> NetworkInfoEnabled { get; set; }

        /// <summary>
        /// Whether power management event reporting is enabled. Report data is not available for personally owned
        /// devices with work profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("powerManagementEventsEnabled")]
        public virtual System.Nullable<bool> PowerManagementEventsEnabled { get; set; }

        /// <summary>Whether software info reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareInfoEnabled")]
        public virtual System.Nullable<bool> SoftwareInfoEnabled { get; set; }

        /// <summary>Whether system properties reporting is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemPropertiesEnabled")]
        public virtual System.Nullable<bool> SystemPropertiesEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for managing system updates</summary>
    public class SystemUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the type is WINDOWED, the end of the maintenance window, measured as the number of minutes after midnight
        /// in device's local time. This value must be between 0 and 1439, inclusive. If this value is less than
        /// start_minutes, then the maintenance window spans midnight. If the maintenance window specified is smaller
        /// than 30 minutes, the actual window is extended to 30 minutes beyond the start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endMinutes")]
        public virtual System.Nullable<int> EndMinutes { get; set; }

        /// <summary>
        /// An annually repeating time period in which over-the-air (OTA) system updates are postponed to freeze the OS
        /// version running on a device. To prevent freezing the device indefinitely, each freeze period must be
        /// separated by at least 60 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freezePeriods")]
        public virtual System.Collections.Generic.IList<FreezePeriod> FreezePeriods { get; set; }

        /// <summary>
        /// If the type is WINDOWED, the start of the maintenance window, measured as the number of minutes after
        /// midnight in the device's local time. This value must be between 0 and 1439, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMinutes")]
        public virtual System.Nullable<int> StartMinutes { get; set; }

        /// <summary>The type of system update to configure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a potential pending system update.</summary>
    public class SystemUpdateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time when the update was first available. A zero value indicates that this field is not set. This field
        /// is set only if an update is available (that is, updateStatus is neither UPDATE_STATUS_UNKNOWN nor
        /// UP_TO_DATE).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateReceivedTime")]
        public virtual object UpdateReceivedTime { get; set; }

        /// <summary>The status of an update: whether an update exists and what type it is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateStatus")]
        public virtual string UpdateStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Telephony information associated with a given SIM card on the device. Only supported on fully managed devices
    /// starting from Android API level 23.
    /// </summary>
    public class TelephonyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The carrier name associated with this SIM card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carrierName")]
        public virtual string CarrierName { get; set; }

        /// <summary>The phone number associated with this SIM card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A terms and conditions page to be accepted during provisioning.</summary>
    public class TermsAndConditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A well-formatted HTML string. It will be parsed on the client with android.text.Html#fromHtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual UserFacingMessage Content { get; set; }

        /// <summary>A short header which appears above the HTML content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual UserFacingMessage Header { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user belonging to an enterprise.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A unique identifier you create for this user, such as user342 or asset#44418. This field must be set when
        /// the user is created and can't be updated. This field must not contain personally identifiable information
        /// (PII). This identifier must be 1024 characters or less; otherwise, the update policy request will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountIdentifier")]
        public virtual string AccountIdentifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides a user-facing message with locale info. The maximum message length is 4096 characters.
    /// </summary>
    public class UserFacingMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The default message displayed if no localized message is specified or the user's locale doesn't match with
        /// any of the localized messages. A default message must be provided if any localized messages are provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMessage")]
        public virtual string DefaultMessage { get; set; }

        /// <summary>
        /// A map containing pairs, where locale is a well-formed BCP 47 language
        /// (https://www.w3.org/International/articles/language-tags/) code, such as en-US, es-ES, or fr.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localizedMessages")]
        public virtual System.Collections.Generic.IDictionary<string, string> LocalizedMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A web app.</summary>
    public class WebApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display mode of the web app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayMode")]
        public virtual string DisplayMode { get; set; }

        /// <summary>A list of icons for the web app. Must have at least one element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icons")]
        public virtual System.Collections.Generic.IList<WebAppIcon> Icons { get; set; }

        /// <summary>
        /// The name of the web app, which is generated by the server during creation in the form
        /// enterprises/{enterpriseId}/webApps/{packageName}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The start URL, i.e. the URL that should load when the user opens the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUrl")]
        public virtual string StartUrl { get; set; }

        /// <summary>
        /// The title of the web app as displayed to the user (e.g., amongst a list of other applications, or as a label
        /// for an icon).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// The current version of the app.Note that the version can automatically increase during the lifetime of the
        /// web app, while Google does internal housekeeping to keep the web app up-to-date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<long> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An icon for a web app. Supported formats are: png, jpg and webp.</summary>
    public class WebAppIcon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The actual bytes of the image in a base64url encoded string (c.f. RFC4648, section 5 "Base 64 Encoding with
        /// URL and Filename Safe Alphabet"). - The image type can be png or jpg. - The image should ideally be square.
        /// - The image should ideally have a size of 512x512.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageData")]
        public virtual string ImageData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A web token used to access the managed Google Play iframe.</summary>
    public class WebToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The features to enable. Use this if you want to control exactly which feature(s) will be activated; leave
        /// empty to allow all features.Restrictions / things to note: - If no features are listed here, all features
        /// are enabled — this is the default behavior where you give access to all features to your admins. - This must
        /// not contain any FEATURE_UNSPECIFIED values. - Repeated values are ignored
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledFeatures")]
        public virtual System.Collections.Generic.IList<string> EnabledFeatures { get; set; }

        /// <summary>
        /// The name of the web token, which is generated by the server during creation in the form
        /// enterprises/{enterpriseId}/webTokens/{webTokenId}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The URL of the parent frame hosting the iframe with the embedded UI. To prevent XSS, the iframe may not be
        /// hosted at other URLs. The URL must use the https scheme.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFrameUrl")]
        public virtual string ParentFrameUrl { get; set; }

        /// <summary>
        /// Permissions available to an admin in the embedded UI. An admin must have all of these permissions in order
        /// to view the UI. This field is deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// The token value which is used in the hosting page to generate the iframe with the embedded UI. This is a
        /// read-only field generated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An action to reset a fully managed device or delete a work profile. Note: blockAction must also be specified.
    /// </summary>
    public class WipeAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the factory-reset protection data is preserved on the device. This setting doesn’t apply to work
        /// profiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preserveFrp")]
        public virtual System.Nullable<bool> PreserveFrp { get; set; }

        /// <summary>
        /// Number of days the policy is non-compliant before the device or work profile is wiped. wipeAfterDays must be
        /// greater than blockAfterDays.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wipeAfterDays")]
        public virtual System.Nullable<int> WipeAfterDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
