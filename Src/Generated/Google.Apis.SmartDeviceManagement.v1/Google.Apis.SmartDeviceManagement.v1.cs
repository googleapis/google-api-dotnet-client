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

namespace Google.Apis.SmartDeviceManagement.v1
{
    /// <summary>The SmartDeviceManagement Service.</summary>
    public class SmartDeviceManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SmartDeviceManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SmartDeviceManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Enterprises = new EnterprisesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "smartdevicemanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://smartdevicemanagement.googleapis.com/";
        #else
            "https://smartdevicemanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://smartdevicemanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Smart Device Management API.</summary>
        public class Scope
        {
            /// <summary>See and/or control the devices that you selected</summary>
            public static string SdmService = "https://www.googleapis.com/auth/sdm.service";

            /// <summary>See and control the Nest thermostats that you select</summary>
            public static string SdmThermostatService = "https://www.googleapis.com/auth/sdm.thermostat.service";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Smart Device Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See and/or control the devices that you selected</summary>
            public const string SdmService = "https://www.googleapis.com/auth/sdm.service";

            /// <summary>See and control the Nest thermostats that you select</summary>
            public const string SdmThermostatService = "https://www.googleapis.com/auth/sdm.thermostat.service";
        }

        /// <summary>Gets the Enterprises resource.</summary>
        public virtual EnterprisesResource Enterprises { get; }
    }

    /// <summary>A base abstract class for SmartDeviceManagement requests.</summary>
    public abstract class SmartDeviceManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SmartDeviceManagementBaseServiceRequest instance.</summary>
        protected SmartDeviceManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SmartDeviceManagement parameter list.</summary>
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
            Devices = new DevicesResource(service);
            Structures = new StructuresResource(service);
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

            /// <summary>Executes a command to device managed by the enterprise.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the device requested. For example: "enterprises/XYZ/devices/123"</param>
            public virtual ExecuteCommandRequest ExecuteCommand(Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandRequest body, string name)
            {
                return new ExecuteCommandRequest(service, body, name);
            }

            /// <summary>Executes a command to device managed by the enterprise.</summary>
            public class ExecuteCommandRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandResponse>
            {
                /// <summary>Constructs a new ExecuteCommand request.</summary>
                public ExecuteCommandRequest(Google.Apis.Services.IClientService service, Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the device requested. For example: "enterprises/XYZ/devices/123"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "executeCommand";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:executeCommand";

                /// <summary>Initializes ExecuteCommand parameter list.</summary>
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

            /// <summary>Gets a device managed by the enterprise.</summary>
            /// <param name="name">The name of the device requested. For example: "enterprises/XYZ/devices/123"</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a device managed by the enterprise.</summary>
            public class GetRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1Device>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the device requested. For example: "enterprises/XYZ/devices/123"</summary>
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

            /// <summary>Lists devices managed by the enterprise.</summary>
            /// <param name="parent">The parent enterprise to list devices under. E.g. "enterprises/XYZ".</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists devices managed by the enterprise.</summary>
            public class ListRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ListDevicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>The parent enterprise to list devices under. E.g. "enterprises/XYZ".</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional filter to list devices. Filters can be done on: Device custom name (substring match):
                /// 'customName=wing'
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional requested page size. Server may return fewer devices than requested. If unspecified, server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional token of the page to retrieve.</summary>
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

        /// <summary>Gets the Structures resource.</summary>
        public virtual StructuresResource Structures { get; }

        /// <summary>The "structures" collection of methods.</summary>
        public class StructuresResource
        {
            private const string Resource = "structures";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public StructuresResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Rooms = new RoomsResource(service);
            }

            /// <summary>Gets the Rooms resource.</summary>
            public virtual RoomsResource Rooms { get; }

            /// <summary>The "rooms" collection of methods.</summary>
            public class RoomsResource
            {
                private const string Resource = "rooms";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RoomsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a room managed by the enterprise.</summary>
                /// <param name="name">
                /// The name of the room requested. For example: "enterprises/XYZ/structures/ABC/rooms/123".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a room managed by the enterprise.</summary>
                public class GetRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1Room>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the room requested. For example: "enterprises/XYZ/structures/ABC/rooms/123".
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
                            Pattern = @"^enterprises/[^/]+/structures/[^/]+/rooms/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists rooms managed by the enterprise.</summary>
                /// <param name="parent">
                /// The parent resource name of the rooms requested. For example: "enterprises/XYZ/structures/ABC".
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists rooms managed by the enterprise.</summary>
                public class ListRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ListRoomsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent resource name of the rooms requested. For example: "enterprises/XYZ/structures/ABC".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer rooms than requested. If unspecified, server will
                    /// pick an appropriate default.
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
                    public override string RestPath => "v1/{+parent}/rooms";

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
                            Pattern = @"^enterprises/[^/]+/structures/[^/]+$",
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

            /// <summary>Gets a structure managed by the enterprise.</summary>
            /// <param name="name">
            /// The name of the structure requested. For example: "enterprises/XYZ/structures/ABC".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a structure managed by the enterprise.</summary>
            public class GetRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1Structure>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the structure requested. For example: "enterprises/XYZ/structures/ABC".
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
                        Pattern = @"^enterprises/[^/]+/structures/[^/]+$",
                    });
                }
            }

            /// <summary>Lists structures managed by the enterprise.</summary>
            /// <param name="parent">The parent enterprise to list structures under. E.g. "enterprises/XYZ".</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists structures managed by the enterprise.</summary>
            public class ListRequest : SmartDeviceManagementBaseServiceRequest<Google.Apis.SmartDeviceManagement.v1.Data.GoogleHomeEnterpriseSdmV1ListStructuresResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>The parent enterprise to list structures under. E.g. "enterprises/XYZ".</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional filter to list structures.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Requested page size. Server may return fewer structures than requested. If unspecified, server will
                /// pick an appropriate default.
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
                public override string RestPath => "v1/{+parent}/structures";

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
namespace Google.Apis.SmartDeviceManagement.v1.Data
{
    /// <summary>Device resource represents an instance of enterprise managed device in the property.</summary>
    public class GoogleHomeEnterpriseSdmV1Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name of the device. For example: "enterprises/XYZ/devices/123".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Assignee details of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentRelations")]
        public virtual System.Collections.Generic.IList<GoogleHomeEnterpriseSdmV1ParentRelation> ParentRelations { get; set; }

