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

namespace Google.Apis.AndroidProvisioningPartner.v1
{
    /// <summary>The AndroidProvisioningPartner Service.</summary>
    public class AndroidProvisioningPartnerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidProvisioningPartnerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidProvisioningPartnerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
            Operations = new OperationsResource(this);
            Partners = new PartnersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "androiddeviceprovisioning";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://androiddeviceprovisioning.googleapis.com/";
        #else
            "https://androiddeviceprovisioning.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://androiddeviceprovisioning.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Partners resource.</summary>
        public virtual PartnersResource Partners { get; }
    }

    /// <summary>A base abstract class for AndroidProvisioningPartner requests.</summary>
    public abstract class AndroidProvisioningPartnerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AndroidProvisioningPartnerBaseServiceRequest instance.</summary>
        protected AndroidProvisioningPartnerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AndroidProvisioningPartner parameter list.</summary>
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

    /// <summary>The "customers" collection of methods.</summary>
    public class CustomersResource
    {
        private const string Resource = "customers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Configurations = new ConfigurationsResource(service);
            Devices = new DevicesResource(service);
            Dpcs = new DpcsResource(service);
        }

        /// <summary>Gets the Configurations resource.</summary>
        public virtual ConfigurationsResource Configurations { get; }

        /// <summary>The "configurations" collection of methods.</summary>
        public class ConfigurationsResource
        {
            private const string Resource = "configurations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConfigurationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new configuration. Once created, a customer can apply the configuration to devices.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The customer that manages the configuration. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new configuration. Once created, a customer can apply the configuration to devices.
            /// </summary>
            public class CreateRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer that manages the configuration. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/configurations";

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
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an unused configuration. The API call fails if the customer has devices with the configuration
            /// applied.
            /// </summary>
            /// <param name="name">
            /// Required. The configuration to delete. An API resource name in the format
            /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`. If the configuration is applied to any
            /// devices, the API call fails.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an unused configuration. The API call fails if the customer has devices with the configuration
            /// applied.
            /// </summary>
            public class DeleteRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The configuration to delete. An API resource name in the format
                /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`. If the configuration is applied to any
                /// devices, the API call fails.
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
                        Pattern = @"^customers/[^/]+/configurations/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the details of a configuration.</summary>
            /// <param name="name">
            /// Required. The configuration to get. An API resource name in the format
            /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the details of a configuration.</summary>
            public class GetRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The configuration to get. An API resource name in the format
                /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`.
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
                        Pattern = @"^customers/[^/]+/configurations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists a customer's configurations.</summary>
            /// <param name="parent">
            /// Required. The customer that manages the listed configurations. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists a customer's configurations.</summary>
            public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerListConfigurationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer that manages the listed configurations. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/configurations";

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
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }

            /// <summary>Updates a configuration's field values.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The API resource name in the format
            /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`. Assigned by the server.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a configuration's field values.</summary>
            public class PatchRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The API resource name in the format
                /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`. Assigned by the server.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The field mask applied to the target `Configuration` before updating the fields. To learn
                /// more about using field masks, read
                /// [FieldMask](/protocol-buffers/docs/reference/google.protobuf#fieldmask) in the Protocol Buffers
                /// documentation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.Configuration Body { get; set; }

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
                        Pattern = @"^customers/[^/]+/configurations/[^/]+$",
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

            /// <summary>
            /// Applies a Configuration to the device to register the device for zero-touch enrollment. After applying a
            /// configuration to a device, the device automatically provisions itself on first boot, or next factory
            /// reset.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The customer managing the device. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual ApplyConfigurationRequest ApplyConfiguration(Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerApplyConfigurationRequest body, string parent)
            {
                return new ApplyConfigurationRequest(service, body, parent);
            }

            /// <summary>
            /// Applies a Configuration to the device to register the device for zero-touch enrollment. After applying a
            /// configuration to a device, the device automatically provisions itself on first boot, or next factory
            /// reset.
            /// </summary>
            public class ApplyConfigurationRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Empty>
            {
                /// <summary>Constructs a new ApplyConfiguration request.</summary>
                public ApplyConfigurationRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerApplyConfigurationRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer managing the device. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerApplyConfigurationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "applyConfiguration";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/devices:applyConfiguration";

                /// <summary>Initializes ApplyConfiguration parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the details of a device.</summary>
            /// <param name="name">
            /// Required. The device to get. An API resource name in the format
            /// `customers/[CUSTOMER_ID]/devices/[DEVICE_ID]`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the details of a device.</summary>
            public class GetRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Device>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The device to get. An API resource name in the format
                /// `customers/[CUSTOMER_ID]/devices/[DEVICE_ID]`.
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
                        Pattern = @"^customers/[^/]+/devices/[^/]+$",
                    });
                }
            }

            /// <summary>Lists a customer's devices.</summary>
            /// <param name="parent">
            /// Required. The customer managing the devices. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists a customer's devices.</summary>
            public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerListDevicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer managing the devices. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of devices to show in a page of results. Must be between 1 and 100 inclusive.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> PageSize { get; set; }

                /// <summary>A token specifying which result page to return.</summary>
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
                        Pattern = @"^customers/[^/]+$",
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

            /// <summary>Removes a configuration from device.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The customer managing the device in the format `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual RemoveConfigurationRequest RemoveConfiguration(Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerRemoveConfigurationRequest body, string parent)
            {
                return new RemoveConfigurationRequest(service, body, parent);
            }

            /// <summary>Removes a configuration from device.</summary>
            public class RemoveConfigurationRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Empty>
            {
                /// <summary>Constructs a new RemoveConfiguration request.</summary>
                public RemoveConfigurationRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerRemoveConfigurationRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer managing the device in the format `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerRemoveConfigurationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "removeConfiguration";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/devices:removeConfiguration";

                /// <summary>Initializes RemoveConfiguration parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Unclaims a device from a customer and removes it from zero-touch enrollment. After removing a device, a
            /// customer must contact their reseller to register the device into zero-touch enrollment again.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The customer managing the device. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual UnclaimRequest Unclaim(Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerUnclaimDeviceRequest body, string parent)
            {
                return new UnclaimRequest(service, body, parent);
            }

            /// <summary>
            /// Unclaims a device from a customer and removes it from zero-touch enrollment. After removing a device, a
            /// customer must contact their reseller to register the device into zero-touch enrollment again.
            /// </summary>
            public class UnclaimRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Empty>
            {
                /// <summary>Constructs a new Unclaim request.</summary>
                public UnclaimRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerUnclaimDeviceRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer managing the device. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerUnclaimDeviceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unclaim";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/devices:unclaim";

                /// <summary>Initializes Unclaim parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Dpcs resource.</summary>
        public virtual DpcsResource Dpcs { get; }

        /// <summary>The "dpcs" collection of methods.</summary>
        public class DpcsResource
        {
            private const string Resource = "dpcs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DpcsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the DPCs (device policy controllers) that support zero-touch enrollment.</summary>
            /// <param name="parent">
            /// Required. The customer that can use the DPCs in configurations. An API resource name in the format
            /// `customers/[CUSTOMER_ID]`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the DPCs (device policy controllers) that support zero-touch enrollment.</summary>
            public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerListDpcsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The customer that can use the DPCs in configurations. An API resource name in the format
                /// `customers/[CUSTOMER_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dpcs";

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
                        Pattern = @"^customers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Lists the user's customer accounts.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the user's customer accounts.</summary>
        public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.CustomerListCustomersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of customers to show in a page of results. A number between 1 and 100 (inclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>A token specifying which result page to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/customers";

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
            }
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
        public class GetRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Operation>
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
    }

    /// <summary>The "partners" collection of methods.</summary>
    public class PartnersResource
    {
        private const string Resource = "partners";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PartnersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Customers = new CustomersResource(service);
            Devices = new DevicesResource(service);
            Vendors = new VendorsResource(service);
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>The "customers" collection of methods.</summary>
        public class CustomersResource
        {
            private const string Resource = "customers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a customer for zero-touch enrollment. After the method returns successfully, admin and owner
            /// roles can manage devices and EMM configs by calling API methods or using their zero-touch enrollment
            /// portal. The customer receives an email that welcomes them to zero-touch enrollment and explains how to
            /// sign into the portal.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource ID in the format `partners/[PARTNER_ID]` that identifies the reseller.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AndroidProvisioningPartner.v1.Data.CreateCustomerRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a customer for zero-touch enrollment. After the method returns successfully, admin and owner
            /// roles can manage devices and EMM configs by calling API methods or using their zero-touch enrollment
            /// portal. The customer receives an email that welcomes them to zero-touch enrollment and explains how to
            /// sign into the portal.
            /// </summary>
            public class CreateRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Company>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.CreateCustomerRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource ID in the format `partners/[PARTNER_ID]` that identifies the reseller.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.CreateCustomerRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/customers";

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
                        Pattern = @"^partners/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the customers that are enrolled to the reseller identified by the `partnerId` argument. This list
            /// includes customers that the reseller created and customers that enrolled themselves using the portal.
            /// </summary>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual ListRequest List(long partnerId)
            {
                return new ListRequest(service, partnerId);
            }

            /// <summary>
            /// Lists the customers that are enrolled to the reseller identified by the `partnerId` argument. This list
            /// includes customers that the reseller created and customers that enrolled themselves using the portal.
            /// </summary>
            public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.ListCustomersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>
                /// The maximum number of results to be returned. If not specified or 0, all the records are returned.
                /// </summary>
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
                public override string RestPath => "v1/partners/{+partnerId}/customers";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
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

            /// <summary>
            /// Claims a device for a customer and adds it to zero-touch enrollment. If the device is already claimed by
            /// another customer, the call returns an error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual ClaimRequest Claim(Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDeviceRequest body, long partnerId)
            {
                return new ClaimRequest(service, body, partnerId);
            }

            /// <summary>
            /// Claims a device for a customer and adds it to zero-touch enrollment. If the device is already claimed by
            /// another customer, the call returns an error.
            /// </summary>
            public class ClaimRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDeviceResponse>
            {
                /// <summary>Constructs a new Claim request.</summary>
                public ClaimRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDeviceRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDeviceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "claim";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:claim";

                /// <summary>Initializes Claim parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Claims a batch of devices for a customer asynchronously. Adds the devices to zero-touch enrollment. To
            /// learn more, read [Long‑running batch operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual ClaimAsyncRequest ClaimAsync(Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDevicesRequest body, long partnerId)
            {
                return new ClaimAsyncRequest(service, body, partnerId);
            }

            /// <summary>
            /// Claims a batch of devices for a customer asynchronously. Adds the devices to zero-touch enrollment. To
            /// learn more, read [Long‑running batch operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            public class ClaimAsyncRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Operation>
            {
                /// <summary>Constructs a new ClaimAsync request.</summary>
                public ClaimAsyncRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDevicesRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.ClaimDevicesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "claimAsync";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:claimAsync";

                /// <summary>Initializes ClaimAsync parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>Finds devices by hardware identifiers, such as IMEI.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual FindByIdentifierRequest FindByIdentifier(Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByDeviceIdentifierRequest body, long partnerId)
            {
                return new FindByIdentifierRequest(service, body, partnerId);
            }

            /// <summary>Finds devices by hardware identifiers, such as IMEI.</summary>
            public class FindByIdentifierRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByDeviceIdentifierResponse>
            {
                /// <summary>Constructs a new FindByIdentifier request.</summary>
                public FindByIdentifierRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByDeviceIdentifierRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByDeviceIdentifierRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "findByIdentifier";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:findByIdentifier";

                /// <summary>Initializes FindByIdentifier parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Finds devices claimed for customers. The results only contain devices registered to the reseller that's
            /// identified by the `partnerId` argument. The customer's devices purchased from other resellers don't
            /// appear in the results.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual FindByOwnerRequest FindByOwner(Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByOwnerRequest body, long partnerId)
            {
                return new FindByOwnerRequest(service, body, partnerId);
            }

            /// <summary>
            /// Finds devices claimed for customers. The results only contain devices registered to the reseller that's
            /// identified by the `partnerId` argument. The customer's devices purchased from other resellers don't
            /// appear in the results.
            /// </summary>
            public class FindByOwnerRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByOwnerResponse>
            {
                /// <summary>Constructs a new FindByOwner request.</summary>
                public FindByOwnerRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByOwnerRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.FindDevicesByOwnerRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "findByOwner";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:findByOwner";

                /// <summary>Initializes FindByOwner parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>Gets a device.</summary>
            /// <param name="name">
            /// Required. The device API resource name in the format `partners/[PARTNER_ID]/devices/[DEVICE_ID]`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a device.</summary>
            public class GetRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Device>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The device API resource name in the format `partners/[PARTNER_ID]/devices/[DEVICE_ID]`.
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
                        Pattern = @"^partners/[^/]+/devices/[^/]+$",
                    });
                }
            }

            /// <summary>Updates reseller metadata associated with the device.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="metadataOwnerId">
            /// Required. The owner of the newly set metadata. Set this to the partner ID.
            /// </param>
            /// <param name="deviceId">Required. The ID of the device.</param>
            public virtual MetadataRequest Metadata(Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataRequest body, long metadataOwnerId, long deviceId)
            {
                return new MetadataRequest(service, body, metadataOwnerId, deviceId);
            }

            /// <summary>Updates reseller metadata associated with the device.</summary>
            public class MetadataRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.DeviceMetadata>
            {
                /// <summary>Constructs a new Metadata request.</summary>
                public MetadataRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataRequest body, long metadataOwnerId, long deviceId) : base(service)
                {
                    MetadataOwnerId = metadataOwnerId;
                    DeviceId = deviceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The owner of the newly set metadata. Set this to the partner ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metadataOwnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long MetadataOwnerId { get; private set; }

                /// <summary>Required. The ID of the device.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long DeviceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "metadata";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+metadataOwnerId}/devices/{+deviceId}/metadata";

                /// <summary>Initializes Metadata parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("metadataOwnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metadataOwnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                    RequestParameters.Add("deviceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>Unclaims a device from a customer and removes it from zero-touch enrollment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The ID of the reseller partner.</param>
            public virtual UnclaimRequest Unclaim(Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDeviceRequest body, long partnerId)
            {
                return new UnclaimRequest(service, body, partnerId);
            }

            /// <summary>Unclaims a device from a customer and removes it from zero-touch enrollment.</summary>
            public class UnclaimRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Empty>
            {
                /// <summary>Constructs a new Unclaim request.</summary>
                public UnclaimRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDeviceRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the reseller partner.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDeviceRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unclaim";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:unclaim";

                /// <summary>Initializes Unclaim parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Unclaims a batch of devices for a customer asynchronously. Removes the devices from zero-touch
            /// enrollment. To learn more, read [Long‑running batch
            /// operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The reseller partner ID.</param>
            public virtual UnclaimAsyncRequest UnclaimAsync(Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDevicesRequest body, long partnerId)
            {
                return new UnclaimAsyncRequest(service, body, partnerId);
            }

            /// <summary>
            /// Unclaims a batch of devices for a customer asynchronously. Removes the devices from zero-touch
            /// enrollment. To learn more, read [Long‑running batch
            /// operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            public class UnclaimAsyncRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Operation>
            {
                /// <summary>Constructs a new UnclaimAsync request.</summary>
                public UnclaimAsyncRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDevicesRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The reseller partner ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.UnclaimDevicesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "unclaimAsync";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:unclaimAsync";

                /// <summary>Initializes UnclaimAsync parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Updates the reseller metadata attached to a batch of devices. This method updates devices asynchronously
            /// and returns an `Operation` that can be used to track progress. Read [Long‑running batch
            /// operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="partnerId">Required. The reseller partner ID.</param>
            public virtual UpdateMetadataAsyncRequest UpdateMetadataAsync(Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataInBatchRequest body, long partnerId)
            {
                return new UpdateMetadataAsyncRequest(service, body, partnerId);
            }

            /// <summary>
            /// Updates the reseller metadata attached to a batch of devices. This method updates devices asynchronously
            /// and returns an `Operation` that can be used to track progress. Read [Long‑running batch
            /// operations](/zero-touch/guides/how-it-works#operations).
            /// </summary>
            public class UpdateMetadataAsyncRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.Operation>
            {
                /// <summary>Constructs a new UpdateMetadataAsync request.</summary>
                public UpdateMetadataAsyncRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataInBatchRequest body, long partnerId) : base(service)
                {
                    PartnerId = partnerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The reseller partner ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("partnerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long PartnerId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidProvisioningPartner.v1.Data.UpdateDeviceMetadataInBatchRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateMetadataAsync";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/partners/{+partnerId}/devices:updateMetadataAsync";

                /// <summary>Initializes UpdateMetadataAsync parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("partnerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "partnerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Vendors resource.</summary>
        public virtual VendorsResource Vendors { get; }

        /// <summary>The "vendors" collection of methods.</summary>
        public class VendorsResource
        {
            private const string Resource = "vendors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VendorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Customers = new CustomersResource(service);
            }

            /// <summary>Gets the Customers resource.</summary>
            public virtual CustomersResource Customers { get; }

            /// <summary>The "customers" collection of methods.</summary>
            public class CustomersResource
            {
                private const string Resource = "customers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the customers of the vendor.</summary>
                /// <param name="parent">
                /// Required. The resource name in the format `partners/[PARTNER_ID]/vendors/[VENDOR_ID]`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the customers of the vendor.</summary>
                public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.ListVendorCustomersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name in the format `partners/[PARTNER_ID]/vendors/[VENDOR_ID]`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of results to be returned.</summary>
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
                    public override string RestPath => "v1/{+parent}/customers";

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
                            Pattern = @"^partners/[^/]+/vendors/[^/]+$",
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

            /// <summary>Lists the vendors of the partner.</summary>
            /// <param name="parent">Required. The resource name in the format `partners/[PARTNER_ID]`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the vendors of the partner.</summary>
            public class ListRequest : AndroidProvisioningPartnerBaseServiceRequest<Google.Apis.AndroidProvisioningPartner.v1.Data.ListVendorsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name in the format `partners/[PARTNER_ID]`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of results to be returned.</summary>
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
                public override string RestPath => "v1/{+parent}/vendors";

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
                        Pattern = @"^partners/[^/]+$",
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
namespace Google.Apis.AndroidProvisioningPartner.v1.Data
{
    /// <summary>Request message to claim a device on behalf of a customer.</summary>
    public class ClaimDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the customer for whom the device is being claimed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual System.Nullable<long> CustomerId { get; set; }

        /// <summary>Required. Required. The device identifier of the device to claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>Optional. The metadata to attach to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>Required. The section type of the device's provisioning record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing device id of the claim.</summary>
    public class ClaimDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device ID of the claimed device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>
        /// The resource name of the device in the format `partners/[PARTNER_ID]/devices/[DEVICE_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceName")]
        public virtual string DeviceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to claim devices asynchronously in batch. Claiming a device adds the device to zero-touch enrollment and
    /// shows the device in the customer's view of the portal.
    /// </summary>
    public class ClaimDevicesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of device claims.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claims")]
        public virtual System.Collections.Generic.IList<PartnerClaim> Claims { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reseller, vendor, or customer in the zero-touch reseller and customer APIs.</summary>
    public class Company : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Email address of customer's users in the admin role. Each email address must be associated with a
        /// Google Account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminEmails")]
        public virtual System.Collections.Generic.IList<string> AdminEmails { get; set; }

        /// <summary>Output only. The ID of the company. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyId")]
        public virtual System.Nullable<long> CompanyId { get; set; }

        /// <summary>
        /// Required. The name of the company. For example _XYZ Corp_. Displayed to the company's employees in the
        /// zero-touch enrollment portal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public virtual string CompanyName { get; set; }

        /// <summary>
        /// Input only. The preferred locale of the customer represented as a BCP47 language code. This field is
        /// validated on input and requests containing unsupported language codes will be rejected. Supported language
        /// codes: Arabic (ar) Chinese (Hong Kong) (zh-HK) Chinese (Simplified) (zh-CN) Chinese (Traditional) (zh-TW)
        /// Czech (cs) Danish (da) Dutch (nl) English (UK) (en-GB) English (US) (en-US) Filipino (fil) Finnish (fi)
        /// French (fr) German (de) Hebrew (iw) Hindi (hi) Hungarian (hu) Indonesian (id) Italian (it) Japanese (ja)
        /// Korean (ko) Norwegian (Bokmal) (no) Polish (pl) Portuguese (Brazil) (pt-BR) Portuguese (Portugal) (pt-PT)
        /// Russian (ru) Spanish (es) Spanish (Latin America) (es-419) Swedish (sv) Thai (th) Turkish (tr) Ukrainian
        /// (uk) Vietnamese (vi)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. The API resource name of the company. The resource name is one of the following formats: *
        /// `partners/[PARTNER_ID]/customers/[CUSTOMER_ID]` * `partners/[PARTNER_ID]/vendors/[VENDOR_ID]` *
        /// `partners/[PARTNER_ID]/vendors/[VENDOR_ID]/customers/[CUSTOMER_ID]` Assigned by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. Email address of customer's users in the owner role. At least one `owner_email` is
        /// required. Owners share the same access as admins but can also add, delete, and edit your organization's
        /// portal users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerEmails")]
        public virtual System.Collections.Generic.IList<string> OwnerEmails { get; set; }

        /// <summary>
        /// Input only. If set to true, welcome email will not be sent to the customer. It is recommended to skip the
        /// welcome email if devices will be claimed with additional DEVICE_PROTECTION service, as the customer will
        /// receive separate emails at device claim time. This field is ignored if this is not a Zero-touch customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipWelcomeEmail")]
        public virtual System.Nullable<bool> SkipWelcomeEmail { get; set; }

        /// <summary>
        /// Output only. Whether any user from the company has accepted the latest Terms of Service (ToS). See
        /// TermsStatus.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termsStatus")]
        public virtual string TermsStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A configuration collects the provisioning options for Android devices. Each configuration combines the
    /// following: * The EMM device policy controller (DPC) installed on the devices. * EMM policies enforced on the
    /// devices. * Metadata displayed on the device to help users during setup. Customers can add as many configurations
    /// as they need. However, zero-touch enrollment works best when a customer sets a default configuration that's
    /// applied to any new devices the organization purchases.
    /// </summary>
    public class Configuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the organization. Zero-touch enrollment shows this organization name to device users
        /// during device provisioning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public virtual string CompanyName { get; set; }

        /// <summary>Output only. The ID of the configuration. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationId")]
        public virtual System.Nullable<long> ConfigurationId { get; set; }

        /// <summary>
        /// Required. A short name that describes the configuration's purpose. For example, _Sales team_ or _Temporary
        /// employees_. The zero-touch enrollment portal displays this name to IT admins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurationName")]
        public virtual string ConfigurationName { get; set; }

        /// <summary>
        /// Required. The email address that device users can contact to get help. Zero-touch enrollment shows this
        /// email address to device users before device provisioning. The value is validated on input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>
        /// Required. The telephone number that device users can call, using another device, to get help. Zero-touch
        /// enrollment shows this number to device users before device provisioning. Accepts numerals, spaces, the plus
        /// sign, hyphens, and parentheses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactPhone")]
        public virtual string ContactPhone { get; set; }

        /// <summary>
        /// A message, containing one or two sentences, to help device users get help or give them more details about
        /// what’s happening to their device. Zero-touch enrollment shows this message before the device is provisioned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMessage")]
        public virtual string CustomMessage { get; set; }

        /// <summary>The JSON-formatted EMM provisioning extras that are passed to the DPC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpcExtras")]
        public virtual string DpcExtras { get; set; }

        /// <summary>
        /// Required. The resource name of the selected DPC (device policy controller) in the format
        /// `customers/[CUSTOMER_ID]/dpcs/*`. To list the supported DPCs, call `customers.dpcs.list`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpcResourcePath")]
        public virtual string DpcResourcePath { get; set; }

        /// <summary>
        /// Required. Whether this is the default configuration that zero-touch enrollment applies to any new devices
        /// the organization purchases in the future. Only one customer configuration can be the default. Setting this
        /// value to `true`, changes the previous default configuration's `isDefault` value to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>
        /// Output only. The API resource name in the format
        /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`. Assigned by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to create a customer.</summary>
    public class CreateCustomerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The company data to populate the new customer. Must contain a value for `companyName` and at least
        /// one `owner_email` that's associated with a Google Account. The values for `companyId` and `name` must be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual Company Customer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for customer to assign a configuration to device.</summary>
    public class CustomerApplyConfigurationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The configuration applied to the device in the format
        /// `customers/[CUSTOMER_ID]/configurations/[CONFIGURATION_ID]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual string Configuration { get; set; }

        /// <summary>Required. The device the configuration is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual DeviceReference Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message of customer's listing configuration.</summary>
    public class CustomerListConfigurationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurations")]
        public virtual System.Collections.Generic.IList<Configuration> Configurations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing my customers.</summary>
    public class CustomerListCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The customer accounts the calling user is a member of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customers")]
        public virtual System.Collections.Generic.IList<Company> Customers { get; set; }

        /// <summary>
        /// A token used to access the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message of customer's liting devices.</summary>
    public class CustomerListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The customer's devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>
        /// A token used to access the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message of customer's listing DPCs.</summary>
    public class CustomerListDpcsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DPCs available to the customer that support zero-touch enrollment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpcs")]
        public virtual System.Collections.Generic.IList<Dpc> Dpcs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for customer to remove the configuration from device.</summary>
    public class CustomerRemoveConfigurationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The device to remove the configuration from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual DeviceReference Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for customer to unclaim a device.</summary>
    public class CustomerUnclaimDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The device to unclaim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual DeviceReference Device { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Android device registered for zero-touch enrollment.</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The provisioning claims for a device. Devices claimed for zero-touch enrollment have a claim
        /// with the type `SECTION_TYPE_ZERO_TOUCH`. Call `partners.devices.unclaim` or `partners.devices.unclaimAsync`
        /// to remove the device from zero-touch enrollment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claims")]
        public virtual System.Collections.Generic.IList<DeviceClaim> Claims { get; set; }

        /// <summary>Not available to resellers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual string Configuration { get; set; }

        /// <summary>Output only. The ID of the device. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>
        /// The hardware IDs that identify a manufactured device. To learn more, read
        /// [Identifiers](https://developers.google.com/zero-touch/guides/identifiers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>
        /// The metadata attached to the device. Structured as key-value pairs. To learn more, read [Device
        /// metadata](https://developers.google.com/zero-touch/guides/metadata).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>
        /// Output only. The API resource name in the format `partners/[PARTNER_ID]/devices/[DEVICE_ID]`. Assigned by
        /// the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A record of a device claimed by a reseller for a customer. Devices claimed for zero-touch enrollment have a
    /// claim with the type `SECTION_TYPE_ZERO_TOUCH`. To learn more, read [Claim devices for
    /// customers](/zero-touch/guides/how-it-works#claim).
    /// </summary>
    public class DeviceClaim : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Customer that purchased the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerCompanyId")]
        public virtual System.Nullable<long> OwnerCompanyId { get; set; }

        /// <summary>The ID of the reseller that claimed the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resellerId")]
        public virtual System.Nullable<long> ResellerId { get; set; }

        /// <summary>Output only. The type of claim made on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>
        /// The timestamp when the device will exit ‘vacation mode’. This value is present iff the device is in
        /// 'vacation mode'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeExpireTime")]
        public virtual object VacationModeExpireTime { get; set; }

        /// <summary>
        /// The timestamp when the device was put into ‘vacation mode’. This value is present iff the device is in
        /// 'vacation mode'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeStartTime")]
        public virtual object VacationModeStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates hardware and product IDs to identify a manufactured device. To understand requirements on
    /// identifier sets, read [Identifiers](https://developers.google.com/zero-touch/guides/identifiers).
    /// </summary>
    public class DeviceIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device’s IMEI number. Validated on input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>
        /// The device manufacturer’s name. Matches the device's built-in value returned from
        /// `android.os.Build.MANUFACTURER`. Allowed values are listed in
        /// [manufacturers](/zero-touch/resources/manufacturer-names#manufacturers-names).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>The device’s MEID number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>
        /// The device model's name. Matches the device's built-in value returned from `android.os.Build.MODEL`. Allowed
        /// values are listed in [models](/zero-touch/resources/manufacturer-names#model-names).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// The manufacturer's serial number for the device. This value might not be unique across different device
        /// models.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata entries that can be attached to a `Device`. To learn more, read [Device
    /// metadata](https://developers.google.com/zero-touch/guides/metadata).
    /// </summary>
    public class DeviceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata entries recorded as key-value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IDictionary<string, string> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `DeviceReference` is an API abstraction that lets you supply a _device_ argument to a method using one of the
    /// following identifier types: * A numeric API resource ID. * Real-world hardware IDs, such as IMEI number,
    /// belonging to the manufactured device. Methods that operate on devices take a `DeviceReference` as a parameter
    /// type because it's more flexible for the caller. To learn more about device identifiers, read
    /// [Identifiers](https://developers.google.com/zero-touch/guides/identifiers).
    /// </summary>
    public class DeviceReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>The hardware IDs of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tracks the status of a long-running operation to asynchronously update a batch of reseller metadata attached to
    /// devices. To learn more, read [Long‑running batch operations](/zero-touch/guides/how-it-works#operations).
    /// </summary>
    public class DevicesLongRunningOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of metadata updates in the operation. This might be different from the number of updates in the
        /// request if the API can't parse some of the updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicesCount")]
        public virtual System.Nullable<int> DevicesCount { get; set; }

        /// <summary>The processing status of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingStatus")]
        public virtual string ProcessingStatus { get; set; }

        /// <summary>
        /// The processing progress of the operation. Measured as a number from 0 to 100. A value of 10O doesnt always
        /// mean the operation completed—check for the inclusion of a `done` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual System.Nullable<int> Progress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tracks the status of a long-running operation to claim, unclaim, or attach metadata to devices. To learn more,
    /// read [Long‑running batch operations](/zero-touch/guides/how-it-works#operations).
    /// </summary>
    public class DevicesLongRunningOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The processing status for each device in the operation. One `PerDeviceStatus` per device. The list order
        /// matches the items in the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perDeviceStatus")]
        public virtual System.Collections.Generic.IList<OperationPerDevice> PerDeviceStatus { get; set; }

        /// <summary>
        /// A summary of how many items in the operation the server processed successfully. Updated as the operation
        /// progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successCount")]
        public virtual System.Nullable<int> SuccessCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An EMM's DPC ([device policy controller](http://developer.android.com/work/dpc/build-dpc.html)). Zero-touch
    /// enrollment installs a DPC (listed in the `Configuration`) on a device to maintain the customer's mobile
    /// policies. All the DPCs listed by the API support zero-touch enrollment and are available in Google Play.
    /// </summary>
    public class Dpc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The title of the DPC app in Google Play. For example, _Google Apps Device Policy_. Useful in an
        /// application's user interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dpcName")]
        public virtual string DpcName { get; set; }

        /// <summary>
        /// Output only. The API resource name in the format `customers/[CUSTOMER_ID]/dpcs/[DPC_ID]`. Assigned by the
        /// server. To maintain a reference to a DPC across customer accounts, persist and match the last path component
        /// (`DPC_ID`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The DPC's Android application ID that looks like a Java package name. Zero-touch enrollment
        /// installs the DPC app onto a device using this identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to find devices.</summary>
    public class FindDevicesByDeviceIdentifierRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Required. The device identifier to search for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>
        /// Required. The maximum number of devices to show in a page of results. Must be between 1 and 100 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>A token specifying which result page to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing found devices.</summary>
    public class FindDevicesByDeviceIdentifierResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Found devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>
        /// A token used to access the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total count of items in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to find devices by customers.</summary>
    public class FindDevicesByOwnerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of customer IDs to search for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> CustomerId { get; set; }

        /// <summary>
        /// Required. The maximum number of devices to show in a page of results. Must be between 1 and 100 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>A token specifying which result page to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The section type of the device's provisioning record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing found devices.</summary>
    public class FindDevicesByOwnerResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The customer's devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>
        /// A token used to access the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total count of items in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message of all customers related to this partner.</summary>
    public class ListCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of customers related to this reseller partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customers")]
        public virtual System.Collections.Generic.IList<Company> Customers { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total count of items in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message to list customers of the vendor.</summary>
    public class ListVendorCustomersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of customers of the vendor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customers")]
        public virtual System.Collections.Generic.IList<Company> Customers { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total count of items in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message to list vendors of the partner.</summary>
    public class ListVendorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Omitted if no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total count of items in the list irrespective of pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>
        /// List of vendors of the reseller partner. Fields `name`, `companyId` and `companyName` are populated to the
        /// Company object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendors")]
        public virtual System.Collections.Generic.IList<Company> Vendors { get; set; }

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

        /// <summary>
        /// This field will always be not set if the operation is created by `claimAsync`, `unclaimAsync`, or
        /// `updateMetadataAsync`. In this case, error information for each device is set in
        /// `response.perDeviceStatus.result.status`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// This field will contain a `DevicesLongRunningOperationMetadata` object if the operation is created by
        /// `claimAsync`, `unclaimAsync`, or `updateMetadataAsync`.
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
        /// This field will contain a `DevicesLongRunningOperationResponse` object if the operation is created by
        /// `claimAsync`, `unclaimAsync`, or `updateMetadataAsync`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A task for each device in the operation. Corresponds to each device change in the request.</summary>
    public class OperationPerDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A copy of the original device-claim request received by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claim")]
        public virtual PartnerClaim Claim { get; set; }

        /// <summary>The processing result for each device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual PerDeviceStatusInBatch Result { get; set; }

        /// <summary>A copy of the original device-unclaim request received by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unclaim")]
        public virtual PartnerUnclaim Unclaim { get; set; }

        /// <summary>A copy of the original metadata-update request received by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMetadata")]
        public virtual UpdateMetadataArguments UpdateMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies one claim request.</summary>
    public class PartnerClaim : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the customer for whom the device is being claimed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual System.Nullable<long> CustomerId { get; set; }

        /// <summary>Required. Required. Device identifier of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>Required. The metadata to attach to the device at claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>Required. The section type of the device's provisioning record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies one unclaim request.</summary>
    public class PartnerUnclaim : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Device ID of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>Required. Device identifier of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>Required. The section type of the device's provisioning record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>
        /// Optional. The duration of the vacation unlock starting from when the request is processed. (1 day is treated
        /// as 24 hours)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeDays")]
        public virtual System.Nullable<int> VacationModeDays { get; set; }

        /// <summary>Optional. The expiration time of the vacation unlock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeExpireTime")]
        public virtual object VacationModeExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the processing status for each device in the operation.</summary>
    public class PerDeviceStatusInBatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If processing succeeds, the device ID of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>If processing fails, the error type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorIdentifier")]
        public virtual string ErrorIdentifier { get; set; }

        /// <summary>If processing fails, a developer message explaining what went wrong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The result status of the device after processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

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

    /// <summary>Request message to unclaim a device.</summary>
    public class UnclaimDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The device ID returned by `ClaimDevice`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>Required. The device identifier you used when you claimed this device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>Required. The section type of the device's provisioning record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>
        /// The duration of the vacation unlock starting from when the request is processed. (1 day is treated as 24
        /// hours)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeDays")]
        public virtual System.Nullable<int> VacationModeDays { get; set; }

        /// <summary>The expiration time of the vacation unlock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vacationModeExpireTime")]
        public virtual object VacationModeExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to unclaim devices asynchronously in batch.</summary>
    public class UnclaimDevicesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of devices to unclaim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unclaims")]
        public virtual System.Collections.Generic.IList<PartnerUnclaim> Unclaims { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update device metadata in batch.</summary>
    public class UpdateDeviceMetadataInBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of metadata updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updates")]
        public virtual System.Collections.Generic.IList<UpdateMetadataArguments> Updates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to set metadata for a device.</summary>
    public class UpdateDeviceMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The metadata to attach to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies metadata updates to one device.</summary>
    public class UpdateMetadataArguments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Device ID of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>Required. Device identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIdentifier")]
        public virtual DeviceIdentifier DeviceIdentifier { get; set; }

        /// <summary>Required. The metadata to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