        /// <summary>Output only. Device traits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traits")]
        public virtual System.Collections.Generic.IDictionary<string, object> Traits { get; set; }

        /// <summary>
        /// Output only. Type of the device for general display purposes. For example: "THERMOSTAT". The device type
        /// should not be used to deduce or infer functionality of the actual device it is assigned to. Instead, use the
        /// returned traits for the device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SmartDeviceManagementService.ExecuteDeviceCommand</summary>
    public class GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The command name to execute, represented by the fully qualified protobuf message name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>The command message to execute, represented as a Struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, object> Params__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SmartDeviceManagementService.ExecuteDeviceCommand</summary>
    public class GoogleHomeEnterpriseSdmV1ExecuteDeviceCommandResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The results of executing the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IDictionary<string, object> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SmartDeviceManagementService.ListDevices</summary>
    public class GoogleHomeEnterpriseSdmV1ListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<GoogleHomeEnterpriseSdmV1Device> Devices { get; set; }

        /// <summary>The pagination token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SmartDeviceManagementService.ListRooms</summary>
    public class GoogleHomeEnterpriseSdmV1ListRoomsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If this field is omitted, there are no subsequent
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of rooms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rooms")]
        public virtual System.Collections.Generic.IList<GoogleHomeEnterpriseSdmV1Room> Rooms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SmartDeviceManagementService.ListStructures</summary>
    public class GoogleHomeEnterpriseSdmV1ListStructuresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If this field is omitted, there are no subsequent
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of structures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structures")]
        public virtual System.Collections.Generic.IList<GoogleHomeEnterpriseSdmV1Structure> Structures { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents device relationships, for instance, structure/room to which the device is assigned to.
    /// </summary>
    public class GoogleHomeEnterpriseSdmV1ParentRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The custom name of the relation -- e.g., structure/room where the device is assigned to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The name of the relation -- e.g., structure/room where the device is assigned to. For example:
        /// "enterprises/XYZ/structures/ABC" or "enterprises/XYZ/structures/ABC/rooms/123"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Room resource represents an instance of sub-space within a structure such as rooms in a hotel suite or rental
    /// apartment.
    /// </summary>
    public class GoogleHomeEnterpriseSdmV1Room : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the room. For example: "enterprises/XYZ/structures/ABC/rooms/123".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Room traits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traits")]
        public virtual System.Collections.Generic.IDictionary<string, object> Traits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structure resource represents an instance of enterprise managed home or hotel room.</summary>
    public class GoogleHomeEnterpriseSdmV1Structure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the structure. For example: "enterprises/XYZ/structures/ABC".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Structure traits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traits")]
        public virtual System.Collections.Generic.IDictionary<string, object> Traits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
